#pragma checksum "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "736876b4d45defaafb608aad50764e0836a06dae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(National_Healthcare_System.Pages.Organizations.Pages_Organizations_Index), @"mvc.1.0.razor-page", @"/Pages/Organizations/Index.cshtml")]
namespace National_Healthcare_System.Pages.Organizations
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
#line 1 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\_ViewImports.cshtml"
using National_Healthcare_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\_ViewImports.cshtml"
using National_Healthcare_System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
using National_Healthcare_System.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"736876b4d45defaafb608aad50764e0836a06dae", @"/Pages/Organizations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64b3fb00e359604ba7be487c77b891cdec4b2d68", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Organizations_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n");
#nullable restore
#line 12 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
 if (!User.IsInRole(Static_Details.PatientUser))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "736876b4d45defaafb608aad50764e0836a06dae6029", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 17 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Organization[0].Organization_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Organization[0].Registration_No));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Organization[0].Organization_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Organization[0].Organization_Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Organization[0].Organization_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Organization[0].Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
         foreach (var item in Model.Organization)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Organization_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Registration_No));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Organization_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Organization_Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Organization_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "736876b4d45defaafb608aad50764e0836a06dae13418", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
                                           WriteLiteral(item.Organization_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "736876b4d45defaafb608aad50764e0836a06dae15708", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
                                              WriteLiteral(item.Organization_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "736876b4d45defaafb608aad50764e0836a06dae18004", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
                                             WriteLiteral(item.Organization_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 70 "G:\EWU Courses Files\CSE\(8th sem) CSE 347 (Information System Analysis and Design)\Project\FarhanMilkCandy\CSE347ProjectNHS\National Healthcare System\Pages\Organizations\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<National_Healthcare_System.Pages.Organizations.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<National_Healthcare_System.Pages.Organizations.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<National_Healthcare_System.Pages.Organizations.IndexModel>)PageContext?.ViewData;
        public National_Healthcare_System.Pages.Organizations.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
