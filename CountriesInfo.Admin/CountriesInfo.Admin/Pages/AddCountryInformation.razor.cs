using CountriesInfo.Admin.Data;
using Microsoft.AspNetCore.Components;
using System.Text;
using System.Text.Json;

namespace CountriesInfo.Admin.Pages;

public partial class AddCountryInformation
{

    private AddCountryInformationDto addCountryInformationDto = new();
    private bool isFormSubmitted = false;
    private string? SuccessMessage { get; set; }
    private string? ErrorMessage { get; set; }

    public bool IsBusy { get; set; }

    [Inject]
    public IHttpClientFactory? _httpClientFactory { get; set; }

    public AddCountryInformation()
    {
    }

    private async Task HandleFormSubmit()
    {
        if (IsBusy)
        {
            return;
        }

        IsBusy = true;

        try
        {
            var client = _httpClientFactory!.CreateClient("FlaskCountriesAPI");

            var json = JsonSerializer.Serialize(new { country_name = addCountryInformationDto.CountryName });
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("api/getcountryinfo", content);

            if (response.IsSuccessStatusCode)
            {
                isFormSubmitted = true;
                ErrorMessage = null;
                StateHasChanged();
            }
            else
            {
                // Handle API error
            }
        }
        catch (Exception ex)
        {
            SuccessMessage = null;
            ErrorMessage = $"Error while adding country information: {ex.Message}";
        }
        finally
        {
            IsBusy = false;
        }
    }
}
