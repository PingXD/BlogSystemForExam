<%@ Page Title="" Language="C#" MasterPageFile="~/user.Master" AutoEventWireup="true" CodeBehind="reg.aspx.cs" Inherits="WebApplication1.reg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style type="text/css">
		body {
			margin: 0 auto;
			background-image: url(img/bgd2.png);
			width: 1000px;
		}
		
		.auto-style11 {
			width: 301px;
			height: 66px;
		}
		
		.auto-style12 {
			width: 82px;
			height: 66px;
		}
		
		.auto-style13 {
			width: 82px;
		}
		
		.auto-style14 {
			width: 89px;
			height: 38px;
		}
		
		.auto-style15 {
			width: 63px;
			height: 37px;
		}
		
		.auto-style16 {
			width: 188px;
			height: 124px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
	<table class="auto-style2">
		<tr>
			<td class="auto-style4"></td>
			<td class="auto-style7" colspan="2">
				<img alt="" class="auto-style16" src="img/title.png" /></td>
			<td class="auto-style3"></td>
		</tr>
		<tr>
			<td class="auto-style5" rowspan="6">&nbsp;</td>
			<td class="auto-style12">
				<img alt="" class="auto-style14" src="img/uname.png" /></td>
			<td class="auto-style11">
				<asp:TextBox ID="unmbox" runat="server" Height="26px" Width="221px"></asp:TextBox>
			</td>
			<td rowspan="6">&nbsp;</td>
		</tr>
		<tr>
			<td class="auto-style13" rowspan="2">
				<img alt="" class="auto-style15" src="img/pwd.png" /></td>
			<td class="auto-style8">
				<asp:TextBox ID="pwdbox" runat="server" Height="26px" Width="221px" TextMode="Password"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td class="auto-style8">
				<asp:TextBox ID="pwdboxy" runat="server" Height="26px" Width="221px" TextMode="Password"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td class="auto-style13">&nbsp;</td>
			<td class="auto-style8">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Button ID="Button1" runat="server" Height="33px" OnClick="Button1_Click" Text="注册" Width="79px" />
			</td>
		</tr>
		<tr>
			<td class="auto-style13">&nbsp;</td>
			<td class="auto-style8">&nbsp;</td>
		</tr>
		<tr>
			<td class="auto-style6"></td>
			<td class="auto-style9" colspan="2">&nbsp;</td>
			<td class="auto-style1"></td>
		</tr>
	</table>
	<script type="text/javascript" color="0,174,255" opacity='0.7' zIndex="-2" count="200" src="/js/back.js"></script>
</asp:Content>