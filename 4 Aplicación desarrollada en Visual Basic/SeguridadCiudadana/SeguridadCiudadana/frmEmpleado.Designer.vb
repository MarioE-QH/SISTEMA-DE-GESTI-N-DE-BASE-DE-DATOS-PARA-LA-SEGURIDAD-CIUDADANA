<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleado))
        Dim IdEmpleadoLabel As System.Windows.Forms.Label
        Dim NombreELabel As System.Windows.Forms.Label
        Dim ApellidoELabel As System.Windows.Forms.Label
        Dim DNIELabel As System.Windows.Forms.Label
        Dim TelefonoELabel As System.Windows.Forms.Label
        Dim FInicioLabel As System.Windows.Forms.Label
        Dim FFinLabel As System.Windows.Forms.Label
        Dim IdTipoLabel As System.Windows.Forms.Label
        Dim SueldoLabel As System.Windows.Forms.Label
        Me.SEGURIDAD_CIUDADANADataSet = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSet()
        Me.EMPLEADO_SEGURIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLEADO_SEGURIDADTableAdapter = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.EMPLEADO_SEGURIDADTableAdapter()
        Me.TableAdapterManager = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager()
        Me.EMPLEADO_SEGURIDADBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EMPLEADO_SEGURIDADBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreETextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoETextBox = New System.Windows.Forms.TextBox()
        Me.DNIETextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoETextBox = New System.Windows.Forms.TextBox()
        Me.FInicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FFinDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdTipoTextBox = New System.Windows.Forms.TextBox()
        Me.SueldoTextBox = New System.Windows.Forms.TextBox()
        IdEmpleadoLabel = New System.Windows.Forms.Label()
        NombreELabel = New System.Windows.Forms.Label()
        ApellidoELabel = New System.Windows.Forms.Label()
        DNIELabel = New System.Windows.Forms.Label()
        TelefonoELabel = New System.Windows.Forms.Label()
        FInicioLabel = New System.Windows.Forms.Label()
        FFinLabel = New System.Windows.Forms.Label()
        IdTipoLabel = New System.Windows.Forms.Label()
        SueldoLabel = New System.Windows.Forms.Label()
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADO_SEGURIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADO_SEGURIDADBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EMPLEADO_SEGURIDADBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SEGURIDAD_CIUDADANADataSet
        '
        Me.SEGURIDAD_CIUDADANADataSet.DataSetName = "SEGURIDAD_CIUDADANADataSet"
        Me.SEGURIDAD_CIUDADANADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPLEADO_SEGURIDADBindingSource
        '
        Me.EMPLEADO_SEGURIDADBindingSource.DataMember = "EMPLEADO_SEGURIDAD"
        Me.EMPLEADO_SEGURIDADBindingSource.DataSource = Me.SEGURIDAD_CIUDADANADataSet
        '
        'EMPLEADO_SEGURIDADTableAdapter
        '
        Me.EMPLEADO_SEGURIDADTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.EMPLEADO_SEGURIDADTableAdapter = Me.EMPLEADO_SEGURIDADTableAdapter
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
        'EMPLEADO_SEGURIDADBindingNavigator
        '
        Me.EMPLEADO_SEGURIDADBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EMPLEADO_SEGURIDADBindingNavigator.BindingSource = Me.EMPLEADO_SEGURIDADBindingSource
        Me.EMPLEADO_SEGURIDADBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EMPLEADO_SEGURIDADBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EMPLEADO_SEGURIDADBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EMPLEADO_SEGURIDADBindingNavigatorSaveItem})
        Me.EMPLEADO_SEGURIDADBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EMPLEADO_SEGURIDADBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EMPLEADO_SEGURIDADBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EMPLEADO_SEGURIDADBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EMPLEADO_SEGURIDADBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EMPLEADO_SEGURIDADBindingNavigator.Name = "EMPLEADO_SEGURIDADBindingNavigator"
        Me.EMPLEADO_SEGURIDADBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EMPLEADO_SEGURIDADBindingNavigator.Size = New System.Drawing.Size(311, 25)
        Me.EMPLEADO_SEGURIDADBindingNavigator.TabIndex = 0
        Me.EMPLEADO_SEGURIDADBindingNavigator.Text = "BindingNavigator1"
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
        'EMPLEADO_SEGURIDADBindingNavigatorSaveItem
        '
        Me.EMPLEADO_SEGURIDADBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EMPLEADO_SEGURIDADBindingNavigatorSaveItem.Image = CType(resources.GetObject("EMPLEADO_SEGURIDADBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EMPLEADO_SEGURIDADBindingNavigatorSaveItem.Name = "EMPLEADO_SEGURIDADBindingNavigatorSaveItem"
        Me.EMPLEADO_SEGURIDADBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.EMPLEADO_SEGURIDADBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdEmpleadoLabel
        '
        IdEmpleadoLabel.AutoSize = True
        IdEmpleadoLabel.Location = New System.Drawing.Point(16, 32)
        IdEmpleadoLabel.Name = "IdEmpleadoLabel"
        IdEmpleadoLabel.Size = New System.Drawing.Size(69, 13)
        IdEmpleadoLabel.TabIndex = 1
        IdEmpleadoLabel.Text = "Id Empleado:"
        '
        'IdEmpleadoTextBox
        '
        Me.IdEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADO_SEGURIDADBindingSource, "IdEmpleado", True))
        Me.IdEmpleadoTextBox.Location = New System.Drawing.Point(91, 29)
        Me.IdEmpleadoTextBox.Name = "IdEmpleadoTextBox"
        Me.IdEmpleadoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdEmpleadoTextBox.TabIndex = 2
        '
        'NombreELabel
        '
        NombreELabel.AutoSize = True
        NombreELabel.Location = New System.Drawing.Point(16, 58)
        NombreELabel.Name = "NombreELabel"
        NombreELabel.Size = New System.Drawing.Size(57, 13)
        NombreELabel.TabIndex = 3
        NombreELabel.Text = "Nombre E:"
        '
        'NombreETextBox
        '
        Me.NombreETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADO_SEGURIDADBindingSource, "NombreE", True))
        Me.NombreETextBox.Location = New System.Drawing.Point(91, 55)
        Me.NombreETextBox.Name = "NombreETextBox"
        Me.NombreETextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreETextBox.TabIndex = 4
        '
        'ApellidoELabel
        '
        ApellidoELabel.AutoSize = True
        ApellidoELabel.Location = New System.Drawing.Point(16, 84)
        ApellidoELabel.Name = "ApellidoELabel"
        ApellidoELabel.Size = New System.Drawing.Size(57, 13)
        ApellidoELabel.TabIndex = 5
        ApellidoELabel.Text = "Apellido E:"
        '
        'ApellidoETextBox
        '
        Me.ApellidoETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADO_SEGURIDADBindingSource, "ApellidoE", True))
        Me.ApellidoETextBox.Location = New System.Drawing.Point(91, 81)
        Me.ApellidoETextBox.Name = "ApellidoETextBox"
        Me.ApellidoETextBox.Size = New System.Drawing.Size(200, 20)
        Me.ApellidoETextBox.TabIndex = 6
        '
        'DNIELabel
        '
        DNIELabel.AutoSize = True
        DNIELabel.Location = New System.Drawing.Point(16, 110)
        DNIELabel.Name = "DNIELabel"
        DNIELabel.Size = New System.Drawing.Size(36, 13)
        DNIELabel.TabIndex = 7
        DNIELabel.Text = "DNIE:"
        '
        'DNIETextBox
        '
        Me.DNIETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADO_SEGURIDADBindingSource, "DNIE", True))
        Me.DNIETextBox.Location = New System.Drawing.Point(91, 107)
        Me.DNIETextBox.Name = "DNIETextBox"
        Me.DNIETextBox.Size = New System.Drawing.Size(200, 20)
        Me.DNIETextBox.TabIndex = 8
        '
        'TelefonoELabel
        '
        TelefonoELabel.AutoSize = True
        TelefonoELabel.Location = New System.Drawing.Point(16, 136)
        TelefonoELabel.Name = "TelefonoELabel"
        TelefonoELabel.Size = New System.Drawing.Size(62, 13)
        TelefonoELabel.TabIndex = 9
        TelefonoELabel.Text = "Telefono E:"
        '
        'TelefonoETextBox
        '
        Me.TelefonoETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADO_SEGURIDADBindingSource, "TelefonoE", True))
        Me.TelefonoETextBox.Location = New System.Drawing.Point(91, 133)
        Me.TelefonoETextBox.Name = "TelefonoETextBox"
        Me.TelefonoETextBox.Size = New System.Drawing.Size(200, 20)
        Me.TelefonoETextBox.TabIndex = 10
        '
        'FInicioLabel
        '
        FInicioLabel.AutoSize = True
        FInicioLabel.Location = New System.Drawing.Point(16, 163)
        FInicioLabel.Name = "FInicioLabel"
        FInicioLabel.Size = New System.Drawing.Size(41, 13)
        FInicioLabel.TabIndex = 11
        FInicioLabel.Text = "FInicio:"
        '
        'FInicioDateTimePicker
        '
        Me.FInicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EMPLEADO_SEGURIDADBindingSource, "FInicio", True))
        Me.FInicioDateTimePicker.Location = New System.Drawing.Point(91, 159)
        Me.FInicioDateTimePicker.Name = "FInicioDateTimePicker"
        Me.FInicioDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FInicioDateTimePicker.TabIndex = 12
        '
        'FFinLabel
        '
        FFinLabel.AutoSize = True
        FFinLabel.Location = New System.Drawing.Point(16, 189)
        FFinLabel.Name = "FFinLabel"
        FFinLabel.Size = New System.Drawing.Size(30, 13)
        FFinLabel.TabIndex = 13
        FFinLabel.Text = "FFin:"
        '
        'FFinDateTimePicker
        '
        Me.FFinDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EMPLEADO_SEGURIDADBindingSource, "FFin", True))
        Me.FFinDateTimePicker.Location = New System.Drawing.Point(91, 185)
        Me.FFinDateTimePicker.Name = "FFinDateTimePicker"
        Me.FFinDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FFinDateTimePicker.TabIndex = 14
        '
        'IdTipoLabel
        '
        IdTipoLabel.AutoSize = True
        IdTipoLabel.Location = New System.Drawing.Point(16, 214)
        IdTipoLabel.Name = "IdTipoLabel"
        IdTipoLabel.Size = New System.Drawing.Size(43, 13)
        IdTipoLabel.TabIndex = 15
        IdTipoLabel.Text = "Id Tipo:"
        '
        'IdTipoTextBox
        '
        Me.IdTipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADO_SEGURIDADBindingSource, "IdTipo", True))
        Me.IdTipoTextBox.Location = New System.Drawing.Point(91, 211)
        Me.IdTipoTextBox.Name = "IdTipoTextBox"
        Me.IdTipoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTipoTextBox.TabIndex = 16
        '
        'SueldoLabel
        '
        SueldoLabel.AutoSize = True
        SueldoLabel.Location = New System.Drawing.Point(16, 240)
        SueldoLabel.Name = "SueldoLabel"
        SueldoLabel.Size = New System.Drawing.Size(43, 13)
        SueldoLabel.TabIndex = 17
        SueldoLabel.Text = "Sueldo:"
        '
        'SueldoTextBox
        '
        Me.SueldoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADO_SEGURIDADBindingSource, "Sueldo", True))
        Me.SueldoTextBox.Location = New System.Drawing.Point(91, 237)
        Me.SueldoTextBox.Name = "SueldoTextBox"
        Me.SueldoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SueldoTextBox.TabIndex = 18
        '
        'frmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 277)
        Me.Controls.Add(IdEmpleadoLabel)
        Me.Controls.Add(Me.IdEmpleadoTextBox)
        Me.Controls.Add(NombreELabel)
        Me.Controls.Add(Me.NombreETextBox)
        Me.Controls.Add(ApellidoELabel)
        Me.Controls.Add(Me.ApellidoETextBox)
        Me.Controls.Add(DNIELabel)
        Me.Controls.Add(Me.DNIETextBox)
        Me.Controls.Add(TelefonoELabel)
        Me.Controls.Add(Me.TelefonoETextBox)
        Me.Controls.Add(FInicioLabel)
        Me.Controls.Add(Me.FInicioDateTimePicker)
        Me.Controls.Add(FFinLabel)
        Me.Controls.Add(Me.FFinDateTimePicker)
        Me.Controls.Add(IdTipoLabel)
        Me.Controls.Add(Me.IdTipoTextBox)
        Me.Controls.Add(SueldoLabel)
        Me.Controls.Add(Me.SueldoTextBox)
        Me.Controls.Add(Me.EMPLEADO_SEGURIDADBindingNavigator)
        Me.Name = "frmEmpleado"
        Me.Text = "Empleado"
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADO_SEGURIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADO_SEGURIDADBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EMPLEADO_SEGURIDADBindingNavigator.ResumeLayout(False)
        Me.EMPLEADO_SEGURIDADBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SEGURIDAD_CIUDADANADataSet As SEGURIDAD_CIUDADANADataSet
    Friend WithEvents EMPLEADO_SEGURIDADBindingSource As BindingSource
    Friend WithEvents EMPLEADO_SEGURIDADTableAdapter As SEGURIDAD_CIUDADANADataSetTableAdapters.EMPLEADO_SEGURIDADTableAdapter
    Friend WithEvents TableAdapterManager As SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager
    Friend WithEvents EMPLEADO_SEGURIDADBindingNavigator As BindingNavigator
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
    Friend WithEvents EMPLEADO_SEGURIDADBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdEmpleadoTextBox As TextBox
    Friend WithEvents NombreETextBox As TextBox
    Friend WithEvents ApellidoETextBox As TextBox
    Friend WithEvents DNIETextBox As TextBox
    Friend WithEvents TelefonoETextBox As TextBox
    Friend WithEvents FInicioDateTimePicker As DateTimePicker
    Friend WithEvents FFinDateTimePicker As DateTimePicker
    Friend WithEvents IdTipoTextBox As TextBox
    Friend WithEvents SueldoTextBox As TextBox
End Class
