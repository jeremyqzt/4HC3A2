Imports MaterialSkin

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

    End Sub
    Private Sub Form2_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Form1.Close()
    End Sub


    Private Sub Withdraw_Click(sender As Object, e As EventArgs) Handles WithdrawB.Click
        My.Computer.Audio.Play(Environment.CurrentDirectory + "\Windows Information Bar.wav")
        Me.Hide()
        Withdraw.Show()

    End Sub
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Hide()
        My.Computer.Audio.Play(Environment.CurrentDirectory + "\Speech Off.wav")
        Form1.Show()
    End Sub

    Private Sub DepositB_Click(sender As Object, e As EventArgs) Handles DepositB.Click
        My.Computer.Audio.Play(Environment.CurrentDirectory + "\Windows Information Bar.wav")

        Me.Hide()
        Deposit.Show()
    End Sub

    Private Sub BackB_Click(sender As Object, e As EventArgs) Handles BackB.Click
        Me.Hide()
        Form1.Show()
        My.Computer.Audio.Play(Environment.CurrentDirectory + "\Speech Off.wav")

    End Sub

    Private Sub CheckBalanceB_Click(sender As Object, e As EventArgs) Handles CheckBalanceB.Click
        My.Computer.Audio.Play(Environment.CurrentDirectory + "\Windows Information Bar.wav")
        Me.Hide()
        Balance.Show()
    End Sub

    Private Sub WithdrawReciptYes_Click(sender As Object, e As EventArgs) Handles WithdrawReciptYes.Click
        Me.Hide()
        Form1.Show()
        My.Computer.Audio.Play(Environment.CurrentDirectory + "\Speech Off.wav")

    End Sub

    Private Sub MainTransfer_Click(sender As Object, e As EventArgs) Handles MainTransfer.Click
        TransferMoney.Show()
        My.Computer.Audio.Play(Environment.CurrentDirectory + "\Windows Information Bar.wav")
        Me.Hide()
    End Sub

    Private Sub info_Click(sender As Object, e As EventArgs) Handles info.Click
        My.Computer.Audio.Play(Environment.CurrentDirectory + "\Speech On.wav")
        Me.Hide()
        Help.Show()
    End Sub
End Class