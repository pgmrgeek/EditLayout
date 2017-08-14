Imports System
Imports System.IO
Imports System.Threading


'====================================================================
'                              EditLayout
'====================================================================
'
' Copyright (c) 2017. Bay Area Event Photography. All Rights Reserved.
'
' BETA Release x.xx (A work in progress)
'
'"EditLayout.exe" is a Microsoft Visual Studio 2010 Visual Basic .NET
'program that provides a user interface read/write the layout files.
'
' sample code
'
'http://www.codescratcher.com/windows-forms/read-and-write-csv-file-in-vb-net/
'
'
'
Public Class EditLayout

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Globals.fEditLayout = Me

        ' read in all the possible layouts, and all the add-on packs

    End Sub

    Public Sub PreShow(ByRef fname As String)

        Globals.LayoutFileName = fname

        ReadBKFGFile(fname)                     ' load this layout from the file
        Globals.BkFgIndex = -1                  ' this layout files maxim
        cbLayoutSelected.SelectedIndex = 0      ' set to the first entry
        EditFormLoadLayout(0)                   ' load the file data into the form fields, first entry

    End Sub

    '-----------------------====< ReadBKFGFile() >====---------------------------
    ' read in the .CVS file listing all the standard & custom backgrounds/foregrounds
    '
    Private Sub ReadBKFGFile(ByRef fname As String)
        Dim i As Integer

        Call _bkfgreader("C:\onsite\backgrounds\" + fname, False)

        ' first reset the items since we're loading everything from scratch
        cbLayoutSelected.Items.Clear()
        i = cbLayoutSelected.Items.Count
        ' load all the variable to make this layout work
        If Globals.BkFgMax > 0 Then
            For i = 0 To Globals.BkFgMax - 1
                cbLayoutSelected.Items.Add(Globals.BkFgName(i)) '= arrCurrentRow(0)
            Next
        End If

        i = cbLayoutSelected.Items.Count

    End Sub

    '-----------------------====< ReadBKFGFile() >====---------------------------
    ' read in the .CVS file listing all the standard & custom backgrounds/foregrounds
    '
    Private Sub WriteBKFGFile(ByRef fname As String)
        Dim i As Integer

        Call _bkfgwriter("C:\onsite\backgrounds\" + fname, False)

    End Sub

    Private Sub _bkfgreader(ByRef fname As String, ByVal first As Boolean)
        Dim str As String
        Dim quot As String = Chr(34)
        'Dim cnt As Int16 = 0

        'If My.Computer.FileSystem.FileExists(fname) Then

        Dim ioReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(fname)

        ioReader.TextFieldType = FileIO.FieldType.Delimited
        ioReader.SetDelimiters(",")

        Globals.BkFgMax = 0
        Globals.cmtMaxCount = 0

        While Not ioReader.EndOfData

            Dim arrCurrentRow As String() = ioReader.ReadFields()

            str = arrCurrentRow(0)

            ' save comments to be rewritten at the start of the file
            If Microsoft.VisualBasic.Left(str, 1) = ":" Then
                Globals.cmtStrings(Globals.cmtMaxCount) = str
                Globals.cmtMaxCount += 1
            Else

                If Microsoft.VisualBasic.Len(str) > 1 Then      ' avoid cr/lf blank lines

                    ' load all the variable to make this layout work
                    Globals.BkFgName(Globals.BkFgMax) = arrCurrentRow(0)
                    Globals.BkFgSetName(Globals.BkFgMax) = arrCurrentRow(1)
                    Globals.BkFgFolder(Globals.BkFgMax) = arrCurrentRow(2)
                    Globals.BkFgGifLayers(Globals.BkFgMax) = arrCurrentRow(3)
                    Globals.BkFgCustLayers(Globals.BkFgMax) = arrCurrentRow(4)
                    Globals.BkFgFGSelect(Globals.BkFgMax) = arrCurrentRow(5)
                    Globals.BkFgBKSelect(Globals.BkFgMax) = arrCurrentRow(6)
                    Globals.BkFgMultLayers(Globals.BkFgMax) = arrCurrentRow(7)
                    Globals.BkFgImage1Bk(Globals.BkFgMax) = arrCurrentRow(8)
                    Globals.BkFgImage2Bk(Globals.BkFgMax) = arrCurrentRow(9)
                    Globals.BkFgImage3Bk(Globals.BkFgMax) = arrCurrentRow(10)
                    Globals.BkFgImage4Bk(Globals.BkFgMax) = arrCurrentRow(11)
                    Globals.BkFgAnimated(Globals.BkFgMax) = arrCurrentRow(12)
                    Globals.BkFgRatio(Globals.BkFgMax) = bin2dec(arrCurrentRow(13))
                    Globals.BkFgGIFDelay(Globals.BkFgMax) = bin2dec(arrCurrentRow(14))
                    'MessageBox.Show("ratio = " & Globals.BkFgRatio(Globals.BkFgMax))

                    'cbLayoutSelected.Items.Add(Globals.BkFgName(Globals.BkFgMax))

                    Globals.BkFgMax += 1

                End If

            End If

        End While

        ' increment the layout string array index to the next entry
        'Globals.bkFgStrMax += 1         ' Move to next row of string array FIX: max is 256

        ioReader.Close()
        
    End Sub

    Private Sub setupdefaultlayout(index As Integer)

        ' this sets up a default bkg/fg layout set.  Hopefully, set '000' is intalled..

        Globals.BkFgName(index) = "layout name?"
        Globals.BkFgSetName(index) = "action set name?"
        Globals.BkFgFolder(index) = "000"
        Globals.BkFgGifLayers(index) = 4
        Globals.BkFgCustLayers(index) = 1
        Globals.BkFgFGSelect(index) = -1
        Globals.BkFgBKSelect(index) = -1
        Globals.BkFgMultLayers(index) = -1
        Globals.BkFgImage1Bk(index) = -1
        Globals.BkFgImage2Bk(index) = -1
        Globals.BkFgImage3Bk(index) = -1
        Globals.BkFgImage4Bk(index) = -1
        Globals.BkFgAnimated(index) = -1
        Globals.BkFgRatio(index) = 31
        Globals.BkFgGIFDelay(index) = 0

    End Sub

    Private Sub _bkfgwriter(ByRef fname As String, ByVal first As Boolean)
        Dim i As Integer
        Dim str As String
        Dim s As String
        Dim quot As String = Chr(34)
        Dim quotc As String = Chr(34) + ","
        Dim file = My.Computer.FileSystem.OpenTextFileWriter(fname, False)

        If Globals.BkFgMax > 0 Then

            ' write out the comments

            If Globals.cmtMaxCount > 0 Then

                For i = 0 To Globals.cmtMaxCount
                    file.WriteLine(Globals.cmtStrings(i))
                Next

            End If

            ' now, write out each line item
            For i = 0 To Globals.BkFgMax - 1 Step 1

                'file.WriteLine("Here is the first string.")

                s = quot + Globals.BkFgName(i) + quotc             ' arrCurrentRow(0)
                s = s + quot + Globals.BkFgSetName(i) + quotc          ' arrCurrentRow(1)
                s = s + quot + Globals.BkFgFolder(i) + quotc           ' arrCurrentRow(2)
                s = s + Globals.BkFgGifLayers(i).ToString + ","     '     = arrCurrentRow(3)
                s = s + Globals.BkFgCustLayers(i).ToString + ","     ' = arrCurrentRow(4)
                s = s + Globals.BkFgFGSelect(i).ToString + ","     ' = arrCurrentRow(5)
                s = s + Globals.BkFgBKSelect(i).ToString + ","     ' = arrCurrentRow(6)
                s = s + Globals.BkFgMultLayers(i).ToString + ","     ' = arrCurrentRow(7)
                s = s + Globals.BkFgImage1Bk(i).ToString + ","     ' = arrCurrentRow(8)
                s = s + Globals.BkFgImage2Bk(i).ToString + ","     ' = arrCurrentRow(9)
                s = s + Globals.BkFgImage3Bk(i).ToString + ","     ' = arrCurrentRow(10)
                s = s + Globals.BkFgImage4Bk(i).ToString + ","     ' = arrCurrentRow(11)
                s = s + Globals.BkFgAnimated(i).ToString + ","     ' = arrCurrentRow(12)
                's = s + Globals.BkFgRatio(i).ToString + ","    ' = bin2dec(arrCurrentRow(13))

                ' convert the ration bit field into a binary string
                str = Convert.ToString(Globals.BkFgRatio(i), 2)
                str = "0000000000000000" + str
                str = Microsoft.VisualBasic.Right(str, 16)
                s = s + quot + str + quotc

                s = s + Globals.BkFgGIFDelay(i).ToString + ",0,0,0"    ' = bin2dec(arrCurrentRow(14))

                file.WriteLine(s)

            Next


            ' increment the layout string array index to the next entry
            'Globals.bkFgStrMax += 1         ' Move to next row of string array FIX: max is 256

            file.Close()


        End If


    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbLayoutSelected.SelectedIndexChanged
        'tbLayoutSelected.Text = cbLayoutSelected.SelectedIndex

        ' selected layout is changing, so save the changes back to the globals
        If Globals.BkFgIndex > -1 Then
            EditFormSaveLayout(Globals.BkFgIndex)
        End If

        ' load the globals for the new selected index
        EditFormLoadLayout(cbLayoutSelected.SelectedIndex)

    End Sub

    Private Function bin2dec(ByRef bString As String) As Integer
        Dim nexp As Integer = 0
        Dim digit As String
        Dim b2d As Integer = 0

        nexp = 0

        For n = Len(bString) To 1 Step -1
            digit = Mid(bString, n, 1)
            b2d = b2d + (CInt(digit) * (2 ^ nexp))
            nexp = nexp + 1
        Next n

        Return b2d

    End Function

    Private Sub cbEnaOvlry_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbEnaOvrly.CheckedChanged
        If cbEnaOvrly.Checked = True Then
            cbUseForeground.Enabled = True
        Else
            cbUseForeground.Enabled = False
        End If
    End Sub

    Private Sub cbEnaGrnScrn_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbEnaGrnScrn.CheckedChanged
        If cbEnaGrnScrn.Checked = True Then
            cbUseBackground.Enabled = True
        Else
            cbUseBackground.Enabled = False
        End If
    End Sub

    Private Sub cbEnaMultiples_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbEnaMultiples.CheckedChanged
        If cbEnaMultiples.Checked = True Then
            cbUseMultipleFGBG.Enabled = True
        Else
            cbUseMultipleFGBG.Enabled = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        ' save the layout changes
        EditFormSaveLayout(Globals.BkFgIndex)
        WriteBKFGFile(Globals.LayoutFileName)
    End Sub

    Private Sub btnSaveClose_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveClose.Click
        'save all changes, and return to open dialog
        EditFormSaveLayout(Globals.BkFgIndex)
        WriteBKFGFile(Globals.LayoutFileName)
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub cbLayoutAction_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
    End Sub

    Private Sub EditFormLoadLayout(ByVal index As Integer)

        Globals.BkFgIndex = index

        tbActionName.Text = Globals.BkFgSetName(index)         '= arrCurrentRow(1)
        txtFolderName.Text = Globals.BkFgFolder(index)         '= arrCurrentRow(2)
        txtImagePerGIF.Text = Globals.BkFgGifLayers(index)     '= arrCurrentRow(3)
        txtImagesPerPrint.Text = Globals.BkFgCustLayers(index) '= arrCurrentRow(4)

        ' arrCurrentRow(5) -  foreground checked?  -1,0,1

        If Globals.BkFgFGSelect(index) = -1 Then
            cbEnaOvrly.Checked = False
            'cbUseForeground.Enabled = False
        Else
            cbEnaOvrly.Checked = True
            'cbUseForeground.Enabled = True
            If Globals.BkFgFGSelect(index) = 0 Then
                cbUseForeground.Checked = False
            Else
                cbUseForeground.Checked = True
            End If
        End If

        ' arrCurrentRow(6) background checked?  -1,0,1

        If Globals.BkFgBKSelect(index) = -1 Then
            cbEnaGrnScrn.Checked = False
            'cbUseBackground.Enabled = False
        Else
            cbEnaGrnScrn.Checked = True
            If Globals.BkFgBKSelect(index) = 0 Then
                cbUseBackground.Checked = False
            Else
                cbUseBackground.Checked = True
            End If
        End If

        'Globals.BkFgMultLayers(index)     '= arrCurrentRow(7)  ' background checked?  -1,0,1

        If Globals.BkFgMultLayers(index) = -1 Then
            cbEnaMultiples.Checked = False
            'cbEnaOvrly.Checked = False
            'cbUseMultipleFGBG.Enabled = False
        Else
            cbEnaMultiples.Checked = True
            'cbUseMultipleFGBG.Enabled = true
            If Globals.BkFgMultLayers(index) = 0 Then
                cbUseMultipleFGBG.Checked = False
            Else
                cbUseMultipleFGBG.Checked = True
            End If
        End If

        tbImagesPerCustom.Text = "1"            'Globals.BkFgImage1Bk(index) ' = arrCurrentRow(8) always a 1    
        If Globals.BkFgImage2Bk(index) = 2 Then 'Globals.BkFgImage2Bk(index) ' = arrCurrentRow(9)
            tbImagesPerCustom.Text = "2"
        End If
        If Globals.BkFgImage3Bk(index) = 3 Then 'Globals.BkFgImage3Bk(index) ' = arrCurrentRow(10)
            tbImagesPerCustom.Text = "3"
        End If
        If Globals.BkFgImage4Bk(index) = 4 Then 'Globals.BkFgImage4Bk(index) ' = arrCurrentRow(11)
            tbImagesPerCustom.Text = "4"
        End If

        If Globals.BkFgAnimated(index) = 0 Then      '= arrCurrentRow(12)
            cbBkFGareAnimated.Checked = False
        Else
            cbBkFGareAnimated.Checked = True
        End If

        'Globals.BkFgRatio(index) = arrCurrentRow(13)
        If Globals.BkFgRatio(index) And &H1 Then
            cbRatio125.Checked = True
        Else
            cbRatio125.Checked = False
        End If

        If Globals.BkFgRatio(index) And &H2 Then
            cbRatio133.Checked = True
        Else
            cbRatio133.Checked = False
        End If

        If Globals.BkFgRatio(index) And &H4 Then
            cbRatio140.Checked = True
        Else
            cbRatio140.Checked = False
        End If

        If Globals.BkFgRatio(index) And &H8 Then
            cbRatio150.Checked = True
        Else
            cbRatio150.Checked = False
        End If

        If Globals.BkFgRatio(index) And &H10 Then
            cbRatio300.Checked = True
        Else
            cbRatio300.Checked = False
        End If

        If Globals.BkFgRatio(index) And &H100 Then
            cbVertSupported.Checked = True
        Else
            cbVertSupported.Checked = False
        End If

        If Globals.BkFgRatio(index) And &H200 Then
            cbVertNameNumbers.Checked = True
        Else
            cbVertNameNumbers.Checked = False
        End If

        If Globals.BkFgRatio(index) And &H400 Then
            cbVertNameRatio.Checked = True
        Else
            cbVertNameRatio.Checked = False
        End If


        If Globals.BkFgRatio(index) And &H1000 Then
            cbHorzSupported.Checked = True
        Else
            cbHorzSupported.Checked = False
        End If

        If Globals.BkFgRatio(index) And &H2000 Then
            cbHorzNameNumbers.Checked = True
        Else
            cbHorzNameNumbers.Checked = False
        End If

        If Globals.BkFgRatio(index) And &H4000 Then
            cbHorzNameRatio.Checked = True
        Else
            cbHorzNameRatio.Checked = False
        End If

        If Globals.BkFgGIFDelay(index) = 0 Then       '= bin2dec(arrCurrentRow(14))
            cbChk4Delays.Checked = False
        Else
            cbChk4Delays.Checked = True
        End If

    End Sub

    Private Sub EditFormSaveLayout(ByVal index As Integer)

        'Globals.BkFgIndex = index

        Globals.BkFgSetName(index) = tbActionName.Text         '= arrCurrentRow(1)
        Globals.BkFgFolder(index) = txtFolderName.Text         '= arrCurrentRow(2)
        Globals.BkFgGifLayers(index) = txtImagePerGIF.Text     '= arrCurrentRow(3)
        Globals.BkFgCustLayers(index) = txtImagesPerPrint.Text '= arrCurrentRow(4)

        ' arrCurrentRow(5) -  foreground checked?  -1,0,1

        If cbEnaOvrly.Checked = True Then
            If cbUseForeground.Checked = False Then
                Globals.BkFgFGSelect(index) = 0
            Else
                Globals.BkFgFGSelect(index) = 1
            End If
        Else
            Globals.BkFgFGSelect(index) = -1
        End If

        ' arrCurrentRow(6) background checked?  -1,0,1

        If cbEnaGrnScrn.Checked = True Then
            If cbUseBackground.Checked = True Then
                Globals.BkFgBKSelect(index) = 1
            Else
                Globals.BkFgBKSelect(index) = 0
            End If
        Else
            Globals.BkFgBKSelect(index) = -1
        End If

        'Globals.BkFgMultLayers(index)     '= arrCurrentRow(7)  ' background checked?  -1,0,1

        If cbEnaMultiples.Checked = True Then
            If cbUseMultipleFGBG.Checked = True Then
                Globals.BkFgMultLayers(index) = 1
            Else
                Globals.BkFgMultLayers(index) = 0
            End If
        Else
            Globals.BkFgMultLayers(index) = -1
        End If

        Globals.BkFgImage1Bk(index) = -1
        Globals.BkFgImage2Bk(index) = -1
        Globals.BkFgImage3Bk(index) = -1
        Globals.BkFgImage4Bk(index) = -1
        Select Case tbImagesPerCustom.Text
            Case "4"
                Globals.BkFgImage4Bk(index) = 4
                Globals.BkFgImage3Bk(index) = 3
                Globals.BkFgImage2Bk(index) = 2
                Globals.BkFgImage1Bk(index) = 1
            Case "3"
                Globals.BkFgImage3Bk(index) = 3
                Globals.BkFgImage2Bk(index) = 2
                Globals.BkFgImage1Bk(index) = 1
            Case "2"
                Globals.BkFgImage2Bk(index) = 2
                Globals.BkFgImage1Bk(index) = 1
            Case "1"
                Globals.BkFgImage1Bk(index) = 1
        End Select

        ' BK/FG are Annimated? arrCurrentRow(12)

        If cbBkFGareAnimated.Checked = False Then
            Globals.BkFgAnimated(index) = 0
        Else
            Globals.BkFgAnimated(index) = 1
        End If

        'Globals.BkFgRatio(index) = arrCurrentRow(13)

        Globals.BkFgRatio(index) = 0
        If cbRatio125.Checked = True Then
            Globals.BkFgRatio(index) = Globals.BkFgRatio(index) Or &H1
        End If

        If cbRatio133.Checked = True Then
            Globals.BkFgRatio(index) = Globals.BkFgRatio(index) Or &H2
        End If

        If cbRatio140.Checked = True Then
            Globals.BkFgRatio(index) = Globals.BkFgRatio(index) Or &H4
        End If

        If cbRatio150.Checked = True Then
            Globals.BkFgRatio(index) = Globals.BkFgRatio(index) Or &H8
        End If

        If cbRatio300.Checked = True Then
            Globals.BkFgRatio(index) = Globals.BkFgRatio(index) Or &H10
        End If

        If cbVertSupported.Checked = True Then
            Globals.BkFgRatio(index) = Globals.BkFgRatio(index) Or &H100
        End If

        If cbVertNameNumbers.Checked = True Then
            Globals.BkFgRatio(index) = Globals.BkFgRatio(index) Or &H200
        End If

        If cbVertNameRatio.Checked = True Then
            Globals.BkFgRatio(index) = Globals.BkFgRatio(index) Or &H400
        End If

        If cbHorzSupported.Checked = True Then
            Globals.BkFgRatio(index) = Globals.BkFgRatio(index) Or &H1000
        End If

        If cbHorzNameNumbers.Checked = True Then
            Globals.BkFgRatio(index) = Globals.BkFgRatio(index) Or &H2000
        End If

        If cbHorzNameRatio.Checked = True Then
            Globals.BkFgRatio(index) = Globals.BkFgRatio(index) Or &H4000
        End If

        ' animated gif delayed by 1 second at end
        If cbChk4Delays.Checked = False Then
            Globals.BkFgGIFDelay(index) = 0
        Else
            Globals.BkFgGIFDelay(index) = 1
        End If

    End Sub

End Class


' ============================================= DATA =================================================

Public Class Globals

    Public Shared Version As String = "Version 0.04"    ' Version string

    ' the form instances
    Public Shared fOpenLayout As OpenLayout
    Public Shared fEditLayout As EditLayout

    ' Array of bk/fg layouts for the user to select from
    'Public Shared BkFgStrings(256) As String        ' holds all strings from the layout file
    'Public Shared bkFgStrMax As Integer = 0         ' max count of the string array

    Public Shared LayoutFileName As String          ' name of the file we're editing
    Public Shared bkFgAllLayoutsIndex = 0           ' layout file index to specfic layout
    Public Shared BkFgIndex As Int16 = 0            ' what entry we're working on right now
    Public Shared BkFgMax As Int16 = 0              ' max counter for these arrays
    Public Shared BkFgName(256) As String           ' name of the layout
    Public Shared BkFgSetName(256) As String        ' action set name
    Public Shared BkFgFolder(256) As String         ' top level layout folder name such as '000'
    Public Shared BkFgGifLayers(256) As Integer     ' number of image layers required by the gif
    Public Shared BkFgCustLayers(256) As Integer    ' number of image layers required by the print
    Public Shared BkFgFGSelect(256) As Int16        ' uses foreground? -1 leave alone, 0=unchecked, 1=checked 
    Public Shared BkFgBKSelect(256) As Int16        ' uses background? -1 leave alone, 0=unchecked, 1=checked
    Public Shared BkFgMultLayers(256) As Int16      ' enable multiple bk/fg selection? -1 leave alone, 0=unchecked, 1=checked
    Public Shared BkFgImage1Bk(256) As Int16        ' 1 must always have one layout
    Public Shared BkFgImage2Bk(256) As Int16        ' 2 if there is a 2nd layout, -1 = not used 
    Public Shared BkFgImage3Bk(256) As Int16        ' 3 if there is a 3rd layout, -1 = not used 
    Public Shared BkFgImage4Bk(256) As Int16        ' 4 if there is a 4th layout, -1 = not used 
    Public Shared BkFgAnimated(256) As Int16        ' Bk/Fg files are used as animation layers, 0=false,1=true
    Public Shared BkFgRatio(256) As Int16         ' ratio supported - see below
    Public Shared BkFgGIFDelay(256) As Int16        ' GIF needs delay at end
    '
    '   In the BkFgRatio data, we specify which features are supported by bitfields
    '   The bit fields are:" 
    '
    '          00000001 - 1.25 = 4x5, 5x4, 8x10, 10x8
    '          00000010 - 1.33 = 3x4, 4x3, 6x8, 8x6
    '          00000100 - 1.40 = 3.5x5, 5x3.5, 5x7, 7x5
    '          00001000 - 1.50 = 4x6, 6x4, 6x9, 9x6, 8x12, 12x8
    '          00010000 - 3.00 = 2x6, 6x
    '          00100000 - unused
    '          01000000 - unused
    '          10000000 - unused
    ' 00000001 00000000 - vertical images supported
    ' 00000010 00000000 - vertical Bg/Fg are unique, and need custom actions
    ' 00000100 00000000 - vertical Print sizes and need custom actions
    ' 00001000 00000000 - unused
    ' 00010000 00000000 - horizontal images supported
    ' 00100000 00000000 - horizontal Bg/Fg are unique, and need custom actions
    ' 01000000 00000000 - horizontal Print sizes and need custom actions

    Public Shared cmtMaxCount As Integer
    Public Shared cmtStrings(256) As String

End Class



