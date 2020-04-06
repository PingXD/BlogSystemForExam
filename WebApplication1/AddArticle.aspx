<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddArticle.aspx.cs" Inherits="WebApplication1.AddArticle" %>


<!DOCTYPE html>

<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/editormd.css" rel="stylesheet" />
    <link href="css/editormd.preview.css" rel="stylesheet" />

    <script src="https://cdn.bootcss.com/jquery/3.3.1/jquery.js"></script>
    <script src="js/editormd.js"></script>

    <script src="lib/marked.min.js"></script>
    <script src="lib/prettify.min.js"></script>
    <script src="lib/raphael.min.js"></script>
    <script src="lib/underscore.min.js"></script>
    <script src="lib/sequence-diagram.min.js"></script>
    <script src="lib/flowchart.min.js"></script>
    <script src="lib/jquery.flowchart.min.js"></script>

    
    <style>
        @media (min-width: 1200px) {
            .container {
                max-width: 100%;
            }
        }
    </style>
</head>
<body>
    <div id="layout">
        <div class="container">
            <div class="row">
                <!--前缀-->
                <div class="form-group col-lg-6">
                    <div class="input-group">
                        <span class="input-group-addon">文章标题：</span>
                        <input class="form-control" type="text" id="articleTitle" placeholder="请输入文章标题" />
                    </div>
                </div>
                <div class="form-group col-lg-5">
                    <div class="input-group">
                        <span class="input-group-addon">类别：</span>
                        <select id="articleCategory" class="form-control">
                            <option value="0" selected="selected">选择分类</option>
                            <option value="28">人工智能
                            </option>
                            <option value="1">移动开发
                            </option>
                            <option value="29">物联网
                            </option>
                            <option value="15">架构
                            </option>
                            <option value="2">云计算/大数据
                            </option>
                            <option value="17">互联网
                            </option>
                            <option value="30">游戏开发
                            </option>
                            <option value="12">运维
                            </option>
                            <option value="6">数据库
                            </option>
                            <option value="14">前端
                            </option>
                            <option value="31">后端
                            </option>
                            <option value="16">编程语言
                            </option>
                            <option value="3">研发管理
                            </option>
                            <option value="32">安全
                            </option>
                            <option value="33">程序人生
                            </option>
                            <option value="34">区块链
                            </option>
                            <option value="35">音视频开发
                            </option>
                            <option value="36">资讯
                            </option>
                            <option value="37">计算机理论与基础
                            </option>
                        </select>
                    </div>
                </div>
                <div class="form-group col-lg-1">
                    <span id="btnList" class="col-md-1">
                        <button type="button" id="publishArticle" onclick="writeArticle.doSubmit();" class="btn btn-info">发布文章</button>
                    </span>

                </div>

            </div>
        </div>

        <div id="test-editormd">
            <textarea id="articleContent" style="display: none;"></textarea>
        </div>
    </div>

    <script type="text/javascript">
        var testEditor;

        $(function () {
            testEditor = editormd("test-editormd", {
                width: "90%",
                height: 640,
                syncScrolling: "single",
                path: "/lib/",
                emoji: true
            });
            //categorySelect.init();
        });

        /* 文章类别下拉框数据绑定 */
        var categorySelect = {
            init: function () {//初始化数据
                $.ajax({
                    type: "GET",
                    url: '/listArticleCategory.ashx',
                    dataType: 'json',
                    contentType: "application/json",
                    cache: false,
                    success: function (data) {
                        //debugger;
                        data = eval(data);
                        categorySelect.buildOption(data);
                    }
                });
            },
            buildOption: function (data) {//构建下拉框数据
                //debugger;
                var optionStr = "";
                for (var i = 0; i < data.length; i++) {
                    optionStr += "<option value=" + data[i].typeId + ">";
                    optionStr += data[i].name;
                    optionStr += "</option>";
                }
                $("#articleCategory").append(optionStr);
            }
        }

        /* 发送文章*/
        var writeArticle = {
            doSubmit: function () {//提交
                if (writeArticle.doCheck()) {
                    //debugger;
                    var title = $("#articleTitle").val();
                    var content = $("#articleContent").val();
                    var typeId = $("#articleCategory").val();
                    $.ajax({
                        type: "POST",
                        url: 'Handler1.ashx',
                        data: { 'article_title': title, 'article_content': content, 'typeId': typeId },
                        dataType: 'json',
                        //contentType:"application/json",
                        cache: false,
                        success: function (data) {
                            //debugger;
                            if ("success" == data.result) {
                                alert("保存成功!");
                                setTimeout(function () {
                                    window.close();
                                }, 3000);
                            }
                        }
                    });
                }
            },
            doCheck: function () {//校验
                //debugger;
                var title = $("#articleTitle").val();
                var content = $("#articleContent").val();
                if (typeof (title) == undefined || title == null || title == "") {
                    alert("请填写文章标题!");
                    return false;
                }

                if (typeof (content) == undefined || content == null || content == "") {
                    alert("请填写文章内容!");
                    return false;
                }
                //alert(content);
                //alert(testEditor.getMarkdown());
                return true;
            }
        }

</script>
</body>
</html>