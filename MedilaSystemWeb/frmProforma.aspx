<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmProforma.aspx.cs" Inherits="MedilaSystemWeb.frmProforma" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <div class="panel-primary">

        <div class="panel-heading">
            PROFORMA
        </div>
        <div class="panel panel-body">
            <div class="row">
                <div class="col-lg-12">
                    <asp:HiddenField ID="hfIdVenta" runat="server"/>

        <div class="panel-body">
          <table class="table table-hover">
                <tr>
                    <td>
                        <asp:Label ID="Label1" Text="RUC / DNI : " runat="server" />
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtRucDni"/>
                    </td>
                    <td>
                        <asp:Button Text="Buscar" ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" />
                    </td>
                    <td>

                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label2" Text="Cliente" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtCliente"/>
                    </td>
                    <td>
                        <asp:Label ID="Label3" Text="Telefono" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox runat="server"  ID="txtTelefono"/>
                    </td>
                </tr>
            </table>

            <hr />

            <asp:TextBox runat="server" ID="txtCriterio"/>
            <asp:Button Text="Buscar" ID="btnBuscarProducto" runat="server" />

            <hr />

            <asp:UpdatePanel ID="upProductos" runat="server">
                <ContentTemplate>
                    <asp:ListView ID="lvProformas" runat="server"
                        ItemType="MedilaSystemEntities.Producto"
                        SelectMethod="getProductos" OnItemCommand="lvProformas_ItemCommand">
                        <LayoutTemplate>
                            <table class="table table-hover">
                                <thead>
                                    <th>ID</th>
                                    <th>NOMBRE</th>
                                    <th>DESCRIPCION</th>
                                    <th>P. VENTA</th>
                                    <th>ACCIONES</th>
                                </thead>
                                <tbody>
                                    <tr id="itemPlaceholder" runat="server" />
                                </tbody>
                            </table>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%# Item.Id %></td>
                                <td><%# Item.Nombre %></td>
                                <td><%# Item.Descripcion %></td>
                                <td><%# Item.PrecioUnitarioDeVenta %></td>
                                <td>
                                    <asp:Button Text="Agregar" ID="btnAgregar" CommandName="agregar" CommandArgument="<%# Item.Id %>" runat="server" />
                                </td>
                            </tr>
                        </ItemTemplate>
                        <EmptyDataTemplate>
                            <tr>
                                <td colspan="3"><b>No hay resultado que mostar..</b></td>
                            </tr>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </ContentTemplate>
            </asp:UpdatePanel>

            <hr />

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:ListView ID="lvDetalleProforma" runat="server"
                        ItemType="MedilaSystemEntities.DetalleProforma" OnItemCommand="lvDetalleProforma_ItemCommand">
                        <LayoutTemplate>
                            <table class="table table-hover">
                                <thead>
                                    <th>Producto</th>
                                   <th>Cantidad</th>
                                    <th>Precio</th>
                                    <th>Monto</th>
                                    <th>Acciones</th>
                                </thead>
                                <tbody>
                                    <tr id="itemPlaceholder" runat="server" />
                                </tbody>
                                <tfoot>
                                                        <tr>
                                                            <td colspan="3">
                                                                <asp:Button ID="btnActualizarItems" runat="server"
                                                                    Text="Actualizar"
                                                                    CommandName="updateItems"
                                                                    CssClass="btn btn-info"/>
                                                            </td>
                                                            <td><b>Total S/.</b></td>
                                                            <td>
                                                                <b><asp:Label ID="lblTotalproforma" runat="server"/></b>
                                                            </td>
                                                            <td></td>
                                                        </tr>
                                                    </tfoot>
                            </table>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%# Item.producto.Descripcion %></td>
                                <td><%# Item.Cantidad %></td>
                                <td><%# Item.producto.PrecioUnitarioDeVenta %></td>
                                <td><%# Item.Monto%></td>
                                 <td>
                                    <asp:Button Text="Quitar" ID="btnQuitar" CommandName="quitar" CommandArgument="<%# Item.ProductoId %>" runat="server" />
                                </td>
                            </tr>
                        </ItemTemplate>
                        <EmptyDataTemplate>
                            <tr>
                                <td colspan="3"><b>No hay resultado que mostar..</b></td>
                            </tr>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </ContentTemplate>
            </asp:UpdatePanel>

        </div>

        <div class="panel-footer">
            <asp:Button Text="Guardar" ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" />
        </div>

    </div>

</asp:Content>

