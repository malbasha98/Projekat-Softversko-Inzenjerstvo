#pragma checksum "D:\Projekti-master\Pages\MojiOglasi.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "881539829da71187d8e03aaeb5562d6b48d34cc5"
// <auto-generated/>
#pragma warning disable 1591
namespace Kucni_poslovi.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projekti-master\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projekti-master\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projekti-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projekti-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projekti-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projekti-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projekti-master\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projekti-master\_Imports.razor"
using Kucni_poslovi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projekti-master\_Imports.razor"
using Kucni_poslovi.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projekti-master\_Imports.razor"
using Kucni_poslovi.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projekti-master\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projekti-master\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projekti-master\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projekti-master\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Projekti-master\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Projekti-master\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projekti-master\Pages\MojiOglasi.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projekti-master\Pages\MojiOglasi.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MojiOglasi")]
    public partial class MojiOglasi : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Roles", "KorisnikUsluge");
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\n");
#nullable restore
#line 11 "D:\Projekti-master\Pages\MojiOglasi.razor"
         if (!Ucitan)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(4, "            ");
                __builder2.AddMarkupContent(5, @"<div class=""sk-circle"">
                <div class=""sk-circle1 sk-child""></div>
                <div class=""sk-circle2 sk-child""></div>
                <div class=""sk-circle3 sk-child""></div>
                <div class=""sk-circle4 sk-child""></div>
                <div class=""sk-circle5 sk-child""></div>
                <div class=""sk-circle6 sk-child""></div>
                <div class=""sk-circle7 sk-child""></div>
                <div class=""sk-circle8 sk-child""></div>
                <div class=""sk-circle9 sk-child""></div>
                <div class=""sk-circle10 sk-child""></div>
                <div class=""sk-circle11 sk-child""></div>
                <div class=""sk-circle12 sk-child""></div>
            </div>
");
#nullable restore
#line 27 "D:\Projekti-master\Pages\MojiOglasi.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(6, "            ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row mb-3");
                __builder2.AddAttribute(9, "style", "display:flex; align-items:center");
                __builder2.AddMarkupContent(10, "\n                ");
                __builder2.AddMarkupContent(11, "<label style=\"margin-bottom:auto; margin-top:auto\">Prikaži: &ensp;</label>\n                ");
                __builder2.OpenElement(12, "span");
                __builder2.AddAttribute(13, "style", "margin-bottom:auto; margin-top:auto");
                __builder2.AddMarkupContent(14, "\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, Polje>>(15);
                __builder2.AddAttribute(16, "Index", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 33 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                           0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "DataSource", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Polje>>(
#nullable restore
#line 33 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                                                                         listaS

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(19, "\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<string>>(20);
                    __builder3.AddAttribute(21, "ValueChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string>>(this, 
#nullable restore
#line 34 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                                                         OnChangeListStanje

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(23);
                    __builder3.AddAttribute(24, "Text", "Tekst");
                    __builder3.AddAttribute(25, "Value", "Id");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n                ");
                __builder2.AddMarkupContent(29, "<label style=\"margin-bottom:auto; margin-top:auto\">&ensp; Filtriraj po: &ensp;</label>\n                ");
                __builder2.OpenElement(30, "span");
                __builder2.AddAttribute(31, "style", "margin-bottom:auto; margin-top:auto");
                __builder2.AddMarkupContent(32, "\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, Polje>>(33);
                __builder2.AddAttribute(34, "Index", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 40 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                           0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "DataSource", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Polje>>(
#nullable restore
#line 40 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                                                                         listaF

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(37, "\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<string>>(38);
                    __builder3.AddAttribute(39, "ValueChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string>>(this, 
#nullable restore
#line 41 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                                                         OnChangeListFilter

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(41);
                    __builder3.AddAttribute(42, "Text", "Tekst");
                    __builder3.AddAttribute(43, "Value", "Id");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\n                ");
                __builder2.AddMarkupContent(47, "<label style=\"margin-bottom:auto; margin-top:auto\">&ensp; Za tip usluge: &ensp;</label>\n                ");
                __builder2.OpenElement(48, "span");
                __builder2.AddAttribute(49, "style", "margin-bottom:auto; margin-top:auto");
                __builder2.AddMarkupContent(50, "\n                    ");
                __Blazor.Kucni_poslovi.Pages.MojiOglasi.TypeInference.CreateSfMultiSelect_0(__builder2, 51, 52, 
#nullable restore
#line 47 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                                                          VisualMode.CheckBox

#line default
#line hidden
#nullable disable
                , 53, "Tipovi usluga", 54, 
#nullable restore
#line 47 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                                                                                                                        listaT

#line default
#line hidden
#nullable disable
                , 55, 
#nullable restore
#line 47 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                                                                                                                                                  true

#line default
#line hidden
#nullable disable
                , 56, 
#nullable restore
#line 47 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                                                                                                                                                                              false

#line default
#line hidden
#nullable disable
                , 57, 
#nullable restore
#line 47 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                                                                                                                                                                                                     false

#line default
#line hidden
#nullable disable
                , 58, 
#nullable restore
#line 47 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                                                                                                                                                                                                                           true

#line default
#line hidden
#nullable disable
                , 59, "poništi", 60, "svi tipovi", 61, "250px", 62, 
#nullable restore
#line 47 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                                 selektovaneUsluge

#line default
#line hidden
#nullable disable
                , 63, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selektovaneUsluge = __value, selektovaneUsluge)), 64, () => selektovaneUsluge, 65, (__builder3) => {
                    __builder3.AddMarkupContent(66, "\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.MultiSelectEvents<TipUsluge[]>>(67);
                    __builder3.AddAttribute(68, "ValueChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.MultiSelectChangeEventArgs<TipUsluge[]>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.MultiSelectChangeEventArgs<TipUsluge[]>>(this, 
#nullable restore
#line 48 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                                                             OnChangeListTip

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.MultiSelectFieldSettings>(70);
                    __builder3.AddAttribute(71, "Text", "Tekst");
                    __builder3.AddAttribute(72, "Value", "TipUsluge");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\n                    ");
                }
                );
                __builder2.AddMarkupContent(74, "\n\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\n        ");
                __builder2.OpenElement(77, "table");
                __builder2.AddAttribute(78, "class", "table table-bordered table-hover");
                __builder2.AddMarkupContent(79, "\n            ");
                __builder2.AddMarkupContent(80, @"<thead>
                <tr>

                    <th scope=""col"">Naslov oglasa</th>
                    <th scope=""col"">Stanje oglasa</th>
                    <th scope=""col"">Opis oglasa</th>
                    <th scope=""col"">Brisanje oglasa</th>
                </tr>
            </thead>
            ");
                __builder2.OpenElement(81, "tbody");
                __builder2.AddMarkupContent(82, "\n");
#nullable restore
#line 65 "D:\Projekti-master\Pages\MojiOglasi.razor"
                 foreach (var oglas in Oglasi.OrderBy(kriterijumF).Where(x => (x.TipUsluge & kriterijumT) == x.TipUsluge))
                {
                    if (!(prikaziAktivan && prikaziUIzvrsavanju && prikaziIzvrsen && prikaziNeaktivan))
                    {
                        if (prikaziAktivan && oglas.Stanje != Stanje.Aktivan)
                            continue;
                        if (prikaziUIzvrsavanju && oglas.Stanje != Stanje.UIzvršavanju)
                            continue;
                        if (prikaziIzvrsen && oglas.Stanje != Stanje.Izvršen)
                            continue;
                        if (prikaziNeaktivan && oglas.Stanje != Stanje.Neaktivan)
                            continue;
                    }
                    var idOglasa = oglas.Id;
                    var userNameKorisnika = oglas.KorisnikUsluge.ToString();

#line default
#line hidden
#nullable disable
                __builder2.AddContent(83, "                    ");
                __builder2.OpenElement(84, "tr");
                __builder2.AddMarkupContent(85, "\n                        ");
                __builder2.OpenElement(86, "td");
                __builder2.AddAttribute(87, "style", "cursor:pointer");
                __builder2.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                                               e => OtvoriOglas(idOglasa)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "scope", "col");
#nullable restore
#line 81 "D:\Projekti-master\Pages\MojiOglasi.razor"
__builder2.AddContent(90, oglas.NaslovOglasa);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\n");
#nullable restore
#line 82 "D:\Projekti-master\Pages\MojiOglasi.razor"
                         if (oglas.Stanje == Stanje.UIzvršavanju)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(92, "                            ");
                __builder2.AddMarkupContent(93, "<td scope=\"col\">U izvršavanju</td>\n");
#nullable restore
#line 85 "D:\Projekti-master\Pages\MojiOglasi.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(94, "                            ");
                __builder2.OpenElement(95, "td");
                __builder2.AddAttribute(96, "scope", "col");
#nullable restore
#line 88 "D:\Projekti-master\Pages\MojiOglasi.razor"
__builder2.AddContent(97, oglas.Stanje);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\n");
#nullable restore
#line 89 "D:\Projekti-master\Pages\MojiOglasi.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(99, "\n                        ");
                __builder2.OpenElement(100, "td");
                __builder2.AddAttribute(101, "scope", "col");
#nullable restore
#line 91 "D:\Projekti-master\Pages\MojiOglasi.razor"
__builder2.AddContent(102, oglas.Opis);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\n                        ");
                __builder2.OpenElement(104, "td");
                __builder2.AddAttribute(105, "scope", "col");
                __builder2.AddMarkupContent(106, "\n                            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(107);
                __builder2.AddAttribute(108, "CssClass", "e-danger");
                __builder2.AddAttribute(109, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                                                      e => PostaviOglasZaBrisanje(idOglasa)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(110, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(111, "Izbriši");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(112, "\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\n");
#nullable restore
#line 96 "D:\Projekti-master\Pages\MojiOglasi.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(115, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\n");
                __builder2.AddContent(118, "        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(119);
                __builder2.AddAttribute(120, "Width", "335px");
                __builder2.AddAttribute(121, "IsModal", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 100 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(122, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 100 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                                               Visibility

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(123, "VisibleChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Visibility = __value, Visibility))));
                __builder2.AddAttribute(124, "VisibleExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => Visibility));
                __builder2.AddAttribute(125, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(126, "\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(127);
                    __builder3.AddAttribute(128, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(129, " Obaveštenje");
                    }
                    ));
                    __builder3.AddAttribute(130, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(131, " ");
                        __builder4.AddMarkupContent(132, "<p>Da li ste sigurni da želite da obrišete oglas</p> ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(133, "\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButtons>(134);
                    __builder3.AddAttribute(135, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(136, "\n                ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(137);
                        __builder4.AddAttribute(138, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 106 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                        ObrisiOglas

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(139, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(140, "\n                    ");
                            __builder5.OpenComponent<Syncfusion.Blazor.Popups.DialogButtonModel>(141);
                            __builder5.AddAttribute(142, "Content", "Da, siguran sam");
                            __builder5.AddAttribute(143, "IsPrimary", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 107 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                                                            true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(144, "\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(145, "\n                ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(146);
                        __builder4.AddAttribute(147, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 109 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                         () => Visibility = false

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(148, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(149, "\n                    ");
                            __builder5.OpenComponent<Syncfusion.Blazor.Popups.DialogButtonModel>(150);
                            __builder5.AddAttribute(151, "Content", "Odustani");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(152, "\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(153, "\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(154, "\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogAnimationSettings>(155);
                    __builder3.AddAttribute(156, "Effect", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Popups.DialogEffect>(
#nullable restore
#line 113 "D:\Projekti-master\Pages\MojiOglasi.razor"
                                              DialogEffect.FadeZoom

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(157, "\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(158, "\n");
#nullable restore
#line 115 "D:\Projekti-master\Pages\MojiOglasi.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(159, "    ");
            }
            ));
            __builder.AddAttribute(160, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(161, "\n        ");
                __builder2.AddMarkupContent(162, "<h2>Nema nista na ovoj stranici</h2>\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 126 "D:\Projekti-master\Pages\MojiOglasi.razor"
 
    KorisnikUsluge Korisnik = new KorisnikUsluge();
    List<Oglas> Oglasi = new List<Oglas>();

    public bool Ucitan { get; set; } = false;
    private bool Refresh { get; set; } = false;

    private bool Visibility { get; set; } = false;
    private Guid oglasZaBrisanje { get; set; }

    private class Polje
    {
        public string Id { get; set; }
        public string Tekst { get; set; }

        public Polje() { }
    }
    public class PoljeTip
    {
        public TipUsluge TipUsluge { get; set; }
        public string Tekst { get; set; }

        public PoljeTip() { }

        public PoljeTip(TipUsluge usluga)
        {
            TipUsluge = usluga;
            string[] split = Regex.Split(usluga.ToString(), @"(?<!^)(?=[A-Z])");
            string ceo = "";
            foreach (var rec in split)
            {
                ceo += rec + " ";
            }
            Tekst = ceo;
        }
    }



    private bool prikaziAktivan = true;
    private bool prikaziUIzvrsavanju = true;
    private bool prikaziIzvrsen = true;
    private bool prikaziNeaktivan = true;

    private List<Polje> listaS = new List<Polje>()
{
        new Polje() { Id = "opcija1", Tekst = "sve oglase"},
        new Polje() { Id = "opcija2", Tekst = "aktivne oglase"},
        new Polje() { Id = "opcija3", Tekst = "oglase u izvršavanju"},
        new Polje() { Id = "opcija4", Tekst = "izvršene oglase"},
        new Polje() { Id = "opcija5", Tekst = "neaktivne oglase"}
    };

    private Func<Oglas, string> kriterijumF = i => i.Stanje.ToString();
    private string kriterijumFTekst;

    private List<Polje> listaF = new List<Polje>()
{
        new Polje() { Id = "opcija1", Tekst = "stanju"},
        new Polje() { Id = "opcija2", Tekst = "naslovu"},
        new Polje() { Id = "opcija3", Tekst = "datumu važenja"},
        new Polje() { Id = "opcija4", Tekst = "broju zahteva"}
    };

    private TipUsluge kriterijumT;
    private List<PoljeTip> listaT = new List<PoljeTip>();
    private TipUsluge[] selektovaneUsluge = null;

    private void OnChangeListStanje(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        var itemData = JsonConvert.DeserializeObject<Polje>(args.ItemData != null ? args.ItemData.ToString() : "");
        prikaziAktivan = false;
        prikaziUIzvrsavanju = false;
        prikaziIzvrsen = false;
        prikaziNeaktivan = false;
        switch (itemData.Id)
        {
            case "opcija1":
                prikaziAktivan = true;
                prikaziUIzvrsavanju = true;
                prikaziIzvrsen = true;
                prikaziNeaktivan = true;
                break;
            case "opcija2":
                prikaziAktivan = true;
                break;
            case "opcija3":
                prikaziUIzvrsavanju = true;
                break;
            case "opcija4":
                prikaziIzvrsen = true;
                break;
            case "opcija5":
                prikaziNeaktivan = true;
                break;
            default:
                break;
        }
    }

    private void OnChangeListFilter(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        var itemData = JsonConvert.DeserializeObject<Polje>(args.ItemData != null ? args.ItemData.ToString() : "");
        kriterijumFTekst = itemData.Id;

        switch (kriterijumFTekst)
        {
            case "opcija1":
                /*dodato*/
                kriterijumF = i => i.Stanje.ToString();
                break;
            case "opcija2":
                kriterijumF = i => i.NaslovOglasa;
                break;
            case "opcija3":
                kriterijumF = i => i.DatumVazenja.ToString("yyyy.MM.dd");
                break;
            case "opcija4":
                kriterijumF = i =>
                {
                    var str = i.Zahtevi.Count.ToString();
                    while (str.Length < 6)
                        str = str.Insert(0, "0");
                    return str;
                };
                break;
            default:
                break;
        }
    }

    private void OnChangeListTip(MultiSelectChangeEventArgs<TipUsluge[]> args)
    {
        var itemData = args.Value;
        if (itemData == null)
        {
            itemData = (TipUsluge[])Enum.GetValues(typeof(TipUsluge));
        }
        kriterijumT = 0;
        foreach (var tip in itemData)
        {
            kriterijumT = kriterijumT | tip;
        }
        this.StateHasChanged();
    }

    protected async override Task OnInitializedAsync()
    {
        Ucitan = false;
        var state = await authenticationStateProvider.GetAuthenticationStateAsync();
        if (state.User.IsInRole("KorisnikUsluge"))
        {
            foreach (var tipUsluge in (TipUsluge[])Enum.GetValues(typeof(TipUsluge)))
            {
                kriterijumT = kriterijumT | tipUsluge;
                PoljeTip novoPolje = new PoljeTip(tipUsluge);
                listaT.Add(novoPolje);
            }

            Korisnik = await dbContext.VratiKorisnika(state.User.Identity.Name);
            foreach (var oglas in Korisnik.MojiOglasi)
            {
                if (oglas.ProveriDaLiVazi())
                {
                    dbContext.Update(oglas);
                    await dbContext.SaveChangesAsync();
                }
                Oglasi.Add(oglas);
            }
        }
    }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender && !Refresh)
        {
            Ucitan = true;
            StateHasChanged();
        }

    }

    private async Task OtvoriKorisnika(string userNameKorisnika)
    {
        var korisnik = await dbContext.VratiKorisnika(userNameKorisnika);
        if (korisnik == null)
            navMenager.NavigateTo("Profil/" + korisnik.Id);
    }

    private void OtvoriOglas(Guid idOglasa)
    {

        navMenager.NavigateTo("Oglas/" + idOglasa.ToString());

    }
    private async Task ObrisiOglas()
    {
        Refresh = true;
        Ucitan = false;
        await dbContext.ObrisiOglas(oglasZaBrisanje);
        this.Visibility = false;
        navMenager.NavigateTo("/MojiOglasi", true);
    }

    private void PostaviOglasZaBrisanje(Guid idOglasa)
    {
        oglasZaBrisanje = idOglasa;
        this.Visibility = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navMenager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MySqlCRUD dbContext { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authenticationStateProvider { get; set; }
    }
}
namespace __Blazor.Kucni_poslovi.Pages.MojiOglasi
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfMultiSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::Syncfusion.Blazor.DropDowns.VisualMode __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Object __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Boolean? __arg5, int __seq6, global::System.Boolean __arg6, int __seq7, global::System.String __arg7, int __seq8, global::System.String __arg8, int __seq9, global::System.String __arg9, int __seq10, TValue __arg10, int __seq11, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg11, int __seq12, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg12, int __seq13, global::Microsoft.AspNetCore.Components.RenderFragment __arg13)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.DropDowns.SfMultiSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Mode", __arg0);
        __builder.AddAttribute(__seq1, "Placeholder", __arg1);
        __builder.AddAttribute(__seq2, "DataSource", __arg2);
        __builder.AddAttribute(__seq3, "ShowDropDownIcon", __arg3);
        __builder.AddAttribute(__seq4, "EnableSelectionOrder", __arg4);
        __builder.AddAttribute(__seq5, "AllowFiltering", __arg5);
        __builder.AddAttribute(__seq6, "ShowSelectAll", __arg6);
        __builder.AddAttribute(__seq7, "UnSelectAllText", __arg7);
        __builder.AddAttribute(__seq8, "SelectAllText", __arg8);
        __builder.AddAttribute(__seq9, "Width", __arg9);
        __builder.AddAttribute(__seq10, "Value", __arg10);
        __builder.AddAttribute(__seq11, "ValueChanged", __arg11);
        __builder.AddAttribute(__seq12, "ValueExpression", __arg12);
        __builder.AddAttribute(__seq13, "ChildContent", __arg13);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591