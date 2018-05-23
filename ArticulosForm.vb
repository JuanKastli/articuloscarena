Public Class ArticulosForm
    Dim operacion_ As String
    Dim MiArticulo As New ArticuloClass
    Dim indice_ As Byte
    Public Property operacion() As String
        Get
            Return operacion_

        End Get

        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property
    Public Property indice() As String
        Get
            Return indice_

        End Get

        Set(ByVal value As String)
            indice_ = value
        End Set
    End Property

    Private Sub aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aceptar.Click

        MiArticulo.Codigo = (codigo.Text)
        MiArticulo.Unidad = unidad.SelectedItem
        MiArticulo.Descripcion = descripcion.Text
        MiArticulo.Stock = CInt(Stock.Text)
        MiArticulo.Iva = iva.SelectedIndex
        MiArticulo.Unidad = unidad.Text
        MiArticulo.Costo = Costo.Text

        Select Case operacion_
            Case "NUEVO"
                lst.Add(MiArticulo)

            Case "ELIMINA"
                lst.RemoveAt(indice_)

            Case "MODIFICA"
                lst.Item(indice_) = MiArticulo

                ArticulosGrid.DataGridView1.Refresh()
        End Select
        Me.Close()
    End Sub


    Private Sub descripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles descripcion.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

            e.Handled = False
        Else

            e.Handled = True
        End If
    End Sub

    Private Sub codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles codigo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not codigo.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Stock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Stock.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not Stock.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Costo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Costo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not Costo.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub utilidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles utilidad.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not utilidad.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub venta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles venta.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not venta.Text.IndexOf(".") Then
            '    e.Handled = True
            'ElseIf e.KeyChar = "." Then
            '    e.Handled = False
            'Else
            e.Handled = True
        End If
    End Sub
    Private Sub cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelar.Click
        Me.Close()
    End Sub

    Private Sub ArticulosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iva.DataSource = listaiva_
    End Sub
End Class
