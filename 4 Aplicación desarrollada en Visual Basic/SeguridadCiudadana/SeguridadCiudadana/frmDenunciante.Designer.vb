<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDenunciante
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDenunciante))
        Dim IdPersonaLabel As System.Windows.Forms.Label
        Dim DettalleDenunciaLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim NombrePersonaLabel As System.Windows.Forms.Label
        Me.SEGURIDAD_CIUDADANADataSet = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSet()
        Me.PERSONABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERSONATableAdapter = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.PERSONATableAdapter()
        Me.TableAdapterManager = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager()
        Me.PERSONABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PERSONABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdPersonaTextBox = New System.Windows.Forms.TextBox()
        Me.DettalleDenunciaTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.NombrePersonaTextBox = New System.Windows.Forms.TextBox()
        IdPersonaLabel = New System.Windows.Forms.Label()
        DettalleDenunciaLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        NombrePersonaLabel = New System.Windows.Forms.Label()
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PERSONABindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SEGURIDAD_CIUDADANADataSet
        '
        Me.SEGURIDAD_CIUDADANADataSet.DataSetName = "SEGURIDAD_CIUDADANADataSet"
        Me.SEGURIDAD_CIUDADANADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PERSONABindingSource
        '
        Me.PERSONABindingSource.DataMember = "PERSONA"
        Me.PERSONABindingSource.DataSource = Me.SEGURIDAD_CIUDADANADataSet
        '
        'PERSONATableAdapter
        '
        Me.PERSONATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AREA_SEGURIDADTableAdapter = Nothing
        Me.TableAdapterManager.ATENCION_VICTIMASTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CAMARATableAdapter = Nothing
        Me.TableAdapterManager.COMISARIATableAdapter = Nothing
        Me.TableAdapterManager.CONTROL__PERSECUCCIONTableAdapter = Nothing
        Me.TableAdapterManager.DELINCUENCIALTableAdapter = Nothing
        Me.TableAdapterManager.DELITOTableAdapter = Nothing
        Me.TableAdapterManager.DETALLE_CAMARATableAdapter = Nothing
        Me.TableAdapterManager.DETALLE_POLICIATableAdapter = Nothing
        Me.TableAdapterManager.DETALLE_SERENAZGOTableAdapter = Nothing
        Me.TableAdapterManager.EMPLEADO_SEGURIDADTableAdapter = Nothing
        Me.TableAdapterManager.EMPRESATableAdapter = Nothing
        Me.TableAdapterManager.ESTADO_EVALLUACIONTableAdapter = Nothing
        Me.TableAdapterManager.ESTADO_SERVICIOTableAdapter = Nothing
        Me.TableAdapterManager.ESTADO_VICTIMATableAdapter = Nothing
        Me.TableAdapterManager.EVALUACIONTableAdapter = Nothing
        Me.TableAdapterManager.MANTENIMIENTOTableAdapter = Nothing
        Me.TableAdapterManager.MUNICIPALIDADTableAdapter = Nothing
        Me.TableAdapterManager.PERSONA_JURIDICATableAdapter = Nothing
        Me.TableAdapterManager.PERSONA_NATURALTableAdapter = Nothing
        Me.TableAdapterManager.PERSONATableAdapter = Me.PERSONATableAdapter
        Me.TableAdapterManager.POLICIATableAdapter = Nothing
        Me.TableAdapterManager.PREVENCION_DELITOTableAdapter = Nothing
        Me.TableAdapterManager.PROGRAMACIÓNTableAdapter = Nothing
        Me.TableAdapterManager.RANGO_POLICIATableAdapter = Nothing
        Me.TableAdapterManager.RAZON_SOCIALTableAdapter = Nothing
        Me.TableAdapterManager.RUBROTableAdapter = Nothing
        Me.TableAdapterManager.SERENAZGOTableAdapter = Nothing
        Me.TableAdapterManager.SERVICIOTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_CAMARATableAdapter = Nothing
        Me.TableAdapterManager.TIPO_COMUNICACIONTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_DELINCUENCIALTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_SEGURIDADTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_SERVICIOTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_VEHICULOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VEHICULOSTableAdapter = Nothing
        Me.TableAdapterManager.VICTIMATableAdapter = Nothing
        Me.TableAdapterManager.VIDEO_OPERADORTableAdapter = Nothing
        Me.TableAdapterManager.VIDEOVIGILANCIATableAdapter = Nothing
        '
        'PERSONABindingNavigator
        '
        Me.PERSONABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PERSONABindingNavigator.BindingSource = Me.PERSONABindingSource
        Me.PERSONABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PERSONABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PERSONABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PERSONABindingNavigatorSaveItem})
        Me.PERSONABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PERSONABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PERSONABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PERSONABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PERSONABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PERSONABindingNavigator.Name = "PERSONABindingNavigator"
        Me.PERSONABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PERSONABindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.PERSONABindingNavigator.TabIndex = 0
        Me.PERSONABindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'PERSONABindingNavigatorSaveItem
        '
        Me.PERSONABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PERSONABindingNavigatorSaveItem.Image = CType(resources.GetObject("PERSONABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PERSONABindingNavigatorSaveItem.Name = "PERSONABindingNavigatorSaveItem"
        Me.PERSONABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PERSONABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdPersonaLabel
        '
        IdPersonaLabel.AutoSize = True
        IdPersonaLabel.Location = New System.Drawing.Point(12, 43)
        IdPersonaLabel.Name = "IdPersonaLabel"
        IdPersonaLabel.Size = New System.Drawing.Size(61, 13)
        IdPersonaLabel.TabIndex = 1
        IdPersonaLabel.Text = "Id Persona:"
        '
        'IdPersonaTextBox
        '
        Me.IdPersonaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERSONABindingSource, "IdPersona", True))
        Me.IdPersonaTextBox.Location = New System.Drawing.Point(113, 40)
        Me.IdPersonaTextBox.Name = "IdPersonaTextBox"
        Me.IdPersonaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdPersonaTextBox.TabIndex = 2
        '
        'DettalleDenunciaLabel
        '
        DettalleDenunciaLabel.AutoSize = True
        DettalleDenunciaLabel.Location = New System.Drawing.Point(12, 69)
        DettalleDenunciaLabel.Name = "DettalleDenunciaLabel"
        DettalleDenunciaLabel.Size = New System.Drawing.Size(95, 13)
        DettalleDenunciaLabel.TabIndex = 3
        DettalleDenunciaLabel.Text = "Dettalle Denuncia:"
        '
        'DettalleDenunciaTextBox
        '
        Me.DettalleDenunciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERSONABindingSource, "DettalleDenuncia", True))
        Me.DettalleDenunciaTextBox.Location = New System.Drawing.Point(113, 66)
        Me.DettalleDenunciaTextBox.Name = "DettalleDenunciaTextBox"
        Me.DettalleDenunciaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DettalleDenunciaTextBox.TabIndex = 4
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(12, 95)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 5
        TelefonoLabel.Text = "Telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERSONABindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(113, 92)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 6
        '
        'NombrePersonaLabel
        '
        NombrePersonaLabel.AutoSize = True
        NombrePersonaLabel.Location = New System.Drawing.Point(12, 121)
        NombrePersonaLabel.Name = "NombrePersonaLabel"
        NombrePersonaLabel.Size = New System.Drawing.Size(89, 13)
        NombrePersonaLabel.TabIndex = 7
        NombrePersonaLabel.Text = "Nombre Persona:"
        '
        'NombrePersonaTextBox
        '
        Me.NombrePersonaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERSONABindingSource, "NombrePersona", True))
        Me.NombrePersonaTextBox.Location = New System.Drawing.Point(113, 118)
        Me.NombrePersonaTextBox.Name = "NombrePersonaTextBox"
        Me.NombrePersonaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombrePersonaTextBox.TabIndex = 8
        '
        'frmDenunciante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(IdPersonaLabel)
        Me.Controls.Add(Me.IdPersonaTextBox)
        Me.Controls.Add(DettalleDenunciaLabel)
        Me.Controls.Add(Me.DettalleDenunciaTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(NombrePersonaLabel)
        Me.Controls.Add(Me.NombrePersonaTextBox)
        Me.Controls.Add(Me.PERSONABindingNavigator)
        Me.Name = "frmDenunciante"
        Me.Text = "Denunciante"
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PERSONABindingNavigator.ResumeLayout(False)
        Me.PERSONABindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SEGURIDAD_CIUDADANADataSet As SEGURIDAD_CIUDADANADataSet
    Friend WithEvents PERSONABindingSource As BindingSource
    Friend WithEvents PERSONATableAdapter As SEGURIDAD_CIUDADANADataSetTableAdapters.PERSONATableAdapter
    Friend WithEvents TableAdapterManager As SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager
    Friend WithEvents PERSONABindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PERSONABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdPersonaTextBox As TextBox
    Friend WithEvents DettalleDenunciaTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents NombrePersonaTextBox As TextBox
End Class
