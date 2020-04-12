namespace SU360XexTool
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
            this.Label_XexFileName = new System.Windows.Forms.Label();
            this.RestoreOriginalResBtn = new System.Windows.Forms.Button();
            this.Label_RenderingRes = new System.Windows.Forms.Label();
            this.Label_X = new System.Windows.Forms.Label();
            this.RenderingRes_X_TextBox = new System.Windows.Forms.TextBox();
            this.RenderingRes_Y_TextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenXex = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveXex = new System.Windows.Forms.ToolStripMenuItem();
            this.GammaColor_R_TextBox = new System.Windows.Forms.TextBox();
            this.GammaColor_G_TextBox = new System.Windows.Forms.TextBox();
            this.GammaColor_B_TextBox = new System.Windows.Forms.TextBox();
            this.Label_GammaR = new System.Windows.Forms.Label();
            this.Label_GammaG = new System.Windows.Forms.Label();
            this.Label_GammaB = new System.Windows.Forms.Label();
            this.RestoreOriginalGammaBtn = new System.Windows.Forms.Button();
            this.DisableGammaCorrectionBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_XexFileName
            // 
            this.Label_XexFileName.AutoSize = true;
            this.Label_XexFileName.Location = new System.Drawing.Point(3, 24);
            this.Label_XexFileName.Name = "Label_XexFileName";
            this.Label_XexFileName.Size = new System.Drawing.Size(73, 13);
            this.Label_XexFileName.TabIndex = 1;
            this.Label_XexFileName.Text = "Xex Filename:";
            // 
            // RestoreOriginalResBtn
            // 
            this.RestoreOriginalResBtn.Location = new System.Drawing.Point(28, 97);
            this.RestoreOriginalResBtn.Name = "RestoreOriginalResBtn";
            this.RestoreOriginalResBtn.Size = new System.Drawing.Size(146, 23);
            this.RestoreOriginalResBtn.TabIndex = 4;
            this.RestoreOriginalResBtn.Text = "Restore Original Res";
            this.RestoreOriginalResBtn.UseVisualStyleBackColor = true;
            this.RestoreOriginalResBtn.Click += new System.EventHandler(this.RestoreOriginalResBtn_Click);
            // 
            // Label_RenderingRes
            // 
            this.Label_RenderingRes.AutoSize = true;
            this.Label_RenderingRes.Location = new System.Drawing.Point(46, 55);
            this.Label_RenderingRes.Name = "Label_RenderingRes";
            this.Label_RenderingRes.Size = new System.Drawing.Size(112, 13);
            this.Label_RenderingRes.TabIndex = 5;
            this.Label_RenderingRes.Text = "Rendering Resolution:";
            // 
            // Label_X
            // 
            this.Label_X.AutoSize = true;
            this.Label_X.Location = new System.Drawing.Point(94, 74);
            this.Label_X.Name = "Label_X";
            this.Label_X.Size = new System.Drawing.Size(14, 13);
            this.Label_X.TabIndex = 6;
            this.Label_X.Text = "X";
            // 
            // RenderingRes_X_TextBox
            // 
            this.RenderingRes_X_TextBox.Location = new System.Drawing.Point(28, 71);
            this.RenderingRes_X_TextBox.Name = "RenderingRes_X_TextBox";
            this.RenderingRes_X_TextBox.Size = new System.Drawing.Size(60, 20);
            this.RenderingRes_X_TextBox.TabIndex = 7;
            this.RenderingRes_X_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.No_Letters);
            // 
            // RenderingRes_Y_TextBox
            // 
            this.RenderingRes_Y_TextBox.Location = new System.Drawing.Point(114, 71);
            this.RenderingRes_Y_TextBox.Name = "RenderingRes_Y_TextBox";
            this.RenderingRes_Y_TextBox.Size = new System.Drawing.Size(60, 20);
            this.RenderingRes_Y_TextBox.TabIndex = 8;
            this.RenderingRes_Y_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.No_Letters);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(205, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenXex,
            this.SaveXex});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // OpenXex
            // 
            this.OpenXex.Name = "OpenXex";
            this.OpenXex.Size = new System.Drawing.Size(120, 22);
            this.OpenXex.Text = "Open";
            this.OpenXex.Click += new System.EventHandler(this.OpenXex_Click);
            // 
            // SaveXex
            // 
            this.SaveXex.Name = "SaveXex";
            this.SaveXex.Size = new System.Drawing.Size(120, 22);
            this.SaveXex.Text = "SaveAs...";
            this.SaveXex.Click += new System.EventHandler(this.SaveXex_Click);
            // 
            // GammaColor_R_TextBox
            // 
            this.GammaColor_R_TextBox.Location = new System.Drawing.Point(8, 140);
            this.GammaColor_R_TextBox.Name = "GammaColor_R_TextBox";
            this.GammaColor_R_TextBox.Size = new System.Drawing.Size(60, 20);
            this.GammaColor_R_TextBox.TabIndex = 10;
            this.GammaColor_R_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.No_Letters);
            // 
            // GammaColor_G_TextBox
            // 
            this.GammaColor_G_TextBox.Location = new System.Drawing.Point(74, 140);
            this.GammaColor_G_TextBox.Name = "GammaColor_G_TextBox";
            this.GammaColor_G_TextBox.Size = new System.Drawing.Size(60, 20);
            this.GammaColor_G_TextBox.TabIndex = 11;
            this.GammaColor_G_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.No_Letters);
            // 
            // GammaColor_B_TextBox
            // 
            this.GammaColor_B_TextBox.Location = new System.Drawing.Point(140, 140);
            this.GammaColor_B_TextBox.Name = "GammaColor_B_TextBox";
            this.GammaColor_B_TextBox.Size = new System.Drawing.Size(60, 20);
            this.GammaColor_B_TextBox.TabIndex = 12;
            this.GammaColor_B_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.No_Letters);
            // 
            // Label_GammaR
            // 
            this.Label_GammaR.AutoSize = true;
            this.Label_GammaR.Location = new System.Drawing.Point(11, 124);
            this.Label_GammaR.Name = "Label_GammaR";
            this.Label_GammaR.Size = new System.Drawing.Size(57, 13);
            this.Label_GammaR.TabIndex = 13;
            this.Label_GammaR.Text = "Gamma R:";
            // 
            // Label_GammaG
            // 
            this.Label_GammaG.AutoSize = true;
            this.Label_GammaG.Location = new System.Drawing.Point(77, 124);
            this.Label_GammaG.Name = "Label_GammaG";
            this.Label_GammaG.Size = new System.Drawing.Size(57, 13);
            this.Label_GammaG.TabIndex = 14;
            this.Label_GammaG.Text = "Gamma G:";
            // 
            // Label_GammaB
            // 
            this.Label_GammaB.AutoSize = true;
            this.Label_GammaB.Location = new System.Drawing.Point(140, 124);
            this.Label_GammaB.Name = "Label_GammaB";
            this.Label_GammaB.Size = new System.Drawing.Size(56, 13);
            this.Label_GammaB.TabIndex = 15;
            this.Label_GammaB.Text = "Gamma B:";
            // 
            // RestoreOriginalGammaBtn
            // 
            this.RestoreOriginalGammaBtn.Location = new System.Drawing.Point(8, 166);
            this.RestoreOriginalGammaBtn.Name = "RestoreOriginalGammaBtn";
            this.RestoreOriginalGammaBtn.Size = new System.Drawing.Size(192, 23);
            this.RestoreOriginalGammaBtn.TabIndex = 16;
            this.RestoreOriginalGammaBtn.Text = "Restore Original Gamma";
            this.RestoreOriginalGammaBtn.UseVisualStyleBackColor = true;
            this.RestoreOriginalGammaBtn.Click += new System.EventHandler(this.RestoreOriginalGammaBtn_Click);
            // 
            // DisableGammaCorrectionBtn
            // 
            this.DisableGammaCorrectionBtn.Location = new System.Drawing.Point(8, 195);
            this.DisableGammaCorrectionBtn.Name = "DisableGammaCorrectionBtn";
            this.DisableGammaCorrectionBtn.Size = new System.Drawing.Size(192, 23);
            this.DisableGammaCorrectionBtn.TabIndex = 17;
            this.DisableGammaCorrectionBtn.Text = "Disable Gamma Correction";
            this.DisableGammaCorrectionBtn.UseVisualStyleBackColor = true;
            this.DisableGammaCorrectionBtn.Click += new System.EventHandler(this.DisableGammaCorrectionBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 222);
            this.Controls.Add(this.DisableGammaCorrectionBtn);
            this.Controls.Add(this.RestoreOriginalGammaBtn);
            this.Controls.Add(this.Label_GammaB);
            this.Controls.Add(this.Label_GammaG);
            this.Controls.Add(this.Label_GammaR);
            this.Controls.Add(this.GammaColor_B_TextBox);
            this.Controls.Add(this.GammaColor_G_TextBox);
            this.Controls.Add(this.GammaColor_R_TextBox);
            this.Controls.Add(this.RenderingRes_Y_TextBox);
            this.Controls.Add(this.RenderingRes_X_TextBox);
            this.Controls.Add(this.Label_X);
            this.Controls.Add(this.Label_RenderingRes);
            this.Controls.Add(this.RestoreOriginalResBtn);
            this.Controls.Add(this.Label_XexFileName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "SU360XexTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_XexFileName;
        private System.Windows.Forms.Button RestoreOriginalResBtn;
        private System.Windows.Forms.Label Label_RenderingRes;
        private System.Windows.Forms.Label Label_X;
        private System.Windows.Forms.TextBox RenderingRes_X_TextBox;
        private System.Windows.Forms.TextBox RenderingRes_Y_TextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenXex;
        private System.Windows.Forms.ToolStripMenuItem SaveXex;
        private System.Windows.Forms.TextBox GammaColor_R_TextBox;
        private System.Windows.Forms.TextBox GammaColor_G_TextBox;
        private System.Windows.Forms.TextBox GammaColor_B_TextBox;
        private System.Windows.Forms.Label Label_GammaR;
        private System.Windows.Forms.Label Label_GammaG;
        private System.Windows.Forms.Label Label_GammaB;
        private System.Windows.Forms.Button RestoreOriginalGammaBtn;
        private System.Windows.Forms.Button DisableGammaCorrectionBtn;
    }
}

