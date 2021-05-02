using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RZielinski_Final_Project_2021.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace RZielinski_Final_Project_2021.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IHttpClientFactory clientFactory;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory HttpClientFactory)
        {
            _logger = logger;
            clientFactory = HttpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        // This section of the controller handles the Weather Forecast endpoint in the API
        [HttpGet]
        [ProducesResponseType(200,Type = typeof(WeatherForecast))]
        public async Task<IActionResult> Weather()
        {
            string uri;

            ViewData["Title"] = "Weather Forecast";
            uri = $"WeatherForecast";

            var client = clientFactory.CreateClient(
                name: "Shadow_Info");

            var request = new HttpRequestMessage(
                method: HttpMethod.Get, requestUri: uri);

            HttpResponseMessage response = await client.SendAsync(request);

            var model = await response.Content.ReadFromJsonAsync<WeatherForecast>();

            return View(model);
        }

        // This section of the controller handles the detailed Weather Forecast endpoint in the API
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(WeatherForecastDetailed))]
        public async Task<IActionResult> WeatherForecastDetailed()
        {
            string uri;

            ViewData["Title"] = "Weather Forecast Details";
            uri = $"WeatherForecast/details";

            var client = clientFactory.CreateClient(
                name: "Shadow_Info");

            var request = new HttpRequestMessage(
                method: HttpMethod.Get, requestUri: uri);

            HttpResponseMessage response = await client.SendAsync(request);

            var model = await response.Content.ReadFromJsonAsync<WeatherForecastDetailed>();

            return View(model);
        }

        // This section of the controller handles the hourly Weather Forecast endpoint in the API
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<WeatherForecastHourly>))]
        public async Task<IActionResult> WeatherForecastHourly()
        {
            string uri;

            ViewData["Title"] = "Weather Forecast Hourly";
            uri = $"WeatherForecast/hourly";

            var client = clientFactory.CreateClient(
                name: "Shadow_Info");

            var request = new HttpRequestMessage(
                method: HttpMethod.Get, requestUri: uri);

            HttpResponseMessage response = await client.SendAsync(request);

            var model = await response.Content.ReadFromJsonAsync<IEnumerable<WeatherForecastHourly>>();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
