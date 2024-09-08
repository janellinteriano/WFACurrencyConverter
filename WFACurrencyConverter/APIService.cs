using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// contains classes for sending HTTP requests and receiving HTTP responses
using System.Net.Http;
// supports asynchronous programming
using System.Threading.Tasks;
// provides functionality for JSON serialization and deserialization
using System.Text.Json;

namespace WFACurrencyConverter
{
    // API Service class will handle the API calls
    public class APIService
    {
        // fields

        // API Key
        private readonly string _apiKey;
        // HTTP Client
        private readonly HttpClient _httpClient;

        // constructor
        public APIService(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
        }

        // method to get the exchange rate (sends GET request, parses through recieved JSON response, and returns exchange rate)
        public async Task<decimal> GetExchangeRateAsync(string baseCurrency, string targetCurrency, decimal amountToConvert)
        {
            // API url
            string url = $"https://v6.exchangerate-api.com/v6/{_apiKey}/pair/{baseCurrency}/{targetCurrency}/{amountToConvert}";

            try
            {
                // send a GET request to the specified Uri as an asynchronous operation
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                // throws an exception if the HTTP response was unsuccessful
                response.EnsureSuccessStatusCode();
                // read the HTTP response content as a string
                string responseData = await response.Content.ReadAsStringAsync();


                // Parsing the JSON response
                var jsonDocument = JsonDocument.Parse(responseData);
                var root = jsonDocument.RootElement;
                var conversionResult = root.GetProperty("conversion_result").GetDecimal();

                return conversionResult;
            }
            catch (HttpRequestException e)
            {
                // log the exception
                Console.WriteLine($"An error occurred: {e.Message}");
                return 0;
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Currency not found in the response.");
                return 0;
            }
        }
        
    }
}
