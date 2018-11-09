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
        Me.radLookAt = New System.Windows.Forms.RadioButton()
        Me.radPickUp = New System.Windows.Forms.RadioButton()
        Me.boxActions = New System.Windows.Forms.GroupBox()
        Me.radTalkTo = New System.Windows.Forms.RadioButton()
        Me.radInteract = New System.Windows.Forms.RadioButton()
        Me.radUseItem = New System.Windows.Forms.RadioButton()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.picRight = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picLeft = New System.Windows.Forms.PictureBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.txtIn = New System.Windows.Forms.TextBox()
        Me.lblOut = New System.Windows.Forms.Label()
        Me.picBook = New System.Windows.Forms.PictureBox()
        Me.picKey = New System.Windows.Forms.PictureBox()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.grpInventory = New System.Windows.Forms.GroupBox()
        Me.radInvThree = New System.Windows.Forms.RadioButton()
        Me.radInvTwo = New System.Windows.Forms.RadioButton()
        Me.radInvOne = New System.Windows.Forms.RadioButton()
        Me.lblMoves = New System.Windows.Forms.Label()
        Me.picInv = New System.Windows.Forms.PictureBox()
        Me.boxActions.SuspendLayout()
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInventory.SuspendLayout()
        CType(Me.picInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radLookAt
        '
        Me.radLookAt.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.radLookAt.Checked = True
        Me.radLookAt.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLookAt.Location = New System.Drawing.Point(6, 19)
        Me.radLookAt.Name = "radLookAt"
        Me.radLookAt.Size = New System.Drawing.Size(88, 22)
        Me.radLookAt.TabIndex = 0
        Me.radLookAt.TabStop = True
        Me.radLookAt.Text = "Look At"
        Me.radLookAt.UseVisualStyleBackColor = True
        '
        'radPickUp
        '
        Me.radPickUp.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.radPickUp.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPickUp.Location = New System.Drawing.Point(6, 100)
        Me.radPickUp.Name = "radPickUp"
        Me.radPickUp.Size = New System.Drawing.Size(88, 22)
        Me.radPickUp.TabIndex = 3
        Me.radPickUp.Text = "Pick Up"
        Me.radPickUp.UseVisualStyleBackColor = True
        '
        'boxActions
        '
        Me.boxActions.Controls.Add(Me.radTalkTo)
        Me.boxActions.Controls.Add(Me.radInteract)
        Me.boxActions.Controls.Add(Me.radLookAt)
        Me.boxActions.Controls.Add(Me.radUseItem)
        Me.boxActions.Controls.Add(Me.radPickUp)
        Me.boxActions.Font = New System.Drawing.Font("Algerian", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxActions.Location = New System.Drawing.Point(6, 9)
        Me.boxActions.Name = "boxActions"
        Me.boxActions.Size = New System.Drawing.Size(104, 165)
        Me.boxActions.TabIndex = 0
        Me.boxActions.TabStop = False
        Me.boxActions.Text = "Actions"
        '
        'radTalkTo
        '
        Me.radTalkTo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.radTalkTo.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTalkTo.Location = New System.Drawing.Point(6, 73)
        Me.radTalkTo.Name = "radTalkTo"
        Me.radTalkTo.Size = New System.Drawing.Size(88, 22)
        Me.radTalkTo.TabIndex = 2
        Me.radTalkTo.Text = "Talk to"
        Me.radTalkTo.UseVisualStyleBackColor = True
        '
        'radInteract
        '
        Me.radInteract.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.radInteract.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radInteract.Location = New System.Drawing.Point(6, 46)
        Me.radInteract.Name = "radInteract"
        Me.radInteract.Size = New System.Drawing.Size(88, 22)
        Me.radInteract.TabIndex = 1
        Me.radInteract.Text = "Interact"
        Me.radInteract.UseVisualStyleBackColor = True
        '
        'radUseItem
        '
        Me.radUseItem.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.radUseItem.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radUseItem.Location = New System.Drawing.Point(6, 128)
        Me.radUseItem.Name = "radUseItem"
        Me.radUseItem.Size = New System.Drawing.Size(88, 22)
        Me.radUseItem.TabIndex = 4
        Me.radUseItem.Text = "Use Item"
        Me.radUseItem.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Font = New System.Drawing.Font("Algerian", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(12, 373)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(88, 40)
        Me.btnHelp.TabIndex = 3
        Me.btnHelp.TabStop = False
        Me.btnHelp.Text = "Help!"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'picRight
        '
        Me.picRight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picRight.Cursor = System.Windows.Forms.Cursors.PanEast
        Me.picRight.Location = New System.Drawing.Point(748, 21)
        Me.picRight.Name = "picRight"
        Me.picRight.Size = New System.Drawing.Size(46, 349)
        Me.picRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRight.TabIndex = 23
        Me.picRight.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Font = New System.Drawing.Font("Algerian", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(12, 416)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 40)
        Me.btnExit.TabIndex = 4
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picLeft
        '
        Me.picLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picLeft.Cursor = System.Windows.Forms.Cursors.PanWest
        Me.picLeft.Location = New System.Drawing.Point(116, 21)
        Me.picLeft.Name = "picLeft"
        Me.picLeft.Size = New System.Drawing.Size(46, 349)
        Me.picLeft.TabIndex = 24
        Me.picLeft.TabStop = False
        '
        'btnEnter
        '
        Me.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEnter.Font = New System.Drawing.Font("Algerian", 15.75!)
        Me.btnEnter.Location = New System.Drawing.Point(703, 416)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(91, 40)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'txtIn
        '
        Me.txtIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtIn.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txtIn.Location = New System.Drawing.Point(116, 417)
        Me.txtIn.Multiline = True
        Me.txtIn.Name = "txtIn"
        Me.txtIn.Size = New System.Drawing.Size(581, 40)
        Me.txtIn.TabIndex = 1
        '
        'lblOut
        '
        Me.lblOut.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblOut.BackColor = System.Drawing.Color.MistyRose
        Me.lblOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOut.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblOut.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOut.Location = New System.Drawing.Point(116, 373)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(678, 40)
        Me.lblOut.TabIndex = 22
        '
        'picBook
        '
        Me.picBook.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picBook.Image = Global.Advent.My.Resources.Resources.book
        Me.picBook.Location = New System.Drawing.Point(400, 117)
        Me.picBook.Name = "picBook"
        Me.picBook.Size = New System.Drawing.Size(198, 130)
        Me.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBook.TabIndex = 19
        Me.picBook.TabStop = False
        '
        'picKey
        '
        Me.picKey.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picKey.Image = Global.Advent.My.Resources.Resources.key1
        Me.picKey.Location = New System.Drawing.Point(264, 117)
        Me.picKey.Name = "picKey"
        Me.picKey.Size = New System.Drawing.Size(84, 34)
        Me.picKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picKey.TabIndex = 17
        Me.picKey.TabStop = False
        '
        'picBackground
        '
        Me.picBackground.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBackground.Image = Global.Advent.My.Resources.Resources.bg
        Me.picBackground.Location = New System.Drawing.Point(116, 21)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(678, 349)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBackground.TabIndex = 16
        Me.picBackground.TabStop = False
        '
        'grpInventory
        '
        Me.grpInventory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpInventory.Controls.Add(Me.picInv)
        Me.grpInventory.Controls.Add(Me.radInvThree)
        Me.grpInventory.Controls.Add(Me.radInvTwo)
        Me.grpInventory.Controls.Add(Me.radInvOne)
        Me.grpInventory.Font = New System.Drawing.Font("Algerian", 8.25!)
        Me.grpInventory.Location = New System.Drawing.Point(6, 180)
        Me.grpInventory.Name = "grpInventory"
        Me.grpInventory.Size = New System.Drawing.Size(104, 164)
        Me.grpInventory.TabIndex = 25
        Me.grpInventory.TabStop = False
        Me.grpInventory.Text = "Inventory"
        '
        'radInvThree
        '
        Me.radInvThree.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.radInvThree.Enabled = False
        Me.radInvThree.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radInvThree.Location = New System.Drawing.Point(6, 77)
        Me.radInvThree.Name = "radInvThree"
        Me.radInvThree.Size = New System.Drawing.Size(88, 22)
        Me.radInvThree.TabIndex = 2
        Me.radInvThree.Text = "Empty"
        Me.radInvThree.UseVisualStyleBackColor = True
        '
        'radInvTwo
        '
        Me.radInvTwo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.radInvTwo.Enabled = False
        Me.radInvTwo.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radInvTwo.Location = New System.Drawing.Point(6, 49)
        Me.radInvTwo.Name = "radInvTwo"
        Me.radInvTwo.Size = New System.Drawing.Size(88, 22)
        Me.radInvTwo.TabIndex = 1
        Me.radInvTwo.Text = "Empty"
        Me.radInvTwo.UseVisualStyleBackColor = True
        '
        'radInvOne
        '
        Me.radInvOne.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.radInvOne.Enabled = False
        Me.radInvOne.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radInvOne.Location = New System.Drawing.Point(6, 21)
        Me.radInvOne.Name = "radInvOne"
        Me.radInvOne.Size = New System.Drawing.Size(88, 22)
        Me.radInvOne.TabIndex = 0
        Me.radInvOne.Text = "Empty"
        Me.radInvOne.UseVisualStyleBackColor = True
        '
        'lblMoves
        '
        Me.lblMoves.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMoves.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoves.Location = New System.Drawing.Point(12, 347)
        Me.lblMoves.Name = "lblMoves"
        Me.lblMoves.Size = New System.Drawing.Size(88, 23)
        Me.lblMoves.TabIndex = 26
        Me.lblMoves.Text = "0"
        Me.lblMoves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picInv
        '
        Me.picInv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picInv.Location = New System.Drawing.Point(9, 105)
        Me.picInv.Name = "picInv"
        Me.picInv.Size = New System.Drawing.Size(85, 53)
        Me.picInv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picInv.TabIndex = 3
        Me.picInv.TabStop = False
        '
        'Advent
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 466)
        Me.Controls.Add(Me.lblMoves)
        Me.Controls.Add(Me.grpInventory)
        Me.Controls.Add(Me.boxActions)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.picRight)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picLeft)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtIn)
        Me.Controls.Add(Me.lblOut)
        Me.Controls.Add(Me.picBook)
        Me.Controls.Add(Me.picKey)
        Me.Controls.Add(Me.picBackground)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Advent"
        Me.Text = "Advent"
        Me.boxActions.ResumeLayout(False)
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInventory.ResumeLayout(False)
        CType(Me.picInv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radLookAt As RadioButton
    Friend WithEvents radPickUp As RadioButton
    Friend WithEvents boxActions As GroupBox
    Friend WithEvents radTalkTo As RadioButton
    Friend WithEvents radInteract As RadioButton
    Friend WithEvents btnHelp As Button
    Friend WithEvents picRight As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents picLeft As PictureBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents txtIn As TextBox
    Friend WithEvents lblOut As Label
    Friend WithEvents picBook As PictureBox
    Friend WithEvents picKey As PictureBox
    Friend WithEvents picBackground As PictureBox
    Friend WithEvents grpInventory As GroupBox
    Friend WithEvents radInvOne As RadioButton
    Friend WithEvents radInvThree As RadioButton
    Friend WithEvents radInvTwo As RadioButton
    Friend WithEvents radUseItem As RadioButton
    Friend WithEvents lblMoves As Label
    Friend WithEvents picInv As PictureBox
End Class
