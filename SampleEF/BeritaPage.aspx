<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BeritaPage.aspx.cs" Inherits="SampleEF.BeritaPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ObjectDataSource ID="odsBerita" TypeName="SampleEF.DAL.BeritaDAL" 
       SelectMethod="GetAll" runat="server" />
    <asp:GridView ID="gvBerita" CssClass="table table-bordered" 
        DataSourceID="odsBerita" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="id_berita" HeaderText="id_berita" SortExpression="id_berita" />
            <asp:BoundField DataField="Kategori.nama_kat" HeaderText="Nama Kategori" />
            <asp:BoundField DataField="judul_berita" HeaderText="judul_berita" SortExpression="judul_berita" />
            <asp:BoundField DataField="detail_berita" HeaderText="detail_berita" SortExpression="detail_berita" />
            <asp:BoundField DataField="tanggal" HeaderText="tanggal" SortExpression="tanggal" />
            <asp:CheckBoxField DataField="isapprove" HeaderText="isapprove" SortExpression="isapprove" />
            <asp:BoundField DataField="pics" HeaderText="pics" SortExpression="pics" />
            <asp:BoundField DataField="pengarang" HeaderText="pengarang" SortExpression="pengarang" />
            <asp:BoundField DataField="tahun_terbit" HeaderText="tahun_terbit" SortExpression="tahun_terbit" />
        </Columns>
    </asp:GridView>
</asp:Content>
