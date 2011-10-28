<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
   
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="headerbar"> 
		
		<div class="container"> 
			<div class="sixteen columns alpha"> 
				<header> 
					<div class="row"> 
						<div class="six columns offset-by-one"> 
							<h1>免费的 <span>交互式</span> 旅游手册 </h1>	
						</div> 
						<div class="six columns offset-by-one omega"> 
							<img src="images/frontpage.png" style="margin-bottom: -100px;"/> 
						</div> 
					</div> 
				</header> 
			</div> 
		</div> 
		
	</div> 

    <div class="container"> 
		<div class="nine columns alpha"> 
			<h3>关于口袋旅行</h3> 
			<p> 
			    我们热爱旅行，但常常为一些琐事所苦恼，比如查找景点，了解天气，寻找路线，甚至是找厕所。当然，这些事情也许本身快乐的，但我们却希望让你更加体验旅行的纯粹，如果有一个随时随地都可以使用的旅行手册该多好。
            </p> 
            <p> 
	口袋旅行就是这样一个工具，你选择去某个地方，然后把那个地方的攻略，地图，最有特色的景点，特色餐厅，甚至是最近三天的天气都下载下来，其中还包含一些驴友的建议。另外，你也可以自己做好攻略最重要的是，即使没有网络，你可以使用口袋旅行。当然，一旦有了网络，也可以同步更新最新的数据。
             
			</p> 
    <p>

	我们目前搜罗了中国30多个大部分主要城市景点和20个川西的自助旅游线路，有300多个经典和50,000多家餐厅的信息，马上免费下载吧。
        </p>
		
		</div> 
		
		<div class="six columns offset-by-one omega"> 
			<h3>&nbsp;</h3> 
			<p> 
				
				<a class="bigaction android" href="/">&nbsp;</a> 
			</p> 
		</div> 

	</div> 

</asp:Content>
