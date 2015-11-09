Imports MaterialSkin

Public Class Balance
    Private Sub Balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub TByEmailB_Click(sender As Object, e As EventArgs) Handles TByEmailB.Click
        MaterialLabel1.Visible = True
        MaterialLabel2.Visible = True
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Windows Information Bar.wav")

        MaterialLabel5.Visible = True
    End Sub

    Private Sub MPaymentB_Click(sender As Object, e As EventArgs) Handles MPaymentB.Click
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Windows Information Bar.wav")
        MaterialLabel3.Visible = True
        MaterialLabel5.Visible = True
        MaterialLabel4.Visible = True
    End Sub

    Private Sub WithdrawReciptYes_Click(sender As Object, e As EventArgs) Handles WithdrawReciptYes.Click
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Speech Off.wav")
        Me.Hide()
        Form1.Show()
        MaterialLabel1.Visible = False
        MaterialLabel2.Visible = False
        MaterialLabel3.Visible = False
        MaterialLabel5.Visible = False
        MaterialLabel4.Visible = False
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        MsgBox("Printing Receipt")
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Print.wav")

    End Sub

    Private Sub Another_Click(sender As Object, e As EventArgs) Handles Another.Click
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Speech On.wav")
        Me.Hide()
        Form2.Show()
        MaterialLabel1.Visible = False
        MaterialLabel2.Visible = False
        MaterialLabel3.Visible = False
        MaterialLabel5.Visible = False
        MaterialLabel4.Visible = False
    End Sub

    Private Sub BackB_Click(sender As Object, e As EventArgs) Handles BackB.Click
        Me.Hide()
        Form2.Show()
        MaterialLabel1.Visible = False
        MaterialLabel2.Visible = False
        MaterialLabel3.Visible = False
        MaterialLabel5.Visible = False
        MaterialLabel4.Visible = False
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Hide()
        Form1.Show()
        MaterialLabel1.Visible = False
        MaterialLabel2.Visible = False
        MaterialLabel3.Visible = False
        MaterialLabel5.Visible = False
        MaterialLabel4.Visible = False
    End Sub
End Class