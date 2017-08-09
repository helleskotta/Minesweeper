<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Minesweeper.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>MineSweeper</h1>
    <table style="width:400px; height:400px; border: 1px solid red;">
            <asp:Literal ID="PlayField" runat="server"></asp:Literal>
        </table>
</asp:Content>

