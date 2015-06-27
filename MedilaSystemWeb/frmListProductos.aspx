<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmListProductos.aspx.cs" Inherits="MedilaSystemWeb.frmListProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
     <div class="panel panel-default"> 
         <div class="panel-heading">
           <div class ="row">
             <div class ="col-sm-9">
                 <h3> Productos</h3>
             </div>
               <div class="col-sm-3">                    
                    <a href="fromProducto?accion=nuevo" class="btn btn-success" style="margin: auto; color: #ffffff;">
                        Registrar Producto
                    </a>
                </div>
         </div>
     </div>
    <div class="panel-body">
        <div>
            <label>Criterio:</label>
            <asp:TextBox ID="txtcriterio"  runat="server" />
            <asp:Button ID="btnBuscar" Text="Buscar" CssClass="btn btn-info" runat="server" />
         </div>
    </div>
</div>
    <asp:ListView ID="lvproductos" runat="server"
        ItemType="MedilaSystemEntities.Producto"
        SelectMethod="Getproducto">
        <LayoutTemplate>
            <table class="table table-hover">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Nombre</th>
                        <th>Descripcion</th>
                        <th>Marca</th>
                        <th>Precio compra</th>
                        <th>Precio venta</th>
                        <th>Proveedor</th>
                        <th>Estado</th>
                        <th>acciones</th>

                    </tr>
                </thead
                    <tbody>
                        <tr id="itemPlaceholder" runat="server"/>
                           
                    </tbody>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%#Item.Id %> </td>
                <td><%#Item.Nombre %></td>
                <td><%#Item.Descripcion%></td>
                <td><%#Item.Marca%></td>
                <td><%#Item.PrecioUnitarioDeCompra%></td>
                <td><%#Item.PrecioUnitarioDeVenta%></td>
                <td><%#Item.ProveedorId%></td>
                <td><%#Item.IsEstado%></td>
                 <td>
     
                        <a href="fromProducto.aspx?id=<%#Item.Id %>">Editar</a>
                         | <a href="fromProducto.aspx?accion=delete&id=<%#Item.Id %>"
                            onclick="return confirm('Desea Elininar a: <%# Item.Nombre %>');" >
                               Eliminar
                           </a>
                    </td>

            </tr>
        </ItemTemplate>
    </asp:ListView>

</asp:Content>
