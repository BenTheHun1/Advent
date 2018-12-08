'Benjamin Hunsicker
'10/17/18
'Advent 2, 10/18/18, Unit 3
'-----------------------------------------------------------------------------------
'A rewrite and expansion of my first project. It's an attempt to make an adventure puzzle game, along the lines of Myst.
'-----------------------------------------------------------------------------------

Public Class Advent
    Private Sub Advent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets up the randomized element of the fortune-telling
        Randomize()
        picBackground.Image = My.Resources.bg
        picKey.Image = My.Resources.key1
        picBook.Image = My.Resources.book
        picItem.Image = My.Resources.interdiction
        picLook.Image = My.Resources.eye
        picTake.Image = My.Resources.pickup
        picUse.Image = My.Resources.grab
        picTalk.Image = My.Resources.talk
        picHole.Image = My.Resources.keyhole
    End Sub

    'Modular Variables
    Dim mintLocation As Integer = 0
    Dim mintBookLocation As Integer = 0
    Dim mintKeyLocation As Integer = 0
    Dim mintFortuneStep As Integer = -1
    Dim mintAge As Integer
    Dim mintDay As Integer
    Dim mstrHope As String
    Dim mintFortune As Integer
    Dim mintFortuneOut As Integer
    Dim mstrActionMode As String = "look"

    Private Sub picKey_Click(sender As Object, e As EventArgs) Handles picKey.Click
        'Checks which action is selected
        Select Case mstrActionMode
            Case "look"
                lblOut.Text = "A golden key lies on the desk. What could it go to?"
            Case "use"
                lblOut.Text = "The golden key feels cool to the touch. It could be Picked Up."
            Case "talk"
                lblOut.Text = "It doesn't have much to say."
            Case "take"
                lstInv.Items.Add("Golden Key")
                mintKeyLocation = -1
                picKey.Visible = False
            Case Else
                lblOut.Text = "Nothing happens."
                Exit Sub
        End Select
    End Sub

    Private Sub picBook_Click(sender As Object, e As EventArgs) Handles picBook.Click
        'Same setup as picKey
        Select Case mstrActionMode
            Case "look"
                lblOut.Text = "A book lies open on the desk. Reading a few lines, it seems to be about an ancient historical event of some sort."
            Case "use"
                lblOut.Text = "You turn the page. It continues to discuss the ancient event."
            Case "talk"
                lblOut.Text = "It doesn't have much to say."
            Case "take"
                lstInv.Items.Add("Ancient Book")
                mintBookLocation = -1
                picBook.Visible = False
            Case Else
                lblOut.Text = "Nothing happens."
                Exit Sub
        End Select
    End Sub

    Private Sub picBackground_Click(sender As Object, e As EventArgs) Handles picBackground.Click
        'mintLocation tracks where in the world you are. 0 is the start.
        Select Case mintLocation
            Case = 0
                'Same setup as picKey and picBook.
                Select Case mstrActionMode
                    Case "look"
                        lblOut.Text = "A sturdy wooden desk lies in front of you."
                    Case "use"
                        lblOut.Text = "The desk appears to have drawers, but they do not budge."
                    Case "talk"
                        lblOut.Text = "It doesn't have much to say."
                    Case "take"
                        lblOut.Text = "It is much too heavy."
                    Case Else
                        lblOut.Text = "Nothing happens."
                        Exit Sub
                End Select
            Case = 1
                Select Case mstrActionMode
                    Case "look"
                        If mintFortuneStep < 0 Then
                            lblOut.Text = "In front of you lies a glass box, inside of which is a peculiar mannequin. On the side, there is a keyhole surrounded by a circle of gold."
                        Else
                            lblOut.Text = "The mannequin awaits your response."
                        End If
                    Case "use"
                        lblOut.Text = "The mannequin does not respond to your gestures."
                    Case "talk"
                        lblOut.Text = "The mannequin looks like it has a head full of secrets. What has his black, beady eyes seen?"
                    Case "take"
                        lblOut.Text = "It is much too heavy."
                    Case "item"
                        If lstInv.SelectedItem = "Golden Key" And mintFortuneStep < 0 Then
                            frmMann.Show()
                        End If
                    Case "item" And mintFortuneStep >= 0
                        lblOut.Text = "The mannequin patiently awaits your response."
                    Case Else
                        lblOut.Text = "Nothing happens."
                        Exit Sub
                End Select
        End Select
    End Sub

    Private Sub picLeft_Click(sender As Object, e As EventArgs) Handles picLeft.Click
        If mintLocation = 0 Then
            mintLocation = 2
        Else
            mintLocation -= 1
        End If
        movement()
    End Sub

    Private Sub picRight_Click(sender As Object, e As EventArgs) Handles picRight.Click
        If mintLocation = 2 Then
            mintLocation = 0
        Else
            mintLocation += 1
        End If
        movement()
    End Sub

    Private Sub movement()
        'handles movement when the edges of the screen are clicked.
        Select Case mintLocation
            Case = 0
                picBackground.Image = My.Resources.bg
                'If the items have been collected, they are hidden.
                If mintKeyLocation = 0 Then
                    picKey.Visible = True
                Else
                    picKey.Visible = False
                End If
                If mintBookLocation = 0 Then
                    picBook.Visible = True
                Else
                    picBook.Visible = False
                End If
                picHole.Visible = False

            Case = 1
                picBackground.Image = My.Resources.bg1
                picKey.Visible = False
                picBook.Visible = False
                picHole.Visible = False

            Case = 2
                picBackground.Image = My.Resources.door
                picHole.Visible = True
                picKey.Visible = False
                picBook.Visible = False

        End Select
    End Sub

    Private Sub picLook_Click(sender As Object, e As EventArgs) Handles picLook.Click
        Dim cur As Cursor = New Cursor(New IO.MemoryStream(My.Resources.look))
        Me.Cursor = cur
        mstrActionMode = "look"
    End Sub

    Private Sub picUse_Click(sender As Object, e As EventArgs) Handles picUse.Click
        Dim cur As Cursor = New Cursor(New IO.MemoryStream(My.Resources.openhand))
        Me.Cursor = cur
        mstrActionMode = "use"
    End Sub

    Private Sub picTalk_Click(sender As Object, e As EventArgs) Handles picTalk.Click
        Dim cur As Cursor = New Cursor(New IO.MemoryStream(My.Resources.speech))
        Me.Cursor = cur
        mstrActionMode = "talk"
    End Sub

    Private Sub picTake_Click(sender As Object, e As EventArgs) Handles picTake.Click
        Dim cur As Cursor = New Cursor(New IO.MemoryStream(My.Resources.usingitem))
        Me.Cursor = cur
        mstrActionMode = "take"
    End Sub

    Private Sub picItem_Click(sender As Object, e As EventArgs) Handles picItem.Click
        Dim cur As Cursor = New Cursor(New IO.MemoryStream(My.Resources.bag))
        Me.Cursor = cur
        mstrActionMode = "item"
    End Sub

    Private Sub Advent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Confirms user actually wants to quit, especially since there isn't any kind of saving system.
        If MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo) = vbYes Then
            Exit Sub
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub lstInv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstInv.SelectedIndexChanged
        Select Case lstInv.SelectedItem
            Case "Golden Key"
                picItem.Image = My.Resources.key1
            Case "Ancient Book"
                picItem.Image = My.Resources.book
        End Select
        picItem_Click(sender, e)
    End Sub

    Private Sub menSave_Click(sender As Object, e As EventArgs) Handles menSave.Click

    End Sub

    Private Sub menHelp_Click(sender As Object, e As EventArgs) Handles menHelp.Click
        MessageBox.Show("Welcome to Advent!" & vbNewLine & "To interact with the world: Click on the Action you would like to perform." & vbNewLine & "Eye: Look at" & vbNewLine & "Grabby Hand: Interact" & vbNewLine & "Speech Bubble: Talk to" & vbNewLine & "Hand Over Object: Pick up" & vbNewLine & "Fifth Action: Use selected item", "Help!", MessageBoxButtons.OK)
    End Sub

End Class