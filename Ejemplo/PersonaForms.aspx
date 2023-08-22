<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PersonaForms.aspx.cs" Inherits="Ejemplo.PersonaForms" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtId" class="form-label">Id</label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtEdad" class="form-label">Edad</label>
                <asp:TextBox runat="server" TextMode="Number" ID="txtEdad" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="calFechaNac" class="form-label">Fecha Nacimiento</label>
                <asp:TextBox runat="server" TextMode="Date" ID="calFechaNac" CssClass="form-control" />
            </div>
                <asp:CheckBox Text="" ID="chkCasado" runat="server" />
                <asp:Label Text="Casado" cssclass="form-check-label" runat="server" />
            <div class="mb-3">
                <label for=ID="rdbArgentino" class="form-label">Argentino</label>
                <asp:RadioButton ID="rdbSiArgentino" Text="Si" runat="server" GroupName="Argentino" />
                <asp:RadioButton ID="rdbNoArgentino" Text="No" Checked="true" runat="server" GroupName="Argentino"/>
            </div>

            <div class="mb-3">
                <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" />
                <a href="Default.aspx">Cancelar</a>
            </div>

        </div>
    </div>

</asp:Content>
