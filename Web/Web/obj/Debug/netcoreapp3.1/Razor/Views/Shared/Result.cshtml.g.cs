#pragma checksum "C:\Users\Eduard\Desktop\Уроки\ASP.NET\Task4-5\Web\Web\Views\Shared\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "838588e69b4f121c3f524d8b740e3a3a81c436c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Result), @"mvc.1.0.view", @"/Views/Shared/Result.cshtml")]
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
#line 1 "C:\Users\Eduard\Desktop\Уроки\ASP.NET\Task4-5\Web\Web\Views\Shared\Result.cshtml"
using Web.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eduard\Desktop\Уроки\ASP.NET\Task4-5\Web\Web\Views\Shared\Result.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Eduard\Desktop\Уроки\ASP.NET\Task4-5\Web\Web\Views\Shared\Result.cshtml"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"838588e69b4f121c3f524d8b740e3a3a81c436c1", @"/Views/Shared/Result.cshtml")]
    public class Views_Shared_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Question>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Eduard\Desktop\Уроки\ASP.NET\Task4-5\Web\Web\Views\Shared\Result.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838588e69b4f121c3f524d8b740e3a3a81c436c13480", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi"" crossorigin=""anonymous"">
    <title>Test</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838588e69b4f121c3f524d8b740e3a3a81c436c14867", async() => {
                WriteLiteral("\r\n    <nav class=\"navbar navbar-expand-lg bg-light\">\r\n        <div class=\"container-fluid\">\r\n            <a class=\"navbar-brand\"");
                BeginWriteAttribute("href", " href=\"", 713, "\"", 720, 0);
                EndWriteAttribute();
                WriteLiteral(">Asp Net тест</a>\r\n        </div>\r\n    </nav>\r\n    <div class=\"container\">\r\n        \r\n");
#nullable restore
#line 26 "C:\Users\Eduard\Desktop\Уроки\ASP.NET\Task4-5\Web\Web\Views\Shared\Result.cshtml"
          
            
            
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("rabovolenkoeduard@gmail.com", "pozdwyrezrjjgotv"),
                EnableSsl = true,
            };
            
            var mailMessage = new MailMessage
            {
                From = new MailAddress("test@mail.com"),
                Subject = "Результат проходження тесту",
                Body = "<h1> Результат " + @ViewBag.res + "</h1>",
                IsBodyHtml = true,
            };
            mailMessage.To.Add(@ViewBag.email);

            smtpClient.Send(mailMessage);
        

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h3>Результат : ");
#nullable restore
#line 47 "C:\Users\Eduard\Desktop\Уроки\ASP.NET\Task4-5\Web\Web\Views\Shared\Result.cshtml"
                       Write(ViewBag.res);

#line default
#line hidden
#nullable disable
                WriteLiteral("  </h3>\r\n            <p>Відправлено на ");
#nullable restore
#line 48 "C:\Users\Eduard\Desktop\Уроки\ASP.NET\Task4-5\Web\Web\Views\Shared\Result.cshtml"
                         Write(ViewBag.email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
                WriteLiteral("\r\n        <form method=\"get\" action=\"/\">\r\n            <input value=\"Пройти ще раз\" type=\"submit\"  class=\"btn btn-primary mt-3 mb-3\">\r\n        </form>\r\n    </div>\r\n   \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Question>> Html { get; private set; }
    }
}
#pragma warning restore 1591
