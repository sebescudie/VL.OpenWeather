# VL.OpenWeather

[![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/VL.OpenWeather?style=flat-square)](https://www.nuget.org/packages/VL.OpenWeather/)


## What's inside

Wraps some of OpenWeather's APIs :

### [OneCall 3.0](https://openweathermap.org/api/one-call-3)

- [Current and forecast weather data](https://openweathermap.org/api/one-call-3#current)
	- Minute forecast for 1 hour
	- Hourly forecast for 48 hours
	- Daily forecast for 7 days
	- National weather alerts
- [Historical weather data for the previous 5 days](https://openweathermap.org/api/one-call-3#history)

### [Air Pollution API](https://openweathermap.org/api/air-pollution)

- Air pollution history
- Air pollution forecast

## Compatibility

- Starting with `1.0.0-preview07` this plugin only works with vvvv gamma 2021.4.11. Older previews should work with any vvvv version
- Starting with `1.0.0`, this plugin was only tested with vvvv gamma 5.1

## Installation

Go to vvvv gamma's command line and type

```
nuget install VL.OpenWeather
```

## Prerequisites

You'll need a free API key from OpenWeather to use this plugin. Check [this page](https://openweathermap.org/price) for more information.

## Getting Started

Check the help browser, a help patch shows you how to make a call and retrieve weather data, and a small example shows how you can build a basic weather app using this API

![](/img/sunny.gif)