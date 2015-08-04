<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel_Home = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Connection = New System.Windows.Forms.TabPage()
        Me.TS_Customer = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Database = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Query = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Label_Database = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Connection.SuspendLayout()
        Me.TS_Customer.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'StatusStrip
        '
        Me.StatusStrip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusStrip.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(795, 22)
        Me.StatusStrip.TabIndex = 8
        Me.StatusStrip.Text = "StatusStrip"
        '
        'StatusLabel_Home
        '
        Me.StatusLabel_Home.Name = "StatusLabel_Home"
        Me.StatusLabel_Home.Size = New System.Drawing.Size(39, 17)
        Me.StatusLabel_Home.Text = "Status"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 566)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(907, 26)
        Me.Panel1.TabIndex = 12
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.StatusStrip)
        Me.SplitContainer1.Size = New System.Drawing.Size(903, 22)
        Me.SplitContainer1.SplitterDistance = 795
        Me.SplitContainer1.TabIndex = 0
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(102, 49)
        Me.ToolStripButton11.Text = "Sales FF"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Comic Sans MS", 8.0!)
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(93, 49)
        Me.ToolStripButton1.Text = "MESO"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Comic Sans MS", 8.0!)
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(90, 49)
        Me.ToolStripButton2.Text = "ROFO"
        '
        'Connection
        '
        Me.Connection.Controls.Add(Me.Label_Database)
        Me.Connection.Controls.Add(Me.TS_Customer)
        Me.Connection.Location = New System.Drawing.Point(4, 22)
        Me.Connection.Name = "Connection"
        Me.Connection.Size = New System.Drawing.Size(899, 52)
        Me.Connection.TabIndex = 3
        Me.Connection.Text = "Connection"
        Me.Connection.UseVisualStyleBackColor = True
        '
        'TS_Customer
        '
        Me.TS_Customer.AutoSize = False
        Me.TS_Customer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TS_Customer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TS_Customer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Database, Me.ToolStripButton_Query})
        Me.TS_Customer.Location = New System.Drawing.Point(0, 0)
        Me.TS_Customer.Name = "TS_Customer"
        Me.TS_Customer.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TS_Customer.Size = New System.Drawing.Size(899, 52)
        Me.TS_Customer.TabIndex = 6
        Me.TS_Customer.Text = "CUSTOMER"
        '
        'ToolStripButton_Database
        '
        Me.ToolStripButton_Database.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton_Database.Image = CType(resources.GetObject("ToolStripButton_Database.Image"), System.Drawing.Image)
        Me.ToolStripButton_Database.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton_Database.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Database.Name = "ToolStripButton_Database"
        Me.ToolStripButton_Database.Size = New System.Drawing.Size(106, 49)
        Me.ToolStripButton_Database.Text = "Database"
        '
        'ToolStripButton_Query
        '
        Me.ToolStripButton_Query.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton_Query.Image = CType(resources.GetObject("ToolStripButton_Query.Image"), System.Drawing.Image)
        Me.ToolStripButton_Query.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton_Query.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Query.Name = "ToolStripButton_Query"
        Me.ToolStripButton_Query.Size = New System.Drawing.Size(92, 49)
        Me.ToolStripButton_Query.Text = "Query"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Connection)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(907, 78)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 10
        '
        'Label_Database
        '
        Me.Label_Database.AutoSize = True
        Me.Label_Database.Location = New System.Drawing.Point(555, 22)
        Me.Label_Database.Name = "Label_Database"
        Me.Label_Database.Size = New System.Drawing.Size(53, 13)
        Me.Label_Database.TabIndex = 7
        Me.Label_Database.Text = "Database"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(907, 592)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Home"
        Me.Text = " MeBrow"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Connection.ResumeLayout(False)
        Me.Connection.PerformLayout()
        Me.TS_Customer.ResumeLayout(False)
        Me.TS_Customer.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel_Home As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Connection As System.Windows.Forms.TabPage
    Friend WithEvents Label_Database As System.Windows.Forms.Label
    Friend WithEvents TS_Customer As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Database As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Query As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
End Class
