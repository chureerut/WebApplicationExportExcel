<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplicationExportExcel.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Button ID="ButtonExport" runat="server" OnClick="ButtonExport_Click" Text="Export To Excel" />
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:TextBox ID="firstvalue" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td style="height: 22px">
                    <asp:TextBox ID="secondvalue" runat="server"></asp:TextBox>
                </td>
                
            </tr>
             <tr>
                <td>
                    <asp:TextBox ID="operation" runat="server"></asp:TextBox>
                 </td>
                
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
                </td>
            
            </tr>
            <tr>
                <td>
                    
                    <asp:Label ID="lbresult" runat="server" Text="Label"></asp:Label>
                </td>
                
            </tr>
        </table>
    </p>
</asp:Content>
