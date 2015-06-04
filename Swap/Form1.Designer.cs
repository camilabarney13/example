namespace Swap
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.swap = new System.Windows.Forms.Button();
            this.Lucinda = new System.Windows.Forms.Button();
            this.Lloyd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // swap
            // 
            this.swap.Image = global::Swap.Properties.Resources.Ele;
            this.swap.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.swap.Location = new System.Drawing.Point(97, 188);
            this.swap.Name = "swap";
            this.swap.Size = new System.Drawing.Size(81, 28);
            this.swap.TabIndex = 0;
            this.swap.Text = "Swap";
            this.swap.UseVisualStyleBackColor = true;
            this.swap.Click += new System.EventHandler(this.swap_Click);
            // 
            // Lucinda
            // 
            this.Lucinda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Lucinda.BackgroundImage")));
            this.Lucinda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Lucinda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lucinda.Image = global::Swap.Properties.Resources.Ele;
            this.Lucinda.Location = new System.Drawing.Point(97, 137);
            this.Lucinda.Name = "Lucinda";
            this.Lucinda.Size = new System.Drawing.Size(75, 23);
            this.Lucinda.TabIndex = 1;
            this.Lucinda.Text = "Lucinda";
            this.Lucinda.UseVisualStyleBackColor = true;
            this.Lucinda.Click += new System.EventHandler(this.Lucinda_Click);
            // 
            // Lloyd
            // 
            this.Lloyd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Lloyd.BackgroundImage")));
            this.Lloyd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Lloyd.Image = global::Swap.Properties.Resources.Ele;
            this.Lloyd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lloyd.Location = new System.Drawing.Point(97, 86);
            this.Lloyd.Name = "Lloyd";
            this.Lloyd.Size = new System.Drawing.Size(75, 23);
            this.Lloyd.TabIndex = 2;
            this.Lloyd.Text = "Lloyd";
            this.Lloyd.UseVisualStyleBackColor = true;
            this.Lloyd.Click += new System.EventHandler(this.Lloyd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(283, 259);
            this.Controls.Add(this.Lloyd);
            this.Controls.Add(this.Lucinda);
            this.Controls.Add(this.swap);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button swap;
        private System.Windows.Forms.Button Lucinda;
        private System.Windows.Forms.Button Lloyd;
    }
}

