<%@ Page Title="" Language="C#" MasterPageFile="~/Guang.Master" AutoEventWireup="true" CodeBehind="Name.aspx.cs" Inherits="Guang.Name" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <asp:TextBox ID="txtname" runat="server" Placeholder="Enter your Name"></asp:TextBox>
        <br />
        <asp:Button ID="btnsbmt" runat="server" Text="Join"/>
    </form>
</asp:Content>
