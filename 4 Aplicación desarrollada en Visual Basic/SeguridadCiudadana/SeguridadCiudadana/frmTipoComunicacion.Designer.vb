<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoComunicacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTipoComunicacion))
        Dim IdTipoDescripcionLabel As System.Windows.Forms.Label
        Dim DetalleTipoDescripcionLabel As System.Windows.Forms.Label
        Me.SEGURIDAD_CIUDADANADataSet = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSet()
        Me.TIPO_COMUNICACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIPO_COMUNICACIONTableAdapter = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.TIPO_COMUNICACIONTableAdapter()
        Me.TableAdapterManager = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager()
        Me.TIPO_COMUNICACIONBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TIPO_COMUNICACIONBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTipoDescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.DetalleTipoDescripcionTextBox = New System.Windows.Forms.TextBox()
        IdTipoDescripcionLabel = New System.Windows.Forms.Label()
        DetalleTipoDescripcionLabel = New System.Windows.Forms.Label()
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPO_COMUNICACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPO_COMUNICACIONBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TIPO_COMUNICACIONBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SEGURIDAD_CIUDADANADataSet
        '
        Me.SEGURIDAD_CIUDADANADataSet.DataSetName = "SEGURIDAD_CIUDADANADataSet"
        Me.SEGURIDAD_CIUDADANADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TIPO_COMUNICACIONBindingSource
        '
        Me.TIPO_COMUNICACIONBindingSource.DataMember = "TIPO_COMUNICACION"
        Me.TIPO_COMUNICACIONBindingSource.DataSource = Me.SEGURIDAD_CIUDADANADataSet
        '
        'TIPO_COMUNICACIONTableAdapter
        '
        Me.TIPO_COMUNICACIONTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PERSONATableAdapter = Nothing
        Me.TableAdapterManager.POLICIATableAdapter = Nothing
        Me.TableAdapterManager.PREVENCION_DELITOTableAdapter = Nothing
        Me.TableAdapterManager.PROGRAMACIÓNTableAdapter = Nothing
        Me.TableAdapterManager.RANGO_POLICIATableAdapter = Nothing
        Me.TableAdapterManager.RAZON_SOCIALTableAdapter = Nothing
        Me.TableAdapterManager.RUBROTableAdapter = Nothing
        Me.TableAdapterManager.SERENAZGOTableAdapter = Nothing
        Me.TableAdapterManager.SERVICIOTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_CAMARATableAdapter = Nothing
        Me.TableAdapterManager.TIPO_COMUNICACIONTableAdapter = Me.TIPO_COMUNICACIONTableAdapter
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
        'TIPO_COMUNICACIONBindingNavigator
        '
        Me.TIPO_COMUNICACIONBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TIPO_COMUNICACIONBindingNavigator.BindingSource = Me.TIPO_COMUNICACIONBindingSource
        Me.TIPO_COMUNICACIONBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TIPO_COMUNICACIONBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TIPO_COMUNICACIONBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TIPO_COMUNICACIONBindingNavigatorSaveItem})
        Me.TIPO_COMUNICACIONBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TIPO_COMUNICACIONBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TIPO_COMUNICACIONBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TIPO_COMUNICACIONBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TIPO_COMUNICACIONBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TIPO_COMUNICACIONBindingNavigator.Name = "TIPO_COMUNICACIONBindingNavigator"
        Me.TIPO_COMUNICACIONBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TIPO_COMUNICACIONBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.TIPO_COMUNICACIONBindingNavigator.TabIndex = 0
        Me.TIPO_COMUNICACIONBindingNavigator.Text = "BindingNavigator1"
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
        'TIPO_COMUNICACIONBindingNavigatorSaveItem
        '
        Me.TIPO_COMUNICACIONBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TIPO_COMUNICACIONBindingNavigatorSaveItem.Image = CType(resources.GetObject("TIPO_COMUNICACIONBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TIPO_COMUNICACIONBindingNavigatorSaveItem.Name = "TIPO_COMUNICACIONBindingNavigatorSaveItem"
        Me.TIPO_COMUNICACIONBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TIPO_COMUNICACIONBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdTipoDescripcionLabel
        '
        IdTipoDescripcionLabel.AutoSize = True
        IdTipoDescripcionLabel.Location = New System.Drawing.Point(10, 34)
        IdTipoDescripcionLabel.Name = "IdTipoDescripcionLabel"
        IdTipoDescripcionLabel.Size = New System.Drawing.Size(102, 13)
        IdTipoDescripcionLabel.TabIndex = 1
        IdTipoDescripcionLabel.Text = "Id Tipo Descripcion:"
        '
        'IdTipoDescripcionTextBox
        '
        Me.IdTipoDescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPO_COMUNICACIONBindingSource, "IdTipoDescripcion", True))
        Me.IdTipoDescripcionTextBox.Location = New System.Drawing.Point(142, 31)
        Me.IdTipoDescripcionTextBox.Name = "IdTipoDescripcionTextBox"
        Me.IdTipoDescripcionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTipoDescripcionTextBox.TabIndex = 2
        '
        'DetalleTipoDescripcionLabel
        '
        DetalleTipoDescripcionLabel.AutoSize = True
        DetalleTipoDescripcionLabel.Location = New System.Drawing.Point(10, 60)
        DetalleTipoDescripcionLabel.Name = "DetalleTipoDescripcionLabel"
        DetalleTipoDescripcionLabel.Size = New System.Drawing.Size(126, 13)
        DetalleTipoDescripcionLabel.TabIndex = 3
        DetalleTipoDescripcionLabel.Text = "Detalle Tipo Descripcion:"
        '
        'DetalleTipoDescripcionTextBox
        '
        Me.DetalleTipoDescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPO_COMUNICACIONBindingSource, "DetalleTipoDescripcion", True))
        Me.DetalleTipoDescripcionTextBox.Location = New System.Drawing.Point(142, 57)
        Me.DetalleTipoDescripcionTextBox.Name = "DetalleTipoDescripcionTextBox"
        Me.DetalleTipoDescripcionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DetalleTipoDescripcionTextBox.TabIndex = 4
        '
        'frmTipoComunicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(IdTipoDescripcionLabel)
        Me.Controls.Add(Me.IdTipoDescripcionTextBox)
        Me.Controls.Add(DetalleTipoDescripcionLabel)
        Me.Controls.Add(Me.DetalleTipoDescripcionTextBox)
        Me.Controls.Add(Me.TIPO_COMUNICACIONBindingNavigator)
        Me.Name = "frmTipoComunicacion"
        Me.Text = "Comunicacion"
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPO_COMUNICACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPO_COMUNICACIONBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TIPO_COMUNICACIONBindingNavigator.ResumeLayout(False)
        Me.TIPO_COMUNICACIONBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SEGURIDAD_CIUDADANADataSet As SEGURIDAD_CIUDADANADataSet
    Friend WithEvents TIPO_COMUNICACIONBindingSource As BindingSource
    Friend WithEvents TIPO_COMUNICACIONTableAdapter As SEGURIDAD_CIUDADANADataSetTableAdapters.TIPO_COMUNICACIONTableAdapter
    Friend WithEvents TableAdapterManager As SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager
    Friend WithEvents TIPO_COMUNICACIONBindingNavigator As BindingNavigator
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
    Friend WithEvents TIPO_COMUNICACIONBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTipoDescripcionTextBox As TextBox
    Friend WithEvents DetalleTipoDescripcionTextBox As TextBox
End Class
