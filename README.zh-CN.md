# 英雄联盟客户端 (WinUI 3)

[![English](https://img.shields.io/badge/docs-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/docs-中文-red.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/docs-한국어-green.svg)](README.ko.md)

这是一个使用 WinUI 3 技术高质量重现的英雄联盟客户端项目。该项目展示了 WinUI 3 的各种实现技术，并演示了大型项目分布式设计的广泛技术方法。

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnetgroup/leagueoflegends-winui3.svg)](https://github.com/jamesnetgroup/leagueoflegends-winui3/stargazers)
[![Forks](https://img.shields.io/github/forks/jamesnetgroup/leagueoflegends-winui3.svg)](https://github.com/jamesnetgroup/leagueoflegends-winui3/network/members)
[![Issues](https://img.shields.io/github/issues/jamesnetgroup/leagueoflegends-winui3.svg)](https://github.com/jamesnetgroup/leagueoflegends-winui3/issues)

#### 英雄联盟 XAML 基础系列：
[英雄联盟客户端 (WPF)](https://github.com/jamesnetgroup/leagueoflegends-wpf)  
[英雄联盟客户端 (Uno-Platform)](https://github.com/jamesnetgroup/leagueoflegends-uno)  
[英雄联盟客户端 (WinUI 3)](https://github.com/jamesnetgroup/leagueoflegends-winui3)

> 如果你是 WPF 或 Uno Platform 开发者，你将看到基于 XAML 的技能如何过渡到 WinUI 3 开发。

## 项目概述

我们自 2008 年以来一直在研究并积累基于 XAML 的技术经验。多年来，WPF、UWP 以及现在的 WinUI 3 等各种技术不断发展，使我们能够将技能扩展到最新的 Windows UI 框架。

我们发布的这个英雄联盟 WinUI 3 版本建立在基于 XAML 的丰富 UX 设计、C# 的面向对象设计以及系统化的项目结构之上。这是继我们之前的 WPF 和 Uno Platform 版本的英雄联盟项目之后的新挑战。

本项目展示了如何使用 WinUI 3 实现大型项目。通过将复杂控件实现为 CustomControls，我们旨在为开发者提供丰富的学习材料。此外，它还包括 WinUI 3 的各种技术实现案例，展示了如何在实际项目中利用这个框架的强大功能。

特别是，本项目展示了大型应用程序分布式设计的广泛方法。它演示了如何通过模块化结构、高效的状态管理和可扩展的架构来构建和管理复杂的应用程序。

Jamesnet.Core 框架库基于 .NET Standard 2.0 设计，可以在 WPF、Uno Platform 以及现在的 WinUI 3 中相同地工作。该库作为 Jamesnet.Window 提供给 WPF，作为 Jamesnet.Uno 提供给 Uno Platform，现在作为 Jamesnet.WinUI3 提供给 WinUI 3。

在本项目中，我们直接引用了 Jamesnet.Core 和 Jamesnet.WinUI3 的实际源代码，让您可以学习基于 XAML 的框架的设计方法。

我们希望这个项目不仅能在 WinUI 3 中广泛使用，还能作为各种基于 XAML 的平台的参考，为 Windows 应用程序开发开辟新的视野。

<img src="https://github.com/user-attachments/assets/3bc0d881-577e-4aa2-8802-698169d701a5" width="49%"/>
<img src="https://github.com/user-attachments/assets/d3b13869-d0f8-457d-90d9-5a637c500b4a" width="49%"/>
<img src="https://github.com/user-attachments/assets/45920f83-41b9-4924-8e92-86123d15a2a4" width="49%"/>
<img src="https://github.com/user-attachments/assets/4e41c4af-1a98-48b0-9c44-05ac48f0430e" width="49%"/>
<img src="https://github.com/user-attachments/assets/78415f9d-732c-4940-881c-beed7a6e9620" width="49%"/>
<img src="https://github.com/user-attachments/assets/b376f4ed-4ffd-4528-b1cc-6b0483f442e1" width="49%"/>
<img src="https://github.com/user-attachments/assets/3bc0d881-577e-4aa2-8802-698169d701a5" width="49%"/>
<img src="https://github.com/user-attachments/assets/0cedb504-2f27-43b8-87ed-34e85f1d7b83" width="49%"/>
<img src="https://github.com/user-attachments/assets/f5e80933-9d18-47c1-81c6-eb55a680972a" width="49%"/>
<img src="https://github.com/user-attachments/assets/d8aa51d5-c6e1-4a9a-95f8-e20a7c6f9f91" width="49%"/>
<img src="https://github.com/user-attachments/assets/c2cc6c22-8345-4333-83a2-61ab08883652" width="49%"/>
<img src="https://github.com/user-attachments/assets/fd6aa0ca-14c1-4446-b6cb-2617bc15b373" width="49%"/>
<img src="https://github.com/user-attachments/assets/be84fe63-4fb5-4a6c-a537-9907b88e648b" width="49%"/>
<img src="https://github.com/user-attachments/assets/24db2d8b-b839-42b2-be8a-2fc6266dad77" width="49%"/>
<img src="https://github.com/user-attachments/assets/642ccf0d-f2df-4adc-bb87-b1246cbda0b7" width="49%"/>
<img src="https://github.com/user-attachments/assets/bece2bfd-1bb9-436e-b928-929d3706398c" width="49%"/>

## 支持的平台

本项目支持以下平台：

- **Windows**：在 Windows 10 版本 1809（内部版本 17763）或更高版本上作为本机应用程序运行。

注意：这个应用程序是专门使用 WinUI 3 为 Windows 环境开发的。它不像 Uno Platform 版本那样支持跨平台开发。

## 如何运行

当你克隆此存储库时，它默认设置为 .NET 8.0 环境。你可以立即使用 Windows 上的 Visual Studio 2022 构建和运行它。

### 配置：

项目文件配置如下。你可以根据需要调整 .NET 版本。

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

## 为项目做贡献

欢迎你的贡献！随时提交 Pull Requests。

## 许可证

本项目采用 MIT 许可证。详情请参见 [LICENSE](LICENSE) 文件。
