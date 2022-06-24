<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarLectura.aspx.cs" Inherits="Evaluacion3Web.IngresarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary">
                    <h3>Ingresar Lectura</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="medidorDdl">Medidor</label>
                        <asp:DropDownList runat="server" ID="medidorDdl" CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                    <table class="table-primary mt-2 mb-2">
                        <asp:Calendar ID="calendarioLectura" runat="server" SelectionMode="DayWeekMonth"></asp:Calendar>
                    </table>
                    <div class="form-group">
                        <label for="horaTxt">Hora de lectura (ingrese hora 00-24)</label>
                        <asp:TextBox ID="horaTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ID="horaTxtValid" controltovalidate="horaTxt" errormessage="Debes ingresar una hora" CssClass="text-danger"/>
                        <asp:RangeValidator runat="server" id="horaTxtRange" controltovalidate="horaTxt"  minimumvalue="0" maximumvalue="23" errormessage="debes ingresar una hora valida" CssClass="text-danger" />
                    </div>
                    <div class="form-group">
                        <label for="minutosTxt">(ingrese minutos 00-59)</label>
                        <asp:TextBox ID="minutosTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ID="minutosTxtValid" controltovalidate="minutosTxt" errormessage="Debes ingresar los minutos" CssClass="text-danger"/>
                        <asp:RangeValidator runat="server" id="minutosTxtRange" controltovalidate="minutosTxt" minimumvalue="0" maximumvalue="59" errormessage="debes ingresar minutos validos" CssClass="text-danger" />
                    </div>
                    <div class="form-group">
                        <label for="valorTxt">Valor de consumo (0-600)</label>
                        <asp:TextBox ID="valorTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ID="valorTxtValid" controltovalidate="valorTxt" errormessage="Debes ingresar el valor de consumo" CssClass="text-danger"/>
                        <asp:RangeValidator runat="server" id="valorTxtRange" controltovalidate="valorTxt" minimumvalue="0" maximumvalue="600" errormessage="debes ingresar un valor valido" CssClass="text-danger" />
                    </div>
                    <div class="form-group mt-1">
                        <asp:Button runat="server" ID="ingresarLecturaBtn" OnClick="ingresarLecturaBtn_Click" Text="Ingresar" CssClass="btn btn-primary btn-lg" />
                    </div>
                    <div>
                        <asp:Label runat="server" ID="ingresarLecturaMsj" CssClass="text-success"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
