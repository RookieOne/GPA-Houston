<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<GpaHouston.Models.Event>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Events
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Events</h2>

    Events
    <p>
GPA - Houston provides plenty of opportunities for people and hounds to get together.  Whether it's a first meeting at one of our store front appearances, or a holiday party, greyhounds are the center of attention. 
</p>

    <p>
        <%= Html.ActionLink("Create New", "Create") %>
    </p>

    <% foreach (var item in Model) { %>
    
        <h3><%= Html.Encode(item.Title) %></h3>

        <table>
        <tr>
            <td>What :</td>
            <td><%= Html.Encode(item.What) %></td>
        </tr>
        <tr>
            <td>When :</td>
            <td><%= Html.Encode(item.When) %></td>
        </tr>
                <tr>
            <td>Where :</td>
            <td><%= Html.Encode(item.Where)%></td>
        </tr>
                <tr>
            <td>Contact :</td>
            <td><%= Html.Encode(item.Contact) %></td>
        </tr>
        </table>

        <p>Description : <%= Html.Encode(item.Description) %></p>
    
    <% } %>    

</asp:Content>

