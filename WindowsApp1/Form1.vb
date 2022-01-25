Public Class Form1

    Private Const KM2MI = 1.609
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'proovime teisendada
            'txtMI.Text = txtKM.Text / KM2MI
            txtMI.Text = teisenda(txtKM.Text)
        Catch ex As Exception
            'vea korral tekkib see asi
            MsgBox("Viga sisendis!")
        End Try

    End Sub

    Function teisenda(ByVal km As Double) As Double
        Return km / KM2MI
    End Function

End Class
