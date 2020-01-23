<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="KategoriPage.aspx.cs" Inherits="SampleEF.KategoriPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ObjectDataSource ID="odsKategori" TypeName="SampleEF.DAL.KategoriDAL"
        SelectMethod="GetAll" UpdateMethod="Update" InsertMethod="Insert" runat="server">
        <InsertParameters>
            <asp:Parameter Name="nama_kat" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="nama_kat" Type="String" />
            <asp:Parameter Name="id_kat" Type="Int32" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    <div class="row">
        <div class="col-md-6">
            <asp:GridView ID="gvKategori" CssClass="table table-bordered" DataKeyNames="id_kat"
                DataSourceID="odsKategori" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="id_kat" HeaderText="ID" ReadOnly="true" SortExpression="id_kat" />
                    <asp:BoundField DataField="nama_kat" HeaderText="Nama Kategori" SortExpression="nama_kat" />
                    <asp:CommandField ShowEditButton="True" ControlStyle-CssClass="btn btn-warning btn-sm" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="col-md-6">
            <asp:FormView ID="frmKat" DefaultMode="Insert" DataSourceID="odsKategori" runat="server">
                <InsertItemTemplate>
                    <div class="form-group">
                        <label>Nama Kategori :</label>
                        <asp:TextBox ID="txtNamaKategori" Text='<%# Bind("nama_kat") %>' CssClass="form-control" 
                            runat="server" />
                    </div>
                    <asp:Button ID="btnSubmit" CssClass="btn btn-success btn-sm" 
                        Text="Submit" CommandName="Insert" runat="server" />
                </InsertItemTemplate>
            </asp:FormView>
        </div>
    </div>

</asp:Content>
