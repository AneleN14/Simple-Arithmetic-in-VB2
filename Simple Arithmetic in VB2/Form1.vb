﻿Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' ListBox1.Items.Add("Redmi")

        Dim myitem

        myitem = InputBox("enter your fav phone ")
        ListBox1.Items.Add(mytime)

    End Sub
End Class
