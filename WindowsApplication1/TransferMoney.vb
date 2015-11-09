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
        MaterialRadioButton1.Hide()
        Return 0
    End Function
    Private Function loadTransfer() As Integer
        MPaymentB.Show()
        TBetweenAccB.Show()
        TByEmailB.Show()
        MaterialRadioButton1.Show()
        Return 0
    End Function
    Private Function unloadKeys() As Integer
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
        MaterialLabel1.Hide()
        PassField.Hide()
        Return 0
    End Function

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Hide()
        Form1.Show()
    End Sub


    Private Sub BackB_Click(sender As Object, e As EventArgs) Handles BackB.Click
        Me.Hide()
        Form2.Show
    End Sub


    Private Sub MPaymentB_Click(sender As Object, e As EventArgs) Handles MPaymentB.Click

    End Sub


    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub PassKey1_Click(sender As Object, e As EventArgs) Handles PassKey1.Click
        Dim current As String
        current = PassField.Text
        current = current + "1"
        PassField.Text = current
    End Sub

    Private Sub PassKey2_Click(sender As Object, e As EventArgs) Handles PassKey2.Click
        Dim current As String
        current = PassField.Text
        current = current + "2"
        PassField.Text = current
    End Sub

    Private Sub PassKey3_Click(sender As Object, e As EventArgs) Handles PassKey3.Click
        Dim current As String
        current = PassField.Text
        current = current + "3"
        PassField.Text = current
    End Sub

    Private Sub PassKey4_Click(sender As Object, e As EventArgs) Handles PassKey4.Click
        Dim current As String
        current = PassField.Text
        current = current + "4"
        PassField.Text = current
    End Sub

    Private Sub PassKey5_Click(sender As Object, e As EventArgs) Handles PassKey5.Click
        Dim current As String
        current = PassField.Text
        current = current + "5"
        PassField.Text = current
    End Sub

    Private Sub PassKey6_Click(sender As Object, e As EventArgs) Handles PassKey6.Click
        Dim current As String
        current = PassField.Text
        current = current + "6"
        PassField.Text = current
    End Sub

    Private Sub PassKey7_Click(sender As Object, e As EventArgs) Handles PassKey7.Click
        Dim current As String
        current = PassField.Text
        current = current + "7"
        PassField.Text = current
    End Sub

    Private Sub PassKey8_Click(sender As Object, e As EventArgs) Handles PassKey8.Click
        Dim current As String
        current = PassField.Text
        current = current + "8"
        PassField.Text = current
    End Sub

    Private Sub PassKey9_Click(sender As Object, e As EventArgs) Handles PassKey9.Click
        Dim current As String
        current = PassField.Text
        current = current + "9"
        PassField.Text = current
    End Sub

    Private Sub PassKey0_Click(sender As Object, e As EventArgs) Handles PassKey0.Click
        Dim current As String
        current = PassField.Text
        current = current + "0"
        PassField.Text = current
    End Sub

    Private Sub PassKeyCor_Click(sender As Object, e As EventArgs) Handles PassKeyCor.Click
        Dim current As String
        Dim length As Long
        current = PassField.Text
        length = current.Length
        If length > 1 Then
            PassField.Text = current.Substring(0, CInt(length))
        End If
    End Sub

    Private Sub PassKeyEnter_Click(sender As Object, e As EventArgs) Handles PassKeyEnter.Click
        Call loadTransfer()
        Call unloadKeys()
    End Sub

    Private Sub TBetweenAccB_Click(sender As Object, e As EventArgs) Handles TBetweenAccB.Click

    End Sub
End Class