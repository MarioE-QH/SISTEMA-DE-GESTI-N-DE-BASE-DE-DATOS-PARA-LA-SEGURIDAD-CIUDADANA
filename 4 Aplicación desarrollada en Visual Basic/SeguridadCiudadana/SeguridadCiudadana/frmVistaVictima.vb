Public Class frmVistaVictima
    Private Sub frmVistaVictima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SEGURIDAD_CIUDADANADataSet.V_VICTIMAS_MUJERES' Puede moverla o quitarla según sea necesario.
        Me.V_VICTIMAS_MUJERESTableAdapter.Fill(Me.SEGURIDAD_CIUDADANADataSet.V_VICTIMAS_MUJERES)
        'TODO: esta línea de código carga datos en la tabla 'SEGURIDAD_CIUDADANADataSet.V_VICTIMAS' Puede moverla o quitarla según sea necesario.
        'Me.V_VICTIMASTableAdapter.Fill(Me.SEGURIDAD_CIUDADANADataSet.V_VICTIMAS_MUJERES)

    End Sub
End Class