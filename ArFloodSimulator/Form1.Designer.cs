namespace ArFloodSimulator
{
    partial class MainForm
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
            this.BtnSetCurrentLoc = new System.Windows.Forms.Button();
            this.BtnGetCurrentLoc = new System.Windows.Forms.Button();
            this.BtnOpenProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSetCurrentLoc
            // 
            this.BtnSetCurrentLoc.Location = new System.Drawing.Point(69, 32);
            this.BtnSetCurrentLoc.Name = "BtnSetCurrentLoc";
            this.BtnSetCurrentLoc.Size = new System.Drawing.Size(185, 23);
            this.BtnSetCurrentLoc.TabIndex = 0;
            this.BtnSetCurrentLoc.Text = "Set Current Location";
            this.BtnSetCurrentLoc.UseVisualStyleBackColor = true;
            this.BtnSetCurrentLoc.Click += new System.EventHandler(this.BtnSetCurrentLoc_Click);
            // 
            // BtnGetCurrentLoc
            // 
            this.BtnGetCurrentLoc.Location = new System.Drawing.Point(69, 76);
            this.BtnGetCurrentLoc.Name = "BtnGetCurrentLoc";
            this.BtnGetCurrentLoc.Size = new System.Drawing.Size(185, 23);
            this.BtnGetCurrentLoc.TabIndex = 1;
            this.BtnGetCurrentLoc.Text = "Get Current Location";
            this.BtnGetCurrentLoc.UseVisualStyleBackColor = true;
            this.BtnGetCurrentLoc.Click += new System.EventHandler(this.BtnGetCurrentLoc_Click);
            // 
            // BtnOpenProject
            // 
            this.BtnOpenProject.Location = new System.Drawing.Point(69, 117);
            this.BtnOpenProject.Name = "BtnOpenProject";
            this.BtnOpenProject.Size = new System.Drawing.Size(185, 23);
            this.BtnOpenProject.TabIndex = 2;
            this.BtnOpenProject.Text = "Project Details";
            this.BtnOpenProject.UseVisualStyleBackColor = true;
            this.BtnOpenProject.Click += new System.EventHandler(this.BtnOpenProject_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 285);
            this.Controls.Add(this.BtnOpenProject);
            this.Controls.Add(this.BtnGetCurrentLoc);
            this.Controls.Add(this.BtnSetCurrentLoc);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AR Flood Simulator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSetCurrentLoc;
        private System.Windows.Forms.Button BtnGetCurrentLoc;
        private System.Windows.Forms.Button BtnOpenProject;
    }
}

