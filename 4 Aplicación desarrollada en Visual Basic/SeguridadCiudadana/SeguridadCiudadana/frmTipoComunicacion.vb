Public Class frmTipoComunicacion
    Private Sub TIPO_COMUNICACIONBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TIPO_COMUNICACIONBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TIPO_COMUNICACIONBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SEGURIDAD_CIUDADANADataSet)

    End Sub

    Private Sub frmTipoComunicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SEGURIDAD_CIUDADANADataSet.TIPO_COMUNICACION' Puede moverla o quitarla según sea necesario.
        Me.TIPO_COMUNICACIONTableAdapter.Fill(Me.SEGURIDAD_CIUDADANADataSet.TIPO_COMUNICACION)

    End Sub
End Class