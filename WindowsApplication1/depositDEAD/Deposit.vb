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

    Private Function DepositReset() As Integer
        cheque.Show()
        cash.Show()
        cheque.Text = "$"
        cash.Text = "$"
        MaterialRadioButton1.Show()
        MaterialRadioButton2.Show()
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
        PassKeyCor.Show()
        PassKeyEnter.Show()
        DepositLabel.Hide()
        DepositFinish.Hide()
        Return 0
    End Function

    Private Function DepositUnload() As Integer
        cheque.Hide()
        cash.Hide()
        MaterialRadioButton1.Hide()
        MaterialRadioButton2.Hide()
        PassKey1.Hide()
        PassKey2.Hide()
        cheque.Text = ""
        cash.Text = ""
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
        DepositFinish.Hide()
        DepositLabel.Hide()
        Return 0
    End Function

    Private Sub PassKey1_Click(sender As Object, e As EventArgs)
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

    Private Sub MaterialRadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        If MaterialRadioButton1.Checked = True Then
            MaterialRadioButton2.Checked = False
            focus = "Cheque"
            cash.Text = ""

        End If
    End Sub

    Private Sub MaterialRadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        If MaterialRadioButton2.Checked = True Then
            MaterialRadioButton1.Checked = False
            focus = "Cash"
            cheque.Text = ""
        End If
    End Sub

    Private Sub PassKey2_Click(sender As Object, e As EventArgs)
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

    Private Sub PassKey3_Click(sender As Object, e As EventArgs)
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

    Private Sub PassKey4_Click(sender As Object, e As EventArgs)
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

    Private Sub PassKey5_Click(sender As Object, e As EventArgs)
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

    Private Sub PassKey6_Click(sender As Object, e As EventArgs)
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

    Private Sub PassKey7_Click(sender As Object, e As EventArgs)
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

    Private Sub PassKey8_Click(sender As Object, e As EventArgs)
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

    Private Sub PassKey9_Click(sender As Object, e As EventArgs)
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

    Private Sub PassKey0_Click(sender As Object, e As EventArgs)
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

    Private Sub PassKeyCor_Click(sender As Object, e As EventArgs)
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


    Private Sub BackB_Click(sender As Object, e As EventArgs)
        DepositReset()
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs)
        DepositUnload()
        DepositLabel.Visible = True
        DepositLabel.Text = ("You are now logged out.")
        DepositFinish.Visible = True
    End Sub

    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs) Handles DepositLabel.Click

    End Sub

    Private Sub DepositFinish_Click(sender As Object, e As EventArgs)
        DepositReset()
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub PassKeyEnter_Click(sender As Object, e As EventArgs)

        If (cash.Text = "$") And Not (cheque.Text = "$") Then
            DepositUnload()
            DepositLabel.Visible = True
            DepositLabel.Text = ("Please insert an envelope with the amount inside. Selected amount: $" + cheque.Text)

        ElseIf (cheque.Text = "$") And Not (cash.Text = "$") Then
            DepositUnload()
            DepositLabel.Visible = True
            DepositLabel.Text = ("Please insert an envelope with the amount inside. Selected amount: $" + cash.Text)

        Else
            MsgBox("Please select an amount to deposit.")
        End If

    End Sub



    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Deposit
        '
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.Name = "Deposit"
        Me.ResumeLayout(False)

    End Sub

    Private Sub Deposit_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class