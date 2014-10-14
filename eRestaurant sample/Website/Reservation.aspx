<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Reservation.aspx.cs" Inherits="Reservation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Select Reservation By Special Event</h1>
    <asp:Label ID="Label1" runat="server" Text="Special Events:" AssociatedControlID="SpecialEventList"></asp:Label>
    <br />
    <asp:DropDownList ID="SpecialEventList" runat="server" DataSourceID="SpecialEventDataSource" DataTextField="Description" DataValueField="EventCode" AppendDataBoundItems="True">
        <asp:ListItem>Select Event</asp:ListItem>
        <asp:ListItem Value="">No Event</asp:ListItem>
    </asp:DropDownList>
    <asp:LinkButton ID="Submit" runat="server">View Reservations</asp:LinkButton>
    <asp:ObjectDataSource ID="SpecialEventDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ListAllEvents" TypeName="eRestaurant.BLL.RestaurantAdminController"></asp:ObjectDataSource>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Reservations:" AssociatedControlID="ReservationGridView"></asp:Label>
    <asp:GridView ID="ReservationGridView" runat="server" AutoGenerateColumns="False" DataSourceID="ReservationDataSource" AllowPaging="True">
        <Columns>
            <asp:BoundField DataField="reservationID" HeaderText="reservationID" SortExpression="reservationID" />
            <asp:BoundField DataField="CustomerName" HeaderText="CustomerName" SortExpression="CustomerName" />
            <asp:BoundField DataField="ReservationDate" HeaderText="ReservationDate" SortExpression="ReservationDate" />
            <asp:BoundField DataField="NumberInParty" HeaderText="NumberInParty" SortExpression="NumberInParty" />
            <asp:BoundField DataField="ContactPhone" HeaderText="ContactPhone" SortExpression="ContactPhone" />
            <asp:BoundField DataField="ReservationStatus" HeaderText="ReservationStatus" SortExpression="ReservationStatus" />
            <asp:BoundField DataField="EventCode" HeaderText="EventCode" SortExpression="EventCode" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ReservationDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getReservation" TypeName="eRestaurant.BLL.ReservationController">
        <SelectParameters>
            <asp:ControlParameter ControlID="SpecialEventList" Name="EventCode" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

