<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<GpaHouston.Models.News>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	News
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>GPA News</h2>

    <ul>

    <% foreach (var item in Model) { %>
    
        <li><%= Html.Encode(item.Title) %></li>
    
    <% } %>

    </ul>

    <p>
        <%= Html.ActionLink("Create New", "Create") %>
    </p>

    <% foreach (var item in Model) { %>
    
        <h3><%= Html.Encode(item.Title) %></h3>

        <p><%= Html.Encode(item.Html) %></p>

    <% } %>

</asp:Content>

