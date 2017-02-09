<%--<%@ Page Language="C#" AutoEventWireup="true" CodeFile="easy2.aspx.cs" Inherits="easy" %>
<%@ Import Namespace="AgileFrame.Orm.PersistenceLayer.Model" %>
--%>


<!doctype html>
<html>

	<head>
		<meta charset="UTF-8">
		<title></title>
		<meta name="viewport" content="width=device-width,initial-scale=1,minimum-scale=1,maximum-scale=1,user-scalable=no" />
		<link href="css/mui.min.css" rel="stylesheet" />
		<link href="css/easy2.css" rel="stylesheet" />
       
        <link href="//at.alicdn.com/t/font_pcuqq7o8sldz33di.css" rel="stylesheet" />
     
       



    
	</head>

	
	<!-- 缩放式侧滑（类手机QQ） -->
	<!-- 侧滑导航根容器 -->
	<div class="mui-off-canvas-wrap mui-draggable cehua">
	  <!-- 菜单容器 -->
	  <aside class="mui-off-canvas-left mui-transitioning" id="cehua">
	    <div class="mui-scroll-wrapper">
	      <div class="mui-scroll">
	        <!-- 菜单具体展示内容 -->
	        <div  class="title">果易数码</div>
	        <div class="content">产品列表</div>
 <ul class="mui-table-view mui-table-view-chevron mui-table-view-inverted">
   <%--  <% foreach( T_Category item in listcategory){  %>
    <li class="mui-table-view-cell">
        <a class="mui-navigate-right" href="easy2.aspx?Category=<%=item.Id %>"> <%=item.Name %></a>
    </li>
     <%} %>--%>

</ul>
	        <p style="margin: 10px 15px;">
		<button id="cehuahide" type="button" class="mui-btn mui-btn-danger mui-btn-block" style="padding: 5px 20px;">左滑关闭</button>
			</p>
			
	      </div>
	     
	    
	    </div>
	  </aside>
	  <!-- 主页面容器 -->
	  <div class="mui-inner-wrap mui-transitioning">
	    <!-- 主页面标题 -->
	    <header class="mui-bar mui-bar-nav">
	      <a class="mui-icon mui-action-menu mui-icon-bars mui-pull-left" href="#cehua"></a>
	      <h1 class="mui-title">果易</h1>
	    </header>
	    <div class="mui-content mui-scroll-wrapper">
	      <div class="mui-scroll">
	        <!-- 主界面具体展示内容 -->
		<div class="mui-content">
			<ul class="mui-table-view mui-grid-view mui-grid-9">
             <%--   <%foreach(T_ejiCategory item in listeji){ %>
		            <li class="mui-table-view-cell mui-media mui-col-xs-4 mui-col-sm-3"><a href="easy4.aspx">
		                    <span class="mui-icon iconfont <%= ' '+item.Icom %>"></span>
		                    <div class="mui-media-body"><%=item._Ejiname %></div></a></li>
                <%} %>
              --%>
		
		        </ul>
			


		
		</div>
	      </div>
	    </div>  
	    <div class="mui-off-canvas-backdrop"></div>
	  </div>
	</div>
		<nav class="mui-bar mui-bar-tab ">
			<a class="mui-tab-item" href="#Popover_0">故事</a>
			<a class="mui-tab-item mui-active" href="#Popover_1">还会</a>
			<a class="mui-tab-item" href="#Popover_2">继续上演</a>
		</nav>
		<div id="Popover_0" class="mui-popover mui-bar-popover" style="width: 30%;" >
			<div class="mui-popover-arrow"></div>
			<ul class="mui-table-view">
				<li class="mui-table-view-cell"><a href="easy.aspx">首页</a>
				</li>
				<li class="mui-table-view-cell"><a href="easy2.aspx?id=1">产品分类页</a>
				</li>
				<li class="mui-table-view-cell"><a href="easy3.aspx">产品页</a>
				</li>
			</ul>
		</div>
		<div id="Popover_1" class="mui-popover mui-bar-popover"  style="width: 30%">
			<div class="mui-popover-arrow"></div>
			<ul class="mui-table-view">
				<li class="mui-table-view-cell"><a href="#">PC方案</a>
				</li>
				<li class="mui-table-view-cell"><a href="#">手机方案</a>
				</li>
				<li class="mui-table-view-cell"><a href="#">TV方案</a>
				</li>
			</ul>
		</div>
		<div id="Popover_2" class="mui-popover mui-bar-popover" style="width: 30%">
			<div class="mui-popover-arrow"></div>
			<ul class="mui-table-view">
				<li class="mui-table-view-cell"><a href="#">公司新闻</a>
				</li>
				<li class="mui-table-view-cell"><a href="#">行业新闻</a>
				</li>
			</ul>
		</div>
	<body>
		<script src="js/mui.min.js"></script>
		<script src="//cdn.bootcss.com/jquery/2.2.4/jquery.js"></script>

	<!--<script src="js/easy.js"></script>-->
		<script type="text/javascript">

		    mui('body').on('tap', 'a', function () { document.location.href = this.href; });//超链接无效用


		</script>
	</body>

</html>

