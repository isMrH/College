<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Rss.aspx.cs" Inherits="Rss" ContentType="text/xml" %>

<asp:Repeater id="rptRss" runat="server">

<HeaderTemplate>
<rss version="2.0">
<channel>
<title>第三极网络书店</title>
<link>www.apatech.com</link>
<description>第三极网络书店</description>
<copyright>Copyright 2007-2009 by 第三极网络书店</copyright>
</HeaderTemplate>

<ItemTemplate>
<item>
<title><%# EnCode(Eval("Title"))%></title>
<author><%# EnCode(Eval("Author"))%></author>
<description><%# EnCode(Eval("ContentDescription"))%></description>
<link><%# EnCode(GetUrl(Eval("ID")))%></link>
<pubDate><%# EnCode(string.Format("{0:D}", Eval("PublishDate")))%></pubDate>
</item>
</ItemTemplate>

<FooterTemplate>
</channel>
</rss>
</FooterTemplate>

</asp:Repeater>