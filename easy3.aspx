﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="easy3.aspx.cs" Inherits="easy" %>
<%@ Import Namespace="AgileFrame.Orm.PersistenceLayer.Model" %>


<!doctype html>
<html>

	<head>
		<meta charset="UTF-8">
		<title></title>
		<meta name="viewport" content="width=device-width,initial-scale=1,minimum-scale=1,maximum-scale=1,user-scalable=no" />
		<link href="css/mui.min.css" rel="stylesheet" />
		<link href="css/easy.css" rel="stylesheet" /
			<script src="js/mui.js"></script>
			
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
<%--     <% foreach( T_Category item in listcategory){  %>
    <li class="mui-table-view-cell">
        <a  href="easy2.aspx?Category=<%=item.Id %>" class="mui-navigate-right"> <%=item.Name %></a>
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
		

		<div class="mui-card">
			
	<!--页眉，放置标题-->
	<div class="mui-card-header">苹果手机</div>
	<!--内容区-->
	<div class="mui-card-content " >
		
		<div id="slider" class="mui-slider" >
		  <div class="mui-slider-group mui-slider-loop">
		    <!-- 额外增加的一个节点(循环轮播：第一个节点是最后一张轮播) -->
		    <div class="mui-slider-item mui-slider-item-duplicate">
		      <a href="#">
		        <img src="images/cbd.jpg" />
		      </a>
		    </div>
		    <!-- 第一张 -->
		    <div class="mui-slider-item">
		      <a href="#">
		     <img src="images/cbd.jpg" />
		      </a>
		    </div>
		    <!-- 第二张 -->
		    <div class="mui-slider-item">
		      <a href="#">
		    <img src="images/muwu.jpg" />
		      </a>
		    </div>
		    <!-- 第三张 -->
		    <div class="mui-slider-item">
		      <a href="#">
                  <img src="images/shuijiao.jpg" />
		      </a>
		    </div>
		    <!-- 第四张 -->
		    <div class="mui-slider-item">
		      <a href="#">
		      <img src="images/yuantiao.jpg" />
		      </a>
		    </div>
		    <!-- 额外增加的一个节点(循环轮播：最后一个节点是第一张轮播) -->
		    <div class="mui-slider-item mui-slider-item-duplicate">
		      <a href="#">
                  <img src="images/cbd.jpg" />
		      
		      </a>
		    </div>
		  </div>
		  <div class="mui-slider-indicator">
		    <div class="mui-indicator mui-active"></div>
		    <div class="mui-indicator"></div>
		    <div class="mui-indicator"></div>
		    <div class="mui-indicator"></div>
		  </div>
		</div>
	</div>
	<!--页脚，放置补充信息或支持的操作-->
	 <ul class="mui-table-view"> 
        <li class="mui-table-view-cell mui-collapse">
            <a class="mui-navigate-right" href="#">查看参数</a>
            <div class="mui-collapse-content">
               <a href="baidu.com"> <p>参数介绍</p></a>
            </div>
        </li>
    </ul>
      
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

		<script src="js/mui.min.js"></script>
		<script src="//cdn.bootcss.com/jquery/2.2.4/jquery.js"></script>
	<!--<script src="js/easy.js"></script>-->
		<script type="text/javascript">

		    mui.init();


		    $(document).ready(function () {

		        $("#cehuahide").click(function () {
		            mui('.mui-off-canvas-wrap').offCanvas('show');
		        });
		    });
		    mui('body').on('tap', 'a', function () { document.location.href = this.href; });//超链接无效用
		</script>
	</body>

</html>