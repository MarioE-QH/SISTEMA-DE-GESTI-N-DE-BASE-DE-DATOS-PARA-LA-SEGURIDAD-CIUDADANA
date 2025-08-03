Public Class frmVistaSerenazgo
    Private Sub frmVistaSerenazgo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SEGURIDAD_CIUDADANADataSet.V_SERENAZGO_SE' Puede moverla o quitarla según sea necesario.
        Me.V_SERENAZGO_SETableAdapter.Fill(Me.SEGURIDAD_CIUDADANADataSet.V_SERENAZGO_SE)

    End Sub

    Private Sub V_SERENAZGO_SEDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles V_SERENAZGO_SEDataGridView.CellContentClick

    End Sub
End Class