<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageRoles.aspx.cs" Inherits="OnlineDiary.Roles.ManageRoles" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">    
    <b>Create a New Role: </b>
    <asp:TextBox ID="RoleName" Runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="CreateRoleButton" Runat="server" Text="Create Role" OnClick="CreateRoleButton_Click" />
</asp:Content>