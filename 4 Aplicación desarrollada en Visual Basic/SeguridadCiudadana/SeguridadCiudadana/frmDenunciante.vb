Public Class frmDenunciante
    Private Sub PERSONABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PERSONABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SEGURIDAD_CIUDADANADataSet)

    End Sub

    Private Sub PERSONABindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles PERSONABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PERSONABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SEGURIDAD_CIUDADANADataSet)

    End Sub

    Private Sub frmDenunciante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SEGURIDAD_CIUDADANADataSet.PERSONA' Puede moverla o quitarla según sea necesario.
        Me.PERSONATableAdapter.Fill(Me.SEGURIDAD_CIUDADANADataSet.PERSONA)

    End Sub
End Class