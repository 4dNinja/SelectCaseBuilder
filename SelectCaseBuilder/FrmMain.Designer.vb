<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.TxtFilesPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLoad = New System.Windows.Forms.Button()
        Me.LsvResources = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtEditRes = New System.Windows.Forms.TextBox()
        Me.TxtEditRef = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnHelp = New System.Windows.Forms.Button()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlHelp = New System.Windows.Forms.Panel()
        Me.BtnCloseHelp = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.PnlMain.SuspendLayout()
        Me.PnlHelp.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtFilesPath
        '
        Me.TxtFilesPath.Location = New System.Drawing.Point(25, 44)
        Me.TxtFilesPath.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtFilesPath.Name = "TxtFilesPath"
        Me.TxtFilesPath.Size = New System.Drawing.Size(295, 27)
        Me.TxtFilesPath.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.TxtFilesPath, "Directory path of resource files.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Directory"
        '
        'BtnLoad
        '
        Me.BtnLoad.Location = New System.Drawing.Point(326, 19)
        Me.BtnLoad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.Size = New System.Drawing.Size(75, 52)
        Me.BtnLoad.TabIndex = 1
        Me.BtnLoad.Text = "&Load"
        Me.ToolTip1.SetToolTip(Me.BtnLoad, "Load files from directory.")
        Me.BtnLoad.UseVisualStyleBackColor = True
        '
        'LsvResources
        '
        Me.LsvResources.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LsvResources.FullRowSelect = True
        Me.LsvResources.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LsvResources.HideSelection = False
        Me.LsvResources.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LsvResources.Location = New System.Drawing.Point(25, 79)
        Me.LsvResources.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LsvResources.MultiSelect = False
        Me.LsvResources.Name = "LsvResources"
        Me.LsvResources.ShowItemToolTips = True
        Me.LsvResources.Size = New System.Drawing.Size(538, 463)
        Me.LsvResources.TabIndex = 2
        Me.LsvResources.UseCompatibleStateImageBehavior = False
        Me.LsvResources.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Resource"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Reference"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Else"
        Me.ColumnHeader3.Width = 50
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(407, 19)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 52)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "&Save"
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Generate a Select Case.")
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtEditRes)
        Me.GroupBox1.Controls.Add(Me.TxtEditRef)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 549)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 109)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit"
        '
        'TxtEditRes
        '
        Me.TxtEditRes.Location = New System.Drawing.Point(138, 30)
        Me.TxtEditRes.Name = "TxtEditRes"
        Me.TxtEditRes.ReadOnly = True
        Me.TxtEditRes.Size = New System.Drawing.Size(343, 27)
        Me.TxtEditRes.TabIndex = 3
        Me.TxtEditRes.TabStop = False
        Me.ToolTip1.SetToolTip(Me.TxtEditRes, "Resource name.")
        '
        'TxtEditRef
        '
        Me.TxtEditRef.Location = New System.Drawing.Point(138, 63)
        Me.TxtEditRef.Name = "TxtEditRef"
        Me.TxtEditRef.Size = New System.Drawing.Size(343, 27)
        Me.TxtEditRef.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.TxtEditRef, "Case reference.")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Reference"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Resource"
        '
        'BtnHelp
        '
        Me.BtnHelp.Location = New System.Drawing.Point(488, 19)
        Me.BtnHelp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnHelp.Name = "BtnHelp"
        Me.BtnHelp.Size = New System.Drawing.Size(75, 52)
        Me.BtnHelp.TabIndex = 5
        Me.BtnHelp.Text = "&Help"
        Me.BtnHelp.UseVisualStyleBackColor = True
        '
        'PnlMain
        '
        Me.PnlMain.AllowDrop = True
        Me.PnlMain.Controls.Add(Me.Label1)
        Me.PnlMain.Controls.Add(Me.GroupBox1)
        Me.PnlMain.Controls.Add(Me.TxtFilesPath)
        Me.PnlMain.Controls.Add(Me.LsvResources)
        Me.PnlMain.Controls.Add(Me.BtnLoad)
        Me.PnlMain.Controls.Add(Me.BtnHelp)
        Me.PnlMain.Controls.Add(Me.BtnSave)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(584, 677)
        Me.PnlMain.TabIndex = 5
        '
        'PnlHelp
        '
        Me.PnlHelp.Controls.Add(Me.BtnCloseHelp)
        Me.PnlHelp.Controls.Add(Me.TextBox1)
        Me.PnlHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlHelp.Location = New System.Drawing.Point(0, 0)
        Me.PnlHelp.Name = "PnlHelp"
        Me.PnlHelp.Size = New System.Drawing.Size(584, 677)
        Me.PnlHelp.TabIndex = 6
        Me.PnlHelp.Visible = False
        '
        'BtnCloseHelp
        '
        Me.BtnCloseHelp.Location = New System.Drawing.Point(441, 615)
        Me.BtnCloseHelp.Name = "BtnCloseHelp"
        Me.BtnCloseHelp.Size = New System.Drawing.Size(131, 51)
        Me.BtnCloseHelp.TabIndex = 1
        Me.BtnCloseHelp.TabStop = False
        Me.BtnCloseHelp.Text = "&Close Help"
        Me.BtnCloseHelp.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft NeoGothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(560, 588)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 677)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.PnlHelp)
        Me.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Case Builder"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PnlMain.ResumeLayout(False)
        Me.PnlMain.PerformLayout()
        Me.PnlHelp.ResumeLayout(False)
        Me.PnlHelp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtFilesPath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLoad As Button
    Friend WithEvents LsvResources As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents BtnSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtEditRes As TextBox
    Friend WithEvents TxtEditRef As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents BtnHelp As Button
    Friend WithEvents PnlMain As Panel
    Friend WithEvents PnlHelp As Panel
    Friend WithEvents BtnCloseHelp As Button
    Friend WithEvents TextBox1 As TextBox
End Class
