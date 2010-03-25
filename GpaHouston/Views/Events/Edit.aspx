<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<GpaHouston.Models.Event>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit</h2>

    <% using (Html.BeginForm("save", "Events"))
       {%>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Title) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Title) %>
                <%= Html.ValidationMessageFor(model => model.Title) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.What) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.What) %>
                <%= Html.ValidationMessageFor(model => model.What) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.When) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.When) %>
                <%= Html.ValidationMessageFor(model => model.When) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Where) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Where) %>
                <%= Html.ValidationMessageFor(model => model.Where) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Contact) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Contact) %>
                <%= Html.ValidationMessageFor(model => model.Contact) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Description) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Description) %>
                <%= Html.ValidationMessageFor(model => model.Description) %>
            </div>
            
            <%= Html.HiddenFor(model => model.Id) %>

            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%=Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

