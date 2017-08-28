Public Class NewLayout

    Private Sub NewLayout_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Globals.nlCompletionCode = -1   ' looping
        tbLayoutName.Text = " New Layout"
    End Sub

    Private Sub tbLayoutName_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbLayoutName.TextChanged

    End Sub

    Private Sub txtFolderName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFolderName.TextChanged

    End Sub

    Private Sub btnOkay_Click(sender As System.Object, e As System.EventArgs) Handles btnOkay.Click
        Dim num As Integer

        ' validate the 3 digit folder #
        If Globals.fNewLayout.txtFolderName.Text.Length <> 3 Then
            MsgBox("Bad 3 digit number, please try again")
            Globals.nlCompletionCode = 1
        Else
            num = CInt(Int(Globals.fNewLayout.txtFolderName.Text))
            Globals.nlCompletionCode = 0   ' Good
        End If

        Me.Hide()

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Globals.nlCompletionCode = 1   ' Cancel
        Me.Hide()
    End Sub

    Public Sub Preshow()
        Globals.nlCompletionCode = -1   ' looping
    End Sub
End Class