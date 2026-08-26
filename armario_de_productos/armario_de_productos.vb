Imports System
Module armario_de_productos
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim nombres(9) As String
        Dim categorias(9) As String
        Dim cantidades(9) As Integer
        Dim precios(9) As Double
        Dim ubicaciones(9) As String
        Dim proveedores(9) As String
        Dim fechasIngreso(9) As String
        Dim estados(9) As String
        Dim observaciones(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '-----------------------------------------'
        '--|menu_principal_armario_de_productos|--'
        '-----------------------------------------'
        Do
            Console.WriteLine("menu principal armario de productos")
            Console.WriteLine("1) Registrar producto")
            Console.WriteLine("2) Editar producto")
            Console.WriteLine("3) Listar productos")
            Console.WriteLine("4) Buscar producto")
            Console.WriteLine("5) Eliminar producto")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '------------------------'
                '--|registrar_producto|--'
                '------------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas productos.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.Write("Nombre: ")
                        nombres(cantidad) = Console.ReadLine()
                        Console.Write("Categoria: ")
                        categorias(cantidad) = Console.ReadLine()
                        Console.Write("Cantidad: ")
                        cantidades(cantidad) = Convert.ToInt32(Console.ReadLine())
                        Console.Write("Precio: ")
                        precios(cantidad) = Convert.ToDouble(Console.ReadLine())
                        Console.Write("Ubicacion: ")
                        ubicaciones(cantidad) = Console.ReadLine()
                        Console.Write("Proveedor: ")
                        proveedores(cantidad) = Console.ReadLine()
                        Console.Write("Fecha de ingreso: ")
                        fechasIngreso(cantidad) = Console.ReadLine()
                        Console.Write("Estado: ")
                        estados(cantidad) = Console.ReadLine()
                        Console.Write("Observacion: ")
                        observaciones(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Producto registrado correctamente.")
                    End If
                '---------------------'
                '--|editar_producto|--'
                '---------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen productos registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Categoria: " & categorias(i) & " | Cantidad: " & cantidades(i) & " | Precio: " & precios(i) & " | Ubicacion: " & ubicaciones(i) & " | Proveedor: " & proveedores(i) & " | Fecha de ingreso: " & fechasIngreso(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID del producto a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo nombre: ")
                            nombres(posicion) = Console.ReadLine()
                            Console.Write("Nueva categoria: ")
                            categorias(posicion) = Console.ReadLine()
                            Console.Write("Nueva cantidad: ")
                            cantidades(posicion) = Convert.ToInt32(Console.ReadLine())
                            Console.Write("Nuevo precio: ")
                            precios(posicion) = Convert.ToDouble(Console.ReadLine())
                            Console.Write("Nueva ubicacion: ")
                            ubicaciones(posicion) = Console.ReadLine()
                            Console.Write("Nuevo proveedor: ")
                            proveedores(posicion) = Console.ReadLine()
                            Console.Write("Nueva fecha de ingreso: ")
                            fechasIngreso(posicion) = Console.ReadLine()
                            Console.Write("Nuevo estado: ")
                            estados(posicion) = Console.ReadLine()
                            Console.Write("Nueva observacion: ")
                            observaciones(posicion) = Console.ReadLine()
                            Console.WriteLine("Producto actualizado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '----------------------'
                '--|listar_productos|--'
                '----------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen productos registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Categoria: " & categorias(i) & " | Cantidad: " & cantidades(i) & " | Precio: " & precios(i) & " | Ubicacion: " & ubicaciones(i) & " | Proveedor: " & proveedores(i) & " | Fecha de ingreso: " & fechasIngreso(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                    End If
                '---------------------'
                '--|buscar_producto|--'
                '---------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen productos registrados.")
                    Else
                        Console.Write("Ingrese el ID del producto a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("ID: " & ids(posicion) & " | Nombre: " & nombres(posicion) & " | Categoria: " & categorias(posicion) & " | Cantidad: " & cantidades(posicion) & " | Precio: " & precios(posicion) & " | Ubicacion: " & ubicaciones(posicion) & " | Proveedor: " & proveedores(posicion) & " | Fecha de ingreso: " & fechasIngreso(posicion) & " | Estado: " & estados(posicion) & " | Observacion: " & observaciones(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-----------------------'
                '--|eliminar_producto|--'
                '-----------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen productos registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Categoria: " & categorias(i) & " | Cantidad: " & cantidades(i) & " | Precio: " & precios(i) & " | Ubicacion: " & ubicaciones(i) & " | Proveedor: " & proveedores(i) & " | Fecha de ingreso: " & fechasIngreso(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID del producto a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                nombres(i) = nombres(i + 1)
                                categorias(i) = categorias(i + 1)
                                cantidades(i) = cantidades(i + 1)
                                precios(i) = precios(i + 1)
                                ubicaciones(i) = ubicaciones(i + 1)
                                proveedores(i) = proveedores(i + 1)
                                fechasIngreso(i) = fechasIngreso(i + 1)
                                estados(i) = estados(i + 1)
                                observaciones(i) = observaciones(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Producto eliminado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|mostrar_resumen|--'
                '---------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen productos registrados.")
                    Else
                        Dim unidadesTotales As Integer = 0
                        Dim disponibles As Integer = 0
                        Dim agotados As Integer = 0
                        Dim reservados As Integer = 0
                        Dim danados As Integer = 0
                        Dim valorTotal As Double = 0
                        Dim mayorCantidad As Integer = cantidades(0)
                        Dim menorCantidad As Integer = cantidades(0)
                        Dim mayorPrecio As Double = precios(0)
                        Dim menorPrecio As Double = precios(0)
                        Dim productoMayorCantidad As String = nombres(0)
                        Dim productoMenorCantidad As String = nombres(0)
                        Dim productoMayorPrecio As String = nombres(0)
                        Dim productoMenorPrecio As String = nombres(0)
                        Dim categoriaMasUtilizada As String = categorias(0)
                        Dim mayorCategoria As Integer = 0
                        For i As Integer = 0 To cantidad - 1
                            unidadesTotales += cantidades(i)
                            valorTotal += cantidades(i) * precios(i)
                            If cantidades(i) > mayorCantidad Then
                                mayorCantidad = cantidades(i)
                                productoMayorCantidad = nombres(i)
                            End If
                            If cantidades(i) < menorCantidad Then
                                menorCantidad = cantidades(i)
                                productoMenorCantidad = nombres(i)
                            End If
                            If precios(i) > mayorPrecio Then
                                mayorPrecio = precios(i)
                                productoMayorPrecio = nombres(i)
                            End If
                            If precios(i) < menorPrecio Then
                                menorPrecio = precios(i)
                                productoMenorPrecio = nombres(i)
                            End If
                            Select Case estados(i).ToLower()
                                Case "disponible"
                                    disponibles += 1
                                Case "agotado"
                                    agotados += 1
                                Case "reservado"
                                    reservados += 1
                                Case "dañado", "danado"
                                    danados += 1
                            End Select
                        Next
                        For i As Integer = 0 To cantidad - 1
                            Dim contadorCategoria As Integer = 0
                            For j As Integer = 0 To cantidad - 1
                                If categorias(i).ToLower() = categorias(j).ToLower() Then
                                    contadorCategoria += 1
                                End If
                            Next
                            If contadorCategoria > mayorCategoria Then
                                mayorCategoria = contadorCategoria
                                categoriaMasUtilizada = categorias(i)
                            End If
                        Next
                        Console.WriteLine("Productos: " & cantidad & " | Unidades: " & unidadesTotales & " | Disponibles: " & disponibles & " | Agotados: " & agotados & " | Reservados: " & reservados & " | Dañados: " & danados & " | Valor total: " & valorTotal & " | Mayor cantidad: " & productoMayorCantidad & " | Menor cantidad: " & productoMenorCantidad & " | Mayor precio: " & productoMayorPrecio & " | Menor precio: " & productoMenorPrecio & " | Categoria mas utilizada: " & categoriaMasUtilizada)
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Armario de Productos.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module