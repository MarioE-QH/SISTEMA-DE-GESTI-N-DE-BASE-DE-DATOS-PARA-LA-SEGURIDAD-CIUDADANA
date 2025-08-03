<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVistaSerenazgo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVistaSerenazgo))
        Me.SEGURIDAD_CIUDADANADataSet = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSet()
        Me.V_SERENAZGO_SEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_SERENAZGO_SETableAdapter = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.V_SERENAZGO_SETableAdapter()
        Me.TableAdapterManager = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager()
        Me.V_SERENAZGO_SEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.V_SERENAZGO_SEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.V_SERENAZGO_SEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_SERENAZGO_SEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_SERENAZGO_SEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.V_SERENAZGO_SEBindingNavigator.SuspendLayout()
        CType(Me.V_SERENAZGO_SEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SEGURIDAD_CIUDADANADataSet
        '
        Me.SEGURIDAD_CIUDADANADataSet.DataSetName = "SEGURIDAD_CIUDADANADataSet"
        Me.SEGURIDAD_CIUDADANADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'V_SERENAZGO_SEBindingSource
        '
        Me.V_SERENAZGO_SEBindingSource.DataMember = "V_SERENAZGO_SE"
        Me.V_SERENAZGO_SEBindingSource.DataSource = Me.SEGURIDAD_CIUDADANADataSet
        '
        'V_SERENAZGO_SETableAdapter
        '
        Me.V_SERENAZGO_SETableAdapter.ClearBeforeFill = True
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
        'V_SERENAZGO_SEBindingNavigator
        '
        Me.V_SERENAZGO_SEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.V_SERENAZGO_SEBindingNavigator.BindingSource = Me.V_SERENAZGO_SEBindingSource
        Me.V_SERENAZGO_SEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.V_SERENAZGO_SEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.V_SERENAZGO_SEBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.V_SERENAZGO_SEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.V_SERENAZGO_SEBindingNavigatorSaveItem})
        Me.V_SERENAZGO_SEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.V_SERENAZGO_SEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.V_SERENAZGO_SEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.V_SERENAZGO_SEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.V_SERENAZGO_SEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.V_SERENAZGO_SEBindingNavigator.Name = "V_SERENAZGO_SEBindingNavigator"
        Me.V_SERENAZGO_SEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.V_SERENAZGO_SEBindingNavigator.Size = New System.Drawing.Size(884, 27)
        Me.V_SERENAZGO_SEBindingNavigator.TabIndex = 0
        Me.V_SERENAZGO_SEBindingNavigator.Text = "BindingNavigator1"
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
        'V_SERENAZGO_SEBindingNavigatorSaveItem
        '
        Me.V_SERENAZGO_SEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.V_SERENAZGO_SEBindingNavigatorSaveItem.Enabled = False
        Me.V_SERENAZGO_SEBindingNavigatorSaveItem.Image = CType(resources.GetObject("V_SERENAZGO_SEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.V_SERENAZGO_SEBindingNavigatorSaveItem.Name = "V_SERENAZGO_SEBindingNavigatorSaveItem"
        Me.V_SERENAZGO_SEBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.V_SERENAZGO_SEBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'V_SERENAZGO_SEDataGridView
        '
        Me.V_SERENAZGO_SEDataGridView.AutoGenerateColumns = False
        Me.V_SERENAZGO_SEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.V_SERENAZGO_SEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.V_SERENAZGO_SEDataGridView.DataSource = Me.V_SERENAZGO_SEBindingSource
        Me.V_SERENAZGO_SEDataGridView.Location = New System.Drawing.Point(16, 34)
        Me.V_SERENAZGO_SEDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.V_SERENAZGO_SEDataGridView.Name = "V_SERENAZGO_SEDataGridView"
        Me.V_SERENAZGO_SEDataGridView.Size = New System.Drawing.Size(856, 345)
        Me.V_SERENAZGO_SEDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DNISerenazgo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DNISerenazgo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FEHCA NACIMIENTO"
        Me.DataGridViewTextBoxColumn4.HeaderText = "FEHCA NACIMIENTO"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "EDAD"
        Me.DataGridViewTextBoxColumn5.HeaderText = "EDAD"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SEXO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "SEXO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'frmVistaSerenazgo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 404)
        Me.Controls.Add(Me.V_SERENAZGO_SEDataGridView)
        Me.Controls.Add(Me.V_SERENAZGO_SEBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmVistaSerenazgo"
        Me.Text = "VistaSerenazgo"
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_SERENAZGO_SEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_SERENAZGO_SEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.V_SERENAZGO_SEBindingNavigator.ResumeLayout(False)
        Me.V_SERENAZGO_SEBindingNavigator.PerformLayout()
        CType(Me.V_SERENAZGO_SEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SEGURIDAD_CIUDADANADataSet As SEGURIDAD_CIUDADANADataSet
    Friend WithEvents V_SERENAZGO_SEBindingSource As BindingSource
    Friend WithEvents V_SERENAZGO_SETableAdapter As SEGURIDAD_CIUDADANADataSetTableAdapters.V_SERENAZGO_SETableAdapter
    Friend WithEvents TableAdapterManager As SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager
    Friend WithEvents V_SERENAZGO_SEBindingNavigator As BindingNavigator
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
    Friend WithEvents V_SERENAZGO_SEBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents V_SERENAZGO_SEDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
