<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Koneksi
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
        Me.Txt_Database = New System.Windows.Forms.TextBox()
        Me.Button_Database = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txt_Database
        '
        Me.Txt_Database.Location = New System.Drawing.Point(12, 14)
        Me.Txt_Database.Name = "Txt_Database"
        Me.Txt_Database.Size = New System.Drawing.Size(447, 20)
        Me.Txt_Database.TabIndex = 0
        '
        'Button_Database
        '
        Me.Button_Database.Location = New System.Drawing.Point(465, 13)
        Me.Button_Database.Name = "Button_Database"
        Me.Button_Database.Size = New System.Drawing.Size(24, 23)
        Me.Button_Database.TabIndex = 1
        Me.Button_Database.Text = "..."
        Me.Button_Database.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(345, 57)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(144, 23)
        Me.Btn_Save.TabIndex = 2
        Me.Btn_Save.Text = "Save URL Database"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Form_Koneksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 92)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.Button_Database)
        Me.Controls.Add(Me.Txt_Database)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Koneksi"
        Me.Opacity = 0.8R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Browse Database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_Database As System.Windows.Forms.TextBox
    Friend WithEvents Button_Database As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Btn_Save As System.Windows.Forms.Button
End Class
