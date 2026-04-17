using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System.Configuration;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace ASCENTRA
{
    public partial class chatform : MetroFramework.Forms.MetroForm
    {
        private static readonly string apiKey =
            ConfigurationManager.AppSettings["GeminiKey"];
        public chatform()
        {
            InitializeComponent();
        }

        private  void chatform_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show(apiKey == null ? "API KEY = NULL" : apiKey);
                try
                {
                    string prompt = txtPrompt.Text.Trim();
                    if (string.IsNullOrEmpty(prompt))
                        return;

                    if (string.IsNullOrEmpty(apiKey))
                    {
                        rtbChat.AppendText("Error: Gemini API key not found in App.config\n");
                        return;
                    }

                    rtbChat.AppendText("You: " + prompt + "\n");

                    using (HttpClient client = new HttpClient())
                    {
                        var requestData = new
                        {
                            contents = new[]
                            {
                            new
                            {
                                parts = new[]
                                {
                                    new { text = prompt }
                                }
                            }
                        }
                        };

                        string json = JsonConvert.SerializeObject(requestData);
                        var content = new StringContent(json, Encoding.UTF8, "application/json");

                        string url =
                          "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash:generateContent?key=" + apiKey;

                        HttpResponseMessage response = await client.PostAsync(url, content);
                        string responseString = await response.Content.ReadAsStringAsync();

                        if (!response.IsSuccessStatusCode)
                        {
                            rtbChat.AppendText("API Error: " + response.StatusCode + "\n");
                            return;
                        }

                        JObject obj = JObject.Parse(responseString);
                        var replyToken = obj["candidates"]?[0]?["content"]?["parts"]?[0]?["text"];

                        if (replyToken != null)
                        {
                            string aiReply = replyToken.ToString().Trim();
                            rtbChat.AppendText("AI: " + aiReply + "\n\n");
                        }
                        else
                        {
                            rtbChat.AppendText("Error: Invalid Gemini response format\n");
                        }
                    }

                    txtPrompt.Clear();
                }
                catch (Exception ex)
                {
                    rtbChat.AppendText("Error: " + ex.Message + "\n");
                }
            }
        }





        private void txtPrompt_TextChanged(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(txtPrompt.Text))
            {
                btnSend.Text = "➤"; // arrow icon
                btnSend.Enabled = false; // optional: disable button if empty
            }
            else
            {
                btnSend.Text = "📩"; // send icon
                btnSend.Enabled = true; // enable button
            }
        }

       

        private void txtPrompt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSend.PerformClick();
                e.Handled = true; // prevent beep
            }

        }


        
        }
    }

