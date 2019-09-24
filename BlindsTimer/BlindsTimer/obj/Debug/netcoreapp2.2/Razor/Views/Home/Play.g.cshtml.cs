#pragma checksum "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6412e873335897ca9af9ef8425fc487b5eddd6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Play), @"mvc.1.0.view", @"/Views/Home/Play.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Play.cshtml", typeof(AspNetCore.Views_Home_Play))]
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
#line 1 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\_ViewImports.cshtml"
using BlindsTimer;

#line default
#line hidden
#line 2 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\_ViewImports.cshtml"
using BlindsTimer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6412e873335897ca9af9ef8425fc487b5eddd6d", @"/Views/Home/Play.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1249a1a96d1cdb0052bbc0a5ef5753f5346ac129", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Play : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tournament>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/sounds/zapsplat_technology_cb_radio_two_way_beep_single_39804.mp3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml"
  
    ViewData["Title"] = "Play"; 

#line default
#line hidden
            BeginContext(60, 181, true);
            WriteLiteral("\r\n<h1>Timer</h1>\r\n<p></p>\r\n<div>\r\n    <button onclick=\"levelTimer();\">Start</button>\r\n    <button onclick=\"pauseTimer();\">Pause</button>\r\n</div>\r\n<p></p>\r\n\r\n<audio id=\"sound\">\r\n    ");
            EndContext();
            BeginContext(241, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a6412e873335897ca9af9ef8425fc487b5eddd6d4074", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(324, 1090, true);
            WriteLiteral(@"
</audio>


<div id=""current"" class=""box-shadow container-fluid"" style=""background-color:darkseagreen; padding:20px; margin-bottom:20px; display:flex; height:200px;"">
    <div class=""col-md-6"" style=""display:flex; flex-direction:column; justify-content: space-between;"">
        <p id=""level"" class=""maintext""></p>
        <p id=""blinds"" class=""maintext""></p>
    </div>
    <div class=""col-md-6"" style=""display:flex; flex-direction:column; align-items:center; justify-content:center"">
        <p id=""timer"" style=""font-size:500%;  font-weight:600; text-shadow:2px 2px 0 #999""></p>
    </div>
</div>

<div id=""next"" class=""container-fluid box-shadow"" style=""display:flex; padding:20px; background-color:lightgrey;"" >
    <div class=""col-md-6"" style=""display:flex; align-items:center"">
        <p style=""font-size:300%;  font-weight:600; text-shadow:2px 2px 0 #999"">Up Next:</p>
    </div>
    <div class=""col-md-6 maintext rightside"">
        <p id=""nextLevel""></p>
        <p id=""nextBlinds""></p>
    <");
            WriteLiteral("/div>\r\n    \r\n    \r\n</div>\r\n\r\n\r\n<script>\r\n\r\n    let levelMinutes = ");
            EndContext();
            BeginContext(1415, 18, false);
#line 44 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml"
                  Write(Model.LevelMinutes);

#line default
#line hidden
            EndContext();
            BeginContext(1433, 114, true);
            WriteLiteral(";\r\n    let levelSeconds = 0;\r\n    let currentLevel = 0;\r\n    let nextlevel = 1;\r\n\r\n    \r\n\r\n    let breakMinutes = ");
            EndContext();
            BeginContext(1548, 17, false);
#line 51 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml"
                  Write(Model.BreakLength);

#line default
#line hidden
            EndContext();
            BeginContext(1565, 61, true);
            WriteLiteral(";\r\n    //let breakSeconds = 0;\r\n\r\n    const blindStructure = ");
            EndContext();
            BeginContext(1627, 76, false);
#line 54 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml"
                      Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(@Model.BlindStructure)));

#line default
#line hidden
            EndContext();
            BeginContext(1703, 265, true);
            WriteLiteral(@";
    let timerInterval;
    let breakTimerInterval;

    function levelTimer() {

        timerInterval = setInterval(function () {
            if (levelMinutes === 0 && levelSeconds === 0) {
                displayBreak();
                levelMinutes = ");
            EndContext();
            BeginContext(1969, 18, false);
#line 63 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml"
                          Write(Model.LevelMinutes);

#line default
#line hidden
            EndContext();
            BeginContext(1987, 1121, true);
            WriteLiteral(@";
                levelSeconds = 0;
                currentLevel++;
                nextlevel++;
                displayLevel();
                displayNextLevel();
            }
            if (levelMinutes === 0 && levelSeconds <= 6)
            {
                levelSeconds--;
                document.getElementById(""timer"").innerHTML = levelMinutes.toString() + ' : ' + addZero().toString();
                beep();
             }
            else {
                if (levelMinutes > 0 && levelSeconds === 0) {
                    levelMinutes -= 1;
                    levelSeconds = 60;
                    levelSeconds--;
                }
                else {
                    levelSeconds--;
                }

                document.getElementById(""timer"").innerHTML = levelMinutes.toString() + ' : ' + addZero().toString();
            }

        }, 1000);
    }
    function breakTimer() {
        breakTimerInterval = setInterval(function () {
            if (breakMinut");
            WriteLiteral("es === 0 && levelSeconds === 0) {\r\n                levelTimer();\r\n                breakMinutes = ");
            EndContext();
            BeginContext(3109, 17, false);
#line 95 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml"
                          Write(Model.BreakLength);

#line default
#line hidden
            EndContext();
            BeginContext(3126, 1369, true);
            WriteLiteral(@";
                pauseBreakTimer(); //this may need to be changed to a function the clears the timer
                //something to remove the display of break
            }
            if (breakMinutes === 0 && levelSeconds <= 6) {
                levelSeconds--;
                document.getElementById(""timer"").innerHTML = breakMinutes.toString() + ' : ' + addZero().toString();
                beep();
            }
            else {
                if (breakMinutes > 0 && levelSeconds === 0) {
                    breakMinutes -= 1;
                    levelSeconds = 60;
                    levelSeconds--;
                }
                else {
                    levelSeconds--;
                }

                document.getElementById(""timer"").innerHTML = breakMinutes.toString() + ' : ' + addZero().toString();
            }
        }, 1000);
            
    }

    function pauseTimer() {
        clearInterval(timerInterval);
    }

    function pauseBreakTimer() {
       ");
            WriteLiteral(@" clearInterval(breakTimerInterval);
    }

    function addZero() {
        if (levelSeconds < 10) {
            let plusZero = '0' + levelSeconds;
            return plusZero;
        }
        return levelSeconds;
    }

    function displayLevel() {
        for (var key in blindStructure) {
            if ((currentLevel + 1) % ");
            EndContext();
            BeginContext(4496, 20, false);
#line 138 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml"
                                Write(Model.BreakFrequency);

#line default
#line hidden
            EndContext();
            BeginContext(4516, 25, true);
            WriteLiteral(" === 0 && breakMinutes < ");
            EndContext();
            BeginContext(4542, 17, false);
#line 138 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml"
                                                                              Write(Model.BreakLength);

#line default
#line hidden
            EndContext();
            BeginContext(4559, 911, true);
            WriteLiteral(@") {
                document.getElementById(""level"").innerHTML = 'Break'
            }
            else if (key == currentLevel) {
                document.getElementById(""blinds"").innerHTML = 'Blinds ' + blindStructure[key].SmallBlind.toString() + ' / ' + blindStructure[key].BigBlind.toString();
                document.getElementById(""level"").innerHTML = 'Level ' + (currentLevel + 1);
            }
        }
    }
    function displayNextLevel() {
        for (var key in blindStructure) {
            if (key == nextlevel) {
                document.getElementById(""nextBlinds"").innerHTML = 'Blinds ' + blindStructure[key].SmallBlind.toString() + ' / ' + blindStructure[key].BigBlind.toString();
                document.getElementById(""nextLevel"").innerHTML = 'Level ' + (currentLevel + 2);
            } 
        }
    }
    function displayBreak() {
        if ((currentLevel + 2) % ");
            EndContext();
            BeginContext(5471, 20, false);
#line 156 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml"
                            Write(Model.BreakFrequency);

#line default
#line hidden
            EndContext();
            BeginContext(5491, 266, true);
            WriteLiteral(@" === 0) {
            pauseTimer();
            breakTimer();
        }
    }

    function beep() {
        const mySound = document.getElementById(""sound"");
        mySound.play();
    }
    displayLevel();
    displayNextLevel();

</script>




");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tournament> Html { get; private set; }
    }
}
#pragma warning restore 1591
