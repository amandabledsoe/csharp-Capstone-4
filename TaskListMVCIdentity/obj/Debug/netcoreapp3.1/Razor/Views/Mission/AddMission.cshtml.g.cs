#pragma checksum "C:\Users\xando\OneDrive\Desktop\ALL GRAND CIRCUS\Grand Circus Projects\Bootcamp Labs & Projects\LABS\ASP.NET\TaskListMVCIdentity\TaskListMVCIdentity\Views\Mission\AddMission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06cac0a20333ffad04489c9193972181210e848f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mission_AddMission), @"mvc.1.0.view", @"/Views/Mission/AddMission.cshtml")]
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
#line 1 "C:\Users\xando\OneDrive\Desktop\ALL GRAND CIRCUS\Grand Circus Projects\Bootcamp Labs & Projects\LABS\ASP.NET\TaskListMVCIdentity\TaskListMVCIdentity\Views\_ViewImports.cshtml"
using TaskListMVCIdentity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\xando\OneDrive\Desktop\ALL GRAND CIRCUS\Grand Circus Projects\Bootcamp Labs & Projects\LABS\ASP.NET\TaskListMVCIdentity\TaskListMVCIdentity\Views\_ViewImports.cshtml"
using TaskListMVCIdentity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06cac0a20333ffad04489c9193972181210e848f", @"/Views/Mission/AddMission.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8350b6069dfb2f65515a2689e3e18e36b0934364", @"/Views/_ViewImports.cshtml")]
    public class Views_Mission_AddMission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\xando\OneDrive\Desktop\ALL GRAND CIRCUS\Grand Circus Projects\Bootcamp Labs & Projects\LABS\ASP.NET\TaskListMVCIdentity\TaskListMVCIdentity\Views\Mission\AddMission.cshtml"
  
    ViewData["Title"] = "AddMission";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>AddMission</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06cac0a20333ffad04489c9193972181210e848f4215", async() => {
                WriteLiteral(@"
    <input type=""date"" name=""DueDate"" placeholder=""Due Date"" />
    <input type=""text"" name=""MissionDescription"" placeholder=""Mission Description"" />
    <input type=""checkbox"" name=""MissionDescription"" value=""true"" /> Complete
    <input type=""checkbox"" name=""MissionDescription"" placeholder=""false"" /> Not Complete

    <input type=""submit"" value=""Add Mission"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 87, "/Mission/AddMission?id=", 87, 23, true);
#nullable restore
#line 8 "C:\Users\xando\OneDrive\Desktop\ALL GRAND CIRCUS\Grand Circus Projects\Bootcamp Labs & Projects\LABS\ASP.NET\TaskListMVCIdentity\TaskListMVCIdentity\Views\Mission\AddMission.cshtml"
AddHtmlAttributeValue("", 110, Model[0].Id, 110, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 17 "C:\Users\xando\OneDrive\Desktop\ALL GRAND CIRCUS\Grand Circus Projects\Bootcamp Labs & Projects\LABS\ASP.NET\TaskListMVCIdentity\TaskListMVCIdentity\Views\Mission\AddMission.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral(";");
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
