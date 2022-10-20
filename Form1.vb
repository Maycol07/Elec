Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CALCULAR.Click
        Dim edad As Integer = Val(TextEdad.Text)
        Dim nombre As String = txtNombre.Text
        Dim numVotacion As Integer
        Dim vote As Integer = edad - 14
        Do While (vote >= 4)
            vote = vote - 4
            numVotacion = numVotacion + 1
        Loop


        If edad < 18 Then
            MessageBox.Show("No haz realizado ninguna eleccion")

        Else
            MessageBox.Show(nombre & " Tienes  " & edad &
                    " haz participado en " & numVotacion & " elelciones")

        End If


    End Sub

    Private Function Int() As Object
        Throw New NotImplementedException()
    End Function
End Class
