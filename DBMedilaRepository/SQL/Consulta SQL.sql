SELECT        Cliente.Nombre, Cliente.RucDni, Ventas.Fecha, DetalleVenta.Precio, DetalleVenta.Cantidad, Productos.Nombre AS Producto, Ventas.Total
FROM            Productos INNER JOIN
                         DetalleVenta ON Productos.Id = DetalleVenta.ProductoId INNER JOIN
                         Ventas ON DetalleVenta.VentaId = Ventas.Id INNER JOIN
                         Cliente ON Ventas.clienteId = Cliente.Id