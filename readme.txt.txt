Tyler Hanlon
Windows Software Development
Final Project

Visual Studio 2012
.NET Version 4.5


~~~~~~~~~~~Data structures:~~~~~~~~~~~~

Destinations: Saved in an Point[]. Pretty self explanatory.

Bridges: Stored as Point[]. Even nodes are more northern bridge locations, odd are southern.
	-I considered making a datastructure for them but the heuristic of even/odd was convenient and avoids having too many method calls.

Pedestrians: The Pedestrian class contains information about a PictureBox (such as its location and the color of its trail) and the destinations chosen via related ComboBoxes. When the Go button is clicked, the Form tells the Pedestrian to make a path and then starts a thread to walk along the path.



~~~~~~~~~~~Pathing~~~~~~~~~~~~~~~~~~~~~~

The GetNorth(int X, int Y) function divides the map into sections and checks if Point(X,Y) is in a given section. I made the equations to determine the sections by approximating the river's curve.

If a destination is in the same section as the current location, go straight there. If not, find the halfway point between the location and the destination and take the bridge closest to that point in the same section. Crossing a bridge moves from one section's bridge node to another section's bridge node (repeat if you're crossing an island).