using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botstrony
{

    public partial class Form1 : Form
    {

        private void Form1_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://bazaro.com.pl/?view=post&catid=5&subcatid=49");
        }

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (CheckForInternetConnection() == true && CheckForText() == true)
            {
                    if (mylomza_checkBox.Checked)
                    {
                        mylomza();
                    }
                    else if (fourlomza_checkBox.Checked)
                    {
                        fourlomza();
                    }
                    else if (kaliszak_checkBox.Checked)
                    {
                        kaliszak();
                    }
                    else if (krakusik_checkBox.Checked)
                    {
                        krakusik();
                    }
                    else if (gdyniak_checkBox.Checked)
                    {
                        gdyniak();
                    }
                    else if (bazaro_checkBox.Checked)
                    {
                        bazaro();
                    }
                    //jumla tez odpada bo obrazek
                    //epracazagranica.pl - trzeba sie zastanowic nad tym
            }
            else if (CheckForInternetConnection() == false)
            {
                MessageBox.Show("Błąd","Brak połączenia z internetem");
            }

        }

        private void mylomza()
        {

            webBrowser1.Document.GetElementById("contact").SetAttribute("value", phone_textbox.Text);
            webBrowser1.Document.GetElementById("cat_id").SetAttribute("value", "6");

            HtmlElementCollection elc = this.webBrowser1.Document.GetElementsByTagName("textarea");
            foreach (HtmlElement el in elc)
            {
                if (el.GetAttribute("name").Equals("description"))
                {
                    el.SetAttribute("value", tresc_textbox.Text);
                }
            }

            HtmlElementCollection wcisk = this.webBrowser1.Document.GetElementsByTagName("button");
            foreach (HtmlElement el in wcisk)
            {
               if (el.GetAttribute("type").Equals("button"))
                {
                    el.InvokeMember("click");
                }
            }
        }

        private void fourlomza()
        {
            webBrowser1.Navigate("https://www.4lomza.pl/ogl2.php?mod=new");
            webBrowser1.Document.GetElementById("form_email").InnerText = email_textbox.Text;
            webBrowser1.Document.GetElementById("form_nazwa").InnerText = name_textbox.Text;
            webBrowser1.Document.GetElementById("form_tel").InnerText = phone_textbox.Text;
            webBrowser1.Document.GetElementById("form_kat").SetAttribute("value", "4");
            webBrowser1.Document.GetElementById("form_tresc").InnerText = tresc_textbox.Text;


            HtmlElementCollection elc = this.webBrowser1.Document.GetElementsByTagName("input");
            foreach (HtmlElement el in elc)
            {
                if (el.GetAttribute("type").Equals("submit"))
                {
                    el.InvokeMember("click");
                }
            }

        }

        private void bazaro()
        {
            //webBrowser1.Navigate("https://bazaro.com.pl/?view=post&catid=5&subcatid=49");

            HtmlElementCollection ele = webBrowser1.Document.GetElementsByTagName("select");
            foreach (HtmlElement el in ele)
            {
                if (el.GetAttribute("name").Equals("district"))
                {
                    el.SetAttribute("value", "15");
                }
            }
            
            webBrowser1.Document.GetElementById("email").SetAttribute("value", email_textbox.Text);
            webBrowser1.Document.GetElementById("adtitle").SetAttribute("value", name_textbox.Text);
            webBrowser1.Document.GetElementById("addesc").SetAttribute("value", tresc_textbox.Text);
            webBrowser1.Document.GetElementById("price").SetAttribute("value", "123");
            webBrowser1.Document.GetElementById("x[1]").SetAttribute("value", phone_textbox.Text);

            HtmlElementCollection elem = webBrowser1.Document.GetElementsByTagName("input");
            foreach (HtmlElement eles in elem)
            {
                if (eles.GetAttribute("name").Equals("agree"))
                {
                    eles.InvokeMember("click");
                }
            }
           
            HtmlElementCollection element = webBrowser1.Document.GetElementsByTagName("button");
            foreach (HtmlElement elems in element)
            {
                if (elems.GetAttribute("class").Equals("btn btn-default btn-sm"))
                {
                    elems.InvokeMember("click");
                }
            }  
        }

        private async void kaliszak()
        {
            //webBrowser1.Navigate("http://www.kaliszak.pl/dodaj-ogloszenie/formularz");

            HtmlElementCollection ele = webBrowser1.Document.All;
            foreach (HtmlElement el in ele)
            {
                if (el.InnerText == "Dam pracę")
                {
                    el.InvokeMember("onClick");
                }

            }

            await PageLoad(5);
            
            webBrowser1.Document.GetElementById("announcement_title").SetAttribute("value", name_textbox.Text);
            webBrowser1.Document.GetElementById("announcement_description").SetAttribute("value", tresc_textbox.Text);
            webBrowser1.Document.GetElementById("announcement_phone_number").SetAttribute("value", phone_textbox.Text);
            webBrowser1.Document.GetElementById("announcement_email").SetAttribute("value", email_textbox.Text);
            webBrowser1.Document.GetElementById("announcement_place").SetAttribute("value", place_textbox.Text);
            webBrowser1.Document.GetElementById("announcement_attribute_109_Praca-za-granica").InvokeMember("click");
            webBrowser1.Document.GetElementById("announcement_rules_accept").InvokeMember("click");
            //webBrowser1.Document.GetElementById("announcement_marketing_consent").InvokeMember("click");

            HtmlElementCollection elc = this.webBrowser1.Document.GetElementsByTagName("input");
            foreach (HtmlElement el in elc)
            {
                if (el.GetAttribute("type").Equals("submit"))
                {
                    el.InvokeMember("click");
                }
            }
        }

        private async void krakusik()
        {
            //webBrowser1.Navigate("http://www.krakusik.pl/dodaj-ogloszenie/formularz");

            HtmlElementCollection ele = webBrowser1.Document.All;
            foreach (HtmlElement el in ele)
            {
                if (el.InnerText == "Praca za granicą")
                {
                    el.InvokeMember("onClick");
                }

            }
            
            await PageLoad(5);

            webBrowser1.Document.GetElementById("announcement_title").SetAttribute("value", name_textbox.Text);
            webBrowser1.Document.GetElementById("announcement_description").SetAttribute("value", tresc_textbox.Text);
            webBrowser1.Document.GetElementById("announcement_phone_number").SetAttribute("value", phone_textbox.Text);
            webBrowser1.Document.GetElementById("announcement_email").SetAttribute("value", email_textbox.Text);
            webBrowser1.Document.GetElementById("announcement_rules_accept").InvokeMember("click");

            HtmlElementCollection elc = this.webBrowser1.Document.GetElementsByTagName("input");
            foreach (HtmlElement el in elc)
            {
                if (el.GetAttribute("type").Equals("submit"))
                {
                    el.InvokeMember("click");
                }
            }
            
        }

        private async void gdyniak()
        {
            webBrowser1.Navigate("http://www.gdyniak.pl/dodaj-ogloszenie/formularz");

            HtmlElementCollection ele = webBrowser1.Document.All;
            foreach (HtmlElement el in ele)
            {
                if (el.InnerText == "Dam pracę")
                {
                    el.InvokeMember("onClick");
                }

            }
            
            await PageLoad(5);

            webBrowser1.Document.GetElementById("announcement_title").SetAttribute("value", name_textbox.Text);
            webBrowser1.Document.GetElementById("announcement_description").SetAttribute("value", tresc_textbox.Text);
            webBrowser1.Document.GetElementById("announcement_phone_number").SetAttribute("value", phone_textbox.Text);
            webBrowser1.Document.GetElementById("announcement_email").SetAttribute("value", email_textbox.Text);
            webBrowser1.Document.GetElementById("announcement_place").SetAttribute("value", place_textbox.Text);
            webBrowser1.Document.GetElementById("announcement_attribute_109_Praca-za-granica").InvokeMember("click");
            webBrowser1.Document.GetElementById("announcement_rules_accept").InvokeMember("click");
            //webBrowser1.Document.GetElementById("announcement_marketing_consent").InvokeMember("click");

            HtmlElementCollection elc = this.webBrowser1.Document.GetElementsByTagName("input");
            foreach (HtmlElement el in elc)
            {
                if (el.GetAttribute("type").Equals("submit"))
                {
                    el.InvokeMember("click");
                }
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int length = tresc_textbox.TextLength;

            if (length == 0)
            {
                time_label.Text = "";
            }
            else if (length < 160)
            {
                int remaind = 160 - length;
                time_label.Text = "Pozostało znaków: " + remaind;
            }
            else
            {
                time_label.Text = "Pozostało znaków: 0";
            }
        }

        private void mylomza_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mylomza_checkBox.Checked)
            {
                webBrowser1.Navigate("http://mylomza.pl/ogloszenia/dodaj2.html");
            }
            else
            {
                webBrowser1.Navigate("");
            }
        }

        private void fourlomza_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fourlomza_checkBox.Checked)
            {
                webBrowser1.Navigate("https://www.4lomza.pl/ogl2.php?mod=new");
            }
            else
            {
                webBrowser1.Navigate("");
            }
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool CheckForText() 
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox textBox = c as TextBox;
                        if (textBox.Text != string.Empty)
                        {
                            return true;
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private async Task PageLoad(int TimeOut)
        {
            TaskCompletionSource<bool> PageLoaded = null;
            PageLoaded = new TaskCompletionSource<bool>();
            int TimeElapsed = 0;
            webBrowser1.DocumentCompleted += (s, e) =>
            {
                if (webBrowser1.ReadyState != WebBrowserReadyState.Complete) return;
                if (PageLoaded.Task.IsCompleted) return; PageLoaded.SetResult(true);
            };
            //
            while (PageLoaded.Task.Status != TaskStatus.RanToCompletion)
            {
                await Task.Delay(10);//10 ms interval
                TimeElapsed++;
                if (TimeElapsed >= TimeOut * 100) PageLoaded.TrySetResult(true);
            }
        }

    }
}
