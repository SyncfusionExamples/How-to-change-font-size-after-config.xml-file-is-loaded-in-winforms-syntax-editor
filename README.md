# This document describes how to change the font size of editor texts after config.xml file has been loaded 

This repository explains how to modify the font size of editor texts after the config.xml file has been loaded in a syntax editor control. The customization of text appearance in the editor is achieved using the ISnippetFormat interface and Lexems, which allow developers to define how specific language elements should be displayed. By identifying the language used in the editor and applying formatting properties such as font style, font family, font size, and font color, developers can enhance the readability and visual appeal of code snippets.
For example, in a C# application, you can define a custom format for keywords using ISnippetFormat. You can set the font color to red and apply an italic style with a specific font size. Then, using ConfigLexem, you can define a regular expression pattern to match keywords and associate it with the custom format. This lexem is added to the language configuration, and the editor caches are reset to apply the changes.
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

