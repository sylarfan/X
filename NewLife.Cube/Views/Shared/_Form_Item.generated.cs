﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Shared\_Form_Item.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    
    #line 2 "..\..\Views\Shared\_Form_Item.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Shared\_Form_Item.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Form_Item.cshtml")]
    public partial class _Views_Shared__Form_Item_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Form_Item_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Shared\_Form_Item.cshtml"
  
    var pair = Model as Pair;
    var entity = pair.First as IEntity;
    var item = pair.Second as FieldItem;

    var isInt = item.Type == typeof(Int32);
    var w = isInt ? 4 : 8;

            
            #line default
            #line hidden
WriteLiteral("\r\n<label");

WriteLiteral(" class=\"control-label col-xs-2 col-sm-3\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\Shared\_Form_Item.cshtml"
                                          Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 335), Tuple.Create("\"", 374)
, Tuple.Create(Tuple.Create("", 343), Tuple.Create("input-group", 343), true)
, Tuple.Create(Tuple.Create(" ", 354), Tuple.Create("col-xs-10", 355), true)
, Tuple.Create(Tuple.Create(" ", 364), Tuple.Create("col-sm-", 365), true)
            
            #line 13 "..\..\Views\Shared\_Form_Item.cshtml"
, Tuple.Create(Tuple.Create("", 372), Tuple.Create<System.Object, System.Int32>(w
            
            #line default
            #line hidden
, 372), false)
);

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 14 "..\..\Views\Shared\_Form_Item.cshtml"
Write(Html.ForEditor(item, entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 15 "..\..\Views\Shared\_Form_Item.cshtml"
Write(Html.ForDescription(item));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 16 "..\..\Views\Shared\_Form_Item.cshtml"
    
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Shared\_Form_Item.cshtml"
     if (ViewData.ModelState.ContainsKey(item.Name))
    {

            
            #line default
            #line hidden
WriteLiteral("        <span");

WriteLiteral(" class=\"alert-danger\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 19 "..\..\Views\Shared\_Form_Item.cshtml"
       Write(Html.ValidationMessage(item.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </span>\r\n");

            
            #line 21 "..\..\Views\Shared\_Form_Item.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
