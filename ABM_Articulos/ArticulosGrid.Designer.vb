<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticulosGrid
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
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.agregar = New System.Windows.Forms.Button
        Me.modificar = New System.Windows.Forms.Button
        Me.eliminar = New System.Windows.Forms.Button
        Me.salir = New System.Windows.Forms.Button
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UtilidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ArticulosCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripcionDataGridViewTextBoxColumn, Me.ArticuloDataGridViewTextBoxColumn, Me.UnidadDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.IvaDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.UtilidadDataGridViewTextBoxColumn, Me.VentaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ArticulosCollectionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(814, 135)
        Me.DataGridView1.TabIndex = 0
        '
        'agregar
        '
        Me.agregar.Location = New System.Drawing.Point(121, 212)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(103, 32)
        Me.agregar.TabIndex = 1
        Me.agregar.Text = "agregar"
        Me.agregar.UseVisualStyleBackColor = True
        '
        'modificar
        '
        Me.modificar.Location = New System.Drawing.Point(354, 212)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(119, 32)
        Me.modificar.TabIndex = 2
        Me.modificar.Text = "modificar"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'eliminar
        '
        Me.eliminar.Location = New System.Drawing.Point(121, 304)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(94, 37)
        Me.eliminar.TabIndex = 3
        Me.eliminar.Text = "eliminar"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(367, 306)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(106, 32)
        Me.salir.TabIndex = 4
        Me.salir.Text = "salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ArticuloDataGridViewTextBoxColumn
        '
        Me.ArticuloDataGridViewTextBoxColumn.DataPropertyName = "articulo"
        Me.ArticuloDataGridViewTextBoxColumn.HeaderText = "articulo"
        Me.ArticuloDataGridViewTextBoxColumn.Name = "ArticuloDataGridViewTextBoxColumn"
        Me.ArticuloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnidadDataGridViewTextBoxColumn
        '
        Me.UnidadDataGridViewTextBoxColumn.DataPropertyName = "unidad"
        Me.UnidadDataGridViewTextBoxColumn.HeaderText = "unidad"
        Me.UnidadDataGridViewTextBoxColumn.Name = "UnidadDataGridViewTextBoxColumn"
        Me.UnidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IvaDataGridViewTextBoxColumn
        '
        Me.IvaDataGridViewTextBoxColumn.DataPropertyName = "Iva"
        Me.IvaDataGridViewTextBoxColumn.HeaderText = "Iva"
        Me.IvaDataGridViewTextBoxColumn.Name = "IvaDataGridViewTextBoxColumn"
        Me.IvaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "Costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UtilidadDataGridViewTextBoxColumn
        '
        Me.UtilidadDataGridViewTextBoxColumn.DataPropertyName = "utilidad"
        Me.UtilidadDataGridViewTextBoxColumn.HeaderText = "utilidad"
        Me.UtilidadDataGridViewTextBoxColumn.Name = "UtilidadDataGridViewTextBoxColumn"
        Me.UtilidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VentaDataGridViewTextBoxColumn
        '
        Me.VentaDataGridViewTextBoxColumn.DataPropertyName = "venta"
        Me.VentaDataGridViewTextBoxColumn.HeaderText = "venta"
        Me.VentaDataGridViewTextBoxColumn.Name = "VentaDataGridViewTextBoxColumn"
        Me.VentaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ArticulosCollectionBindingSource
        '
        Me.ArticulosCollectionBindingSource.DataSource = GetType(WindowsApplication1.ArticulosCollection)
        '
        'ArticulosGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 568)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.eliminar)
        Me.Controls.Add(Me.modificar)
        Me.Controls.Add(Me.agregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ArticulosGrid"
        Me.Text = "ArticulosGrid"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents agregar As System.Windows.Forms.Button
    Friend WithEvents modificar As System.Windows.Forms.Button
    Friend WithEvents eliminar As System.Windows.Forms.Button
    Friend WithEvents salir As System.Windows.Forms.Button
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IvaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UtilidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArticulosCollectionBindingSource As System.Windows.Forms.BindingSource
End Class
