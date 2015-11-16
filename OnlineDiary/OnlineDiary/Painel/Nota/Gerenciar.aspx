<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Gerenciar.aspx.cs" Inherits="OnlineDiary.Classes.Painel.NotaTela.Gerenciar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table runat="server" ID="tbl_notas">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell runat="server">Alunxs</asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server">N1</asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server">2N1</asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server">N2</asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server">2N2</asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server">N3</asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server">2N3</asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server">Média Final</asp:TableHeaderCell>
        </asp:TableHeaderRow>
    </asp:Table>                          
</asp:Content>
