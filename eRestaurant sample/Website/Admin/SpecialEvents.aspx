﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SpecialEvents.aspx.cs" Inherits="Admin_SpecialEvents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row col-md-12">
        <h1>Special Events<span class="glyphicon glyphicon-glass"></span></h1>
    </div>

    <asp:ListView ID="ListView1" runat="server" DataSourceID="SpecialEventsDataSource" InsertItemPosition="LastItem">
       
        <EditItemTemplate>
            <span style="">EventCode:
                <asp:TextBox Text='<%# Bind("EventCode") %>' runat="server" ID="EventCodeTextBox" /><br />
                Description:
                <asp:TextBox Text='<%# Bind("Description") %>' runat="server" ID="DescriptionTextBox" /><br />
                <asp:CheckBox Checked='<%# Bind("Active") %>' runat="server" ID="ActiveCheckBox" Text="Active" /><br />
                Reservations:
                <asp:TextBox Text='<%# Bind("Reservations") %>' runat="server" ID="ReservationsTextBox" /><br />
                <asp:Button runat="server" CommandName="Update" Text="Update" ID="UpdateButton" /><asp:Button runat="server" CommandName="Cancel" Text="Cancel" ID="CancelButton" /><br />
                <br />
            </span>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <span>No data was returned.</span>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <span style="">
                <asp:LinkButton runat="server" CommandName="Insert" ID="InsertButton" >Insert <span class="glyphicon glyphicon-plus"></span></asp:LinkButton>
                &nbsp;
                <asp:LinkButton runat="server" CommandName="Cancel" ID="CancelButton" >Clear <span class="glyphicon glyphicon-refresh"></span></asp:LinkButton>
                &nbsp;&nbsp;&nbsp;
                <asp:CheckBox Checked='<%# Bind("Active") %>' runat="server" ID="ActiveCheckBox" Text="Active" />
                &mdash;
                <asp:Label ID="Label3" runat="server" AssociatedControlID="EventCodeTextBox" CssClass="control-label">Event Code</asp:Label>
                <asp:TextBox Text='<%# Bind("EventCode") %>' runat="server" ID="EventCodeTextBox" />
                &mdash;
                <asp:Label ID="Label4" runat="server" AssociatedControlID="DescriptionTextBox" CssClass="control-label">Description</asp:Label>
                <asp:TextBox Text='<%# Bind("Description") %>' runat="server" ID="DescriptionTextBox" />
                
                
                <br />
            </span>
        </InsertItemTemplate>
        <ItemTemplate>
            <div><asp:LinkButton runat="server" CommandName="Edit" ID="EditButton">Edit <span class="glyphicon glyphicon-pencil"></span></asp:LinkButton>
                &nbsp;
                <asp:LinkButton runat="server" CommandName="Delete" ID="DeleteButton" >Delete <span class="glyphicon glyphicon-trash"></span></asp:LinkButton>
                &nbsp;&nbsp;&nbsp;
                 <asp:CheckBox Checked='<%# Eval("Active") %>' runat="server" ID="CheckBox1" Enabled="false" Text="Active" />
                &mdash;
                <asp:Label ID="Label1" runat="server" AssociatedControlID="EventCodeLabel" CssClass="control-label">Event Code</asp:Label>  
                <asp:Label Text='<%# Eval("EventCode") %>' runat="server" ID="EventCodeLabel" />
                <asp:Label ID="Label2" runat="server" AssociatedControlID="DescriptionLabel">Description</asp:Label>
                <asp:Label Text='<%# Eval("Description") %>' runat="server" ID="DescriptionLabel" />
            </div>
        </ItemTemplate>
        <LayoutTemplate>
            <fieldset runat="server" id="itemPlaceholderContainer" style=""><div runat="server" id="itemPlaceholder" /></fieldset>

        </LayoutTemplate>
       
    </asp:ListView>
    <asp:ObjectDataSource runat="server" ID="SpecialEventsDataSource" DataObjectTypeName="eRestaurant.Entities.SpecialEvent" DeleteMethod="DeleteEvent" InsertMethod="AddEvent" OldValuesParameterFormatString="original_{0}" SelectMethod="ListAllEvents" TypeName="eRestaurant.BLL.RestaurantAdminController" UpdateMethod="UpdateEvent"></asp:ObjectDataSource>
</asp:Content>

