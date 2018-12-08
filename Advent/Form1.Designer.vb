<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMann
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
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.lblHope = New System.Windows.Forms.Label()
        Me.txtLearn = New System.Windows.Forms.TextBox()
        Me.lblFortune = New System.Windows.Forms.Label()
        Me.btnSpeak = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAge
        '
        Me.lblAge.Location = New System.Drawing.Point(16, 16)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(158, 77)
        Me.lblAge.TabIndex = 0
        Me.lblAge.Text = "You place the key into the hole, and turn. Suddenly, the mannequin begins to move" &
    ". A voice echoes out of it, 'What is your age?"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(19, 96)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(155, 20)
        Me.txtAge.TabIndex = 0
        '
        'lblDay
        '
        Me.lblDay.Location = New System.Drawing.Point(16, 150)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(158, 38)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "On what day of the month were you born?"
        Me.lblDay.Visible = False
        '
        'txtDay
        '
        Me.txtDay.Location = New System.Drawing.Point(19, 191)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(155, 20)
        Me.txtDay.TabIndex = 1
        Me.txtDay.Visible = False
        '
        'lblHope
        '
        Me.lblHope.Location = New System.Drawing.Point(16, 232)
        Me.lblHope.Name = "lblHope"
        Me.lblHope.Size = New System.Drawing.Size(158, 38)
        Me.lblHope.TabIndex = 0
        Me.lblHope.Text = "What do you hope to learn from this?"
        Me.lblHope.Visible = False
        '
        'txtLearn
        '
        Me.txtLearn.Location = New System.Drawing.Point(19, 273)
        Me.txtLearn.Name = "txtLearn"
        Me.txtLearn.Size = New System.Drawing.Size(155, 20)
        Me.txtLearn.TabIndex = 2
        Me.txtLearn.Visible = False
        '
        'lblFortune
        '
        Me.lblFortune.Font = New System.Drawing.Font("Algerian", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFortune.Location = New System.Drawing.Point(218, 16)
        Me.lblFortune.Name = "lblFortune"
        Me.lblFortune.Size = New System.Drawing.Size(330, 138)
        Me.lblFortune.TabIndex = 0
        '
        'btnSpeak
        '
        Me.btnSpeak.Font = New System.Drawing.Font("Algerian", 15.75!)
        Me.btnSpeak.Location = New System.Drawing.Point(201, 341)
        Me.btnSpeak.Name = "btnSpeak"
        Me.btnSpeak.Size = New System.Drawing.Size(169, 58)
        Me.btnSpeak.TabIndex = 2
        Me.btnSpeak.Text = "SPEAK"
        Me.btnSpeak.UseVisualStyleBackColor = True
        '
        'frmMann
        '
        Me.AcceptButton = Me.btnSpeak
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 432)
        Me.Controls.Add(Me.btnSpeak)
        Me.Controls.Add(Me.txtLearn)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblHope)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblFortune)
        Me.Controls.Add(Me.lblAge)
        Me.Name = "frmMann"
        Me.Text = "Advent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAge As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblDay As Label
    Friend WithEvents txtDay As TextBox
    Friend WithEvents lblHope As Label
    Friend WithEvents txtLearn As TextBox
    Friend WithEvents lblFortune As Label
    Friend WithEvents btnSpeak As Button
End Class
