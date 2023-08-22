<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ejemplo.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .oculto{
            display: none;
        }
    </style>

    <div class="row">
        <div class="col">
            <asp:GridView runat="server" ID="dgvPersonas" OnSelectedIndexChanged="dgvPersonas_SelectedIndexChanged" CssClass="table" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Id" DataField="Id" HeaderStyle-CssClass="oculto" ItemStyle-CssClass="oculto" />
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                    <asp:BoundField HeaderText="Edad" DataField="Edad" />
                    <asp:BoundField HeaderText="Fecha Nacimiento" DataField="FechaNacimiento" />
                    <asp:CheckBoxField HeaderText="Casado" DataField="Casado" />
                    <asp:CheckBoxField HeaderText="Argentino" DataField="Argentino" />
                    <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Accion" />
                </Columns>
            </asp:GridView>
            <a href="PersonaForms.aspx">Agregar</a>
        </div>
    </div>

</asp:Content>
