Public Class MPFRM01AndreaNicoleCruz

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        NumericUpDown1.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sss, val As Integer
        Dim civil As Double
        Dim Tax As Double

        If ComboBox2.Text = "A" Then
            TextBox2.Text = (500 * NumericUpDown1.Value)
        ElseIf ComboBox2.Text = "B" Then
            TextBox2.Text = (400 * NumericUpDown1.Value)
        ElseIf ComboBox2.Text = "C" Then
            TextBox2.Text = (300 * NumericUpDown1.Value)
        End If


        val = TextBox2.Text


        If val >= 10000 Then
            sss = (val * 0.07)
            TextBox3.Text = sss
        End If
        If (val >= 5000) And (val <= 9000) Then
            sss = (val * 0.05)
            TextBox3.Text = sss
        End If
        If (val >= 1000) And (val <= 4999) Then
            sss = (val * 0.03)
            TextBox3.Text = sss
        End If
        If val <= 1000 Then
            sss = (val * 0.01)
            TextBox3.Text = sss
        End If


        If RadioButton1.Checked Then
            civil = 0.1
        ElseIf RadioButton2.Checked Then
            civil = 0.05
        ElseIf RadioButton3.Checked Then
            civil = 0.05
        End If



        Tax = val * civil
        TextBox4.Text = Tax
        TextBox5.Text = val - Tax - sss




    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = 1 Then
            TextBox1.Text = "Nanon Korapat"
        ElseIf ComboBox1.SelectedItem = 2 Then
            TextBox1.Text = "Ohm Pawat"
        ElseIf ComboBox1.SelectedItem = 3 Then
            TextBox1.Text = "Chimon Wachiwarit"
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Close()

    End Sub
End Class
