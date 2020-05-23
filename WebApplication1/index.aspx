<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication1.WebForm1"  %>

<!DOCTYPE html>
<html>

	<head>
		<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
		<meta content="width=device-width, initial-scale=1, maximum-scale=1" name="viewport">
		<title>PingX Blog</title>
		<link href="css/font-awesome.min.css" type="text/css" rel="stylesheet">
		<link href="css/bootstrap.css" type="text/css" rel="stylesheet">
		<script src="https://cdn.bootcss.com/jquery/3.3.1/jquery.js"></script>
		<script src="lib/jquery.flowchart.min.js"></script>
		<link href="css/style.css" type="text/css" rel="stylesheet">

    <link rel="stylesheet" href="css/editormd.css" />

    <script src="js/jquery.min.js"></script>
    <script src="js/base64.min.js "></script>
    <script src="lib/marked.min.js "></script>
    <script src="lib/prettify.min.js "></script>
    <script src="lib/raphael.min.js "></script>
    <script src="lib/underscore.min.js "></script>
    <script src="/lib/sequence-diagram.min.js "></script>
    <script src="/lib/flowchart.min.js "></script>

    <script src="js/editormd.min.js "></script>

		<style type="text/css">
			.left {
				margin-left: auto;
				width: 50%;
				float: left;
			}
			
			.right {
				margin-right: auto;
				width: 50%;
				float: left;
			}
		</style>
		<script>
            function getQueryVariable(variable) {
                var query = window.location.search.substring(1);
                var vars = query.split("&");
                for (var i = 0; i < vars.length; i++) {
                    var pair = vars[i].split("=");
                    if (pair[0] == variable) { return pair[1]; }
                }
                return (false);
            }
			//url参数获取方法
			function getclassname()
			{
				var classname = getQueryVariable("class");
				if (classname == false) {
                    classname = "all"
				}
				return classname;
			}

      //      var ajaxRquesttitle = $.ajax({

      //          type: "POST",
      //          url: 'PostALLAit.ashx',
      //          data: { 'article_idd': getclassname() },
      //          dataType: 'json',


      //          success: function (data) {
      //              for (id = data.length-1; id >=0 ; id = id - 1) {

						//var biaoti = "<p><a style=\"font-size:26px;\" href='detailed.html?id=" + data[id].article_id + "'>" + data[id].article_title + " </a><br><a style=\"font-size: 13px;\">" + data[id].artcle_content_20 + "</a></p></p>";
      //                  //console.log(data[id-2])
      //                  $(".entry-header").append(biaoti + '<br>');
      //              }

      //          }
      //      });
			//标题ajax
            var ajaxRquestclass = $.ajax({

                type: "POST",
                url: 'PostALLAit.ashx',
                data: { 'article_idd': "title" },
                dataType: 'json',

                //contentType:"application/json",

                success: function (data) {
                    for (clid = 0; clid <= data.length - 1; clid = clid + 1) {

                        //$(".menupbt").append("<li><a href=\"/index.aspx?class=" + data[clid].article_class + "\">" + data[clid].article_class + "</a></li>")
                        $(".article-class").append("<li><a dir=\"ltr\" href=\"/index.aspx?class=" + data[clid].article_class + "\">" + data[clid].article_class + "</li>")

                    }

                    //for (id = 1; id++; id <= data.length) {
                    //    console.log(data[id - 2].article_title);
                    //    var biaoti = "<p><a href='detailed.html?id=" + (id - 1) + "'>" + data[id - 2].article_title + id + " </a></p>";
                    //    console.log(data[id - 2])
                    //    $(".entry-header").append(biaoti + '<br>');
                    //}

                }
			});
			//分类ajax
		</script>
		<style type="text/css">
			.auto-style1 {
				font-size: 100%;
			}
			
			#butt {
				text-align: center;
			}
		</style>
	</head>

	<body>
		<form id="form1" runat="server">
			<div id="pagepbt">
				<header class="site-headerpbt" id="mastheadpbt" role="banner">

					<div class="site-brandingpbt">

						<div class="headersec section" id="headersec">
							<div class="widget Header" data-version="1" id="Header1">
								<div id="header-inner">
									<div class="titlewrapper">
										<h2 class="site-titlenbt">
										<a href="#">PingX</a>
									</h2>
									</div>
									<h2 class="site-descriptionnbt">世界不止眼前的苟且，还有排骨和汤，虾和蟹黄。</h2>
								</div>
							</div>
						</div>
					</div>

					<nav class="main-navigationpbt" id="site-navigationpbt" role="navigation">
						<button class="menu-togglepbt">菜单<i class="fa fa-align-justify"></i></button>
						<div class="menu-pbt-container">
							<ul class="menupbt">
								<li>
									<a href="/index.aspx">首页</a>
								</li>

							</ul>
						</div>
					</nav>
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
															
    <div class="panel-body ">
        <!-- 用于显示md编辑器的md格式 -->
        <div id="doc-content">
            <!--<textarea  style='display:none;'></textarea>-->
        </div>
    </div>
														</header>
														<footer class="entry-footerpbt">
														</footer>
													</article>
												</div>
											</div>
										</div>
										<input type="hidden" id="js_page" name="page" value="1">
<%--										<script>
                                            function search(page) {
                                                var js_form = document.getElementById("js_search");
                                                document.getElementById("js_page").value = page;
                                                js_form.method = 'POST';
                                                js_form.submit();
                                            }
									搜索功能，暂未想到好的方法
										</script>--%>
									</div>
									<div class="clear"></div>
								</div>
							</div>
						</div>
					</div>
					<div class="widget-areapbt" id="secondarypbt" role="complementary">

						<div class="widget widget_search">
							<div class="search-formpbt">
								<script>
                                    $(function () {
                                        $("#Button1").click(function () {
                                            window.open('/AddArticle.aspx?uid=' + getQueryVariable("uid"));
                                        });
                                    });
								</script>
								<div id="butt">
									<input id="Button1" type="button" value="发布" />
									<input id="Button2" type="button" value="登陆" onclick="window.location = '/user.aspx'" />
									<input id="Button3" type="button" value="注册" onclick="window.location = '/reg.aspx'" />

								</div>
							</div>
						</div>
						<div class="sidebarrightsec section" id="sidebarrightsec">
							<div class="widget Label" data-version="1" id="Label0">
								<h2>简介</h2>
								<div class="widget-content list-label-widget-content">
									<ul>
									    <li>
											<a  href="https://github.com/PingXD/">
												GitHub主页
											</a>
										</li>
                                        <li>
											<a  href="#">
												邮箱:admin@pingx.cc
											</a>
                                        </li>

									</ul>
								</div>
							</div>

							<div class="sidebarrightsec section" id="sidebarrightsec">
								<div class="widget Label" data-version="1" id="Label1">
									<h2>文章分类</h2>
									<div class="widget-content list-label-widget-content">
										<ul class="article-class">
											<li><a dir="ltr" href="/index.aspx"> 全部文章</a></li>
										</ul>
										<div class="clear"></div>
									</div>
								</div>
							</div>

						</div>
		</form>
		<div align="center">
			<div class="left">
				在线人数：
				<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
			</div>
			<div class="right">
				总计访问：
				<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
			</div>
			<div class="cen"></div>
		</div>
	</body>
	<script>
        $(".right").after($(".login"))
	</script>

	
	<script type="text/javascript" color="0,174,255" opacity='0.7' zIndex="-2" count="200" src="/js/back.js"></script>
	<script>
                //var url = decodeURI(window.location.search);
                //result = url.substr(url.indexOf("=") + 1);
                function getQueryVariable(variable) {
                    var query = window.location.search.substring(1);
                    var vars = query.split("&");
                    for (var i = 0; i < vars.length; i++) {
                        var pair = vars[i].split("=");
                        if (pair[0] == variable) { return pair[1]; }
                    }
                    return (false);
                }
                var idname = getQueryVariable("id");
                var ajaxRquest = $.ajax({


                    type: "POST",
                    url: 'GetAllaitcontent.ashx',
                    data: { 'article_idd': idname },
                    dataType: 'json',
                    async: false,
                    //这里被ajax抬了一手，排错四五个小时，要设置ajax同步异步，异步情况下加载完页面 才收到ashx的respon，导致后面的mdjs执行在获取值之前
                    //同步情况下  收到ashx传回的数据之后才继续往下执行
                    //contentType:"application/json ",


                    success: function (data) {
                        //console.log(Base64.decode(data.article_content));
                        var txt1 = "<textarea style='display:none;'>" + Base64.decode(data["0"].article_content) + "</textarea>";
                        $("#doc-content").append(txt1);
                        //console.log(txt1);
                        //console.log(Base64.decode(data.article_content));
                    }
                });
    </script>

	<%--ajax获取文章方法--%>
	<script>
            var testEditor;
            $(function () {
                testEditor = editormd.markdownToHTML("doc-content", { //注意：这里是上面DIV的id
                    htmlDecode: "style,script,iframe",
                    emoji: true,
                    taskList: true,
                    tex: true, // 默认不解析
                    flowChart: true, // 默认不解析
                    sequenceDiagram: true, // 默认不解析
                    codeFold: true
                });
            });
    </script>
	<%--//md方法--%>

</html>