﻿#region Using Directives

using System;

#endregion Using Directives


namespace ScintillaNET
{
    // NOTE: The Scintilla.WndProc function needs to specifically allow the custom BindableCommand values that we've
    // created (above 10000). Any additions here need to be kept in sync with the range supported by that function.
    // Next = 10025

    /// <summary>
    ///     List of commands that ScintillaNET can execute. These can be
    ///     bound to keyboard shortcuts
    /// </summary>
    public enum BindableCommand
    {
        AcceptActiveSnippets = 10006,
        AutoCCancel = 2101,
        AutoCComplete = 2104,
        AutoCShow = 10001,
        BackTab = 2328,
        BeginUndoAction = 2078,
        CallTipCancel = 2201,
        Cancel = 2325,
        CancelActiveSnippets = 10005,
        CharLeft = 2304,
        CharLeftExtend = 2305,
        CharLeftRectExtend = 2428,
        CharRight = 2306,
        CharRightExtend = 2307,
        CharRightRectExtend = 2429,
        ChooseCaretX = 2399,
        Clear = 2180,
        ClearAll = 2004,
        ClearAllCmdKeys = 2072,
        ClearDocumentStyle = 2005,
        ClearRegisteredImages = 2408,
        Copy = 2178,
        Cut = 2177,
        DeleteBack = 2326,
        DeleteBackNotLine = 2344,
        DelLineLeft = 2395,
        DelLineRight = 2396,
        DelWordLeft = 2335,
        DelWordRight = 2336,
        DocumentEnd = 2318,
        DocumentEndExtend = 2319,
        DocumentNavigateBackward = 10018,
        DocumentNavigateForward = 10019,
        DocumentStart = 2316,
        DocumentStartExtend = 2317,
        DoSnippetCheck = 10002,
        DropMarkerCollect = 10008,
        DropMarkerDrop = 10007,
        EditToggleOvertype = 2324,
        EmptyUndoBuffer = 2175,
        EndUndoAction = 2079,
        FindNext = 10013,
        FindPrevious = 10014,
        FormFeed = 2330,
        GrabFocus = 2400,
        Home = 2312,
        HomeDisplay = 2345,
        HomeDisplayExtend = 2346,
        HomeExtend = 2313,
        HomeRectExtend = 2430,
        HomeWrap = 2349,
        HomeWrapExtend = 2450,
        IncrementalSearch = 10015,
        LineCopy = 2455,
        LineComment = 10016,
        LineCut = 2337,
        LineDelete = 2338,
        LineDown = 2300,
        LineDownExtend = 2301,
        LineDownRectExtend = 2426,
        LineDuplicate = 2404,
        LineEnd = 2314,
        LineEndDisplay = 2347,
        LineEndDisplayExtend = 2348,
        LineEndExtend = 2315,
        LineEndRectExtend = 2432,
        LineEndWrap = 2451,
        LineEndWrapExtend = 2452,
        LineScrollDown = 2342,
        LineScrollUp = 2343,
        LinesJoin = 2288,
        LineTranspose = 2339,
        LineUncomment = 10017,
        LineUp = 2302,
        LineUpExtend = 2303,
        LineUpRectExtend = 2427,
        LowerCase = 2340,
        MoveCaretInsideView = 2401,
        MoveSelectedLinesDown = 2621,
        MoveSelectedLinesUp = 2620,
        NewLine = 2329,
        NextSnippetRange = 10003,
        Null = 2172,
        PageDown = 2322,
        PageDownExtend = 2323,
        PageDownRectExtend = 2434,
        PageUp = 2320,
        PageUpExtend = 2321,
        PageUpRectExtend = 2433,
        ParaDown = 2413,
        ParaDownExtend = 2414,
        ParaUp = 2415,
        ParaUpExtend = 2416,
        PreviousSnippetRange = 10004,
        Print = 10009,
        PrintPreview = 10010,
        Paste = 2179,
        Redo = 2011,
        ScrollCaret = 2169,
        SearchAnchor = 2366,
        SelectAll = 2013,
        SelectionDuplicate = 2469,
        SetCharsDefault = 2444,
        SetSavePoint = 2014,
        SetZoom = 2373,
        ShowFind = 10011,
        ShowReplace = 10012,
        ShowSnippetList = 10022,
        ShowSurroundWithList = 10023,
        ShowGoTo = 10024,
        StartRecord = 3001,
        StreamComment = 10021,
        StopRecord = 3002,
        StutteredPageDown = 2437,
        StutteredPageDownExtend = 2438,
        StutteredPageUp = 2435,
        StutteredPageUpExtend = 2436,
        StyleClearAll = 2050,
        StyleResetDefault = 2058,
        Tab = 2327,
        TargetFromSelection = 2287,
        ToggleCaretSticky = 2459,
        ToggleLineComment = 10020,
        Undo = 2176,
        UpperCase = 2341,
        VCHome = 2331,
        VCHomeExtend = 2332,
        VCHomeRectExtend = 2431,
        VCHomeWrap = 2453,
        VCHomeWrapExtend = 2454,
        WordLeft = 2308,
        WordLeftEnd = 2439,
        WordLeftEndExtend = 2440,
        WordLeftExtend = 2309,
        WordPartLeft = 2390,
        WordPartLeftExtend = 2391,
        WordPartRight = 2392,
        WordPartRightExtend = 2393,
        WordRight = 2310,
        WordRightEnd = 2441,
        WordRightEndExtend = 2442,
        WordRightExtend = 2311,
        ZoomIn = 2333,
        ZoomOut = 2334,
    }
}
