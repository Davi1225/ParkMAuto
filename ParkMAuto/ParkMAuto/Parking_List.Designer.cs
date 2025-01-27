namespace ParkMAuto
{
    partial class Parking_List
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            cmbparkingspot = new ComboBox();
            panel3 = new Panel();
            btnSimulate = new Button();
            cmbvehicletype = new ComboBox();
            cmbstatus = new ComboBox();
            btnclear = new Button();
            panel2 = new Panel();
            btnout = new Button();
            txtsearch = new TextBox();
            label9 = new Label();
            btnenter = new Button();
            btnsave = new Button();
            txtdrivername = new TextBox();
            txtcarbrand = new TextBox();
            txtplatenum = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnback = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(317, 60);
            label1.TabIndex = 2;
            label1.Text = "PARKMAUTO";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridViewCellStyle1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 55;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(391, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(979, 603);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column2
            // 
            Column2.HeaderText = "Parking Spot";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.True;
            // 
            // Column1
            // 
            Column1.HeaderText = "Status";
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.False;
            Column1.Width = 80;
            // 
            // Column3
            // 
            Column3.HeaderText = "Plate Number";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.False;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Car Brand";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Vehicle Type";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.False;
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Driver's Name";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Resizable = DataGridViewTriState.False;
            // 
            // Column7
            // 
            Column7.HeaderText = "Ticket";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Resizable = DataGridViewTriState.False;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(cmbparkingspot);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(cmbvehicletype);
            panel1.Controls.Add(cmbstatus);
            panel1.Controls.Add(btnclear);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnsave);
            panel1.Controls.Add(txtdrivername);
            panel1.Controls.Add(txtcarbrand);
            panel1.Controls.Add(txtplatenum);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(16, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 603);
            panel1.TabIndex = 4;
            // 
            // cmbparkingspot
            // 
            cmbparkingspot.Font = new Font("Rockwell", 9.75F);
            cmbparkingspot.FormattingEnabled = true;
            cmbparkingspot.Items.AddRange(new object[] { "2 Wheels", "3 Wheels", "4 Wheels" });
            cmbparkingspot.Location = new Point(164, 203);
            cmbparkingspot.Name = "cmbparkingspot";
            cmbparkingspot.Size = new Size(181, 24);
            cmbparkingspot.TabIndex = 22;
            cmbparkingspot.SelectedIndexChanged += cmbparkingspot_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(btnSimulate);
            panel3.Location = new Point(0, 525);
            panel3.Name = "panel3";
            panel3.Size = new Size(359, 78);
            panel3.TabIndex = 21;
            // 
            // btnSimulate
            // 
            btnSimulate.BackColor = SystemColors.MenuBar;
            btnSimulate.Font = new Font("Lucida Console", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimulate.Location = new Point(13, 13);
            btnSimulate.Name = "btnSimulate";
            btnSimulate.Size = new Size(332, 53);
            btnSimulate.TabIndex = 20;
            btnSimulate.Text = "SIMULATION";
            btnSimulate.UseVisualStyleBackColor = false;
            btnSimulate.Click += btnSimulate_Click;
            // 
            // cmbvehicletype
            // 
            cmbvehicletype.Font = new Font("Rockwell", 9.75F);
            cmbvehicletype.FormattingEnabled = true;
            cmbvehicletype.Items.AddRange(new object[] { "2 Wheels", "3 Wheels", "4 Wheels" });
            cmbvehicletype.Location = new Point(164, 156);
            cmbvehicletype.Name = "cmbvehicletype";
            cmbvehicletype.Size = new Size(181, 24);
            cmbvehicletype.TabIndex = 18;
            cmbvehicletype.SelectedIndexChanged += cmbvehicletype_SelectedIndexChanged;
            // 
            // cmbstatus
            // 
            cmbstatus.Font = new Font("Rockwell", 9.75F);
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Location = new Point(164, 399);
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(181, 24);
            cmbstatus.TabIndex = 19;
            cmbstatus.SelectedIndexChanged += cmbstatus_SelectedIndexChanged;
            // 
            // btnclear
            // 
            btnclear.BackColor = SystemColors.Menu;
            btnclear.Font = new Font("Rockwell", 15.75F, FontStyle.Bold);
            btnclear.Location = new Point(184, 450);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(97, 37);
            btnclear.TabIndex = 17;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btnout);
            panel2.Controls.Add(txtsearch);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btnenter);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 113);
            panel2.TabIndex = 16;
            // 
            // btnout
            // 
            btnout.BackColor = SystemColors.ButtonFace;
            btnout.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            btnout.Location = new Point(276, 19);
            btnout.Name = "btnout";
            btnout.Size = new Size(69, 32);
            btnout.TabIndex = 18;
            btnout.Text = "Out";
            btnout.UseVisualStyleBackColor = false;
            btnout.Click += btnout_Click;
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsearch.Location = new Point(13, 62);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(332, 33);
            txtsearch.TabIndex = 17;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Console", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(8, 19);
            label9.Name = "label9";
            label9.Size = new Size(154, 32);
            label9.TabIndex = 17;
            label9.Text = "SEARCH:";
            label9.Click += label9_Click;
            // 
            // btnenter
            // 
            btnenter.BackColor = SystemColors.ButtonFace;
            btnenter.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            btnenter.Location = new Point(195, 19);
            btnenter.Name = "btnenter";
            btnenter.Size = new Size(75, 32);
            btnenter.TabIndex = 15;
            btnenter.Text = "Copy";
            btnenter.UseVisualStyleBackColor = false;
            btnenter.Click += btnenter_Click;
            // 
            // btnsave
            // 
            btnsave.BackColor = SystemColors.Menu;
            btnsave.Font = new Font("Rockwell", 15.75F, FontStyle.Bold);
            btnsave.Location = new Point(81, 450);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(97, 37);
            btnsave.TabIndex = 12;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // txtdrivername
            // 
            txtdrivername.Font = new Font("Rockwell", 9.75F);
            txtdrivername.Location = new Point(164, 348);
            txtdrivername.Name = "txtdrivername";
            txtdrivername.Size = new Size(181, 23);
            txtdrivername.TabIndex = 10;
            // 
            // txtcarbrand
            // 
            txtcarbrand.Font = new Font("Rockwell", 9.75F);
            txtcarbrand.Location = new Point(164, 296);
            txtcarbrand.Name = "txtcarbrand";
            txtcarbrand.Size = new Size(181, 23);
            txtcarbrand.TabIndex = 9;
            // 
            // txtplatenum
            // 
            txtplatenum.Font = new Font("Rockwell", 9.75F);
            txtplatenum.Location = new Point(164, 247);
            txtplatenum.Name = "txtplatenum";
            txtplatenum.Size = new Size(181, 23);
            txtplatenum.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 14.25F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(13, 159);
            label7.Name = "label7";
            label7.Size = new Size(134, 21);
            label7.TabIndex = 6;
            label7.Text = "Vehicle Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 14.25F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(13, 350);
            label6.Name = "label6";
            label6.Size = new Size(141, 21);
            label6.TabIndex = 5;
            label6.Text = "Driver's Name:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 14.25F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(13, 298);
            label5.Name = "label5";
            label5.Size = new Size(141, 21);
            label5.TabIndex = 4;
            label5.Text = "Vehicle Brand:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 14.25F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(13, 249);
            label4.Name = "label4";
            label4.Size = new Size(137, 21);
            label4.TabIndex = 3;
            label4.Text = "Plate Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 14.25F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(13, 202);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 2;
            label3.Text = "Parking Spot:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 14.25F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(13, 402);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 0;
            label2.Text = "Status:";
            // 
            // btnback
            // 
            btnback.Font = new Font("Sitka Small", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnback.Location = new Point(1267, 13);
            btnback.Name = "btnback";
            btnback.Size = new Size(103, 60);
            btnback.TabIndex = 7;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // Parking_List
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1386, 700);
            Controls.Add(btnback);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Parking_List";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parking_List";
            Load += Parking_List_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnback;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private TextBox txtdrivername;
        private TextBox txtcarbrand;
        private TextBox txtplatenum;
        private Button btnsave;
        private Panel panel2;
        private Button btnenter;
        private Label label9;
        private TextBox txtsearch;
        private Button btnclear;
        private ComboBox cmbvehicletype;
        private ComboBox cmbstatus;
        private Button btnout;
        private Button btnSimulate;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Panel panel3;
        private ComboBox cmbparkingspot;
    }
}