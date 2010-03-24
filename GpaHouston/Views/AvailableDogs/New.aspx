<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<GpaHouston.Models.AvailableDogModel>" %>
<%@ Import Namespace="MvcContrib.UI.InputBuilder.Views" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	New
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>New</h2>

    <%= Html.InputForm() %>

</asp:Content>
