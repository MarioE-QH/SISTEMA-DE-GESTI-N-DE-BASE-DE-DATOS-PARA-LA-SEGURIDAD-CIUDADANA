<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSerenazgo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSerenazgo))
        Dim IdSerenazgoLabel As System.Windows.Forms.Label
        Dim NombreSerenoLabel As System.Windows.Forms.Label
        Dim ApellidoSerenoLabel As System.Windows.Forms.Label
        Dim DNISerenazgoLabel As System.Windows.Forms.Label
        Dim TelefonoSerenoLabel As System.Windows.Forms.Label
        Dim FechaNacimientoSerenoLabel As System.Windows.Forms.Label
        Dim FechaInicioSerenoLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim IdPatrullaLabel As System.Windows.Forms.Label
        Me.SEGURIDAD_CIUDADANADataSet = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSet()
        Me.SERENAZGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SERENAZGOTableAdapter = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.SERENAZGOTableAdapter()
        Me.TableAdapterManager = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager()
        Me.SERENAZGOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SERENAZGOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdSerenazgoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreSerenoTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoSerenoTextBox = New System.Windows.Forms.TextBox()
        Me.DNISerenazgoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoSerenoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaNacimientoSerenoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaInicioSerenoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SexoTextBox = New System.Windows.Forms.TextBox()
        Me.IdPatrullaTextBox = New System.Windows.Forms.TextBox()
        IdSerenazgoLabel = New System.Windows.Forms.Label()
        NombreSerenoLabel = New System.Windows.Forms.Label()
        ApellidoSerenoLabel = New System.Windows.Forms.Label()
        DNISerenazgoLabel = New System.Windows.Forms.Label()
        TelefonoSerenoLabel = New System.Windows.Forms.Label()
        FechaNacimientoSerenoLabel = New System.Windows.Forms.Label()
        FechaInicioSerenoLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        IdPatrullaLabel = New System.Windows.Forms.Label()
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERENAZGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERENAZGOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SERENAZGOBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SEGURIDAD_CIUDADANADataSet
        '
        Me.SEGURIDAD_CIUDADANADataSet.DataSetName = "SEGURIDAD_CIUDADANADataSet"
        Me.SEGURIDAD_CIUDADANADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SERENAZGOBindingSource
        '
        Me.SERENAZGOBindingSource.DataMember = "SERENAZGO"
        Me.SERENAZGOBindingSource.DataSource = Me.SEGURIDAD_CIUDADANADataSet
        '
        'SERENAZGOTableAdapter
        '
        Me.SERENAZGOTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.SERENAZGOTableAdapter = Me.SERENAZGOTableAdapter
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
        'SERENAZGOBindingNavigator
        '
        Me.SERENAZGOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SERENAZGOBindingNavigator.BindingSource = Me.SERENAZGOBindingSource
        Me.SERENAZGOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SERENAZGOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SERENAZGOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SERENAZGOBindingNavigatorSaveItem})
        Me.SERENAZGOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SERENAZGOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SERENAZGOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SERENAZGOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SERENAZGOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SERENAZGOBindingNavigator.Name = "SERENAZGOBindingNavigator"
        Me.SERENAZGOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SERENAZGOBindingNavigator.Size = New System.Drawing.Size(362, 25)
        Me.SERENAZGOBindingNavigator.TabIndex = 0
        Me.SERENAZGOBindingNavigator.Text = "BindingNavigator1"
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
        'SERENAZGOBindingNavigatorSaveItem
        '
        Me.SERENAZGOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SERENAZGOBindingNavigatorSaveItem.Image = CType(resources.GetObject("SERENAZGOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SERENAZGOBindingNavigatorSaveItem.Name = "SERENAZGOBindingNavigatorSaveItem"
        Me.SERENAZGOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.SERENAZGOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdSerenazgoLabel
        '
        IdSerenazgoLabel.AutoSize = True
        IdSerenazgoLabel.Location = New System.Drawing.Point(11, 31)
        IdSerenazgoLabel.Name = "IdSerenazgoLabel"
        IdSerenazgoLabel.Size = New System.Drawing.Size(73, 13)
        IdSerenazgoLabel.TabIndex = 1
        IdSerenazgoLabel.Text = "Id Serenazgo:"
        '
        'IdSerenazgoTextBox
        '
        Me.IdSerenazgoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SERENAZGOBindingSource, "IdSerenazgo", True))
        Me.IdSerenazgoTextBox.Location = New System.Drawing.Point(150, 28)
        Me.IdSerenazgoTextBox.Name = "IdSerenazgoTextBox"
        Me.IdSerenazgoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdSerenazgoTextBox.TabIndex = 2
        '
        'NombreSerenoLabel
        '
        NombreSerenoLabel.AutoSize = True
        NombreSerenoLabel.Location = New System.Drawing.Point(11, 57)
        NombreSerenoLabel.Name = "NombreSerenoLabel"
        NombreSerenoLabel.Size = New System.Drawing.Size(84, 13)
        NombreSerenoLabel.TabIndex = 3
        NombreSerenoLabel.Text = "Nombre Sereno:"
        '
        'NombreSerenoTextBox
        '
        Me.NombreSerenoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SERENAZGOBindingSource, "NombreSereno", True))
        Me.NombreSerenoTextBox.Location = New System.Drawing.Point(150, 54)
        Me.NombreSerenoTextBox.Name = "NombreSerenoTextBox"
        Me.NombreSerenoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreSerenoTextBox.TabIndex = 4
        '
        'ApellidoSerenoLabel
        '
        ApellidoSerenoLabel.AutoSize = True
        ApellidoSerenoLabel.Location = New System.Drawing.Point(11, 83)
        ApellidoSerenoLabel.Name = "ApellidoSerenoLabel"
        ApellidoSerenoLabel.Size = New System.Drawing.Size(84, 13)
        ApellidoSerenoLabel.TabIndex = 5
        ApellidoSerenoLabel.Text = "Apellido Sereno:"
        '
        'ApellidoSerenoTextBox
        '
        Me.ApellidoSerenoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SERENAZGOBindingSource, "ApellidoSereno", True))
        Me.ApellidoSerenoTextBox.Location = New System.Drawing.Point(150, 80)
        Me.ApellidoSerenoTextBox.Name = "ApellidoSerenoTextBox"
        Me.ApellidoSerenoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ApellidoSerenoTextBox.TabIndex = 6
        '
        'DNISerenazgoLabel
        '
        DNISerenazgoLabel.AutoSize = True
        DNISerenazgoLabel.Location = New System.Drawing.Point(11, 109)
        DNISerenazgoLabel.Name = "DNISerenazgoLabel"
        DNISerenazgoLabel.Size = New System.Drawing.Size(80, 13)
        DNISerenazgoLabel.TabIndex = 7
        DNISerenazgoLabel.Text = "DNISerenazgo:"
        '
        'DNISerenazgoTextBox
        '
        Me.DNISerenazgoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SERENAZGOBindingSource, "DNISerenazgo", True))
        Me.DNISerenazgoTextBox.Location = New System.Drawing.Point(150, 106)
        Me.DNISerenazgoTextBox.Name = "DNISerenazgoTextBox"
        Me.DNISerenazgoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DNISerenazgoTextBox.TabIndex = 8
        '
        'TelefonoSerenoLabel
        '
        TelefonoSerenoLabel.AutoSize = True
        TelefonoSerenoLabel.Location = New System.Drawing.Point(11, 135)
        TelefonoSerenoLabel.Name = "TelefonoSerenoLabel"
        TelefonoSerenoLabel.Size = New System.Drawing.Size(89, 13)
        TelefonoSerenoLabel.TabIndex = 9
        TelefonoSerenoLabel.Text = "Telefono Sereno:"
        '
        'TelefonoSerenoTextBox
        '
        Me.TelefonoSerenoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SERENAZGOBindingSource, "TelefonoSereno", True))
        Me.TelefonoSerenoTextBox.Location = New System.Drawing.Point(150, 132)
        Me.TelefonoSerenoTextBox.Name = "TelefonoSerenoTextBox"
        Me.TelefonoSerenoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TelefonoSerenoTextBox.TabIndex = 10
        '
        'FechaNacimientoSerenoLabel
        '
        FechaNacimientoSerenoLabel.AutoSize = True
        FechaNacimientoSerenoLabel.Location = New System.Drawing.Point(11, 162)
        FechaNacimientoSerenoLabel.Name = "FechaNacimientoSerenoLabel"
        FechaNacimientoSerenoLabel.Size = New System.Drawing.Size(133, 13)
        FechaNacimientoSerenoLabel.TabIndex = 11
        FechaNacimientoSerenoLabel.Text = "Fecha Nacimiento Sereno:"
        '
        'FechaNacimientoSerenoDateTimePicker
        '
        Me.FechaNacimientoSerenoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SERENAZGOBindingSource, "FechaNacimientoSereno", True))
        Me.FechaNacimientoSerenoDateTimePicker.Location = New System.Drawing.Point(150, 158)
        Me.FechaNacimientoSerenoDateTimePicker.Name = "FechaNacimientoSerenoDateTimePicker"
        Me.FechaNacimientoSerenoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaNacimientoSerenoDateTimePicker.TabIndex = 12
        '
        'FechaInicioSerenoLabel
        '
        FechaInicioSerenoLabel.AutoSize = True
        FechaInicioSerenoLabel.Location = New System.Drawing.Point(11, 188)
        FechaInicioSerenoLabel.Name = "FechaInicioSerenoLabel"
        FechaInicioSerenoLabel.Size = New System.Drawing.Size(105, 13)
        FechaInicioSerenoLabel.TabIndex = 13
        FechaInicioSerenoLabel.Text = "Fecha Inicio Sereno:"
        '
        'FechaInicioSerenoDateTimePicker
        '
        Me.FechaInicioSerenoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SERENAZGOBindingSource, "FechaInicioSereno", True))
        Me.FechaInicioSerenoDateTimePicker.Location = New System.Drawing.Point(150, 184)
        Me.FechaInicioSerenoDateTimePicker.Name = "FechaInicioSerenoDateTimePicker"
        Me.FechaInicioSerenoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaInicioSerenoDateTimePicker.TabIndex = 14
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Location = New System.Drawing.Point(11, 213)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(34, 13)
        SexoLabel.TabIndex = 15
        SexoLabel.Text = "Sexo:"
        '
        'SexoTextBox
        '
        Me.SexoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SERENAZGOBindingSource, "Sexo", True))
        Me.SexoTextBox.Location = New System.Drawing.Point(150, 210)
        Me.SexoTextBox.Name = "SexoTextBox"
        Me.SexoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SexoTextBox.TabIndex = 16
        '
        'IdPatrullaLabel
        '
        IdPatrullaLabel.AutoSize = True
        IdPatrullaLabel.Location = New System.Drawing.Point(11, 239)
        IdPatrullaLabel.Name = "IdPatrullaLabel"
        IdPatrullaLabel.Size = New System.Drawing.Size(57, 13)
        IdPatrullaLabel.TabIndex = 17
        IdPatrullaLabel.Text = "Id Patrulla:"
        '
        'IdPatrullaTextBox
        '
        Me.IdPatrullaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SERENAZGOBindingSource, "IdPatrulla", True))
        Me.IdPatrullaTextBox.Location = New System.Drawing.Point(150, 236)
        Me.IdPatrullaTextBox.Name = "IdPatrullaTextBox"
        Me.IdPatrullaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdPatrullaTextBox.TabIndex = 18
        '
        'frmSerenazgo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 261)
        Me.Controls.Add(IdSerenazgoLabel)
        Me.Controls.Add(Me.IdSerenazgoTextBox)
        Me.Controls.Add(NombreSerenoLabel)
        Me.Controls.Add(Me.NombreSerenoTextBox)
        Me.Controls.Add(ApellidoSerenoLabel)
        Me.Controls.Add(Me.ApellidoSerenoTextBox)
        Me.Controls.Add(DNISerenazgoLabel)
        Me.Controls.Add(Me.DNISerenazgoTextBox)
        Me.Controls.Add(TelefonoSerenoLabel)
        Me.Controls.Add(Me.TelefonoSerenoTextBox)
        Me.Controls.Add(FechaNacimientoSerenoLabel)
        Me.Controls.Add(Me.FechaNacimientoSerenoDateTimePicker)
        Me.Controls.Add(FechaInicioSerenoLabel)
        Me.Controls.Add(Me.FechaInicioSerenoDateTimePicker)
        Me.Controls.Add(SexoLabel)
        Me.Controls.Add(Me.SexoTextBox)
        Me.Controls.Add(IdPatrullaLabel)
        Me.Controls.Add(Me.IdPatrullaTextBox)
        Me.Controls.Add(Me.SERENAZGOBindingNavigator)
        Me.Name = "frmSerenazgo"
        Me.Text = "Serenazgo"
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERENAZGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERENAZGOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SERENAZGOBindingNavigator.ResumeLayout(False)
        Me.SERENAZGOBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SEGURIDAD_CIUDADANADataSet As SEGURIDAD_CIUDADANADataSet
    Friend WithEvents SERENAZGOBindingSource As BindingSource
    Friend WithEvents SERENAZGOTableAdapter As SEGURIDAD_CIUDADANADataSetTableAdapters.SERENAZGOTableAdapter
    Friend WithEvents TableAdapterManager As SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager
    Friend WithEvents SERENAZGOBindingNavigator As BindingNavigator
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
    Friend WithEvents SERENAZGOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdSerenazgoTextBox As TextBox
    Friend WithEvents NombreSerenoTextBox As TextBox
    Friend WithEvents ApellidoSerenoTextBox As TextBox
    Friend WithEvents DNISerenazgoTextBox As TextBox
    Friend WithEvents TelefonoSerenoTextBox As TextBox
    Friend WithEvents FechaNacimientoSerenoDateTimePicker As DateTimePicker
    Friend WithEvents FechaInicioSerenoDateTimePicker As DateTimePicker
    Friend WithEvents SexoTextBox As TextBox
    Friend WithEvents IdPatrullaTextBox As TextBox
End Class
