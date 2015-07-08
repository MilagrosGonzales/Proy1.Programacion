<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmListClientes.aspx.cs" Inherits="MedilaSystemWeb.frmListClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel panel-default"> 
         <div class="panel-heading">
           <div class ="row">
             <div class ="col-sm-9">
                 <h3> CLIENTE</h3>
             </div>
               <div class="col-sm-3">                    
                    <a href="frmCliente?accion=nuevo" class="btn btn-success" style="margin: auto; color: #000;">
                        Registrar Cliente
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
    <asp:ListView ID="lvclientes" runat="server"
        ItemType="MedilaSystemEntities.Cliente"
        SelectMethod="Getcliente">
        <LayoutTemplate>
            <table class="table table-hover">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Ruc/Dni</th>
                        <th>Nombre</th>
                        <th>Apellidos</th>
                        <th>Telefono</th>
                        <th>Direccion</th>
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
                <td><%#Item.RucDni %></td>
                <td><%#Item.Nombre%></td>
                <td><%#Item.Apellidos%></td>
                <td><%#Item.Telefono%></td>
                <td><%#Item.Direccion%></td>
                 <td>
     
                        <a href="frmCliente.aspx?id=<%#Item.Id %>">Editar</a>
                         | <a href="frmCliente.aspx?accion=delete&id=<%#Item.Id %>"
                            onclick="return confirm('Desea Elininar a: <%# Item.Nombre %>');" >
                               Eliminar
                           </a>
                    </td>

            </tr>
        </ItemTemplate>
    </asp:ListView>

</asp:Content>
