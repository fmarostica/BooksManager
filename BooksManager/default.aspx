<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="BooksManager._default" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <h2>Últimos libros</h2>
    <div class="row py-4">
        <%
            foreach (var item in lastBooks)
            {
                %>
                <div class="col-md-3">
                    <div class="book-box">
                        <img class="image" src="/images/logo.jpg" />
                        <h3 class="title"><%: item.Title %></h3>
                    </div>
                </div>
                <%
            }
        %>
    </div>
    <h2>
        Populares
    </h2>
    <h2>
        Recomendados
    </h2>
</asp:Content>
