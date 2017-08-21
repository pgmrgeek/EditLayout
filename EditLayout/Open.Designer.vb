<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenLayout
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
        Me.txtLayoutPath = New System.Windows.Forms.TextBox()
        Me.btnFolderDialog = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.grpOpenDialog = New System.Windows.Forms.GroupBox()
        Me.DeleteLayoutSet = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNewLayout = New System.Windows.Forms.Button()
        Me.cbAllLayouts = New System.Windows.Forms.ComboBox()
        Me.lblChooseLayout = New System.Windows.Forms.Label()
        Me.lblChoosePath = New System.Windows.Forms.Label()
        Me.grpOpenDialog.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLayoutPath
        '
        Me.txtLayoutPath.Enabled = False
        Me.txtLayoutPath.Location = New System.Drawing.Point(24, 48)
        Me.txtLayoutPath.Name = "txtLayoutPath"
        Me.txtLayoutPath.Size = New System.Drawing.Size(290, 20)
        Me.txtLayoutPath.TabIndex = 0
        Me.txtLayoutPath.Text = "c:\Onsite\backgrounds"
        '
        'btnFolderDialog
        '
        Me.btnFolderDialog.Enabled = False
        Me.btnFolderDialog.Location = New System.Drawing.Point(320, 46)
        Me.btnFolderDialog.Name = "btnFolderDialog"
        Me.btnFolderDialog.Size = New System.Drawing.Size(31, 23)
        Me.btnFolderDialog.TabIndex = 1
        Me.btnFolderDialog.Text = "..."
        Me.btnFolderDialog.UseVisualStyleBackColor = True
        '
        'grpOpenDialog
        '
        Me.grpOpenDialog.Controls.Add(Me.DeleteLayoutSet)
        Me.grpOpenDialog.Controls.Add(Me.btnCancel)
        Me.grpOpenDialog.Controls.Add(Me.btnEdit)
        Me.grpOpenDialog.Controls.Add(Me.btnNewLayout)
        Me.grpOpenDialog.Controls.Add(Me.cbAllLayouts)
        Me.grpOpenDialog.Controls.Add(Me.lblChooseLayout)
        Me.grpOpenDialog.Controls.Add(Me.lblChoosePath)
        Me.grpOpenDialog.Controls.Add(Me.txtLayoutPath)
        Me.grpOpenDialog.Controls.Add(Me.btnFolderDialog)
        Me.grpOpenDialog.Location = New System.Drawing.Point(24, 25)
        Me.grpOpenDialog.Name = "grpOpenDialog"
        Me.grpOpenDialog.Size = New System.Drawing.Size(388, 180)
        Me.grpOpenDialog.TabIndex = 2
        Me.grpOpenDialog.TabStop = False
        Me.grpOpenDialog.Text = "Open Layout Group"
        '
        'DeleteLayoutSet
        '
        Me.DeleteLayoutSet.Location = New System.Drawing.Point(195, 141)
        Me.DeleteLayoutSet.Name = "DeleteLayoutSet"
        Me.DeleteLayoutSet.Size = New System.Drawing.Size(75, 23)
        Me.DeleteLayoutSet.TabIndex = 8
        Me.DeleteLayoutSet.Text = "Delete Set"
        Me.DeleteLayoutSet.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(293, 141)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Exit"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(109, 141)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Edit Set"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnNewLayout
        '
        Me.btnNewLayout.Enabled = False
        Me.btnNewLayout.Location = New System.Drawing.Point(24, 141)
        Me.btnNewLayout.Name = "btnNewLayout"
        Me.btnNewLayout.Size = New System.Drawing.Size(75, 23)
        Me.btnNewLayout.TabIndex = 5
        Me.btnNewLayout.Text = "New Set"
        Me.btnNewLayout.UseVisualStyleBackColor = True
        '
        'cbAllLayouts
        '
        Me.cbAllLayouts.FormattingEnabled = True
        Me.cbAllLayouts.Location = New System.Drawing.Point(21, 97)
        Me.cbAllLayouts.Name = "cbAllLayouts"
        Me.cbAllLayouts.Size = New System.Drawing.Size(293, 21)
        Me.cbAllLayouts.TabIndex = 4
        '
        'lblChooseLayout
        '
        Me.lblChooseLayout.AutoSize = True
        Me.lblChooseLayout.Location = New System.Drawing.Point(18, 81)
        Me.lblChooseLayout.Name = "lblChooseLayout"
        Me.lblChooseLayout.Size = New System.Drawing.Size(166, 13)
        Me.lblChooseLayout.TabIndex = 3
        Me.lblChooseLayout.Text = "Choose a Layout Set in this group"
        '
        'lblChoosePath
        '
        Me.lblChoosePath.AutoSize = True
        Me.lblChoosePath.Location = New System.Drawing.Point(21, 29)
        Me.lblChoosePath.Name = "lblChoosePath"
        Me.lblChoosePath.Size = New System.Drawing.Size(150, 13)
        Me.lblChoosePath.TabIndex = 2
        Me.lblChoosePath.Text = "Select the Path to the Layouts"
        '
        'OpenLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 239)
        Me.Controls.Add(Me.grpOpenDialog)
        Me.Name = "OpenLayout"
        Me.Text = "Layout Editor"
        Me.grpOpenDialog.ResumeLayout(False)
        Me.grpOpenDialog.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtLayoutPath As System.Windows.Forms.TextBox
    Friend WithEvents btnFolderDialog As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents grpOpenDialog As System.Windows.Forms.GroupBox
    Friend WithEvents cbAllLayouts As System.Windows.Forms.ComboBox
    Friend WithEvents lblChooseLayout As System.Windows.Forms.Label
    Friend WithEvents lblChoosePath As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNewLayout As System.Windows.Forms.Button
    Friend WithEvents DeleteLayoutSet As System.Windows.Forms.Button
End Class
