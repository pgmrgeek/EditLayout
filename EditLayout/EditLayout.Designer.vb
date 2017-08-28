<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditLayout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSaveClose = New System.Windows.Forms.Button()
        Me.grpLayout = New System.Windows.Forms.GroupBox()
        Me.DeleteThisLayout = New System.Windows.Forms.Button()
        Me.lblActionSetName = New System.Windows.Forms.Label()
        Me.tbActionSetName = New System.Windows.Forms.TextBox()
        Me.cbEnaMultiples = New System.Windows.Forms.CheckBox()
        Me.cbEnaGrnScrn = New System.Windows.Forms.CheckBox()
        Me.cbEnaOvrly = New System.Windows.Forms.CheckBox()
        Me.NewLayout = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gbHorzLayouts = New System.Windows.Forms.GroupBox()
        Me.cbHorzNameRatio = New System.Windows.Forms.CheckBox()
        Me.cbHorzNameNumbers = New System.Windows.Forms.CheckBox()
        Me.cbHorzSupported = New System.Windows.Forms.CheckBox()
        Me.gbVertLayouts = New System.Windows.Forms.GroupBox()
        Me.cbVertNameRatio = New System.Windows.Forms.CheckBox()
        Me.cbVertNameNumbers = New System.Windows.Forms.CheckBox()
        Me.cbVertSupported = New System.Windows.Forms.CheckBox()
        Me.grpRatios = New System.Windows.Forms.GroupBox()
        Me.cbRatio300 = New System.Windows.Forms.CheckBox()
        Me.cbRatio150 = New System.Windows.Forms.CheckBox()
        Me.cbRatio140 = New System.Windows.Forms.CheckBox()
        Me.cbRatio133 = New System.Windows.Forms.CheckBox()
        Me.cbRatio125 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblImagesPerCustom = New System.Windows.Forms.Label()
        Me.tbImagesPerCustom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNumOfLayersPerGIF = New System.Windows.Forms.Label()
        Me.lblChk4Delays = New System.Windows.Forms.Label()
        Me.cbChk4Delays = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbBkFGareAnimated = New System.Windows.Forms.CheckBox()
        Me.lblEna4BKGrnds = New System.Windows.Forms.Label()
        Me.lblEnaGrnScrn = New System.Windows.Forms.Label()
        Me.lblEnableFG = New System.Windows.Forms.Label()
        Me.grpLayoutSelect = New System.Windows.Forms.GroupBox()
        Me.cbLayoutSelected = New System.Windows.Forms.ComboBox()
        Me.cbUseMultipleFGBG = New System.Windows.Forms.CheckBox()
        Me.cbUseBackground = New System.Windows.Forms.CheckBox()
        Me.cbUseForeground = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtImagesPerPrint = New System.Windows.Forms.TextBox()
        Me.lblGifLayers = New System.Windows.Forms.Label()
        Me.txtImagePerGIF = New System.Windows.Forms.TextBox()
        Me.lblFolderName = New System.Windows.Forms.Label()
        Me.txtFolderName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpLayout.SuspendLayout()
        Me.gbHorzLayouts.SuspendLayout()
        Me.gbVertLayouts.SuspendLayout()
        Me.grpRatios.SuspendLayout()
        Me.grpLayoutSelect.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSaveClose
        '
        Me.btnSaveClose.Location = New System.Drawing.Point(682, 331)
        Me.btnSaveClose.Name = "btnSaveClose"
        Me.btnSaveClose.Size = New System.Drawing.Size(87, 23)
        Me.btnSaveClose.TabIndex = 0
        Me.btnSaveClose.Text = "Save && Close"
        Me.btnSaveClose.UseVisualStyleBackColor = True
        '
        'grpLayout
        '
        Me.grpLayout.Controls.Add(Me.DeleteThisLayout)
        Me.grpLayout.Controls.Add(Me.lblActionSetName)
        Me.grpLayout.Controls.Add(Me.tbActionSetName)
        Me.grpLayout.Controls.Add(Me.cbEnaMultiples)
        Me.grpLayout.Controls.Add(Me.cbEnaGrnScrn)
        Me.grpLayout.Controls.Add(Me.cbEnaOvrly)
        Me.grpLayout.Controls.Add(Me.NewLayout)
        Me.grpLayout.Controls.Add(Me.btnCancel)
        Me.grpLayout.Controls.Add(Me.gbHorzLayouts)
        Me.grpLayout.Controls.Add(Me.gbVertLayouts)
        Me.grpLayout.Controls.Add(Me.grpRatios)
        Me.grpLayout.Controls.Add(Me.Label4)
        Me.grpLayout.Controls.Add(Me.lblImagesPerCustom)
        Me.grpLayout.Controls.Add(Me.tbImagesPerCustom)
        Me.grpLayout.Controls.Add(Me.Label3)
        Me.grpLayout.Controls.Add(Me.lblNumOfLayersPerGIF)
        Me.grpLayout.Controls.Add(Me.lblChk4Delays)
        Me.grpLayout.Controls.Add(Me.cbChk4Delays)
        Me.grpLayout.Controls.Add(Me.Label2)
        Me.grpLayout.Controls.Add(Me.cbBkFGareAnimated)
        Me.grpLayout.Controls.Add(Me.lblEna4BKGrnds)
        Me.grpLayout.Controls.Add(Me.lblEnaGrnScrn)
        Me.grpLayout.Controls.Add(Me.lblEnableFG)
        Me.grpLayout.Controls.Add(Me.grpLayoutSelect)
        Me.grpLayout.Controls.Add(Me.cbUseMultipleFGBG)
        Me.grpLayout.Controls.Add(Me.cbUseBackground)
        Me.grpLayout.Controls.Add(Me.cbUseForeground)
        Me.grpLayout.Controls.Add(Me.Label1)
        Me.grpLayout.Controls.Add(Me.txtImagesPerPrint)
        Me.grpLayout.Controls.Add(Me.lblGifLayers)
        Me.grpLayout.Controls.Add(Me.txtImagePerGIF)
        Me.grpLayout.Controls.Add(Me.lblFolderName)
        Me.grpLayout.Controls.Add(Me.txtFolderName)
        Me.grpLayout.Controls.Add(Me.btnSave)
        Me.grpLayout.Controls.Add(Me.btnSaveClose)
        Me.grpLayout.Location = New System.Drawing.Point(30, 12)
        Me.grpLayout.Name = "grpLayout"
        Me.grpLayout.Size = New System.Drawing.Size(878, 373)
        Me.grpLayout.TabIndex = 1
        Me.grpLayout.TabStop = False
        Me.grpLayout.Text = "Edit the Layouts in this Group"
        '
        'DeleteThisLayout
        '
        Me.DeleteThisLayout.Location = New System.Drawing.Point(176, 67)
        Me.DeleteThisLayout.Name = "DeleteThisLayout"
        Me.DeleteThisLayout.Size = New System.Drawing.Size(114, 23)
        Me.DeleteThisLayout.TabIndex = 39
        Me.DeleteThisLayout.Text = "Delete this Layout"
        Me.DeleteThisLayout.UseVisualStyleBackColor = True
        '
        'lblActionSetName
        '
        Me.lblActionSetName.AutoSize = True
        Me.lblActionSetName.Location = New System.Drawing.Point(15, 16)
        Me.lblActionSetName.Name = "lblActionSetName"
        Me.lblActionSetName.Size = New System.Drawing.Size(141, 13)
        Me.lblActionSetName.TabIndex = 5
        Me.lblActionSetName.Text = "Photoshop Action Set Name"
        '
        'tbActionSetName
        '
        Me.tbActionSetName.Enabled = False
        Me.tbActionSetName.Location = New System.Drawing.Point(25, 35)
        Me.tbActionSetName.Name = "tbActionSetName"
        Me.tbActionSetName.Size = New System.Drawing.Size(284, 20)
        Me.tbActionSetName.TabIndex = 34
        '
        'cbEnaMultiples
        '
        Me.cbEnaMultiples.AutoSize = True
        Me.cbEnaMultiples.Location = New System.Drawing.Point(355, 162)
        Me.cbEnaMultiples.Name = "cbEnaMultiples"
        Me.cbEnaMultiples.Size = New System.Drawing.Size(32, 17)
        Me.cbEnaMultiples.TabIndex = 38
        Me.cbEnaMultiples.Text = "+"
        Me.cbEnaMultiples.UseVisualStyleBackColor = True
        '
        'cbEnaGrnScrn
        '
        Me.cbEnaGrnScrn.AutoSize = True
        Me.cbEnaGrnScrn.Location = New System.Drawing.Point(355, 126)
        Me.cbEnaGrnScrn.Name = "cbEnaGrnScrn"
        Me.cbEnaGrnScrn.Size = New System.Drawing.Size(32, 17)
        Me.cbEnaGrnScrn.TabIndex = 37
        Me.cbEnaGrnScrn.Text = "+"
        Me.cbEnaGrnScrn.UseVisualStyleBackColor = True
        '
        'cbEnaOvrly
        '
        Me.cbEnaOvrly.AutoSize = True
        Me.cbEnaOvrly.Location = New System.Drawing.Point(355, 86)
        Me.cbEnaOvrly.Name = "cbEnaOvrly"
        Me.cbEnaOvrly.Size = New System.Drawing.Size(32, 17)
        Me.cbEnaOvrly.TabIndex = 36
        Me.cbEnaOvrly.Text = "+"
        Me.cbEnaOvrly.UseVisualStyleBackColor = True
        '
        'NewLayout
        '
        Me.NewLayout.Location = New System.Drawing.Point(42, 67)
        Me.NewLayout.Name = "NewLayout"
        Me.NewLayout.Size = New System.Drawing.Size(114, 23)
        Me.NewLayout.TabIndex = 35
        Me.NewLayout.Text = "New Layout"
        Me.NewLayout.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(775, 331)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 33
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'gbHorzLayouts
        '
        Me.gbHorzLayouts.Controls.Add(Me.cbHorzNameRatio)
        Me.gbHorzLayouts.Controls.Add(Me.cbHorzNameNumbers)
        Me.gbHorzLayouts.Controls.Add(Me.cbHorzSupported)
        Me.gbHorzLayouts.Location = New System.Drawing.Point(564, 122)
        Me.gbHorzLayouts.Name = "gbHorzLayouts"
        Me.gbHorzLayouts.Size = New System.Drawing.Size(291, 92)
        Me.gbHorzLayouts.TabIndex = 32
        Me.gbHorzLayouts.TabStop = False
        Me.gbHorzLayouts.Text = "Check if Horizontal layouts are supported"
        '
        'cbHorzNameRatio
        '
        Me.cbHorzNameRatio.AutoSize = True
        Me.cbHorzNameRatio.Location = New System.Drawing.Point(21, 66)
        Me.cbHorzNameRatio.Name = "cbHorzNameRatio"
        Me.cbHorzNameRatio.Size = New System.Drawing.Size(252, 17)
        Me.cbHorzNameRatio.TabIndex = 2
        Me.cbHorzNameRatio.Text = "Horizontal Print actions have the ratios in names"
        Me.cbHorzNameRatio.UseVisualStyleBackColor = True
        '
        'cbHorzNameNumbers
        '
        Me.cbHorzNameNumbers.AutoSize = True
        Me.cbHorzNameNumbers.Location = New System.Drawing.Point(21, 46)
        Me.cbHorzNameNumbers.Name = "cbHorzNameNumbers"
        Me.cbHorzNameNumbers.Size = New System.Drawing.Size(263, 17)
        Me.cbHorzNameNumbers.TabIndex = 1
        Me.cbHorzNameNumbers.Text = "Horizontal actions have bg/fg #s in the name (1-4)"
        Me.cbHorzNameNumbers.UseVisualStyleBackColor = True
        '
        'cbHorzSupported
        '
        Me.cbHorzSupported.AutoSize = True
        Me.cbHorzSupported.Location = New System.Drawing.Point(21, 23)
        Me.cbHorzSupported.Name = "cbHorzSupported"
        Me.cbHorzSupported.Size = New System.Drawing.Size(177, 17)
        Me.cbHorzSupported.TabIndex = 0
        Me.cbHorzSupported.Text = "Horizontal images are supported"
        Me.cbHorzSupported.UseVisualStyleBackColor = True
        '
        'gbVertLayouts
        '
        Me.gbVertLayouts.Controls.Add(Me.cbVertNameRatio)
        Me.gbVertLayouts.Controls.Add(Me.cbVertNameNumbers)
        Me.gbVertLayouts.Controls.Add(Me.cbVertSupported)
        Me.gbVertLayouts.Location = New System.Drawing.Point(564, 24)
        Me.gbVertLayouts.Name = "gbVertLayouts"
        Me.gbVertLayouts.Size = New System.Drawing.Size(291, 92)
        Me.gbVertLayouts.TabIndex = 31
        Me.gbVertLayouts.TabStop = False
        Me.gbVertLayouts.Text = "Check if Vertical layouts are supported"
        '
        'cbVertNameRatio
        '
        Me.cbVertNameRatio.AutoSize = True
        Me.cbVertNameRatio.Location = New System.Drawing.Point(21, 66)
        Me.cbVertNameRatio.Name = "cbVertNameRatio"
        Me.cbVertNameRatio.Size = New System.Drawing.Size(240, 17)
        Me.cbVertNameRatio.TabIndex = 2
        Me.cbVertNameRatio.Text = "Vertical Print actions have the ratios in names"
        Me.cbVertNameRatio.UseVisualStyleBackColor = True
        '
        'cbVertNameNumbers
        '
        Me.cbVertNameNumbers.AutoSize = True
        Me.cbVertNameNumbers.Location = New System.Drawing.Point(22, 45)
        Me.cbVertNameNumbers.Name = "cbVertNameNumbers"
        Me.cbVertNameNumbers.Size = New System.Drawing.Size(251, 17)
        Me.cbVertNameNumbers.TabIndex = 1
        Me.cbVertNameNumbers.Text = "Vertical actions have bg/fg #s in the name (1-4)"
        Me.cbVertNameNumbers.UseVisualStyleBackColor = True
        '
        'cbVertSupported
        '
        Me.cbVertSupported.AutoSize = True
        Me.cbVertSupported.Location = New System.Drawing.Point(21, 23)
        Me.cbVertSupported.Name = "cbVertSupported"
        Me.cbVertSupported.Size = New System.Drawing.Size(165, 17)
        Me.cbVertSupported.TabIndex = 0
        Me.cbVertSupported.Text = "Vertical images are supported"
        Me.cbVertSupported.UseVisualStyleBackColor = True
        '
        'grpRatios
        '
        Me.grpRatios.Controls.Add(Me.cbRatio300)
        Me.grpRatios.Controls.Add(Me.cbRatio150)
        Me.grpRatios.Controls.Add(Me.cbRatio140)
        Me.grpRatios.Controls.Add(Me.cbRatio133)
        Me.grpRatios.Controls.Add(Me.cbRatio125)
        Me.grpRatios.Location = New System.Drawing.Point(23, 218)
        Me.grpRatios.Name = "grpRatios"
        Me.grpRatios.Size = New System.Drawing.Size(291, 136)
        Me.grpRatios.TabIndex = 30
        Me.grpRatios.TabStop = False
        Me.grpRatios.Text = "Check Ratio Sizes Supported by this layout"
        '
        'cbRatio300
        '
        Me.cbRatio300.AutoSize = True
        Me.cbRatio300.Location = New System.Drawing.Point(21, 108)
        Me.cbRatio300.Name = "cbRatio300"
        Me.cbRatio300.Size = New System.Drawing.Size(66, 17)
        Me.cbRatio300.TabIndex = 4
        Me.cbRatio300.Text = "2x6, 6x2"
        Me.cbRatio300.UseVisualStyleBackColor = True
        '
        'cbRatio150
        '
        Me.cbRatio150.AutoSize = True
        Me.cbRatio150.Location = New System.Drawing.Point(21, 86)
        Me.cbRatio150.Name = "cbRatio150"
        Me.cbRatio150.Size = New System.Drawing.Size(167, 17)
        Me.cbRatio150.TabIndex = 3
        Me.cbRatio150.Text = "4x6, 6x4, 6x9, 9x6, 8x12,12x8"
        Me.cbRatio150.UseVisualStyleBackColor = True
        '
        'cbRatio140
        '
        Me.cbRatio140.AutoSize = True
        Me.cbRatio140.Location = New System.Drawing.Point(21, 66)
        Me.cbRatio140.Name = "cbRatio140"
        Me.cbRatio140.Size = New System.Drawing.Size(130, 17)
        Me.cbRatio140.TabIndex = 2
        Me.cbRatio140.Text = "3.5x5, 5x3.5, 5x7, 7x5"
        Me.cbRatio140.UseVisualStyleBackColor = True
        '
        'cbRatio133
        '
        Me.cbRatio133.AutoSize = True
        Me.cbRatio133.Location = New System.Drawing.Point(21, 46)
        Me.cbRatio133.Name = "cbRatio133"
        Me.cbRatio133.Size = New System.Drawing.Size(112, 17)
        Me.cbRatio133.TabIndex = 1
        Me.cbRatio133.Text = "3x4, 4x3, 6x8, 8x6"
        Me.cbRatio133.UseVisualStyleBackColor = True
        '
        'cbRatio125
        '
        Me.cbRatio125.AutoSize = True
        Me.cbRatio125.Location = New System.Drawing.Point(21, 23)
        Me.cbRatio125.Name = "cbRatio125"
        Me.cbRatio125.Size = New System.Drawing.Size(124, 17)
        Me.cbRatio125.TabIndex = 0
        Me.cbRatio125.Text = "4x5, 5x4, 8x10, 10x8"
        Me.cbRatio125.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(352, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "# of BG/FG images in layout"
        '
        'lblImagesPerCustom
        '
        Me.lblImagesPerCustom.AutoSize = True
        Me.lblImagesPerCustom.Location = New System.Drawing.Point(382, 203)
        Me.lblImagesPerCustom.Name = "lblImagesPerCustom"
        Me.lblImagesPerCustom.Size = New System.Drawing.Size(129, 13)
        Me.lblImagesPerCustom.TabIndex = 28
        Me.lblImagesPerCustom.Text = "Actual # of Layouts in Set"
        '
        'tbImagesPerCustom
        '
        Me.tbImagesPerCustom.Location = New System.Drawing.Point(354, 200)
        Me.tbImagesPerCustom.Name = "tbImagesPerCustom"
        Me.tbImagesPerCustom.Size = New System.Drawing.Size(22, 20)
        Me.tbImagesPerCustom.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(351, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "# of images per layout (photostrips, etc)"
        '
        'lblNumOfLayersPerGIF
        '
        Me.lblNumOfLayersPerGIF.AutoSize = True
        Me.lblNumOfLayersPerGIF.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblNumOfLayersPerGIF.Location = New System.Drawing.Point(352, 236)
        Me.lblNumOfLayersPerGIF.Name = "lblNumOfLayersPerGIF"
        Me.lblNumOfLayersPerGIF.Size = New System.Drawing.Size(139, 13)
        Me.lblNumOfLayersPerGIF.TabIndex = 25
        Me.lblNumOfLayersPerGIF.Text = "Number of Animation Layers"
        '
        'lblChk4Delays
        '
        Me.lblChk4Delays.AutoSize = True
        Me.lblChk4Delays.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblChk4Delays.Location = New System.Drawing.Point(354, 316)
        Me.lblChk4Delays.Name = "lblChk4Delays"
        Me.lblChk4Delays.Size = New System.Drawing.Size(230, 13)
        Me.lblChk4Delays.TabIndex = 24
        Me.lblChk4Delays.Text = "Check to Add a 1 Second Delay to end of GIFs"
        '
        'cbChk4Delays
        '
        Me.cbChk4Delays.AutoSize = True
        Me.cbChk4Delays.Location = New System.Drawing.Point(357, 333)
        Me.cbChk4Delays.Name = "cbChk4Delays"
        Me.cbChk4Delays.Size = New System.Drawing.Size(141, 17)
        Me.cbChk4Delays.TabIndex = 23
        Me.cbChk4Delays.Text = "Add Delay to End of GIF"
        Me.cbChk4Delays.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(352, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Check this if using BK/FGs as animation layers"
        '
        'cbBkFGareAnimated
        '
        Me.cbBkFGareAnimated.AutoSize = True
        Me.cbBkFGareAnimated.Location = New System.Drawing.Point(357, 294)
        Me.cbBkFGareAnimated.Name = "cbBkFGareAnimated"
        Me.cbBkFGareAnimated.Size = New System.Drawing.Size(218, 17)
        Me.cbBkFGareAnimated.TabIndex = 21
        Me.cbBkFGareAnimated.Text = "Backgrounds/Foregrounds are Animated"
        Me.cbBkFGareAnimated.UseVisualStyleBackColor = True
        '
        'lblEna4BKGrnds
        '
        Me.lblEna4BKGrnds.AutoSize = True
        Me.lblEna4BKGrnds.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblEna4BKGrnds.Location = New System.Drawing.Point(332, 146)
        Me.lblEna4BKGrnds.Name = "lblEna4BKGrnds"
        Me.lblEna4BKGrnds.Size = New System.Drawing.Size(166, 13)
        Me.lblEna4BKGrnds.TabIndex = 20
        Me.lblEna4BKGrnds.Text = "Check this to see up to 4 BK/FGs"
        '
        'lblEnaGrnScrn
        '
        Me.lblEnaGrnScrn.AutoSize = True
        Me.lblEnaGrnScrn.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblEnaGrnScrn.Location = New System.Drawing.Point(332, 110)
        Me.lblEnaGrnScrn.Name = "lblEnaGrnScrn"
        Me.lblEnaGrnScrn.Size = New System.Drawing.Size(198, 13)
        Me.lblEnaGrnScrn.TabIndex = 19
        Me.lblEnaGrnScrn.Text = "Check this to enable BKG Green Screen"
        '
        'lblEnableFG
        '
        Me.lblEnableFG.AutoSize = True
        Me.lblEnableFG.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblEnableFG.Location = New System.Drawing.Point(332, 70)
        Me.lblEnableFG.Name = "lblEnableFG"
        Me.lblEnableFG.Size = New System.Drawing.Size(226, 13)
        Me.lblEnableFG.TabIndex = 18
        Me.lblEnableFG.Text = "Check this to enable FG overlay/watermarking"
        '
        'grpLayoutSelect
        '
        Me.grpLayoutSelect.Controls.Add(Me.cbLayoutSelected)
        Me.grpLayoutSelect.Location = New System.Drawing.Point(24, 104)
        Me.grpLayoutSelect.Name = "grpLayoutSelect"
        Me.grpLayoutSelect.Size = New System.Drawing.Size(290, 63)
        Me.grpLayoutSelect.TabIndex = 17
        Me.grpLayoutSelect.TabStop = False
        Me.grpLayoutSelect.Text = "Layout Selected"
        '
        'cbLayoutSelected
        '
        Me.cbLayoutSelected.FormattingEnabled = True
        Me.cbLayoutSelected.Location = New System.Drawing.Point(6, 23)
        Me.cbLayoutSelected.Name = "cbLayoutSelected"
        Me.cbLayoutSelected.Size = New System.Drawing.Size(268, 21)
        Me.cbLayoutSelected.TabIndex = 2
        '
        'cbUseMultipleFGBG
        '
        Me.cbUseMultipleFGBG.AutoSize = True
        Me.cbUseMultipleFGBG.Location = New System.Drawing.Point(395, 164)
        Me.cbUseMultipleFGBG.Name = "cbUseMultipleFGBG"
        Me.cbUseMultipleFGBG.Size = New System.Drawing.Size(166, 17)
        Me.cbUseMultipleFGBG.TabIndex = 16
        Me.cbUseMultipleFGBG.Text = "Enable Multiple BKGs / FGNs"
        Me.cbUseMultipleFGBG.UseVisualStyleBackColor = True
        '
        'cbUseBackground
        '
        Me.cbUseBackground.AutoSize = True
        Me.cbUseBackground.Location = New System.Drawing.Point(395, 126)
        Me.cbUseBackground.Name = "cbUseBackground"
        Me.cbUseBackground.Size = New System.Drawing.Size(128, 17)
        Me.cbUseBackground.TabIndex = 15
        Me.cbUseBackground.Text = "Enable Green Screen"
        Me.cbUseBackground.UseVisualStyleBackColor = True
        '
        'cbUseForeground
        '
        Me.cbUseForeground.AutoSize = True
        Me.cbUseForeground.Location = New System.Drawing.Point(395, 86)
        Me.cbUseForeground.Name = "cbUseForeground"
        Me.cbUseForeground.Size = New System.Drawing.Size(98, 17)
        Me.cbUseForeground.TabIndex = 14
        Me.cbUseForeground.Text = "Enable Overlay"
        Me.cbUseForeground.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(381, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "# Image(s) in Layout"
        '
        'txtImagesPerPrint
        '
        Me.txtImagesPerPrint.Location = New System.Drawing.Point(353, 46)
        Me.txtImagesPerPrint.Name = "txtImagesPerPrint"
        Me.txtImagesPerPrint.Size = New System.Drawing.Size(22, 20)
        Me.txtImagesPerPrint.TabIndex = 10
        '
        'lblGifLayers
        '
        Me.lblGifLayers.AutoSize = True
        Me.lblGifLayers.Location = New System.Drawing.Point(382, 256)
        Me.lblGifLayers.Name = "lblGifLayers"
        Me.lblGifLayers.Size = New System.Drawing.Size(86, 13)
        Me.lblGifLayers.TabIndex = 9
        Me.lblGifLayers.Text = "# frames per GIF"
        '
        'txtImagePerGIF
        '
        Me.txtImagePerGIF.Location = New System.Drawing.Point(357, 252)
        Me.txtImagePerGIF.Name = "txtImagePerGIF"
        Me.txtImagePerGIF.Size = New System.Drawing.Size(22, 20)
        Me.txtImagePerGIF.TabIndex = 8
        '
        'lblFolderName
        '
        Me.lblFolderName.AutoSize = True
        Me.lblFolderName.Location = New System.Drawing.Point(27, 174)
        Me.lblFolderName.Name = "lblFolderName"
        Me.lblFolderName.Size = New System.Drawing.Size(185, 13)
        Me.lblFolderName.TabIndex = 7
        Me.lblFolderName.Text = "3 digit Sub Folder Name for this layout"
        '
        'txtFolderName
        '
        Me.txtFolderName.Location = New System.Drawing.Point(30, 190)
        Me.txtFolderName.Name = "txtFolderName"
        Me.txtFolderName.Size = New System.Drawing.Size(48, 20)
        Me.txtFolderName.TabIndex = 6
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(601, 331)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'EditLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 409)
        Me.Controls.Add(Me.grpLayout)
        Me.Name = "EditLayout"
        Me.Text = "Edit Layout"
        Me.grpLayout.ResumeLayout(False)
        Me.grpLayout.PerformLayout()
        Me.gbHorzLayouts.ResumeLayout(False)
        Me.gbHorzLayouts.PerformLayout()
        Me.gbVertLayouts.ResumeLayout(False)
        Me.gbVertLayouts.PerformLayout()
        Me.grpRatios.ResumeLayout(False)
        Me.grpRatios.PerformLayout()
        Me.grpLayoutSelect.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSaveClose As System.Windows.Forms.Button
    Friend WithEvents grpLayout As System.Windows.Forms.GroupBox
    Friend WithEvents cbUseBackground As System.Windows.Forms.CheckBox
    Friend WithEvents cbUseForeground As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtImagesPerPrint As System.Windows.Forms.TextBox
    Friend WithEvents lblGifLayers As System.Windows.Forms.Label
    Friend WithEvents txtImagePerGIF As System.Windows.Forms.TextBox
    Friend WithEvents lblFolderName As System.Windows.Forms.Label
    Friend WithEvents txtFolderName As System.Windows.Forms.TextBox
    Friend WithEvents lblActionSetName As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cbUseMultipleFGBG As System.Windows.Forms.CheckBox
    Friend WithEvents grpLayoutSelect As System.Windows.Forms.GroupBox
    Friend WithEvents cbLayoutSelected As System.Windows.Forms.ComboBox
    Friend WithEvents lblChk4Delays As System.Windows.Forms.Label
    Friend WithEvents cbChk4Delays As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbBkFGareAnimated As System.Windows.Forms.CheckBox
    Friend WithEvents lblEna4BKGrnds As System.Windows.Forms.Label
    Friend WithEvents lblEnaGrnScrn As System.Windows.Forms.Label
    Friend WithEvents lblEnableFG As System.Windows.Forms.Label
    Friend WithEvents lblNumOfLayersPerGIF As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblImagesPerCustom As System.Windows.Forms.Label
    Friend WithEvents tbImagesPerCustom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbVertLayouts As System.Windows.Forms.GroupBox
    Friend WithEvents cbVertNameRatio As System.Windows.Forms.CheckBox
    Friend WithEvents cbVertNameNumbers As System.Windows.Forms.CheckBox
    Friend WithEvents cbVertSupported As System.Windows.Forms.CheckBox
    Friend WithEvents grpRatios As System.Windows.Forms.GroupBox
    Friend WithEvents cbRatio300 As System.Windows.Forms.CheckBox
    Friend WithEvents cbRatio150 As System.Windows.Forms.CheckBox
    Friend WithEvents cbRatio140 As System.Windows.Forms.CheckBox
    Friend WithEvents cbRatio133 As System.Windows.Forms.CheckBox
    Friend WithEvents cbRatio125 As System.Windows.Forms.CheckBox
    Friend WithEvents gbHorzLayouts As System.Windows.Forms.GroupBox
    Friend WithEvents cbHorzNameRatio As System.Windows.Forms.CheckBox
    Friend WithEvents cbHorzNameNumbers As System.Windows.Forms.CheckBox
    Friend WithEvents cbHorzSupported As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents tbActionSetName As System.Windows.Forms.TextBox
    Friend WithEvents NewLayout As System.Windows.Forms.Button
    Friend WithEvents cbEnaGrnScrn As System.Windows.Forms.CheckBox
    Friend WithEvents cbEnaOvrly As System.Windows.Forms.CheckBox
    Friend WithEvents cbEnaMultiples As System.Windows.Forms.CheckBox
    Friend WithEvents DeleteThisLayout As System.Windows.Forms.Button

End Class
