namespace SU360ResChanger
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
            this.label1 = new System.Windows.Forms.Label();
            this.LoadedXexTextBox = new System.Windows.Forms.TextBox();
            this.RestoreOriginalResBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RenderingRes_X_TextBox = new System.Windows.Forms.TextBox();
            this.RenderingRes_Y_TextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenXex = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveXex = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xex File:";
            // 
            // LoadedXexTextBox
            // 
            this.LoadedXexTextBox.Location = new System.Drawing.Point(56, 27);
            this.LoadedXexTextBox.Name = "LoadedXexTextBox";
            this.LoadedXexTextBox.Size = new System.Drawing.Size(280, 20);
            this.LoadedXexTextBox.TabIndex = 0;
            // 
            // RestoreOriginalResBtn
            // 
            this.RestoreOriginalResBtn.Location = new System.Drawing.Point(87, 91);
            this.RestoreOriginalResBtn.Name = "RestoreOriginalResBtn";
            this.RestoreOriginalResBtn.Size = new System.Drawing.Size(226, 23);
            this.RestoreOriginalResBtn.TabIndex = 4;
            this.RestoreOriginalResBtn.Text = "Restore Original Res";
            this.RestoreOriginalResBtn.UseVisualStyleBackColor = true;
            this.RestoreOriginalResBtn.Click += new System.EventHandler(this.RestoreOriginalResBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "RenderingRes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            // 
            // RenderingRes_X_TextBox
            // 
            this.RenderingRes_X_TextBox.Location = new System.Drawing.Point(87, 65);
            this.RenderingRes_X_TextBox.Name = "RenderingRes_X_TextBox";
            this.RenderingRes_X_TextBox.Size = new System.Drawing.Size(100, 20);
            this.RenderingRes_X_TextBox.TabIndex = 7;
            this.RenderingRes_X_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RenderingRes_X_TextBox_KeyPress);
            // 
            // RenderingRes_Y_TextBox
            // 
            this.RenderingRes_Y_TextBox.Location = new System.Drawing.Point(213, 65);
            this.RenderingRes_Y_TextBox.Name = "RenderingRes_Y_TextBox";
            this.RenderingRes_Y_TextBox.Size = new System.Drawing.Size(100, 20);
            this.RenderingRes_Y_TextBox.TabIndex = 8;
            this.RenderingRes_Y_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RenderingRes_X_TextBox_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(344, 24);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 121);
            this.Controls.Add(this.RenderingRes_Y_TextBox);
            this.Controls.Add(this.RenderingRes_X_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RestoreOriginalResBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadedXexTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "SU360ResChanger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoadedXexTextBox;
        private System.Windows.Forms.Button RestoreOriginalResBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RenderingRes_X_TextBox;
        private System.Windows.Forms.TextBox RenderingRes_Y_TextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenXex;
        private System.Windows.Forms.ToolStripMenuItem SaveXex;
    }
}

