Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblOutput.Text = ""
        lblOutput.Anchor = AnchorStyles.None
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Text = ""
        lblOutput.Text = ""

        rbInchesToMeters.Checked = True
        txtInput.Focus()

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim inputValue As Double

        If Not Double.TryParse(txtInput.Text, inputValue) Then

            MsgBox("Please enter a valid number.", MsgBoxStyle.Exclamation, "Error")
            txtInput.Focus()
            Return
        End If

        If inputValue <= 0 Then

            MsgBox("Please enter a positive number.", MsgBoxStyle.Exclamation, "Error")
            txtInput.Focus()
            Return
        End If

        Dim convertedValue As Double

        If rbInchesToMeters.Checked Then
            convertedValue = inputValue * 0.0254
        Else
            convertedValue = inputValue / 0.0254
        End If

        If convertedValue < 0 Then
            MsgBox("The converted value cannot be negative.", MsgBoxStyle.Exclamation, "Error")
            Return
        End If

        lblOutput.Text = convertedValue.ToString("F2") & Space(2) & "inches."
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
