Imports MaterialSkin

Public Class Help
    Dim tick As Integer = 0
    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

    End Sub
    Private Sub Help_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Form1.Close()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Hide()
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Speech Off.wav")
        Form1.Show()
    End Sub


    Private Sub BackB_Click(sender As Object, e As EventArgs) Handles BackB.Click
        Me.Hide()
        Form1.Show()
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Speech Off.wav")

    End Sub

    Private Sub CheckBalanceB_Click(sender As Object, e As EventArgs)
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Windows Information Bar.wav")
        Me.Hide()
        Balance.Show()
    End Sub


    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs) Handles MaterialLabel1.Click

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Timer1.Enabled = True
        ProgressBar1.Visible = True
        ProgressBar1.ForeColor = Color.Blue
        MaterialLabel1.Text = "Now connecting, please wait."
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
            MaterialLabel1.Text = "You are now on call."
            liveGif.Show()
            endCall.Show()
            Cancel.Hide()
            MaterialRaisedButton1.Hide()
            ProgressBar1.Visible = False
        End If
    End Sub

    Private Sub endCall_Click(sender As Object, e As EventArgs) Handles endCall.Click
        liveGif.Hide()
        endCall.Hide()
        MaterialLabel1.Text = "Do you wish to speak with an agent?"
        MaterialRaisedButton1.Show()
        Cancel.Show()
        Me.Hide()
        Form2.Show()
    End Sub
End Class