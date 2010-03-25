<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<GpaHouston.Models.AvailableDog>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit</h2>

    <% using (Html.BeginForm("save", "AvailableDogs")) {%>

        <fieldset>
            <legend>Fields</legend>            
             
             <%= Html.HiddenFor(m => m.Id) %>

            <div class="editor-label">
                <%= Html.LabelFor(m => m.Name) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(m => m.Name) %>
                <%= Html.ValidationMessageFor(m => m.Name) %>
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%=Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

