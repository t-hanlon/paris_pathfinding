namespace project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new project.Form1.BufferedPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.ped1_dest4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ped1_dest3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ped1_dest2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ped1_dest1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pedestrian1 = new System.Windows.Forms.PictureBox();
            this.pedestrian2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ped2_dest4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ped2_dest3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ped2_dest2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ped2_dest1 = new System.Windows.Forms.ComboBox();
            this.pedestrian3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ped3_dest4 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ped3_dest3 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ped3_dest2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ped3_dest1 = new System.Windows.Forms.ComboBox();
            this.pedestrian4 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ped4_dest4 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ped4_dest3 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ped4_dest2 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ped4_dest1 = new System.Windows.Forms.ComboBox();
            this.pedestrian5 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.ped5_dest4 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.ped5_dest3 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.ped5_dest2 = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.ped5_dest1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pedestrian1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedestrian2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedestrian3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedestrian4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedestrian5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 593);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw_Paths);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(987, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Stop 4";
            // 
            // ped1_dest4
            // 
            this.ped1_dest4.FormattingEnabled = true;
            this.ped1_dest4.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped1_dest4.Location = new System.Drawing.Point(990, 88);
            this.ped1_dest4.Name = "ped1_dest4";
            this.ped1_dest4.Size = new System.Drawing.Size(121, 21);
            this.ped1_dest4.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(855, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Stop 3";
            // 
            // ped1_dest3
            // 
            this.ped1_dest3.FormattingEnabled = true;
            this.ped1_dest3.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped1_dest3.Location = new System.Drawing.Point(858, 88);
            this.ped1_dest3.Name = "ped1_dest3";
            this.ped1_dest3.Size = new System.Drawing.Size(121, 21);
            this.ped1_dest3.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(987, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Stop 2";
            // 
            // ped1_dest2
            // 
            this.ped1_dest2.FormattingEnabled = true;
            this.ped1_dest2.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped1_dest2.Location = new System.Drawing.Point(990, 46);
            this.ped1_dest2.Name = "ped1_dest2";
            this.ped1_dest2.Size = new System.Drawing.Size(121, 21);
            this.ped1_dest2.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(855, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Stop 1";
            // 
            // ped1_dest1
            // 
            this.ped1_dest1.FormattingEnabled = true;
            this.ped1_dest1.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped1_dest1.Location = new System.Drawing.Point(858, 46);
            this.ped1_dest1.Name = "ped1_dest1";
            this.ped1_dest1.Size = new System.Drawing.Size(121, 21);
            this.ped1_dest1.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(814, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Peter";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1124, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.begin_walk);
            // 
            // pedestrian1
            // 
            this.pedestrian1.Image = global::project.Properties.Resources._351__google_guy1;
            this.pedestrian1.Location = new System.Drawing.Point(817, 55);
            this.pedestrian1.Name = "pedestrian1";
            this.pedestrian1.Size = new System.Drawing.Size(18, 28);
            this.pedestrian1.TabIndex = 30;
            this.pedestrian1.TabStop = false;
            this.pedestrian1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.begin_move);
            this.pedestrian1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.update_pos);
            this.pedestrian1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.move_end);
            // 
            // pedestrian2
            // 
            this.pedestrian2.Image = global::project.Properties.Resources._351__google_guy1;
            this.pedestrian2.Location = new System.Drawing.Point(817, 170);
            this.pedestrian2.Name = "pedestrian2";
            this.pedestrian2.Size = new System.Drawing.Size(18, 28);
            this.pedestrian2.TabIndex = 41;
            this.pedestrian2.TabStop = false;
            this.pedestrian2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.begin_move);
            this.pedestrian2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.update_pos);
            this.pedestrian2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.move_end);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1124, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "Go";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.begin_walk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(814, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Piere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(987, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Stop 4";
            // 
            // ped2_dest4
            // 
            this.ped2_dest4.FormattingEnabled = true;
            this.ped2_dest4.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped2_dest4.Location = new System.Drawing.Point(990, 203);
            this.ped2_dest4.Name = "ped2_dest4";
            this.ped2_dest4.Size = new System.Drawing.Size(121, 21);
            this.ped2_dest4.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(855, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Stop 3";
            // 
            // ped2_dest3
            // 
            this.ped2_dest3.FormattingEnabled = true;
            this.ped2_dest3.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped2_dest3.Location = new System.Drawing.Point(858, 203);
            this.ped2_dest3.Name = "ped2_dest3";
            this.ped2_dest3.Size = new System.Drawing.Size(121, 21);
            this.ped2_dest3.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(987, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Stop 2";
            // 
            // ped2_dest2
            // 
            this.ped2_dest2.FormattingEnabled = true;
            this.ped2_dest2.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped2_dest2.Location = new System.Drawing.Point(990, 161);
            this.ped2_dest2.Name = "ped2_dest2";
            this.ped2_dest2.Size = new System.Drawing.Size(121, 21);
            this.ped2_dest2.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(855, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Stop 1";
            // 
            // ped2_dest1
            // 
            this.ped2_dest1.FormattingEnabled = true;
            this.ped2_dest1.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped2_dest1.Location = new System.Drawing.Point(858, 161);
            this.ped2_dest1.Name = "ped2_dest1";
            this.ped2_dest1.Size = new System.Drawing.Size(121, 21);
            this.ped2_dest1.TabIndex = 31;
            // 
            // pedestrian3
            // 
            this.pedestrian3.Image = global::project.Properties.Resources._351__google_guy1;
            this.pedestrian3.Location = new System.Drawing.Point(817, 289);
            this.pedestrian3.Name = "pedestrian3";
            this.pedestrian3.Size = new System.Drawing.Size(18, 28);
            this.pedestrian3.TabIndex = 52;
            this.pedestrian3.TabStop = false;
            this.pedestrian3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.begin_move);
            this.pedestrian3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.update_pos);
            this.pedestrian3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.move_end);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1124, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 23);
            this.button3.TabIndex = 51;
            this.button3.Text = "Go";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.begin_walk);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(814, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Pedro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(987, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Stop 4";
            // 
            // ped3_dest4
            // 
            this.ped3_dest4.FormattingEnabled = true;
            this.ped3_dest4.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped3_dest4.Location = new System.Drawing.Point(990, 322);
            this.ped3_dest4.Name = "ped3_dest4";
            this.ped3_dest4.Size = new System.Drawing.Size(121, 21);
            this.ped3_dest4.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(855, 304);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Stop 3";
            // 
            // ped3_dest3
            // 
            this.ped3_dest3.FormattingEnabled = true;
            this.ped3_dest3.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped3_dest3.Location = new System.Drawing.Point(858, 322);
            this.ped3_dest3.Name = "ped3_dest3";
            this.ped3_dest3.Size = new System.Drawing.Size(121, 21);
            this.ped3_dest3.TabIndex = 46;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(987, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Stop 2";
            // 
            // ped3_dest2
            // 
            this.ped3_dest2.FormattingEnabled = true;
            this.ped3_dest2.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped3_dest2.Location = new System.Drawing.Point(990, 280);
            this.ped3_dest2.Name = "ped3_dest2";
            this.ped3_dest2.Size = new System.Drawing.Size(121, 21);
            this.ped3_dest2.TabIndex = 44;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(855, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Stop 1";
            // 
            // ped3_dest1
            // 
            this.ped3_dest1.FormattingEnabled = true;
            this.ped3_dest1.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped3_dest1.Location = new System.Drawing.Point(858, 280);
            this.ped3_dest1.Name = "ped3_dest1";
            this.ped3_dest1.Size = new System.Drawing.Size(121, 21);
            this.ped3_dest1.TabIndex = 42;
            // 
            // pedestrian4
            // 
            this.pedestrian4.Image = global::project.Properties.Resources._351__google_guy1;
            this.pedestrian4.Location = new System.Drawing.Point(817, 403);
            this.pedestrian4.Name = "pedestrian4";
            this.pedestrian4.Size = new System.Drawing.Size(18, 28);
            this.pedestrian4.TabIndex = 63;
            this.pedestrian4.TabStop = false;
            this.pedestrian4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.begin_move);
            this.pedestrian4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.update_pos);
            this.pedestrian4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.move_end);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1124, 413);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 23);
            this.button4.TabIndex = 62;
            this.button4.Text = "Go";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.begin_walk);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(814, 363);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 61;
            this.label16.Text = "Peeta";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(987, 418);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 60;
            this.label17.Text = "Stop 4";
            // 
            // ped4_dest4
            // 
            this.ped4_dest4.FormattingEnabled = true;
            this.ped4_dest4.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped4_dest4.Location = new System.Drawing.Point(990, 436);
            this.ped4_dest4.Name = "ped4_dest4";
            this.ped4_dest4.Size = new System.Drawing.Size(121, 21);
            this.ped4_dest4.TabIndex = 59;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(855, 418);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 58;
            this.label18.Text = "Stop 3";
            // 
            // ped4_dest3
            // 
            this.ped4_dest3.FormattingEnabled = true;
            this.ped4_dest3.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped4_dest3.Location = new System.Drawing.Point(858, 436);
            this.ped4_dest3.Name = "ped4_dest3";
            this.ped4_dest3.Size = new System.Drawing.Size(121, 21);
            this.ped4_dest3.TabIndex = 57;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(987, 376);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 56;
            this.label19.Text = "Stop 2";
            // 
            // ped4_dest2
            // 
            this.ped4_dest2.FormattingEnabled = true;
            this.ped4_dest2.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped4_dest2.Location = new System.Drawing.Point(990, 394);
            this.ped4_dest2.Name = "ped4_dest2";
            this.ped4_dest2.Size = new System.Drawing.Size(121, 21);
            this.ped4_dest2.TabIndex = 55;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(855, 376);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 54;
            this.label20.Text = "Stop 1";
            // 
            // ped4_dest1
            // 
            this.ped4_dest1.FormattingEnabled = true;
            this.ped4_dest1.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped4_dest1.Location = new System.Drawing.Point(858, 394);
            this.ped4_dest1.Name = "ped4_dest1";
            this.ped4_dest1.Size = new System.Drawing.Size(121, 21);
            this.ped4_dest1.TabIndex = 53;
            // 
            // pedestrian5
            // 
            this.pedestrian5.Image = global::project.Properties.Resources._351__google_guy1;
            this.pedestrian5.Location = new System.Drawing.Point(817, 516);
            this.pedestrian5.Name = "pedestrian5";
            this.pedestrian5.Size = new System.Drawing.Size(18, 28);
            this.pedestrian5.TabIndex = 74;
            this.pedestrian5.TabStop = false;
            this.pedestrian5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.begin_move);
            this.pedestrian5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.update_pos);
            this.pedestrian5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.move_end);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1124, 526);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 23);
            this.button5.TabIndex = 73;
            this.button5.Text = "Go";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.begin_walk);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(814, 476);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 13);
            this.label21.TabIndex = 72;
            this.label21.Text = "Martin";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(987, 531);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 13);
            this.label22.TabIndex = 71;
            this.label22.Text = "Stop 4";
            // 
            // ped5_dest4
            // 
            this.ped5_dest4.FormattingEnabled = true;
            this.ped5_dest4.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped5_dest4.Location = new System.Drawing.Point(990, 549);
            this.ped5_dest4.Name = "ped5_dest4";
            this.ped5_dest4.Size = new System.Drawing.Size(121, 21);
            this.ped5_dest4.TabIndex = 70;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(855, 531);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 13);
            this.label23.TabIndex = 69;
            this.label23.Text = "Stop 3";
            // 
            // ped5_dest3
            // 
            this.ped5_dest3.FormattingEnabled = true;
            this.ped5_dest3.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped5_dest3.Location = new System.Drawing.Point(858, 549);
            this.ped5_dest3.Name = "ped5_dest3";
            this.ped5_dest3.Size = new System.Drawing.Size(121, 21);
            this.ped5_dest3.TabIndex = 68;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(987, 489);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 13);
            this.label24.TabIndex = 67;
            this.label24.Text = "Stop 2";
            // 
            // ped5_dest2
            // 
            this.ped5_dest2.FormattingEnabled = true;
            this.ped5_dest2.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped5_dest2.Location = new System.Drawing.Point(990, 507);
            this.ped5_dest2.Name = "ped5_dest2";
            this.ped5_dest2.Size = new System.Drawing.Size(121, 21);
            this.ped5_dest2.TabIndex = 66;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(855, 489);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 13);
            this.label25.TabIndex = 65;
            this.label25.Text = "Stop 1";
            // 
            // ped5_dest1
            // 
            this.ped5_dest1.FormattingEnabled = true;
            this.ped5_dest1.Items.AddRange(new object[] {
            "1     La Conciergerie",
            "2     Notre Dame",
            "3     Ile St Louis",
            "4     Arc de Triomphe",
            "5     Musee du Louvre",
            "6     Hotel de Ville",
            "7     Musee Picasso",
            "8     Musee Pompidou",
            "9     Montmartre",
            "10   Sacre-Coeur",
            "11   Train station",
            "12   Eiffel Tower",
            "13   Musee Rodin",
            "14   Musee d\'Orsay",
            "15   Montparnasse"});
            this.ped5_dest1.Location = new System.Drawing.Point(858, 507);
            this.ped5_dest1.Name = "ped5_dest1";
            this.ped5_dest1.Size = new System.Drawing.Size(121, 21);
            this.ped5_dest1.TabIndex = 64;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 602);
            this.Controls.Add(this.pedestrian5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.ped5_dest4);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.ped5_dest3);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.ped5_dest2);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.ped5_dest1);
            this.Controls.Add(this.pedestrian4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ped4_dest4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ped4_dest3);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.ped4_dest2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.ped4_dest1);
            this.Controls.Add(this.pedestrian3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ped3_dest4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ped3_dest3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ped3_dest2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ped3_dest1);
            this.Controls.Add(this.pedestrian2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ped2_dest4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ped2_dest3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ped2_dest2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ped2_dest1);
            this.Controls.Add(this.pedestrian1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ped1_dest4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ped1_dest3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ped1_dest2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ped1_dest1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "A oui little Paris adventure";
            ((System.ComponentModel.ISupportInitialize)(this.pedestrian1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedestrian2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedestrian3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedestrian4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedestrian5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BufferedPanel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ped1_dest4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ped1_dest3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ped1_dest2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ped1_dest1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pedestrian1;
        private System.Windows.Forms.PictureBox pedestrian2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ped2_dest4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ped2_dest3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ped2_dest2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ped2_dest1;
        private System.Windows.Forms.PictureBox pedestrian3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ped3_dest4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ped3_dest3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ped3_dest2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox ped3_dest1;
        private System.Windows.Forms.PictureBox pedestrian4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox ped4_dest4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox ped4_dest3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox ped4_dest2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox ped4_dest1;
        private System.Windows.Forms.PictureBox pedestrian5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox ped5_dest4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox ped5_dest3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox ped5_dest2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox ped5_dest1;
    }
}

