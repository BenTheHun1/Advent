Imports System.ComponentModel

Public Class frmMann
    Dim mintFortuneStep As Integer = 0
    Dim mintFortune As Integer
    Private Sub btnSpeak_Click(sender As Object, e As EventArgs) Handles btnSpeak.Click
        Dim intAge As Integer
        Dim intday As Integer
        Dim strHope As String
        Select Case mintFortuneStep
            Case 0
                'checks that input Is numeric (because it Is asking for age)
                If Not IsNumeric(txtAge.Text) Then
                    lblFortune.Text = "Perhaps you should try again?"
                    txtAge.SelectAll()
                    Exit Sub
                End If
                intAge = Int(txtAge.Text)
                'ensures the age is reasonable (the oldest recorded person ever lived to be 123)
                If intAge < 0 Or intAge > 123 Then
                    lblFortune.Text = "Perhaps you should try again?"
                    txtAge.SelectAll()
                    Exit Sub
                End If
                mintFortuneStep = 1
                lblDay.Visible = True
                txtDay.Visible = True
                txtAge.Enabled = False
                txtDay.Focus()
            Case 1
                'checks that input is numeric (because it is asking for a day)
                If Not IsNumeric(txtDay.Text) Then
                    lblFortune.Text = "Perhaps you should try again?"
                    txtDay.SelectAll()
                    Exit Sub
                End If
                'ensures it is a real day
                intday = Int(txtDay.Text)
                If intday < 1 Or intday > 31 Then
                    lblFortune.Text = "I don't believe that day exists in this timeline. Perhaps you should try again?"
                    txtDay.SelectAll()
                    Exit Sub
                End If
                mintFortuneStep = 2
                lblHope.Visible = True
                txtLearn.Visible = True
                txtDay.Enabled = False
                txtLearn.Focus()
            Case = 2
                'checks input *isnt* numeric, because it's asking for a string answer.
                If IsNumeric(txtLearn.Text) Then
                    lblFortune.Text = "Are you sure that's right?"
                    txtLearn.SelectAll()
                    Exit Sub
                End If
                strHope = txtLearn.Text
                'adds random number
                mintFortune += Int(CInt(txtAge.Text) + CInt(txtDay.Text) + (Rnd() * 10 + 1))
                'based on total of mintFortune, outputs a cryptic "fortune"
                Select Case mintfortune
                    Case < 10
                        lblFortune.Text = "'What you seek is in the stars.'"
                    Case < 20
                        lblFortune.Text = "'Be wary of the wandering questions.'"
                    Case < 30
                        lblFortune.Text = "'Remember to check for loose change behind your ears.'"
                    Case < 40
                        lblFortune.Text = "'Do not speak of this matter any further. It will only bring pain.'"
                    Case < 50
                        lblFortune.Text = "'You are better off not knowing.'"
                    Case < 60
                        lblFortune.Text = "'You ought to see a doctor about that.'"
                    Case < 70
                        lblFortune.Text = "'Gold is the colour of fools.'"
                    Case < 80
                        lblFortune.Text = "'Do not be ashamed of your future.'"
                    Case Else
                        lblFortune.Text = "'I'll remind you later.'"
                End Select
                txtLearn.Enabled = False
                btnSpeak.Enabled = False
        End Select
    End Sub

    Private Sub frmMann_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub frmMann_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If mintfortune = Nothing Then
            e.Cancel = True
        End If
    End Sub
End Class