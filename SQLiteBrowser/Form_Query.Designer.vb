<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Query
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBoxQuery = New System.Windows.Forms.GroupBox()
        Me.TextBoxQuery = New System.Windows.Forms.TextBox()
        Me.GroupBoxResult = New System.Windows.Forms.GroupBox()
        Me.Lvw_Result = New System.Windows.Forms.ListView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBoxQuery.SuspendLayout()
        Me.GroupBoxResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBoxQuery)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBoxResult)
        Me.SplitContainer1.Size = New System.Drawing.Size(744, 445)
        Me.SplitContainer1.SplitterDistance = 220
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBoxQuery
        '
        Me.GroupBoxQuery.Controls.Add(Me.TextBoxQuery)
        Me.GroupBoxQuery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxQuery.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxQuery.Name = "GroupBoxQuery"
        Me.GroupBoxQuery.Size = New System.Drawing.Size(744, 220)
        Me.GroupBoxQuery.TabIndex = 0
        Me.GroupBoxQuery.TabStop = False
        Me.GroupBoxQuery.Text = "Query Script"
        '
        'TextBoxQuery
        '
        Me.TextBoxQuery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxQuery.Location = New System.Drawing.Point(3, 16)
        Me.TextBoxQuery.Multiline = True
        Me.TextBoxQuery.Name = "TextBoxQuery"
        Me.TextBoxQuery.Size = New System.Drawing.Size(738, 201)
        Me.TextBoxQuery.TabIndex = 0
        '
        'GroupBoxResult
        '
        Me.GroupBoxResult.Controls.Add(Me.Lvw_Result)
        Me.GroupBoxResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxResult.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxResult.Name = "GroupBoxResult"
        Me.GroupBoxResult.Size = New System.Drawing.Size(744, 221)
        Me.GroupBoxResult.TabIndex = 0
        Me.GroupBoxResult.TabStop = False
        Me.GroupBoxResult.Text = "Result"
        '
        'Lvw_Result
        '
        Me.Lvw_Result.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Lvw_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lvw_Result.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lvw_Result.ForeColor = System.Drawing.Color.Navy
        Me.Lvw_Result.FullRowSelect = True
        Me.Lvw_Result.Location = New System.Drawing.Point(3, 16)
        Me.Lvw_Result.Name = "Lvw_Result"
        Me.Lvw_Result.Size = New System.Drawing.Size(738, 202)
        Me.Lvw_Result.TabIndex = 6
        Me.Lvw_Result.UseCompatibleStateImageBehavior = False
        Me.Lvw_Result.View = System.Windows.Forms.View.Details
        '
        'Form_Query
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(744, 445)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form_Query"
        Me.ShowIcon = False
        Me.Text = "Query"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBoxQuery.ResumeLayout(False)
        Me.GroupBoxQuery.PerformLayout()
        Me.GroupBoxResult.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBoxQuery As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxQuery As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxResult As System.Windows.Forms.GroupBox
    Friend WithEvents Lvw_Result As System.Windows.Forms.ListView
End Class
