Public Class Form1
    Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(0)
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(1)
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(2)
    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
        Dim ObjEmpleado As New frmEmpleado
        ObjEmpleado.MdiParent = Me
        ObjEmpleado.Show()
    End Sub

    Private Sub JefeDeSeguridadToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SerenazgoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SerenazgoToolStripMenuItem.Click
        Dim ObjSerenazgo As New frmSerenazgo
        ObjSerenazgo.MdiParent = Me
        ObjSerenazgo.Show()
    End Sub

    Private Sub PatrullaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatrullaToolStripMenuItem.Click
        Dim ObjPatrulla As New frmPatrulla
        ObjPatrulla.MdiParent = Me
        ObjPatrulla.Show()
    End Sub

    Private Sub ComunicacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComunicacionToolStripMenuItem.Click
        Dim ObjComunicacion As New frmTipoComunicacion
        ObjComunicacion.MdiParent = Me
        ObjComunicacion.Show()
    End Sub

    Private Sub AtencionDeVictimaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtencionDeVictimaToolStripMenuItem.Click
        Dim ObjAtencion As New frmAtencionVictima
        ObjAtencion.MdiParent = Me
        ObjAtencion.Show()
    End Sub

    Private Sub PrevencionDelDelitoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrevencionDelDelitoToolStripMenuItem.Click
        Dim ObjPrevencionDelito As New frmPrevencionDelito
        ObjPrevencionDelito.MdiParent = Me
        ObjPrevencionDelito.Show()
    End Sub

    Private Sub DenuncianteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DenuncianteToolStripMenuItem.Click
        Dim ObjDenunciante As New frmDenunciante
        ObjDenunciante.MdiParent = Me
        ObjDenunciante.Show()
    End Sub

    Private Sub VideoVigilanciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VideoVigilanciaToolStripMenuItem.Click
        Dim ObjVideovigilancia As New frmVideovigilancia
        ObjVideovigilancia.MdiParent = Me
        ObjVideovigilancia.Show()
    End Sub

    Private Sub EmpleadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem1.Click
        Dim ObjVistaEmpleado As New frmVistaEmpleado
        ObjVistaEmpleado.MdiParent = Me
        ObjVistaEmpleado.Show()
    End Sub

    Private Sub SerenazgoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SerenazgoToolStripMenuItem1.Click
        Dim ObjVistaSerenazgo As New frmVistaSerenazgo
        ObjVistaSerenazgo.MdiParent = Me
        ObjVistaSerenazgo.Show()
    End Sub

    Private Sub VictimaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VictimaToolStripMenuItem.Click
        Dim ObjVistaVictima As New frmVistaVictima
        ObjVistaVictima.MdiParent = Me
        ObjVistaVictima.Show()
    End Sub
End Class
