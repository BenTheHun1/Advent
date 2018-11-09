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
    Dim mintMoves As Integer

    'Inventory Mod. Variables
    Dim mintNextInventory = 0
    Dim mintInvSlot1 = -1
    Dim mintInvSlot2 = -1
    Dim mintInvSlot3 = -1

    Private Sub picKey_Click(sender As Object, e As EventArgs) Handles picKey.Click
        'Checks which action is selected
        If radLookAt.Checked = True Then
            lblOut.Text = "A golden key lies on the desk. What could it go to?"
        ElseIf radInteract.Checked = True Then
            lblOut.Text = "The golden key feels cool to the touch. It could be Picked Up."
        ElseIf radTalkTo.Checked = True Then
            lblOut.Text = "It doesn't have much to say."
        ElseIf radPickUp.Checked = True Then
            'Handles inventory. Essentially, mintNextInventory determines which slot is used.
            If Not mintNextInventory = 3 Then
                mintNextInventory += 1
                If mintNextInventory = 1 Then
                    mintInvSlot1 = 1
                    radInvOne.Text = "Key"
                    radInvOne.Enabled = True
                ElseIf mintNextInventory = 2 Then
                    mintInvSlot2 = 1
                    radInvTwo.Text = "Key"
                    radInvTwo.Enabled = True
                Else
                    mintInvSlot3 = 1
                    radInvThree.Text = "Key"
                    radInvThree.Enabled = True
                End If
            Else
                lblOut.Text = "Your bag is full!"
                Exit Sub
            End If
            lblOut.Text = "Picked up."

            mintKeyLocation = -1
            picKey.Visible = False
        Else
            lblOut.Text = "Nothing happens."
            Exit Sub
        End If
        'A move counter. Only occurs if something happens (if the else statement isn't triggered).
        mintMoves += 1
        lblMoves.Text = mintMoves
    End Sub

    Private Sub picBook_Click(sender As Object, e As EventArgs) Handles picBook.Click
        'Same setup as picKey
        If radLookAt.Checked = True Then
            lblOut.Text = "A book lies open on the desk. Reading a few lines, it seems to be about an ancient historical event of some sort."
        ElseIf radInteract.Checked = True Then
            lblOut.Text = "You turn the page. It continues to discuss the ancient event."
        ElseIf radTalkTo.Checked = True Then
            lblOut.Text = "It doesn't have much to say."
        ElseIf radPickUp.Checked = True Then
            If Not mintNextInventory = 3 Then
                mintNextInventory += 1
                If mintNextInventory = 1 Then
                    mintInvSlot1 = 2
                    radInvOne.Text = "Book"
                    radInvOne.Enabled = True
                ElseIf mintNextInventory = 2 Then
                    mintInvSlot2 = 2
                    radInvTwo.Text = "Book"
                    radInvTwo.Enabled = True
                Else
                    mintInvSlot3 = 2
                    radInvThree.Text = "Book"
                    radInvThree.Enabled = True
                End If
            Else
                lblOut.Text = "Your bag is full!"
                Exit Sub
            End If
            lblOut.Text = "Picked up."
            mintBookLocation = -1
            picBook.Visible = False
        Else
            lblOut.Text = "Nothing happens."
            Exit Sub
        End If
        mintMoves += 1
        lblMoves.Text = mintMoves
    End Sub

    Private Sub picBackground_Click(sender As Object, e As EventArgs) Handles picBackground.Click
        'mintLocation tracks where in the world you are. 0 is the start.
        Select Case mintLocation
            Case = 0
                'Same setup as picKey and picBook.
                If radLookAt.Checked = True Then
                    lblOut.Text = "A sturdy wooden desk lies in front of you."
                ElseIf radInteract.Checked = True Then
                    lblOut.Text = "The desk appears to have drawers, but they do not budge."
                ElseIf radTalkTo.Checked = True Then
                    lblOut.Text = "It doesn't have much to say."
                ElseIf radPickUp.Checked = True Then
                    lblOut.Text = "It is much too heavy."
                Else
                    lblOut.Text = "Nothing happens."
                    Exit Sub
                End If
            Case = 1
                If radLookAt.Checked = True Then
                    If mintFortuneStep < 0 Then
                        lblOut.Text = "In front of you lies a glass box, inside of which is a peculiar mannequin. On the side, there is a keyhole surrounded by a circle of gold."
                    Else
                        lblOut.Text = "The mannequin awaits your response."
                    End If

                ElseIf radInteract.Checked = True Then
                    lblOut.Text = "The mannequin does not respond to your gestures."
                ElseIf radTalkTo.Checked = True Then
                    lblOut.Text = "The mannequin looks like it has a head full of secrets. What has his black, beady eyes seen?"
                ElseIf radPickUp.Checked = True Then
                    lblOut.Text = "It is much too heavy."
                ElseIf radUseItem.Checked = True Then
                    If radInvOne.Checked = True And mintInvSlot1 = 1 And mintFortuneStep < 0 Then
                        mintFortuneStep = 0
                        lblOut.Text = "You place the key into the hole, and turn. Suddenly, the mannequin begins to move. A voice echoes out of it, 'What is your age?' (Type into textbox and press 'Enter')"
                    ElseIf radInvTwo.Checked = True And mintInvSlot2 = 1 And mintFortuneStep < 0 Then
                        mintFortuneStep = 0
                        lblOut.Text = "You place the key into the hole, and turn. Suddenly, the mannequin begins to move. A voice echoes out of it, 'What is your age?' (Type into textbox and press 'Enter')"
                    ElseIf radInvThree.Checked = True And mintInvSlot2 = 1 And mintFortuneStep < 0 Then
                        mintFortuneStep = 0
                        lblOut.Text = "You place the key into the hole, and turn. Suddenly, the mannequin begins to move. A voice echoes out of it, 'What is your age?' (Type into textbox and press 'Enter')"
                    ElseIf mintFortuneStep >= 0 Then
                        lblOut.Text = "The mannequin patiently awaits your response."
                    Else
                        lblOut.Text = "Nothing happens."
                        Exit Sub
                    End If
                Else
                    lblOut.Text = "Nothing happens."
                    Exit Sub
                End If
        End Select
        mintMoves += 1
        lblMoves.Text = mintMoves
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Confirms user actually wants to quit, especially since there isn't any kind of saving system.
        If MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo) = vbYes Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub
    'Next few subs chnages cursor for a select few actions.
    Private Sub radLookAt_CheckedChanged(sender As Object, e As EventArgs) Handles radLookAt.CheckedChanged
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub radInteract_CheckedChanged(sender As Object, e As EventArgs) Handles radInteract.CheckedChanged
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub radTalkTo_CheckedChanged(sender As Object, e As EventArgs) Handles radTalkTo.CheckedChanged
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub radPickUp_CheckedChanged(sender As Object, e As EventArgs) Handles radPickUp.CheckedChanged
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub radUseItem_CheckedChanged(sender As Object, e As EventArgs) Handles radUseItem.CheckedChanged
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub picLeft_Click(sender As Object, e As EventArgs) Handles picLeft.Click, picRight.Click
        'handles movement when the edges of the screen are clicked.
        Select Case mintLocation
            Case = 0
                mintLocation = 1
                picBackground.Image = My.Resources.bg1
                picKey.Visible = False
                picBook.Visible = False
            Case = 1
                mintLocation = 0
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
        End Select
        mintMoves += 1
        lblMoves.Text = mintMoves
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'The "new" content. Use the key on the mannequin sets mintFortuneStep to 0
        Select Case mintFortuneStep
            'if mannequin hasnt been activated, then it clears the input box and doesn't proceed,
            Case = -1
                txtIn.Clear()
                Exit Sub
            Case = 0
                'checks that input is numeric (because it is asking for age)
                If Not IsNumeric(txtIn.Text) Then
                    lblOut.Text = "The mannequin looks at you curiously. Perhaps you should try again?"
                    txtIn.SelectAll()
                    Exit Sub
                End If
                mintAge = Int(txtIn.Text)
                'ensures the age is reasonable (the oldest recorded person ever lived to be 123)
                If mintAge < 0 Or mintAge > 123 Then
                    lblOut.Text = "The mannequin looks at you curiously. Perhaps you should try again?"
                    txtIn.SelectAll()
                    Exit Sub
                End If
                mintFortuneStep = 1
                mintFortune += mintAge
                lblOut.Text = "'On what day of the month were you born?'"
            Case = 1
                'checks that input is numeric (because it is asking for a day)
                If Not IsNumeric(txtIn.Text) Then
                    lblOut.Text = "The mannequin looks at you curiously. Perhaps you should try again?"
                    txtIn.SelectAll()
                    Exit Sub
                End If
                'ensures it is a real day
                mintDay = Int(txtIn.Text)
                If mintDay < 1 Or mintDay > 31 Then
                    lblOut.Text = "'I don't believe that day exists in this timeline.' Perhaps you should try again?"
                    txtIn.SelectAll()
                    Exit Sub
                End If
                mintFortuneStep = 2
                mintFortune += mintDay
                lblOut.Text = "'What do you hope to learn from this?'"
            Case = 2
                'checks input *isnt* numeric, because it's asking for a string answer.
                If IsNumeric(txtIn.Text) Then
                    lblOut.Text = "The mannequin looks at you cluelessly. Perhaps you should try again?"
                    txtIn.SelectAll()
                    Exit Sub
                End If
                mstrHope = txtIn.Text
                'adds random number
                mintFortune += Int(Rnd() * 10 + 1)
                'based on total of mintFortune, outputs a cryptic "fortune"
                Select Case mintFortune
                    Case < 10
                        mintFortuneOut = 1
                        lblOut.Text = "'What you seek is in the stars.'"
                    Case < 20
                        mintFortuneOut = 2
                        lblOut.Text = "'Be wary of the wandering questions.'"
                    Case < 30
                        mintFortuneOut = 3
                        lblOut.Text = "'Remember to check for loose change behind your ears.'"
                    Case < 40
                        mintFortuneOut = 4
                        lblOut.Text = "'Do not speak of this matter any further. It will only bring pain.'"
                    Case < 50
                        mintFortuneOut = 5
                        lblOut.Text = "'You are better off not knowing.'"
                    Case < 60
                        mintFortuneOut = 6
                        lblOut.Text = "'You ought to see a doctor about that.'"
                    Case < 70
                        mintFortuneOut = 7
                        lblOut.Text = "'Gold is the colour of fools.'"
                    Case < 80
                        mintFortuneOut = 8
                        lblOut.Text = "'Do not be ashamed of your future.'"
                    Case Else
                        mintFortuneOut = 9
                        lblOut.Text = "'I'll remind you later.'"
                End Select
                mintFortuneStep = -1
                mintFortune = Nothing
        End Select
        txtIn.Clear()
        mintMoves += 1
        lblMoves.Text = mintMoves
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        'Controls may not be immediately apparent, so I added a help button.
        MessageBox.Show("Welcome to Advent!" & Chr(10) & "To interact with the world: Choose from the list of actions and click where you want to do the action." & Chr(10) & "Click on the edges of the screen to move around." & Chr(10) & "To use an item, select the item from your inventory and select the 'Use item' action.", "Help!", MessageBoxButtons.OK)
    End Sub
    'Next three subs checks selected item when selected inventory spot is changed, and displays the approrpiate picture in picInv
    Private Sub radInvOne_CheckedChanged(sender As Object, e As EventArgs) Handles radInvOne.CheckedChanged
        If mintInvSlot1 = 1 Then
            picInv.Image = My.Resources.key1
        ElseIf mintInvSlot1 = 2 Then
            picInv.Image = My.Resources.book
        Else
            Exit Sub
        End If
    End Sub

    Private Sub radInvTwo_CheckedChanged(sender As Object, e As EventArgs) Handles radInvTwo.CheckedChanged
        If mintInvSlot2 = 1 Then
            picInv.Image = My.Resources.key1
        ElseIf mintInvSlot2 = 2 Then
            picInv.Image = My.Resources.book
        Else
            Exit Sub
        End If
    End Sub

    Private Sub radInvThree_CheckedChanged(sender As Object, e As EventArgs) Handles radInvThree.CheckedChanged
        If mintInvSlot3 = 1 Then
            picInv.Image = My.Resources.key1
        ElseIf mintInvSlot1 = 3 Then
            picInv.Image = My.Resources.book
        Else
            Exit Sub
        End If
    End Sub
End Class