using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Speech.Synthesis;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using MaterialSkin;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private string weatherInfo;
        private const string ApiKey = "e4c745faecd5483583737106684a1786";
        private const string WeatherApiUrlTemplate = "https://devapi.qweather.com/v7/weather/now?location={0}&key={1}";
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string locationCode = "101090808"; // 可以改为用户输入或其他方式获取
            weatherInfo = await GetWeatherAsync(locationCode);
            string info;
            info = weatherInfo;
            lblShow.Text = info;
            string localInfo;
            localInfo = "河北省-衡水市-景县天气信息：\n";
            linkTittle.Text = localInfo;
            Console.WriteLine(linkTittle.Text);
            Console.WriteLine(lblShow.Text);
            SpeakWeather(weatherInfo);
        }
        private async void speekbutton_Click(object sender, EventArgs e)
        {
            SpeakWeather(weatherInfo);
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
                            var now = document.RootElement.GetProperty("now");
                            string weatherText = $"景县天气\n当前天气：{now.GetProperty("text").GetString()}\n温度：{now.GetProperty("temp").GetString()}°C\n体感温度：{now.GetProperty("feelsLike").GetString()}°C\n风向：{now.GetProperty("windDir").GetString()} {now.GetProperty("windScale").GetString()}级\n风速：{now.GetProperty("windSpeed").GetString()}km/h\n湿度：{now.GetProperty("humidity").GetString()}%\n能见度：{now.GetProperty("vis").GetString()}公里";
                            return weatherText;
                        }
                        else
                        {
                            return $"API返回错误: {document.RootElement.GetProperty("code")}";
                        }
                    }
                }
                catch (JsonException ex)
                {
                    return $"JSON解析失败: {ex.Message}";
                }
            }
        }
        private void OpenAbout_Click(object sender, EventArgs e)
        {
            // 创建 Form2 的实例
            AboutUsForm2 form2 = new AboutUsForm2();

            // 显示 Form2
            form2.Show();
        }

        private void Open7Days_Click(object sender, EventArgs e)
        {
            // 创建 Form3 的实例
            days7Form3 form3 = new days7Form3();

            // 显示 Form3
            form3.Show();
        }

        private void SpeakWeather(string weatherText)
        {
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                synthesizer.Speak(weatherText+"播报完毕");
                var voices = synthesizer.GetInstalledVoices();
                if (voices.Any(v => v.VoiceInfo.Name.Contains("Microsoft Kangkang")))
                {
                    synthesizer.SelectVoice("Microsoft Kangkang Desktop"); // 中文女声
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblShow_Click(object sender, EventArgs e)
        {

        }
    }
}
