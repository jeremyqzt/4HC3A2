Imports MaterialSkin

Public Class Form1
    Dim tick As Integer
    Dim pinTrack As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles PassKey1.Click
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Windows Information Bar.wav")
        Call AddStar()
    End Sub

    Private Sub MaterialRaisedButton1_Click_1(sender As Object, e As EventArgs) Handles PassKey2.Click
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Windows Information Bar.wav")
        Call AddStar()
    End Sub
    Public Function AddStar() As Integer
        If (pinTrack < 4) Then
            Dim current As String
            current = PassField.Text
            current = current + "   *"
            PassField.Text = current
            pinTrack = pinTrack + 1

        End If
        Return 0
    End Function

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles PassKey3.Click
        Call AddStar()
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Windows Information Bar.wav")
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles PassKey4.Click
        Call AddStar()
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Windows Information Bar.wav")

    End Sub

    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles PassKey5.Click
        Call AddStar()
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Windows Information Bar.wav")

    End Sub

    Private Sub MaterialRaisedButton5_Click(sender As Object, e As EventArgs) Handles PassKey6.Click
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Windows Information Bar.wav")
        Call AddStar()
    End Sub

    Private Sub MaterialRaisedButton6_Click(sender As Object, e As EventArgs) Handles PassKey7.Click
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Windows Information Bar.wav")
        Call AddStar()
    End Sub

    Private Sub MaterialRaisedButton7_Click(sender As Object, e As EventArgs) Handles PassKey8.Click
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Windows Information Bar.wav")
        Call AddStar()
    End Sub

    Private Sub MaterialRaisedButton8_Click(sender As Object, e As EventArgs) Handles PassKey9.Click
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Windows Information Bar.wav")
        Call AddStar()
    End Sub


    Private Sub MaterialRaisedButton1_Click_2(sender As Object, e As EventArgs) Handles PassKey0.Click
        Call AddStar()
    End Sub

    Private Sub MaterialRaisedButton10_Click(sender As Object, e As EventArgs) Handles PassKeyCor.Click
        Dim Removed As String
        Dim Amount As Integer
        Removed = PassField.Text
        Amount = Removed.Length
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Windows Information Bar.wav")

        If Amount > 3 Then

            PassField.Text = Removed.Substring(0, Amount - 4)
            pinTrack = pinTrack - 1
        End If

    End Sub

    Private Sub ToMain_Click_1(sender As Object, e As EventArgs) Handles ToMain.Click
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Windows Information Bar.wav")
        ToMain.Visible = False
        PassField.Show()
        PassKey1.Show()
        PassKey2.Show()
        PassKey3.Show()
        'Info.Show()
        PassKey4.Show()
        PassKey5.Show()
        PassKey6.Show()
        PassKey7.Show()
        PassKey8.Show()
        PassKey9.Show()
        PassKey0.Show()
        PassKeyCor.Show()
        PassKeyEnter.Show()
        MaterialLabel1.Show()
        Cancel.Show()
        MaterialLabel1.Text = "Please enter your pin"
        Me.Text = "Welcome"
    End Sub
    Private Sub PassKeyEnter_Click(sender As Object, e As EventArgs) Handles PassKeyEnter.Click
        If (pinTrack = 4) Then
            PassField.Hide()
            PassKey1.Hide()
            PassKey2.Hide()
            PassKey3.Hide()
            PassKey4.Hide()
            PassKey5.Hide()
            PassKey6.Hide()
            PassKey7.Hide()
            PassKey8.Hide()
            PassKey9.Hide()
            PassKey0.Hide()
            PassKeyCor.Hide()
            MaterialLabel1.Text = "Please Wait While We Fetch Your Account Details..."
            PassKeyEnter.Hide()
            Cancel.Hide()
            My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Speech On.wav")
            pinTrack = 0

            ProgressBar1.Visible = True
            ProgressBar1.ForeColor = Color.Blue
            Timer1.Enabled = True
            'Info.Hide()

        Else
            Beep()
            MsgBox("Pin invalid, please try again")
        End If


    End Sub
    Private Sub PassField_Click(sender As Object, e As EventArgs) Handles PassField.Click

    End Sub
    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs) Handles MaterialLabel1.Click

    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        ToMain.Visible = True
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Speech Off.wav")
        PassField.Text = ""
        PassField.Hide()
        PassKey1.Hide()
        PassKey2.Hide()
        PassKey3.Hide()
        PassKey4.Hide()
        PassKey5.Hide()
        PassKey6.Hide()
        PassKey7.Hide()
        PassKey8.Hide()
        PassKey9.Hide()
        PassKey0.Hide()
        PassKeyCor.Hide()
        MaterialLabel1.Hide()
        PassKeyEnter.Hide()
        Cancel.Hide()
        pinTrack = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tick = tick + 1
        ProgressBar1.Increment(35)
        If tick > 3 Then
            ProgressBar1.Value = 0
            Timer1.Enabled = False
            tick = 0
            ProgressBar1.Visible = False
            Timer1.Enabled = False
            MaterialLabel1.Text = ""
            PassField.Text = ""
            ToMain.Show()
            Me.Hide()
            Form2.Show()
        End If
    End Sub

End Class