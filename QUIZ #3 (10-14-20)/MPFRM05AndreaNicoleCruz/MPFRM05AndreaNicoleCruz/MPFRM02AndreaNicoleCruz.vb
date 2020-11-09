Public Class MPFRM02AndreaNicoleCruz

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim small, medium, large, softdrinks, fruitjuice, coffeechocolate, extracheese, mushrooms, blackolives, onions, greenpeppers, tomatoes, pizza, extratoppings, drinks, thick, total As Double
        small = 100.0
        medium = 150.0
        large = 200.0
        softdrinks = 20.0
        fruitjuice = 15.0
        coffeechocolate = 25.0
        extracheese = 10.0
        mushrooms = 10.0
        blackolives = 10.0
        onions = 10.0
        greenpeppers = 10.0
        tomatoes = 10.0
        thick = 0.5

        If RadioButton1.Checked = True Then
            pizza = small
            If RadioButton5.Checked = True Then
                pizza = small * thick
            End If
            TextBox1.Text = pizza
        ElseIf RadioButton2.Checked = True Then
            pizza = medium
            If RadioButton5.Checked = True Then
                pizza = medium * thick
            End If
            TextBox1.Text = pizza
        ElseIf RadioButton3.Checked Then
            pizza = large
            If RadioButton5.Checked = True Then
                pizza = large * thick
            End If
            TextBox1.Text = pizza

        End If

        If CheckBox1.Checked = True Then
            extratoppings += 10
            TextBox2.Text = extratoppings
        End If
        If CheckBox2.Checked = True Then
            extratoppings += 10
            TextBox2.Text = extratoppings
        End If
        If CheckBox3.Checked = True Then
            extratoppings += 10
            TextBox2.Text = extratoppings
        End If
        If CheckBox4.Checked = True Then
            extratoppings += 10
            TextBox2.Text = extratoppings
        End If
        If CheckBox5.Checked = True Then
            extratoppings += 10
            TextBox2.Text = extratoppings
        End If
        If CheckBox6.Checked = True Then
            extratoppings += 10
            TextBox2.Text = extratoppings
        End If

        If RadioButton6.Checked = True Then
            drinks = softdrinks
            TextBox3.Text = drinks
        ElseIf RadioButton7.Checked = True Then
            drinks = fruitjuice
            TextBox3.Text = drinks
        ElseIf RadioButton8.Checked = True Then
            drinks = coffeechocolate
            TextBox3.Text = drinks
        End If

        total = pizza + extratoppings + drinks
        TextBox4.Text = total



    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        RadioButton8.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""






    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim order As String
        order = ""
        If RadioButton1.Checked = True Then
            order = order + RadioButton1.Text + vbNewLine
        End If
        If RadioButton2.Checked = True Then
            order = order + RadioButton2.Text + vbNewLine
        End If
        If RadioButton3.Checked = True Then
            order = order + RadioButton3.Text + vbNewLine
        End If
        If RadioButton4.Checked = True Then
            order = order + RadioButton4.Text + vbNewLine
        End If
        If RadioButton5.Checked = True Then
            order = order + RadioButton5.Text + vbNewLine
        End If
        If RadioButton6.Checked = True Then
            order = order + RadioButton6.Text + vbNewLine
        End If
        If RadioButton7.Checked = True Then
            order = order + RadioButton7.Text + vbNewLine
        End If
        If RadioButton8.Checked = True Then
            order = order + RadioButton8.Text + vbNewLine
        End If
        If RadioButton9.Checked = True Then
            order = order + RadioButton9.Text + vbNewLine
        End If
        If RadioButton10.Checked = True Then
            order = order + RadioButton10.Text + vbNewLine
        End If
        If CheckBox2.Checked Then
            order = order + CheckBox2.Text + vbNewLine
        End If
        If CheckBox3.Checked Then
            order = order + CheckBox3.Text + vbNewLine
        End If
        If CheckBox4.Checked Then
            order = order + CheckBox4.Text + vbNewLine
        End If
        If CheckBox5.Checked Then
            order = order + CheckBox5.Text + vbNewLine
        End If
        If CheckBox6.Checked Then
            order = order + CheckBox6.Text + vbNewLine
        End If
        If CheckBox1.Checked Then
            order = order + CheckBox1.Text + vbNewLine
        End If
        MessageBox.Show("" + vbNewLine + order, "Your Pizza")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click
        Label4.Text = Today.ToLongDateString()
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        Label5.Text = TimeOfDay
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Close()
    End Sub
End Class
