<%@ Page Title="" Language="C#" MasterPageFile="~/Guang.Master" AutoEventWireup="true" CodeBehind="Passcode.aspx.cs" Inherits="Guang.Passcode" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" class="center">
        <asp:TextBox ID="txtname" runat="server" Placeholder="Enter your Name"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtpasscode" runat="server" Placeholder="Enter Passcode"></asp:TextBox> 
        <br />
        <asp:Button ID="txtsbmt" runat="server" Text="Request for Access" />
    </form>
</asp:Content>
