<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVideovigilancia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVideovigilancia))
        Dim IdVigilanciaLabel As System.Windows.Forms.Label
        Dim IdVOLabel As System.Windows.Forms.Label
        Dim IdServicioLabel As System.Windows.Forms.Label
        Dim IdMunicipalidadLabel As System.Windows.Forms.Label
        Dim CodOperacionLabel As System.Windows.Forms.Label
        Me.SEGURIDAD_CIUDADANADataSet = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSet()
        Me.VIDEOVIGILANCIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VIDEOVIGILANCIATableAdapter = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.VIDEOVIGILANCIATableAdapter()
        Me.TableAdapterManager = New SeguridadCiudadana.SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager()
        Me.VIDEOVIGILANCIABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VIDEOVIGILANCIABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdVigilanciaTextBox = New System.Windows.Forms.TextBox()
        Me.IdVOTextBox = New System.Windows.Forms.TextBox()
        Me.IdServicioTextBox = New System.Windows.Forms.TextBox()
        Me.IdMunicipalidadTextBox = New System.Windows.Forms.TextBox()
        Me.CodOperacionTextBox = New System.Windows.Forms.TextBox()
        IdVigilanciaLabel = New System.Windows.Forms.Label()
        IdVOLabel = New System.Windows.Forms.Label()
        IdServicioLabel = New System.Windows.Forms.Label()
        IdMunicipalidadLabel = New System.Windows.Forms.Label()
        CodOperacionLabel = New System.Windows.Forms.Label()
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VIDEOVIGILANCIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VIDEOVIGILANCIABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VIDEOVIGILANCIABindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SEGURIDAD_CIUDADANADataSet
        '
        Me.SEGURIDAD_CIUDADANADataSet.DataSetName = "SEGURIDAD_CIUDADANADataSet"
        Me.SEGURIDAD_CIUDADANADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VIDEOVIGILANCIABindingSource
        '
        Me.VIDEOVIGILANCIABindingSource.DataMember = "VIDEOVIGILANCIA"
        Me.VIDEOVIGILANCIABindingSource.DataSource = Me.SEGURIDAD_CIUDADANADataSet
        '
        'VIDEOVIGILANCIATableAdapter
        '
        Me.VIDEOVIGILANCIATableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.VEHICULOSTableAdapter = Nothing
        Me.TableAdapterManager.VICTIMATableAdapter = Nothing
        Me.TableAdapterManager.VIDEO_OPERADORTableAdapter = Nothing
        Me.TableAdapterManager.VIDEOVIGILANCIATableAdapter = Me.VIDEOVIGILANCIATableAdapter
        '
        'VIDEOVIGILANCIABindingNavigator
        '
        Me.VIDEOVIGILANCIABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VIDEOVIGILANCIABindingNavigator.BindingSource = Me.VIDEOVIGILANCIABindingSource
        Me.VIDEOVIGILANCIABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VIDEOVIGILANCIABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VIDEOVIGILANCIABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VIDEOVIGILANCIABindingNavigatorSaveItem})
        Me.VIDEOVIGILANCIABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VIDEOVIGILANCIABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VIDEOVIGILANCIABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VIDEOVIGILANCIABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VIDEOVIGILANCIABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VIDEOVIGILANCIABindingNavigator.Name = "VIDEOVIGILANCIABindingNavigator"
        Me.VIDEOVIGILANCIABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VIDEOVIGILANCIABindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.VIDEOVIGILANCIABindingNavigator.TabIndex = 0
        Me.VIDEOVIGILANCIABindingNavigator.Text = "BindingNavigator1"
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
        'VIDEOVIGILANCIABindingNavigatorSaveItem
        '
        Me.VIDEOVIGILANCIABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VIDEOVIGILANCIABindingNavigatorSaveItem.Image = CType(resources.GetObject("VIDEOVIGILANCIABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VIDEOVIGILANCIABindingNavigatorSaveItem.Name = "VIDEOVIGILANCIABindingNavigatorSaveItem"
        Me.VIDEOVIGILANCIABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.VIDEOVIGILANCIABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdVigilanciaLabel
        '
        IdVigilanciaLabel.AutoSize = True
        IdVigilanciaLabel.Location = New System.Drawing.Point(8, 41)
        IdVigilanciaLabel.Name = "IdVigilanciaLabel"
        IdVigilanciaLabel.Size = New System.Drawing.Size(67, 13)
        IdVigilanciaLabel.TabIndex = 1
        IdVigilanciaLabel.Text = "Id Vigilancia:"
        '
        'IdVigilanciaTextBox
        '
        Me.IdVigilanciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIDEOVIGILANCIABindingSource, "IdVigilancia", True))
        Me.IdVigilanciaTextBox.Location = New System.Drawing.Point(101, 38)
        Me.IdVigilanciaTextBox.Name = "IdVigilanciaTextBox"
        Me.IdVigilanciaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdVigilanciaTextBox.TabIndex = 2
        '
        'IdVOLabel
        '
        IdVOLabel.AutoSize = True
        IdVOLabel.Location = New System.Drawing.Point(8, 67)
        IdVOLabel.Name = "IdVOLabel"
        IdVOLabel.Size = New System.Drawing.Size(37, 13)
        IdVOLabel.TabIndex = 3
        IdVOLabel.Text = "Id VO:"
        '
        'IdVOTextBox
        '
        Me.IdVOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIDEOVIGILANCIABindingSource, "IdVO", True))
        Me.IdVOTextBox.Location = New System.Drawing.Point(101, 64)
        Me.IdVOTextBox.Name = "IdVOTextBox"
        Me.IdVOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdVOTextBox.TabIndex = 4
        '
        'IdServicioLabel
        '
        IdServicioLabel.AutoSize = True
        IdServicioLabel.Location = New System.Drawing.Point(8, 93)
        IdServicioLabel.Name = "IdServicioLabel"
        IdServicioLabel.Size = New System.Drawing.Size(60, 13)
        IdServicioLabel.TabIndex = 5
        IdServicioLabel.Text = "Id Servicio:"
        '
        'IdServicioTextBox
        '
        Me.IdServicioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIDEOVIGILANCIABindingSource, "IdServicio", True))
        Me.IdServicioTextBox.Location = New System.Drawing.Point(101, 90)
        Me.IdServicioTextBox.Name = "IdServicioTextBox"
        Me.IdServicioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdServicioTextBox.TabIndex = 6
        '
        'IdMunicipalidadLabel
        '
        IdMunicipalidadLabel.AutoSize = True
        IdMunicipalidadLabel.Location = New System.Drawing.Point(8, 119)
        IdMunicipalidadLabel.Name = "IdMunicipalidadLabel"
        IdMunicipalidadLabel.Size = New System.Drawing.Size(87, 13)
        IdMunicipalidadLabel.TabIndex = 7
        IdMunicipalidadLabel.Text = "Id Municipalidad:"
        '
        'IdMunicipalidadTextBox
        '
        Me.IdMunicipalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIDEOVIGILANCIABindingSource, "IdMunicipalidad", True))
        Me.IdMunicipalidadTextBox.Location = New System.Drawing.Point(101, 116)
        Me.IdMunicipalidadTextBox.Name = "IdMunicipalidadTextBox"
        Me.IdMunicipalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdMunicipalidadTextBox.TabIndex = 8
        '
        'CodOperacionLabel
        '
        CodOperacionLabel.AutoSize = True
        CodOperacionLabel.Location = New System.Drawing.Point(8, 145)
        CodOperacionLabel.Name = "CodOperacionLabel"
        CodOperacionLabel.Size = New System.Drawing.Size(81, 13)
        CodOperacionLabel.TabIndex = 9
        CodOperacionLabel.Text = "Cod Operacion:"
        '
        'CodOperacionTextBox
        '
        Me.CodOperacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIDEOVIGILANCIABindingSource, "CodOperacion", True))
        Me.CodOperacionTextBox.Location = New System.Drawing.Point(101, 142)
        Me.CodOperacionTextBox.Name = "CodOperacionTextBox"
        Me.CodOperacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodOperacionTextBox.TabIndex = 10
        '
        'frmVideovigilancia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(IdVigilanciaLabel)
        Me.Controls.Add(Me.IdVigilanciaTextBox)
        Me.Controls.Add(IdVOLabel)
        Me.Controls.Add(Me.IdVOTextBox)
        Me.Controls.Add(IdServicioLabel)
        Me.Controls.Add(Me.IdServicioTextBox)
        Me.Controls.Add(IdMunicipalidadLabel)
        Me.Controls.Add(Me.IdMunicipalidadTextBox)
        Me.Controls.Add(CodOperacionLabel)
        Me.Controls.Add(Me.CodOperacionTextBox)
        Me.Controls.Add(Me.VIDEOVIGILANCIABindingNavigator)
        Me.Name = "frmVideovigilancia"
        Me.Text = "frmVideovigilancia"
        CType(Me.SEGURIDAD_CIUDADANADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VIDEOVIGILANCIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VIDEOVIGILANCIABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VIDEOVIGILANCIABindingNavigator.ResumeLayout(False)
        Me.VIDEOVIGILANCIABindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SEGURIDAD_CIUDADANADataSet As SEGURIDAD_CIUDADANADataSet
    Friend WithEvents VIDEOVIGILANCIABindingSource As BindingSource
    Friend WithEvents VIDEOVIGILANCIATableAdapter As SEGURIDAD_CIUDADANADataSetTableAdapters.VIDEOVIGILANCIATableAdapter
    Friend WithEvents TableAdapterManager As SEGURIDAD_CIUDADANADataSetTableAdapters.TableAdapterManager
    Friend WithEvents VIDEOVIGILANCIABindingNavigator As BindingNavigator
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
    Friend WithEvents VIDEOVIGILANCIABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdVigilanciaTextBox As TextBox
    Friend WithEvents IdVOTextBox As TextBox
    Friend WithEvents IdServicioTextBox As TextBox
    Friend WithEvents IdMunicipalidadTextBox As TextBox
    Friend WithEvents CodOperacionTextBox As TextBox
End Class
