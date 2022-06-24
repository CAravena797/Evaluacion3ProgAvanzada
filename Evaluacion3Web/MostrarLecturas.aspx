<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarLecturas.aspx.cs" Inherits="Evaluacion3Web.MostrarLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary">
                    <h3>Mostrar Lecturas</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <asp:DropDownList runat="server" ID="mostrarLecturaDdl" CssClass="form-control" OnSelectedIndexChanged="mostrarLecturaDdl_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem Value="no" Text="Elegir medidor" Selected="True"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
