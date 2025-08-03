Public Class frmPatrulla
    Private Sub VEHICULOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VEHICULOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SEGURIDAD_CIUDADANADataSet)

    End Sub

    Private Sub VEHICULOSBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles VEHICULOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VEHICULOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SEGURIDAD_CIUDADANADataSet)

    End Sub

    Private Sub frmPatrulla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SEGURIDAD_CIUDADANADataSet.VEHICULOS' Puede moverla o quitarla según sea necesario.
        Me.VEHICULOSTableAdapter.Fill(Me.SEGURIDAD_CIUDADANADataSet.VEHICULOS)

    End Sub
End Class