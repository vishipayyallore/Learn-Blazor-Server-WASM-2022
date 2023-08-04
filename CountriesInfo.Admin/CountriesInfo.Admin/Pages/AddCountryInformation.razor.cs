using CountriesInfo.Admin.Data;
using Microsoft.AspNetCore.Components;
using System.Text;
using System.Text.Json;

namespace CountriesInfo.Admin.Pages;

public partial class AddCountryInformation
{

    private AddCountryInformationDto addCountryInformationDto = new();
    private bool isFormSubmitted = false;

    [Inject]
    public IHttpClientFactory _httpClientFactory { get; set; }

    public AddCountryInformation()
    {
    }

    public AddCountryInformation(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    private async Task HandleFormSubmit()
    {
        var client = _httpClientFactory.CreateClient("FlaskCountriesAPI");

        var json = JsonSerializer.Serialize(new { country_name = addCountryInformationDto.CountryName });
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await client.PostAsync("api/countryinfo", content);

        if (response.IsSuccessStatusCode)
        {
            isFormSubmitted = true;
            StateHasChanged();
        }
        else
        {
            // Handle API error
        }
    }
}
