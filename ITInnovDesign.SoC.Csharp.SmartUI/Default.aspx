<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ITInnovDesign.SoC.Csharp.SmartUI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Eshop</h1>
        <p class="lead">&nbsp;</p>
        <p>&nbsp;</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Product Discount</h2>
        </div>
        <div class="col-md-4">
             Savings
        <asp:DropDownList ID="ddlDiscountType" runat="server" AutoPostBack="True" 
            onselectedindexchanged="ddlDiscountType_SelectedIndexChanged">
            <asp:ListItem Value="0">No Discount</asp:ListItem>
            <asp:ListItem Value="1">Trade Discount</asp:ListItem>
        </asp:DropDownList>
            <p>
                &nbsp;
                <asp:GridView ID="GridView1" runat="server"
                    AutoGenerateColumns="False"
                    DataKeyNames="ProductId"
                    DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display."
                    OnRowDataBound="GridView1_RowDataBound">
                    <Columns>
                        <asp:BoundField DataField="ProductId" HeaderText="ProductId" ReadOnly="True" SortExpression="ProductId" />
                        <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                        <asp:BoundField DataField="RRP" HeaderText="RRP" SortExpression="RRP" />
                        <asp:TemplateField HeaderText="SellingPrice" SortExpression="SellingPrice">
                    <ItemTemplate>
                        <asp:Label ID="lblSellingPrice" runat="server" Text='<%# Bind("SellingPrice") %>'></asp:Label>
                    </ItemTemplate>                    
                   </asp:TemplateField>
                        <asp:TemplateField HeaderText="Discount">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblDiscount"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Savings">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblSavings">
                                </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShopConnectionString1 %>" DeleteCommand="DELETE FROM [Products] WHERE [ProductId] = @ProductId" InsertCommand="INSERT INTO [Products] ([ProductName], [RRP], [SellingPrice]) VALUES (@ProductName, @RRP, @SellingPrice)" ProviderName="<%$ ConnectionStrings:ShopConnectionString1.ProviderName %>" SelectCommand="SELECT [ProductId], [ProductName], [RRP], [SellingPrice] FROM [Products]" UpdateCommand="UPDATE [Products] SET [ProductName] = @ProductName, [RRP] = @RRP, [SellingPrice] = @SellingPrice WHERE [ProductId] = @ProductId">
                    <DeleteParameters>
                        <asp:Parameter Name="ProductId" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="ProductName" Type="String" />
                        <asp:Parameter Name="RRP" Type="Decimal" />
                        <asp:Parameter Name="SellingPrice" Type="Decimal" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="ProductName" Type="String" />
                        <asp:Parameter Name="RRP" Type="Decimal" />
                        <asp:Parameter Name="SellingPrice" Type="Decimal" />
                        <asp:Parameter Name="ProductId" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
            </p>
        </div>
        <div class="col-md-4">
        </div>
    </div>

</asp:Content>
