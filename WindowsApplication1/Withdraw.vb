Imports MaterialSkin

Public Class Withdraw
    Dim WithdrawTrack As Integer = 0
    Dim WithdrawTick As Integer = 0
    Dim current As Integer = 0
    Private Sub Withdraw_Load(sender As Object, e As EventArgs)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub
    Private Function WithdrawReset() As Integer
        W60.Show()
        W80.Show()
        CustomAmountB.Show()
        W200.Show()
        W140.Show()
        W100.Show()
        W20.Show()
        W40.Show()

        Return 0
    End Function

    Private Function Quick_withrdraw(ByVal Numb As String) As Integer
        W60.Hide()
        W80.Hide()
        CustomAmountB.Hide()
        W200.Hide()
        W140.Hide()
        W100.Hide()
        W20.Hide()
        W40.Hide()
        WithdrawReciptNo.Show()
        WithdrawReciptYes.Show()
        MaterialLabel2.Text = ("Now withdrawing $" + Numb + ".00. Would you like a recipt?")
        Return 0

    End Function

    Public Function CustomWithdraw(ByVal Numb As String, ByVal NumbI As Integer) As Integer
        If ((WithdrawTrack = 0) And (NumbI = 0)) Then

        ElseIf (WithdrawTrack < 4) Then
            Dim currentDisp As String
            current = current * 10
            current = current + NumbI
            currentDisp = PassField.Text
            currentDisp = currentDisp + Numb
            PassField.Text = currentDisp
            WithdrawTrack = WithdrawTrack + 1

        End If
        Return 0
    End Function
    Private Sub WithdrawTxt_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Withdraw_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Form1.Close()
        Form2.Close()
    End Sub
    Private Sub Withdraw_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
        PassKeyEnter.Hide()
        PassField.Text = "$"
        current = 0
        WithdrawTrack = 0
        Cancel.Hide()

        WithdrawReset()
        Me.Hide()
        Form1.Show()
    End Sub


    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles CustomAmountB.Click
        W60.Hide()
        W80.Hide()
        CustomAmountB.Hide()
        W200.Hide()
        W140.Hide()
        W100.Hide()
        W20.Hide()
        W40.Hide()
        PassField.Show()
        PassKey1.Show()
        PassKey2.Show()
        PassKey3.Show()
        PassKey4.Show()
        PassKey5.Show()
        PassKey6.Show()
        PassKey7.Show()
        PassKey8.Show()
        PassKey9.Show()
        PassKey9.Show()
        PassKey0.Show()
        PassKeyCor.Show()
        PassKeyEnter.Show()
        Cancel.Show()

    End Sub

    Private Sub BackB_Click(sender As Object, e As EventArgs) Handles BackB.Click
        Me.Hide()
        W60.Show()
        W80.Show()
        CustomAmountB.Show()
        W200.Show()
        W140.Show()
        W100.Show()
        W20.Show()
        W40.Show()
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
        PassKeyEnter.Hide()
        Cancel.Hide()
        PassField.Text = "$"
        current = 0
        WithdrawTrack = 0
        Form2.Show()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
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
        PassKeyEnter.Hide()
        PassField.Text = "$"
        current = 0
        WithdrawTrack = 0
        Cancel.Hide()

        WithdrawReset()
    End Sub

    Private Sub PassKey1_Click(sender As Object, e As EventArgs) Handles PassKey1.Click
        CustomWithdraw("1", 1)
    End Sub

    Private Sub PassKey2_Click(sender As Object, e As EventArgs) Handles PassKey2.Click
        CustomWithdraw("2", 2)
    End Sub

    Private Sub PassKey3_Click(sender As Object, e As EventArgs) Handles PassKey3.Click
        CustomWithdraw("3", 3)
    End Sub

    Private Sub PassKey4_Click(sender As Object, e As EventArgs) Handles PassKey4.Click
        CustomWithdraw("4", 4)
    End Sub

    Private Sub PassKey5_Click(sender As Object, e As EventArgs) Handles PassKey5.Click
        CustomWithdraw("5", 5)
    End Sub

    Private Sub PassKey6_Click(sender As Object, e As EventArgs) Handles PassKey6.Click
        CustomWithdraw("6", 6)
    End Sub

    Private Sub PassKey7_Click(sender As Object, e As EventArgs) Handles PassKey7.Click
        CustomWithdraw("7", 7)
    End Sub

    Private Sub PassKey8_Click(sender As Object, e As EventArgs) Handles PassKey8.Click
        CustomWithdraw("8", 8)
    End Sub

    Private Sub PassKey9_Click(sender As Object, e As EventArgs) Handles PassKey9.Click
        CustomWithdraw("9", 9)
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles PassKey0.Click
        CustomWithdraw("0", 0)
    End Sub

    Private Sub PassKeyCor_Click(sender As Object, e As EventArgs) Handles PassKeyCor.Click
        Dim Removed As String
        Dim Amount As Integer
        Removed = PassField.Text
        Amount = Removed.Length
        If Amount > 1 Then
            PassField.Text = Removed.Substring(0, Amount - 1)
            WithdrawTrack = WithdrawTrack - 1
        End If
        While Not (current Mod 10 = 0)
            current = current - 1
        End While
        current = CInt(current * 0.1)
    End Sub

    Private Sub PassKeyEnter_Click(sender As Object, e As EventArgs) Handles PassKeyEnter.Click
        If ((current Mod 20) = 0) And (current > 0) Then
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
            PassKeyEnter.Hide()
            WithdrawTrack = 0
            Cancel.Hide()
            MaterialLabel2.Text = ("Now withdrawing " + PassField.Text + ".00. Would you like a recipt?")
            WithdrawReciptNo.Show()
            WithdrawReciptYes.Show()


        Else
            MsgBox("Only multiples of $20 is accepted")
        End If
    End Sub

    Private Sub W20_Click(sender As Object, e As EventArgs) Handles W20.Click
        Quick_withrdraw("20")
    End Sub

    Private Sub W40_Click(sender As Object, e As EventArgs) Handles W40.Click
        Quick_withrdraw("40")
    End Sub

    Private Sub W60_Click(sender As Object, e As EventArgs) Handles W60.Click
        Quick_withrdraw("60")
    End Sub

    Private Sub W80_Click(sender As Object, e As EventArgs) Handles W80.Click
        Quick_withrdraw("80")
    End Sub

    Private Sub W100_Click(sender As Object, e As EventArgs) Handles W100.Click
        Quick_withrdraw("100")
    End Sub

    Private Sub W140_Click(sender As Object, e As EventArgs) Handles W140.Click
        Quick_withrdraw("140")
    End Sub

    Private Sub W200_Click(sender As Object, e As EventArgs) Handles W200.Click
        Quick_withrdraw("200")
    End Sub

    Private Sub WithdrawReciptYes_Click(sender As Object, e As EventArgs) Handles WithdrawReciptYes.Click
        MaterialLabel2.Text = ("Now Printing")
        WithdrawReciptNo.Hide()
        WithdrawReciptYes.Hide()
        WithdrawTimer.Enabled = True
        MsgBox("RECIPT TEXT")
    End Sub
    Private Sub WithdrawReciptNo_Click(sender As Object, e As EventArgs) Handles WithdrawReciptNo.Click
        MaterialLabel2.Text = ("Now Printing")
        WithdrawReciptNo.Hide()
        WithdrawReciptYes.Hide()
        WithdrawTimer.Enabled = True

    End Sub
    Private Sub WithdrawTimer_Tick(sender As Object, e As EventArgs) Handles WithdrawTimer.Tick
        WithdrawTick = WithdrawTick + 1
        If WithdrawTick > 7 Then
            WithdrawTimer.Enabled = False
            WithdrawTick = 0
            WithdrawTimer.Enabled = False
            MaterialLabel2.Text = "Please take your money."
            WithdrawFinish.Show()
        End If
    End Sub


    Private Sub WithdrawFinish_Click(sender As Object, e As EventArgs) Handles WithdrawFinish.Click
        WithdrawFinish.Hide()
        MaterialLabel2.Text = ""
        WithdrawReset()
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class