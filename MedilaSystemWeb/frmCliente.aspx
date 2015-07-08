<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmCliente.aspx.cs" Inherits="MedilaSystemWeb.frmCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-sm-6">
           <asp:FormView ID="fvCliente" runat="server" Width="100%"
                DefaultMode="Edit"
                SelectMethod="GetCliente"
                UpdateMethod="UpdateCliente"
                InsertMethod="InsertCliente"
                ItemType="MedilaSystemEntities.Cliente">
                <InsertItemTemplate>
                    <div>
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                Registar Nuevo Cliente
                            </div>
                            <div class="panel-body">
                                <div class="row">
                                <div class="form-group">
                               <label>Tipo Cliente:</label>
                                   <asp:TextBox ID="txtTipoC" Text="<%# BindItem.TipoCliente%>" 
                                        CssClass="form-control input-sm" runat="server"/>
                                </div>
                                </div>
                             <!--   <asp:DropDownList ID="ddlcliente" CssClass="form-control input-sm"  runat="server" >
                                    <asp:ListItem>JURIDICO</asp:ListItem>
                                    <asp:ListItem>NATURAL</asp:ListItem>
                                     
                                </asp:DropDownList>  -->
                         
                                </div>
                                 
                                <div class="form-group">
                                    <label>Ruc/Dni:</label>
                                    <asp:TextBox ID="txtDni" Text="<%# BindItem.RucDni%>" 
                                        CssClass="form-control input-sm" runat="server"/>
                                </div>
                                <div class="form-group">
                                    <label>Nombre:</label>
                                    <asp:TextBox ID="txtdescripcion" Text="<%# BindItem.Nombre%>" 
                                        CssClass="form-control input-sm" runat="server"/>
                                </div>
                                <div class="form-group">
                                    <label>Apellidos:</label>
                                    <asp:TextBox ID="txtmarca" Text="<%# BindItem.Apellidos%>" 
                                        CssClass="form-control input-sm" runat="server"/>
                                </div>
                                <div class="form-group">
                                    <label>Telefono:</label>
                                    <asp:TextBox ID="txtpreciCompra" Text="<%# BindItem.Telefono%>" 
                                        CssClass="form-control input-sm" runat="server"/>
                                </div>
                                <div class="form-group">
                                    <label>Direccion:</label>
                                    <asp:TextBox ID="txtprecioVenta" Text="<%# BindItem.Direccion%>" 
                                        CssClass="form-control input-sm" runat="server"/>
                                                              
                            </div>
                            <div class="panel-footer">
                                <asp:Button ID="btnGuardar" CommandName="insert" CssClass="btn btn-success" Text="Guardar" runat="server"/>
                                <a href="frmListClientes.aspx" class="btn btn-danger" style="color:#ffffff;"> Cancelar</a>
                            </div>
                        </div>
                        <div class="bg-danger">
                                <asp:ValidationSummary ID="vsInsert" runat="server" ShowModelStateErrors="True"/>
                            </div>
                        
                    </div>
                </InsertItemTemplate>
                <EditItemTemplate>
                    <div>
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                Actualizar Informacion del Cliente
                            </div>
                            <div class="panel-body">
                                <div class="form-group">
                                    <label>Id:</label>
                                    <asp:TextBox ID="txtID" Text="<%# BindItem.Id %>" 
                                        CssClass="form-control input-sm" Enabled="False" runat="server"/>
                                </div>
                                <div class="form-group">
                                   <label>Tipo Cliente:</label>
                                    <asp:TextBox ID="txtTipoC" Text="<%# BindItem.TipoCliente%>" 
                                        CssClass="form-control input-sm" runat="server"/>-->
                                </div>
                              <!--  <asp:DropDownList ID="ddlcliente" CssClass="form-control input-sm" runat="server"  AutoPostBack="True">
                                    <asp:ListItem>JURIDICO</asp:ListItem>
                                    <asp:ListItem>NATURAL</asp:ListItem>
                                </asp:DropDownList>  -->
                         
                                </div>
                                <div class="form-group">
                                    <label>Ruc/Dni:</label>
                                    <asp:TextBox ID="txtDni" Text="<%# BindItem.RucDni%>" 
                                        CssClass="form-control input-sm" Enabled="False" runat="server"/>
                                </div>
                                <div class="form-group">
                                    <label>Nombres:</label>
                                    <asp:TextBox ID="txtNombres" Text="<%# BindItem.Nombre %>" 
                                        CssClass="form-control input-sm" runat="server"/>
                                </div>
                                <div class="form-group">
                                    <label>Apellidos:</label>
                                    <asp:TextBox ID="txtApellidos" Text="<%# BindItem.Apellidos%>" 
                                        CssClass="form-control input-sm" runat="server"/>
                                </div>
                                <div class="form-group">
                                    <label>Telefono:</label>
                                    <asp:TextBox ID="txtmarca" Text="<%# BindItem.Telefono%>" 
                                        CssClass="form-control input-sm" runat="server"/>
                                </div>

                                <div class="form-group">
                                    <label>Direccion:</label>
                                    <asp:TextBox ID="txtprecioCompra" Text="<%# BindItem.Direccion %>" 
                                        CssClass="form-control input-sm" runat="server"/>
                                </div>
                                                               
                            </div>
                           <div class="panel-footer">
                                <asp:Button ID="btnGuardar" CommandName="update" CssClass="btn btn-success" Text="Guardar" runat="server"/>
                              <!-- <a href="RepartosList.aspx" class="btn btn-danger" style="color:#ffffff;"> Cancelar</a>-->
                            </div>
                        </div>
                    
                        <div class="bg-danger">
                                <asp:ValidationSummary ID="vsInsert" runat="server" ShowModelStateErrors="True"/>
                            </div>

                    </div>
                </EditItemTemplate>
            </asp:FormView>
        </div>
    </div>
            

</asp:Content>
