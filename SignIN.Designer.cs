namespace Election_Management_System
{
    partial class SignIN
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
            this.SignIn_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SignUp_btn = new System.Windows.Forms.Button();
            this.Id_txt = new System.Windows.Forms.TextBox();
            this.Pass_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SignIn_btn
            // 
            this.SignIn_btn.BackColor = System.Drawing.Color.Wheat;
            this.SignIn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SignIn_btn.Location = new System.Drawing.Point(240, 255);
            this.SignIn_btn.Name = "SignIn_btn";
            this.SignIn_btn.Size = new System.Drawing.Size(87, 35);
            this.SignIn_btn.TabIndex = 0;
            this.SignIn_btn.Text = "Sign In";
            this.SignIn_btn.UseVisualStyleBackColor = false;
            this.SignIn_btn.Click += new System.EventHandler(this.SignIn_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "National ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // SignUp_btn
            // 
            this.SignUp_btn.BackColor = System.Drawing.Color.Wheat;
            this.SignUp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_btn.Location = new System.Drawing.Point(351, 255);
            this.SignUp_btn.Name = "SignUp_btn";
            this.SignUp_btn.Size = new System.Drawing.Size(107, 35);
            this.SignUp_btn.TabIndex = 3;
            this.SignUp_btn.Text = "Sign Up";
            this.SignUp_btn.UseVisualStyleBackColor = false;
            this.SignUp_btn.Click += new System.EventHandler(this.SignUp_btn_Click);
            // 
            // Id_txt
            // 
            this.Id_txt.BackColor = System.Drawing.Color.NavajoWhite;
            this.Id_txt.Location = new System.Drawing.Point(179, 99);
            this.Id_txt.Name = "Id_txt";
            this.Id_txt.Size = new System.Drawing.Size(227, 20);
            this.Id_txt.TabIndex = 4;
            // 
            // Pass_txt
            // 
            this.Pass_txt.BackColor = System.Drawing.Color.NavajoWhite;
            this.Pass_txt.Location = new System.Drawing.Point(179, 159);
            this.Pass_txt.Name = "Pass_txt";
            this.Pass_txt.Size = new System.Drawing.Size(227, 20);
            this.Pass_txt.TabIndex = 5;
            // 
            // SignIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pass_txt);
            this.Controls.Add(this.Id_txt);
            this.Controls.Add(this.SignUp_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignIn_btn);
            this.Name = "SignIN";
            this.Text = "SignIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignIN_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignIn_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SignUp_btn;
        private System.Windows.Forms.TextBox Id_txt;
        private System.Windows.Forms.TextBox Pass_txt;
    }
}