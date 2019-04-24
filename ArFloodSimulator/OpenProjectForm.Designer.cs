namespace ArFloodSimulator
{
    partial class OpenProjectForm
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
            this.projectListCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxProjectDetails = new System.Windows.Forms.GroupBox();
            this.textBoxFloodLevel = new System.Windows.Forms.TextBox();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelProjectData = new System.Windows.Forms.Panel();
            this.groupBoxProjectLoc = new System.Windows.Forms.GroupBox();
            this.textBoxProjAddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxProjAlti = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxProjLongi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxProjLati = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxBuildingDetails = new System.Windows.Forms.GroupBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBuildingShape = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBuildingType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBuildingName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnEditCncl = new System.Windows.Forms.Button();
            this.BtnNewSaveProj = new System.Windows.Forms.Button();
            this.BtnCancelSaveProject = new System.Windows.Forms.Button();
            this.BtnDeleteProj = new System.Windows.Forms.Button();
            this.groupBoxProjectDetails.SuspendLayout();
            this.panelProjectData.SuspendLayout();
            this.groupBoxProjectLoc.SuspendLayout();
            this.groupBoxBuildingDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectListCombo
            // 
            this.projectListCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectListCombo.FormattingEnabled = true;
            this.projectListCombo.Location = new System.Drawing.Point(12, 35);
            this.projectListCombo.Name = "projectListCombo";
            this.projectListCombo.Size = new System.Drawing.Size(245, 21);
            this.projectListCombo.TabIndex = 0;
            this.projectListCombo.SelectedIndexChanged += new System.EventHandler(this.ProjectListCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project List";
            // 
            // groupBoxProjectDetails
            // 
            this.groupBoxProjectDetails.Controls.Add(this.textBoxFloodLevel);
            this.groupBoxProjectDetails.Controls.Add(this.textBoxProjectName);
            this.groupBoxProjectDetails.Controls.Add(this.label3);
            this.groupBoxProjectDetails.Controls.Add(this.label2);
            this.groupBoxProjectDetails.Location = new System.Drawing.Point(3, 3);
            this.groupBoxProjectDetails.Name = "groupBoxProjectDetails";
            this.groupBoxProjectDetails.Size = new System.Drawing.Size(400, 81);
            this.groupBoxProjectDetails.TabIndex = 3;
            this.groupBoxProjectDetails.TabStop = false;
            this.groupBoxProjectDetails.Text = "Project Details";
            // 
            // textBoxFloodLevel
            // 
            this.textBoxFloodLevel.Location = new System.Drawing.Point(227, 43);
            this.textBoxFloodLevel.Name = "textBoxFloodLevel";
            this.textBoxFloodLevel.Size = new System.Drawing.Size(167, 20);
            this.textBoxFloodLevel.TabIndex = 3;
            this.textBoxFloodLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowNumberOnly);
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Location = new System.Drawing.Point(10, 43);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size(167, 20);
            this.textBoxProjectName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Flood Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Project Name";
            // 
            // panelProjectData
            // 
            this.panelProjectData.Controls.Add(this.BtnDeleteProj);
            this.panelProjectData.Controls.Add(this.groupBoxProjectLoc);
            this.panelProjectData.Controls.Add(this.groupBoxBuildingDetails);
            this.panelProjectData.Controls.Add(this.groupBoxProjectDetails);
            this.panelProjectData.Location = new System.Drawing.Point(13, 64);
            this.panelProjectData.Name = "panelProjectData";
            this.panelProjectData.Size = new System.Drawing.Size(406, 380);
            this.panelProjectData.TabIndex = 4;
            // 
            // groupBoxProjectLoc
            // 
            this.groupBoxProjectLoc.Controls.Add(this.textBoxProjAddress);
            this.groupBoxProjectLoc.Controls.Add(this.label13);
            this.groupBoxProjectLoc.Controls.Add(this.textBoxProjAlti);
            this.groupBoxProjectLoc.Controls.Add(this.label12);
            this.groupBoxProjectLoc.Controls.Add(this.textBoxProjLongi);
            this.groupBoxProjectLoc.Controls.Add(this.label11);
            this.groupBoxProjectLoc.Controls.Add(this.textBoxProjLati);
            this.groupBoxProjectLoc.Controls.Add(this.label10);
            this.groupBoxProjectLoc.Location = new System.Drawing.Point(4, 242);
            this.groupBoxProjectLoc.Name = "groupBoxProjectLoc";
            this.groupBoxProjectLoc.Size = new System.Drawing.Size(399, 100);
            this.groupBoxProjectLoc.TabIndex = 5;
            this.groupBoxProjectLoc.TabStop = false;
            this.groupBoxProjectLoc.Text = "Project Location";
            // 
            // textBoxProjAddress
            // 
            this.textBoxProjAddress.Location = new System.Drawing.Point(9, 76);
            this.textBoxProjAddress.Name = "textBoxProjAddress";
            this.textBoxProjAddress.Size = new System.Drawing.Size(377, 20);
            this.textBoxProjAddress.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Address";
            // 
            // textBoxProjAlti
            // 
            this.textBoxProjAlti.Location = new System.Drawing.Point(271, 32);
            this.textBoxProjAlti.Name = "textBoxProjAlti";
            this.textBoxProjAlti.Size = new System.Drawing.Size(115, 20);
            this.textBoxProjAlti.TabIndex = 20;
            this.textBoxProjAlti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowDecimalOnly);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(268, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Altitude";
            // 
            // textBoxProjLongi
            // 
            this.textBoxProjLongi.Location = new System.Drawing.Point(144, 32);
            this.textBoxProjLongi.Name = "textBoxProjLongi";
            this.textBoxProjLongi.Size = new System.Drawing.Size(115, 20);
            this.textBoxProjLongi.TabIndex = 18;
            this.textBoxProjLongi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowDecimalOnly);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(141, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Longitude";
            // 
            // textBoxProjLati
            // 
            this.textBoxProjLati.Location = new System.Drawing.Point(9, 32);
            this.textBoxProjLati.Name = "textBoxProjLati";
            this.textBoxProjLati.Size = new System.Drawing.Size(115, 20);
            this.textBoxProjLati.TabIndex = 16;
            this.textBoxProjLati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowDecimalOnly);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Latitude";
            // 
            // groupBoxBuildingDetails
            // 
            this.groupBoxBuildingDetails.Controls.Add(this.textBoxLength);
            this.groupBoxBuildingDetails.Controls.Add(this.label9);
            this.groupBoxBuildingDetails.Controls.Add(this.textBoxWidth);
            this.groupBoxBuildingDetails.Controls.Add(this.label8);
            this.groupBoxBuildingDetails.Controls.Add(this.textBoxHeight);
            this.groupBoxBuildingDetails.Controls.Add(this.label7);
            this.groupBoxBuildingDetails.Controls.Add(this.textBoxBuildingShape);
            this.groupBoxBuildingDetails.Controls.Add(this.label6);
            this.groupBoxBuildingDetails.Controls.Add(this.textBoxBuildingType);
            this.groupBoxBuildingDetails.Controls.Add(this.label5);
            this.groupBoxBuildingDetails.Controls.Add(this.textBoxBuildingName);
            this.groupBoxBuildingDetails.Controls.Add(this.label4);
            this.groupBoxBuildingDetails.Location = new System.Drawing.Point(4, 88);
            this.groupBoxBuildingDetails.Name = "groupBoxBuildingDetails";
            this.groupBoxBuildingDetails.Size = new System.Drawing.Size(399, 147);
            this.groupBoxBuildingDetails.TabIndex = 4;
            this.groupBoxBuildingDetails.TabStop = false;
            this.groupBoxBuildingDetails.Text = "Building Details";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(226, 116);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(167, 20);
            this.textBoxLength.TabIndex = 14;
            this.textBoxLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowNumberOnly);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Length";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(9, 116);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(167, 20);
            this.textBoxWidth.TabIndex = 12;
            this.textBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowNumberOnly);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Width";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(226, 76);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(167, 20);
            this.textBoxHeight.TabIndex = 10;
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowNumberOnly);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Height";
            // 
            // textBoxBuildingShape
            // 
            this.textBoxBuildingShape.Location = new System.Drawing.Point(9, 76);
            this.textBoxBuildingShape.Name = "textBoxBuildingShape";
            this.textBoxBuildingShape.Size = new System.Drawing.Size(167, 20);
            this.textBoxBuildingShape.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Shape";
            // 
            // textBoxBuildingType
            // 
            this.textBoxBuildingType.Location = new System.Drawing.Point(226, 36);
            this.textBoxBuildingType.Name = "textBoxBuildingType";
            this.textBoxBuildingType.Size = new System.Drawing.Size(167, 20);
            this.textBoxBuildingType.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type";
            // 
            // textBoxBuildingName
            // 
            this.textBoxBuildingName.Location = new System.Drawing.Point(9, 36);
            this.textBoxBuildingName.Name = "textBoxBuildingName";
            this.textBoxBuildingName.Size = new System.Drawing.Size(167, 20);
            this.textBoxBuildingName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(344, 33);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 5;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnEditCncl
            // 
            this.BtnEditCncl.Location = new System.Drawing.Point(263, 33);
            this.BtnEditCncl.Name = "BtnEditCncl";
            this.BtnEditCncl.Size = new System.Drawing.Size(75, 23);
            this.BtnEditCncl.TabIndex = 6;
            this.BtnEditCncl.Text = "Edit";
            this.BtnEditCncl.UseVisualStyleBackColor = true;
            this.BtnEditCncl.Click += new System.EventHandler(this.BtnEditCncl_Click);
            // 
            // BtnNewSaveProj
            // 
            this.BtnNewSaveProj.Location = new System.Drawing.Point(344, 33);
            this.BtnNewSaveProj.Name = "BtnNewSaveProj";
            this.BtnNewSaveProj.Size = new System.Drawing.Size(75, 23);
            this.BtnNewSaveProj.TabIndex = 7;
            this.BtnNewSaveProj.Text = "New Project";
            this.BtnNewSaveProj.UseVisualStyleBackColor = true;
            this.BtnNewSaveProj.Click += new System.EventHandler(this.BtnNewSaveProj_Click);
            // 
            // BtnCancelSaveProject
            // 
            this.BtnCancelSaveProject.Location = new System.Drawing.Point(264, 33);
            this.BtnCancelSaveProject.Name = "BtnCancelSaveProject";
            this.BtnCancelSaveProject.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelSaveProject.TabIndex = 8;
            this.BtnCancelSaveProject.Text = "Cancel";
            this.BtnCancelSaveProject.UseVisualStyleBackColor = true;
            this.BtnCancelSaveProject.Click += new System.EventHandler(this.BtnCancelSaveProject_Click);
            // 
            // BtnDeleteProj
            // 
            this.BtnDeleteProj.Location = new System.Drawing.Point(7, 348);
            this.BtnDeleteProj.Name = "BtnDeleteProj";
            this.BtnDeleteProj.Size = new System.Drawing.Size(390, 23);
            this.BtnDeleteProj.TabIndex = 9;
            this.BtnDeleteProj.Text = "Delete Project";
            this.BtnDeleteProj.UseVisualStyleBackColor = true;
            this.BtnDeleteProj.Click += new System.EventHandler(this.BtnDeleteProj_Click);
            // 
            // OpenProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 468);
            this.Controls.Add(this.BtnCancelSaveProject);
            this.Controls.Add(this.BtnNewSaveProj);
            this.Controls.Add(this.BtnEditCncl);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.panelProjectData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectListCombo);
            this.Name = "OpenProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OpenProjectForm";
            this.Load += new System.EventHandler(this.OpenProjectForm_Load);
            this.groupBoxProjectDetails.ResumeLayout(false);
            this.groupBoxProjectDetails.PerformLayout();
            this.panelProjectData.ResumeLayout(false);
            this.groupBoxProjectLoc.ResumeLayout(false);
            this.groupBoxProjectLoc.PerformLayout();
            this.groupBoxBuildingDetails.ResumeLayout(false);
            this.groupBoxBuildingDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox projectListCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxProjectDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.TextBox textBoxFloodLevel;
        private System.Windows.Forms.Panel panelProjectData;
        private System.Windows.Forms.GroupBox groupBoxBuildingDetails;
        private System.Windows.Forms.TextBox textBoxBuildingType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBuildingName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBuildingShape;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxProjectLoc;
        private System.Windows.Forms.TextBox textBoxProjLati;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxProjAlti;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxProjLongi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxProjAddress;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnEditCncl;
        private System.Windows.Forms.Button BtnNewSaveProj;
        private System.Windows.Forms.Button BtnCancelSaveProject;
        private System.Windows.Forms.Button BtnDeleteProj;
    }
}