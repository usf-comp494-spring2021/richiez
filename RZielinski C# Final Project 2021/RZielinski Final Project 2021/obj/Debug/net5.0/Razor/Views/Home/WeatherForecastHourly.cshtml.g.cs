#pragma checksum "d:\Users\Richard\Desktop\hi\RZielinski C# Final Project 2021\RZielinski Final Project 2021\Views\Home\WeatherForecastHourly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fcbaf9a00d396883b990bec294f83a2b9486de4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WeatherForecastHourly), @"mvc.1.0.view", @"/Views/Home/WeatherForecastHourly.cshtml")]
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
#nullable restore
#line 1 "d:\Users\Richard\Desktop\hi\RZielinski C# Final Project 2021\RZielinski Final Project 2021\Views\_ViewImports.cshtml"
using RZielinski_Final_Project_2021;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\Users\Richard\Desktop\hi\RZielinski C# Final Project 2021\RZielinski Final Project 2021\Views\_ViewImports.cshtml"
using RZielinski_Final_Project_2021.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fcbaf9a00d396883b990bec294f83a2b9486de4", @"/Views/Home/WeatherForecastHourly.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4560a778d7b40dd11c6ee8044d51fb6362e1b01", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_WeatherForecastHourly : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WeatherForecastHourly>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "d:\Users\Richard\Desktop\hi\RZielinski C# Final Project 2021\RZielinski Final Project 2021\Views\Home\WeatherForecastHourly.cshtml"
  
    ViewData["Title"] = "Weather Forecast Hourly";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Hourly Weather Forecast</h1>\r\n");
#nullable restore
#line 8 "d:\Users\Richard\Desktop\hi\RZielinski C# Final Project 2021\RZielinski Final Project 2021\Views\Home\WeatherForecastHourly.cshtml"
   foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Forecast Date: ");
#nullable restore
#line 11 "d:\Users\Richard\Desktop\hi\RZielinski C# Final Project 2021\RZielinski Final Project 2021\Views\Home\WeatherForecastHourly.cshtml"
                     Write(Html.DisplayFor(modelItem => item.forecastDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Temperature: ");
#nullable restore
#line 12 "d:\Users\Richard\Desktop\hi\RZielinski C# Final Project 2021\RZielinski Final Project 2021\Views\Home\WeatherForecastHourly.cshtml"
                   Write(Html.DisplayFor(modelItem => item.temperature));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Feels Like: ");
#nullable restore
#line 13 "d:\Users\Richard\Desktop\hi\RZielinski C# Final Project 2021\RZielinski Final Project 2021\Views\Home\WeatherForecastHourly.cshtml"
                  Write(Html.DisplayFor(modelItem => item.feelsLike));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Descriptor: ");
#nullable restore
#line 14 "d:\Users\Richard\Desktop\hi\RZielinski C# Final Project 2021\RZielinski Final Project 2021\Views\Home\WeatherForecastHourly.cshtml"
                  Write(Html.DisplayFor(modelItem => item.descriptor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Image Path: ");
#nullable restore
#line 15 "d:\Users\Richard\Desktop\hi\RZielinski C# Final Project 2021\RZielinski Final Project 2021\Views\Home\WeatherForecastHourly.cshtml"
                  Write(Html.DisplayFor(modelItem => item.imagePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Wind Speed: ");
#nullable restore
#line 16 "d:\Users\Richard\Desktop\hi\RZielinski C# Final Project 2021\RZielinski Final Project 2021\Views\Home\WeatherForecastHourly.cshtml"
                  Write(Html.DisplayFor(modelItem => item.windSpeed));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Wind Direction: ");
#nullable restore
#line 17 "d:\Users\Richard\Desktop\hi\RZielinski C# Final Project 2021\RZielinski Final Project 2021\Views\Home\WeatherForecastHourly.cshtml"
                      Write(Html.DisplayFor(modelItem => item.windDirection));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Pressure: ");
#nullable restore
#line 18 "d:\Users\Richard\Desktop\hi\RZielinski C# Final Project 2021\RZielinski Final Project 2021\Views\Home\WeatherForecastHourly.cshtml"
                Write(Html.DisplayFor(modelItem => item.pressure));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Precipitation Percent: ");
#nullable restore
#line 19 "d:\Users\Richard\Desktop\hi\RZielinski C# Final Project 2021\RZielinski Final Project 2021\Views\Home\WeatherForecastHourly.cshtml"
                             Write(Html.DisplayFor(modelItem => item.precipitationPercent));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Precipitation Amount: ");
#nullable restore
#line 20 "d:\Users\Richard\Desktop\hi\RZielinski C# Final Project 2021\RZielinski Final Project 2021\Views\Home\WeatherForecastHourly.cshtml"
                            Write(Html.DisplayFor(modelItem => item.precipitationAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Cloud Cover: ");
#nullable restore
#line 21 "d:\Users\Richard\Desktop\hi\RZielinski C# Final Project 2021\RZielinski Final Project 2021\Views\Home\WeatherForecastHourly.cshtml"
                   Write(Html.DisplayFor(modelItem => item.cloudCover));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Dew Point: ");
#nullable restore
#line 22 "d:\Users\Richard\Desktop\hi\RZielinski C# Final Project 2021\RZielinski Final Project 2021\Views\Home\WeatherForecastHourly.cshtml"
                 Write(Html.DisplayFor(modelItem => item.dewPoint));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Humidity: ");
#nullable restore
#line 23 "d:\Users\Richard\Desktop\hi\RZielinski C# Final Project 2021\RZielinski Final Project 2021\Views\Home\WeatherForecastHourly.cshtml"
                Write(Html.DisplayFor(modelItem => item.humidity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>-------------------------------------------------</p>\r\n");
#nullable restore
#line 25 "d:\Users\Richard\Desktop\hi\RZielinski C# Final Project 2021\RZielinski Final Project 2021\Views\Home\WeatherForecastHourly.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WeatherForecastHourly>> Html { get; private set; }
    }
}
#pragma warning restore 1591