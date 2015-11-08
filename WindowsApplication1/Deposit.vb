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
End Class