﻿/*
Copyright (c) 2003-2013, CKSource - Frederico Knabben. All rights reserved.
For licensing, see LICENSE.html or http://ckeditor.com/license
*/

CKEDITOR.editorConfig = function( config )
{
	// Define changes to default configuration here. For example:
	// config.language = 'fr';
    // config.uiColor = '#AADC6E';
    config.contentsCss = '~/library/css/fonts.css';
    config.font_names = 'Play/play;' + config.font_names;

    config.contentsCss = '~/library/css/font-awesome.css';
    config.font_names = 'FontAwesome/FontAwesome;' + config.font_names;
    



    config.toolbar = 'MyToolbar';

    config.toolbar_MyToolbar =
    [


    ["Source", "-", "NewPage", "Preview", "-", "Templates"],
    ["Cut", "Copy", "Paste", "PasteText", "PasteFromWord", "-", "Print", "SpellChecker", "Scayt"],
    ["Undo", "Redo", "-", "Find", "Replace", "-", "SelectAll", "RemoveFormat"],

    ["Form", "Checkbox", "Radio", "TextField", "Textarea", "Select", "Button", "ImageButton", "HiddenField"],
    ["Bold", "Italic", "Underline", "Strike", "-", "Subscript", "Superscript"],
    ["NumberedList", "BulletedList", "-", "Outdent", "Indent", "Blockquote", "CreateDiv"],
    ["JustifyLeft", "JustifyCenter", "JustifyRight", "JustifyBlock"],
    ["BidiLtr", "BidiRtl"],
    ["Link", "Unlink", "Anchor"],
    ["Image", "Flash", "Table", "HorizontalRule", "Smiley", "SpecialChar", "PageBreak", "Iframe"],
    ["Styles", "Format", "Font", "FontSize"],
    ["TextColor", "BGColor"],
    ["Maximize", "ShowBlocks"],


    ];




};
