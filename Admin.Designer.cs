namespace Election_Management_System
{
    partial class admin
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
            this.Add_btn = new System.Windows.Forms.Button();
            this.RVI_btn = new System.Windows.Forms.Button();
            this.RR_btn = new System.Windows.Forms.Button();
            this.Welcome_lbl = new System.Windows.Forms.Label();
            this.Signoout_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.MistyRose;
            this.Add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.Location = new System.Drawing.Point(157, 95);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(123, 65);
            this.Add_btn.TabIndex = 0;
            this.Add_btn.Text = "Add new candidates";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // RVI_btn
            // 
            this.RVI_btn.BackColor = System.Drawing.Color.MistyRose;
            this.RVI_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RVI_btn.Location = new System.Drawing.Point(517, 95);
            this.RVI_btn.Name = "RVI_btn";
            this.RVI_btn.Size = new System.Drawing.Size(123, 65);
            this.RVI_btn.TabIndex = 1;
            this.RVI_btn.Text = "Review voters info";
            this.RVI_btn.UseVisualStyleBackColor = false;
            this.RVI_btn.Click += new System.EventHandler(this.RVI_btn_Click);
            // 
            // RR_btn
            // 
            this.RR_btn.BackColor = System.Drawing.Color.MistyRose;
            this.RR_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RR_btn.Location = new System.Drawing.Point(332, 190);
            this.RR_btn.Name = "RR_btn";
            this.RR_btn.Size = new System.Drawing.Size(123, 65);
            this.RR_btn.TabIndex = 2;
            this.RR_btn.Text = "Review result";
            this.RR_btn.UseVisualStyleBackColor = false;
            this.RR_btn.Click += new System.EventHandler(this.RR_btn_Click);
            // 
            // Welcome_lbl
            // 
            this.Welcome_lbl.AutoSize = true;
            this.Welcome_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_lbl.Location = new System.Drawing.Point(346, 30);
            this.Welcome_lbl.Name = "Welcome_lbl";
            this.Welcome_lbl.Size = new System.Drawing.Size(82, 20);
            this.Welcome_lbl.TabIndex = 3;
            this.Welcome_lbl.Text = "Welcome";
            // 
            // Signoout_btn
            // 
            this.Signoout_btn.BackColor = System.Drawing.Color.Chocolate;
            this.Signoout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signoout_btn.Location = new System.Drawing.Point(33, 371);
            this.Signoout_btn.Name = "Signoout_btn";
            this.Signoout_btn.Size = new System.Drawing.Size(116, 64);
            this.Signoout_btn.TabIndex = 4;
            this.Signoout_btn.Text = "Sign Out";
            this.Signoout_btn.UseVisualStyleBackColor = false;
            this.Signoout_btn.Click += new System.EventHandler(this.Signoout_btn_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(825, 468);
            this.Controls.Add(this.Signoout_btn);
            this.Controls.Add(this.Welcome_lbl);
            this.Controls.Add(this.RR_btn);
            this.Controls.Add(this.RVI_btn);
            this.Controls.Add(this.Add_btn);
            this.Name = "admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button RVI_btn;
        private System.Windows.Forms.Button RR_btn;
        private System.Windows.Forms.Label Welcome_lbl;
        private System.Windows.Forms.Button Signoout_btn;
    }
}