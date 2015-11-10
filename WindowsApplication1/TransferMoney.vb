Imports MaterialSkin

Public Class TransferMoney
    Dim transferSelect As String = ""
    Dim TransferAmount As String = ""
    Dim pinTrack As Integer = 0
    Dim PaymentPayee As String = ""
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

    End Sub
    Private Sub Transfer_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Form1.Close()
    End Sub
    Private Function selectTransfer() As Integer
        TransferAmount = PassField.Text
        If transferSelect = "Payment" Then
            MaterialRadioButton1.Show()
            MaterialRadioButton2.Show()
            MaterialRadioButton3.Show()
            MaterialRadioButton4.Show()
            MaterialRadioButton5.Show()
            MaterialRadioButton6.Show()
            MaterialRadioButton7.Show()
            MaterialRadioButton8.Show()
            MaterialRadioButton9.Show()
            MaterialRadioButton10.Show()
            SelectPayee.Show()
            MaterialLabel2.Show()
            MaterialLabel2.Text = "Please choose the payee. " + TransferAmount + " is being transfered."
            NextPage.Show()
        ElseIf transferSelect = "BtwAcc" Then
            TransferTo.Show()
            TransferFrom.Show()
            MaterialLabel1.Show()
            MaterialLabel1.Text = "Please select the account to transfer."
            MaterialLabel2.Show()
            MaterialLabel2.Show()
            MaterialLabel2.Text = "Choose the account to transfer from"
            MaterialLabel3.Text = "Choose the account to transfer to"
            MaterialLabel3.Show()
        ElseIf transferSelect = "ByEmail" Then
            MaterialRadioButton15.Show()
            MaterialRadioButton12.Show()
            MaterialRadioButton13.Show()
            MaterialRadioButton14.Show()
            MaterialLabel1.Show()
            MaterialLabel1.Text = "Please select the E-mail to send to."
            SelectPayee.Show()
        End If
        Return 0
    End Function
    Private Sub Form2_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Form1.Close()
    End Sub
    Private Function loadKeys() As Integer
        PassKey1.Show()
        PassKey2.Show()
        PassKey3.Show()
        PassKey4.Show()
        PassKey5.Show()
        PassKey6.Show()
        PassKey7.Show()
        PassKey8.Show()
        PassKey9.Show()
        PassKey0.Show()
        MaterialLabel2.Hide()
        PassKeyCor.Show()
        PassKeyEnter.Show()
        MaterialLabel1.Show()
        PassField.Show()
        Cancel.Show()
        Return 0
    End Function
    Private Function unloadTransfer() As Integer
        MPaymentB.Hide()
        TBetweenAccB.Hide()
        TByEmailB.Hide()
        Return 0
    End Function
    Private Function loadTransfer() As Integer
        MPaymentB.Show()
        TBetweenAccB.Show()
        TByEmailB.Show()
        Return 0
    End Function
    Private Function unloadKeys() As Integer
        PassKey1.Hide()
        MaterialLabel2.Hide()
        MaterialLabel3.Hide()
        TransferTo.Hide()
        TransferFrom.Hide()
        PassKey2.Hide()
        PassKey3.Hide()
        PassKey4.Hide()
        PassKey5.Hide()
        PassKey6.Hide()
        NextPage.Hide()
        Previous.Hide()
        PrintRecipt.Hide()
        ReciptNo.Hide()
        PassField.Text = "$"
        Dim PaymentPayee As String = ""
        PassKey7.Hide()
        PassKey8.Hide()
        MaterialRadioButton1.Hide()
        MaterialRadioButton2.Hide()
        MaterialRadioButton3.Hide()
        MaterialRadioButton4.Hide()
        MaterialRadioButton5.Hide()
        MaterialRadioButton6.Hide()
        MaterialRadioButton7.Hide()
        MaterialRadioButton8.Hide()
        MaterialRadioButton9.Hide()
        MaterialRadioButton10.Hide()
        MaterialRadioButton11.Hide()
        MaterialRadioButton15.Hide()
        MaterialRadioButton12.Hide()
        MaterialRadioButton13.Hide()
        MaterialRadioButton14.Hide()
        MaterialLabel1.Hide()
        MaterialLabel2.Hide()
        MaterialLabel3.Hide()
        SelectPayee.Hide()
        PassKey9.Hide()
        PassKey0.Hide()
        Cancel.Hide()
        PassKeyCor.Hide()
        PassKeyEnter.Hide()
        MaterialLabel1.Hide()
        PassField.Hide()
        Return 0
    End Function

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        unloadKeys()
        loadTransfer()
        MaterialLabel2.Hide()
        MaterialLabel3.Hide()
        transferSelect = ""
        Me.Hide()
        Form1.Show()
    End Sub


    Private Sub BackB_Click(sender As Object, e As EventArgs) Handles BackB.Click
        unloadKeys()
        transferSelect = ""
        loadTransfer()
        Me.Hide()
        MaterialLabel2.Hide()
        MaterialLabel3.Hide()
        Form2.Show()
    End Sub


    Private Sub MPaymentB_Click(sender As Object, e As EventArgs) Handles MPaymentB.Click
        unloadTransfer()
        transferSelect = "Payment"
        loadKeys()
    End Sub


    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        loadTransfer()
        MaterialLabel2.Hide()
        MaterialLabel3.Hide()
        transferSelect = ""
        TransferAmount = ""
        unloadKeys()
    End Sub

    Private Sub PassKey1_Click(sender As Object, e As EventArgs) Handles PassKey1.Click
        Dim current As String
        current = PassField.Text
        current = current + "1"
        pinTrack = pinTrack + 1
        PassField.Text = current
    End Sub

    Private Sub PassKey2_Click(sender As Object, e As EventArgs) Handles PassKey2.Click
        Dim current As String
        current = PassField.Text
        pinTrack = pinTrack + 1
        current = current + "2"
        PassField.Text = current
    End Sub

    Private Sub PassKey3_Click(sender As Object, e As EventArgs) Handles PassKey3.Click
        Dim current As String
        current = PassField.Text
        pinTrack = pinTrack + 1
        current = current + "3"
        PassField.Text = current
    End Sub

    Private Sub PassKey4_Click(sender As Object, e As EventArgs) Handles PassKey4.Click
        Dim current As String
        current = PassField.Text
        current = current + "4"
        pinTrack = pinTrack + 1
        PassField.Text = current
    End Sub

    Private Sub PassKey5_Click(sender As Object, e As EventArgs) Handles PassKey5.Click
        Dim current As String
        current = PassField.Text
        pinTrack = pinTrack + 1
        current = current + "5"
        PassField.Text = current
    End Sub

    Private Sub PassKey6_Click(sender As Object, e As EventArgs) Handles PassKey6.Click
        Dim current As String
        current = PassField.Text
        current = current + "6"
        PassField.Text = current
        pinTrack = pinTrack + 1
    End Sub

    Private Sub PassKey7_Click(sender As Object, e As EventArgs) Handles PassKey7.Click
        Dim current As String
        current = PassField.Text
        current = current + "7"
        pinTrack = pinTrack + 1
        PassField.Text = current
    End Sub

    Private Sub PassKey8_Click(sender As Object, e As EventArgs) Handles PassKey8.Click
        Dim current As String
        current = PassField.Text
        current = current + "8"
        PassField.Text = current
        pinTrack = pinTrack + 1
    End Sub

    Private Sub PassKey9_Click(sender As Object, e As EventArgs) Handles PassKey9.Click
        Dim current As String
        current = PassField.Text
        current = current + "9"
        PassField.Text = current
        pinTrack = pinTrack + 1
    End Sub

    Private Sub PassKey0_Click(sender As Object, e As EventArgs) Handles PassKey0.Click
        Dim current As String
        current = PassField.Text
        current = current + "0"
        pinTrack = pinTrack + 1
        PassField.Text = current
    End Sub

    Private Sub PassKeyCor_Click(sender As Object, e As EventArgs) Handles PassKeyCor.Click
        Dim current As String
        Dim length As Long
        current = PassField.Text
        length = current.Length
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Windows Information Bar.wav")

        If length > 1 Then

            PassField.Text = current.Substring(0, CInt(length - 1))
            pinTrack = pinTrack - 1
        End If
    End Sub

    Private Sub PassKeyEnter_Click(sender As Object, e As EventArgs) Handles PassKeyEnter.Click
        selectTransfer()
        PassKey1.Hide()
        PassKey2.Hide()
        PassKey3.Hide()
        PassKey4.Hide()
        PassKey5.Hide()
        PassKey6.Hide()
        PassField.Text = "$"
        PassKey7.Hide()
        PassKey8.Hide()
        PassKey9.Hide()
        PassKey0.Hide()
        PassKeyCor.Hide()
        PassKeyEnter.Hide()
        MaterialLabel1.Hide()
        PassField.Hide()
    End Sub

    Private Sub TBetweenAccB_Click(sender As Object, e As EventArgs) Handles TBetweenAccB.Click
        unloadTransfer()
        loadKeys()
        transferSelect = "BtwAcc"
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        PaymentPayee = MaterialRadioButton1.Text
    End Sub

    Private Sub MaterialRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton1.CheckedChanged

    End Sub

    Private Sub PassField_Click(sender As Object, e As EventArgs) Handles PassField.Click

    End Sub

    Private Sub TByEmailB_Click(sender As Object, e As EventArgs) Handles TByEmailB.Click
        unloadTransfer()
        transferSelect = "ByEmail"
        loadKeys()
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles NextPage.Click
        MaterialRadioButton1.Hide()
        MaterialRadioButton2.Hide()
        MaterialRadioButton3.Hide()
        MaterialRadioButton4.Hide()
        MaterialRadioButton5.Hide()
        MaterialRadioButton6.Hide()
        MaterialRadioButton7.Hide()
        MaterialRadioButton8.Hide()
        MaterialRadioButton9.Hide()
        MaterialRadioButton10.Hide()
        MaterialRadioButton11.Show()
        NextPage.Hide()
        Previous.Show()
    End Sub

    Private Sub MaterialRadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton5.CheckedChanged
        PaymentPayee = MaterialRadioButton5.Text
    End Sub

    Private Sub MaterialLabel3_Click(sender As Object, e As EventArgs) Handles MaterialLabel3.Click

    End Sub

    Private Sub TransferFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TransferFrom.SelectedIndexChanged

    End Sub

    Private Sub Previous_Click(sender As Object, e As EventArgs) Handles Previous.Click
        MaterialRadioButton1.Show()
        MaterialRadioButton2.Show()
        MaterialRadioButton3.Show()
        MaterialRadioButton4.Show()
        MaterialRadioButton5.Show()
        MaterialRadioButton6.Show()
        MaterialRadioButton7.Show()
        MaterialRadioButton8.Show()
        MaterialRadioButton11.Hide()
        MaterialRadioButton9.Show()
        MaterialRadioButton10.Show()
        NextPage.Show()
        Previous.Hide()
    End Sub

    Private Sub MaterialRadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton11.CheckedChanged
        PaymentPayee = MaterialRadioButton11.Text
    End Sub

    Private Sub MaterialRadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton7.CheckedChanged
        PaymentPayee = MaterialRadioButton7.Text
    End Sub

    Private Sub MaterialRadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton10.CheckedChanged
        PaymentPayee = MaterialRadioButton10.Text
    End Sub

    Private Sub MaterialRadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton3.CheckedChanged
        PaymentPayee = MaterialRadioButton3.Text
    End Sub

    Private Sub MaterialRadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton2.CheckedChanged
        PaymentPayee = MaterialRadioButton2.Text
    End Sub

    Private Sub MaterialRadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton8.CheckedChanged
        PaymentPayee = MaterialRadioButton8.Text
    End Sub

    Private Sub MaterialRadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton4.CheckedChanged
        PaymentPayee = MaterialRadioButton4.Text
    End Sub

    Private Sub MaterialRadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton6.CheckedChanged
        PaymentPayee = MaterialRadioButton6.Text
    End Sub

    Private Sub MaterialRadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton9.CheckedChanged
        PaymentPayee = MaterialRadioButton9.Text
    End Sub

    Private Sub SelectPayee_Click(sender As Object, e As EventArgs) Handles SelectPayee.Click
        MaterialRadioButton1.Hide()
        MaterialRadioButton2.Hide()
        MaterialRadioButton3.Hide()
        MaterialRadioButton4.Hide()
        SelectPayee.Hide()
        MaterialRadioButton5.Hide()
        MaterialRadioButton6.Hide()
        MaterialRadioButton7.Hide()
        MaterialRadioButton8.Hide()
        MaterialRadioButton9.Hide()
        MaterialRadioButton10.Hide()
        MaterialRadioButton11.Hide()
        MaterialRadioButton12.Hide()
        MaterialRadioButton13.Hide()
        MaterialRadioButton14.Hide()
        MaterialRadioButton15.Hide()

        NextPage.Hide()
        Previous.Hide()
        PrintRecipt.Show()
        ReciptNo.Show()
        MaterialLabel2.Show()
        MaterialLabel2.Text = TransferAmount + " has been transfered to the payee, " + PaymentPayee + ""

    End Sub

    Private Sub PrintRecipt_Click(sender As Object, e As EventArgs) Handles PrintRecipt.Click
        MaterialLabel2.Hide()
        MaterialLabel1.Show()
        MaterialLabel1.Text = "You are now logged out."
        PrintRecipt.Hide()
        ReciptNo.Hide()
        TransferContinue.Show()
    End Sub

    Private Sub TransferContinue_Click(sender As Object, e As EventArgs) Handles TransferContinue.Click
        MaterialLabel1.Hide()
        TransferContinue.Hide()
        loadTransfer()
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub ReciptNo_Click(sender As Object, e As EventArgs) Handles ReciptNo.Click
        MaterialLabel1.Hide()
        PrintRecipt.Hide()
        ReciptNo.Hide()
        loadTransfer()
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub MaterialRadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton12.CheckedChanged
        PaymentPayee = MaterialRadioButton12.Text
    End Sub

    Private Sub MaterialRadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton13.CheckedChanged
        PaymentPayee = MaterialRadioButton13.Text
    End Sub

    Private Sub MaterialRadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton14.CheckedChanged
        PaymentPayee = MaterialRadioButton14.Text
    End Sub

    Private Sub MaterialRadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton15.CheckedChanged
        PaymentPayee = MaterialRadioButton15.Text
    End Sub

    Private Sub info_Click(sender As Object, e As EventArgs) Handles info.Click

        unloadKeys()
        PrintRecipt.Hide()
        ReciptNo.Hide()
        loadTransfer()
        Me.Hide()
        Help.Show()
    End Sub
End Class