<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="Evaluacion3Web.VerMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary">
                    <h3>Ver Medidores</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <asp:DropDownList runat="server" ID="verMedidorDdl" CssClass="form-control" OnSelectedIndexChanged="verMedidorDdl_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem Value="no" Text="Filtrar por Tipo" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="tipo1" Text="Tipo 1"></asp:ListItem>
                            <asp:ListItem Value="tipo2" Text="Tipo 2"></asp:ListItem>
                            <asp:ListItem Value="tipo3" Text="Tipo 3"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <asp:GridView CssClass="table table-hover table-bordered" runat="server" ID="medidoresGrid" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Numero de serie" />
                            <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
