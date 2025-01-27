namespace ParkMAuto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtpass = new TextBox();
            btnsignin = new Button();
            label2 = new Label();
            label3 = new Label();
            txtusername = new TextBox();
            btnclose = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 171);
            label1.Name = "label1";
            label1.Size = new Size(420, 79);
            label1.TabIndex = 0;
            label1.Text = "PARKMAUTO";
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Sitka Small", 18F);
            txtpass.Location = new Point(699, 231);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(264, 37);
            txtpass.TabIndex = 1;
            txtpass.TextChanged += txtpass_TextChanged;
            // 
            // btnsignin
            // 
            btnsignin.Font = new Font("Sitka Small", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsignin.Location = new Point(767, 304);
            btnsignin.Name = "btnsignin";
            btnsignin.Size = new Size(147, 66);
            btnsignin.TabIndex = 2;
            btnsignin.Text = "Sign-in";
            btnsignin.UseVisualStyleBackColor = true;
            btnsignin.Click += btnsignin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 20.25F);
            label2.Location = new Point(537, 177);
            label2.Name = "label2";
            label2.Size = new Size(145, 31);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 20.25F);
            label3.Location = new Point(537, 237);
            label3.Name = "label3";
            label3.Size = new Size(139, 31);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Sitka Small", 18F);
            txtusername.Location = new Point(699, 171);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(264, 37);
            txtusername.TabIndex = 5;
            // 
            // btnclose
            // 
            btnclose.Font = new Font("Lucida Console", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose.Location = new Point(17, 22);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(33, 32);
            btnclose.TabIndex = 6;
            btnclose.Text = "X";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(28, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 118);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(btnclose);
            panel2.Location = new Point(922, -10);
            panel2.Name = "panel2";
            panel2.Size = new Size(73, 118);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Lavender;
            panel3.Location = new Point(-7, -10);
            panel3.Name = "panel3";
            panel3.Size = new Size(71, 118);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Lavender;
            panel4.Location = new Point(-9, 425);
            panel4.Name = "panel4";
            panel4.Size = new Size(71, 68);
            panel4.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Lavender;
            panel5.Location = new Point(920, 425);
            panel5.Name = "panel5";
            panel5.Size = new Size(73, 68);
            panel5.TabIndex = 11;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Lavender;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(26, 425);
            panel6.Name = "panel6";
            panel6.Size = new Size(930, 68);
            panel6.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 477);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnsignin);
            Controls.Add(txtpass);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtpass;
        private Button btnsignin;
        private Label label2;
        private Label label3;
        private TextBox txtusername;
        private Button btnclose;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}
