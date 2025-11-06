# How to Change the Font Size of Editor Texts After config.xml Has Been Loaded
## Overview
This repository demonstrates how to modify the font size of editor texts in a syntax editor control after the config.xml file has been loaded.

Customization of text appearance is achieved using the ISnippetFormat interface and Lexems, which allow developers to define how specific language elements should be displayed. By identifying the language used in the editor and applying formatting properties such as font style, font family, font size, and font color, developers can enhance the readability and visual appeal of code snippets.

## Example: C# Implementation
In a C# application, you can define a custom format for keywords using ISnippetFormat. For instance, you can set the font color to red, apply an italic style, and specify a font size. Then, using ConfigLexem, you define a regular expression pattern to match keywords and associate it with the custom format.

``` C#
ISnippetFormat keywordFormat = this.editControl1.Language.Add("Keyword");
keywordFormat.FontColor = Color.Red;
keywordFormat.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Italic);

ConfigLexem configLex = new ConfigLexem("[A-Z]+", "", FormatType.Custom, false);
configLex.IsBeginRegex = true;
configLex.IsEndRegex = true;
configLex.FormatName = "Keyword";

editControl1.Language.Lexems.Add(configLex);
editControl1.Language.ResetCaches();
```

## Key Steps
- Create a custom format using ISnippetFormat.
- Define a Lexem with a regex pattern to match specific text (e.g., keywords).
- Associate the Lexem with the custom format.
- Add the Lexem to the language configuration.
- Reset the editor caches to apply the changes.
  
