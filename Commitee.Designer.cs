namespace Election_Management_System
{
    partial class Commitee
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
            this.Welcome_lbl = new System.Windows.Forms.Label();
            this.show_btn = new System.Windows.Forms.Button();
            this.sign_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome_lbl
            // 
            this.Welcome_lbl.AutoSize = true;
            this.Welcome_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_lbl.Location = new System.Drawing.Point(337, 13);
            this.Welcome_lbl.Name = "Welcome_lbl";
            this.Welcome_lbl.Size = new System.Drawing.Size(66, 24);
            this.Welcome_lbl.TabIndex = 0;
            this.Welcome_lbl.Text = "label1";
            // 
            // show_btn
            // 
            this.show_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.Location = new System.Drawing.Point(209, 135);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(331, 63);
            this.show_btn.TabIndex = 2;
            this.show_btn.Text = "Review result and confirm it";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // sign_btn
            // 
            this.sign_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_btn.Location = new System.Drawing.Point(637, 393);
            this.sign_btn.Name = "sign_btn";
            this.sign_btn.Size = new System.Drawing.Size(117, 45);
            this.sign_btn.TabIndex = 3;
            this.sign_btn.Text = "Sign Out";
            this.sign_btn.UseVisualStyleBackColor = true;
            this.sign_btn.Click += new System.EventHandler(this.sign_btn_Click);
            // 
            // Commitee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sign_btn);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.Welcome_lbl);
            this.Name = "Commitee";
            this.Text = "Commitee";
            this.Load += new System.EventHandler(this.Commitee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_lbl;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.Button sign_btn;
    }
}