#pragma checksum "C:\Users\Vivek\Desktop\DotNet\Assignment29thAugust\Assignment29thAugust\Views\Home\_SingleStudentDetailPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d97e3838c441368872b3971f9aaad53fda93be7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__SingleStudentDetailPartial), @"mvc.1.0.view", @"/Views/Home/_SingleStudentDetailPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_SingleStudentDetailPartial.cshtml", typeof(AspNetCore.Views_Home__SingleStudentDetailPartial))]
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
#line 1 "C:\Users\Vivek\Desktop\DotNet\Assignment29thAugust\Assignment29thAugust\Views\_ViewImports.cshtml"
using Assignment29thAugust;

#line default
#line hidden
#line 2 "C:\Users\Vivek\Desktop\DotNet\Assignment29thAugust\Assignment29thAugust\Views\_ViewImports.cshtml"
using Assignment29thAugust.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d97e3838c441368872b3971f9aaad53fda93be7", @"/Views/Home/_SingleStudentDetailPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f5865a668e9d0f7dba0ee9f4319e7781cbd6ced", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__SingleStudentDetailPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Assignment29thAugust.Models.StudentViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(181, 50, true);
            WriteLiteral("\r\n<table border=\"1\" align=\"center\" width=\"100%\">\r\n");
            EndContext();
#line 7 "C:\Users\Vivek\Desktop\DotNet\Assignment29thAugust\Assignment29thAugust\Views\Home\_SingleStudentDetailPartial.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(272, 140, true);
            WriteLiteral("        <tr style=\"text-align:center;font:large;font-family:\'Franklin Gothic Medium\', \'Arial Narrow\', Arial, sans-serif;\">\r\n            <td>");
            EndContext();
            BeginContext(413, 14, false);
#line 10 "C:\Users\Vivek\Desktop\DotNet\Assignment29thAugust\Assignment29thAugust\Views\Home\_SingleStudentDetailPartial.cshtml"
           Write(item.StudentId);

#line default
#line hidden
            EndContext();
            BeginContext(427, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(451, 16, false);
#line 11 "C:\Users\Vivek\Desktop\DotNet\Assignment29thAugust\Assignment29thAugust\Views\Home\_SingleStudentDetailPartial.cshtml"
           Write(item.StudentName);

#line default
#line hidden
            EndContext();
            BeginContext(467, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(491, 17, false);
#line 12 "C:\Users\Vivek\Desktop\DotNet\Assignment29thAugust\Assignment29thAugust\Views\Home\_SingleStudentDetailPartial.cshtml"
           Write(item.StudentClass);

#line default
#line hidden
            EndContext();
            BeginContext(508, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(532, 15, false);
#line 13 "C:\Users\Vivek\Desktop\DotNet\Assignment29thAugust\Assignment29thAugust\Views\Home\_SingleStudentDetailPartial.cshtml"
           Write(item.StudentAge);

#line default
#line hidden
            EndContext();
            BeginContext(547, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 15 "C:\Users\Vivek\Desktop\DotNet\Assignment29thAugust\Assignment29thAugust\Views\Home\_SingleStudentDetailPartial.cshtml"
    }

#line default
#line hidden
            BeginContext(576, 12, true);
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Assignment29thAugust.Models.StudentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
