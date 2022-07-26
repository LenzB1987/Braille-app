namespace Braille_Assist_App
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
            this.bClear = new MaterialSkin.Controls.MaterialButton();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.richBraille = new System.Windows.Forms.RichTextBox();
            this.bTranslate = new MaterialSkin.Controls.MaterialButton();
            this.bPrint = new MaterialSkin.Controls.MaterialButton();
            this.bSave = new MaterialSkin.Controls.MaterialButton();
            this.bLeft = new MaterialSkin.Controls.MaterialButton();
            this.bClose = new MaterialSkin.Controls.MaterialButton();
            this.bAll = new MaterialSkin.Controls.MaterialButton();
            this.bHelp = new MaterialSkin.Controls.MaterialButton();
            this.bRight = new MaterialSkin.Controls.MaterialButton();
            this.ComboFontSize = new MaterialSkin.Controls.MaterialComboBox();
            this.ComboFontStyle = new MaterialSkin.Controls.MaterialComboBox();
            this.ComboFontFamily = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnSaveAs = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // bClear
            // 
            this.bClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bClear.Depth = 0;
            this.bClear.HighEmphasis = true;
            this.bClear.Icon = null;
            this.bClear.Location = new System.Drawing.Point(6, 477);
            this.bClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.bClear.Name = "bClear";
            this.bClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bClear.Size = new System.Drawing.Size(66, 36);
            this.bClear.TabIndex = 0;
            this.bClear.Text = "Clear";
            this.bClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bClear.UseAccentColor = false;
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // richText
            // 
            this.richText.AcceptsTab = true;
            this.richText.AutoWordSelection = true;
            this.richText.EnableAutoDragDrop = true;
            this.richText.Location = new System.Drawing.Point(6, 209);
            this.richText.Name = "richText";
            this.richText.ShowSelectionMargin = true;
            this.richText.Size = new System.Drawing.Size(507, 248);
            this.richText.TabIndex = 1;
            this.richText.Text = "";
            this.richText.UseWaitCursor = true;
            // 
            // richBraille
            // 
            this.richBraille.AcceptsTab = true;
            this.richBraille.AutoWordSelection = true;
            this.richBraille.EnableAutoDragDrop = true;
            this.richBraille.Location = new System.Drawing.Point(548, 209);
            this.richBraille.Name = "richBraille";
            this.richBraille.ShowSelectionMargin = true;
            this.richBraille.Size = new System.Drawing.Size(453, 248);
            this.richBraille.TabIndex = 2;
            this.richBraille.Text = "";
            this.richBraille.UseWaitCursor = true;
            // 
            // bTranslate
            // 
            this.bTranslate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bTranslate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bTranslate.Depth = 0;
            this.bTranslate.HighEmphasis = true;
            this.bTranslate.Icon = null;
            this.bTranslate.Location = new System.Drawing.Point(119, 477);
            this.bTranslate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bTranslate.MouseState = MaterialSkin.MouseState.HOVER;
            this.bTranslate.Name = "bTranslate";
            this.bTranslate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bTranslate.Size = new System.Drawing.Size(187, 36);
            this.bTranslate.TabIndex = 3;
            this.bTranslate.Text = "Translate to Braille";
            this.bTranslate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bTranslate.UseAccentColor = false;
            this.bTranslate.UseVisualStyleBackColor = true;
            this.bTranslate.Click += new System.EventHandler(this.bTranslate_Click);
            // 
            // bPrint
            // 
            this.bPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bPrint.Depth = 0;
            this.bPrint.HighEmphasis = true;
            this.bPrint.Icon = null;
            this.bPrint.Location = new System.Drawing.Point(351, 477);
            this.bPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.bPrint.Name = "bPrint";
            this.bPrint.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bPrint.Size = new System.Drawing.Size(124, 36);
            this.bPrint.TabIndex = 4;
            this.bPrint.Text = "Print braille ";
            this.bPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bPrint.UseAccentColor = false;
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // bSave
            // 
            this.bSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bSave.Depth = 0;
            this.bSave.HighEmphasis = true;
            this.bSave.Icon = null;
            this.bSave.Location = new System.Drawing.Point(654, 477);
            this.bSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.bSave.Name = "bSave";
            this.bSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bSave.Size = new System.Drawing.Size(157, 36);
            this.bSave.TabIndex = 5;
            this.bSave.Text = "Save Braille Text";
            this.bSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bSave.UseAccentColor = false;
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bLeft
            // 
            this.bLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bLeft.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bLeft.Depth = 0;
            this.bLeft.HighEmphasis = true;
            this.bLeft.Icon = null;
            this.bLeft.Location = new System.Drawing.Point(7, 164);
            this.bLeft.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.bLeft.Name = "bLeft";
            this.bLeft.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bLeft.Size = new System.Drawing.Size(118, 36);
            this.bLeft.TabIndex = 6;
            this.bLeft.Text = "Change Left";
            this.bLeft.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bLeft.UseAccentColor = false;
            this.bLeft.UseVisualStyleBackColor = true;
            this.bLeft.Click += new System.EventHandler(this.bLeft_Click);
            // 
            // bClose
            // 
            this.bClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bClose.Depth = 0;
            this.bClose.HighEmphasis = true;
            this.bClose.Icon = null;
            this.bClose.Location = new System.Drawing.Point(591, 164);
            this.bClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.bClose.Name = "bClose";
            this.bClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bClose.Size = new System.Drawing.Size(98, 36);
            this.bClose.TabIndex = 7;
            this.bClose.Text = "Close App";
            this.bClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bClose.UseAccentColor = false;
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bAll
            // 
            this.bAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bAll.Depth = 0;
            this.bAll.HighEmphasis = true;
            this.bAll.Icon = null;
            this.bAll.Location = new System.Drawing.Point(159, 164);
            this.bAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.bAll.Name = "bAll";
            this.bAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bAll.Size = new System.Drawing.Size(110, 36);
            this.bAll.TabIndex = 8;
            this.bAll.Text = "Change All";
            this.bAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bAll.UseAccentColor = false;
            this.bAll.UseVisualStyleBackColor = true;
            this.bAll.Click += new System.EventHandler(this.bAll_Click);
            // 
            // bHelp
            // 
            this.bHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bHelp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bHelp.Depth = 0;
            this.bHelp.HighEmphasis = true;
            this.bHelp.Icon = null;
            this.bHelp.Location = new System.Drawing.Point(482, 164);
            this.bHelp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bHelp.MouseState = MaterialSkin.MouseState.HOVER;
            this.bHelp.Name = "bHelp";
            this.bHelp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bHelp.Size = new System.Drawing.Size(64, 36);
            this.bHelp.TabIndex = 9;
            this.bHelp.Text = "Help";
            this.bHelp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bHelp.UseAccentColor = false;
            this.bHelp.UseVisualStyleBackColor = true;
            // 
            // bRight
            // 
            this.bRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bRight.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bRight.Depth = 0;
            this.bRight.HighEmphasis = true;
            this.bRight.Icon = null;
            this.bRight.Location = new System.Drawing.Point(317, 164);
            this.bRight.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bRight.MouseState = MaterialSkin.MouseState.HOVER;
            this.bRight.Name = "bRight";
            this.bRight.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bRight.Size = new System.Drawing.Size(127, 36);
            this.bRight.TabIndex = 10;
            this.bRight.Text = "Change Right";
            this.bRight.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bRight.UseAccentColor = false;
            this.bRight.UseVisualStyleBackColor = true;
            this.bRight.Click += new System.EventHandler(this.bRight_Click);
            // 
            // ComboFontSize
            // 
            this.ComboFontSize.AutoResize = false;
            this.ComboFontSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboFontSize.Depth = 0;
            this.ComboFontSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboFontSize.DropDownHeight = 174;
            this.ComboFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboFontSize.DropDownWidth = 121;
            this.ComboFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboFontSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboFontSize.FormattingEnabled = true;
            this.ComboFontSize.IntegralHeight = false;
            this.ComboFontSize.ItemHeight = 43;
            this.ComboFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.ComboFontSize.Location = new System.Drawing.Point(6, 106);
            this.ComboFontSize.MaxDropDownItems = 4;
            this.ComboFontSize.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboFontSize.Name = "ComboFontSize";
            this.ComboFontSize.Size = new System.Drawing.Size(239, 49);
            this.ComboFontSize.StartIndex = 0;
            this.ComboFontSize.TabIndex = 11;
            // 
            // ComboFontStyle
            // 
            this.ComboFontStyle.AutoResize = false;
            this.ComboFontStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboFontStyle.Depth = 0;
            this.ComboFontStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboFontStyle.DropDownHeight = 174;
            this.ComboFontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboFontStyle.DropDownWidth = 121;
            this.ComboFontStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboFontStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboFontStyle.FormattingEnabled = true;
            this.ComboFontStyle.IntegralHeight = false;
            this.ComboFontStyle.ItemHeight = 43;
            this.ComboFontStyle.Items.AddRange(new object[] {
            "Italic",
            "Bold",
            "Regular",
            "Strikeout",
            "Underline",
            "UpperCase",
            "LowerCase"});
            this.ComboFontStyle.Location = new System.Drawing.Point(654, 105);
            this.ComboFontStyle.MaxDropDownItems = 4;
            this.ComboFontStyle.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboFontStyle.Name = "ComboFontStyle";
            this.ComboFontStyle.Size = new System.Drawing.Size(287, 49);
            this.ComboFontStyle.StartIndex = 0;
            this.ComboFontStyle.TabIndex = 12;
            // 
            // ComboFontFamily
            // 
            this.ComboFontFamily.AutoResize = false;
            this.ComboFontFamily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboFontFamily.Depth = 0;
            this.ComboFontFamily.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboFontFamily.DropDownHeight = 174;
            this.ComboFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboFontFamily.DropDownWidth = 121;
            this.ComboFontFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboFontFamily.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboFontFamily.FormattingEnabled = true;
            this.ComboFontFamily.IntegralHeight = false;
            this.ComboFontFamily.ItemHeight = 43;
            this.ComboFontFamily.Location = new System.Drawing.Point(262, 105);
            this.ComboFontFamily.MaxDropDownItems = 4;
            this.ComboFontFamily.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboFontFamily.Name = "ComboFontFamily";
            this.ComboFontFamily.Size = new System.Drawing.Size(362, 49);
            this.ComboFontFamily.StartIndex = 0;
            this.ComboFontFamily.TabIndex = 13;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(35, 79);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(112, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Select Font size";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(368, 79);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(132, 19);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Select Font Family";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(705, 79);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(119, 19);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "Select Font Style";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveAs.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveAs.Depth = 0;
            this.btnSaveAs.HighEmphasis = true;
            this.btnSaveAs.Icon = null;
            this.btnSaveAs.Location = new System.Drawing.Point(489, 477);
            this.btnSaveAs.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveAs.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveAs.Size = new System.Drawing.Size(136, 36);
            this.btnSaveAs.TabIndex = 17;
            this.btnSaveAs.Text = "Save Text File";
            this.btnSaveAs.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveAs.UseAccentColor = false;
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1015, 539);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ComboFontFamily);
            this.Controls.Add(this.ComboFontStyle);
            this.Controls.Add(this.ComboFontSize);
            this.Controls.Add(this.bRight);
            this.Controls.Add(this.bHelp);
            this.Controls.Add(this.bAll);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bLeft);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.bTranslate);
            this.Controls.Add(this.richBraille);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.bClear);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Braille Text App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton bClear;
        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.RichTextBox richBraille;
        private MaterialSkin.Controls.MaterialButton bTranslate;
        private MaterialSkin.Controls.MaterialButton bPrint;
        private MaterialSkin.Controls.MaterialButton bSave;
        private MaterialSkin.Controls.MaterialButton bLeft;
        private MaterialSkin.Controls.MaterialButton bClose;
        private MaterialSkin.Controls.MaterialButton bAll;
        private MaterialSkin.Controls.MaterialButton bHelp;
        private MaterialSkin.Controls.MaterialButton bRight;
        private MaterialSkin.Controls.MaterialComboBox ComboFontSize;
        private MaterialSkin.Controls.MaterialComboBox ComboFontStyle;
        private MaterialSkin.Controls.MaterialComboBox ComboFontFamily;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private MaterialSkin.Controls.MaterialButton btnSaveAs;
    }
}

