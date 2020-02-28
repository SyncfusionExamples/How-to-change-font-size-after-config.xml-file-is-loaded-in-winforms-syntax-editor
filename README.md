# This document describes how to change the font size of editor texts after config.xml file has been loaded 

We can change the font style, font family, font size and font color of editor texts using ISnippetFormat and Lexems by deriving the language used and changing the above-mentioned properties of font and adding that Lexems for that language in config.xml.
## C#
            ISnippetFormat keywordFormat = this.editControl1.Language.Add("Keyword");
            keywordFormat.FontColor = Color.Red;
            keywordFormat.Font = new Font(FontFamily.GenericSansSerif, 14,FontStyle.Italic);

            ConfigLexem configLex = new ConfigLexem("[A-Z]+", "", FormatType.Custom, false);


            configLex.IsBeginRegex = true;
            configLex.IsEndRegex = true;
            configLex.FormatName = "Keyword";


            editControl1.Language.Lexems.Add(configLex);
            editControl1.Language.ResetCaches();

