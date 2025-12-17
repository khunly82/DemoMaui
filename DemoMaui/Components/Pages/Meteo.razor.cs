using DemoMaui.Models;
using DemoMaui.Services;
using Microsoft.AspNetCore.Components;

namespace DemoMaui.Components.Pages
{
    public partial class Meteo
    {
        [Inject]
        public MeteoService MeteoService { get; set; } = null!;

        public MeteoData? Data { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Data = await MeteoService.GetMeteoAsync(50.294, 5.1);
        }

        //public async Task LoadData()
        //{
        //    Data = await MeteoService.GetMeteoAsync(50.294, 5.1);
        //    StateHasChanged();
        //}
    }
}
