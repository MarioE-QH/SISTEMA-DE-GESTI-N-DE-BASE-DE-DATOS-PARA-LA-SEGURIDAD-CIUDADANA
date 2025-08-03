<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAtencionVictima
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAtencionVictima))
        Dim IdAtencionLabel As System.Windows.Forms.Label
        Dim IdServicioLabel As System.Windows.Forms.Label
        Dim IdVictimaLabel As System.Windows.Forms.Label
        Dim IdDelitoLabel As System.Windows.Forms.Label
        Dim IdMunicipalidadLabel As System.Windows.Forms.Label
        Dim CodOperacionLabel As System.Windows.Forms.Label
        Me.SEGURIDAD_CIUDADANADataSet = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSet()
        Me.ATENCION_VICTIMASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ATENCION_VICTIMASTableAdapter = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.ATENCION_VICTIMASTableAdapter()
        Me.TableAdapterManager = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager()
        Me.ATENCION_VICTIMASBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ATENCION_VICTIMASBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdAtencionTextBox = New System.Windows.Forms.TextBox()
        Me.IdServicioTextBox = New System.Windows.Forms.TextBox()
        Me.IdVictimaTextBox = New System.Windows.Forms.TextBox()
        Me.IdDelitoTextBox = New System.Windows.Forms.TextBox()
        Me.IdMunicipalidadTextBox = New System.Windows.Forms.TextBox()
        Me.CodOperacionTextBox = New System.Windows.Forms.TextBox()
        IdAtencionLabel = New System.Windows.Forms.Label()
        IdServicioLabel = New System.Windows.Forms.Label()
        IdVictimaLabel = New System.Windows.Forms.Label()
        IdDelitoLabel = New System.Windows.Forms.Label()
        IdMunicipalidadLabel = New System.Windows.Forms.Label()
        CodOperacionLabel = New System.Windows.Forms.Label()
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATENCION_VICTIMASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATENCION_VICTIMASBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ATENCION_VICTIMASBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SEGURIDAD_CIUDADANADataSet
        '
        Me.SEGURIDAD_CIUDADANADataSet.DataSetName = "SEGURIDAD_CIUDADANADataSet"
        Me.SEGURIDAD_CIUDADANADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ATENCION_VICTIMASBindingSource
        '
        Me.ATENCION_VICTIMASBindingSource.DataMember = "ATENCION_VICTIMAS"
        Me.ATENCION_VICTIMASBindingSource.DataSource = Me.SEGURIDAD_CIUDADANADataSet
        '
        'ATENCION_VICTIMASTableAdapter
        '
        Me.ATENCION_VICTIMASTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AREA_SEGURIDADTableAdapter = Nothing
        Me.TableAdapterManager.ATENCION_VICTIMASTableAdapter = Me.ATENCION_VICTIMASTableAdapter
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
        'ATENCION_VICTIMASBindingNavigator
        '
        Me.ATENCION_VICTIMASBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ATENCION_VICTIMASBindingNavigator.BindingSource = Me.ATENCION_VICTIMASBindingSource
        Me.ATENCION_VICTIMASBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ATENCION_VICTIMASBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ATENCION_VICTIMASBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ATENCION_VICTIMASBindingNavigatorSaveItem})
        Me.ATENCION_VICTIMASBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ATENCION_VICTIMASBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ATENCION_VICTIMASBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ATENCION_VICTIMASBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ATENCION_VICTIMASBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ATENCION_VICTIMASBindingNavigator.Name = "ATENCION_VICTIMASBindingNavigator"
        Me.ATENCION_VICTIMASBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ATENCION_VICTIMASBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.ATENCION_VICTIMASBindingNavigator.TabIndex = 0
        Me.ATENCION_VICTIMASBindingNavigator.Text = "BindingNavigator1"
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
        'ATENCION_VICTIMASBindingNavigatorSaveItem
        '
        Me.ATENCION_VICTIMASBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ATENCION_VICTIMASBindingNavigatorSaveItem.Image = CType(resources.GetObject("ATENCION_VICTIMASBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ATENCION_VICTIMASBindingNavigatorSaveItem.Name = "ATENCION_VICTIMASBindingNavigatorSaveItem"
        Me.ATENCION_VICTIMASBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ATENCION_VICTIMASBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdAtencionLabel
        '
        IdAtencionLabel.AutoSize = True
        IdAtencionLabel.Location = New System.Drawing.Point(20, 41)
        IdAtencionLabel.Name = "IdAtencionLabel"
        IdAtencionLabel.Size = New System.Drawing.Size(64, 13)
        IdAtencionLabel.TabIndex = 1
        IdAtencionLabel.Text = "Id Atencion:"
        '
        'IdAtencionTextBox
        '
        Me.IdAtencionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATENCION_VICTIMASBindingSource, "IdAtencion", True))
        Me.IdAtencionTextBox.Location = New System.Drawing.Point(113, 38)
        Me.IdAtencionTextBox.Name = "IdAtencionTextBox"
        Me.IdAtencionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdAtencionTextBox.TabIndex = 2
        '
        'IdServicioLabel
        '
        IdServicioLabel.AutoSize = True
        IdServicioLabel.Location = New System.Drawing.Point(20, 67)
        IdServicioLabel.Name = "IdServicioLabel"
        IdServicioLabel.Size = New System.Drawing.Size(60, 13)
        IdServicioLabel.TabIndex = 3
        IdServicioLabel.Text = "Id Servicio:"
        '
        'IdServicioTextBox
        '
        Me.IdServicioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATENCION_VICTIMASBindingSource, "IdServicio", True))
        Me.IdServicioTextBox.Location = New System.Drawing.Point(113, 64)
        Me.IdServicioTextBox.Name = "IdServicioTextBox"
        Me.IdServicioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdServicioTextBox.TabIndex = 4
        '
        'IdVictimaLabel
        '
        IdVictimaLabel.AutoSize = True
        IdVictimaLabel.Location = New System.Drawing.Point(20, 93)
        IdVictimaLabel.Name = "IdVictimaLabel"
        IdVictimaLabel.Size = New System.Drawing.Size(56, 13)
        IdVictimaLabel.TabIndex = 5
        IdVictimaLabel.Text = "Id Victima:"
        '
        'IdVictimaTextBox
        '
        Me.IdVictimaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATENCION_VICTIMASBindingSource, "IdVictima", True))
        Me.IdVictimaTextBox.Location = New System.Drawing.Point(113, 90)
        Me.IdVictimaTextBox.Name = "IdVictimaTextBox"
        Me.IdVictimaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdVictimaTextBox.TabIndex = 6
        '
        'IdDelitoLabel
        '
        IdDelitoLabel.AutoSize = True
        IdDelitoLabel.Location = New System.Drawing.Point(20, 119)
        IdDelitoLabel.Name = "IdDelitoLabel"
        IdDelitoLabel.Size = New System.Drawing.Size(48, 13)
        IdDelitoLabel.TabIndex = 7
        IdDelitoLabel.Text = "id Delito:"
        '
        'IdDelitoTextBox
        '
        Me.IdDelitoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATENCION_VICTIMASBindingSource, "idDelito", True))
        Me.IdDelitoTextBox.Location = New System.Drawing.Point(113, 116)
        Me.IdDelitoTextBox.Name = "IdDelitoTextBox"
        Me.IdDelitoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdDelitoTextBox.TabIndex = 8
        '
        'IdMunicipalidadLabel
        '
        IdMunicipalidadLabel.AutoSize = True
        IdMunicipalidadLabel.Location = New System.Drawing.Point(20, 145)
        IdMunicipalidadLabel.Name = "IdMunicipalidadLabel"
        IdMunicipalidadLabel.Size = New System.Drawing.Size(87, 13)
        IdMunicipalidadLabel.TabIndex = 9
        IdMunicipalidadLabel.Text = "Id Municipalidad:"
        '
        'IdMunicipalidadTextBox
        '
        Me.IdMunicipalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATENCION_VICTIMASBindingSource, "IdMunicipalidad", True))
        Me.IdMunicipalidadTextBox.Location = New System.Drawing.Point(113, 142)
        Me.IdMunicipalidadTextBox.Name = "IdMunicipalidadTextBox"
        Me.IdMunicipalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdMunicipalidadTextBox.TabIndex = 10
        '
        'CodOperacionLabel
        '
        CodOperacionLabel.AutoSize = True
        CodOperacionLabel.Location = New System.Drawing.Point(20, 171)
        CodOperacionLabel.Name = "CodOperacionLabel"
        CodOperacionLabel.Size = New System.Drawing.Size(81, 13)
        CodOperacionLabel.TabIndex = 11
        CodOperacionLabel.Text = "Cod Operacion:"
        '
        'CodOperacionTextBox
        '
        Me.CodOperacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATENCION_VICTIMASBindingSource, "CodOperacion", True))
        Me.CodOperacionTextBox.Location = New System.Drawing.Point(113, 168)
        Me.CodOperacionTextBox.Name = "CodOperacionTextBox"
        Me.CodOperacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodOperacionTextBox.TabIndex = 12
        '
        'frmAtencionVictima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 211)
        Me.Controls.Add(IdAtencionLabel)
        Me.Controls.Add(Me.IdAtencionTextBox)
        Me.Controls.Add(IdServicioLabel)
        Me.Controls.Add(Me.IdServicioTextBox)
        Me.Controls.Add(IdVictimaLabel)
        Me.Controls.Add(Me.IdVictimaTextBox)
        Me.Controls.Add(IdDelitoLabel)
        Me.Controls.Add(Me.IdDelitoTextBox)
        Me.Controls.Add(IdMunicipalidadLabel)
        Me.Controls.Add(Me.IdMunicipalidadTextBox)
        Me.Controls.Add(CodOperacionLabel)
        Me.Controls.Add(Me.CodOperacionTextBox)
        Me.Controls.Add(Me.ATENCION_VICTIMASBindingNavigator)
        Me.Name = "frmAtencionVictima"
        Me.Text = "frmAtencionVictima"
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATENCION_VICTIMASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATENCION_VICTIMASBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ATENCION_VICTIMASBindingNavigator.ResumeLayout(False)
        Me.ATENCION_VICTIMASBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SEGURIDAD_CIUDADANADataSet As SEGURIDAD_CIUDADANADataSet
    Friend WithEvents ATENCION_VICTIMASBindingSource As BindingSource
    Friend WithEvents ATENCION_VICTIMASTableAdapter As SEGURIDAD_CIUDADANADataSetTableAdapters.ATENCION_VICTIMASTableAdapter
    Friend WithEvents TableAdapterManager As SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager
    Friend WithEvents ATENCION_VICTIMASBindingNavigator As BindingNavigator
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
    Friend WithEvents ATENCION_VICTIMASBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdAtencionTextBox As TextBox
    Friend WithEvents IdServicioTextBox As TextBox
    Friend WithEvents IdVictimaTextBox As TextBox
    Friend WithEvents IdDelitoTextBox As TextBox
    Friend WithEvents IdMunicipalidadTextBox As TextBox
    Friend WithEvents CodOperacionTextBox As TextBox
End Class
