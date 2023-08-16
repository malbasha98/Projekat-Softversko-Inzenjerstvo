// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591