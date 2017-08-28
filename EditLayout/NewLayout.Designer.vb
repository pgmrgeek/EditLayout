<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewLayout
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
        Me.lblEnterName = New System.Windows.Forms.Label()
        Me.tbLayoutName = New System.Windows.Forms.TextBox()
        Me.lblFolderName = New System.Windows.Forms.Label()
        Me.txtFolderName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEnterName
        '
        Me.lblEnterName.AutoSize = True
        Me.lblEnterName.Location = New System.Drawing.Point(15, 27)
        Me.lblEnterName.Name = "lblEnterName"
        Me.lblEnterName.Size = New System.Drawing.Size(163, 13)
        Me.lblEnterName.TabIndex = 35
        Me.lblEnterName.Text = "Enter the name of the new layout"
        '
        'tbLayoutName
        '
        Me.tbLayoutName.Location = New System.Drawing.Point(18, 43)
        Me.tbLayoutName.Name = "tbLayoutName"
        Me.tbLayoutName.Size = New System.Drawing.Size(264, 20)
        Me.tbLayoutName.TabIndex = 38
        '
        'lblFolderName
        '
        Me.lblFolderName.AutoSize = True
        Me.lblFolderName.Location = New System.Drawing.Point(15, 78)
        Me.lblFolderName.Name = "lblFolderName"
        Me.lblFolderName.Size = New System.Drawing.Size(213, 13)
        Me.lblFolderName.TabIndex = 37
        Me.lblFolderName.Text = "Enter 3 digit Sub Folder Name for this layout"
        '
        'txtFolderName
        '
        Me.txtFolderName.Location = New System.Drawing.Point(18, 94)
        Me.txtFolderName.Name = "txtFolderName"
        Me.txtFolderName.Size = New System.Drawing.Size(48, 20)
        Me.txtFolderName.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnOkay)
        Me.GroupBox1.Controls.Add(Me.lblEnterName)
        Me.GroupBox1.Controls.Add(Me.txtFolderName)
        Me.GroupBox1.Controls.Add(Me.tbLayoutName)
        Me.GroupBox1.Controls.Add(Me.lblFolderName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 233)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Start a new layout"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(181, 198)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 40
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(34, 198)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(75, 23)
        Me.btnOkay.TabIndex = 39
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'NewLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 256)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "NewLayout"
        Me.Text = "NewLayout"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblEnterName As System.Windows.Forms.Label
    Friend WithEvents tbLayoutName As System.Windows.Forms.TextBox
    Friend WithEvents lblFolderName As System.Windows.Forms.Label
    Friend WithEvents txtFolderName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOkay As System.Windows.Forms.Button
End Class
