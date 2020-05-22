<%@ Page Title="" Language="C#" MasterPageFile="~/user.Master" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="WebApplication1.user1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

	<style type="text/css">
		body {
			margin: 0 auto;
			background-image: url(img/bgd2.png);
			width: 1000px;
		}
		
		.auto-style12 {
			height: 57px;
		}
		
		.auto-style13 {
			height: 57px;
			width: 96px;
		}
		
		.auto-style14 {
			width: 96px;
			height: 174px;
		}
		
		.auto-style15 {
			height: 57px;
			width: 289px;
		}
		
		.auto-style16 {
			width: 289px;
			height: 174px;
		}
		
		.auto-style17 {
			height: 61px;
			width: 96px;
		}
		
		.auto-style18 {
			height: 61px;
			width: 289px;
		}
		
		.auto-style19 {
			height: 61px;
		}
		
		.auto-style20 {
			height: 174px;
		}
		
		.auto-style21 {
			width: 89px;
			height: 38px;
		}
		
		.auto-style22 {
			width: 61px;
			height: 37px;
		}
		
		.auto-style23 {
			width: 100%;
			height: 598px;
		}
		
		.auto-style25 {
			width: 289px;
			height: 44px;
		}
		
		.auto-style26 {
			width: 289px;
			height: 31px;
		}
		
		.auto-style27 {
			width: 188px;
			height: 124px;
		}
	</style>
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">

	<body style="height: 596px; width: 580px">
		<table class="auto-style2">
			<tr>
				<td class="auto-style4"></td>
				<td class="auto-style3">
					<img alt="" class="auto-style27" src="img/title.png" /></td>
				<td class="auto-style3"></td>
			</tr>
			<tr>
				<td class="auto-style5">&nbsp;</td>
				<td>
					<table class="auto-style23">
						<tr>
							<td class="auto-style13">
								<img alt="" class="auto-style21" src="img/uname.png" /></td>
							<td class="auto-style15">
								<asp:TextBox ID="UNBox" runat="server" Height="30px" Width="279px"></asp:TextBox>
							</td>
							<td class="auto-style12"></td>
						</tr>
						<tr>
							<td class="auto-style17">&nbsp;
								<img alt="" class="auto-style22" src="img/pwd.png" /></td>
							<td class="auto-style18">
								<asp:TextBox ID="PWDBox" runat="server" Height="30px" Width="279px" TextMode="Password"></asp:TextBox>
							</td>
							<td class="auto-style19"></td>
						</tr>
						<tr>
							<td class="auto-style14" rowspan="3"></td>
							<td class="auto-style26">&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
								<asp:Button ID="Button1" runat="server" Height="31px" Text="登陆" Width="68px" OnClick="Button1_Click" />
							</td>
							<td class="auto-style20" rowspan="3"></td>
						</tr>
						<tr>
							<td class="auto-style25">
								在线人数：
								<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
								<br /> 共计访问人数：
								<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
							</td>
						</tr>
						<tr>
							<td class="auto-style16">&nbsp;</td>
						</tr>
					</table>
				</td>
				<td>&nbsp;</td>
			</tr>
			<tr>
				<td class="auto-style6"></td>
				<td class="auto-style1">&nbsp;</td>
				<td class="auto-style1"></td>
			</tr>
		</table>
	</body>
	<script type="text/javascript" color="0,174,255" opacity='0.7' zIndex="-2" count="200" src="/js/back.js"></script>
</asp:Content>