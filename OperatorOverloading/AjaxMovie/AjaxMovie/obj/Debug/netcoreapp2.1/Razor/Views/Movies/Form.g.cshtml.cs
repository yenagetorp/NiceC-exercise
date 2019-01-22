#pragma checksum "C:\Users\Yen Agetorp\source\repos\AjaxMovie\AjaxMovie\Views\Movies\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d32bae94334acb4a32ea0d703eebd5c1a33951e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Form), @"mvc.1.0.view", @"/Views/Movies/Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movies/Form.cshtml", typeof(AspNetCore.Views_Movies_Form))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d32bae94334acb4a32ea0d703eebd5c1a33951e", @"/Views/Movies/Form.cshtml")]
    public class Views_Movies_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(147, 29, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(176, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaeb25826943443691c2cad49e639b85", async() => {
                BeginContext(182, 31, true);
                WriteLiteral("\r\n    <title>MovieApp</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(220, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(222, 2692, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47f49b68438b41abb7ed353fd3adffd9", async() => {
                BeginContext(228, 2679, true);
                WriteLiteral(@"
    <label>Enter Mpvie ID:</label>
    <input type=""text"" id=""movieId"" placeholder=""movieID"" />
    <button id=""getHtml"" value=""Get HTML"">Get HTML</button>
    <button id=""getJeson"" value=""Get Json"">Get Json</button>
    <button id=""getJesonAll"" value=""Get All Json"">Get All Films</button>
    <div id=""divResult""></div>
    <div id=""allfilms"">
    </div>


    <script src=""https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.3.1.min.js""></script>
    <script src=""https://ajax.aspnetcdn.com/ajax/jquery.validate/1.17.0/jquery.validate.min.js""></script>
    <script src=""https://ajax.aspnetcdn.com/ajax/mvc/5.2.3/jquery.validate.unobtrusive.min.js""></script>
    <script>
        $(document).ready(function () {
            $(""#getHtml"").click(function () {
                // alert(""Hej funkar!"")
                $.ajax({
                    url: ""/Movies/GetPartialView"",
                    type: ""GET"",
                    data: { ""id"": $(""#movieId"").val() },
                    success: function (d");
                WriteLiteral(@"ata) {

                        $(""#divResult"").html(data);
                    }

                });
                //e.preventDefault();

            });

            $(""#getJeson"").click(function () {
                // alert(""Hej funkar!"")
                $.ajax({
                    url: ""/Movies/GetMovieJeson"",
                    type: ""GET"",
                    data: { ""id"": $(""#movieId"").val() },
                    success: function (data) {
                        console.log(data)
                        $(""#divResult"").html(""<p>Titel: "" + data.title + ""</p>"" + ""<p>Description: "" + data.description + ""</p>"");
                    }
                    //kolla på json file i consolen, data.titel and data.descriptions name should be the same.
                });
            });

            //e.preventDefault();

            $(""#getJesonAll"").click(function () {
                alert(""Hej funkar!"")
                $.ajax({
                    url: ""/Movies/GetAllMoviesJ");
                WriteLiteral(@"eson"",
                    type: ""GET"",
                    data: null,
                    success: function (data) {
                        for (var i = 0; i < data.length; i++) {
                            console.log(data[i].title)
                            $(""#allfilms"").html(""<p>Titel: "" + data[i].title + ""</p>"" + ""<p>Description: "" + data[i].description + ""</p>"");
                        }
                    }
                    //kolla på json file i consolen, data.titel and data.descriptions name should be the same.
                });
            });
            
        });
    </script>


");
                EndContext();
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
            EndContext();
            BeginContext(2914, 9, true);
            WriteLiteral("\r\n</html>");
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