Public Class frmAtencionVictima
    Private Sub ATENCION_VICTIMASBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ATENCION_VICTIMASBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ATENCION_VICTIMASBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SEGURIDAD_CIUDADANADataSet)

    End Sub

    Private Sub frmAtencionVictima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SEGURIDAD_CIUDADANADataSet.ATENCION_VICTIMAS' Puede moverla o quitarla según sea necesario.
        Me.ATENCION_VICTIMASTableAdapter.Fill(Me.SEGURIDAD_CIUDADANADataSet.ATENCION_VICTIMAS)

    End Sub
End Class