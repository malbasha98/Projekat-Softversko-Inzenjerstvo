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
#line 5 "D:\Projekti-master\Pages\Index.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projekti-master\Pages\Index.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 196 "D:\Projekti-master\Pages\Index.razor"
 
    private bool Ucitan { get; set; } = false;

    private string tekstKorisnik = "Treba Vam pomoć u kući? Registrujte se kao Korisnik usluge, postavite oglas za posao i pronađite osobu koja Vam može pomoći!";
    private string tekstPruzalac = "Tražite honorarni posao vezan za pomoć u kući? Registrujte se kao Pružalac usluge i pronađite odgovarajući posao!";

    private KorisnikUsluge Korisnik = new KorisnikUsluge();
    private PruzalacUsluge Pruzalac = new PruzalacUsluge();

    private List<PruzalacUsluge> preporuceniPruzaoci = new List<PruzalacUsluge>();
    private Func<PruzalacUsluge, string> kriterijumK = i => i.UserName;
    private string kriterijumKTekst;

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

    private TipUsluge kriterijumT;
    private List<PoljeTip> listaT = new List<PoljeTip>();
    private TipUsluge[] selektovaneUsluge = null;

    private List<Polje> listaK = new List<Polje>()
{
        new Polje() { Id = "opcija1", Tekst = "korisničkom imenu"},
        new Polje() { Id = "opcija2", Tekst = "imenu"},
        new Polje() { Id = "opcija3", Tekst = "prezimenu"},
        new Polje() { Id = "opcija4", Tekst = "prosečnoj oceni"}
    };

    private void OnChangeListKorisnik(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        var itemData = JsonConvert.DeserializeObject<Polje>(args.ItemData != null ? args.ItemData.ToString() : "");
        kriterijumKTekst = itemData.Id;

        switch (kriterijumKTekst)
        {
            case "opcija1":
                kriterijumK = i => i.UserName;
                break;
            case "opcija2":
                kriterijumK = i => i.Ime;
                break;
            case "opcija3":
                kriterijumK = i => i.Prezime;
                break;
            case "opcija4":
                kriterijumK = i => (5 - i.ProsecnaOcena).ToString();
                break;
            default:
                break;
        }
    }

    private List<Oglas> preporuceniOglasi = new List<Oglas>();
    private Func<Oglas, string> kriterijumP = i => i.DatumVazenja.ToString();
    private string kriterijumPTekst;

    private List<Polje> listaP = new List<Polje>()
{
        new Polje() { Id = "opcija1", Tekst = "datumu važenja"},
        new Polje() { Id = "opcija2", Tekst = "prosečnoj oceni vlasnika"},
        new Polje() { Id = "opcija3", Tekst = "naslovu"}
    };

    private void OnChangeListPruzalac(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        var itemData = JsonConvert.DeserializeObject<Polje>(args.ItemData != null ? args.ItemData.ToString() : "");
        kriterijumPTekst = itemData.Id;

        switch (kriterijumPTekst)
        {
            case "opcija1":
                kriterijumP = i => i.DatumVazenja.ToString("yyyy.MM.dd");
                break;
            case "opcija2":
                kriterijumP = i => (5 - i.KorisnikUsluge.ProsecnaOcena).ToString();
                break;
            case "opcija3":
                kriterijumP = i => i.NaslovOglasa;
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


    private void NoviOglas()
    {
        navMenager.NavigateTo("NoviOglas",true);
    }

    private void NavKorisnik()
    {
        navMenager.NavigateTo("/RegistrujKorisnika", true);
    }

    private void NavPruzalac()
    {
        navMenager.NavigateTo("/RegistrujPruzaoca", true);
    }

    protected async override Task OnInitializedAsync()
    {
        Ucitan = false;
        var state = await authenticationStateProvider.GetAuthenticationStateAsync();

        if (state.User.IsInRole("PruzalacUsluge"))
        {
            Pruzalac = await dbContext.VratiPruzaoca(state.User.Identity.Name);
            foreach (var tipUsluge in (TipUsluge[])Enum.GetValues(typeof(TipUsluge)))
            {
                kriterijumT = kriterijumT | tipUsluge;
                if ((Pruzalac.TipUsluga & tipUsluge) != tipUsluge)
                    continue;
                PoljeTip novoPolje = new PoljeTip(tipUsluge);
                listaT.Add(novoPolje);
            }
            foreach (var ev in Pruzalac.Evidencije)
            {
                var oglas = ev.Oglas;
                if (oglas.ProveriDaLiVazi())
                {
                    dbContext.Update(oglas);
                    await dbContext.SaveChangesAsync();
                }
                if (oglas.Stanje == Stanje.Aktivan)//ne dodavati ako je poslat zahtev
                {
                    if (await dbContext.PostojiZahtevKaKorisniku(Pruzalac.Id, oglas.Id))
                        continue;
                    preporuceniOglasi.Add(oglas);
                }

            }
        }
        else if (state.User.IsInRole("KorisnikUsluge"))
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
                if (oglas.Stanje == Stanje.Aktivan)
                {
                    foreach (var ev in oglas.Evidencije)
                    {
                        var postoji = await dbContext.PostojiZahtevKaPruzaocu(Korisnik.UserName, ev.PruzalacUsluge.Id, oglas.Id);
                        if (!preporuceniPruzaoci.Contains(ev.PruzalacUsluge) && !postoji)
                            preporuceniPruzaoci.Add(ev.PruzalacUsluge);
                    }
                }
            }
        }
        
    }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender)
        {
            Ucitan = true;
            StateHasChanged();
        }

    }

    private void PrikaziProfil(string id)
    {
        Ucitan = false;
        navMenager.NavigateTo("Profil/" + id);
    }

    private void PrikaziOglas(Guid id)
    {
        navMenager.NavigateTo("Oglas/" + id.ToString());
    }

    private string Usluga(PruzalacUsluge p)
    {
        string s = "";
        foreach (TipUsluge tip in (TipUsluge[])Enum.GetValues(typeof(TipUsluge)))
        {
            if ((p.TipUsluga & tip) == tip)
                s += tip.ToString() + ", ";
        }
        if (s != "")
            s = s.Remove(s.Length - 2);
        return s;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MySqlCRUD dbContext { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navMenager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591