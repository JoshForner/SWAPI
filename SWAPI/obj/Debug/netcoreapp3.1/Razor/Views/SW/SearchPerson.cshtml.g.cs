#pragma checksum "C:\Users\forne\source\repos\CSHARP\SWAPI\SWAPI\Views\SW\SearchPerson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5947141abc7ebf9832b0460e7fc1fb2988d8529e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SW_SearchPerson), @"mvc.1.0.view", @"/Views/SW/SearchPerson.cshtml")]
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
#line 1 "C:\Users\forne\source\repos\CSHARP\SWAPI\SWAPI\Views\_ViewImports.cshtml"
using SWAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\forne\source\repos\CSHARP\SWAPI\SWAPI\Views\_ViewImports.cshtml"
using SWAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5947141abc7ebf9832b0460e7fc1fb2988d8529e", @"/Views/SW/SearchPerson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67a2a7524a3e15c6deb36b004187595012c6cbad", @"/Views/_ViewImports.cshtml")]
    public class Views_SW_SearchPerson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>Name: ");
#nullable restore
#line 3 "C:\Users\forne\source\repos\CSHARP\SWAPI\SWAPI\Views\SW\SearchPerson.cshtml"
    Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Height: ");
#nullable restore
#line 4 "C:\Users\forne\source\repos\CSHARP\SWAPI\SWAPI\Views\SW\SearchPerson.cshtml"
      Write(Model.height);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Mass: ");
#nullable restore
#line 5 "C:\Users\forne\source\repos\CSHARP\SWAPI\SWAPI\Views\SW\SearchPerson.cshtml"
    Write(Model.mass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Hair Color: ");
#nullable restore
#line 6 "C:\Users\forne\source\repos\CSHARP\SWAPI\SWAPI\Views\SW\SearchPerson.cshtml"
          Write(Model.hair_color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Skin Color: ");
#nullable restore
#line 7 "C:\Users\forne\source\repos\CSHARP\SWAPI\SWAPI\Views\SW\SearchPerson.cshtml"
          Write(Model.skin_color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Eye Color: ");
#nullable restore
#line 8 "C:\Users\forne\source\repos\CSHARP\SWAPI\SWAPI\Views\SW\SearchPerson.cshtml"
         Write(Model.eye_color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Birth Year: ");
#nullable restore
#line 9 "C:\Users\forne\source\repos\CSHARP\SWAPI\SWAPI\Views\SW\SearchPerson.cshtml"
          Write(Model.birth_year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Gender: ");
#nullable restore
#line 10 "C:\Users\forne\source\repos\CSHARP\SWAPI\SWAPI\Views\SW\SearchPerson.cshtml"
      Write(Model.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Person> Html { get; private set; }
    }
}
#pragma warning restore 1591