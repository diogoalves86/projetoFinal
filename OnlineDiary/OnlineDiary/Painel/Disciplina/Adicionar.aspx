<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Adicionar.aspx.cs" Inherits="OnlineDiary.Classes.Adicionar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset>
        <h3>Formulário de cadastro de disciplinas
        </h3>
            <p>Nome
                <asp:TextBox ID="txt_nome" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btn_cadastrar" runat="server" OnClick="btn_cadastrar_Click" Text="Cadastrar " />
            </p>
            <p>
                <asp:Label ID="lbl_feedback" runat="server" Text="Mensagem de Feedback" Visible="False"></asp:Label>
            </p>
    </fieldset>
</asp:Content>
