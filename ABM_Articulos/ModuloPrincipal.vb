Module ModuloPrincipal

    Public lst As ArticulosCollection


    Sub Main()
        lst = New ArticulosCollection

        Application.Run(ArticulosGrid)


    End Sub


    Public listaiva() As String = {"21,00%", "10,5%"}


End Module
