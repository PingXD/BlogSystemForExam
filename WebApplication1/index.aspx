<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication1.WebForm1"  %>

<!DOCTYPE html>
<html>
	<head>
		<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
		<meta content="width=device-width, initial-scale=1, maximum-scale=1" name="viewport">
		<title>PingX</title>
		<link href="css/font-awesome.min.css" type="text/css" rel="stylesheet">
		<link href="css/bootstrap.css" type="text/css" rel="stylesheet">
		<script src="https://cdn.bootcss.com/jquery/3.3.1/jquery.js"></script>
		<script src="lib/jquery.flowchart.min.js"></script>
		<link href="css/style.css" type="text/css" rel="stylesheet">
		<script>
        $.ajax({
            type: "POST",
            url: 'PostALLAit.ashx',
            data: { 'article_idd': 23 },
            dataType: 'json',
            //contentType:"application/json",
            cache: false,
            success: function (data) {

                }
            
        });
		</script>
	    <style type="text/css">
            .auto-style1 {
                font-size: 100%;
            }
        </style>
	</head>
	<body>
		<form id="form1" runat="server">
		<div id="pagepbt">
			<header class="site-headerpbt" id="mastheadpbt" role="banner">
				在线人数：<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                z<div class="site-brandingpbt">
					<div class="headersec section" id="headersec">
						<div class="widget Header" data-version="1" id="Header1">
							<div id="header-inner">
								<div class="titlewrapper">
									<h2 class="site-titlenbt">
										<a href="#">P<span class="auto-style1">ing</span></a>X
									</h2>
								</div>
								<h2 class="site-descriptionnbt">Hello World</h2>
							</div>
						</div>
					</div>
				</div>
				<div class="site-socialpbt">
				</div>
				<nav class="main-navigationpbt" id="site-navigationpbt" role="navigation">
					<button class="menu-togglepbt">分类菜单<i class="fa fa-align-justify"></i></button>
					<div class="menu-pbt-container">
						<ul class="menupbt">
							<li><a href="#">首页</a></li>
							<li>
								<a href="#">Java</a>
							</li>
							<li>
								<a href="#">PHP</a>
							</li>
						</ul>
					</div>
				</nav>
&nbsp;总计访问：<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
			</header>
			<div class="site-contentpbt" id="contentpbt">
					<div class="content-areapbt" id="primarypbt">
						<div class="site-mainpbt" id="mainpbt" role="main">
							<div class="mainblogsec section" id="mainblogsec">
								<div class="widget" data-version="1" id="Blog1">
									<div class="blog-posts hfeed">
										<div class="date-outer">
											<h2 class="date-header">
												<span>2020-03-05 19:04:35</span>
											</h2>
											<div class="date-posts">
												<div class="post-outer">
													<article class="post hentry">
														<header class="entry-header">
															<h1 class="post-title entry-title" itemprop="name">
																<a href="" runat="server" id="t1"></a>
															</h1>
															<div class="entry-metapbt">
																<span class="post-author vcard">
																	<i class="fa fa-user"></i>&nbsp;
																	<span class="fn" itemprop="author">
																		<a class="g-profile" href="http://javaweb.org/?uid=1" rel="author" title="作者信息">
																			<span itemprop="name">yzmm</span>
																		</a>
																	</span>&nbsp;&nbsp;&nbsp;
																	<i class="fa fa-calendar"></i>&nbsp;

																	<i class="fa fa-folder-o"></i>&nbsp;
																	<a href="http://javaweb.org/?cat=3" rel="tag">Java</a>&nbsp;&nbsp;&nbsp;
																	<i class="fa fa-comments"></i>&nbsp;
																	<a href="http://javaweb.org/#" onclick="">0 comments</a>&nbsp;&nbsp;&nbsp;
																	<i class="fa fa-eye"></i>&nbsp;
																	<a href="http://javaweb.org/#" onclick="">319</a>
																</span>
															</div>
														</header>
														<div class="post-header-line-1"></div>
														<div class="post-body entry-content">
															<div id="summary">
																<div class="separator" style="clear: both;">0000000</div>
															</div>
															<div style="clear: both;"></div>
															<div style="clear: both;"></div>
														</div>
														<footer class="entry-footerpbt">
															<div class="readMoreLinkpbt">
																<a href="http://javaweb.org/?p=1876">Read More<i class="fa spaceLeft fa-angle-double-right"></i></a>
															</div>
														</footer>
													</article>
													<div style="clear: both;"></div>
												</div>
											</div>
										</div>
									</div>
									<div style="clear: both;"></div>
									<div class="blog-pager" id="blog-pager">
										<input type="hidden" id="js_page" name="page" value="1">
										<script>
											function search(page) 
											{
												var js_form = document.getElementById("js_search");
												document.getElementById("js_page").value = page;
												js_form.method = 'POST';
												js_form.submit();
												}
										</script>
									</div>
									<div class="clear"></div>
								</div>
							</div>
						</div>
					</div>
					<div class="widget-areapbt" id="secondarypbt" role="complementary">
						<div class="widget widget_search">
							<div class="search-formpbt">
								<label>
									<span class="screen-reader-text">Search for:</span>
									<input class="search-fieldpbt" name="q" placeholder="Search" title="搜索" type="search" value="">
								</label>
								<input class="search-submitpbt" type="submit" value="Search">
							</div>
						</div>
						<div class="sidebarrightsec section" id="sidebarrightsec">
							<div class="widget Label" data-version="1" id="Label1">
								<h2>最新评论</h2>
								<div class="widget-content list-label-widget-content">
									<ul>
										<li>[test]
											<a dir="ltr" href="#">
												123Hello
											</a>
										</li>
										<li>[365cent]
											评论</li>
									</ul>
								</div>
							</div>

							<div class="sidebarrightsec section" id="sidebarrightsec">
								<div class="widget Label" data-version="1" id="Label1">
									<h2>文章分类</h2>
									<div class="widget-content list-label-widget-content">
										<ul>
											<li>
												<a dir="ltr" href="">Java</a>
												<span dir="ltr">(68)</span>
											</li>
											<li>
												<a dir="ltr" href="">Documents</a>
												<span dir="ltr">(39)</span>
											</li>
										</ul>
										<div class="clear"></div>
									</div>
								</div>
							</div>

							
						</div>
	    </form>
	</body>
</html>
