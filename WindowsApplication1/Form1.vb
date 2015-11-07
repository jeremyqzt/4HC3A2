Imports MaterialSkin

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub


    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles PassKey1.Click
        Call AddStar()
    End Sub

    Private Sub MaterialRaisedButton1_Click_1(sender As Object, e As EventArgs) Handles PassKey2.Click
        Call AddStar()
    End Sub
    Public Function AddStar() As Integer
        Dim current As String
        current = PassField.Text
        current = current + "   *"
        PassField.Text = current
        Return 0
    End Function

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles PassKey3.Click
        Call AddStar()

    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles PassKey4.Click
        Call AddStar()

    End Sub

    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles PassKey5.Click
        Call AddStar()

    End Sub

    Private Sub MaterialRaisedButton5_Click(sender As Object, e As EventArgs) Handles PassKey6.Click
        Call AddStar()

    End Sub

    Private Sub MaterialRaisedButton6_Click(sender As Object, e As EventArgs) Handles PassKey7.Click
        Call AddStar()

    End Sub

    Private Sub MaterialRaisedButton7_Click(sender As Object, e As EventArgs) Handles PassKey8.Click
        Call AddStar()

    End Sub

    Private Sub MaterialRaisedButton8_Click(sender As Object, e As EventArgs) Handles PassKey9.Click
        Call AddStar()

    End Sub

    Private Sub MaterialRaisedButton10_Click(sender As Object, e As EventArgs) Handles PassKeyCor.Click
        Dim Removed As String
        Dim Amount As Integer
        Removed = PassField.Text
        Amount = Removed.Length
        If Amount > 3 Then
            PassField.Text = Removed.Substring(0, Amount - 4)
        Else

        End If

    End Sub

    Private Sub ToMain_Click(ByVal sender As Object, e As EventArgs) Handles ToMain.Click
        ToMain.Hide()
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
        PassKeyCor.Show()
        MaterialLabel1.Show()
        PassKeyEnter.Show()
        Cancel.Show()
        Me.Text = "Welcome User"
    End Sub


    Private Sub PassKeyEnter_Click(sender As Object, e As EventArgs) Handles PassKeyEnter.Click
        Me.Visible = False
        objForm2.ShowDialog()
    End Sub
    Private Sub PassField_Click(sender As Object, e As EventArgs) Handles PassField.Click

    End Sub
    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs) Handles MaterialLabel1.Click

    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click

    End Sub
End Class