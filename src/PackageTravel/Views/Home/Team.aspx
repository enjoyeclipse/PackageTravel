<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
    
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="contentbar"> 

        <div class="container"> 
        
		<div class="ten columns alpha" id="team"> 
			<h2>关于团队</h2> 
			<p> 
				口袋旅行主要由曾健,武小萌,蒋明峰建立. 
				虽然专业背景不同，但我们都热爱旅游，同时也喜欢倒腾互联网和移动终端。每周我们都会一起聚会，
				讨论些互联网的事情。
			</p> 
			<p>&nbsp;</p> 
			<div class="row clearfix"> 
				<div class="five columns alpha"> 
					<h4>曾健</h4> 
					<p> 
						项目的发起者和技术负责人
					</p> 
					
				</div> 
				
			</div> 
			
			<div class="row clearfix"> 
				
				<div class="five columns alpha"> 
					<h4>武晓萌</h4> 
					<p> 
						负责项目的产品和界面设计
					</p> 
					
 
				</div> 
			</div> 
			
			<div class="row clearfix"> 
				<div class="five columns alpha"> 
					<h4>蒋明峰</h4> 
					<p> 
						负责项目的商务和运营工作
					</p> 
					
				
				</div> 
			
				
			</div> 
 
		</div> 
	</div> 
 		
	</div> 
</asp:Content>
