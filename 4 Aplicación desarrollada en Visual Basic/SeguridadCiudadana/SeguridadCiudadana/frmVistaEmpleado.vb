Public Class frmVistaEmpleado
    Private Sub frmVistaEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SEGURIDAD_CIUDADANADataSet.V_EMPLEADOS' Puede moverla o quitarla según sea necesario.
        Me.V_EMPLEADOSTableAdapter.Fill(Me.SEGURIDAD_CIUDADANADataSet.V_EMPLEADOS)

    End Sub
End Class