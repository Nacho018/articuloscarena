﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticuloForm
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
        Me.codigo = New System.Windows.Forms.Label
        Me.descripcion = New System.Windows.Forms.Label
        Me.unidad = New System.Windows.Forms.Label
        Me.stock = New System.Windows.Forms.Label
        Me.costo = New System.Windows.Forms.Label
        Me.aceptar = New System.Windows.Forms.Button
        Me.cancelar = New System.Windows.Forms.Button
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.iva = New System.Windows.Forms.Label
        Me.utilidad = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.venta = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.articulo = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'codigo
        '
        Me.codigo.AutoSize = True
        Me.codigo.Location = New System.Drawing.Point(63, 63)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(40, 13)
        Me.codigo.TabIndex = 0
        Me.codigo.Text = "Codigo"
        '
        'descripcion
        '
        Me.descripcion.AutoSize = True
        Me.descripcion.Location = New System.Drawing.Point(57, 110)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(63, 13)
        Me.descripcion.TabIndex = 1
        Me.descripcion.Text = "Descripcion"
        '
        'unidad
        '
        Me.unidad.AutoSize = True
        Me.unidad.Location = New System.Drawing.Point(57, 146)
        Me.unidad.Name = "unidad"
        Me.unidad.Size = New System.Drawing.Size(39, 13)
        Me.unidad.TabIndex = 2
        Me.unidad.Text = "unidad"
        '
        'stock
        '
        Me.stock.AutoSize = True
        Me.stock.Location = New System.Drawing.Point(63, 187)
        Me.stock.Name = "stock"
        Me.stock.Size = New System.Drawing.Size(33, 13)
        Me.stock.TabIndex = 3
        Me.stock.Text = "stock"
        '
        'costo
        '
        Me.costo.AutoSize = True
        Me.costo.Location = New System.Drawing.Point(63, 243)
        Me.costo.Name = "costo"
        Me.costo.Size = New System.Drawing.Size(33, 13)
        Me.costo.TabIndex = 4
        Me.costo.Text = "costo"
        '
        'aceptar
        '
        Me.aceptar.Location = New System.Drawing.Point(90, 440)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(122, 33)
        Me.aceptar.TabIndex = 8
        Me.aceptar.Text = "aceptar"
        Me.aceptar.UseVisualStyleBackColor = True
        '
        'cancelar
        '
        Me.cancelar.Location = New System.Drawing.Point(263, 440)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(107, 33)
        Me.cancelar.TabIndex = 9
        Me.cancelar.Text = "cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(154, 187)
        Me.TextBox3.MaxLength = 12
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(121, 20)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(154, 243)
        Me.TextBox4.MaxLength = 12
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(128, 20)
        Me.TextBox4.TabIndex = 14
        '
        'iva
        '
        Me.iva.AutoSize = True
        Me.iva.Location = New System.Drawing.Point(66, 284)
        Me.iva.Name = "iva"
        Me.iva.Size = New System.Drawing.Size(21, 13)
        Me.iva.TabIndex = 15
        Me.iva.Text = "iva"
        '
        'utilidad
        '
        Me.utilidad.AutoSize = True
        Me.utilidad.Location = New System.Drawing.Point(69, 325)
        Me.utilidad.Name = "utilidad"
        Me.utilidad.Size = New System.Drawing.Size(40, 13)
        Me.utilidad.TabIndex = 16
        Me.utilidad.Text = "utilidad"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"litros", "metros", "kilos"})
        Me.ComboBox1.Location = New System.Drawing.Point(160, 147)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(114, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"21%", "10,5%"})
        Me.ComboBox2.Location = New System.Drawing.Point(157, 287)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(117, 21)
        Me.ComboBox2.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(151, 60)
        Me.TextBox1.MaxLength = 12
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 19
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(157, 103)
        Me.TextBox2.MaxLength = 24
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(118, 20)
        Me.TextBox2.TabIndex = 20
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(151, 322)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(130, 20)
        Me.TextBox5.TabIndex = 21
        '
        'venta
        '
        Me.venta.AutoSize = True
        Me.venta.Location = New System.Drawing.Point(72, 360)
        Me.venta.Name = "venta"
        Me.venta.Size = New System.Drawing.Size(34, 13)
        Me.venta.TabIndex = 22
        Me.venta.Text = "venta"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(157, 364)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(135, 20)
        Me.TextBox6.TabIndex = 23
        '
        'articulo
        '
        Me.articulo.AutoSize = True
        Me.articulo.Location = New System.Drawing.Point(68, 23)
        Me.articulo.Name = "articulo"
        Me.articulo.Size = New System.Drawing.Size(41, 13)
        Me.articulo.TabIndex = 24
        Me.articulo.Text = "articulo"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(160, 20)
        Me.TextBox7.MaxLength = 12
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(104, 20)
        Me.TextBox7.TabIndex = 25
        '
        'ArticuloForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 485)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.articulo)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.venta)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.utilidad)
        Me.Controls.Add(Me.iva)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.costo)
        Me.Controls.Add(Me.stock)
        Me.Controls.Add(Me.unidad)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.codigo)
        Me.Name = "ArticuloForm"
        Me.Text = "ArticuloForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents codigo As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.Label
    Friend WithEvents unidad As System.Windows.Forms.Label
    Friend WithEvents stock As System.Windows.Forms.Label
    Friend WithEvents costo As System.Windows.Forms.Label
    Friend WithEvents aceptar As System.Windows.Forms.Button
    Friend WithEvents cancelar As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents iva As System.Windows.Forms.Label
    Friend WithEvents utilidad As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents venta As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents articulo As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox

End Class
