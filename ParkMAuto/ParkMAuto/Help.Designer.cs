namespace ParkMAuto
{
    partial class Help
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
            label1 = new Label();
            label2 = new Label();
            btnsignout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 51);
            label1.Name = "label1";
            label1.Size = new Size(420, 79);
            label1.TabIndex = 1;
            label1.Text = "PARKMAUTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ink Free", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 211);
            label2.Name = "label2";
            label2.Size = new Size(193, 79);
            label2.TabIndex = 2;
            label2.Text = "HELP";
            // 
            // btnsignout
            // 
            btnsignout.BackColor = Color.SteelBlue;
            btnsignout.FlatStyle = FlatStyle.Popup;
            btnsignout.Location = new Point(730, 153);
            btnsignout.Name = "btnsignout";
            btnsignout.Size = new Size(36, 32);
            btnsignout.TabIndex = 3;
            btnsignout.Text = "X";
            btnsignout.UseVisualStyleBackColor = false;
            btnsignout.Click += btnsignout_Click;
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500);
            Controls.Add(btnsignout);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Help";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Help";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnsignout;
    }
}