using Syncfusion.Windows.Forms.Edit.Enums;
using Syncfusion.Windows.Forms.Edit.Implementation.Config;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditControlFontCustomize
{
    public partial class Form1 : Form
    {
        private string ConfigPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\config.xml";
        public Form1()
        {
            InitializeComponent();
            this.editControl1.Configurator.Open(ConfigPath);
            editControl1.NewFile(editControl1.Configurator["C#"]);
            editControl1.Language.CaseInsensitive = true;
            this.editControl1.Text = "New Table in Syntax Editor \nand how to change the font appearance \nespecially in Syntax Editor \n value of gravity is 9.816653 m/s*s";
            this.editControl1.ApplyConfiguration(Syncfusion.Windows.Forms.Edit.Enums.KnownLanguages.CSharp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISnippetFormat keywordFormat = this.editControl1.Language.Add("Keyword");
            keywordFormat.FontColor = Color.Red;
            keywordFormat.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);

            ConfigLexem configLex = new ConfigLexem("[A-Z]+", "", FormatType.Custom, false);


            configLex.IsBeginRegex = true;
            configLex.IsEndRegex = true;
            configLex.FormatName = "Keyword";

            ISnippetFormat keywordFormat1 = this.editControl1.Language.Add("Keyword1");
            keywordFormat1.FontColor = Color.Green;
            keywordFormat1.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);

            ConfigLexem configLex1 = new ConfigLexem("[1-9]+", "", FormatType.Custom, false);


            configLex.IsBeginRegex = true;
            configLex.IsEndRegex = true;
            configLex.FormatName = "Keyword";
         

            configLex1.IsBeginRegex = true;
            configLex1.IsEndRegex = true;
            configLex1.FormatName = "Keyword1";


            editControl1.Language.Lexems.Add(configLex);
            editControl1.Language.Lexems.Add(configLex1);
            editControl1.Language.ResetCaches();

        }
    }
}
