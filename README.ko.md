# 리그 오브 레전드 클라이언트 (WinUI 3)

[![English](https://img.shields.io/badge/docs-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/docs-中文-red.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/docs-한국어-green.svg)](README.ko.md)

이는 WinUI 3를 사용하여 고품질로 재현한 리그 오브 레전드 클라이언트 프로젝트입니다. 이 프로젝트는 WinUI 3의 다양한 구현 기술을 보여주며, 대규모 프로젝트의 분산 설계에 대한 광범위한 기술적 접근을 보여줍니다.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnetgroup/leagueoflegends-winui3.svg)](https://github.com/jamesnetgroup/leagueoflegends-winui3/stargazers)
[![Forks](https://img.shields.io/github/forks/jamesnetgroup/leagueoflegends-winui3.svg)](https://github.com/jamesnetgroup/leagueoflegends-winui3/network/members)
[![Issues](https://img.shields.io/github/issues/jamesnetgroup/leagueoflegends-winui3.svg)](https://github.com/jamesnetgroup/leagueoflegends-winui3/issues)

#### 리그 오브 레전드 XAML 기반 시리즈:
<div style="text-align: center;">
    <img src="https://jamesnetdev.blob.core.windows.net/articleimages/543a4bd8-ace3-4d1a-acab-36f5b7f8b200.png" width="8%"/>
    <img src="https://jamesnetdev.blob.core.windows.net/articleimages/0d8bd5b4-c898-4bcf-af91-b4267551934f.png" width="20%"/>
    <img src="https://jamesnetdev.blob.core.windows.net/articleimages/77eaa9cd-865b-430d-89c6-0e10ead0abd5.png" width="8%"/>
</div>

<br/>

[리그 오브 레전드 클라이언트 (WPF)](https://github.com/jamesnetgroup/leagueoflegends-wpf)  
[리그 오브 레전드 클라이언트 (Uno-Platform)](https://github.com/jamesnetgroup/leagueoflegends-uno)  
[리그 오브 레전드 클라이언트 (WinUI 3)](https://github.com/jamesnetgroup/leagueoflegends-winui3)

> WPF 또는 Uno Platform 개발자라면, XAML 기반 기술이 어떻게 WinUI 3 개발로 전환되는지 볼 수 있습니다.

## 프로젝트 개요

우리는 2008년부터 XAML 기반 기술을 연구하고 경험을 쌓아왔습니다. 수년간 WPF, UWP, 그리고 이제 WinUI 3와 같은 다양한 기술이 발전해왔으며, 이를 통해 우리의 기술을 최신 Windows UI 프레임워크로 확장할 수 있게 되었습니다.

우리가 출시하는 이 리그 오브 레전드 WinUI 3 버전은 XAML 기반의 풍부한 UX 설계, C#의 객체 지향 설계, 그리고 체계적인 프로젝트 구조를 기반으로 구축되었습니다. 이는 이전의 WPF와 Uno Platform 버전의 리그 오브 레전드 프로젝트에 이은 새로운 도전입니다.

이 프로젝트는 WinUI 3를 사용하여 대규모 프로젝트를 구현하는 방법을 보여줍니다. 복잡한 컨트롤을 CustomControls로 구현함으로써 개발자들에게 풍부한 학습 자료를 제공하고자 합니다. 또한 WinUI 3의 다양한 기술 구현 사례를 포함하고 있어, 실제 프로젝트에서 이 프레임워크의 강력한 기능을 어떻게 활용할 수 있는지 보여줍니다.

특히 이 프로젝트는 대규모 애플리케이션의 분산 설계에 대한 광범위한 접근 방식을 제시합니다. 모듈화된 구조, 효율적인 상태 관리, 확장 가능한 아키텍처를 통해 복잡한 애플리케이션을 어떻게 구조화하고 관리할 수 있는지 보여줍니다.

Jamesnet.Core 프레임워크 라이브러리는 .NET Standard 2.0을 기반으로 설계되어 WPF, Uno Platform, 그리고 이제 WinUI 3에서 동일하게 작동합니다. 이 라이브러리는 WPF용 Jamesnet.Window, Uno Platform용 Jamesnet.Uno, 그리고 이제 WinUI 3용 Jamesnet.WinUI3로 제공됩니다.

이 프로젝트에서는 Jamesnet.Core와 Jamesnet.WinUI3의 실제 소스 코드를 직접 참조하여, XAML 기반 프레임워크의 설계 방법을 배울 수 있게 합니다.

우리는 이 프로젝트가 WinUI 3뿐만 아니라 다양한 XAML 기반 플랫폼의 참조로 널리 사용되어, Windows 애플리케이션 개발의 새로운 지평을 열기를 희망합니다.

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

## 지원 플랫폼

이 프로젝트는 다음 플랫폼을 지원합니다:

- **Windows**: Windows 10 버전 1809(빌드 17763) 이상에서 네이티브 애플리케이션으로 실행.

참고: 이 애플리케이션은 WinUI 3를 사용하여 Windows 환경에 특화되어 개발되었습니다. Uno Platform 버전과 달리 크로스 플랫폼 개발을 지원하지 않습니다.

## 실행 방법

이 저장소를 클론하면 기본적으로 .NET 8.0 환경으로 설정됩니다. Windows의 Visual Studio 2022를 사용하여 즉시 빌드하고 실행할 수 있습니다.

### 구성:

프로젝트 파일은 다음과 같이 구성되어 있습니다. 필요에 따라 .NET 버전을 조정할 수 있습니다.

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

## 프로젝트에 기여하기
여러분의 기여를 환영합니다! 언제든지 Pull Request를 제출해 주세요.

## 라이선스

이 프로젝트는 MIT 라이선스 하에 제공됩니다. 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.
