Public Class frmVideovigilancia
    Private Sub VIDEOVIGILANCIABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VIDEOVIGILANCIABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VIDEOVIGILANCIABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SEGURIDAD_CIUDADANADataSet)

    End Sub

    Private Sub frmVideovigilancia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SEGURIDAD_CIUDADANADataSet.VIDEOVIGILANCIA' Puede moverla o quitarla según sea necesario.
        Me.VIDEOVIGILANCIATableAdapter.Fill(Me.SEGURIDAD_CIUDADANADataSet.VIDEOVIGILANCIA)

    End Sub
End Class