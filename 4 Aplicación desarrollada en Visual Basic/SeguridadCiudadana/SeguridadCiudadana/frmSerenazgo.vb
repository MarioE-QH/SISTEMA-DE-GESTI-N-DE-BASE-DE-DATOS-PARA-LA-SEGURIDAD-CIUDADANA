Public Class frmSerenazgo
    Private Sub SERENAZGOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SERENAZGOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SERENAZGOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SEGURIDAD_CIUDADANADataSet)

    End Sub

    Private Sub frmSerenazgo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SEGURIDAD_CIUDADANADataSet.SERENAZGO' Puede moverla o quitarla según sea necesario.
        Me.SERENAZGOTableAdapter.Fill(Me.SEGURIDAD_CIUDADANADataSet.SERENAZGO)

    End Sub
End Class