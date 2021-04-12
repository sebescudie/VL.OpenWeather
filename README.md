# VL.OpenWeather

[![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/VL.OpenWeather?style=flat-square)](https://www.nuget.org/packages/VL.OpenWeather/)


Allows to retrieve results from OpenWeather's [OneCall](https://openweathermap.org/api/one-call-api) API. Only retrieves current weather and previsions for the next 60 minutes, 48 hours and 7 days, as well as weather alerts. Historical data from the last five days is not implemented yet.

Works with OpenWeather's API v2.5 (`https://api.openweathermap.org/data/2.5/onecall`).

## Installation

Go to VL's command line and type

```
nuget install VL.OpenWeather -pre
```

Please note that this will only work with VL > 2020.3

## Prerequisites

You'll need a free API key from OpenWeather to use this plugin. Check [this page](https://openweathermap.org/price) for more information.

## Getting Started

Check the help browser, a help patch shows you how to make a call and retrieve weather data, and a small example shows how you can build a basic weather app using this API

![](/img/sunny.gif)