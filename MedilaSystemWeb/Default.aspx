<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MedilaSystemWeb._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                
                <h2>Sistema de Ventas ... </h2>
            </hgroup>
            <p>
             <ol class="round">
                <li class="one" >
                 <h2>Proformas</h2>
             
               <div class="col-sm-3" >                    
                    <a href="frmProforma?acc=nuevo" class="btn btn-success" style="margin: auto; color: #808080;">
                        Registrar Proforma
                    </a>
                </div>
                 </li>
                <li class="two">
              <h2>Ventas</h2>
             
               <div class="col-sm-3">                    
                    <a href="frmListVentas.aspx" class="btn btn-success" style="margin: auto; color: #808080;">
                        Registrar Venta
                    </a>
                </div>
                    </li>
            <li class="three" >
            <h2>Clientes</h2>
             
               <div class="col-sm-3">                    
                    <a href="frmListClientes.aspx" class="btn btn-success" style="margin: auto; color: #808080;">
                        Lista de Clientes
                    </a>
                </div>
                </li>
               <li class="four" >
            <h2>Productos</h2>
             
               <div class="col-sm-3">                    
                    <a href="frmListProductos.aspx" class="btn btn-success" style="margin: auto; color: #808080;">
                        Lista de Productos
                    </a>
                </div>
                   </li>
                 </ol>

                <a href="http://forums.asp.net/18.aspx" title="ASP.NET Forum"></a>.
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
    
</asp:Content>
