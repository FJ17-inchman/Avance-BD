﻿Public Class Parroquia
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnEditarP.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KERMESSEDataSet.Parroquia' Puede moverla o quitarla según sea necesario.
        Me.ParroquiaTableAdapter.Fill(Me.KERMESSEDataSet.Parroquia)

    End Sub

    Private Sub txtSegP_Click(sender As Object, e As EventArgs) Handles txtSegP.Click

        Kermessevb.Show()

    End Sub
End Class
