Imports System
Imports System.IO
Imports System.Threading
Imports System.Windows.Forms


Public Class OpenLayout

    Private Sub OpenLayout_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Dim fEditLayout As EditLayout

        Globals.fOpenLayout = Me
        Me.Text = Me.Text + " " + Globals.Version

        Globals.fNewLayout = New NewLayout
        Globals.fEditLayout = New EditLayout

        Globals.fEditLayout.Show()
        Globals.fEditLayout.Hide()

        LoadCSVFileNames()

    End Sub

    Private Sub btnFolderDialog_Click(sender As System.Object, e As System.EventArgs) Handles btnFolderDialog.Click
        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\onsite\backgrounds"
        openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFileDialog1.OpenFile()
                If (myStream IsNot Nothing) Then
                    ' Insert code to read the stream here.
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If

    End Sub


    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        Dim s As String
        'prtrSelect1.Text = Printer1LB.SelectedIndex
        s = cbAllLayouts.SelectedItem
        Globals.fEditLayout.PreShow(s)
        Globals.fEditLayout.Show()
        'Globals.fOpenLayout.Hide()

    End Sub

    Private Sub btnNewLayout_Click(sender As System.Object, e As System.EventArgs) Handles btnNewLayout.Click

    End Sub


    Private Sub LoadCSVFileNames()
        Dim files As New List(Of FileInfo)(New DirectoryInfo("C:\onsite\backgrounds\").GetFiles("bkfglayouts.*"))

        ' load all the .cvs file names
        'LoadCSVFileNames()

        ' reset the list and attempt to read in all bk/fg combos files
        'Globals.BkFgMax = 0
        cbAllLayouts.Items.Clear()

        ' scan for all bkg/fg .csv files.  Special case the first - bkfglayouts.000.csv"

        For Each fi As FileInfo In files
            cbAllLayouts.Items.Add(fi.Name)
        Next

        'If cbAllLayouts.Items.Count > 0 Then
        cbAllLayouts.SelectedIndex = 0
        'End If

    End Sub

    'Public Sub DoShow()
    'Dim fEditLayout As New EditLayout

    'Globals.fEditLayout.Select = Globals.fOpenLayout.cbAllLayouts.SelectedIndex
    'Globals.fOpenLayout.Top = True
    'Globals.fOpenLayout.Show()
    'End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cbAllLayouts_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbAllLayouts.SelectedIndexChanged
        Globals.bkFgAllLayoutsIndex = cbAllLayouts.SelectedIndex
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles DeleteLayoutSet.Click

    End Sub
End Class


