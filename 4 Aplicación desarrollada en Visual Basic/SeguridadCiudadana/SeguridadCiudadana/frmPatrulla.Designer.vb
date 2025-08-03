<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPatrulla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatrulla))
        Dim IdPatrullaLabel As System.Windows.Forms.Label
        Dim PlacaPatrullaLabel As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Dim AsientosLabel As System.Windows.Forms.Label
        Dim IdTipoVLabel As System.Windows.Forms.Label
        Dim CostoLabel As System.Windows.Forms.Label
        Dim CEquipacionLabel As System.Windows.Forms.Label
        Me.SEGURIDAD_CIUDADANADataSet = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSet()
        Me.VEHICULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VEHICULOSTableAdapter = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.VEHICULOSTableAdapter()
        Me.TableAdapterManager = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager()
        Me.VEHICULOSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VEHICULOSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdPatrullaTextBox = New System.Windows.Forms.TextBox()
        Me.PlacaPatrullaTextBox = New System.Windows.Forms.TextBox()
        Me.AñoTextBox = New System.Windows.Forms.TextBox()
        Me.AsientosTextBox = New System.Windows.Forms.TextBox()
        Me.IdTipoVTextBox = New System.Windows.Forms.TextBox()
        Me.CostoTextBox = New System.Windows.Forms.TextBox()
        Me.CEquipacionTextBox = New System.Windows.Forms.TextBox()
        IdPatrullaLabel = New System.Windows.Forms.Label()
        PlacaPatrullaLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        AsientosLabel = New System.Windows.Forms.Label()
        IdTipoVLabel = New System.Windows.Forms.Label()
        CostoLabel = New System.Windows.Forms.Label()
        CEquipacionLabel = New System.Windows.Forms.Label()
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VEHICULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VEHICULOSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VEHICULOSBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SEGURIDAD_CIUDADANADataSet
        '
        Me.SEGURIDAD_CIUDADANADataSet.DataSetName = "SEGURIDAD_CIUDADANADataSet"
        Me.SEGURIDAD_CIUDADANADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VEHICULOSBindingSource
        '
        Me.VEHICULOSBindingSource.DataMember = "VEHICULOS"
        Me.VEHICULOSBindingSource.DataSource = Me.SEGURIDAD_CIUDADANADataSet
        '
        'VEHICULOSTableAdapter
        '
        Me.VEHICULOSTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TIPO_COMUNICACIONTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_DELINCUENCIALTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_SEGURIDADTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_SERVICIOTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_VEHICULOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VEHICULOSTableAdapter = Me.VEHICULOSTableAdapter
        Me.TableAdapterManager.VICTIMATableAdapter = Nothing
        Me.TableAdapterManager.VIDEO_OPERADORTableAdapter = Nothing
        Me.TableAdapterManager.VIDEOVIGILANCIATableAdapter = Nothing
        '
        'VEHICULOSBindingNavigator
        '
        Me.VEHICULOSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VEHICULOSBindingNavigator.BindingSource = Me.VEHICULOSBindingSource
        Me.VEHICULOSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VEHICULOSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VEHICULOSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VEHICULOSBindingNavigatorSaveItem})
        Me.VEHICULOSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VEHICULOSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VEHICULOSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VEHICULOSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VEHICULOSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VEHICULOSBindingNavigator.Name = "VEHICULOSBindingNavigator"
        Me.VEHICULOSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VEHICULOSBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.VEHICULOSBindingNavigator.TabIndex = 0
        Me.VEHICULOSBindingNavigator.Text = "BindingNavigator1"
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
        'VEHICULOSBindingNavigatorSaveItem
        '
        Me.VEHICULOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VEHICULOSBindingNavigatorSaveItem.Image = CType(resources.GetObject("VEHICULOSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VEHICULOSBindingNavigatorSaveItem.Name = "VEHICULOSBindingNavigatorSaveItem"
        Me.VEHICULOSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.VEHICULOSBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdPatrullaLabel
        '
        IdPatrullaLabel.AutoSize = True
        IdPatrullaLabel.Location = New System.Drawing.Point(12, 36)
        IdPatrullaLabel.Name = "IdPatrullaLabel"
        IdPatrullaLabel.Size = New System.Drawing.Size(57, 13)
        IdPatrullaLabel.TabIndex = 1
        IdPatrullaLabel.Text = "Id Patrulla:"
        '
        'IdPatrullaTextBox
        '
        Me.IdPatrullaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEHICULOSBindingSource, "IdPatrulla", True))
        Me.IdPatrullaTextBox.Location = New System.Drawing.Point(93, 33)
        Me.IdPatrullaTextBox.Name = "IdPatrullaTextBox"
        Me.IdPatrullaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdPatrullaTextBox.TabIndex = 2
        '
        'PlacaPatrullaLabel
        '
        PlacaPatrullaLabel.AutoSize = True
        PlacaPatrullaLabel.Location = New System.Drawing.Point(12, 62)
        PlacaPatrullaLabel.Name = "PlacaPatrullaLabel"
        PlacaPatrullaLabel.Size = New System.Drawing.Size(75, 13)
        PlacaPatrullaLabel.TabIndex = 3
        PlacaPatrullaLabel.Text = "Placa Patrulla:"
        '
        'PlacaPatrullaTextBox
        '
        Me.PlacaPatrullaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEHICULOSBindingSource, "PlacaPatrulla", True))
        Me.PlacaPatrullaTextBox.Location = New System.Drawing.Point(93, 59)
        Me.PlacaPatrullaTextBox.Name = "PlacaPatrullaTextBox"
        Me.PlacaPatrullaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PlacaPatrullaTextBox.TabIndex = 4
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Location = New System.Drawing.Point(12, 88)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(29, 13)
        AñoLabel.TabIndex = 5
        AñoLabel.Text = "Año:"
        '
        'AñoTextBox
        '
        Me.AñoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEHICULOSBindingSource, "Año", True))
        Me.AñoTextBox.Location = New System.Drawing.Point(93, 85)
        Me.AñoTextBox.Name = "AñoTextBox"
        Me.AñoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AñoTextBox.TabIndex = 6
        '
        'AsientosLabel
        '
        AsientosLabel.AutoSize = True
        AsientosLabel.Location = New System.Drawing.Point(12, 114)
        AsientosLabel.Name = "AsientosLabel"
        AsientosLabel.Size = New System.Drawing.Size(50, 13)
        AsientosLabel.TabIndex = 7
        AsientosLabel.Text = "Asientos:"
        '
        'AsientosTextBox
        '
        Me.AsientosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEHICULOSBindingSource, "Asientos", True))
        Me.AsientosTextBox.Location = New System.Drawing.Point(93, 111)
        Me.AsientosTextBox.Name = "AsientosTextBox"
        Me.AsientosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AsientosTextBox.TabIndex = 8
        '
        'IdTipoVLabel
        '
        IdTipoVLabel.AutoSize = True
        IdTipoVLabel.Location = New System.Drawing.Point(12, 140)
        IdTipoVLabel.Name = "IdTipoVLabel"
        IdTipoVLabel.Size = New System.Drawing.Size(53, 13)
        IdTipoVLabel.TabIndex = 9
        IdTipoVLabel.Text = "Id Tipo V:"
        '
        'IdTipoVTextBox
        '
        Me.IdTipoVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEHICULOSBindingSource, "IdTipoV", True))
        Me.IdTipoVTextBox.Location = New System.Drawing.Point(93, 137)
        Me.IdTipoVTextBox.Name = "IdTipoVTextBox"
        Me.IdTipoVTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTipoVTextBox.TabIndex = 10
        '
        'CostoLabel
        '
        CostoLabel.AutoSize = True
        CostoLabel.Location = New System.Drawing.Point(12, 166)
        CostoLabel.Name = "CostoLabel"
        CostoLabel.Size = New System.Drawing.Size(37, 13)
        CostoLabel.TabIndex = 11
        CostoLabel.Text = "Costo:"
        '
        'CostoTextBox
        '
        Me.CostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEHICULOSBindingSource, "Costo", True))
        Me.CostoTextBox.Location = New System.Drawing.Point(93, 163)
        Me.CostoTextBox.Name = "CostoTextBox"
        Me.CostoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CostoTextBox.TabIndex = 12
        '
        'CEquipacionLabel
        '
        CEquipacionLabel.AutoSize = True
        CEquipacionLabel.Location = New System.Drawing.Point(12, 192)
        CEquipacionLabel.Name = "CEquipacionLabel"
        CEquipacionLabel.Size = New System.Drawing.Size(70, 13)
        CEquipacionLabel.TabIndex = 13
        CEquipacionLabel.Text = "CEquipacion:"
        '
        'CEquipacionTextBox
        '
        Me.CEquipacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEHICULOSBindingSource, "CEquipacion", True))
        Me.CEquipacionTextBox.Location = New System.Drawing.Point(93, 189)
        Me.CEquipacionTextBox.Name = "CEquipacionTextBox"
        Me.CEquipacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CEquipacionTextBox.TabIndex = 14
        '
        'frmPatrulla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(IdPatrullaLabel)
        Me.Controls.Add(Me.IdPatrullaTextBox)
        Me.Controls.Add(PlacaPatrullaLabel)
        Me.Controls.Add(Me.PlacaPatrullaTextBox)
        Me.Controls.Add(AñoLabel)
        Me.Controls.Add(Me.AñoTextBox)
        Me.Controls.Add(AsientosLabel)
        Me.Controls.Add(Me.AsientosTextBox)
        Me.Controls.Add(IdTipoVLabel)
        Me.Controls.Add(Me.IdTipoVTextBox)
        Me.Controls.Add(CostoLabel)
        Me.Controls.Add(Me.CostoTextBox)
        Me.Controls.Add(CEquipacionLabel)
        Me.Controls.Add(Me.CEquipacionTextBox)
        Me.Controls.Add(Me.VEHICULOSBindingNavigator)
        Me.Name = "frmPatrulla"
        Me.Text = "Patrulla"
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VEHICULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VEHICULOSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VEHICULOSBindingNavigator.ResumeLayout(False)
        Me.VEHICULOSBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SEGURIDAD_CIUDADANADataSet As SEGURIDAD_CIUDADANADataSet
    Friend WithEvents VEHICULOSBindingSource As BindingSource
    Friend WithEvents VEHICULOSTableAdapter As SEGURIDAD_CIUDADANADataSetTableAdapters.VEHICULOSTableAdapter
    Friend WithEvents TableAdapterManager As SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager
    Friend WithEvents VEHICULOSBindingNavigator As BindingNavigator
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
    Friend WithEvents VEHICULOSBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdPatrullaTextBox As TextBox
    Friend WithEvents PlacaPatrullaTextBox As TextBox
    Friend WithEvents AñoTextBox As TextBox
    Friend WithEvents AsientosTextBox As TextBox
    Friend WithEvents IdTipoVTextBox As TextBox
    Friend WithEvents CostoTextBox As TextBox
    Friend WithEvents CEquipacionTextBox As TextBox
End Class
