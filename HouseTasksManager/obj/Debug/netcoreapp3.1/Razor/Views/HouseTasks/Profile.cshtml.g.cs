#pragma checksum "C:\Users\javie\HouseTaskManager\HouseTasksManager\HouseTasksManager\Views\HouseTasks\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "402a135e4ec36a620c6f49a3c125cb4a57808c74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HouseTasks_Profile), @"mvc.1.0.view", @"/Views/HouseTasks/Profile.cshtml")]
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
#line 1 "C:\Users\javie\HouseTaskManager\HouseTasksManager\HouseTasksManager\Views\_ViewImports.cshtml"
using HouseTasksManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\javie\HouseTaskManager\HouseTasksManager\HouseTasksManager\Views\_ViewImports.cshtml"
using HouseTasksManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"402a135e4ec36a620c6f49a3c125cb4a57808c74", @"/Views/HouseTasks/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"426c78e61bce369c3dfdcaf8528fca5dc20911f2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_HouseTasks_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HouseTasksManager.Models.HouseTask>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h3>Hello ");
#nullable restore
#line 11 "C:\Users\javie\HouseTaskManager\HouseTasksManager\HouseTasksManager\Views\HouseTasks\Profile.cshtml"
     Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div>\r\n    <p> These are your assigned tasks:</p>\r\n");
#nullable restore
#line 14 "C:\Users\javie\HouseTaskManager\HouseTasksManager\HouseTasksManager\Views\HouseTasks\Profile.cshtml"
     foreach (var AssignedTask in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\javie\HouseTaskManager\HouseTasksManager\HouseTasksManager\Views\HouseTasks\Profile.cshtml"
         if (AssignedTask.Owner == User.Identity.Name)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>");
#nullable restore
#line 18 "C:\Users\javie\HouseTaskManager\HouseTasksManager\HouseTasksManager\Views\HouseTasks\Profile.cshtml"
            Write(AssignedTask.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 19 "C:\Users\javie\HouseTaskManager\HouseTasksManager\HouseTasksManager\Views\HouseTasks\Profile.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\javie\HouseTaskManager\HouseTasksManager\HouseTasksManager\Views\HouseTasks\Profile.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div>\r\n    <span>These are the tasks you have completed:</span>\r\n");
#nullable restore
#line 25 "C:\Users\javie\HouseTaskManager\HouseTasksManager\HouseTasksManager\Views\HouseTasks\Profile.cshtml"
       
        int totalValue = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\javie\HouseTaskManager\HouseTasksManager\HouseTasksManager\Views\HouseTasks\Profile.cshtml"
         foreach (var AssignedTask in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\javie\HouseTaskManager\HouseTasksManager\HouseTasksManager\Views\HouseTasks\Profile.cshtml"
             if (AssignedTask.Finished & AssignedTask.Owner == User.Identity.Name)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>");
#nullable restore
#line 31 "C:\Users\javie\HouseTaskManager\HouseTasksManager\HouseTasksManager\Views\HouseTasks\Profile.cshtml"
                 Write(AssignedTask.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <span> with value: </span>\r\n                <span>");
#nullable restore
#line 33 "C:\Users\javie\HouseTaskManager\HouseTasksManager\HouseTasksManager\Views\HouseTasks\Profile.cshtml"
                 Write(AssignedTask.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 34 "C:\Users\javie\HouseTaskManager\HouseTasksManager\HouseTasksManager\Views\HouseTasks\Profile.cshtml"
                totalValue += AssignedTask.Value;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n");
#nullable restore
#line 36 "C:\Users\javie\HouseTaskManager\HouseTasksManager\HouseTasksManager\Views\HouseTasks\Profile.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\javie\HouseTaskManager\HouseTasksManager\HouseTasksManager\Views\HouseTasks\Profile.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div>\r\n    <span>The amount of points you have is: ");
#nullable restore
#line 42 "C:\Users\javie\HouseTaskManager\HouseTasksManager\HouseTasksManager\Views\HouseTasks\Profile.cshtml"
                                       Write(totalValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HouseTasksManager.Models.HouseTask>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
