<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticulosForm
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
        Me.aceptar = New System.Windows.Forms.Button
        Me.cancelar = New System.Windows.Forms.Button
        Me.codigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.descripcion = New System.Windows.Forms.TextBox
        Me.Stock = New System.Windows.Forms.TextBox
        Me.Costo = New System.Windows.Forms.TextBox
        Me.utilidad = New System.Windows.Forms.TextBox
        Me.venta = New System.Windows.Forms.TextBox
        Me.iva = New System.Windows.Forms.ComboBox
        Me.unidad = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'aceptar
        '
        Me.aceptar.Location = New System.Drawing.Point(103, 367)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(75, 23)
        Me.aceptar.TabIndex = 0
        Me.aceptar.Text = "Aceptar"
        Me.aceptar.UseVisualStyleBackColor = True
        '
        'cancelar
        '
        Me.cancelar.Location = New System.Drawing.Point(217, 367)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cancelar.TabIndex = 1
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(125, 60)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(167, 20)
        Me.codigo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Codigo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Unidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Costo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Descripcion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Stock"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Iva"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Utilidad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Venta"
        '
        'descripcion
        '
        Me.descripcion.Location = New System.Drawing.Point(125, 23)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(167, 20)
        Me.descripcion.TabIndex = 13
        '
        'Stock
        '
        Me.Stock.Location = New System.Drawing.Point(125, 168)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(167, 20)
        Me.Stock.TabIndex = 15
        '
        'Costo
        '
        Me.Costo.Location = New System.Drawing.Point(125, 194)
        Me.Costo.Name = "Costo"
        Me.Costo.Size = New System.Drawing.Size(167, 20)
        Me.Costo.TabIndex = 16
        '
        'utilidad
        '
        Me.utilidad.Location = New System.Drawing.Point(125, 283)
        Me.utilidad.Name = "utilidad"
        Me.utilidad.Size = New System.Drawing.Size(167, 20)
        Me.utilidad.TabIndex = 18
        '
        'venta
        '
        Me.venta.Location = New System.Drawing.Point(125, 315)
        Me.venta.Name = "venta"
        Me.venta.Size = New System.Drawing.Size(167, 20)
        Me.venta.TabIndex = 19
        '
        'iva
        '
        Me.iva.FormattingEnabled = True
        Me.iva.Items.AddRange(New Object() {"10,50", "21,00"})
        Me.iva.Location = New System.Drawing.Point(125, 247)
        Me.iva.Name = "iva"
        Me.iva.Size = New System.Drawing.Size(121, 21)
        Me.iva.TabIndex = 20
        '
        'unidad
        '
        Me.unidad.FormattingEnabled = True
        Me.unidad.Items.AddRange(New Object() {"Kilos" & Global.Microsoft.VisualBasic.ChrW(9), "Metros" & Global.Microsoft.VisualBasic.ChrW(9), "Litros"})
        Me.unidad.Location = New System.Drawing.Point(125, 95)
        Me.unidad.Name = "unidad"
        Me.unidad.Size = New System.Drawing.Size(121, 21)
        Me.unidad.TabIndex = 21
        '
        'ArticulosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 402)
        Me.Controls.Add(Me.unidad)
        Me.Controls.Add(Me.iva)
        Me.Controls.Add(Me.venta)
        Me.Controls.Add(Me.utilidad)
        Me.Controls.Add(Me.Costo)
        Me.Controls.Add(Me.Stock)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.aceptar)
        Me.Name = "ArticulosForm"
        Me.Text = "AriculosForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents aceptar As System.Windows.Forms.Button
    Friend WithEvents cancelar As System.Windows.Forms.Button
    Friend WithEvents codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Stock As System.Windows.Forms.TextBox
    Friend WithEvents Costo As System.Windows.Forms.TextBox
    Friend WithEvents utilidad As System.Windows.Forms.TextBox
    Friend WithEvents venta As System.Windows.Forms.TextBox
    Friend WithEvents iva As System.Windows.Forms.ComboBox
    Friend WithEvents unidad As System.Windows.Forms.ComboBox

End Class
