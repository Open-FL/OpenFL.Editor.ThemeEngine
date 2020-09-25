namespace OpenFL.Editor.ThemeEngine.Forms
{
    partial class EditorThemeSettingsForm
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.gbEditor = new System.Windows.Forms.GroupBox();
            this.btnLoadStyle = new System.Windows.Forms.Button();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.cdChangeThemeColor = new System.Windows.Forms.ColorDialog();
            this.sfdTheme = new System.Windows.Forms.SaveFileDialog();
            this.fbdSelectHomeDir = new System.Windows.Forms.FolderBrowserDialog();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelTopFill = new System.Windows.Forms.Panel();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.panelButtons.SuspendLayout();
            this.gbEditor.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelTopFill.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.DimGray;
            this.panelButtons.Controls.Add(this.gbEditor);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(471, 299);
            this.panelButtons.TabIndex = 2;
            // 
            // gbEditor
            // 
            this.gbEditor.Controls.Add(this.panelGrid);
            this.gbEditor.Controls.Add(this.panelTop);
            this.gbEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEditor.Location = new System.Drawing.Point(0, 0);
            this.gbEditor.Name = "gbEditor";
            this.gbEditor.Size = new System.Drawing.Size(471, 299);
            this.gbEditor.TabIndex = 18;
            this.gbEditor.TabStop = false;
            this.gbEditor.Text = "Editor";
            // 
            // btnLoadStyle
            // 
            this.btnLoadStyle.BackColor = System.Drawing.Color.DimGray;
            this.btnLoadStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadStyle.Location = new System.Drawing.Point(0, 0);
            this.btnLoadStyle.Name = "btnLoadStyle";
            this.btnLoadStyle.Size = new System.Drawing.Size(77, 25);
            this.btnLoadStyle.TabIndex = 33;
            this.btnLoadStyle.Text = "Load Style";
            this.btnLoadStyle.UseVisualStyleBackColor = false;
            this.btnLoadStyle.Click += new System.EventHandler(this.btnLoadStyle_Click);
            // 
            // cbStyle
            // 
            this.cbStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Location = new System.Drawing.Point(0, 0);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(388, 21);
            this.cbStyle.TabIndex = 32;
            // 
            // sfdTheme
            // 
            this.sfdTheme.DefaultExt = "xml";
            this.sfdTheme.Title = "Save the Theme";
            // 
            // fbdSelectHomeDir
            // 
            this.fbdSelectHomeDir.Description = "Select the Root directory from where the FL scripts will be called(this will fix " +
    "filenames)";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelTopFill);
            this.panelTop.Controls.Add(this.panelTopRight);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(3, 16);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(465, 25);
            this.panelTop.TabIndex = 34;
            // 
            // panelTopFill
            // 
            this.panelTopFill.Controls.Add(this.cbStyle);
            this.panelTopFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopFill.Location = new System.Drawing.Point(0, 0);
            this.panelTopFill.Name = "panelTopFill";
            this.panelTopFill.Size = new System.Drawing.Size(388, 25);
            this.panelTopFill.TabIndex = 35;
            // 
            // panelTopRight
            // 
            this.panelTopRight.Controls.Add(this.btnLoadStyle);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTopRight.Location = new System.Drawing.Point(388, 0);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(77, 25);
            this.panelTopRight.TabIndex = 36;
            // 
            // panelGrid
            // 
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(3, 41);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(465, 255);
            this.panelGrid.TabIndex = 35;
            // 
            // EditorThemeSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 299);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EditorThemeSettingsForm";
            this.Text = "Editor Theme Settings";
            this.panelButtons.ResumeLayout(false);
            this.gbEditor.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTopFill.ResumeLayout(false);
            this.panelTopRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.GroupBox gbEditor;
        private System.Windows.Forms.ColorDialog cdChangeThemeColor;
        private System.Windows.Forms.SaveFileDialog sfdTheme;
        private System.Windows.Forms.FolderBrowserDialog fbdSelectHomeDir;
        private System.Windows.Forms.Button btnLoadStyle;
        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelTopFill;
        private System.Windows.Forms.Panel panelTopRight;
    }
}