using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Tyler Hanlon
 * Final Project
 * Windows Software Development
 * 
 * 
 * What lies before you is a behemouth of a final project.
 * Pedestrians run amok in Paris, leaving behind colorful trails to mark their passage.
 * An unseen controller (you) can control where they go using ComboBoxes and then drag the
 * hapless PictureBox into the streets with nothing but their destinations to guide them after you hit Go.
 * 
 * Known bugs:  -Pedestrians don't check if they're in the map to start moving
 *              -Lines tend to snap into place upon the final move to a destination. It's jerky.
 * 
 * Thanks for teaching the course, it was fun :)
 */

namespace project
{
    public partial class Form1 : Form
    {
        /* Global variables. Information about the map and destinations */
        public static Point[] locations;
        public static Point[] bridges;

        // Used to keep track of an icon that the user is currently moving
        // or placing on the the map
        PictureBox curMove;
        private Point MouseDownLocation;
        bool moving;

        //Used for moving the pedestrians simultaneously
        Thread[] runningThreads;
        Pedestrian[] ped;
        delegate void UpdatePedLocation(Point newLoc);

        /* Makes smoother drawing on our panel */
        private class BufferedPanel : Panel
        {
            public BufferedPanel()
            {
                this.DoubleBuffered = true;
            }
        }

        /* Contains methods and functions related to moving the icons around the map. */
        private class Pedestrian
        {
            //TODO: Make active true only when the Pedestrian is in the map area
            private bool active; //Does the pedestrian have points?
            private BufferedPanel container;
            private Form1 source;
            private Color lineColor;
            private PictureBox icon;
            private ComboBox[] destinations; // The ComboBoxes related to the pedestrian
            private int[] dest;
            private int numDest;
            private List<Point> destPath; //Will contain points to draw the trail they follow
            private List<Point> fullPath;

            public Pedestrian(BufferedPanel mainPanel, PictureBox movingPanel, Color color, Form1 sourceForm, ComboBox[] dests)
            {
                active = false;
                container = mainPanel;
                destinations = dests;
                source = sourceForm;
                lineColor = color;
                icon = movingPanel;
                dest = new int[]{-1,-1,-1,-1};
                numDest = 0;
                destPath = new List<Point>();
            }

            /* Adds a location "loc" at as the 'num'th destination. */
            public int addDest(int loc, int num)
            {
                if (loc >= 0 && loc < 15)
                {
                    active = true;
                    dest[num] = loc;
                    numDest++;
                    return 0;
                }
                return 1;
            }

            /**
             * Reads in all the ComboBoxes and stores their destinations if they have one
             */
            private void readDests()
            {
                addDest(destinations[0].SelectedIndex, 0);
                addDest(destinations[1].SelectedIndex, 1);
                addDest(destinations[2].SelectedIndex, 2);
                addDest(destinations[3].SelectedIndex, 3);
            }

            /* Resets all the destinations. */
            public void clearDest()
            {
                numDest = 0;
                dest[0] = -1;
                dest[1] = -1;
                dest[2] = -1;
                dest[3] = -1;
                active = false;
            }

            private int getX()
            {
                return icon.Left - container.Left;
            }

            private int getY()
            {
                return icon.Top - container.Top;
            }

            /* Finds a set of bridge points to use closest to Point (X,Y) */
            private Point[] findClosestBridge(double X, double Y, int north)
            {
                Point[] bridgePath;
                int closestBridge = 0; //0 means A, 1 : B, 2 : C, 3 : D, 4 : E
                double minPath = 9999;
                double pathLength;
                north = north/11; //0 if north, 1 if south. Never called if on an island.

                //Compares distance from the points to A, B, and C bridges.
                //+north is used because southern bridge points are always odd.
                for (int i = 0+north; i < 6; i += 2)
                {
                    pathLength = Math.Sqrt(Math.Pow(X - bridges[i].X, 2.0)
                                            + Math.Pow(Y - bridges[i].Y, 2.0));
                    if (pathLength < minPath)
                    {
                        minPath = pathLength;
                        closestBridge = i;
                    }
                }

                //Compares distance from (X,Y) to D and E bridges.
                //Only compares bridge points on the banks.
                for (int i = 6 + 3*north; i < 14; i += 4)
                {
                    pathLength = Math.Sqrt(Math.Pow(X - bridges[i].X, 2.0)
                                            + Math.Pow(Y - bridges[i].Y, 2.0));
                    if (pathLength < minPath)
                    {
                        minPath = pathLength;
                        closestBridge = i;
                    }
                }

                //A, B, and C only have two points to cross the bridge
                if (closestBridge < 6)
                {
                    bridgePath = new Point[2];
                    bridgePath[0] = bridges[closestBridge];
                    if (north == 1)
                        bridgePath[1] = bridges[closestBridge - 1];
                    else
                        bridgePath[1] = bridges[closestBridge + 1];
                }
                else //But D and E have two sets of bridges to cross.
                {
                    bridgePath = new Point[4];
                    bridgePath[0] = bridges[closestBridge];
                    if (north == 1)
                    {
                        bridgePath[1] = bridges[closestBridge - 1];
                        bridgePath[2] = bridges[closestBridge - 2];
                        bridgePath[3] = bridges[closestBridge - 3];
                    }
                    else
                    {
                        bridgePath[1] = bridges[closestBridge + 1];
                        bridgePath[2] = bridges[closestBridge + 2];
                        bridgePath[3] = bridges[closestBridge + 3];
                    }
                }

                return bridgePath;
            }

            /*
             * Makes an array of Points representing all destinations to go to
             * and any bridges that would need to be crossed to get there.
             */
            public void makePath()
            {
                int numNodes;
                int prev;
                double avX;
                double avY;
                Point prevDest;

                //Gets all the destinations
                clearDest();
                readDests();

                //Active means we're good to go.
                if(active) {

                    //Add starting point
                    destPath = new List<Point>();
                    destPath.Add(icon.Location);
                    prevDest = icon.Location;

                    //Checks where the starting point is located.
                    prev = getNorth(prevDest.X,prevDest.Y);

                    //If we start in the small area in the bottom right and would run across the river
                    if (prev == 5)
                    {
                        if ((dest[0] == -1 || (5 < dest[0] && dest[0] < 11)) || 
                            (dest[1] == -1 || (5 < dest[1] && dest[0] < 11)) || 
                            (dest[2] == -1 || (5 < dest[2] && dest[0] < 11)) ||
                            (5 < dest[3] && dest[0] < 11))
                        destPath.Add(new Point(630, 440));
                    }
                    numNodes = 1;
                    for (int i = 0; i < 4; i++)
                    {
                        if (dest[i] < 0)
                        {
                            //Do nothing because there's no destination
                        }
                        else if (locations[dest[i]] == prevDest)
                        {
                            //Don't add another point because we're already at the location
                        }
                        else // Basic state control to cross from one state (north, south, island1, island2)
                            // to another 
                        {
                            if (dest[i] < 2) //Next destination is on island 1
                            {
                                //Previous destination was:
                                if (prev < 2) //On island 1
                                {
                                    destPath.Add(locations[dest[i]]);
                                }
                                else if (prev == 2) //On island 3
                                {
                                    destPath.Add(bridges[11]);
                                    destPath.Add(bridges[10]);
                                    destPath.Add(bridges[6]);
                                    destPath.Add(bridges[7]);
                                    destPath.Add(locations[dest[i]]);
                                }
                                else if (prev < 11) //North of river
                                {
                                    destPath.Add(bridges[6]);
                                    destPath.Add(bridges[7]);
                                    destPath.Add(locations[dest[i]]);
                                }
                                else //South of river
                                {
                                    destPath.Add(bridges[9]);
                                    destPath.Add(bridges[8]);
                                    destPath.Add(locations[dest[i]]);
                                }
                            }
                            //Next destination is:
                            else if (dest[i] == 2) //On island 3
                            {
                                //Previous destination was:
                                if (prev < 2) //On island 1
                                {
                                    destPath.Add(bridges[7]);
                                    destPath.Add(bridges[6]);
                                    destPath.Add(bridges[10]);
                                    destPath.Add(bridges[11]);
                                    destPath.Add(locations[dest[i]]);
                                }
                                else if (prev == 2) //On island 3 [shouldn't happen]
                                {
                                    destPath.Add(locations[dest[i]]);
                                }
                                else if (prev < 11) //North of river
                                {
                                    destPath.Add(bridges[10]);
                                    destPath.Add(bridges[11]);
                                    destPath.Add(locations[dest[i]]);
                                }
                                else //South of river
                                {
                                    destPath.Add(bridges[13]);
                                    destPath.Add(bridges[12]);
                                    destPath.Add(locations[dest[i]]);
                                }
                            }
                            //Next destination is:
                            else if (dest[i] < 11) //North of river
                            {
                                //Previous destination was:
                                if (prev < 2) //On island 1
                                {
                                    destPath.Add(bridges[7]);
                                    destPath.Add(bridges[6]);
                                    destPath.Add(locations[dest[i]]);
                                }
                                else if (prev == 2) //On island 3
                                {
                                    destPath.Add(bridges[11]);
                                    destPath.Add(bridges[10]);
                                    destPath.Add(locations[dest[i]]);
                                }
                                else if (prev < 11) //North of river
                                {
                                    destPath.Add(locations[dest[i]]);
                                }
                                else //South of river
                                {
                                    //Average the two points, find the bridge closest to the middle.
                                    avX = (prevDest.X + locations[dest[i]].X) / 2.0;
                                    avY = (prevDest.Y + locations[dest[i]].Y) / 2.0;
                                    destPath.AddRange(findClosestBridge(avX, avY, prev));
                                    destPath.Add(locations[dest[i]]);
                                }
                            }
                            //Next destination is:
                            else //South of river
                            {
                                //Previous destination was:
                                if (prev < 2) //On island 1
                                {
                                    destPath.Add(bridges[8]);
                                    destPath.Add(bridges[9]);
                                    destPath.Add(locations[dest[i]]);
                                }
                                else if (prev == 2) //On island 3
                                {
                                    destPath.Add(bridges[12]);
                                    destPath.Add(bridges[13]);
                                    destPath.Add(locations[dest[i]]);
                                }
                                else if (prev < 11) //North of river
                                {
                                    //Average the two points, find the bridge closest to the middle.
                                    avX = (prevDest.X + locations[dest[i]].X) / 2.0;
                                    avY = (prevDest.Y + locations[dest[i]].Y) / 2.0;
                                    destPath.AddRange(findClosestBridge(avX, avY, prev));
                                    destPath.Add(locations[dest[i]]);
                                }
                                else //South of river
                                {
                                    destPath.Add(locations[dest[i]]);
                                }
                            }


                            //Now that we've added a node, increment numNodes
                            numNodes++;
                            prev = dest[i];
                            prevDest = locations[prev];
                        }
                    }
                }
            }

            //Returns if the Pedestrian is ready to walk.
            public bool getActive()
            {
                return active;
            }

            // Draws data related to the Pedestrian.
            public void Draw(PaintEventArgs e)
            {
                Pen myPen = new Pen(lineColor,3.0F);
                e.Graphics.DrawLines(myPen, fullPath.ToArray());
            }

            /*
             * Move the pedestrian along their path at a steady rate.
             * Modify the speed they move at with the double speed local parameter.
             */
            public void walk()
            {
                int curNode = 1;
                double speed = 4.0;
                int maxNode = destPath.Count;
                double xPos = icon.Left;
                double yPos = icon.Top;
                double pathLength;
                double xChange;
                double yChange;
                double numTicks;
                int curTick = 0;
                Point nextPoint;
                
                // Starts to make the line to be drawn.
                fullPath = new List<Point>();
                fullPath.Add(destPath[0]);
                fullPath.Add(new Point());
                nextPoint = destPath[1];

                // Determines how far to move per frame/tick
                pathLength = Math.Sqrt( Math.Pow(fullPath[0].X - nextPoint.X, 2.0)
                                            + Math.Pow(fullPath[0].Y - nextPoint.Y, 2.0));
                numTicks = pathLength / speed;
                xChange = (nextPoint.X - destPath[0].X) / numTicks;
                yChange = (nextPoint.Y - destPath[0].Y) / numTicks;
                while (curNode < maxNode)
                {
                    //Destination reached
                    if (icon.Left - container.Left == nextPoint.X && icon.Top - container.Top == nextPoint.Y)
                    {
                        fullPath.Add(destPath[curNode]);
                        if (curNode + 1 == maxNode)
                        {
                            return;
                        }
                        nextPoint = destPath[curNode+1];
                        pathLength = Math.Sqrt(Math.Pow(fullPath[curNode].X - nextPoint.X, 2.0)
                                            + Math.Pow(fullPath[curNode].Y - nextPoint.Y, 2.0));
                        numTicks = pathLength / speed;
                        xChange = (nextPoint.X - fullPath[curNode].X) / numTicks;
                        yChange = (nextPoint.Y - fullPath[curNode].Y) / numTicks;
                        curNode++;
                        curTick = 0;
                    }

                    else //Move a tick closer to the destination
                    {
                        if (++curTick >= numTicks) //Next tick reaches the destination, so we might move less than usual.
                        {
                            source.updatePedLocation(icon,new Point(nextPoint.X + container.Left, nextPoint.Y + container.Top));
                        }
                        else //Move the standard amount
                        {
                            xPos += xChange;
                            yPos += yChange;
                            source.updatePedLocation(icon, new Point((int)xPos, (int)yPos));
                        }
                        fullPath[curNode] = icon.Location;
                    }

                    //Redraw the line and sleep to slow down the pace.
                    container.Invalidate();
                    Thread.Sleep(5);
                } /* */
            }
        }


        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            runningThreads = new Thread[5];

            //Make our pedestrians
            ped = new Pedestrian[5];

            ped[0] = new Pedestrian(panel1, pedestrian1, Color.CadetBlue, this, 
                                    new ComboBox[]{ped1_dest1, ped1_dest2, ped1_dest3, ped1_dest4});
            ped[1] = new Pedestrian(panel1, pedestrian2, Color.DarkSeaGreen, this,
                                    new ComboBox[] { ped2_dest1, ped2_dest2, ped2_dest3, ped2_dest4 });
            ped[2] = new Pedestrian(panel1, pedestrian3, Color.DarkOrchid, this,
                                    new ComboBox[] { ped3_dest1, ped3_dest2, ped3_dest3, ped3_dest4 });
            ped[3] = new Pedestrian(panel1, pedestrian4, Color.DarkRed, this,
                                    new ComboBox[] { ped4_dest1, ped4_dest2, ped4_dest3, ped4_dest4 });
            ped[4] = new Pedestrian(panel1, pedestrian5, Color.Chocolate, this,
                                    new ComboBox[] { ped5_dest1, ped5_dest2, ped5_dest3, ped5_dest4 });

            //An attempt to position the window upon opening... I don't think it works.
            this.Top = 0;
            this.Left = 0;

            //Locations
            locations = new Point[15];
            locations[0] = new Point(478,397);
            locations[1] = new Point(530, 427);
            locations[2] = new Point(580, 443);
            locations[3] = new Point(85, 180);
            locations[4] = new Point(414, 333);
            locations[5] = new Point(540, 354);
            locations[6] = new Point(651, 343);
            locations[7] = new Point(584, 214);
            locations[8] = new Point(320, 27);
            locations[9] = new Point(490, 27);
            locations[10] = new Point(620, 100);
            locations[11] = new Point(70, 385);
            locations[12] = new Point(270, 410);
            locations[13] = new Point(385, 382);
            locations[14] = new Point(370, 580);

            //Initializes bridges
            bridges = new Point[14];
            bridges[0] = new Point(140, 284);
            bridges[1] = new Point(140, 314);
            bridges[2] = new Point(290, 290);
            bridges[3] = new Point(279, 319);
            bridges[4] = new Point(400, 340);
            bridges[5] = new Point(385, 370);
            bridges[6] = new Point(510, 375);
            bridges[7] = new Point(500, 400);
            bridges[8] = new Point(493, 410);
            bridges[9] = new Point(481, 430);
            bridges[10] = new Point(595, 425);
            bridges[11] = new Point(585, 445);
            bridges[12] = new Point(585, 445);
            bridges[13] = new Point(575, 470);
        }
        
        //Looks at (X,Y) on the form and returns its general location. Its 'region' 
        //The equations follow the river... sort of.
        //
        //Returns 1 if on the island with destination 1 and 2
        //Returns 3 if on the island with destination 3
        //Returns 4 if north of the river
        //Returns 5 if north of the river AND in the bottom right hand corner [an edge case]
        //Returns 12 if south of the river
        public static int getNorth(int xCoor, int yCoor)
        {

            if (xCoor < 550) //Left side
            {
                if (xCoor <= 285) //Far left
                {
                    if (yCoor < 300)
                    {
                        return 4;
                    }
                    else
                    {
                        return 12;
                    }
                }
                else if (xCoor < 450) //Between the far left and island 1
                {
                    if (yCoor < (300.0 + 150.0 / 315.0 * (xCoor - 285.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 12;
                    }
                }

                else //Three options: North, south, or island 1
                {
                    if (yCoor < 365.0 + 40.0 / 100.0 * (xCoor - 450)) //North
                    {
                        return 4;
                    }
                    else if (yCoor < 385.0 + 73.0 / 100.0 * (xCoor - 450)) //Island
                    {
                        return 1;
                    }
                    else //South
                    {
                        return 12;
                    }
                }
            }
            else if (xCoor < 615) //Vertical slice that contains the second island
            {
                if (yCoor < 413.0 + 37.0 / 65.0 * (xCoor - 550)) //North
                {
                    return 4;
                }
                else if (yCoor < 455.0 + 33.0 / 65.0 * (xCoor - 550)) //Island
                {
                    return 2;
                }
                else // South
                {
                    return 12;
                }
            }
            else //Right half
            {
                if (xCoor < 720) //Just past the first island
                {
                    if (yCoor < (450.0 + 146.0 / 120.0 * (xCoor - 600.0)))
                    {
                        if (yCoor > (440 + 85.0 / 180.0 * (xCoor - 620)))
                        {
                            return 5;
                        }
                        return 4;
                    }
                    else
                    {
                        return 12;
                    }
                }
                else //Only dryland. It's all north but sets a waypoint if it's far south
                {
                    if (yCoor > (440 + 85.0 / 180.0 * (xCoor - 620))) {
                        return 5;
                    }
                    else {
                        return 4;
                    }
                }
            }
        }

        //Start dragging (mousedown event)
        private void begin_move(object sender, MouseEventArgs e)
        {
            curMove = (PictureBox) sender;
            moving = true;
        }

        //Stop dragging (mouseup event)
        private void move_end(object sender, MouseEventArgs e)
        {
            moving = false;
        }

        //Drag (move mouse)
        private void update_pos(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                curMove.Location = new Point(e.X + curMove.Left - MouseDownLocation.X, e.Y + curMove.Top - MouseDownLocation.Y);
                Invalidate();
            }
        }

        //An invoked method to allow threads to update Pedestrian positions.
        private void updatePedLocation(PictureBox pedestrian, Point p)
        {
            if (InvokeRequired)
            {
                // after we've done all the processing, 
                this.Invoke(new MethodInvoker(delegate
                {
                    pedestrian.Location = p;
                }));
                return;
            }
            else
            {
                pedestrian.Location = p;
            }
        }

        /// <summary>
        /// Today I learned that triple slash is how you're supposed to do method descriptions.
        /// This one is a response to a button 'go' being hit.
        /// </summary>
        /// <param name="sender">A button</param>
        /// <param name="e">Not used.</param>
        private void begin_walk(object sender, EventArgs e)
        {
            int pedNum;
            Pedestrian p;

            //Which pedestrian does the caller button correspond to?
            if (sender.Equals(button1))
            {
                pedNum = 0;
            }
            else if (sender.Equals(button2))
            {
                pedNum = 1;
            }
            else if (sender.Equals(button3))
            {
                pedNum = 2;
            }
            else if (sender.Equals(button4))
            {
                pedNum = 3;
            }
            else if (sender.Equals(button5))
            {
                pedNum = 4;
            }
            else
            {
                return;
            }

            //Shuts down any movement the pedestrian may be making.
            if(runningThreads[pedNum] != null && runningThreads[pedNum].IsAlive)
                runningThreads[pedNum].Abort();

            //Makes a path and sends the pedestrian walking
            p = ped[pedNum];
            runningThreads[pedNum] = new Thread(p.walk);
            p.makePath();
            if (p.getActive())
            {
                runningThreads[pedNum].Start();
            }
        }

        //Replaces onPaint. Draws all the pedestrian paths.
        private void Draw_Paths(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (Pedestrian p in ped) {
                if (p.getActive())
                    p.Draw(e);
            }
        }

    }
}
