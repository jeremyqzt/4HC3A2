Imports MaterialSkin

Public Class TransferMoney

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

    End Sub
    Private Sub Form2_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Form1.Close()
    End Sub

    Private Function unloadTransfer() As Integer
        MPaymentB.Hide()
        TBetweenAccB.Hide()
        TByEmailB.Hide()
        Return 0
    End Function

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Hide()
        Form1.Show()
    End Sub


    Private Sub BackB_Click(sender As Object, e As EventArgs) Handles BackB.Click

    End Sub


    Private Sub MPaymentB_Click(sender As Object, e As EventArgs) Handles MPaymentB.Click

    End Sub

    Private Sub MainFinish_Click(sender As Object, e As EventArgs) Handles MainFinish.Click

    End Sub

    Private Sub Another_Click(sender As Object, e As EventArgs) Handles Another.Click

    End Sub
End Class