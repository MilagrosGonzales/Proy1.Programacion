<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmListVentas.aspx.cs" Inherits="MedilaSystemWeb.frmListVentas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel panel-default">
        <div class="panel-heading">
            Ventas
        </div>
        <div class="panel-body">
            <table>
                
                <a href="frmVenta.aspx?opc=nuevo"class="btn btn-success" style="margin: auto; color: #000;">
                    Nueva Venta</a>
                <tr>
                    <td>
                        <label>Criterio:</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCriterio" CssClass="form-control" Width="100%" runat="server"/>
                    </td>
                    <td>
                        <label>Fecha Inicio:</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFechaIni" CssClass="form-control" Width="100px" runat="server"/>
                        <ajaxToolkit:CalendarExtender ID="txtFechaIni_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtFechaIni" Format="dd/MM/yyyy">
                        </ajaxToolkit:CalendarExtender>
                    </td>
                    <td>
                        <label>Fecha Fin:</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFechaFin" CssClass="form-control" Width="100px" runat="server"/>
                        <ajaxToolkit:CalendarExtender ID="txtFechaFin_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtFechaFin" Format="dd/MM/yyyy">
                        </ajaxToolkit:CalendarExtender>
                    </td>
                    <td>
                        <asp:Button ID="btnBuscar" Text="Buscar" CssClass="btn btn-success" runat="server"/>
                    </td>
                </tr>
            </table>
        </div>
        
        <asp:ListView ID="lvVentas" runat="server"
            ItemType="MedilaSystemEntities.Venta"
            SelectMethod="GetVentas">
            <LayoutTemplate>
                <table class="table table-hover">
                    <tr>
                        <th>Fecha</th>
                        <th>Cliente</th>
                        <th>Tipo comprobante</th>
                         <th>Total</th>
                        <th>Acciones</th>
                    </tr>
                    <tbody>
                        <tr id="itemPlaceholder" runat="server"/>
                    </tbody>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Item.Fecha %></td>
                     <td><%# Item.cliente.Nombre %><a></a><%# Item.cliente.Apellidos %></td>
                    <td><%# Item.comprobante.TipoComprobante %></td>
                    <td><%# Item.Total%></td>
                    
                    
                    <td>
                        <a href="frmVenta.aspx?IdVenta=<%# Item.Id  %>&opc=editar">
                            Editar
                        </a>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>

