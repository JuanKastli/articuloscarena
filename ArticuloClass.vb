Public Class ArticuloClass
    Dim Codigo_, Iva_ As Integer
    Dim Descripcion_, Unidad_ As String
    Dim Stock_, Costo_, Utilidad_, Venta_ As Decimal


    Public Property Descripcion() As String
        Get
            Return Descripcion_
        End Get
        Set(ByVal value As String)
            Descripcion_ = value

        End Set
    End Property
    Public Property Codigo() As Integer
        Get

            Return Codigo_
        End Get
        Set(ByVal value As Integer)
            Codigo_ = value
        End Set
    End Property
    Public Property Unidad() As String

        Get
            Return Unidad_
        End Get
        Set(ByVal value As String)
            Unidad_ = value

        End Set
    End Property
    Public Property Iva() As Integer

        Get
            Return Iva_
        End Get
        Set(ByVal value As Integer)
            Iva_ = value
        End Set

    End Property
    Public Property Stock() As Decimal

        Get
            Return Stock_
        End Get
        Set(ByVal value As Decimal)
            Stock_ = value

        End Set
    End Property
    Public Property Costo() As Decimal

        Get
            Return Costo_
        End Get
        Set(ByVal value As Decimal)
            Costo_ = value

        End Set
    End Property
    Public Property Utilidad() As Decimal

        Get
            Return Utilidad_
        End Get
        Set(ByVal value As Decimal)
            Utilidad_ = value

        End Set
    End Property
    Public ReadOnly Property Venta() As Decimal
        Get
            Venta_ = Costo_ * (1 + Iva_ / 100) * (1 + Utilidad_ / 100)
            Return Venta_
        End Get
    End Property
    Public ReadOnly Property detalleiva() As String
        Get
            Return listaiva_(Iva_)

        End Get

    End Property
End Class
