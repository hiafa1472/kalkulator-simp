Public Class Form1
    Dim op, fn As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & 1
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & 2
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & 3
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & 4
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & 5
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & 6
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & 7
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & 8
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & 9
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & 0
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs)
        If TextBox1.Text = "" Then
            TextBox1.Text = "-"
        Else
            TextBox1.Text = "-" TextBox1.Text
        End If
    End Sub
    Private Sub Buttontambah_Click(sender As Object, e As EventArgs)
        op = 1
        fn = TextBox1.Text
        TextBox1.Text = ""
    End Sub
    Private Sub Buttonkurang_Click(sender As Object, e As EventArgs)
        op = 2
        fn = TextBox1.Text
        TextBox1.Text = ""
    End Sub
    Private Sub Buttonkali_Click(sender As Object, e As EventArgs)
        op = 3
        fn = TextBox1.Text
        TextBox1.Text = ""
    End Sub

    Private Sub Buttonbagi_Click(sender As Object, e As EventArgs)
        op = 4
        fn = TextBox1.Text
        TextBox1.Text = ""
    End Sub

    Private Sub Buttonkuadrat_Click(sender As Object, e As EventArgs)
        op = 5
        fn = TextBox1.Text
        TextBox1.Text = ""
    End Sub

    Private Sub Buttonsqrt_Click(sender As Object, e As EventArgs)
        op = 6
        fn = TextBox1.Text
        TextBox1.Text = ""
    End Sub

    Private Sub Buttonclear_Click(sender As Object, e As EventArgs)
        TextBox1.Text = ""
    End Sub

    Private Sub Buttonequals_Click(sender As Object, e As EventArgs)
        If op = 1 Then
            TextBox1.Text = Val(fn) + Val(TextBox1.Text)
        ElseIf op = 2 Then
            TextBox1.Text = Val(fn) - Val(TextBox1.Text)
        ElseIf op = 3 Then
            TextBox1.Text = Val(fn) * Val(TextBox1.Text)
        ElseIf op = 4 Then
            TextBox1.Text = Val(fn) / Val(TextBox1.Text)
        ElseIf op = 5 Then
            TextBox1.Text = Val(fn) ^ Val(TextBox1.Text)
        ElseIf op = 6 Then
            TextBox1.Text = Math.Sqrt(Val(TextBox1.Text))
        End If
        If TextBox1.Text = Val(TextBox1.Text) Then
            op = True
        End If
    End Sub
End Class
