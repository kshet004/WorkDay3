﻿Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click

        Dim num1, num2 As Double

        If Not (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text)) Then
            MessageBox.Show("error: please type a number!", "error")
            Return
        End If

        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)

        If (num1 < 0 Or num2 < 0) Then
            MessageBox.Show("Error: please type a POSITIVE number!", "error")
            Return
        End If
        If num1 > num2 Then
            txtResult.Text = "Larger Number is " & num1
        ElseIf (num2 > num1) Then
            txtResult.Text = "Larger Number is " & num2
        Else
            txtResult.Text = "The two are equal."
        End If






    End Sub

End Class
