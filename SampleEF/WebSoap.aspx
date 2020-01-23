<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebSoap.aspx.cs" Inherits="SampleEF.WebSoap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ObjectDataSource ID="odsKategori" TypeName="SampleEF.Services.KategoriServices"
        SelectMethod="GetAll" InsertMethod="Insert" runat="server">
        <InsertParameters>
            <asp:Parameter Name="nama_kat" Type="String" />
        </InsertParameters>
    </asp:ObjectDataSource>

    <div class="row">
        <div class="col-md-6">
            <asp:GridView ID="gvKategori" DataSourceID="odsKategori" CssClass="table table-bordered"
                runat="server">
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
