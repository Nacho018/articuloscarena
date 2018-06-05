
Imports System.ComponentModel

Public Class ArticulosCollection


    Inherits BindingList(Of ArticuloClass)



    Protected Overrides Sub onAddingNew(ByVal e As AddingNewEventArgs)


        e.NewObject = New ArticuloClass()



    End Sub






End Class
