#pragma checksum "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\Library\BookDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cacd41b78891bac2febc32fa856f1c3570419c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Library_BookDetail), @"mvc.1.0.view", @"/Views/Library/BookDetail.cshtml")]
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
#line 1 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\_ViewImports.cshtml"
using LibraryWebProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\_ViewImports.cshtml"
using LibraryWebProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cacd41b78891bac2febc32fa856f1c3570419c2", @"/Views/Library/BookDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2dd9b2b592b938053875f387391e38843cfaa1e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Library_BookDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LibraryWebProject.Models.BookModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mx-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 120px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Library", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\Library\BookDetail.cshtml"
  
    ViewData["Title"] = "BookDetail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-dark table-hover table-striped\">\r\n    <thead>\r\n        <th>");
#nullable restore
#line 8 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\Library\BookDetail.cshtml"
       Write(Html.DisplayNameFor(x => x.BookName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 9 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\Library\BookDetail.cshtml"
       Write(Html.DisplayNameFor(x => x.PageNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 10 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\Library\BookDetail.cshtml"
       Write(Html.DisplayNameFor(x => x.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 11 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\Library\BookDetail.cshtml"
       Write(Html.DisplayNameFor(x => x.PublishDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 12 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\Library\BookDetail.cshtml"
       Write(Html.DisplayNameFor(x => x.Publisher));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 13 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\Library\BookDetail.cshtml"
       Write(Html.DisplayNameFor(x => x.BookInformation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 14 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\Library\BookDetail.cshtml"
       Write(Html.DisplayNameFor(x => x.BookPhotos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\Library\BookDetail.cshtml"
         foreach (var book in Model.Where(x => x.isDeleted == false))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\Library\BookDetail.cshtml"
               Write(book.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\Library\BookDetail.cshtml"
               Write(book.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\Library\BookDetail.cshtml"
               Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\Library\BookDetail.cshtml"
               Write(book.PublishDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\Library\BookDetail.cshtml"
               Write(book.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\Library\BookDetail.cshtml"
               Write(book.BookInformation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8cacd41b78891bac2febc32fa856f1c3570419c29501", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 996, "~/BookPhotoFile/", 996, 16, true);
#nullable restore
#line 26 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\Library\BookDetail.cshtml"
AddHtmlAttributeValue("", 1012, book.BookPhotos.FirstOrDefault().PhotoName, 1012, 43, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cacd41b78891bac2febc32fa856f1c3570419c211234", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\Library\BookDetail.cshtml"
                                                                            WriteLiteral(book.BookID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Berlevo\Desktop\ASP_Net_MVC\ASP_MVC_Projects\LibraryWebProject\Views\Library\BookDetail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LibraryWebProject.Models.BookModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
