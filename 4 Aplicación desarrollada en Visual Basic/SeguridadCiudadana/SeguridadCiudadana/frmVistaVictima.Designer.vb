<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVistaVictima
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVistaVictima))
        Me.SEGURIDAD_CIUDADANADataSet = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSet()
        Me.V_VICTIMASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_VICTIMASTableAdapter = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.V_VICTIMASTableAdapter()
        Me.TableAdapterManager = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager()
        Me.V_VICTIMASBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.V_VICTIMASBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.V_VICTIMAS_MUJERESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_VICTIMAS_MUJERESTableAdapter = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.V_VICTIMAS_MUJERESTableAdapter()
        Me.V_VICTIMAS_MUJERESDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_VICTIMASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_VICTIMASBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.V_VICTIMASBindingNavigator.SuspendLayout()
        CType(Me.V_VICTIMAS_MUJERESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_VICTIMAS_MUJERESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SEGURIDAD_CIUDADANADataSet
        '
        Me.SEGURIDAD_CIUDADANADataSet.DataSetName = "SEGURIDAD_CIUDADANADataSet"
        Me.SEGURIDAD_CIUDADANADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'V_VICTIMASBindingSource
        '
        Me.V_VICTIMASBindingSource.DataMember = "V_VICTIMAS"
        Me.V_VICTIMASBindingSource.DataSource = Me.SEGURIDAD_CIUDADANADataSet
        '
        'V_VICTIMASTableAdapter
        '
        Me.V_VICTIMASTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AREA_SEGURIDADTableAdapter = Nothing
        Me.TableAdapterManager.ATENCION_VICTIMASTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CAMARATableAdapter = Nothing
        Me.TableAdapterManager.COMISARIATableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
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
        'V_VICTIMASBindingNavigator
        '
        Me.V_VICTIMASBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.V_VICTIMASBindingNavigator.BindingSource = Me.V_VICTIMASBindingSource
        Me.V_VICTIMASBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.V_VICTIMASBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.V_VICTIMASBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.V_VICTIMASBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.V_VICTIMASBindingNavigatorSaveItem})
        Me.V_VICTIMASBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.V_VICTIMASBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.V_VICTIMASBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.V_VICTIMASBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.V_VICTIMASBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.V_VICTIMASBindingNavigator.Name = "V_VICTIMASBindingNavigator"
        Me.V_VICTIMASBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.V_VICTIMASBindingNavigator.Size = New System.Drawing.Size(1290, 27)
        Me.V_VICTIMASBindingNavigator.TabIndex = 0
        Me.V_VICTIMASBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'V_VICTIMASBindingNavigatorSaveItem
        '
        Me.V_VICTIMASBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.V_VICTIMASBindingNavigatorSaveItem.Enabled = False
        Me.V_VICTIMASBindingNavigatorSaveItem.Image = CType(resources.GetObject("V_VICTIMASBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.V_VICTIMASBindingNavigatorSaveItem.Name = "V_VICTIMASBindingNavigatorSaveItem"
        Me.V_VICTIMASBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.V_VICTIMASBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'V_VICTIMAS_MUJERESBindingSource
        '
        Me.V_VICTIMAS_MUJERESBindingSource.DataMember = "V_VICTIMAS_MUJERES"
        Me.V_VICTIMAS_MUJERESBindingSource.DataSource = Me.SEGURIDAD_CIUDADANADataSet
        '
        'V_VICTIMAS_MUJERESTableAdapter
        '
        Me.V_VICTIMAS_MUJERESTableAdapter.ClearBeforeFill = True
        '
        'V_VICTIMAS_MUJERESDataGridView
        '
        Me.V_VICTIMAS_MUJERESDataGridView.AutoGenerateColumns = False
        Me.V_VICTIMAS_MUJERESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.V_VICTIMAS_MUJERESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.V_VICTIMAS_MUJERESDataGridView.DataSource = Me.V_VICTIMAS_MUJERESBindingSource
        Me.V_VICTIMAS_MUJERESDataGridView.Location = New System.Drawing.Point(50, 77)
        Me.V_VICTIMAS_MUJERESDataGridView.Name = "V_VICTIMAS_MUJERESDataGridView"
        Me.V_VICTIMAS_MUJERESDataGridView.RowTemplate.Height = 24
        Me.V_VICTIMAS_MUJERESDataGridView.Size = New System.Drawing.Size(1082, 220)
        Me.V_VICTIMAS_MUJERESDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "FECHA"
        Me.DataGridViewTextBoxColumn11.HeaderText = "FECHA"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "HORA"
        Me.DataGridViewTextBoxColumn12.HeaderText = "HORA"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn13.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "APELLIODS"
        Me.DataGridViewTextBoxColumn14.HeaderText = "APELLIODS"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "DNI"
        Me.DataGridViewTextBoxColumn15.HeaderText = "DNI"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "NACIMIENTO"
        Me.DataGridViewTextBoxColumn16.HeaderText = "NACIMIENTO"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "EDAD"
        Me.DataGridViewTextBoxColumn17.HeaderText = "EDAD"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "SEXO"
        Me.DataGridViewTextBoxColumn18.HeaderText = "SEXO"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "DELITO"
        Me.DataGridViewTextBoxColumn19.HeaderText = "DELITO"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "ESTADO VICTIMA"
        Me.DataGridViewTextBoxColumn20.HeaderText = "ESTADO VICTIMA"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'frmVistaVictima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1290, 591)
        Me.Controls.Add(Me.V_VICTIMAS_MUJERESDataGridView)
        Me.Controls.Add(Me.V_VICTIMASBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmVistaVictima"
        Me.Text = "VistaVictima"
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_VICTIMASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_VICTIMASBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.V_VICTIMASBindingNavigator.ResumeLayout(False)
        Me.V_VICTIMASBindingNavigator.PerformLayout()
        CType(Me.V_VICTIMAS_MUJERESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_VICTIMAS_MUJERESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SEGURIDAD_CIUDADANADataSet As SEGURIDAD_CIUDADANADataSet
    Friend WithEvents V_VICTIMASBindingSource As BindingSource
    Friend WithEvents V_VICTIMASTableAdapter As SEGURIDAD_CIUDADANADataSetTableAdapters.V_VICTIMASTableAdapter
    Friend WithEvents TableAdapterManager As SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager
    Friend WithEvents V_VICTIMASBindingNavigator As BindingNavigator
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
    Friend WithEvents V_VICTIMASBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents V_VICTIMAS_MUJERESBindingSource As BindingSource
    Friend WithEvents V_VICTIMAS_MUJERESTableAdapter As SEGURIDAD_CIUDADANADataSetTableAdapters.V_VICTIMAS_MUJERESTableAdapter
    Friend WithEvents V_VICTIMAS_MUJERESDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
End Class
