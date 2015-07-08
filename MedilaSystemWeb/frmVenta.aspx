<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmVenta.aspx.cs" Inherits="MedilaSystemWeb.frmVenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel panel-primary">
        <div class="panel-heading">
            <h1>Registrar Venta</h1>
        </div>
        <div class="panel panel-body">
            <div class="row">
                <div class="col-lg-12">
                    <asp:HiddenField ID="hfIdVenta" runat="server"/>
                    <table class="table table-bordered">
                        <tr>
                            <td><b>DNI/Ruc:</b></td>
                            <td>
                                <asp:TextBox ID="txtDni" Width="200px" runat="server"/>
                                <asp:Button ID="txtBuscarClienteDNI" Text="..." CssClass="btn btn-default" runat="server" OnClick="txtBuscarClienteDNI_Click"/>
                                <b><asp:Label ID="lblMensajeCliente" ForeColor="red"  runat="server"/></b>
                            </td>
                            <td>Comprobante</td>
                            <td>
                                <asp:DropDownList ID="cbTipoComprobante" 
                                   CssClass="form-control input-sm"
                                                    
                                                    ItemType="MedilaSystemEntities.Comprobante"
                                                    DataTextField="TipoComprobante"
                                                    DataValueField="Id"
                                                    runat="server"
                                                    SelectMethod="GetComprobantes"/>
                            </td>
                            
                        </tr>
                        <tr>
                            <td><b>Cliente:</b></td>
                            <td colspan="3">
                                <asp:TextBox ID="txtCliente" runat="server"/>
                            </td>
                        </tr>
                        <tr>
                            <td><b>Direccion:</b></td>
                            <td>
                                <asp:TextBox ID="txtDireccion" runat="server"/>
                            </td>
                            <td>
                                <b>Fecha:</b>
                            </td>
                            <td>
                                <asp:TextBox ID="txtFecha" Width="120px" Enabled="False" runat="server"/>
                            </td>
                        </tr>
                        <tr>
                            <td><b>Hora Pedido:</b></td>
                            <td>
                                <asp:TextBox ID="txtHoraPedido" Width="120px" runat="server" Enabled="False"/>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <h2>Productos</h2>
                                <label>Criterio</label>
                                <asp:TextBox ID="txtCriterio" runat="server"/>
                                <asp:Button ID="btnBuscar" Text="Buscar" CssClass="btn btn-danger" runat="server" OnClick="btnBuscar_Click"/>                                
                                <asp:UpdatePanel ID="upProductos" runat="server">
                                    <ContentTemplate>
                                        <asp:ListView ID="lvProductos" runat="server" SelectMethod="GetProductos"
                                            ItemType="MedilaSystemEntities.Producto"
                                             OnItemCommand="lvProductos_ItemCommand">
                                            <LayoutTemplate>
                                                <table class="table table-hover">
                                                    
                                                    <thead>
                                                        <th>Descripcion</th>
                                                        <th>Precio</th>
                                                        <th>Acciones</th>
                                                    </thead>
                                                    <tbody>
                                                        <tr id="itemPlaceholder" runat="server"/>
                                                    </tbody>
                                                </table>
                                                <asp:DataPager runat="server" PagedControlID="lvProductos" PageSize="1" ID="dpProductos">
                                                    <Fields>
                                                        <asp:NextPreviousPagerField
                                                            ButtonType="Link"
												            ShowFirstPageButton="False"
												            ShowLastPageButton="False"
												            ShowNextPageButton="False"
												            ShowPreviousPageButton="False"
                                                            
                                                            />
                                                    </Fields>
                                                </asp:DataPager>
                                            </LayoutTemplate>
                                            <ItemTemplate>
                                                <tr>
                                                    <td><%# Item.Nombre %></td>
                                                    <td><%# Item.PrecioUnitarioDeVenta %></td>
                                                   
                                                    <td>
                                                        <asp:Button ID="btnAgregar" 
                                                            CommandName="addProducto" 
                                                            CommandArgument="<%# Item.Id %>" 
                                                            Text="Agregar" 
                                                            CssClass="btn btn-default" 
                                                            runat="server"/>
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
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="btnBuscar" EventName="Click"/>
                                    </Triggers>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                        <td colspan="4">
                                <asp:UpdatePanel ID="upDetalleVenta" runat="server">
                                    <ContentTemplate>
                                        <asp:ListView ID="lvDetalleVenta" runat="server" OnItemCommand="lvDetalleVenta_ItemCommand" >
                                            <LayoutTemplate>
                                                <table class="table table-hover">
                                                    <thead>
                                                        <tr>
                                                            <th>Descripcion</th>
                                                            <th>Cantidad</th>
                                                            <th>Precio</th>
                                                            <th>Monto</th>
                                                            <th>Acciones</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr id="itemPlaceholder" runat="server"/>
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
                                                                <b><asp:Label ID="lblTotal" runat="server"/></b>
                                                            </td>
                                                            <td></td>
                                                        </tr>
                                                    </tfoot>
                                                </table>
                                            </LayoutTemplate>
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                       <%# Eval("Producto.Nombre") %> 
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="txtCantidad" Text='<%# Bind("Cantidad") %>' Width="50px" runat="server" />
                                                    </td>
                                                    <td>
                                                        <%# Eval("Precio") %> 
                                                    </td>
                                                    <td>
                                                        <%# Eval("Monto") %>
                                                    </td>
                                                    <td>
                                                        <asp:Button ID="btnQuitarDetalle" runat="server"
                                                            Text="Quitar"
                                                            CommandName="QuitarDetalle"
                                                            CommandArgument='<%# Eval("productoId") %>'
                                                            CssClass="btn btn-danger"/>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:ListView>
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="lvProductos" EventName="ItemCommand" />
                                        <asp:AsyncPostBackTrigger ControlID="lvDetalleVenta" EventName="ItemCommand" />
                                    </Triggers>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
        <div class="panel-footer">
            <asp:Button ID="btnGuardar" Text="Guardar" CssClass="btn btn-primary" runat="server" OnClick="btnGuardar_Click" />
            <asp:Button ID="btnCancelar" Text="Cancelar" CssClass="btn btn-danger" runat="server"/>
        </div>
    </div>




 
                            
                        
</asp:Content>
