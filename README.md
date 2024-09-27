# League of Legends Client (WinUI 3)

[![English](https://img.shields.io/badge/docs-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/docs-中文-red.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/docs-한국어-green.svg)](README.ko.md)

This is a high-quality recreation project of the League of Legends client using WinUI 3. The project showcases various implementation techniques of WinUI 3 and demonstrates a wide range of technical approaches to distributed design for large-scale projects.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-6.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnetgroup/leagueoflegends-winui3.svg)](https://github.com/jamesnetgroup/leagueoflegends-winui3/stargazers)
[![Forks](https://img.shields.io/github/forks/jamesnetgroup/leagueoflegends-winui3.svg)](https://github.com/jamesnetgroup/leagueoflegends-winui3/network/members)
[![Issues](https://img.shields.io/github/issues/jamesnetgroup/leagueoflegends-winui3.svg)](https://github.com/jamesnetgroup/leagueoflegends-winui3/issues)

#### League of Legends XAML-Based Series:  
[League of Legends Client (WPF)](https://github.com/jamesnetgroup/leagueoflegends-wpf)  
[League of Legends Client (Uno-Platform)](https://github.com/jamesnetgroup/leagueoflegends-uno)  
[League of Legends Client (WinUI 3)](https://github.com/jamesnetgroup/leagueoflegends-winui3)

> If you are a WPF or Uno Platform developer, you will see how XAML-based skills transition into WinUI 3 development.

## Project Overview

We have been researching and gaining experience with XAML-based technologies since 2008. Over the years, various technologies such as WPF, UWP, and now WinUI 3 have evolved, allowing us to extend our skills to the latest Windows UI framework.

This League of Legends WinUI 3 version we're releasing is built on the rich UX of XAML-based design, C#'s object-oriented design, and a systematic project structure. It's a new challenge following our previous WPF and Uno Platform versions of the League of Legends project.

This project demonstrates how to implement large-scale projects using WinUI 3. By implementing complex controls as CustomControls, we aim to provide developers with rich learning materials. Furthermore, it includes various technical implementation cases of WinUI 3, showcasing how to utilize the powerful features of this framework in real projects.

In particular, this project presents a broad approach to distributed design for large-scale applications. It demonstrates how to structure and manage complex applications through modularized structures, efficient state management, and scalable architecture.

The Jamesnet.Core framework library is designed based on .NET Standard 2.0 to work identically in WPF, Uno Platform, and now WinUI 3. This library is provided as Jamesnet.Window for WPF, Jamesnet.Uno for the Uno Platform, and now Jamesnet.WinUI3 for WinUI 3.

In this project, we directly reference the actual source code of Jamesnet.Core and Jamesnet.WinUI3, allowing you to learn about the design methods of XAML-based frameworks.

We hope this project will be widely used not only in WinUI 3 but also serve as a reference for various XAML-based platforms, opening new horizons for Windows application development.

[Images would remain the same as in the original document]

## Supported Platforms

This project supports the following platforms:

- **Windows**: Run as a native application on Windows 10 version 1809 (build 17763) or later.

Note: This application is specifically developed for the Windows environment using WinUI 3. It does not support cross-platform development like the Uno Platform version.

## How to Run

When you clone this repository, it's set up for the .NET 6.0 environment by default. You can build and run it immediately using Visual Studio 2022 on Windows.

### Configuration:

The project file is configured as follows. You can adjust the .NET version as needed.

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>WinExe</OutputType>
    <TargetFramework>net8.0-windows10.0.19041.0</TargetFramework>
    <TargetPlatformMinVersion>10.0.17763.0</TargetPlatformMinVersion>
    <UseWinUI>true</UseWinUI>
  </PropertyGroup>
</Project>
```

## Contributing to the Project

Your contributions are welcome! Feel free to submit Pull Requests.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Development Roadmap
Here are the items that need development in the future. Anyone can participate in these tasks and become a contributor. We look forward to your opinions and participation!

- [ ] Implement GradientBrush for Foreground
- [ ] Customize TextBox CaretBrush color
- [ ] Improve TextBox CustomControl
- [ ] Enhance ScrollViewer CustomControl
- [ ] Resolve view coordinate update issue when changing main window position
- [ ] Improve DependencyProperty Callback handling timing
- [ ] Add multi-language support
- [ ] Implement multi-theme support
- [ ] Optimize performance for large-scale data handling
- [ ] Implement advanced animations using Composition API
- [ ] Integrate with Windows App SDK features
