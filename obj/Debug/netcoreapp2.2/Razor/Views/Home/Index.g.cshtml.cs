#pragma checksum "/Users/Guest/Desktop/Survivor.Solution/Survivor/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e96cd3ec00c9e1343efbdaa802120ab5360ca37a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/Guest/Desktop/Survivor.Solution/Survivor/Views/Home/Index.cshtml"
using Survivor.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e96cd3ec00c9e1343efbdaa802120ab5360ca37a", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 26, true);
            WriteLiteral("\n<h1>Survivors!</h1>\n<ul>\n");
            EndContext();
#line 5 "/Users/Guest/Desktop/Survivor.Solution/Survivor/Views/Home/Index.cshtml"
 foreach (Player player in Model)
{
    

#line default
#line hidden
            BeginContext(90, 14, true);
            WriteLiteral("    <li>Name: ");
            EndContext();
            BeginContext(105, 17, false);
#line 8 "/Users/Guest/Desktop/Survivor.Solution/Survivor/Views/Home/Index.cshtml"
         Write(player.PlayerName);

#line default
#line hidden
            EndContext();
            BeginContext(122, 20, true);
            WriteLiteral("</li>\n    <li>Name: ");
            EndContext();
            BeginContext(143, 13, false);
#line 9 "/Users/Guest/Desktop/Survivor.Solution/Survivor/Views/Home/Index.cshtml"
         Write(player.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(156, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 10 "/Users/Guest/Desktop/Survivor.Solution/Survivor/Views/Home/Index.cshtml"
    
}

#line default
#line hidden
            BeginContext(169, 5, true);
            WriteLiteral("</ul>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591