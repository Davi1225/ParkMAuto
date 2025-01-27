namespace ParkMAuto
{
    partial class About
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
            btnsignout = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnsignout
            // 
            btnsignout.BackColor = Color.SteelBlue;
            btnsignout.FlatStyle = FlatStyle.Popup;
            btnsignout.Location = new Point(699, 233);
            btnsignout.Name = "btnsignout";
            btnsignout.Size = new Size(36, 32);
            btnsignout.TabIndex = 6;
            btnsignout.Text = "X";
            btnsignout.UseVisualStyleBackColor = false;
            btnsignout.Click += btnsignout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ink Free", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(209, 291);
            label2.Name = "label2";
            label2.Size = new Size(255, 79);
            label2.TabIndex = 5;
            label2.Text = "ABOUT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 131);
            label1.Name = "label1";
            label1.Size = new Size(420, 79);
            label1.TabIndex = 4;
            label1.Text = "PARKMAUTO";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500);
            Controls.Add(btnsignout);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsignout;
        private Label label2;
        private Label label1;
    }
}