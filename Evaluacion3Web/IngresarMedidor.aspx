<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarMedidor.aspx.cs" Inherits="Evaluacion3Web.AgregarMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary">
                    <h3>Ingresar Medidor</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="numSerieTxt">Numero de serie de medidor</label>
                        <asp:TextBox ID="numSerieTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ID="numSerieTxtValid" controltovalidate="numSerieTxt" errormessage="Debes ingresar un numero de serie" CssClass="text-danger"/>
                        <asp:CustomValidator runat="server" id="numSerieTxtCus" controltovalidate="numSerieTxt" onservervalidate="numSerieTxtCus_ServerValidate" CssClass="text-danger" errormessage="Formato no valido (Solo se aceptan numeros)" />
                        <asp:Label runat="server" ID="medidorRepetidoMsj" CssClass="text-danger"></asp:Label>
                    </div>
                    <div class="form-group">
                        <label for="tipoMedidorDdl">Tipo de medidor</label>
                        <asp:DropDownList runat="server" ID="tipoMedidorDdl" CssClass="form-control">
                            <asp:ListItem Value="tipo1" Text="Tipo 1"></asp:ListItem>
                            <asp:ListItem Value="tipo2" Text="Tipo 2"></asp:ListItem>
                            <asp:ListItem Value="tipo3" Text="Tipo 3"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group mt-1">
                        <asp:Button runat="server" ID="ingresarMedidorBtn" OnClick="ingresarMedidorBtn_Click" Text="Ingresar" CssClass="btn btn-primary btn-lg" />
                    </div>
                    <div>
                        <asp:Label runat="server" ID="ingresarMedidorMsj" CssClass="text-success"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
