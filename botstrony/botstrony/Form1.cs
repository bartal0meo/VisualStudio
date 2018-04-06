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
            webBrowser1.Navigate("http://mylomza.pl/ogloszenia/dodaj2.html");
        }
        WebBrowser webBrowser = new WebBrowser();
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (CheckForInternetConnection() == true)
            {
                    if (mylomza_checkBox.Checked)
                    {
                        mylomza();
                    }
                    else if (fourlomza_checkBox.Checked)
                    {
                        fourlomza();
                    }
                    else if (checkBox_localhost.Checked)
                    {
                        localhost();
                    }
            }
            else
            {
                MessageBox.Show("Błąd","Brak połączenia z internetem");
            }

        }
        private void localhost()
        {
            webBrowser.Navigate("http://localhost/bot/rejestracja.php");
            // var f_name = webBrowser.Document.GetElementsByTagName("text")["nick"].GetAttribute("value");
            webBrowser.Document.GetElementsByTagName("text")["nick"].SetAttribute("input", name_textbox.Text);
            //var f_name1 = webBrowser.Document.GetElementsByTagName("text")["nick"].GetAttribute("value");
            webBrowser.Document.GetElementsByTagName("text")["email"].SetAttribute("input", name_textbox.Text);
            //var f_name2 = webBrowser.Document.GetElementsByTagName("text")["nick"].GetAttribute("value");
            webBrowser.Document.GetElementsByTagName("text")["tel"].SetAttribute("input", name_textbox.Text);
            //var f_name3 = webBrowser.Document.GetElementsByTagName("text")["nick"].GetAttribute("value");
            webBrowser.Document.GetElementsByTagName("text")["kat"].SetAttribute("input", name_textbox.Text);
            //  var f_name4 = webBrowser.Document.GetElementsByTagName("text")["nick"].GetAttribute("value");
            webBrowser.Document.GetElementsByTagName("text")["tresc"].SetAttribute("input", name_textbox.Text);

            webBrowser.Document.GetElementById("submit").InvokeMember("click");

        }
        private void mylomza()
        {

             //webBrowser1.Document.GetElementById("form_email").InnerText = email_textbox.Text;

            //  webBrowser1.Document.GetElementById("form_nazwa").InnerText = name_textbox.Text;

           // webBrowser1.Document.GetElementById("contact").SetAttribute("value", phone_textbox.Text);
            //webBrowser1.Document.GetElementById("cat_id").SetAttribute("value", "6");
            //webBrowser1.Document.GetElementById("description").SetAttribute("value", tresc_textbox.Text);

            //HtmlElementCollection elc = this.webBrowser1.Document.GetElementsByTagName("desciption");
            //foreach (HtmlElement el in elc)
            //{
             //   if (el.GetAttribute("name").Equals("description"))
              //  {
               //     el.SetAttr("value", tresc_textbox.Text);
               // }
            //}


            // HtmlElementCollection elc = this.webBrowser1.Document.GetElementsByTagName("input");
            // foreach (HtmlElement el in elc)
            // {
            //    if (el.GetAttribute("type").Equals("submit"))
            //    {
            //        el.InvokeMember("click");
            //    }
            // }


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

    }
}
