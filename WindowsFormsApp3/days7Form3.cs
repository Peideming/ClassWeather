using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using MaterialSkin;

namespace WindowsFormsApp3
{
    public partial class days7Form3 : Form
    {
        private string weatherInfo;
        private const string ApiKey = "e4c745faecd5483583737106684a1786";
        private const string WeatherApiUrlTemplate = "https://devapi.qweather.com/v7/weather/7d?location={0}&key={1}";


        public days7Form3()
        {
            InitializeComponent();
        }
        private async void days7Form3_Load(object sender, EventArgs e)
        {
            string locationCode = "101090808"; // 北京的locationCode，可以改为用户输入或其他方式获取
            weatherInfo = await GetWeatherAsync(locationCode);
            lblShow.Text = weatherInfo;
            string localInfo = "河北省-衡水市-景县未来7天天气信息：\n";
            linkLabel1.Text = localInfo; // 假设你的LinkLabel名为linkLabel1
        }
        private async void speekbutton_Click(object sender, EventArgs e)
        {
            SpeakWeather(weatherInfo);
        }
        private void SpeakWeather(string weatherText)
        {
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                synthesizer.Speak(weatherText + "播报完毕");
                var voices = synthesizer.GetInstalledVoices();
                if (voices.Any(v => v.VoiceInfo.Name.Contains("Microsoft Kangkang")))
                {
                    synthesizer.SelectVoice("Microsoft Kangkang Desktop"); // 中文女声
                }
            }
        }
        private async Task<string> GetWeatherAsync(string locationCode)
        {
            using (HttpClient client = new HttpClient(new HttpClientHandler
            {
                AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate
            }))
            {
                string url = string.Format(WeatherApiUrlTemplate, locationCode, ApiKey);
                HttpResponseMessage response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    return $"HTTP请求失败: {response.StatusCode}";
                }

                if (response.Content.Headers.ContentType?.MediaType != "application/json")
                {
                    return "API返回了非JSON数据";
                }

                string responseBody = await response.Content.ReadAsStringAsync();

                try
                {
                    using (JsonDocument document = JsonDocument.Parse(responseBody))
                    {
                        if (document.RootElement.GetProperty("code").GetString() == "200")
                        {
                            var daily = document.RootElement.GetProperty("daily");
                            StringBuilder weatherText = new StringBuilder();

                            foreach (var day in daily.EnumerateArray())
                            {
                                weatherText.AppendLine($"日期: {day.GetProperty("fxDate").GetString()}");
                                weatherText.AppendLine($"日出: {day.GetProperty("sunrise").GetString()}");
                                weatherText.AppendLine($"日落: {day.GetProperty("sunset").GetString()}");
                                weatherText.AppendLine($"白天天气: {day.GetProperty("textDay").GetString()} ({day.GetProperty("iconDay").GetString()})");
                                weatherText.AppendLine($"夜间天气: {day.GetProperty("textNight").GetString()} ({day.GetProperty("iconNight").GetString()})");
                                weatherText.AppendLine($"最高温度: {day.GetProperty("tempMax").GetString()}°C");
                                weatherText.AppendLine($"最低温度: {day.GetProperty("tempMin").GetString()}°C");
                                weatherText.AppendLine($"白天风向: {day.GetProperty("windDirDay").GetString()} {day.GetProperty("windScaleDay").GetString()}级");
                                weatherText.AppendLine($"夜间风向: {day.GetProperty("windDirNight").GetString()} {day.GetProperty("windScaleNight").GetString()}级");
                                weatherText.AppendLine($"湿度: {day.GetProperty("humidity").GetString()}%");
                                weatherText.AppendLine($"能见度: {day.GetProperty("vis").GetString()}公里");
                                weatherText.AppendLine();
                            }

                            return weatherText.ToString();
                        }
                        else
                        {
                            return $"API返回错误: {document.RootElement.GetProperty("code").GetString()}";
                        }
                    }
                }
                catch (JsonException ex)
                {
                    return $"JSON解析失败: {ex.Message}";
                }
            }

        }

        private void lblShow_Click(object sender, EventArgs e)
        {

        }
    }
}
