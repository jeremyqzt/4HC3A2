Imports MaterialSkin

Public Class Deposit
    Dim focus As String
    Private Sub Deposit_Load(sender As Object, e As EventArgs)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        focus = "Cash"
    End Sub

    Private Sub PassKey1_Click(sender As Object, e As EventArgs) Handles PassKey1.Click
        Dim field As String
        If focus = "Cash" Then
            field = cash.Text + "1"
            cash.Text = field
            cash.Focus()

        ElseIf focus = "Cheque" Then
            field = cheque.Text + "1"
            cheque.Text = field
            cheque.Focus()
        Else
            MsgBox("Please Select Cash or Cheque Deposit")
        End If
    End Sub

    Private Sub MaterialRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton1.CheckedChanged
        If MaterialRadioButton1.Checked = True Then
            MaterialRadioButton2.Checked = False
            focus = "Cheque"

        End If
    End Sub

    Private Sub MaterialRadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton2.CheckedChanged
        If MaterialRadioButton2.Checked = True Then
            MaterialRadioButton1.Checked = False
            focus = "Cash"

        End If
    End Sub

    Private Sub PassKey2_Click(sender As Object, e As EventArgs) Handles PassKey2.Click
        Dim field As String
        If focus = "Cash" Then
            field = cash.Text + "2"
            cash.Text = field
            cash.Focus()

        ElseIf focus = "Cheque" Then
            field = cheque.Text + "2"
            cheque.Text = field
            cheque.Focus()
        Else
            MsgBox("Please Select Cash or Cheque Deposit")
        End If
    End Sub

    Private Sub PassKey3_Click(sender As Object, e As EventArgs) Handles PassKey3.Click
        Dim field As String
        If focus = "Cash" Then
            field = cash.Text + "3"
            cash.Text = field
            cash.Focus()

        ElseIf focus = "Cheque" Then
            field = cheque.Text + "3"
            cheque.Text = field
            cheque.Focus()
        Else
            MsgBox("Please Select Cash or Cheque Deposit")
        End If
    End Sub

    Private Sub PassKey4_Click(sender As Object, e As EventArgs) Handles PassKey4.Click
        Dim field As String
        If focus = "Cash" Then
            field = cash.Text + "4"
            cash.Text = field
            cash.Focus()

        ElseIf focus = "Cheque" Then
            field = cheque.Text + "4"
            cheque.Text = field
            cheque.Focus()
        Else
            MsgBox("Please Select Cash or Cheque Deposit")
        End If
    End Sub

    Private Sub PassKey5_Click(sender As Object, e As EventArgs) Handles PassKey5.Click
        Dim field As String
        If focus = "Cash" Then
            field = cash.Text + "5"
            cash.Text = field
            cash.Focus()

        ElseIf focus = "Cheque" Then
            field = cheque.Text + "5"
            cheque.Text = field
            cheque.Focus()
        Else
            MsgBox("Please Select Cash or Cheque Deposit")
        End If
    End Sub

    Private Sub PassKey6_Click(sender As Object, e As EventArgs) Handles PassKey6.Click
        Dim field As String
        If focus = "Cash" Then
            field = cash.Text + "6"
            cash.Text = field
            cash.Focus()

        ElseIf focus = "Cheque" Then
            field = cheque.Text + "6"
            cheque.Text = field
            cheque.Focus()
        Else
            MsgBox("Please Select Cash or Cheque Deposit")
        End If
    End Sub

    Private Sub PassKey7_Click(sender As Object, e As EventArgs) Handles PassKey7.Click
        Dim field As String
        If focus = "Cash" Then
            field = cash.Text + "7"
            cash.Text = field
            cash.Focus()

        ElseIf focus = "Cheque" Then
            field = cheque.Text + "7"
            cheque.Text = field
            cheque.Focus()
        Else
            MsgBox("Please Select Cash or Cheque Deposit")
        End If
    End Sub

    Private Sub PassKey8_Click(sender As Object, e As EventArgs) Handles PassKey8.Click
        Dim field As String
        If focus = "Cash" Then
            field = cash.Text + "8"
            cash.Text = field
            cash.Focus()

        ElseIf focus = "Cheque" Then
            field = cheque.Text + "8"
            cheque.Text = field
            cheque.Focus()
        Else
            MsgBox("Please Select Cash or Cheque Deposit")
        End If
    End Sub

    Private Sub PassKey9_Click(sender As Object, e As EventArgs) Handles PassKey9.Click
        Dim field As String
        If focus = "Cash" Then
            field = cash.Text + "9"
            cash.Text = field
            cash.Focus()

        ElseIf focus = "Cheque" Then
            field = cheque.Text + "9"
            cheque.Text = field
            cheque.Focus()
        Else
            MsgBox("Please Select Cash or Cheque Deposit")
        End If
    End Sub

    Private Sub PassKey0_Click(sender As Object, e As EventArgs) Handles PassKey0.Click
        Dim field As String
        If focus = "Cash" Then
            field = cash.Text + "0"
            cash.Text = field
            cash.Focus()

        ElseIf focus = "Cheque" Then
            field = cheque.Text + "0"
            cheque.Text = field
            cheque.Focus()
        Else
            MsgBox("Please Select Cash or Cheque Deposit")
        End If
    End Sub

    Private Sub PassKeyCor_Click(sender As Object, e As EventArgs) Handles PassKeyCor.Click
        Dim field As String
        Dim amount As Integer
        If focus = "Cash" Then
            field = cash.Text
            amount = field.Length
            If amount > 1 Then
                cash.Text = field.Substring(0, amount - 1)
            End If
        ElseIf focus = "Cheque" Then
            field = cheque.Text
            amount = field.Length
            If amount > 1 Then
                cheque.Text = field.Substring(0, amount - 1)
            End If
        Else
                MsgBox("Please Select Cash or Cheque Deposit")
        End If
    End Sub

    Private Sub PassKeyEnter_Click(sender As Object, e As EventArgs) Handles PassKeyEnter.Click
        Dim Total As Integer
        If cash.Text.Length > 1 Then
            Total = CInt((cash.Text.Substring(0, cash.Text.Length)))
        End If
        If cheque.Text.Length > 1 Then
            Total = Total + CInt(cheque.Text.Substring(0, cheque.Text.Length))
        End If
        If Total > 0 Then
            MaterialSingleLineTextField1.Text = "Please Confirm Total Deposit: $" + CType(Total, String)
            PassKey0.Visible = False
            PassKey1.Visible = False
            PassKey2.Visible = False
            PassKey3.Visible = False
            PassKey4.Visible = False
            PassKey5.Visible = False
            PassKey6.Visible = False
            PassKey7.Visible = False
            PassKey8.Visible = False
            PassKey9.Visible = False
            PassKeyEnter.Visible = False
            MaterialRadioButton1.Visible = False
            MaterialRadioButton2.Visible = False
            PassKeyCor.Visible = False
            cash.Visible = False
            cheque.Visible = False
            WithdrawReciptYes.Visible = True
            WithdrawReciptNo.Visible = True
        Else
            MsgBox("Please Deposit More Than $0!")
        End If
    End Sub

    Private Sub WithdrawReciptYes_Click(sender As Object, e As EventArgs) Handles WithdrawReciptYes.Click
        If WithdrawReciptYes.Text = "YES" Then
            WithdrawReciptYes.Text = "Press Here to Finish"
            WithdrawReciptNo.Visible = False
            Another.Visible = True
            MaterialSingleLineTextField1.Text = "Your Deposit Has Been Completed"
        Else
            PassKey0.Visible = True
            PassKey1.Visible = True
            PassKey2.Visible = True
            PassKey3.Visible = True
            PassKey4.Visible = True
            PassKey5.Visible = True
            PassKey6.Visible = True
            PassKey7.Visible = True
            PassKey8.Visible = True
            PassKey9.Visible = True
            PassKeyEnter.Visible = True
            MaterialRadioButton1.Visible = True
            MaterialRadioButton2.Visible = True
            PassKeyCor.Visible = True
            cash.Visible = True
            cheque.Visible = True
            WithdrawReciptYes.Visible = False
            WithdrawReciptNo.Visible = False
            MaterialRadioButton1.Checked = True
            MaterialRadioButton2.Checked = False
            MaterialSingleLineTextField1.Text = "Please Enter The Amounts You Wish To Deposit "
            cheque.Text = "$"
            cash.Text = "$"
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub WithdrawReciptNo_Click(sender As Object, e As EventArgs) Handles WithdrawReciptNo.Click
        PassKey0.Visible = True
        PassKey1.Visible = True
        PassKey2.Visible = True
        PassKey3.Visible = True
        PassKey4.Visible = True
        PassKey5.Visible = True
        PassKey6.Visible = True
        PassKey7.Visible = True
        PassKey8.Visible = True
        PassKey9.Visible = True
        PassKeyEnter.Visible = True
        MaterialRadioButton1.Visible = True
        MaterialRadioButton2.Visible = True
        PassKeyCor.Visible = True
        cash.Visible = True
        cheque.Visible = True
        WithdrawReciptYes.Visible = False
        WithdrawReciptNo.Visible = False
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        PassKey0.Visible = True
        PassKey1.Visible = True
        PassKey2.Visible = True
        PassKey3.Visible = True
        PassKey4.Visible = True
        PassKey5.Visible = True
        PassKey6.Visible = True
        PassKey7.Visible = True
        PassKey8.Visible = True
        PassKey9.Visible = True
        PassKeyEnter.Visible = True
        MaterialRadioButton1.Visible = True
        MaterialRadioButton2.Visible = True
        PassKeyCor.Visible = True
        cash.Visible = True
        Another.Visible = False
        cheque.Visible = True
        WithdrawReciptYes.Visible = False
        WithdrawReciptNo.Visible = False
        MaterialRadioButton1.Checked = False
        MaterialRadioButton2.Checked = False
        MaterialSingleLineTextField1.Text = "Please Enter The Amounts You Wish To Deposit "
        cheque.Text = "$"
        cash.Text = "$"
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub BackB_Click(sender As Object, e As EventArgs) Handles BackB.Click
        Another.Visible = False
        PassKey0.Visible = True
        PassKey1.Visible = True
        PassKey2.Visible = True
        PassKey3.Visible = True
        PassKey4.Visible = True
        PassKey5.Visible = True
        PassKey6.Visible = True
        PassKey7.Visible = True
        PassKey8.Visible = True
        PassKey9.Visible = True
        PassKeyEnter.Visible = True
        MaterialRadioButton1.Visible = True
        MaterialRadioButton2.Visible = True
        PassKeyCor.Visible = True
        cash.Visible = True
        cheque.Visible = True
        WithdrawReciptYes.Visible = False
        WithdrawReciptNo.Visible = False
        MaterialRadioButton1.Enabled = True
        MaterialSingleLineTextField1.Text = "Please Enter The Amounts You Wish To Deposit "
        cheque.Text = "$"
        cash.Text = "$"
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Another_Click(sender As Object, e As EventArgs) Handles Another.Click
        Another.Visible = False
        PassKey0.Visible = True
        PassKey1.Visible = True
        PassKey2.Visible = True
        PassKey3.Visible = True
        PassKey4.Visible = True
        PassKey5.Visible = True
        PassKey6.Visible = True
        PassKey7.Visible = True
        PassKey8.Visible = True
        PassKey9.Visible = True
        PassKeyEnter.Visible = True
        MaterialRadioButton1.Visible = True
        MaterialRadioButton2.Visible = True
        PassKeyCor.Visible = True
        cash.Visible = True
        cheque.Visible = True
        WithdrawReciptYes.Visible = False
        WithdrawReciptNo.Visible = False
        MaterialRadioButton1.Checked = True
        MaterialRadioButton2.Checked = False
        MaterialSingleLineTextField1.Text = "Please Enter The Amounts You Wish To Deposit "
        cheque.Text = "$"
        cash.Text = "$"
        Me.Hide()
        Form2.Show()
    End Sub
End Class