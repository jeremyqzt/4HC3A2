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

    Private Sub MaterialRaisedButton1_Click_1(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Call AddStar()
    End Sub
    Public Function AddStar() As Integer
        Dim current As String
        current = PassField.Text
        current = current + "   *"
        PassField.Text = current
        Return 0
    End Function

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Call AddStar()

    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        Call AddStar()

    End Sub

    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton4.Click
        Call AddStar()

    End Sub

    Private Sub MaterialRaisedButton5_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton5.Click
        Call AddStar()

    End Sub

    Private Sub MaterialRaisedButton6_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton6.Click
        Call AddStar()

    End Sub

    Private Sub MaterialRaisedButton7_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton7.Click
        Call AddStar()

    End Sub

    Private Sub MaterialRaisedButton8_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton8.Click
        Call AddStar()

    End Sub

    Private Sub MaterialRaisedButton10_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton10.Click
        Dim Removed As String
        Dim Amount As Integer
        Removed = PassField.Text
        Amount = Removed.Length
        If Amount > 3 Then
            PassField.Text = Removed.Substring(0, Amount - 4)
        Else

        End If
    End Sub
End Class