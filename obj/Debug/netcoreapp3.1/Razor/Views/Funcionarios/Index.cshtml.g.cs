#pragma checksum "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\aspnetcoreMVC\Views\Funcionarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa05266b3cb42e9abb73f6e27f9a577b87f16978"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionarios_Index), @"mvc.1.0.view", @"/Views/Funcionarios/Index.cshtml")]
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
#line 1 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\aspnetcoreMVC\Views\_ViewImports.cshtml"
using aspnetcoreMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\aspnetcoreMVC\Views\_ViewImports.cshtml"
using aspnetcoreMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa05266b3cb42e9abb73f6e27f9a577b87f16978", @"/Views/Funcionarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edbdd6ffcb562188713ac71e37d15e907af82554", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<aspnetcoreMVC.Models.Funcionario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Todos os funcionarios</h2>\r\n<a href=\"/Funcionarios/Cadastrar\" class=\"btn btn-success\">Novo funcionario</a>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\aspnetcoreMVC\Views\Funcionarios\Index.cshtml"
 foreach (var funcionario in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Nome: ");
#nullable restore
#line 9 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\aspnetcoreMVC\Views\Funcionarios\Index.cshtml"
        Write(funcionario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Salário: ");
#nullable restore
#line 10 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\aspnetcoreMVC\Views\Funcionarios\Index.cshtml"
           Write(funcionario.Salario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Cpf: ");
#nullable restore
#line 11 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\aspnetcoreMVC\Views\Funcionarios\Index.cshtml"
       Write(funcionario.Cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 390, "\"", 433, 2);
            WriteAttributeValue("", 397, "/Funcionarios/Editar/", 397, 21, true);
#nullable restore
#line 12 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\aspnetcoreMVC\Views\Funcionarios\Index.cshtml"
WriteAttributeValue("", 418, funcionario.Id, 418, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Editar</a>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 477, "\"", 521, 2);
            WriteAttributeValue("", 484, "/Funcionarios/Deletar/", 484, 22, true);
#nullable restore
#line 13 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\aspnetcoreMVC\Views\Funcionarios\Index.cshtml"
WriteAttributeValue("", 506, funcionario.Id, 506, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Deletar</a>\r\n    <hr>\r\n");
#nullable restore
#line 15 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\aspnetcoreMVC\Views\Funcionarios\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<aspnetcoreMVC.Models.Funcionario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
