namespace SEMALG_ProyectoIntegrador
{
    partial class MainWindow
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
            System.Windows.Forms.Panel Panel_ActionButtons;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Button_Reset = new System.Windows.Forms.Button();
            this.Button_About = new System.Windows.Forms.Button();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Button_Configure = new System.Windows.Forms.Button();
            this.Button_Load = new System.Windows.Forms.Button();
            this.Button_Graph = new System.Windows.Forms.Button();
            this.PictureBox_Graph = new System.Windows.Forms.PictureBox();
            this.OpenExplorer = new System.Windows.Forms.OpenFileDialog();
            this.PictureBox_Item0 = new System.Windows.Forms.PictureBox();
            this.PictureBox_Item3 = new System.Windows.Forms.PictureBox();
            this.PictureBox_Item1 = new System.Windows.Forms.PictureBox();
            this.Label_Start = new System.Windows.Forms.Label();
            this.ComboBox_Start = new System.Windows.Forms.ComboBox();
            this.Panel_Configuration = new System.Windows.Forms.Panel();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Next = new System.Windows.Forms.Button();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_PhaseTitle = new System.Windows.Forms.Label();
            this.PictureBox_Item2 = new System.Windows.Forms.PictureBox();
            this.Panel_Simulation = new System.Windows.Forms.Panel();
            this.CheckBox_Music = new System.Windows.Forms.CheckBox();
            this.Label_FirstBlood = new System.Windows.Forms.Label();
            this.Label_BestPredator = new System.Windows.Forms.Label();
            this.Label_TotalPreys = new System.Windows.Forms.Label();
            this.Label_TotalPredators = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_StateMessage = new System.Windows.Forms.Label();
            this.PictureBox_State = new System.Windows.Forms.PictureBox();
            this.Label_State = new System.Windows.Forms.Label();
            this.Button_StartSimulation = new System.Windows.Forms.Button();
            this.ComboBox_Target = new System.Windows.Forms.ComboBox();
            this.Label_Target = new System.Windows.Forms.Label();
            Panel_ActionButtons = new System.Windows.Forms.Panel();
            Panel_ActionButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Item0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Item3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Item1)).BeginInit();
            this.Panel_Configuration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Item2)).BeginInit();
            this.Panel_Simulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_State)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_ActionButtons
            // 
            Panel_ActionButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            Panel_ActionButtons.Controls.Add(this.Button_Reset);
            Panel_ActionButtons.Controls.Add(this.Button_About);
            Panel_ActionButtons.Controls.Add(this.Button_Start);
            Panel_ActionButtons.Controls.Add(this.Button_Configure);
            Panel_ActionButtons.Controls.Add(this.Button_Load);
            Panel_ActionButtons.Controls.Add(this.Button_Graph);
            Panel_ActionButtons.Location = new System.Drawing.Point(-3, 608);
            Panel_ActionButtons.Name = "Panel_ActionButtons";
            Panel_ActionButtons.Size = new System.Drawing.Size(1292, 126);
            Panel_ActionButtons.TabIndex = 0;
            // 
            // Button_Reset
            // 
            this.Button_Reset.FlatAppearance.BorderSize = 0;
            this.Button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Reset.Image = ((System.Drawing.Image)(resources.GetObject("Button_Reset.Image")));
            this.Button_Reset.Location = new System.Drawing.Point(1012, 0);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Button_Reset.Size = new System.Drawing.Size(32, 125);
            this.Button_Reset.TabIndex = 6;
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // Button_About
            // 
            this.Button_About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Button_About.FlatAppearance.BorderSize = 0;
            this.Button_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_About.Font = new System.Drawing.Font("Roboto Thin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_About.ForeColor = System.Drawing.SystemColors.Control;
            this.Button_About.Image = ((System.Drawing.Image)(resources.GetObject("Button_About.Image")));
            this.Button_About.Location = new System.Drawing.Point(1115, 0);
            this.Button_About.Name = "Button_About";
            this.Button_About.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.Button_About.Size = new System.Drawing.Size(168, 130);
            this.Button_About.TabIndex = 4;
            this.Button_About.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_About.UseVisualStyleBackColor = false;
            this.Button_About.Click += new System.EventHandler(this.Button_About_Click);
            // 
            // Button_Start
            // 
            this.Button_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Button_Start.FlatAppearance.BorderSize = 0;
            this.Button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Start.Font = new System.Drawing.Font("Roboto Thin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Start.ForeColor = System.Drawing.SystemColors.Control;
            this.Button_Start.Image = ((System.Drawing.Image)(resources.GetObject("Button_Start.Image")));
            this.Button_Start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Start.Location = new System.Drawing.Point(729, 0);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Padding = new System.Windows.Forms.Padding(15, 0, 40, 0);
            this.Button_Start.Size = new System.Drawing.Size(242, 130);
            this.Button_Start.TabIndex = 3;
            this.Button_Start.Text = "Iniciar";
            this.Button_Start.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Start.UseVisualStyleBackColor = false;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Button_Configure
            // 
            this.Button_Configure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Button_Configure.FlatAppearance.BorderSize = 0;
            this.Button_Configure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Configure.Font = new System.Drawing.Font("Roboto Thin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Configure.ForeColor = System.Drawing.SystemColors.Control;
            this.Button_Configure.Image = ((System.Drawing.Image)(resources.GetObject("Button_Configure.Image")));
            this.Button_Configure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Configure.Location = new System.Drawing.Point(486, 0);
            this.Button_Configure.Name = "Button_Configure";
            this.Button_Configure.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.Button_Configure.Size = new System.Drawing.Size(242, 130);
            this.Button_Configure.TabIndex = 2;
            this.Button_Configure.Text = "Configurar";
            this.Button_Configure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Configure.UseVisualStyleBackColor = false;
            this.Button_Configure.Click += new System.EventHandler(this.Button_Configure_Click);
            // 
            // Button_Load
            // 
            this.Button_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Button_Load.FlatAppearance.BorderSize = 0;
            this.Button_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Load.Font = new System.Drawing.Font("Roboto Thin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Load.ForeColor = System.Drawing.SystemColors.Control;
            this.Button_Load.Image = ((System.Drawing.Image)(resources.GetObject("Button_Load.Image")));
            this.Button_Load.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Load.Location = new System.Drawing.Point(0, 0);
            this.Button_Load.Name = "Button_Load";
            this.Button_Load.Padding = new System.Windows.Forms.Padding(15, 0, 40, 0);
            this.Button_Load.Size = new System.Drawing.Size(242, 130);
            this.Button_Load.TabIndex = 1;
            this.Button_Load.Text = "Cargar";
            this.Button_Load.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Load.UseVisualStyleBackColor = false;
            this.Button_Load.Click += new System.EventHandler(this.Button_Load_Click);
            // 
            // Button_Graph
            // 
            this.Button_Graph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Button_Graph.FlatAppearance.BorderSize = 0;
            this.Button_Graph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Graph.Font = new System.Drawing.Font("Roboto Thin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Graph.ForeColor = System.Drawing.SystemColors.Control;
            this.Button_Graph.Image = ((System.Drawing.Image)(resources.GetObject("Button_Graph.Image")));
            this.Button_Graph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Graph.Location = new System.Drawing.Point(243, 0);
            this.Button_Graph.Name = "Button_Graph";
            this.Button_Graph.Padding = new System.Windows.Forms.Padding(15, 0, 40, 0);
            this.Button_Graph.Size = new System.Drawing.Size(242, 130);
            this.Button_Graph.TabIndex = 0;
            this.Button_Graph.Text = "Crear\r\nGrafo";
            this.Button_Graph.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Graph.UseVisualStyleBackColor = false;
            this.Button_Graph.Click += new System.EventHandler(this.Button_Graph_Click);
            // 
            // PictureBox_Graph
            // 
            this.PictureBox_Graph.Location = new System.Drawing.Point(5, 5);
            this.PictureBox_Graph.Name = "PictureBox_Graph";
            this.PictureBox_Graph.Size = new System.Drawing.Size(780, 600);
            this.PictureBox_Graph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Graph.TabIndex = 2;
            this.PictureBox_Graph.TabStop = false;
            this.PictureBox_Graph.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBox_Graph_DragDrop);
            this.PictureBox_Graph.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox_Graph_DragEnter);
            // 
            // OpenExplorer
            // 
            this.OpenExplorer.FileName = "openFileDialog1";
            // 
            // PictureBox_Item0
            // 
            this.PictureBox_Item0.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Item0.Image")));
            this.PictureBox_Item0.Location = new System.Drawing.Point(71, 51);
            this.PictureBox_Item0.Name = "PictureBox_Item0";
            this.PictureBox_Item0.Size = new System.Drawing.Size(150, 150);
            this.PictureBox_Item0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Item0.TabIndex = 3;
            this.PictureBox_Item0.TabStop = false;
            this.PictureBox_Item0.Click += new System.EventHandler(this.PictureBox_Item0_Click);
            this.PictureBox_Item0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_Item0_MouseDown);
            this.PictureBox_Item0.MouseHover += new System.EventHandler(this.PictureBox_Item0_MouseHover);
            // 
            // PictureBox_Item3
            // 
            this.PictureBox_Item3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Item3.Image")));
            this.PictureBox_Item3.Location = new System.Drawing.Point(246, 222);
            this.PictureBox_Item3.Name = "PictureBox_Item3";
            this.PictureBox_Item3.Size = new System.Drawing.Size(150, 150);
            this.PictureBox_Item3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Item3.TabIndex = 4;
            this.PictureBox_Item3.TabStop = false;
            this.PictureBox_Item3.Click += new System.EventHandler(this.PictureBox_Item3_Click);
            this.PictureBox_Item3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_Item3_MouseDown);
            this.PictureBox_Item3.MouseHover += new System.EventHandler(this.PictureBox_Item3_MouseHover);
            // 
            // PictureBox_Item1
            // 
            this.PictureBox_Item1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Item1.Image")));
            this.PictureBox_Item1.Location = new System.Drawing.Point(246, 51);
            this.PictureBox_Item1.Name = "PictureBox_Item1";
            this.PictureBox_Item1.Size = new System.Drawing.Size(150, 150);
            this.PictureBox_Item1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Item1.TabIndex = 5;
            this.PictureBox_Item1.TabStop = false;
            this.PictureBox_Item1.Click += new System.EventHandler(this.PictureBox_Item1_Click);
            this.PictureBox_Item1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_Item1_MouseDown);
            this.PictureBox_Item1.MouseHover += new System.EventHandler(this.PictureBox_Item1_MouseHover);
            // 
            // Label_Start
            // 
            this.Label_Start.AutoSize = true;
            this.Label_Start.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Start.Location = new System.Drawing.Point(63, 415);
            this.Label_Start.Name = "Label_Start";
            this.Label_Start.Size = new System.Drawing.Size(103, 19);
            this.Label_Start.TabIndex = 6;
            this.Label_Start.Text = "Vértice Inicial";
            this.Label_Start.Visible = false;
            // 
            // ComboBox_Start
            // 
            this.ComboBox_Start.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Start.FormattingEnabled = true;
            this.ComboBox_Start.Location = new System.Drawing.Point(174, 410);
            this.ComboBox_Start.Name = "ComboBox_Start";
            this.ComboBox_Start.Size = new System.Drawing.Size(135, 27);
            this.ComboBox_Start.TabIndex = 7;
            this.ComboBox_Start.Visible = false;
            // 
            // Panel_Configuration
            // 
            this.Panel_Configuration.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Configuration.Controls.Add(this.Button_Save);
            this.Panel_Configuration.Controls.Add(this.Button_Next);
            this.Panel_Configuration.Controls.Add(this.TextBox_Name);
            this.Panel_Configuration.Controls.Add(this.Label_Name);
            this.Panel_Configuration.Controls.Add(this.Label_PhaseTitle);
            this.Panel_Configuration.Controls.Add(this.PictureBox_Item2);
            this.Panel_Configuration.Controls.Add(this.PictureBox_Item0);
            this.Panel_Configuration.Controls.Add(this.PictureBox_Item3);
            this.Panel_Configuration.Controls.Add(this.PictureBox_Item1);
            this.Panel_Configuration.Controls.Add(this.ComboBox_Start);
            this.Panel_Configuration.Controls.Add(this.Label_Start);
            this.Panel_Configuration.Location = new System.Drawing.Point(791, 5);
            this.Panel_Configuration.Name = "Panel_Configuration";
            this.Panel_Configuration.Size = new System.Drawing.Size(479, 597);
            this.Panel_Configuration.TabIndex = 10;
            this.Panel_Configuration.Visible = false;
            // 
            // Button_Save
            // 
            this.Button_Save.FlatAppearance.BorderSize = 0;
            this.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Save.Image = ((System.Drawing.Image)(resources.GetObject("Button_Save.Image")));
            this.Button_Save.Location = new System.Drawing.Point(339, 410);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(85, 85);
            this.Button_Save.TabIndex = 14;
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Visible = false;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_Next
            // 
            this.Button_Next.FlatAppearance.BorderSize = 0;
            this.Button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Next.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Next.Image = ((System.Drawing.Image)(resources.GetObject("Button_Next.Image")));
            this.Button_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Next.Location = new System.Drawing.Point(112, 528);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.Button_Next.Size = new System.Drawing.Size(253, 37);
            this.Button_Next.TabIndex = 11;
            this.Button_Next.Text = "Siguiente";
            this.Button_Next.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Next.UseVisualStyleBackColor = true;
            this.Button_Next.Visible = false;
            this.Button_Next.Click += new System.EventHandler(this.Button_Next_Click);
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(137, 463);
            this.TextBox_Name.MaxLength = 20;
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(172, 27);
            this.TextBox_Name.TabIndex = 13;
            this.TextBox_Name.Visible = false;
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.Location = new System.Drawing.Point(67, 466);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(65, 19);
            this.Label_Name.TabIndex = 12;
            this.Label_Name.Text = "Nombre";
            this.Label_Name.Visible = false;
            // 
            // Label_PhaseTitle
            // 
            this.Label_PhaseTitle.AutoSize = true;
            this.Label_PhaseTitle.Font = new System.Drawing.Font("Roboto Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PhaseTitle.Location = new System.Drawing.Point(137, 11);
            this.Label_PhaseTitle.Name = "Label_PhaseTitle";
            this.Label_PhaseTitle.Size = new System.Drawing.Size(213, 23);
            this.Label_PhaseTitle.TabIndex = 11;
            this.Label_PhaseTitle.Text = "Configuración de presas";
            // 
            // PictureBox_Item2
            // 
            this.PictureBox_Item2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Item2.Image")));
            this.PictureBox_Item2.Location = new System.Drawing.Point(71, 222);
            this.PictureBox_Item2.Name = "PictureBox_Item2";
            this.PictureBox_Item2.Size = new System.Drawing.Size(150, 150);
            this.PictureBox_Item2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Item2.TabIndex = 10;
            this.PictureBox_Item2.TabStop = false;
            this.PictureBox_Item2.Click += new System.EventHandler(this.PictureBox_Item2_Click);
            this.PictureBox_Item2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_Item2_MouseDown);
            this.PictureBox_Item2.MouseHover += new System.EventHandler(this.PictureBox_Item2_MouseHover);
            // 
            // Panel_Simulation
            // 
            this.Panel_Simulation.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Simulation.Controls.Add(this.CheckBox_Music);
            this.Panel_Simulation.Controls.Add(this.Label_FirstBlood);
            this.Panel_Simulation.Controls.Add(this.Label_BestPredator);
            this.Panel_Simulation.Controls.Add(this.Label_TotalPreys);
            this.Panel_Simulation.Controls.Add(this.Label_TotalPredators);
            this.Panel_Simulation.Controls.Add(this.label1);
            this.Panel_Simulation.Controls.Add(this.Label_StateMessage);
            this.Panel_Simulation.Controls.Add(this.PictureBox_State);
            this.Panel_Simulation.Controls.Add(this.Label_State);
            this.Panel_Simulation.Controls.Add(this.Button_StartSimulation);
            this.Panel_Simulation.Controls.Add(this.ComboBox_Target);
            this.Panel_Simulation.Controls.Add(this.Label_Target);
            this.Panel_Simulation.Location = new System.Drawing.Point(791, 5);
            this.Panel_Simulation.Name = "Panel_Simulation";
            this.Panel_Simulation.Size = new System.Drawing.Size(479, 597);
            this.Panel_Simulation.TabIndex = 15;
            this.Panel_Simulation.Visible = false;
            // 
            // CheckBox_Music
            // 
            this.CheckBox_Music.AutoSize = true;
            this.CheckBox_Music.Checked = true;
            this.CheckBox_Music.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_Music.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_Music.Location = new System.Drawing.Point(396, 571);
            this.CheckBox_Music.Name = "CheckBox_Music";
            this.CheckBox_Music.Size = new System.Drawing.Size(80, 23);
            this.CheckBox_Music.TabIndex = 16;
            this.CheckBox_Music.Text = "Música";
            this.CheckBox_Music.UseVisualStyleBackColor = true;
            this.CheckBox_Music.CheckedChanged += new System.EventHandler(this.CheckBox_Music_CheckedChanged);
            // 
            // Label_FirstBlood
            // 
            this.Label_FirstBlood.AutoSize = true;
            this.Label_FirstBlood.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FirstBlood.Location = new System.Drawing.Point(63, 514);
            this.Label_FirstBlood.Name = "Label_FirstBlood";
            this.Label_FirstBlood.Size = new System.Drawing.Size(68, 19);
            this.Label_FirstBlood.TabIndex = 10;
            this.Label_FirstBlood.Text = "Mensaje";
            // 
            // Label_BestPredator
            // 
            this.Label_BestPredator.AutoSize = true;
            this.Label_BestPredator.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BestPredator.Location = new System.Drawing.Point(63, 490);
            this.Label_BestPredator.Name = "Label_BestPredator";
            this.Label_BestPredator.Size = new System.Drawing.Size(68, 19);
            this.Label_BestPredator.TabIndex = 9;
            this.Label_BestPredator.Text = "Mensaje";
            // 
            // Label_TotalPreys
            // 
            this.Label_TotalPreys.AutoSize = true;
            this.Label_TotalPreys.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalPreys.Location = new System.Drawing.Point(63, 466);
            this.Label_TotalPreys.Name = "Label_TotalPreys";
            this.Label_TotalPreys.Size = new System.Drawing.Size(68, 19);
            this.Label_TotalPreys.TabIndex = 8;
            this.Label_TotalPreys.Text = "Mensaje";
            // 
            // Label_TotalPredators
            // 
            this.Label_TotalPredators.AutoSize = true;
            this.Label_TotalPredators.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalPredators.Location = new System.Drawing.Point(63, 442);
            this.Label_TotalPredators.Name = "Label_TotalPredators";
            this.Label_TotalPredators.Size = new System.Drawing.Size(68, 19);
            this.Label_TotalPredators.TabIndex = 7;
            this.Label_TotalPredators.Text = "Mensaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Estadísticas";
            // 
            // Label_StateMessage
            // 
            this.Label_StateMessage.AutoSize = true;
            this.Label_StateMessage.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_StateMessage.Location = new System.Drawing.Point(63, 333);
            this.Label_StateMessage.Name = "Label_StateMessage";
            this.Label_StateMessage.Size = new System.Drawing.Size(68, 19);
            this.Label_StateMessage.TabIndex = 5;
            this.Label_StateMessage.Text = "Mensaje";
            // 
            // PictureBox_State
            // 
            this.PictureBox_State.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_State.Image")));
            this.PictureBox_State.Location = new System.Drawing.Point(183, 189);
            this.PictureBox_State.Name = "PictureBox_State";
            this.PictureBox_State.Size = new System.Drawing.Size(128, 128);
            this.PictureBox_State.TabIndex = 4;
            this.PictureBox_State.TabStop = false;
            // 
            // Label_State
            // 
            this.Label_State.AutoSize = true;
            this.Label_State.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_State.Location = new System.Drawing.Point(137, 146);
            this.Label_State.Name = "Label_State";
            this.Label_State.Size = new System.Drawing.Size(214, 23);
            this.Label_State.TabIndex = 3;
            this.Label_State.Text = "Estado de la Simulación";
            // 
            // Button_StartSimulation
            // 
            this.Button_StartSimulation.FlatAppearance.BorderSize = 0;
            this.Button_StartSimulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_StartSimulation.Font = new System.Drawing.Font("Roboto Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_StartSimulation.Image = ((System.Drawing.Image)(resources.GetObject("Button_StartSimulation.Image")));
            this.Button_StartSimulation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_StartSimulation.Location = new System.Drawing.Point(263, 35);
            this.Button_StartSimulation.Name = "Button_StartSimulation";
            this.Button_StartSimulation.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.Button_StartSimulation.Size = new System.Drawing.Size(206, 64);
            this.Button_StartSimulation.TabIndex = 2;
            this.Button_StartSimulation.Text = "¡Iniciar!";
            this.Button_StartSimulation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_StartSimulation.UseVisualStyleBackColor = true;
            this.Button_StartSimulation.Click += new System.EventHandler(this.Button_StartSimulation_Click);
            // 
            // ComboBox_Target
            // 
            this.ComboBox_Target.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ComboBox_Target.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox_Target.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Target.FormattingEnabled = true;
            this.ComboBox_Target.Location = new System.Drawing.Point(54, 67);
            this.ComboBox_Target.Name = "ComboBox_Target";
            this.ComboBox_Target.Size = new System.Drawing.Size(184, 27);
            this.ComboBox_Target.TabIndex = 1;
            // 
            // Label_Target
            // 
            this.Label_Target.AutoSize = true;
            this.Label_Target.Font = new System.Drawing.Font("Roboto Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Target.Location = new System.Drawing.Point(49, 35);
            this.Label_Target.Name = "Label_Target";
            this.Label_Target.Size = new System.Drawing.Size(141, 23);
            this.Label_Target.TabIndex = 0;
            this.Label_Target.Text = "Vértice Objetivo";
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 734);
            this.Controls.Add(this.PictureBox_Graph);
            this.Controls.Add(Panel_ActionButtons);
            this.Controls.Add(this.Panel_Simulation);
            this.Controls.Add(this.Panel_Configuration);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto Integrador - Presas contra Depredadores";
            Panel_ActionButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Item0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Item3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Item1)).EndInit();
            this.Panel_Configuration.ResumeLayout(false);
            this.Panel_Configuration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Item2)).EndInit();
            this.Panel_Simulation.ResumeLayout(false);
            this.Panel_Simulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_State)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Button_Graph;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Button Button_Configure;
        private System.Windows.Forms.Button Button_Load;
        private System.Windows.Forms.Button Button_About;
        private System.Windows.Forms.OpenFileDialog OpenExplorer;
        private System.Windows.Forms.PictureBox PictureBox_Item0;
        private System.Windows.Forms.PictureBox PictureBox_Item3;
        private System.Windows.Forms.PictureBox PictureBox_Item1;
        private System.Windows.Forms.Label Label_Start;
        private System.Windows.Forms.ComboBox ComboBox_Start;
        private System.Windows.Forms.Panel Panel_Configuration;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_PhaseTitle;
        private System.Windows.Forms.PictureBox PictureBox_Item2;
        private System.Windows.Forms.Button Button_Next;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Panel Panel_Simulation;
        private System.Windows.Forms.Label Label_Target;
        private System.Windows.Forms.Button Button_StartSimulation;
        private System.Windows.Forms.Label Label_State;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Reset;
        public System.Windows.Forms.PictureBox PictureBox_Graph;
        public System.Windows.Forms.ComboBox ComboBox_Target;
        public System.Windows.Forms.Label Label_StateMessage;
        public System.Windows.Forms.PictureBox PictureBox_State;
        public System.Windows.Forms.Label Label_BestPredator;
        public System.Windows.Forms.Label Label_TotalPreys;
        public System.Windows.Forms.Label Label_TotalPredators;
        public System.Windows.Forms.Label Label_FirstBlood;
        public System.Windows.Forms.CheckBox CheckBox_Music;
    }
}

