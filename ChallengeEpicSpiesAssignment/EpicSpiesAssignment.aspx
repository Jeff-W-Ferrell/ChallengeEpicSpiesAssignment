<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EpicSpiesAssignment.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.EpicSpiesAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-weight: normal;
        }
        .auto-style3 {
            font-weight: normal;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" Width="160px" />
        <h1><strong style="font-family: Arial, Helvetica, sans-serif">Spy New Assignment Form</strong></h1>
        <h3><span class="auto-style1">Spy Code Name:</span>&nbsp;
            <asp:TextBox ID="codeNameTextBox" runat="server" Width="189px"></asp:TextBox>
        </h3>
        <h3><span class="auto-style3">New Assignment Name:</span>&nbsp;
            <asp:TextBox ID="assignmentNameTextBox" runat="server" Width="188px"></asp:TextBox>
        </h3>
        <p>
            &nbsp;</p>
        <p class="auto-style3">
            End Date of Previous Assignment:<asp:Calendar ID="previousEndCalendar" runat="server"></asp:Calendar>
        </p>
        <p class="auto-style3">
            &nbsp;</p>
        <p class="auto-style3">
            Start Date of New Assignment:<asp:Calendar ID="newCalendar" runat="server"></asp:Calendar>
        </p>
        <p class="auto-style3">
            &nbsp;</p>
        <p class="auto-style3">
            Projected End Date of New Assignment:<asp:Calendar ID="newEndCalendar" runat="server"></asp:Calendar>
            &nbsp;</p>
        <p class="auto-style3">
            <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign Spy" />
        </p>
        <p class="auto-style3">
            <asp:Label ID="detailsLabel" runat="server"></asp:Label>
        </p>
        <p class="auto-style3">
            &nbsp;</p>
    
    </div>
    </form>
</body>
</html>
