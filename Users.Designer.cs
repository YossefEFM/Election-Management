namespace Election_Management_System
{
    partial class Users
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
            this.Go_btn = new System.Windows.Forms.Button();
            this.Signed_lbl = new System.Windows.Forms.Label();
            this.Action_cmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Go_btn
            // 
            this.Go_btn.BackColor = System.Drawing.Color.Salmon;
            this.Go_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go_btn.Location = new System.Drawing.Point(394, 93);
            this.Go_btn.Name = "Go_btn";
            this.Go_btn.Size = new System.Drawing.Size(114, 42);
            this.Go_btn.TabIndex = 0;
            this.Go_btn.Text = "! GO !";
            this.Go_btn.UseVisualStyleBackColor = false;
            this.Go_btn.Click += new System.EventHandler(this.Go_btn_Click);
            // 
            // Signed_lbl
            // 
            this.Signed_lbl.AutoSize = true;
            this.Signed_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signed_lbl.Location = new System.Drawing.Point(720, 9);
            this.Signed_lbl.Name = "Signed_lbl";
            this.Signed_lbl.Size = new System.Drawing.Size(57, 20);
            this.Signed_lbl.TabIndex = 1;
            this.Signed_lbl.Text = "label1";
            // 
            // Action_cmb
            // 
            this.Action_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Action_cmb.FormattingEnabled = true;
            this.Action_cmb.Items.AddRange(new object[] {
            "View Candidates",
            "Vote",
            "Sign In",
            "Sign Out",
            "Register"});
            this.Action_cmb.Location = new System.Drawing.Point(200, 101);
            this.Action_cmb.Name = "Action_cmb";
            this.Action_cmb.Size = new System.Drawing.Size(121, 28);
            this.Action_cmb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Action";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(781, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "This System  is Election Management System You can Vote With it without move from" +
    " your home";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Action_cmb);
            this.Controls.Add(this.Signed_lbl);
            this.Controls.Add(this.Go_btn);
            this.Name = "Users";
            this.Text = "User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Users_FormClosing);
            this.Load += new System.EventHandler(this.Users_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Go_btn;
        private System.Windows.Forms.Label Signed_lbl;
        private System.Windows.Forms.ComboBox Action_cmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}