<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="fromProducto.aspx.cs" Inherits="MedilaSystemWeb.fromProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row">
        <div class="col-sm-6">
            <asp:FormView id="fvProductos" runat="server" Width="100%"
                DefaultMode="Edit"
                SelectMethod="GetProducto"
                UpdateMethod="UpdateProducto"
                InsertMethod="InsertProducto"
                ItemType="MedilaSystemEntities.Producto">
                <InsertItemTemplate>
                    <div>
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                Registar Producto
                            </div>
                            <div class="panel-body">
                                <div class="row">
                                <div class="form-group">
                                    <label>Nombres:</label>
                                    <asp:TextBox ID="txtNombres" Text="<%# BindItem.Nombre%>" 
                                        CssClass="form-control input-sm" runat="server"/>
                                </div>
                                <div class="form-group">
                                    <label>Descripcion:</label>
                                    <asp:TextBox ID="txtdescripcion" Text="<%# BindItem.Descripcion%>" 
                                        CssClass="form-control input-sm" runat="server"/>
                                </div>
                                <div class="form-group">
                                    <label>Precio Compra:</label>
                                    <asp:TextBox ID="txtpreciCompra" Text="<%# BindItem.PrecioUnitarioDeCompra%>" 
                                        CssClass="form-control input-sm" runat="server"/>
                                </div>
                                <div class="form-group">
                                    <label>Precio Venta:</label>
                                    <asp:TextBox ID="txtprecioVenta" Text="<%# BindItem.PrecioUnitarioDeVenta%>" 
                                        CssClass="form-control input-sm" runat="server"/>
                                </div>
                               <div class="form-group">
                                    <label>Proveedor:</label>
                                      <asp:DropDownList ID="ddlproveedores" runat="server" 
                                             SelectMethod="GetProveedor"
                                             ItemType="MedilaSystemEntities.Proveedor"
                                              DataTextField="NombreE"
                                              DataValueField="Id"
                                           SelectedValue='<%# BindItem.ProveedorId%>'/>  
                         
                                </div>
                                <div class="form-group">
                                    <asp:CheckBox ID="chkestado" Checked="<%# BindItem.IsEstado %>" 
                                        runat="server" Text="&nbsp; BuenEstado"/>
                                </div>
                            </div>
                            <div class="panel-footer">
                                <asp:Button ID="btnGuardar" CommandName="insert" CssClass="btn btn-success" Text="Guardar" runat="server"/>
                                <a href="frmListProductos.aspx" class="btn btn-danger" style="color:#ffffff;"> Cancelar</a>
                            </div>
                        </div>
                        <div class="bg-danger">
                                <asp:ValidationSummary ID="vsInsert" runat="server" 
                            ShowModelStateErrors="True"/>
                            </div>
                        
                    </div>
                </InsertItemTemplate>
                <EditItemTemplate>
                    <div>
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                Actualizar Informacion del Producto
                            </div>
                            <div class="panel-body">
                                <div class="form-group">
                                    <label>ID:</label>
                                    <asp:TextBox ID="txtID" Text="<%# BindItem.Id %>" 
                                        CssClass="form-control input-sm" Enabled="False" runat="server"/>
                                </div>
                                <div class="form-group">
                                    <label>Nombres:</label>
                                    <asp:TextBox ID="txtNombres" Text="<%# BindItem.Nombre %>" 
                                        CssClass="form-control input-sm" runat="server"/>
                                </div>
                                <div class="form-group">
                                    <label>Descripcion:</label>
                                    <asp:TextBox ID="txtdesceipcion" Text="<%# BindItem.Descripcion%>" 
                                        CssClass="form-control input-sm" runat="server"/>
                                </div>
                                <div class="form-group">
                                    <label>Precio compra:</label>
                                    <asp:TextBox ID="txtprecioCompra" Text="<%# BindItem.PrecioUnitarioDeCompra %>" 
                                        CssClass="form-control input-sm" runat="server"/>
                                </div>
                                <div class="form-group">
                                    <label>Precio Venta:</label>
                                    <asp:TextBox ID="txtprecioVenta" Text="<%# BindItem.PrecioUnitarioDeVenta %>" 
                                        CssClass="form-control input-sm" runat="server"/>
                                </div>
                                <div class="form-group">
                                    <label>Proveedor :</label>
                                    <asp:DropDownList ID="ddlproveedores" runat="server" 
                                             SelectMethod="GetProveedor"
                                             ItemType="MedilaSystemEntities.Proveedor"
                                              DataTextField="NombreE"
                                              DataValueField="Id"
                                        SelectedValue='<%# BindItem.ProveedorId%>'/> 
                                </div>
                                <div class="form-group">
                                    <label>Estado: </label>
                                    <asp:CheckBox ID="chkDisponible" Checked="<%# BindItem.IsEstado%>" runat="server" />
                                </div>
                                
                                
                               
                            </div>
                            <div class="panel-footer">
                                <asp:Button ID="btnGuardar" CommandName="update" CssClass="btn btn-success" Text="Guardar" runat="server"/>
                              <!-- <a href="RepartosList.aspx" class="btn btn-danger" style="color:#ffffff;"> Cancelar</a>-->
                            </div>
                        </div>
                    
                        <div class="bg-danger">
                                <asp:ValidationSummary ID="vsInsert" runat="server" 
                            ShowModelStateErrors="True"/>
                            </div>

                    </div>
                </EditItemTemplate>
            </asp:FormView>
        </div>
    </div>

</asp:Content>
