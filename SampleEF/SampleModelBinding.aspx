<%@ Page Title="Sample Model Binding" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SampleModelBinding.aspx.cs" Inherits="SampleEF.SampleModelBinding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gvKategori" CssClass="table table-bordered" DataKeyNames="id_kat"
        ItemType="SampleEF.Data.Kategori" SelectMethod="gvKategori_GetData" AutoGenerateEditButton="true"
        UpdateMethod="gvKategori_UpdateItem"
        runat="server"></asp:GridView>
</asp:Content>
