Public Class Form1
    Dim UserOption As Integer
    Dim ComputerOption As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UserOption = 1
        Randomize()
        ComputerOption = CInt(Int((3 * Rnd()) + 1))
        If ComputerOption = 1 And UserOption = 1 Then
            Label2.Visible = True
            Label3.Visible = True
            Label3.Text = "Your option: Rock|" & "Computer option: Rock"
            Label2.Text = "Nobody did win!"
        ElseIf ComputerOption = 1 And UserOption = 2 Then
            Label2.Visible = True
            Label2.Text = "You win!"
            Label3.Visible = True
            Label3.Text = "Your option: Paper|" & "Computer option: Rock"
        ElseIf ComputerOption = 1 And UserOption = 3 Then
            Label2.Visible = True
            Label2.Text = "Computer winned!"
            Label3.Visible = True
            Label3.Text = "Your option: Scissors|" & "Computer option: Rock"
        ElseIf ComputerOption = 2 And UserOption = 1 Then
            Label2.Visible = True
            Label2.Text = "Computer winned!"
            Label3.Visible = True
            Label3.Text = "Your option: Rock|" & "Computer option: Paper"
        ElseIf ComputerOption = 2 And UserOption = 2 Then
            Label2.Visible = True
            Label2.Text = "Nobody did win!"
            Label3.Visible = True
            Label3.Text = "Your option: Paper|" & "Computer option: Paper"
        ElseIf ComputerOption = 2 And UserOption = 3 Then
            Label2.Visible = True
            Label2.Text = "You win!"
            Label3.Visible = True
            Label3.Text = "Your option: Scissors|" & "Computer option: Paper"
        ElseIf ComputerOption = 3 And UserOption = 1 Then
            Label2.Visible = True
            Label2.Text = "You win!"
            Label3.Visible = True
            Label3.Text = "Your option: Rock|" & "Computer option: Scissors"
        ElseIf ComputerOption = 3 And UserOption = 2 Then
            Label2.Visible = True
            Label2.Text = "Computer winned!"
            Label3.Visible = True
            Label3.Text = "Your option: Paper|" & "Computer option: Scissors"
        ElseIf ComputerOption = 3 And UserOption = 3 Then
            Label2.Visible = True
            Label2.Text = "Nobody did win!"
            Label3.Visible = True
            Label3.Text = "Your option: Scissors|" & "Computer option: Scissors"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        UserOption = 2
        Randomize()
        ComputerOption = CInt(Int((3 * Rnd()) + 1))
        If ComputerOption = 1 And UserOption = 1 Then
            Label2.Visible = True
            Label3.Visible = True
            Label3.Text = "Your option: Rock|" & "Computer option: Rock"
            Label2.Text = "Nobody did win!"
        ElseIf ComputerOption = 1 And UserOption = 2 Then
            Label2.Visible = True
            Label2.Text = "You win!"
            Label3.Visible = True
            Label3.Text = "Your option: Paper|" & "Computer option: Rock"
        ElseIf ComputerOption = 1 And UserOption = 3 Then
            Label2.Visible = True
            Label2.Text = "Computer winned!"
            Label3.Visible = True
            Label3.Text = "Your option: Scissors|" & "Computer option: Rock"
        ElseIf ComputerOption = 2 And UserOption = 1 Then
            Label2.Visible = True
            Label2.Text = "Computer winned!"
            Label3.Visible = True
            Label3.Text = "Your option: Rock|" & "Computer option: Paper"
        ElseIf ComputerOption = 2 And UserOption = 2 Then
            Label2.Visible = True
            Label2.Text = "Nobody did win!"
            Label3.Visible = True
            Label3.Text = "Your option: Paper|" & "Computer option: Paper"
        ElseIf ComputerOption = 2 And UserOption = 3 Then
            Label2.Visible = True
            Label2.Text = "You win!"
            Label3.Visible = True
            Label3.Text = "Your option: Scissors|" & "Computer option: Paper"
        ElseIf ComputerOption = 3 And UserOption = 1 Then
            Label2.Visible = True
            Label2.Text = "You win!"
            Label3.Visible = True
            Label3.Text = "Your option: Rock|" & "Computer option: Scissors"
        ElseIf ComputerOption = 3 And UserOption = 2 Then
            Label2.Visible = True
            Label2.Text = "Computer winned!"
            Label3.Visible = True
            Label3.Text = "Your option: Paper|" & "Computer option: Scissors"
        ElseIf ComputerOption = 3 And UserOption = 3 Then
            Label2.Visible = True
            Label2.Text = "Nobody did win!"
            Label3.Visible = True
            Label3.Text = "Your option: Scissors|" & "Computer option: Scissors"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        UserOption = 3
        Randomize()
        ComputerOption = CInt(Int((3 * Rnd()) + 1))
        If ComputerOption = 1 And UserOption = 1 Then
            Label2.Visible = True
            Label3.Visible = True
            Label3.Text = "Your option: Rock|" & "Computer option: Rock"
            Label2.Text = "Nobody did win!"
        ElseIf ComputerOption = 1 And UserOption = 2 Then
            Label2.Visible = True
            Label2.Text = "You win!"
            Label3.Visible = True
            Label3.Text = "Your option: Paper|" & "Computer option: Rock"
        ElseIf ComputerOption = 1 And UserOption = 3 Then
            Label2.Visible = True
            Label2.Text = "Computer winned!"
            Label3.Visible = True
            Label3.Text = "Your option: Scissors|" & "Computer option: Rock"
        ElseIf ComputerOption = 2 And UserOption = 1 Then
            Label2.Visible = True
            Label2.Text = "Computer winned!"
            Label3.Visible = True
            Label3.Text = "Your option: Rock|" & "Computer option: Paper"
        ElseIf ComputerOption = 2 And UserOption = 2 Then
            Label2.Visible = True
            Label2.Text = "Nobody did win!"
            Label3.Visible = True
            Label3.Text = "Your option: Paper|" & "Computer option: Paper"
        ElseIf ComputerOption = 2 And UserOption = 3 Then
            Label2.Visible = True
            Label2.Text = "You win!"
            Label3.Visible = True
            Label3.Text = "Your option: Scissors|" & "Computer option: Paper"
        ElseIf ComputerOption = 3 And UserOption = 1 Then
            Label2.Visible = True
            Label2.Text = "You win!"
            Label3.Visible = True
            Label3.Text = "Your option: Rock|" & "Computer option: Scissors"
        ElseIf ComputerOption = 3 And UserOption = 2 Then
            Label2.Visible = True
            Label2.Text = "Computer winned!"
            Label3.Visible = True
            Label3.Text = "Your option: Paper|" & "Computer option: Scissors"
        ElseIf ComputerOption = 3 And UserOption = 3 Then
            Label2.Visible = True
            Label2.Text = "Nobody did win!"
            Label3.Visible = True
            Label3.Text = "Your option: Scissors|" & "Computer option: Scissors"
        End If
    End Sub
End Class
