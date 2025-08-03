Public Class frmEmpleado
    Private Sub EMPLEADO_SEGURIDADBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EMPLEADO_SEGURIDADBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SEGURIDAD_CIUDADANADataSet)

    End Sub

    Private Sub EMPLEADO_SEGURIDADBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles EMPLEADO_SEGURIDADBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EMPLEADO_SEGURIDADBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SEGURIDAD_CIUDADANADataSet)

    End Sub

    Private Sub frmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SEGURIDAD_CIUDADANADataSet.EMPLEADO_SEGURIDAD' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADO_SEGURIDADTableAdapter.Fill(Me.SEGURIDAD_CIUDADANADataSet.EMPLEADO_SEGURIDAD)

    End Sub
End Class