<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PagerControl.ascx.cs" Inherits="Inventory.Web.UserControl.PagerControl" %>
 <asp:Panel ID="PagerPanel" runat="server" HorizontalAlign="Right" CssClass="paging">
  <asp:LinkButton ID="LinkFirst" runat="server" Visible="True" onclick="Link_Click" ToolTip="First"><<</asp:LinkButton>
  <asp:LinkButton ID="LinkPrev" runat="server" Visible="True" onclick="Link_Click" ToolTip="Previous">...</asp:LinkButton>
  <asp:LinkButton ID="Link1" runat="server" Visible="True"  onclick="Link_Click">1</asp:LinkButton>
  <asp:LinkButton ID="Link2" runat="server" Visible="True"  onclick="Link_Click">2</asp:LinkButton>
  <asp:LinkButton ID="Link3" runat="server" Visible="True"  onclick="Link_Click">3</asp:LinkButton>
  <asp:LinkButton ID="Link4" runat="server" Visible="True"  onclick="Link_Click">4</asp:LinkButton>
  <asp:LinkButton ID="Link5" runat="server" Visible="True"  onclick="Link_Click">5</asp:LinkButton>
  <asp:LinkButton ID="Link6" runat="server" Visible="True"  onclick="Link_Click">6</asp:LinkButton>
  <asp:LinkButton ID="Link7" runat="server" Visible="True"  onclick="Link_Click">7</asp:LinkButton>
  <asp:LinkButton ID="Link8" runat="server" Visible="True"  onclick="Link_Click">8</asp:LinkButton>
  <asp:LinkButton ID="Link9" runat="server" Visible="True"  onclick="Link_Click">9</asp:LinkButton>
  <asp:LinkButton ID="Link10" runat="server" Visible="True"  onclick="Link_Click">10</asp:LinkButton>
  <asp:LinkButton ID="LinkNext" runat="server" Visible="True" onclick="Link_Click" ToolTip="Next">...</asp:LinkButton>
  <asp:LinkButton ID="LinkLast" runat="server" Visible="True" onclick="Link_Click" ToolTip="Last">>></asp:LinkButton>
 </asp:Panel>
