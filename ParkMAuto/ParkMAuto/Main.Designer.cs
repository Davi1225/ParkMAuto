namespace ParkMAuto
{
    partial class Main
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
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            btnsignout = new Button();
            btnlist = new Button();
            btnsimulation = new Button();
            label1 = new Label();
            btn4wheels = new Button();
            btn2wheels = new Button();
            btn3wheels = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnsignout);
            panel1.Controls.Add(btnlist);
            panel1.Controls.Add(btnsimulation);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(672, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 462);
            panel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Lucida Console", 14.25F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ControlLight;
            button3.Location = new Point(-9, 277);
            button3.Name = "button3";
            button3.Size = new Size(326, 50);
            button3.TabIndex = 5;
            button3.Text = "About";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Lucida Console", 14.25F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlLight;
            button2.Location = new Point(-9, 326);
            button2.Name = "button2";
            button2.Size = new Size(326, 50);
            button2.TabIndex = 3;
            button2.Text = "Help";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnsignout
            // 
            btnsignout.BackColor = Color.SteelBlue;
            btnsignout.FlatStyle = FlatStyle.Popup;
            btnsignout.Location = new Point(260, 400);
            btnsignout.Name = "btnsignout";
            btnsignout.Size = new Size(36, 32);
            btnsignout.TabIndex = 2;
            btnsignout.Text = "X";
            btnsignout.UseVisualStyleBackColor = false;
            btnsignout.Click += btnsignout_Click;
            // 
            // btnlist
            // 
            btnlist.BackColor = Color.SteelBlue;
            btnlist.FlatStyle = FlatStyle.Popup;
            btnlist.Font = new Font("Lucida Console", 14.25F, FontStyle.Bold);
            btnlist.ForeColor = SystemColors.ControlLight;
            btnlist.Location = new Point(-9, 226);
            btnlist.Name = "btnlist";
            btnlist.Size = new Size(326, 52);
            btnlist.TabIndex = 1;
            btnlist.Text = "Parking List";
            btnlist.UseVisualStyleBackColor = false;
            btnlist.Click += btnlist_Click;
            // 
            // btnsimulation
            // 
            btnsimulation.BackColor = Color.SteelBlue;
            btnsimulation.FlatStyle = FlatStyle.Popup;
            btnsimulation.Font = new Font("Lucida Console", 14.25F, FontStyle.Bold);
            btnsimulation.ForeColor = SystemColors.ControlLight;
            btnsimulation.Location = new Point(-9, 177);
            btnsimulation.Name = "btnsimulation";
            btnsimulation.Size = new Size(326, 50);
            btnsimulation.TabIndex = 0;
            btnsimulation.Text = "View Simulation";
            btnsimulation.UseVisualStyleBackColor = false;
            btnsimulation.Click += btnsimulation_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GradientInactiveCaption;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(194, 36);
            label1.TabIndex = 1;
            label1.Text = "PARKMAUTO";
            label1.Click += label1_Click;
            // 
            // btn4wheels
            // 
            btn4wheels.BackColor = Color.MediumPurple;
            btn4wheels.Location = new Point(28, 191);
            btn4wheels.Name = "btn4wheels";
            btn4wheels.Size = new Size(188, 236);
            btn4wheels.TabIndex = 3;
            btn4wheels.Text = "4 - WHEELS";
            btn4wheels.UseVisualStyleBackColor = false;
            btn4wheels.Click += button1_Click;
            // 
            // btn2wheels
            // 
            btn2wheels.BackColor = Color.MediumSeaGreen;
            btn2wheels.Location = new Point(226, 191);
            btn2wheels.Name = "btn2wheels";
            btn2wheels.Size = new Size(188, 236);
            btn2wheels.TabIndex = 4;
            btn2wheels.Text = "2 - WHEELS";
            btn2wheels.UseVisualStyleBackColor = false;
            btn2wheels.Click += btn2wheels_Click;
            // 
            // btn3wheels
            // 
            btn3wheels.BackColor = Color.Gold;
            btn3wheels.Location = new Point(424, 191);
            btn3wheels.Name = "btn3wheels";
            btn3wheels.Size = new Size(188, 236);
            btn3wheels.TabIndex = 5;
            btn3wheels.Text = "3 - WHEELS";
            btn3wheels.UseVisualStyleBackColor = false;
            btn3wheels.Click += btn3wheels_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 54.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 30);
            label2.Name = "label2";
            label2.Size = new Size(617, 146);
            label2.TabIndex = 6;
            label2.Text = "FIND YOUR\r\nPARKING SPACE";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(980, 450);
            Controls.Add(label2);
            Controls.Add(btn3wheels);
            Controls.Add(btn2wheels);
            Controls.Add(btn4wheels);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button btnsignout;
        private Button btnlist;
        private Button btnsimulation;
        private Button btn4wheels;
        private Button btn2wheels;
        private Button btn3wheels;
        private Label label2;
        private Button button3;
        private Button button2;
        private Label label1;
    }
}