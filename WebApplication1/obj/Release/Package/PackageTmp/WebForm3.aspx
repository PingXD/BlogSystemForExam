<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>
<script>        
    var url = decodeURI(window.location.search);
    result = url.substr(url.indexOf("=") + 1);
    var ajaxRquest = $.ajax({


        type: "POST",
        url: 'PostALLAit.ashx',
        data: { 'article_idd': result },
        dataType: 'json',
        //contentType:"application/json",


        success: function (data) {
            console.log(data.article_content);
            var txt1 = "<textarea style='display:none;'>" + data.article_content + "</textarea>";
            $("#doc-content").append(txt1);
        }
    });</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>



    <script src="js/jquery.min.js"></script>
        
        <link rel="stylesheet" href="css/editormd.css" />
    <link rel="shortcut icon" href="https://pandao.github.io/editor.md/favicon.ico" type="image/x-icon" />
    <script src="lib/marked.min.js"></script>
    <script src="lib/prettify.min.js"></script>
    <script src="lib/raphael.min.js"></script>
    <script src="lib/underscore.min.js"></script>
    <script src="/lib/sequence-diagram.min.js"></script>
    <script src="/lib/flowchart.min.js"></script>
    
    <script src="js/editormd.min.js"></script>


    <style>
        @media (min-width: 1200px) {
            .container {
                max-width: 100%;
            }
        }
    </style>


</head>
<body>

    
    <div class="panel-body">
        <!-- 用于显示md编辑器的md格式 -->
        <div id="doc-content">
       <textarea style='display:none;'></textarea>
        </div>
    </div>
    
    <script>

        var testEditor;
        $(function () {
            testEditor = editormd.markdownToHTML("doc-content", {//注意：这里是上面DIV的id
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


</body>
</html>
