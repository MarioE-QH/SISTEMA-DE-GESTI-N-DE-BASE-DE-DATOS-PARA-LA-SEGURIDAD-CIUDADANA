<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrevencionDelito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrevencionDelito))
        Dim IdPrevencionLabel As System.Windows.Forms.Label
        Dim IdServicioLabel As System.Windows.Forms.Label
        Dim IdMunicipalidadLabel As System.Windows.Forms.Label
        Dim DetalleLabel As System.Windows.Forms.Label
        Dim IdDelicuencialLabel As System.Windows.Forms.Label
        Dim CodOperacionLabel As System.Windows.Forms.Label
        Me.SEGURIDAD_CIUDADANADataSet = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSet()
        Me.PREVENCION_DELITOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PREVENCION_DELITOTableAdapter = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.PREVENCION_DELITOTableAdapter()
        Me.TableAdapterManager = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager()
        Me.PREVENCION_DELITOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PREVENCION_DELITOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdPrevencionTextBox = New System.Windows.Forms.TextBox()
        Me.IdServicioTextBox = New System.Windows.Forms.TextBox()
        Me.IdMunicipalidadTextBox = New System.Windows.Forms.TextBox()
        Me.DetalleTextBox = New System.Windows.Forms.TextBox()
        Me.IdDelicuencialTextBox = New System.Windows.Forms.TextBox()
        Me.CodOperacionTextBox = New System.Windows.Forms.TextBox()
        IdPrevencionLabel = New System.Windows.Forms.Label()
        IdServicioLabel = New System.Windows.Forms.Label()
        IdMunicipalidadLabel = New System.Windows.Forms.Label()
        DetalleLabel = New System.Windows.Forms.Label()
        IdDelicuencialLabel = New System.Windows.Forms.Label()
        CodOperacionLabel = New System.Windows.Forms.Label()
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PREVENCION_DELITOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PREVENCION_DELITOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PREVENCION_DELITOBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SEGURIDAD_CIUDADANADataSet
        '
        Me.SEGURIDAD_CIUDADANADataSet.DataSetName = "SEGURIDAD_CIUDADANADataSet"
        Me.SEGURIDAD_CIUDADANADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PREVENCION_DELITOBindingSource
        '
        Me.PREVENCION_DELITOBindingSource.DataMember = "PREVENCION_DELITO"
        Me.PREVENCION_DELITOBindingSource.DataSource = Me.SEGURIDAD_CIUDADANADataSet
        '
        'PREVENCION_DELITOTableAdapter
        '
        Me.PREVENCION_DELITOTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PREVENCION_DELITOTableAdapter = Me.PREVENCION_DELITOTableAdapter
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
        'PREVENCION_DELITOBindingNavigator
        '
        Me.PREVENCION_DELITOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PREVENCION_DELITOBindingNavigator.BindingSource = Me.PREVENCION_DELITOBindingSource
        Me.PREVENCION_DELITOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PREVENCION_DELITOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PREVENCION_DELITOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PREVENCION_DELITOBindingNavigatorSaveItem})
        Me.PREVENCION_DELITOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PREVENCION_DELITOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PREVENCION_DELITOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PREVENCION_DELITOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PREVENCION_DELITOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PREVENCION_DELITOBindingNavigator.Name = "PREVENCION_DELITOBindingNavigator"
        Me.PREVENCION_DELITOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PREVENCION_DELITOBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.PREVENCION_DELITOBindingNavigator.TabIndex = 0
        Me.PREVENCION_DELITOBindingNavigator.Text = "BindingNavigator1"
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
        'PREVENCION_DELITOBindingNavigatorSaveItem
        '
        Me.PREVENCION_DELITOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PREVENCION_DELITOBindingNavigatorSaveItem.Image = CType(resources.GetObject("PREVENCION_DELITOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PREVENCION_DELITOBindingNavigatorSaveItem.Name = "PREVENCION_DELITOBindingNavigatorSaveItem"
        Me.PREVENCION_DELITOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PREVENCION_DELITOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdPrevencionLabel
        '
        IdPrevencionLabel.AutoSize = True
        IdPrevencionLabel.Location = New System.Drawing.Point(7, 30)
        IdPrevencionLabel.Name = "IdPrevencionLabel"
        IdPrevencionLabel.Size = New System.Drawing.Size(76, 13)
        IdPrevencionLabel.TabIndex = 1
        IdPrevencionLabel.Text = "Id Prevencion:"
        '
        'IdPrevencionTextBox
        '
        Me.IdPrevencionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PREVENCION_DELITOBindingSource, "IdPrevencion", True))
        Me.IdPrevencionTextBox.Location = New System.Drawing.Point(100, 27)
        Me.IdPrevencionTextBox.Name = "IdPrevencionTextBox"
        Me.IdPrevencionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdPrevencionTextBox.TabIndex = 2
        '
        'IdServicioLabel
        '
        IdServicioLabel.AutoSize = True
        IdServicioLabel.Location = New System.Drawing.Point(7, 56)
        IdServicioLabel.Name = "IdServicioLabel"
        IdServicioLabel.Size = New System.Drawing.Size(60, 13)
        IdServicioLabel.TabIndex = 3
        IdServicioLabel.Text = "Id Servicio:"
        '
        'IdServicioTextBox
        '
        Me.IdServicioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PREVENCION_DELITOBindingSource, "IdServicio", True))
        Me.IdServicioTextBox.Location = New System.Drawing.Point(100, 53)
        Me.IdServicioTextBox.Name = "IdServicioTextBox"
        Me.IdServicioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdServicioTextBox.TabIndex = 4
        '
        'IdMunicipalidadLabel
        '
        IdMunicipalidadLabel.AutoSize = True
        IdMunicipalidadLabel.Location = New System.Drawing.Point(7, 82)
        IdMunicipalidadLabel.Name = "IdMunicipalidadLabel"
        IdMunicipalidadLabel.Size = New System.Drawing.Size(87, 13)
        IdMunicipalidadLabel.TabIndex = 5
        IdMunicipalidadLabel.Text = "Id Municipalidad:"
        '
        'IdMunicipalidadTextBox
        '
        Me.IdMunicipalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PREVENCION_DELITOBindingSource, "IdMunicipalidad", True))
        Me.IdMunicipalidadTextBox.Location = New System.Drawing.Point(100, 79)
        Me.IdMunicipalidadTextBox.Name = "IdMunicipalidadTextBox"
        Me.IdMunicipalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdMunicipalidadTextBox.TabIndex = 6
        '
        'DetalleLabel
        '
        DetalleLabel.AutoSize = True
        DetalleLabel.Location = New System.Drawing.Point(7, 108)
        DetalleLabel.Name = "DetalleLabel"
        DetalleLabel.Size = New System.Drawing.Size(43, 13)
        DetalleLabel.TabIndex = 7
        DetalleLabel.Text = "Detalle:"
        '
        'DetalleTextBox
        '
        Me.DetalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PREVENCION_DELITOBindingSource, "Detalle", True))
        Me.DetalleTextBox.Location = New System.Drawing.Point(100, 105)
        Me.DetalleTextBox.Name = "DetalleTextBox"
        Me.DetalleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DetalleTextBox.TabIndex = 8
        '
        'IdDelicuencialLabel
        '
        IdDelicuencialLabel.AutoSize = True
        IdDelicuencialLabel.Location = New System.Drawing.Point(7, 134)
        IdDelicuencialLabel.Name = "IdDelicuencialLabel"
        IdDelicuencialLabel.Size = New System.Drawing.Size(80, 13)
        IdDelicuencialLabel.TabIndex = 9
        IdDelicuencialLabel.Text = "Id Delicuencial:"
        '
        'IdDelicuencialTextBox
        '
        Me.IdDelicuencialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PREVENCION_DELITOBindingSource, "IdDelicuencial", True))
        Me.IdDelicuencialTextBox.Location = New System.Drawing.Point(100, 131)
        Me.IdDelicuencialTextBox.Name = "IdDelicuencialTextBox"
        Me.IdDelicuencialTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdDelicuencialTextBox.TabIndex = 10
        '
        'CodOperacionLabel
        '
        CodOperacionLabel.AutoSize = True
        CodOperacionLabel.Location = New System.Drawing.Point(7, 160)
        CodOperacionLabel.Name = "CodOperacionLabel"
        CodOperacionLabel.Size = New System.Drawing.Size(81, 13)
        CodOperacionLabel.TabIndex = 11
        CodOperacionLabel.Text = "Cod Operacion:"
        '
        'CodOperacionTextBox
        '
        Me.CodOperacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PREVENCION_DELITOBindingSource, "CodOperacion", True))
        Me.CodOperacionTextBox.Location = New System.Drawing.Point(100, 157)
        Me.CodOperacionTextBox.Name = "CodOperacionTextBox"
        Me.CodOperacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodOperacionTextBox.TabIndex = 12
        '
        'frmPrevencionDelito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(IdPrevencionLabel)
        Me.Controls.Add(Me.IdPrevencionTextBox)
        Me.Controls.Add(IdServicioLabel)
        Me.Controls.Add(Me.IdServicioTextBox)
        Me.Controls.Add(IdMunicipalidadLabel)
        Me.Controls.Add(Me.IdMunicipalidadTextBox)
        Me.Controls.Add(DetalleLabel)
        Me.Controls.Add(Me.DetalleTextBox)
        Me.Controls.Add(IdDelicuencialLabel)
        Me.Controls.Add(Me.IdDelicuencialTextBox)
        Me.Controls.Add(CodOperacionLabel)
        Me.Controls.Add(Me.CodOperacionTextBox)
        Me.Controls.Add(Me.PREVENCION_DELITOBindingNavigator)
        Me.Name = "frmPrevencionDelito"
        Me.Text = "PrevencionDelito"
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PREVENCION_DELITOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PREVENCION_DELITOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PREVENCION_DELITOBindingNavigator.ResumeLayout(False)
        Me.PREVENCION_DELITOBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SEGURIDAD_CIUDADANADataSet As SEGURIDAD_CIUDADANADataSet
    Friend WithEvents PREVENCION_DELITOBindingSource As BindingSource
    Friend WithEvents PREVENCION_DELITOTableAdapter As SEGURIDAD_CIUDADANADataSetTableAdapters.PREVENCION_DELITOTableAdapter
    Friend WithEvents TableAdapterManager As SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager
    Friend WithEvents PREVENCION_DELITOBindingNavigator As BindingNavigator
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
    Friend WithEvents PREVENCION_DELITOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdPrevencionTextBox As TextBox
    Friend WithEvents IdServicioTextBox As TextBox
    Friend WithEvents IdMunicipalidadTextBox As TextBox
    Friend WithEvents DetalleTextBox As TextBox
    Friend WithEvents IdDelicuencialTextBox As TextBox
    Friend WithEvents CodOperacionTextBox As TextBox
End Class
