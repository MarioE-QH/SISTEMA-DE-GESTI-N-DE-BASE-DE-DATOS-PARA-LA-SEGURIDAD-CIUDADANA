Public Class frmPrevencionDelito
    Private Sub PREVENCION_DELITOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PREVENCION_DELITOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PREVENCION_DELITOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SEGURIDAD_CIUDADANADataSet)

    End Sub

    Private Sub frmPrevencionDelito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SEGURIDAD_CIUDADANADataSet.PREVENCION_DELITO' Puede moverla o quitarla según sea necesario.
        Me.PREVENCION_DELITOTableAdapter.Fill(Me.SEGURIDAD_CIUDADANADataSet.PREVENCION_DELITO)

    End Sub
End Class