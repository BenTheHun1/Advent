<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Advent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Advent))
        Me.lblOut = New System.Windows.Forms.Label()
        Me.lstInv = New System.Windows.Forms.ListBox()
        Me.menMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.menHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.picHole = New System.Windows.Forms.PictureBox()
        Me.picBook = New System.Windows.Forms.PictureBox()
        Me.picKey = New System.Windows.Forms.PictureBox()
        Me.picItem = New System.Windows.Forms.PictureBox()
        Me.picTake = New System.Windows.Forms.PictureBox()
        Me.picTalk = New System.Windows.Forms.PictureBox()
        Me.picUse = New System.Windows.Forms.PictureBox()
        Me.picLook = New System.Windows.Forms.PictureBox()
        Me.picRight = New System.Windows.Forms.PictureBox()
        Me.picLeft = New System.Windows.Forms.PictureBox()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.menMenu.SuspendLayout()
        CType(Me.picHole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTalk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOut
        '
        Me.lblOut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOut.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOut.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblOut.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOut.Location = New System.Drawing.Point(12, 460)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(933, 35)
        Me.lblOut.TabIndex = 22
        '
        'lstInv
        '
        Me.lstInv.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lstInv.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInv.FormattingEnabled = True
        Me.lstInv.ItemHeight = 15
        Me.lstInv.Location = New System.Drawing.Point(552, 27)
        Me.lstInv.Name = "lstInv"
        Me.lstInv.Size = New System.Drawing.Size(393, 64)
        Me.lstInv.TabIndex = 28
        '
        'menMenu
        '
        Me.menMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.menMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.menMenu.Location = New System.Drawing.Point(-1, 1)
        Me.menMenu.Name = "menMenu"
        Me.menMenu.Size = New System.Drawing.Size(45, 24)
        Me.menMenu.TabIndex = 29
        Me.menMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menSave, Me.menHelp})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'menSave
        '
        Me.menSave.Name = "menSave"
        Me.menSave.Size = New System.Drawing.Size(107, 22)
        Me.menSave.Text = "Save"
        '
        'menHelp
        '
        Me.menHelp.Name = "menHelp"
        Me.menHelp.Size = New System.Drawing.Size(107, 22)
        Me.menHelp.Text = "Help?!"
        '
        'picHole
        '
        Me.picHole.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picHole.Location = New System.Drawing.Point(552, 297)
        Me.picHole.Name = "picHole"
        Me.picHole.Size = New System.Drawing.Size(30, 32)
        Me.picHole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHole.TabIndex = 32
        Me.picHole.TabStop = False
        Me.picHole.Visible = False
        '
        'picBook
        '
        Me.picBook.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picBook.Location = New System.Drawing.Point(476, 199)
        Me.picBook.Name = "picBook"
        Me.picBook.Size = New System.Drawing.Size(198, 130)
        Me.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBook.TabIndex = 19
        Me.picBook.TabStop = False
        '
        'picKey
        '
        Me.picKey.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picKey.Location = New System.Drawing.Point(240, 166)
        Me.picKey.Name = "picKey"
        Me.picKey.Size = New System.Drawing.Size(96, 40)
        Me.picKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picKey.TabIndex = 17
        Me.picKey.TabStop = False
        '
        'picItem
        '
        Me.picItem.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picItem.Location = New System.Drawing.Point(444, 27)
        Me.picItem.Name = "picItem"
        Me.picItem.Size = New System.Drawing.Size(72, 74)
        Me.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picItem.TabIndex = 27
        Me.picItem.TabStop = False
        '
        'picTake
        '
        Me.picTake.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picTake.Location = New System.Drawing.Point(336, 27)
        Me.picTake.Name = "picTake"
        Me.picTake.Size = New System.Drawing.Size(72, 74)
        Me.picTake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTake.TabIndex = 27
        Me.picTake.TabStop = False
        '
        'picTalk
        '
        Me.picTalk.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picTalk.Location = New System.Drawing.Point(228, 27)
        Me.picTalk.Name = "picTalk"
        Me.picTalk.Size = New System.Drawing.Size(72, 74)
        Me.picTalk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTalk.TabIndex = 27
        Me.picTalk.TabStop = False
        '
        'picUse
        '
        Me.picUse.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picUse.Location = New System.Drawing.Point(120, 27)
        Me.picUse.Name = "picUse"
        Me.picUse.Size = New System.Drawing.Size(72, 74)
        Me.picUse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUse.TabIndex = 27
        Me.picUse.TabStop = False
        '
        'picLook
        '
        Me.picLook.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picLook.Location = New System.Drawing.Point(12, 28)
        Me.picLook.Name = "picLook"
        Me.picLook.Size = New System.Drawing.Size(72, 74)
        Me.picLook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLook.TabIndex = 27
        Me.picLook.TabStop = False
        '
        'picRight
        '
        Me.picRight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picRight.Cursor = System.Windows.Forms.Cursors.PanEast
        Me.picRight.Location = New System.Drawing.Point(907, 108)
        Me.picRight.Name = "picRight"
        Me.picRight.Size = New System.Drawing.Size(38, 349)
        Me.picRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRight.TabIndex = 23
        Me.picRight.TabStop = False
        '
        'picLeft
        '
        Me.picLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picLeft.Cursor = System.Windows.Forms.Cursors.PanWest
        Me.picLeft.Location = New System.Drawing.Point(12, 108)
        Me.picLeft.Name = "picLeft"
        Me.picLeft.Size = New System.Drawing.Size(48, 349)
        Me.picLeft.TabIndex = 24
        Me.picLeft.TabStop = False
        '
        'picBackground
        '
        Me.picBackground.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picBackground.Location = New System.Drawing.Point(66, 108)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(835, 349)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBackground.TabIndex = 16
        Me.picBackground.TabStop = False
        '
        'Advent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(959, 534)
        Me.Controls.Add(Me.picHole)
        Me.Controls.Add(Me.picBook)
        Me.Controls.Add(Me.picKey)
        Me.Controls.Add(Me.lstInv)
        Me.Controls.Add(Me.picItem)
        Me.Controls.Add(Me.picTake)
        Me.Controls.Add(Me.picTalk)
        Me.Controls.Add(Me.picUse)
        Me.Controls.Add(Me.picLook)
        Me.Controls.Add(Me.picRight)
        Me.Controls.Add(Me.picLeft)
        Me.Controls.Add(Me.lblOut)
        Me.Controls.Add(Me.picBackground)
        Me.Controls.Add(Me.menMenu)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menMenu
        Me.Name = "Advent"
        Me.Text = "Advent"
        Me.menMenu.ResumeLayout(False)
        Me.menMenu.PerformLayout()
        CType(Me.picHole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTalk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picRight As PictureBox
    Friend WithEvents picLeft As PictureBox
    Friend WithEvents lblOut As Label
    Friend WithEvents picBook As PictureBox
    Friend WithEvents picKey As PictureBox
    Friend WithEvents picBackground As PictureBox
    Friend WithEvents picLook As PictureBox
    Friend WithEvents picUse As PictureBox
    Friend WithEvents picTalk As PictureBox
    Friend WithEvents picTake As PictureBox
    Friend WithEvents picItem As PictureBox
    Friend WithEvents lstInv As ListBox
    Friend WithEvents menMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menSave As ToolStripMenuItem
    Friend WithEvents menHelp As ToolStripMenuItem
    Friend WithEvents picHole As PictureBox
End Class
