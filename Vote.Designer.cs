namespace Election_Management_System
{
    partial class Vote
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
            this.label2 = new System.Windows.Forms.Label();
            this.Name_cmb = new System.Windows.Forms.ComboBox();
            this.Sh_lbl = new System.Windows.Forms.Label();
            this.Disc_lbl = new System.Windows.Forms.Label();
            this.Show_btn = new System.Windows.Forms.Button();
            this.Vote_btn = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // Name_cmb
            // 
            this.Name_cmb.FormattingEnabled = true;
            this.Name_cmb.Location = new System.Drawing.Point(192, 42);
            this.Name_cmb.Name = "Name_cmb";
            this.Name_cmb.Size = new System.Drawing.Size(121, 21);
            this.Name_cmb.TabIndex = 3;
            // 
            // Sh_lbl
            // 
            this.Sh_lbl.AutoSize = true;
            this.Sh_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sh_lbl.Location = new System.Drawing.Point(127, 134);
            this.Sh_lbl.Name = "Sh_lbl";
            this.Sh_lbl.Size = new System.Drawing.Size(0, 20);
            this.Sh_lbl.TabIndex = 4;
            // 
            // Disc_lbl
            // 
            this.Disc_lbl.AutoSize = true;
            this.Disc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disc_lbl.Location = new System.Drawing.Point(127, 189);
            this.Disc_lbl.Name = "Disc_lbl";
            this.Disc_lbl.Size = new System.Drawing.Size(0, 20);
            this.Disc_lbl.TabIndex = 5;
            // 
            // Show_btn
            // 
            this.Show_btn.BackColor = System.Drawing.Color.Coral;
            this.Show_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_btn.Location = new System.Drawing.Point(318, 81);
            this.Show_btn.Name = "Show_btn";
            this.Show_btn.Size = new System.Drawing.Size(75, 35);
            this.Show_btn.TabIndex = 6;
            this.Show_btn.Text = "Show";
            this.Show_btn.UseVisualStyleBackColor = false;
            this.Show_btn.Click += new System.EventHandler(this.Show_btn_Click);
            // 
            // Vote_btn
            // 
            this.Vote_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.Vote_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vote_btn.Location = new System.Drawing.Point(318, 288);
            this.Vote_btn.Name = "Vote_btn";
            this.Vote_btn.Size = new System.Drawing.Size(75, 38);
            this.Vote_btn.TabIndex = 7;
            this.Vote_btn.Text = "Vote";
            this.Vote_btn.UseVisualStyleBackColor = false;
            this.Vote_btn.Click += new System.EventHandler(this.Vote_btn_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(325, 9);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(0, 20);
            this.Welcome.TabIndex = 8;
            // 
            // Vote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.Vote_btn);
            this.Controls.Add(this.Show_btn);
            this.Controls.Add(this.Disc_lbl);
            this.Controls.Add(this.Sh_lbl);
            this.Controls.Add(this.Name_cmb);
            this.Controls.Add(this.label2);
            this.Name = "Vote";
            this.Text = "Vote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vote_FormClosing);
            this.Load += new System.EventHandler(this.Vote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Name_cmb;
        private System.Windows.Forms.Label Sh_lbl;
        private System.Windows.Forms.Label Disc_lbl;
        private System.Windows.Forms.Button Show_btn;
        private System.Windows.Forms.Button Vote_btn;
        private System.Windows.Forms.Label Welcome;
    }
}