namespace WindowsFormsApplication2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            labelMainTitle = new System.Windows.Forms.Label();
            lblInfo = new System.Windows.Forms.Label();
            labelVersion = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            linkLabelSourceCode = new System.Windows.Forms.LinkLabel();
            button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            linkLabelLastProject = new System.Windows.Forms.LinkLabel();
            SuspendLayout();
            // 
            // labelMainTitle
            // 
            labelMainTitle.AutoSize = true;
            labelMainTitle.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
            labelMainTitle.Location = new System.Drawing.Point(12, 14);
            labelMainTitle.Name = "labelMainTitle";
            labelMainTitle.Size = new System.Drawing.Size(238, 36);
            labelMainTitle.TabIndex = 5;
            labelMainTitle.Text = "雨雨跟打器 ®";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.ForeColor = System.Drawing.Color.Red;
            lblInfo.Location = new System.Drawing.Point(14, 60);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new System.Drawing.Size(76, 21);
            lblInfo.TabIndex = 6;
            lblInfo.Text = "label1";
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Font = new System.Drawing.Font("新宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
            labelVersion.Location = new System.Drawing.Point(264, 14);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new System.Drawing.Size(102, 28);
            labelVersion.TabIndex = 7;
            labelVersion.Text = "label1";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(14, 179);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(439, 21);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "原项目：添雨跟打器 (Apache License 2.0)";
            linkLabel1.LinkClicked += LinkLabel1Clicked;
            // 
            // linkLabelSourceCode
            // 
            linkLabelSourceCode.AutoSize = true;
            linkLabelSourceCode.Location = new System.Drawing.Point(14, 254);
            linkLabelSourceCode.Name = "linkLabelSourceCode";
            linkLabelSourceCode.Size = new System.Drawing.Size(307, 21);
            linkLabelSourceCode.TabIndex = 9;
            linkLabelSourceCode.TabStop = true;
            linkLabelSourceCode.Text = "源代码 (Apache License 2.0)";
            linkLabelSourceCode.LinkClicked += LinkLabelSourceCodeClicked;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(326, 302);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 40);
            button1.TabIndex = 11;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OKClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 143);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(714, 21);
            label3.TabIndex = 12;
            label3.Text = "该软件基于添雨跟打器旧版本项目修改构建出来的雨天跟打器修改构建。";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(14, 110);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(494, 21);
            label4.TabIndex = 13;
            label4.Text = "雨雨跟打器是一款免费开源的便捷打字练习软件，";
            // 
            // linkLabelLastProject
            // 
            linkLabelLastProject.AutoSize = true;
            linkLabelLastProject.Location = new System.Drawing.Point(12, 216);
            linkLabelLastProject.Name = "linkLabelLastProject";
            linkLabelLastProject.Size = new System.Drawing.Size(439, 21);
            linkLabelLastProject.TabIndex = 14;
            linkLabelLastProject.TabStop = true;
            linkLabelLastProject.Text = "前项目：雨天跟打器 (Apache License 2.0)";
            linkLabelLastProject.LinkClicked += linkLabelLastProject_LinkClicked;
            // 
            // About
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(726, 354);
            Controls.Add(linkLabelLastProject);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(linkLabelSourceCode);
            Controls.Add(linkLabel1);
            Controls.Add(labelVersion);
            Controls.Add(lblInfo);
            Controls.Add(labelMainTitle);
            Font = new System.Drawing.Font("新宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "关于雨雨跟打器";
            Load += Start_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMainTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabelSourceCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabelLastProject;
    }
}