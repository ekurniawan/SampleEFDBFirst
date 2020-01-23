<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="KategoriPage.aspx.cs" Inherits="SampleEF.KategoriPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ObjectDataSource ID="odsKategori" TypeName="SampleEF.DAL.KategoriDAL"
        SelectMethod="GetAll"  InsertMethod="Insert" runat="server" />
    <div class="row">
        <div class="col-md-6">
            <asp:GridView ID="gvKategori" CssClass="table table-bordered"
                DataSourceID="odsKategori" runat="server">
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
