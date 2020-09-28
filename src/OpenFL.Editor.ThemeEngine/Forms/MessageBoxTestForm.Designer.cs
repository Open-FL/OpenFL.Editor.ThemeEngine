namespace OpenFL.Editor.ThemeEngine.Forms
{
    partial class MessageBoxTestForm
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
            this.btnShowDialog = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblContentStyle = new System.Windows.Forms.Label();
            this.cbContentStyle = new System.Windows.Forms.ComboBox();
            this.cbMaxmize = new System.Windows.Forms.CheckBox();
            this.cbMinimize = new System.Windows.Forms.CheckBox();
            this.cbClose = new System.Windows.Forms.CheckBox();
            this.cbIcon = new System.Windows.Forms.ComboBox();
            this.lblIcon = new System.Windows.Forms.Label();
            this.cbHasImage = new System.Windows.Forms.CheckBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.nudSizeWidth = new System.Windows.Forms.NumericUpDown();
            this.nudSizeHeight = new System.Windows.Forms.NumericUpDown();
            this.cbBorderStyle = new System.Windows.Forms.ComboBox();
            this.lblBorderStyle = new System.Windows.Forms.Label();
            this.cbMessageBoxButtons = new System.Windows.Forms.ComboBox();
            this.lblMessageBoxButtons = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Location = new System.Drawing.Point(12, 321);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(232, 23);
            this.btnShowDialog.TabIndex = 0;
            this.btnShowDialog.Text = "Show";
            this.btnShowDialog.UseVisualStyleBackColor = true;
            this.btnShowDialog.Click += new System.EventHandler(this.btnShowDialog_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(14, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(85, 14);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(157, 20);
            this.tbTitle.TabIndex = 2;
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(87, 172);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(157, 96);
            this.rtbContent.TabIndex = 3;
            this.rtbContent.Text = "";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(14, 175);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(47, 13);
            this.lblContent.TabIndex = 4;
            this.lblContent.Text = "Content:";
            // 
            // lblContentStyle
            // 
            this.lblContentStyle.AutoSize = true;
            this.lblContentStyle.Location = new System.Drawing.Point(12, 43);
            this.lblContentStyle.Name = "lblContentStyle";
            this.lblContentStyle.Size = new System.Drawing.Size(33, 13);
            this.lblContentStyle.TabIndex = 5;
            this.lblContentStyle.Text = "Style:";
            // 
            // cbContentStyle
            // 
            this.cbContentStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContentStyle.FormattingEnabled = true;
            this.cbContentStyle.Items.AddRange(new object[] {
            "Text",
            "Rich Text"});
            this.cbContentStyle.Location = new System.Drawing.Point(85, 40);
            this.cbContentStyle.Name = "cbContentStyle";
            this.cbContentStyle.Size = new System.Drawing.Size(157, 21);
            this.cbContentStyle.TabIndex = 6;
            // 
            // cbMaxmize
            // 
            this.cbMaxmize.AutoSize = true;
            this.cbMaxmize.Location = new System.Drawing.Point(87, 274);
            this.cbMaxmize.Name = "cbMaxmize";
            this.cbMaxmize.Size = new System.Drawing.Size(69, 17);
            this.cbMaxmize.TabIndex = 7;
            this.cbMaxmize.Text = "Maximize";
            this.cbMaxmize.UseVisualStyleBackColor = true;
            // 
            // cbMinimize
            // 
            this.cbMinimize.AutoSize = true;
            this.cbMinimize.Location = new System.Drawing.Point(176, 274);
            this.cbMinimize.Name = "cbMinimize";
            this.cbMinimize.Size = new System.Drawing.Size(66, 17);
            this.cbMinimize.TabIndex = 8;
            this.cbMinimize.Text = "Minimize";
            this.cbMinimize.UseVisualStyleBackColor = true;
            // 
            // cbClose
            // 
            this.cbClose.AutoSize = true;
            this.cbClose.Checked = true;
            this.cbClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbClose.Location = new System.Drawing.Point(87, 297);
            this.cbClose.Name = "cbClose";
            this.cbClose.Size = new System.Drawing.Size(52, 17);
            this.cbClose.TabIndex = 9;
            this.cbClose.Text = "Close";
            this.cbClose.UseVisualStyleBackColor = true;
            // 
            // cbIcon
            // 
            this.cbIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIcon.FormattingEnabled = true;
            this.cbIcon.Items.AddRange(new object[] {
            "Text",
            "Rich Text"});
            this.cbIcon.Location = new System.Drawing.Point(85, 67);
            this.cbIcon.Name = "cbIcon";
            this.cbIcon.Size = new System.Drawing.Size(157, 21);
            this.cbIcon.TabIndex = 11;
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(14, 70);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(31, 13);
            this.lblIcon.TabIndex = 10;
            this.lblIcon.Text = "Icon:";
            // 
            // cbHasImage
            // 
            this.cbHasImage.AutoSize = true;
            this.cbHasImage.Checked = true;
            this.cbHasImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHasImage.Location = new System.Drawing.Point(165, 297);
            this.cbHasImage.Name = "cbHasImage";
            this.cbHasImage.Size = new System.Drawing.Size(77, 17);
            this.cbHasImage.TabIndex = 12;
            this.cbHasImage.Text = "Has Image";
            this.cbHasImage.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(14, 149);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 13);
            this.lblSize.TabIndex = 13;
            this.lblSize.Text = "Size:";
            // 
            // nudSizeWidth
            // 
            this.nudSizeWidth.Location = new System.Drawing.Point(85, 147);
            this.nudSizeWidth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudSizeWidth.Name = "nudSizeWidth";
            this.nudSizeWidth.Size = new System.Drawing.Size(76, 20);
            this.nudSizeWidth.TabIndex = 14;
            // 
            // nudSizeHeight
            // 
            this.nudSizeHeight.Location = new System.Drawing.Point(167, 147);
            this.nudSizeHeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudSizeHeight.Name = "nudSizeHeight";
            this.nudSizeHeight.Size = new System.Drawing.Size(75, 20);
            this.nudSizeHeight.TabIndex = 15;
            // 
            // cbBorderStyle
            // 
            this.cbBorderStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBorderStyle.FormattingEnabled = true;
            this.cbBorderStyle.Items.AddRange(new object[] {
            "Text",
            "Rich Text"});
            this.cbBorderStyle.Location = new System.Drawing.Point(85, 94);
            this.cbBorderStyle.Name = "cbBorderStyle";
            this.cbBorderStyle.Size = new System.Drawing.Size(157, 21);
            this.cbBorderStyle.TabIndex = 17;
            // 
            // lblBorderStyle
            // 
            this.lblBorderStyle.AutoSize = true;
            this.lblBorderStyle.Location = new System.Drawing.Point(12, 97);
            this.lblBorderStyle.Name = "lblBorderStyle";
            this.lblBorderStyle.Size = new System.Drawing.Size(67, 13);
            this.lblBorderStyle.TabIndex = 16;
            this.lblBorderStyle.Text = "Border Style:";
            // 
            // cbMessageBoxButtons
            // 
            this.cbMessageBoxButtons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMessageBoxButtons.FormattingEnabled = true;
            this.cbMessageBoxButtons.Items.AddRange(new object[] {
            "Text",
            "Rich Text"});
            this.cbMessageBoxButtons.Location = new System.Drawing.Point(85, 121);
            this.cbMessageBoxButtons.Name = "cbMessageBoxButtons";
            this.cbMessageBoxButtons.Size = new System.Drawing.Size(157, 21);
            this.cbMessageBoxButtons.TabIndex = 19;
            // 
            // lblMessageBoxButtons
            // 
            this.lblMessageBoxButtons.AutoSize = true;
            this.lblMessageBoxButtons.Location = new System.Drawing.Point(12, 124);
            this.lblMessageBoxButtons.Name = "lblMessageBoxButtons";
            this.lblMessageBoxButtons.Size = new System.Drawing.Size(46, 13);
            this.lblMessageBoxButtons.TabIndex = 18;
            this.lblMessageBoxButtons.Text = "Buttons:";
            // 
            // MessageBoxTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 356);
            this.Controls.Add(this.cbMessageBoxButtons);
            this.Controls.Add(this.lblMessageBoxButtons);
            this.Controls.Add(this.cbBorderStyle);
            this.Controls.Add(this.lblBorderStyle);
            this.Controls.Add(this.nudSizeHeight);
            this.Controls.Add(this.nudSizeWidth);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.cbHasImage);
            this.Controls.Add(this.cbIcon);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.cbMinimize);
            this.Controls.Add(this.cbMaxmize);
            this.Controls.Add(this.cbContentStyle);
            this.Controls.Add(this.lblContentStyle);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnShowDialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MessageBoxTestForm";
            this.Text = "MessageBoxTestForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowDialog;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblContentStyle;
        private System.Windows.Forms.ComboBox cbContentStyle;
        private System.Windows.Forms.CheckBox cbMaxmize;
        private System.Windows.Forms.CheckBox cbMinimize;
        private System.Windows.Forms.CheckBox cbClose;
        private System.Windows.Forms.ComboBox cbIcon;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.CheckBox cbHasImage;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.NumericUpDown nudSizeWidth;
        private System.Windows.Forms.NumericUpDown nudSizeHeight;
        private System.Windows.Forms.ComboBox cbBorderStyle;
        private System.Windows.Forms.Label lblBorderStyle;
        private System.Windows.Forms.ComboBox cbMessageBoxButtons;
        private System.Windows.Forms.Label lblMessageBoxButtons;
    }
}