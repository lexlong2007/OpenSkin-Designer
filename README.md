OpenSkin Designer
=================
[![GitHub release](https://img.shields.io/github/release/Humaxx/OpenSkin-Designer.svg)](https://github.com/Humaxx/OpenSkin-Designer/releases)
[![GitHub All Releases](https://img.shields.io/github/downloads/Humaxx/OpenSkin-Designer/total.svg)](https://github.com/Humaxx/OpenSkin-Designer/releases)
[![GitHub Releases (by Release)](https://img.shields.io/github/downloads/Humaxx/OpenSkin-Designer/3.2.5/total.svg)](https://github.com/Humaxx/OpenSkin-Designer/releases)
[![GitHub Releases (by Release)](https://img.shields.io/github/downloads/Humaxx/OpenSkin-Designer/3.2.4/total.svg)](https://github.com/Humaxx/OpenSkin-Designer/releases)
[![GitHub Releases (by Release)](https://img.shields.io/github/downloads/Humaxx/OpenSkin-Designer/3.2.3/total.svg)](https://github.com/Humaxx/OpenSkin-Designer/releases)
[![GitHub Releases (by Release)](https://img.shields.io/github/downloads/Humaxx/OpenSkin-Designer/3.2.0/total.svg)](https://github.com/Humaxx/OpenSkin-Designer/releases)

OpenSkin Designer is a further development of [e2skinner](https://code.google.com/p/e2skinner2/).

It includes a couple of new features i.e.:
* includes
* panels
* colored tree view
* screen search
* fold/unfold xml code
* quick add buttons (add screen, panel, widget, label, pixmap; delete item)
* simple autocomplete in code
* toggle conditional hiding element (show all, none, random, default)
* toggle markers (border indicators of elements)
* position replacement to 'center' disabled
* bugfixes
* etc.

## Notes
To view 'fMain.cs'[design] you have to delete the following lines 988-997 (they will autogenerated again...)
this.textBoxEditor2.Styles.BraceBad.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
this.textBoxEditor2.Styles.BraceLight.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
this.textBoxEditor2.Styles.CallTip.FontName = "Segoe UI\0\0\0\0\0\0\0\0\0\0\0\0";
this.textBoxEditor2.Styles.ControlChar.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
this.textBoxEditor2.Styles.Default.BackColor = System.Drawing.SystemColors.InactiveBorder;
this.textBoxEditor2.Styles.Default.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
this.textBoxEditor2.Styles.IndentGuide.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
this.textBoxEditor2.Styles.LastPredefined.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
this.textBoxEditor2.Styles.LineNumber.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
this.textBoxEditor2.Styles.Max.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";

## Screenshots
<p align="center">
<img src="Screenshots/preview1.jpg?sanitize=true&raw=true" title="preview1" width="400"/>
<img src="Screenshots/preview2.jpg?sanitize=true&raw=true" title="preview2" width="400"/>
<img src="Screenshots/preview3.jpg?sanitize=true&raw=true" title="preview3" width="400"/>
</p>

## Changelog

### 3.2.0.0 (08.04.2019)
created by [Scrounger](https://github.com/Scrounger)
* Converter: support for 'FullDescription' added
* Resize picon on element size change
* Use attribute scale for ePixmap & widget which have 'pixmap' attribute.
* Converter MovieInfo added
* Show images for widgets with any render and 'path' attribute
* Show EventImage if render attribute contains 'eventimage'
* Show XHDPicon if render attribute contains 'xhdpicon'
* Show images with 'pixmaps' attribute

### 3.2.2.0 (08.04.2019 - 21.04.2019)
created by [Scrounger](https://github.com/Scrounger)
* cConverterSimplePresets added
* Alias font bug fixes -> gobal loading / usage added
* Fonts sorting added
* Label: font bug fix property grid -> change font or fontsize
* ListBox font added to property grid
* Show font style and size for listboxes
* Font bug fix -> catch exception if font is not defined or exist
* ListBox: Show entries added
* Label metrixreloadedvrunningtext added
* ListBox: count of entries to show bug fixed
* sAttributePixmap: element with attribute 'path' -> bug fix if skinPath is part of attribute path
* converterSimple.xml: MetrixReloaded converters added

### 3.2.3.0 (23.03.2020) by Humax
* Undefined colors are added alternatively ('#' is not replaced by 'un')'
* Added a option how to add undefined colors (with '#' or with 'un')
* Fixed unhandled exception if a borderset-file isn't existing
* Fixed unhandled exception in 'Windowstyle-preview' if no borderstyle is declared in skin.xml
* Bug fix in 'Windowstyle-preview': Now displaying correct borderset and filename
* Fixed a bug that probably exists since 3.1.0.3. Font preview is now again working
* Editor: now showing up to 99999 line numbers instead of max 999
* Editor: background color changed for better contrast
* Text-preview: using lcd.ttf if declared font is not found
* Added VTi-Fonts
* Converter bug fixes: 'TimeshiftService' added to prevent a exception in 'Timeshiftstate'
* Corrected xhdpicon.png for building in visual studio

### 3.2.3.1 (23.03.2020) by Humax
* Added more sources rendered as listbox
* Fixed unhandled exception if source = null

### 3.2.3.2 (26.03.2020) by Humax
* Fixed unhandled exception if no Font is declared or only alias - then using 'lcd.ttf'
* Fixed unhandled exceptions if a color is missing or declared with 'foregroundColors'
* Ask to show messageboxes again or not
* Bugfix: show picon also when a path is set
* Added option to set 'Fallback-Color', which is used for previewing some text

### 3.2.3.3 (27.03.2020) by Humax
* Fixed path not found exception
* Updated converter.xml
* Added speedyAXBlueRunningText
* Removed doubled attributs
* Added some entries to attribut-list like 'foregroundColors' 'options' 'pixmaps' and more
* Added a option to enable showing full attribut-list
* Autocomplete attribut list - max preview set to 15 instead of 5

### 3.2.3.4 (01.04.2020) by Humax
* Added render 'ChamaeleonRunningText'
* If pixmap have a path without specified filename, take random image
* Bugfix: pixmap path
* Added all renders containing 'runningtext'
* Handling all renders containing 'list' as listbox
* Notifying about unsafed changes

### 3.2.3.5 (14.04.2020) by Humax
* Fixed an unhandled exception if image is corrupt
* Only take 'jpg'; 'jpeg' and 'png' for random picture selection

### 3.2.4.0 (04.06.2020) by Humax
* Fixed typos
* Fixed unhandled exception in 'Color Dialog'
* Allow only valid characters in Textboxes in 'Color Dialog'
* Support for language file (CustomLanguage.lng) in 'xml'-diretory

### 3.2.4.1 (05.06.2020) by Humax
* Add search for searching text in code editor

### 3.2.4.2 by Humax
* Upgraded search-function
* Added missing translation
* Fixed text from 'Open-Button' in 'Open-Dialog'

### 3.2.4.3 by Humax
* Multilanguage support
* Added missing translation
* Settings are now saved

### 3.2.4.4 by Humax
* Added missing translation

### 3.2.4.5 by Humax
* Displaying the name of the loaded skin.

### 3.2.4.6 by Humax
* Fixed unhandled exception when using right-click in designer
* Add turkish language (thanks to 'audi06)
* Bugfix: restoring language only searches for first language file in languages-directory
* Translate existing element-items after changing language

### 3.2.4.7 by Humax
* Add albanian language (thanks to 'kqiqi1')
* Fixed polish language
* Added missing translations
* Bugfix: now displaying an error message if a font is not valid

### 3.2.4.8 by Humax
* Add options to show notifications about unsafed changes
* Added missing translations
* Bugfix: Now also a notification is shown, if colors are changed
* Added 'ExtEvent' to converter.xml

### 3.2.4.9 by Humax
* Using 'delete'-key to delete select element

### 3.2.5.0 by Humax
* Added 'experimental delete-mode'
* Bugfix: Don't delete root-node
* Bugfix: 'Color-Dialog': changed 'Change'-button to 'Rename'-button
* Bugfix: 'Color-Dialog': changing a color now triggers unsafed-changes-notification
* Closing 'Color-Dialog' instead of hiding
* Changes in 'Color-Dialog' now take immediatly effect without the need to save and reload
* Nomore saveing and reloading needed if a color is defined two times.

### 3.2.5.1 by Humax
* Bugfix: fixed unhandled exception if file (include) was not found
* Bugfix: fixed unhandled exception if * is used for integer value
* Added an example in converterSimple.xml for converter-preview-text

### 3.2.5.2 by Humax
* Added an option for linewrapping in code-editor
* Typos
* Added missing translations

### 3.2.5.3 by Humax
* Bugfix: fixed unhandled exception if using delete - key without selected item
* Bugfix: using delete-key no longer deletes a selected item in propertygrid
### 3.2.5.4 by Humax
* Bugfix: Selected Treeviewnode was deleted when pressing any key in Designer-Mode
### 3.2.5.5 by Humax
* Add an option to not replace color beginning with '#'
### 3.2.5.6 by Humax
Support for QHD (WQHD) and 4K UHD (Ultra HD)
### 3.2.5.7 by Humax
* Support for resolution 3200 x 1800
* Fixed unhandled Exception when borderset has no filename
### 3.2.5.8 by Humax
* Fixed unhandled Exception when borderset path has not been specified
### 3.2.5.9 by Humax
* Fixed borderset - bug
* application will be terminated if a '.svg' graphic is used in the 'borderset's
### 3.2.6.0 by Humax
* Undo application termination if a '.svg' graphic is used in the 'borderset's
* If '.svg' graphic is used, the application searches for a corresponding '.png' graphic'
### 3.2.6.1 by Humax
* Added an option to hide attribut-list in code-editor
* Updated language-files
* After opening the skin, the main node is displayed in the code editor
* Bugfix: Notification about unsafed changes, hasn't work in every case
### 3.2.6.2 by Humax
* Fixed the display of the error message
### 3.2.6.3 by Humax
* Fixed typos
* Added dutch translation --> thanks to 'lk1zhm'
* Added new 'Converter.xml and 'simpleConverter.xml'
* Fixed some unhandled Exception when no converter was found