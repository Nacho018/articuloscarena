Public Class ArticuloClass
    Dim Codigo_ As Integer

    Dim Stock_, costo_, utilidad_, venta_, iva_ As Decimal

    Dim Descripcion_, unidad_, articulo_ As String

    Dim contiva_ As Decimal


    Public Property Descripcion() As String

        Get

            Return Descripcion_

        End Get


        Set(ByVal value As String)

            Descripcion_ = value


        End Set

    End Property

    Public Property articulo() As String

        Get

            Return articulo_

        End Get


        Set(ByVal value As String)

            articulo_ = value


        End Set

    End Property

    Public Property unidad() As String



        Get



            Return unidad_

        End Get

        Set(ByVal value As String)


            unidad_ = value

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


    Public Property Iva() As Decimal
        Get

            Return iva_

        End Get

        Set(ByVal value As Decimal)

            iva_ = value



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

            Return costo_

        End Get

        Set(ByVal value As Decimal)

            costo_ = value

        End Set

    End Property

    Public Property utilidad() As Decimal


        Get

            Return utilidad_

        End Get

        Set(ByVal value As Decimal)

            utilidad_ = value

        End Set

    End Property


    Public ReadOnly Property venta() As Decimal



        Get

            If iva_ = 0 Then

                contiva_ = 21.0

            Else

                contiva_ = 10.5

            End If



            venta_ = costo_ * (1 + contiva_ / 100) * (1 + utilidad_ / 100)


            Return venta_




        End Get







    End Property

    Public ReadOnly Property detalleIva() As String

        Get


            Return listaiva(iva_)





        End Get




    End Property

End Class
