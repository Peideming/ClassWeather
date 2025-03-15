# ClassWeather 🌤️

**版本**: V1.0  
**项目类型**: 轻量化天气小插件（Windows 窗体应用）

---

## 🚀 功能特性

- **实时天气预览**  
  快速获取地区编码 `101090808`（默认景县）的实时天气数据，包括温度、天气状况、湿度等。
- **语音播报支持**  
  通过系统 TTS（Text-To-Speech）自动朗读天气信息，支持无障碍操作。
- **极简交互设计**  
  单一窗体界面，无复杂依赖项，开箱即用。

---

## 📥 安装与配置

### 环境要求

- **.NET Framework**: 4.7.2 或更高版本
- **.NET Core**: 3.1 或更高版本
- **操作系统**: Windows（需启用 Windows 窗体应用支持）

### 快速开始

1. **克隆项目**  
   ```bash
   git clone https://github.com/Peideming/ClassWeather.git
   ```

2. **修改配置**

   - **设置 API 密钥**  
     打开 `Form1.cs` 文件，定位到第 21 行左右，替换天气 API 密钥：
     ```csharp
     private const string ApiKey = "XXXXXXXX"; // 替换为实际天气 API 密钥
     ```

   - **修改地区编码**  
     打开 `Form1.cs` 文件，定位到第 30 行左右，修改或设置地区编码：
     ```csharp
     string locationCode = "101090808"; // 可改为用户输入或其他方式获取
     ```

3. **安装依赖项**  
   在项目目录下运行以下命令安装 Newtonsoft.Json 和 System.Speech 包：
   ```bash
   dotnet add package Newtonsoft.Json
   dotnet add package System.Speech
   ```

4. **编译运行**  
   在项目目录下运行以下命令进行编译和运行：
   ```bash
   dotnet build
   dotnet run
   ```

### 🎯 使用示例

```csharp
// Form1.cs 核心逻辑示例
private void GetWeather_Click(object sender, EventArgs e)
{
    var weatherData = FetchWeather(locationCode);
    
    // 弹窗显示天气
    MessageBox.Show(
        $"当前天气：{weatherData.Condition}\n温度：{weatherData.Temp}℃",
        "景县天气",
        MessageBoxButtons.OK
    );

    // 语音播报
    new SpeechSynthesizer().Speak($"当前温度 {weatherData.Temp} 摄氏度");
}
```

### ⚠️ 注意事项

- **地区限制**  
  当前版本仅支持通过修改代码设置地区编码。
- **API 密钥**  
  需自行申请天气 API 服务并替换密钥。
- **语音兼容性**  
  依赖系统 TTS 引擎，Windows 需启用语音功能。
- **开源协议**  
  本项目采用 GNU 通用公共许可证（GNU General Public License）v3.0，禁止闭源商用。

### 🔧 技术架构

- **数据获取**  
  使用 `HttpClient` 进行数据请求，使用 `Newtonsoft.Json` 进行 JSON 解析。
- **用户界面**  
  使用 `System.Windows.Forms` 构建 Windows 窗体应用。
- **语音播报**  
  使用 `System.Speech.Synthesis` 进行语音合成和播报。
- **配置文件**  
  当前版本硬编码在代码中，建议后续版本迁移到配置文件。

### 📜 开源协议

本项目采用 GNU General Public License v3.0。详细条款请查看 `LICENSE` 文件。

### 📧 开发者与问题反馈

- **开发者**: Peideming
- **问题反馈**: 
  - 邮箱: peideming132@163.com
  - GitHub Issue: 提交问题到项目仓库的 Issues 页面
