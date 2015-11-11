Imports MaterialSkin

Public Class Balance
    Dim Savings As Integer
    Dim Checkings As Integer
    Public Function updateSavings(ByVal change As Integer) As Integer
        Savings = Savings + change
        Return 0
    End Function
    Public Function updateChecking(ByVal change2 As Integer) As Integer
        Checkings = Checkings + change2
        Return 0
    End Function
    Public Function getChecking() As Integer
        Return Checkings
    End Function
    Public Function getSaving() As Integer
        Return Savings
    End Function
    Private Sub Balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub
    Private Sub Balance_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Form1.Close()
    End Sub
    Private Sub TByEmailB_Click(sender As Object, e As EventArgs) Handles TByEmailB.Click
        If TByEmailB.Text = "Show Checkings Balance" Then
            MaterialLabel1.Visible = True
            MaterialLabel2.Text = " Your Total Checkings Blance: $" + CStr(Checkings)
            MaterialLabel2.Visible = True
            My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Windows Information Bar.wav")
            MaterialLabel5.Visible = True
            TByEmailB.Text = "Hide My Checkings Balances"
        Else
            My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Windows Information Bar.wav")
            MaterialLabel2.Visible = False
            MaterialLabel1.Visible = False
            TByEmailB.Text = "Show Checkings Balance"
        End If
    End Sub

    Private Sub MPaymentB_Click(sender As Object, e As EventArgs) Handles MPaymentB.Click
        If MPaymentB.Text = "Show Savings Balance" Then
            My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Windows Information Bar.wav")
            MaterialLabel3.Visible = True
            MaterialLabel3.Text = "Your Total Savings Blance: $" + CStr(Savings)
            MaterialLabel5.Visible = True
            MaterialLabel4.Visible = True
            MPaymentB.Text = "Hide My Savings Balances"
        Else
            My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Windows Information Bar.wav")
            MaterialLabel3.Visible = False
            MaterialLabel4.Visible = False
            MPaymentB.Text = "Show Savings Balance"
        End If
    End Sub

    Private Sub WithdrawReciptYes_Click(sender As Object, e As EventArgs) Handles WithdrawReciptYes.Click
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Speech Off.wav")
        Me.Hide()
        Form1.Show()
        MaterialLabel1.Visible = False
        MaterialLabel2.Visible = False
        MaterialLabel3.Visible = False
        MaterialLabel5.Visible = False
        MaterialLabel4.Visible = False
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        MsgBox("Printing Receipt")
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Print.wav")

    End Sub

    Private Sub Another_Click(sender As Object, e As EventArgs) Handles Another.Click
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Speech On.wav")
        Me.Hide()
        Form2.Show()
        MaterialLabel1.Visible = False
        MaterialLabel2.Visible = False
        MaterialLabel3.Visible = False
        MaterialLabel5.Visible = False
        MaterialLabel4.Visible = False
    End Sub

    Private Sub BackB_Click(sender As Object, e As EventArgs) Handles BackB.Click
        Me.Hide()
        Form2.Show()
        MaterialLabel1.Visible = False
        MaterialLabel2.Visible = False
        MaterialLabel3.Visible = False
        MaterialLabel5.Visible = False
        MaterialLabel4.Visible = False
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Hide()
        Form1.Show()
        MaterialLabel1.Visible = False
        MaterialLabel2.Visible = False
        MaterialLabel3.Visible = False
        MaterialLabel5.Visible = False
        MaterialLabel4.Visible = False
    End Sub

    Private Sub info_Click(sender As Object, e As EventArgs) Handles info.Click
        My.Computer.Audio.Play("C:\Users\Jeremy\Documents\Visual Studio 2015\Projects\4HC3A2\packages\Speech On.wav")
        Me.Hide()
        Help.Show()
        MaterialLabel1.Visible = False
        MaterialLabel2.Visible = False
        MaterialLabel3.Visible = False
        MaterialLabel5.Visible = False
        MaterialLabel4.Visible = False
    End Sub
End Class