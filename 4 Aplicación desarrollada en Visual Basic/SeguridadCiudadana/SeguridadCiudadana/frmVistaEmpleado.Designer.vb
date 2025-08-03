<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVistaEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVistaEmpleado))
        Me.V_EMPLEADOSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.V_EMPLEADOSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.V_EMPLEADOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.V_EMPLEADOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SEGURIDAD_CIUDADANADataSet = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSet()
        Me.V_EMPLEADOSTableAdapter = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.V_EMPLEADOSTableAdapter()
        Me.TableAdapterManager = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager()
        CType(Me.V_EMPLEADOSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.V_EMPLEADOSBindingNavigator.SuspendLayout()
        CType(Me.V_EMPLEADOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'V_EMPLEADOSBindingNavigator
        '
        Me.V_EMPLEADOSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.V_EMPLEADOSBindingNavigator.BindingSource = Me.V_EMPLEADOSBindingSource
        Me.V_EMPLEADOSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.V_EMPLEADOSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.V_EMPLEADOSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.V_EMPLEADOSBindingNavigatorSaveItem})
        Me.V_EMPLEADOSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.V_EMPLEADOSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.V_EMPLEADOSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.V_EMPLEADOSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.V_EMPLEADOSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.V_EMPLEADOSBindingNavigator.Name = "V_EMPLEADOSBindingNavigator"
        Me.V_EMPLEADOSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.V_EMPLEADOSBindingNavigator.Size = New System.Drawing.Size(694, 25)
        Me.V_EMPLEADOSBindingNavigator.TabIndex = 0
        Me.V_EMPLEADOSBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'V_EMPLEADOSBindingNavigatorSaveItem
        '
        Me.V_EMPLEADOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.V_EMPLEADOSBindingNavigatorSaveItem.Enabled = False
        Me.V_EMPLEADOSBindingNavigatorSaveItem.Image = CType(resources.GetObject("V_EMPLEADOSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.V_EMPLEADOSBindingNavigatorSaveItem.Name = "V_EMPLEADOSBindingNavigatorSaveItem"
        Me.V_EMPLEADOSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.V_EMPLEADOSBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'V_EMPLEADOSDataGridView
        '
        Me.V_EMPLEADOSDataGridView.AutoGenerateColumns = False
        Me.V_EMPLEADOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.V_EMPLEADOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.V_EMPLEADOSDataGridView.DataSource = Me.V_EMPLEADOSBindingSource
        Me.V_EMPLEADOSDataGridView.Location = New System.Drawing.Point(26, 67)
        Me.V_EMPLEADOSDataGridView.Name = "V_EMPLEADOSDataGridView"
        Me.V_EMPLEADOSDataGridView.Size = New System.Drawing.Size(656, 220)
        Me.V_EMPLEADOSDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "APELLIDOS"
        Me.DataGridViewTextBoxColumn2.HeaderText = "APELLIDOS"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DNI"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DNI"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PUESTO"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PUESTO"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SUELDO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SUELDO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TELEFONO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TELEFONO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "INICIO CONTRATO"
        Me.DataGridViewTextBoxColumn7.HeaderText = "INICIO CONTRATO"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FIN CONTRATO"
        Me.DataGridViewTextBoxColumn8.HeaderText = "FIN CONTRATO"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'V_EMPLEADOSBindingSource
        '
        Me.V_EMPLEADOSBindingSource.DataMember = "V_EMPLEADOS"
        Me.V_EMPLEADOSBindingSource.DataSource = Me.SEGURIDAD_CIUDADANADataSet
        '
        'SEGURIDAD_CIUDADANADataSet
        '
        Me.SEGURIDAD_CIUDADANADataSet.DataSetName = "SEGURIDAD_CIUDADANADataSet"
        Me.SEGURIDAD_CIUDADANADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'V_EMPLEADOSTableAdapter
        '
        Me.V_EMPLEADOSTableAdapter.ClearBeforeFill = True
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
        'frmVistaEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 323)
        Me.Controls.Add(Me.V_EMPLEADOSDataGridView)
        Me.Controls.Add(Me.V_EMPLEADOSBindingNavigator)
        Me.Name = "frmVistaEmpleado"
        Me.Text = "VistaEmpleado"
        CType(Me.V_EMPLEADOSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.V_EMPLEADOSBindingNavigator.ResumeLayout(False)
        Me.V_EMPLEADOSBindingNavigator.PerformLayout()
        CType(Me.V_EMPLEADOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SEGURIDAD_CIUDADANADataSet As SEGURIDAD_CIUDADANADataSet
    Friend WithEvents V_EMPLEADOSBindingSource As BindingSource
    Friend WithEvents V_EMPLEADOSTableAdapter As SEGURIDAD_CIUDADANADataSetTableAdapters.V_EMPLEADOSTableAdapter
    Friend WithEvents TableAdapterManager As SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager
    Friend WithEvents V_EMPLEADOSBindingNavigator As BindingNavigator
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
    Friend WithEvents V_EMPLEADOSBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents V_EMPLEADOSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
