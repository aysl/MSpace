﻿#pragma checksum "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5E599A4A4984ED5E68D44BE79686777DA2EC85DD"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18034
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    
    
    public class _Page_Areas_Admin_Views_Shared__Layout_cshtml : System.Web.Mvc.WebViewPage<dynamic> {
        
#line hidden

        
        public _Page_Areas_Admin_Views_Shared__Layout_cshtml() {
        }
        
        protected ASP.global_asax ApplicationInstance {
            get {
                return ((ASP.global_asax)(Context.ApplicationInstance));
            }
        }
        
        public override void Execute() {
WriteLiteral(@"<!DOCTYPE html>
<html>
<head>
    <meta charset=""utf-8"" />
    <!-- Always force latest IE rendering engine (even in intranet) & Chrome Frame -->
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"" />
    <!-- Mobile viewport optimized: h5bp.com/viewport -->
    <meta name=""viewport"" content=""width=device-width"">
    <link rel=""shortcut icon"" type=""image/x-icon"" href=""");


            
            #line 9 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                                   Write(Url.Content("~/Content/admin/favicon.ico"));

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n    <title>");


            
            #line 10 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(@"</title>

    <!-- remove or comment this line if you want to use the local fonts -->
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700' rel='stylesheet' type='text/css'>

    <link rel=""stylesheet"" type=""text/css"" href=""");


            
            #line 15 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                            Write(Url.Content("~/Content/admin/css/bootstrap.css"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"");


            
            #line 16 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                            Write(Url.Content("~/Content/admin/css/bootstrap-responsive.css"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"");


            
            #line 17 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                            Write(Url.Content("~/Content/admin/css/bootmetro.css"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"");


            
            #line 18 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                            Write(Url.Content("~/Content/admin/css/bootmetro-tiles.css"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"");


            
            #line 19 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                            Write(Url.Content("~/Content/admin/css/bootmetro-charms.css"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"");


            
            #line 20 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                            Write(Url.Content("~/Content/admin/css/metro-ui-light.css"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"");


            
            #line 21 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                            Write(Url.Content("~/Content/admin/css/icomoon.css"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"");


            
            #line 22 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                            Write(Url.Content("~/Content/admin/css/datepicker.css"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    \r\n\r\n    <!-- Le fav and touch icons -->\r\n    <link rel=\"shortcut icon\" hr" +
"ef=\"content/ico/favicon.ico\">\r\n    <link rel=\"apple-touch-icon-precomposed\" size" +
"s=\"144x144\" href=\"");


            
            #line 27 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                                              Write(Url.Content("~/Content/admin/ico/apple-touch-icon-144-precomposed.png"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <link rel=\"apple-touch-icon-precomposed\" sizes=\"114x114\" href=\"");


            
            #line 28 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                                              Write(Url.Content("~/Content/admin/ico/apple-touch-icon-114-precomposed.png"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <link rel=\"apple-touch-icon-precomposed\" sizes=\"72x72\" href=\"");


            
            #line 29 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                                            Write(Url.Content("~/Content/admin/ico/apple-touch-icon-72-precomposed.png"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <link rel=\"apple-touch-icon-precomposed\" href=\"");


            
            #line 30 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                              Write(Url.Content("~/Content/admin/ico/apple-touch-icon-57-precomposed.png"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\r\n    <script src=\"");


            
            #line 32 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
            Write(Url.Content("~/Scripts/jquery-1.7.2.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n    <script src=\"");


            
            #line 33 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
            Write(Url.Content("~/Scripts/jquery.transit.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n    <script src=\"");


            
            #line 34 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
            Write(Url.Content("~/Scripts/jquery.unobtrusive-ajax.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n    <script src=\"");


            
            #line 35 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
            Write(Url.Content("~/Scripts/jquery.validate.min.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n    <script src=\"");


            
            #line 36 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
            Write(Url.Content("~/Scripts/jquery.validate.unobtrusive.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n    <script src=\"");


            
            #line 37 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
            Write(Url.Content("~/Scripts/modernizr-2.5.3.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n    <script src=\"");


            
            #line 38 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
            Write(Url.Content("~/Scripts/jQuery.tmpl.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n    <script src=\"");


            
            #line 39 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
            Write(Url.Content("~/Scripts/jquery-ui-1.10.0.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n\r\n    <link href=\"");


            
            #line 41 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
           Write(Url.Content("~/Content/widgets/artDialog/skins/twitter.css"));

            
            #line default
            #line hidden
WriteLiteral("\" rel=\"stylesheet\" type=\"text/css\" />\r\n    <script src=\"");


            
            #line 42 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
            Write(Url.Content("~/Content/widgets/artDialog/artDialog.min.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n\r\n    <link href=\"");


            
            #line 44 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
           Write(Url.Content("~/Content/widgets/showDialog/showDialog.css"));

            
            #line default
            #line hidden
WriteLiteral("\" rel=\"stylesheet\" type=\"text/css\" />\r\n    <script src=\"");


            
            #line 45 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
            Write(Url.Content("~/Content/widgets/showDialog/showDialog.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n    \r\n    <script src=\"http://js.live.net/v5." +
"0/wl.js\"></script>\r\n    \r\n    <script type=\"text/javascript\" src=\"");


            
            #line 49 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                   Write(Url.Content("~/Scripts/jsrender.js"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n\r\n    ");


            
            #line 51 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", false));

            
            #line default
            #line hidden
WriteLiteral(@"

    <script type=""text/javascript"">
        
    </script>
</head>

<body>
    <!-- Header ================================================== -->
    <header id=""nav-bar"" class=""container-fluid"">
        <div class=""row-fluid"">
            <div class=""span8"">
                <div id=""header-container"">
                    ");



WriteLiteral("\r\n                    <a class=\"win-backbutton\" href=\"");


            
            #line 70 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                               Write(Context.Request.UrlReferrer);

            
            #line default
            #line hidden
WriteLiteral("\" id=\"backbutton\"> </a>\r\n                    ");



WriteLiteral("\r\n                    <h5><b class=\"icon-cube\"></b> <strong> MSpace</strong></h5>" +
"\r\n                    <div class=\"dropdown\">\r\n                        ");



WriteLiteral(@"
                        <a class=""header-dropdown dropdown-toggle accent-color"" data-toggle=""dropdown"" href=""#"">
                            开始
                            <b class=""caret""></b>
                        </a>
                        <ul class=""dropdown-menu"">
                            <li><a href=""");


            
            #line 80 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                    Write(Url.RouteUrl(new { controller = "Article", action = "Write" }));

            
            #line default
            #line hidden
WriteLiteral("\">写文章</a></li>\r\n                            <li><a href=\"");


            
            #line 81 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                    Write(Url.RouteUrl(new { controller = "Twitter", action = "Index" }));

            
            #line default
            #line hidden
WriteLiteral(@""">碎语</a></li>
                            <li><a href=""./appbar-demo.html"">Demo App-Bar</a></li>
                            <li><a href=""./table.html"">Demo Table</a></li>
                            <li><a href=""./icons.html"">Icons</a></li>
                            <li><a href=""./scaffolding.html"">Bootstrap Scaffolding</a></li>
                            <li><a href=""./base-css.html"">Bootstrap Base CSS</a></li>
                            <li><a href=""./components.html"">Bootstrap Components</a></li>
                            <li><a href=""./javascript.html"">Bootstrap Javascript</a></li>
                            <li class=""divider""></li>
                            <li>");


            
            #line 90 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                           Write(Html.RouteLink(
                                    linkText: "返回首页",
                                    routeName: "DefaultRoute",
                                    routeValues: new { controller="Home", action="Index" }
                                ));

            
            #line default
            #line hidden
WriteLiteral(@"
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div id=""top-info"" class=""pull-right"">
                <a href=""#"" class=""pull-left"">
                    <div class=""top-info-block"">
                        <h3>常</h3>
                        <h4>伟华</h4>
                    </div>
                    <div class=""top-info-block"">
                        <b class=""icon-user-3""></b>
                    </div>
                    </a>
                    <hr class=""separator pull-left""/>
                    <a id=""settings"" class=""pull-left"" href=""#"">
                        <b class=""icon-settings""></b>
                    </a>
                </div>
        </div>
    </header>
    
    <div class=""container-fluid"">
        <div class=""row-fluid"">
            ");


            
            #line 120 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral(@"
        </div>
    </div>

    <footer id=""commandContainer"" class=""win-commandlayout win-ui-dark navbar-fixed-bottom"">
        <div class=""container"">
            <div class=""row"">
                <div class=""span6 align-left"">
                    <a class=""win-command"" href=""");


            
            #line 128 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                            Write(Url.RouteUrl(new { controller = "Home", action = "Index" }));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        <span class=\"win-commandimage win-commandring\">&#x002" +
"1;</span>\r\n                        <span class=\"win-label\">主页</span>\r\n          " +
"          </a>\r\n                    <a class=\"win-command\" href=\"");


            
            #line 132 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                            Write(Context.Request.Url);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        <span class=\"win-commandimage win-commandring\">&#xe1d" +
"e;</span>\r\n                        <span class=\"win-label\">刷新页面</span>\r\n        " +
"            </a>\r\n                    <hr class=\"win-command\" />\r\n              " +
"      ");


            
            #line 137 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
               Write(RenderSection("LeftFooter", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div class=\"span6 align-right\">\r\n      " +
"              ");



WriteLiteral("\r\n                    ");


            
            #line 148 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
               Write(RenderSection("RightFooter", false));

            
            #line default
            #line hidden
WriteLiteral(@"
                </div>
            </div>
        </div>
    </footer>
    
   
    <div id=""charms"" class=""win-ui-dark"">
        <div id=""theme-charms-section"" class=""charms-section"">
            <div class=""charms-header"">
                <a href=""#"" class=""close-charms win-command"">
                    <span class=""win-commandimage win-commandring"">&#xe05d;</span>
                </a>
                <h2>系统设置</h2>
            </div>
            <div class=""row-fluid"">
                <div class=""span12"">
                    <form class="""">
                        <label for=""win-theme-select"">Change theme:</label>
                        <select id=""win-theme-select"" class="""">
                            <option value=""metro-ui-semilight"">Semi-Light</option>
                            <option value=""metro-ui-light"">Light</option>
                            <option value=""metro-ui-dark"">Dark</option>
                        </select>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <!-- Grab Google CDN's jQuery. fall back to local if necessary -->  
    ");



WriteLiteral("\r\n    ");



WriteLiteral("\r\n\r\n    <script type=\"text/javascript\" src=\"");


            
            #line 183 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                   Write(Url.Content("~/Content/admin/scripts/jquery.mousewheel.js"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n    <script type=\"text/javascript\" src=\"");


            
            #line 184 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                   Write(Url.Content("~/Content/admin/scripts/jquery.scrollTo.js"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n    <script type=\"text/javascript\" src=\"");


            
            #line 185 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                   Write(Url.Content("~/Content/admin/scripts/bootstrap.min.js"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n    <script type=\"text/javascript\" src=\"");


            
            #line 186 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                   Write(Url.Content("~/Content/admin/scripts/bootstrap-datepicker.js"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n    <script type=\"text/javascript\" src=\"");


            
            #line 187 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                   Write(Url.Content("~/Content/admin/scripts/bootmetro.js"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n    <script type=\"text/javascript\" src=\"");


            
            #line 188 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                   Write(Url.Content("~/Content/admin/scripts/bootmetro-charms.js"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n    <script type=\"text/javascript\" src=\"");


            
            #line 189 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                   Write(Url.Content("~/Content/admin/scripts/holder.js"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n    <script type=\"text/javascript\" src=\"");


            
            #line 190 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                   Write(Url.Content("~/Content/admin/scripts/jquery.blockUI.js"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n    <script type=\"text/javascript\" src=\"");


            
            #line 191 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\Shared\_Layout.cshtml"
                                   Write(Url.Content("~/Content/admin/scripts/mustache.js"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n\r\n    <script type=\"text/javascript\">\r\n       $(\".metro\").metro();\r\n" +
"    </script>   \t\r\n</body>\r\n</html>\r\n");


        }
    }
}
