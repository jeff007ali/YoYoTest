#pragma checksum "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da61a1760720ab4372f28732c3654ce24a0b3dd4"
// <auto-generated/>
#pragma warning disable 1591
namespace YoYoApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\_Imports.razor"
using YoYoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\_Imports.razor"
using YoYoApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""d-flex flex-row"">
    <div class=""span-svg""><svg focusable=""false"" viewBox=""0 0 24 24"" height=""48px"" width=""48px""><path d=""M16.59 8.59L12 13.17 7.41 8.59 6 10l6 6 6-6z"" transform=""rotate(90 12 12)""></path></svg></div>
    <div class=""flex-grow-1 text-center span-header"">YoYo Test</div>
</div>

");
#nullable restore
#line 8 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
 if (shuttles == null || players == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 11 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", 
#nullable restore
#line 14 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                  gt180 ? "progress-pie-chart gt-180" : "progress-pie-chart" 

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                                                          startShuttle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "ppc-progress");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "ppc-progress-fill");
            __builder.AddAttribute(13, "style", 
#nullable restore
#line 16 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                   timerDeg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "ppc-percents");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "pcc-percents-wrapper");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "span");
            __builder.AddContent(23, 
#nullable restore
#line 20 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                       mainBtnTxt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    <br>\r\n");
            __builder.AddContent(28, "    ");
            __builder.OpenElement(29, "table");
            __builder.AddAttribute(30, "class", "table ov-border-top");
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "tbody");
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "tr");
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "td");
            __builder.AddAttribute(37, "class", "border-right");
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.AddMarkupContent(39, "<p class=\"text-center small-font\">NEXT SHUTTLE</p>\r\n                    ");
            __builder.OpenElement(40, "p");
            __builder.AddAttribute(41, "class", "text-center little-bold");
            __builder.AddContent(42, 
#nullable restore
#line 31 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                        remainingShuttleTime.Seconds

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(43, " s");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "td");
            __builder.AddAttribute(47, "class", "border-right");
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.AddMarkupContent(49, "<p class=\"text-center small-font\">TOTAL TIME</p>\r\n                    ");
            __builder.OpenElement(50, "p");
            __builder.AddAttribute(51, "class", "text-center little-bold");
            __builder.AddContent(52, 
#nullable restore
#line 35 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                         elapsedTime.Minutes + ":" + elapsedTime.Seconds

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(53, " m");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "td");
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.AddMarkupContent(58, "<p class=\"text-center small-font\">TOTAL DISTANCE</p>\r\n                    ");
            __builder.OpenElement(59, "p");
            __builder.AddAttribute(60, "class", "text-center little-bold");
            __builder.AddContent(61, 
#nullable restore
#line 39 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                        totalDistance

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(62, " m");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.AddContent(68, "    ");
            __builder.AddMarkupContent(69, "<h5 class=\"player-table-text\">Track</h5>\r\n    ");
            __builder.OpenElement(70, "table");
            __builder.AddAttribute(71, "class", "table table-hover player-table-text");
            __builder.AddMarkupContent(72, "\r\n        ");
            __builder.OpenElement(73, "tbody");
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 48 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
             for (var i = 0; i < players.Length; i++)
            {
                var a = i;

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "                ");
            __builder.OpenElement(76, "tr");
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.OpenElement(78, "td");
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.AddContent(80, 
#nullable restore
#line 53 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                          a+1

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(81, ".\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                    ");
            __builder.OpenElement(83, "td");
            __builder.AddAttribute(84, "class", "text-nowrap");
            __builder.AddMarkupContent(85, "\r\n                        ");
            __builder.AddContent(86, 
#nullable restore
#line 56 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                         players[a].PlayerName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(87, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                    ");
            __builder.OpenElement(89, "td");
            __builder.AddMarkupContent(90, "\r\n                        ");
            __builder.OpenElement(91, "button");
            __builder.AddAttribute(92, "class", "table-btn" + " " + (
#nullable restore
#line 59 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                   isStarted && !players[a].IsWarned ? "warn-btn" : "warned-btn" 

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 59 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                                                                                     isStarted && !players[a].IsStopped ? "visible" : "invisible" 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                                                                                                                                                                 () => warnPlayer(players[a].Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "disabled", 
#nullable restore
#line 59 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                                                                                                                                                                                                               players[a].IsWarned ? true : false 

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(95, 
#nullable restore
#line 59 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                                                                                                                                                                                                                                                       players[a].IsWarned ? "Warned" : "Warn" 

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                    ");
            __builder.OpenElement(98, "td");
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 62 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                         if (!players[a].IsStopped)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "                            ");
            __builder.OpenElement(101, "button");
            __builder.AddAttribute(102, "class", "table-btn" + " stop-btn" + " " + (
#nullable restore
#line 64 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                                isStarted ? "visible" : "invisible" 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                                                                                   () => stopTracking(players[a].Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(104, "Stop");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n");
#nullable restore
#line 65 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(106, "                            ");
            __builder.OpenElement(107, "label");
            __builder.AddAttribute(108, "class", "result-card");
            __builder.AddContent(109, 
#nullable restore
#line 68 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                        string.Format("{0}-{1}", players[a].LevelCompleted, players[a].ShuttleCompleted)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n");
#nullable restore
#line 70 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                             if (players[a].IsEditable)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(111, "                                ");
            __builder.OpenElement(112, "span");
            __builder.AddAttribute(113, "class", "span-svg");
            __builder.AddAttribute(114, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                                   () => editResult(players[a].Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(115, "<svg focusable=\"false\" viewBox=\"0 0 24 24\" height=\"20px\" width=\"20px\"><path d=\"M16.59 8.59L12 13.17 7.41 8.59 6 10l6 6 6-6z\" transform=\"rotate(180 12 12)\"></path></svg>");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                                <br>\r\n");
            __builder.AddContent(117, "                                ");
            __builder.OpenElement(118, "div");
            __builder.AddMarkupContent(119, "\r\n                                    ");
            __builder.AddMarkupContent(120, "<div>\r\n                                        <label for=\"level\" class=\"control-label\">Level:</label>\r\n                                    </div>\r\n                                    ");
            __builder.OpenElement(121, "div");
            __builder.AddMarkupContent(122, "\r\n                                        ");
            __builder.OpenElement(123, "select");
            __builder.AddAttribute(124, "class", "form-control");
            __builder.AddAttribute(125, "name", "level");
            __builder.AddAttribute(126, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 80 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                                                               e => levelChange(players[a].Id, e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(127, "\r\n");
#nullable restore
#line 81 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                             for (var j = 0; j < levels.Length; j++)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                 if (players[a].LevelCompleted == levels[j])
                                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(128, "                                                    ");
            __builder.OpenElement(129, "option");
            __builder.AddAttribute(130, "selected", true);
            __builder.AddContent(131, 
#nullable restore
#line 85 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                                      levels[j]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n");
#nullable restore
#line 86 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(133, "                                                    ");
            __builder.OpenElement(134, "option");
            __builder.AddContent(135, 
#nullable restore
#line 89 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                             levels[j]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n");
#nullable restore
#line 90 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                 

                                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(137, "                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n");
#nullable restore
#line 96 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"

                                var shuttleNos = levelShuttleDict[players[a].LevelCompleted].ToArray();

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(141, "                                <br>\r\n                                ");
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "col-xs-8");
            __builder.AddMarkupContent(144, "\r\n                                    ");
            __builder.AddMarkupContent(145, "<div class=\"col-xs-4\">\r\n                                        <label for=\"shuttle\" class=\"control-label\">Shuttle:</label>\r\n                                    </div>\r\n                                    ");
            __builder.OpenElement(146, "div");
            __builder.AddAttribute(147, "class", "col-xs-8");
            __builder.AddMarkupContent(148, "\r\n                                        ");
            __builder.OpenElement(149, "select");
            __builder.AddAttribute(150, "class", "form-control");
            __builder.AddAttribute(151, "name", "shuttle");
            __builder.AddAttribute(152, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 104 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                                                                 e => shuttleChange(players[a].Id, e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(153, "\r\n");
#nullable restore
#line 105 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                             for (var j = 0; j < shuttleNos.Length; j++)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                 if (players[a].ShuttleCompleted == shuttleNos[j])
                                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(154, "                                                    ");
            __builder.OpenElement(155, "option");
            __builder.AddAttribute(156, "selected", true);
            __builder.AddContent(157, 
#nullable restore
#line 109 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                                      shuttleNos[j]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n");
#nullable restore
#line 110 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(159, "                                                    ");
            __builder.OpenElement(160, "option");
            __builder.AddContent(161, 
#nullable restore
#line 113 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                             shuttleNos[j]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n");
#nullable restore
#line 114 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                 

                                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(163, "                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n");
#nullable restore
#line 120 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(167, "                                ");
            __builder.OpenElement(168, "span");
            __builder.AddAttribute(169, "class", "span-svg");
            __builder.AddAttribute(170, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 123 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                                                                   () => editResult(players[a].Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(171, "<svg focusable=\"false\" viewBox=\"0 0 24 24\" height=\"20px\" width=\"20px\"><path d=\"M16.59 8.59L12 13.17 7.41 8.59 6 10l6 6 6-6z\"></path></svg>");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n");
#nullable restore
#line 124 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
                             
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(173, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n");
#nullable restore
#line 129 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(176, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n");
#nullable restore
#line 132 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 135 "E:\WorkSpace\C Sharp\YoYoApp\YoYoApp\Pages\Index.razor"
       
    private string[] playerString = new string[] { "Ashton Eston", "Bryan Clay", "Dean Karnazes", "Usain Bolt" };

    private Shuttle[] shuttles;
    private Player[] players;

    private Dictionary<string, List<string>> levelShuttleDict = new Dictionary<string, List<string>>();
    private string[] levels;

    protected override async Task OnInitializedAsync()
    {
        shuttles = await Http.GetFromJsonAsync<Shuttle[]>("sample-data/fitnessrating_beeptest.json");
        players = playerString.Select(p => new Player { PlayerName = p }).ToArray();

        // Populate level shuttle dictionary to use in edit result
        levelShuttleDict.Add("0", new List<string>(new string[] { "0" }));
        foreach (var shuttle in shuttles)
        {
            List<string> existing;
            if (!levelShuttleDict.TryGetValue(shuttle.SpeedLevel, out existing))
            {
                existing = new List<string>();
                levelShuttleDict[shuttle.SpeedLevel] = existing;
            }
            // At this point we know that "existing" refers to the relevant list in the
            // dictionary, one way or another.
            existing.Add(shuttle.ShuttleNo);
        }

        levels = levelShuttleDict.Keys.ToArray();
    }

    public class Shuttle
    {
        public string AccumulatedShuttleDistance { get; set; }

        public string SpeedLevel { get; set; }

        public string ShuttleNo { get; set; }

        public string Speed { get; set; }

        public string LevelTime { get; set; }

        public TimeSpan LevelTimeSpan => new TimeSpan(0, 0, (int)Math.Round(Convert.ToDouble(LevelTime)));

        public string CommulativeTime { get; set; }

        public TimeSpan CommulativeTimeSpan => TimeSpan.Parse("00:" + CommulativeTime);

        public string StartTime { get; set; }

        public TimeSpan StartTimeSpan => TimeSpan.Parse("00:" + StartTime);
    }

    public class Player
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string PlayerName { get; set; }

        public bool IsWarned { get; set; } = false;

        public bool IsStopped { get; set; } = false;

        public string LevelCompleted { get; set; } = "";

        public string ShuttleCompleted { get; set; } = "";

        public bool IsEditable { get; set; } = false;
    }

    private int index = 0;

    private MarkupString mainBtnTxt = (MarkupString)"<p class=\"main-play-btn\"> ▶</p>";
    private TimeSpan remainingShuttleTime = new TimeSpan();
    private TimeSpan totalShuttleTime = new TimeSpan();
    private TimeSpan elapsedTime = new TimeSpan();
    private string totalDistance = "0";

    //private TimeSpan runTimeLimit = new TimeSpan();
    private TimeSpan shuttleTimeLimit = new TimeSpan();

    private bool isStarted = false;

    private string timerDeg = "transform: rotate(0deg);";
    private bool gt180 = false;

    private void startShuttle()
    {
        if (!isStarted)
        {
            // get ready for beeptest session (reset all values)
            remainingShuttleTime = new TimeSpan();
            elapsedTime = new TimeSpan();
            //runTimeLimit = new TimeSpan();
            shuttleTimeLimit = new TimeSpan();
            totalDistance = "0";

            updateValues();
            isStarted = true;
        }
    }

    private void updateValues()
    {
        if (index < shuttles.Length)
        {
            mainBtnTxt = (MarkupString)string.Format("<p class=\"little-bold\">Level {0}<br />Shuttle {1}</p><p class=\"small-font\">{2} km/h</p>", shuttles[index].SpeedLevel, shuttles[index].ShuttleNo, shuttles[index].Speed);
            //runTimeLimit = elapsedTime.Add(shuttles[index].LevelTimeSpan);
            //remainingShuttleTime = runTimeLimit.Subtract(elapsedTime);
            shuttleTimeLimit = shuttles[index].CommulativeTimeSpan;
            totalDistance = shuttles[index].AccumulatedShuttleDistance;
            timerDeg = "transform: rotate(0deg);";
            gt180 = false;

            Timer();
            index++;
        }
        else
        {
            mainBtnTxt = (MarkupString)"Test Complete";
            timerDeg = "transform: rotate(360deg);";
            //index = 0;
            //isStarted = false;

            foreach (var player in players)
            {
                if (!player.IsStopped)
                {
                    player.IsStopped = !player.IsStopped;
                    player.LevelCompleted = shuttles[shuttles.Length - 1].SpeedLevel;
                    player.ShuttleCompleted = shuttles[shuttles.Length - 1].ShuttleNo;
                }
            }
        }

    }

    async Task Timer()
    {
        // To handle runtime and rest time separately
        //while (elapsedTime < runTimeLimit)
        //{
        //    await Task.Delay(1000);
        //    elapsedTime = elapsedTime.Add(new TimeSpan(0, 0, 1));
        //    remainingShuttleTime = runTimeLimit.Subtract(elapsedTime);
        //    StateHasChanged();
        //
        //}

        remainingShuttleTime = shuttleTimeLimit.Subtract(elapsedTime);
        totalShuttleTime = shuttleTimeLimit.Subtract(elapsedTime);

        while (elapsedTime < shuttleTimeLimit)
        {
            //mainBtnTxt = (MarkupString)"Rest time";
            elapsedTime = elapsedTime.Add(new TimeSpan(0, 0, 1));
            remainingShuttleTime = shuttleTimeLimit.Subtract(elapsedTime);
            setDegree(totalShuttleTime, remainingShuttleTime);

            StateHasChanged();
            await Task.Delay(1000);
        }
        await AfterTime();
        StateHasChanged();
    }

    Task AfterTime()
    {
        // mainBtnTxt = (MarkupString)"Complete timer";
        updateValues();
        return Task.CompletedTask;
    }

    private void setDegree(TimeSpan totalTime, TimeSpan remainingTime)
    {
        double totalSeconds = totalTime.TotalSeconds;
        double remainingSeconds = remainingTime.TotalSeconds;
        double elapsedSeconds = totalSeconds - remainingSeconds;

        double resDeg = ((360 * elapsedSeconds) / totalSeconds);

        if (resDeg > 180)
        {
            gt180 = true;
        }
        timerDeg = string.Format("transform: rotate({0}deg);", resDeg.ToString());
    }

    private void warnPlayer(Guid id)
    {
        var player = players.First(x => x.Id == id);
        player.IsWarned = !player.IsWarned;
    }

    private void stopTracking(Guid id)
    {
        var player = players.First(x => x.Id == id);
        player.IsStopped = !player.IsStopped;

        player.LevelCompleted = index.ToString();

        var completedIndex = index - 2;
        if (completedIndex >= 0)
        {
            player.LevelCompleted = shuttles[index - 2].SpeedLevel;
            player.ShuttleCompleted = shuttles[index - 2].ShuttleNo;
        }
        else
        {
            player.LevelCompleted = "0";
            player.ShuttleCompleted = "0";
        }

    }

    private void editResult(Guid id)
    {
        var player = players.First(x => x.Id == id);
        player.IsEditable = !player.IsEditable;
    }

    private void levelChange(Guid id, ChangeEventArgs e)
    {
        var player = players.First(x => x.Id == id);
        player.LevelCompleted = e.Value.ToString();
        if (!levelShuttleDict[player.LevelCompleted].Contains(player.ShuttleCompleted))
        {
            player.ShuttleCompleted = levelShuttleDict[player.LevelCompleted].First();
        }
    }

    private void shuttleChange(Guid id, ChangeEventArgs e)
    {
        var player = players.First(x => x.Id == id);
        player.ShuttleCompleted = e.Value.ToString();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
