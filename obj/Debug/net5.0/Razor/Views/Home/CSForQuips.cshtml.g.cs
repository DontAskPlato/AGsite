#pragma checksum "C:\Users\AcademyPgh\Desktop\AGsite\Views\Home\CSForQuips.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1656d171c89b73105e6d3cdda8cc19e2ebb05a2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CSForQuips), @"mvc.1.0.view", @"/Views/Home/CSForQuips.cshtml")]
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
#nullable restore
#line 1 "C:\Users\AcademyPgh\Desktop\AGsite\Views\_ViewImports.cshtml"
using AGsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AcademyPgh\Desktop\AGsite\Views\_ViewImports.cshtml"
using AGsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1656d171c89b73105e6d3cdda8cc19e2ebb05a2e", @"/Views/Home/CSForQuips.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fac7c8ca150248d7653895d9a2b91cc761e53db8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CSForQuips : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\AcademyPgh\Desktop\AGsite\Views\Home\CSForQuips.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">CS For Quips!</h1>
</div>

<div class=""vidwrapper"">
    <div class=""vid-container"" id=""first"">
        <iframe class=""video"" src=""https://www.youtube.com/embed/mRuPUh-_pXU"">Video 2</iframe>
    </div>
    <div class=""vid-container"" id=""second"">
        <iframe class=""video"" src=""https://www.youtube.com/embed/lo5cG0FhWro"">Video 2</iframe>
    </div>
</div>

<div>
    <hr />
    <p class=""para"">CS for Quips is a free 6 week virtual computer science course for students in grades 6-10. Students
        will learn the basics of HTML, JavaScript, and CSS to build their own website. The classes will be instructed by
        experienced professionals from Beta Builders [link]. Funding secured with the assistance of Grow a Generation
        STEM Leadership Center [link].</p>
    <hr />
</div>

<div id=""wrapperp"">
    <div>
        <img class=""posters"" src=""\Site Assets\2.png"" id=""firstp"">
    </div>
    <div>
        <img class=""posters""");
            WriteLiteral(@" src=""\Site Assets\4.png"" id=""fourthp"">
    </div>
    <div>
        <img class=""posters"" src=""\Site Assets\3.png"" id=""secondp"">
    </div>
</div>

<style>
    .vidwrapper {
        padding: 3%;
        height: 410px;
        overflow: hidden;
    }

    .vid-container {
        height: 50vh;
        width: 50%;
        text-align: center;

    }

    #wrapperp {
        overflow: hidden;
        display: flex;
        align-content: center;
        margin-bottom: 3%;
    }

    .posters {
        height: 100%;
        width: 75%;
        margin-left: 5%;
        margin-right: 5%;
        border: solid 15px black;
    }

    .video {
        object-fit: cover;
        height: 100%;
        width: 100%;
    }

    #first {
        float: left;
        background-color: red;
    }

    #second {
        float: right;
        background-color: blue;
    }

    .para {
        text-align: center;
    }

    #firstp {}

    #secondp {}

    #fourthp {}
");
            WriteLiteral("\n    body {\r\n        padding-bottom: 0;\r\n    }\r\n</style>");
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
