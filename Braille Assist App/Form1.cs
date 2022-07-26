using MaterialSkin;
using MaterialSkin.Controls;
using System.ComponentModel;
//using Translator.braille;
using System.Drawing.Printing;
using System.Globalization;
using Braille_Assist_App;
using System.Drawing;
//using System.Drawing.Printing;
using System.Text;
using System.Collections.Generic;

using System.Data;
using System.Collections;
using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;

//using System.IO.

namespace Braille_Assist_App
{
    public partial class Form1 : MaterialForm
    {
        string a = null;
        SaveFileDialog s = new SaveFileDialog();//file save dialogue ,not implemented yet
        OpenFileDialog file = new OpenFileDialog();
        string Title = "Untitled-Braille";
        readonly MaterialSkin.MaterialSkinManager materialskinManager;
        public Form1()
        {
            materialskinManager = MaterialSkinManager.Instance;
            materialskinManager.EnforceBackcolorOnAllComponents = true;
            materialskinManager.AddFormToManage(this);
            materialskinManager.Theme = MaterialSkinManager.Themes.DARK;
            // materialskinManager.ColorScheme(materialskinManager.ColorScheme.)
            materialskinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green700, MaterialSkin.Primary.Pink400, MaterialSkin.Primary.Brown400, MaterialSkin.Accent.Blue700, MaterialSkin.TextShade.WHITE);
          
            InitializeComponent();

        }

        private void materialFloatingActionButton1_Click(object sender, System.EventArgs e)
        {
            MaterialMessageBox.Show("hello");
        }

        private void bClear_Click(object sender, System.EventArgs e)
        {

            Braille_Table.ResetFlags(); //reset back to initial flags

            richBraille.Clear();
            richText.Clear();
        }
        private void SetFont()
        {
            // get the font name and style
            FontFamily fname = new FontFamily(ComboFontFamily.Text);
            FontStyle fs = FontStyle.Regular;


            FontStyle fstyle = (FontStyle)Enum.Parse(typeof(FontStyle), ComboFontStyle.Text, true);

            richBraille.Font = new Font(ComboFontFamily.Text,
                float.Parse(ComboFontSize.Text, CultureInfo.InvariantCulture.NumberFormat), fstyle);

            richText.Font = new Font(ComboFontFamily.Text,
                float.Parse(ComboFontSize.Text, CultureInfo.InvariantCulture.NumberFormat), fstyle);
        }

        private void bTranslate_Click(object sender, System.EventArgs e)
        {
            Braille_Table.ResetFlags(); //reset back to initial flags

            richBraille.Text = "";

            string data = richText.Text;


            // As first pass we just parse each char. In future we need to parse this to be able to markup properly.
            foreach (char c in data)
            {
                // richtext.Text += BrailleTable.ToBraille(c);
                richBraille.Text += Braille_Table.ToBraille(c);
            }
        }
        private StringBuilder sb = new StringBuilder();
        private void bPrint_Click(object sender, System.EventArgs e)
        { //private StringBuilder sb = new StringBuilder();
            /** PrintDocument printDocument1 = new PrintDocument();
                 //PrintPreviewDialog l = new PrintPreviewDialog();

                 
               //  PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                 //printPreviewDialog1.Icon = new Icon("..\\..\\braille.ico");

                 sb.Append(richBraille.Text);

                 printDocument1.PrintPage += PrintDocument_PrintPage;
                 printPreviewDialog1.Document = printDocument1;

                 printPreviewDialog1.ShowDialog();

                 printDocument1.Dispose();
                 printPreviewDialog1.Dispose();
                 ***/
            PrintDocument printDocument1 = new PrintDocument();
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
           // printPreviewDialog1.Icon = new Icon("..\\..\\braille.ico");

            sb.Append(richBraille.Text);
            //System.Windows.Forms.PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
           // System.Windows.Forms.prin

            printDocument1.PrintPage += PrintDocument_PrintPage;
            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.ShowDialog();

            printDocument1.Dispose();
            printPreviewDialog1.Dispose();




        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            //comes in here for every page it needs to make

            int charactersOnPage = 0;
            int linesPerPage = 0;
            Font drawFont = new Font(richBraille.Font.ToString(), richBraille.Font.Size);

            // Sets the value of charactersOnPage to the number of characters
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(richBraille.Text, drawFont,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page
            e.Graphics.DrawString(richBraille.Text, drawFont, Brushes.Black,
                e.MarginBounds, StringFormat.GenericTypographic);


            // Remove the portion of the string that has been printed.
            richBraille.Text = richBraille.Text.Substring(charactersOnPage);


            // Check to see if more pages are to be printed.
            // replace the text when the window is empty so we have something to print
            // otherwise we print a balnk document.

            if (richBraille.Text.Length > 0)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
                richBraille.Text = sb.ToString();
            }
        }


        private void bLeft_Click(object sender, System.EventArgs e)
        {
            // get the font name and style
            FontFamily fname = new FontFamily(ComboFontFamily.Text);
            FontStyle fs = FontStyle.Regular;
            


            FontStyle fstyle = (FontStyle)Enum.Parse(typeof(FontStyle), ComboFontStyle.Text, true);

            richText.Font = new Font(ComboFontFamily.Text,
                float.Parse(ComboFontSize.Text, CultureInfo.InvariantCulture.NumberFormat), fstyle);
        }

        //private StringBuilder sb = new StringBuilder(); //needed to replace text into richtextbox after preview

       // public PrintPageEventHandler PrintDocument_PrintPage { get; private set; }

        private void bAll_Click(object sender, System.EventArgs e)
        {
            {
                SetFont();
            }

            
        }
       

        private void bRight_Click(object sender, System.EventArgs e)
        {
            // get the font name and style
            FontFamily fname = new FontFamily(ComboFontFamily.Text);
            FontStyle fs = FontStyle.Regular;


            FontStyle fstyle = (FontStyle)Enum.Parse(typeof(FontStyle), ComboFontStyle.Text, true);

            richText.Font = new Font(ComboFontFamily.Text,
                float.Parse(ComboFontSize.Text, CultureInfo.InvariantCulture.NumberFormat), fstyle);
        }

        private void bClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                ComboFontFamily.Items.Add(oneFontFamily.Name);
            }

            ComboFontFamily.SelectedIndex = 6;
            ComboFontSize.SelectedIndex = 8;
            ComboFontStyle.SelectedIndex = 2;

            SetFont();
        }

        private void printPreviewDialog1_Load(object sender, System.EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            
            int charactersOnPage = 0;
            int linesPerPage = 0;
            Font drawFont = new Font(richBraille.Font.ToString(), richBraille.Font.Size);

            // Sets the value of charactersOnPage to the number of characters
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(richBraille.Text, drawFont,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page
            e.Graphics.DrawString(richBraille.Text, drawFont, Brushes.Black,
                e.MarginBounds, StringFormat.GenericTypographic);


            // Remove the portion of the string that has been printed.
             richBraille.Text = richBraille.Text.Substring(charactersOnPage);
           

            // Check to see if more pages are to be printed.
            // replace the text when the window is empty so we have something to print
            // otherwise we print a balnk document.
            
             if (richBraille.Text.Length > 0)
             {
                 e.HasMorePages = true;
             }
             else
             {
                 e.HasMorePages = false;
                 richBraille.Text = sb.ToString();
             }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            


             
            s.DefaultExt = "*.brf";
            s.Filter = "Braille File|*.brf";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK && s.FileName.Length > 0)
            {
              richBraille.SaveFile(s.FileName, RichTextBoxStreamType.PlainText);
                //richBraille.SaveFile(s.FileName, RichTextBoxStreamType.UnicodePlainText);
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            s.DefaultExt = "*.txt";
            s.Filter = "Word  Files File|*.doc";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK && s.FileName.Length > 0)
            {
                richText.SaveFile(s.FileName, RichTextBoxStreamType.PlainText);
                //richBraille.SaveFile(s.FileName, RichTextBoxStreamType.UnicodePlainText);
            }

        }
        private void SaveFile()
        {

            s.Title = "Save As";

            s.Filter = "Text Document|*.txt";//applied filter       

            s.DefaultExt = "txt";//applied default extension    

            if (s.ShowDialog() == DialogResult.OK)

            {

                

                {

                    richBraille.SaveFile(s.FileName, RichTextBoxStreamType.PlainText);
                    var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(s.FileName);
                    this.Text = fileNameWithoutExtension + "-" + Title;

                           

                }

            }

        }
    }
}

