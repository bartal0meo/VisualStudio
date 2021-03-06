﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace botstrony
{

    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            //  webBrowser1.Navigate("http://www.najpewniej.pl/dodaj.php?kat=764");
            // Od pictureBox2 do pictureBox18 - zielone 
            //Od 19 do 35 czerwone 
            //  pictureBox23.Visible = true;     

        }

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Start();
            tresc_textbox.MaxLength = 10000;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox[] boxes = { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox25, pictureBox26, pictureBox27, pictureBox28, pictureBox29, pictureBox30, pictureBox31, pictureBox32, pictureBox33};

                for (int i = 0; i < boxes.Length; i++)
                {
                    boxes[i].Visible = false;
                }

                if (CheckForInternetConnection() == false)
                {
                    MessageBox.Show("Brak połączenia z internetem", "Błąd");
                }
                if (CheckForText() > 0)
                {
                    int count = CheckForText();
                    MessageBox.Show("Uzupełnij brakujące pola. Pozostało: " + count, "Puste pole");
                }
                if (CheckBox() == false)
                {
                    MessageBox.Show("Wybierz stronę", "Nie wybrano stron");
                }


                if (CheckForInternetConnection() == true && CheckForText() == 0 && CheckBox() == true)
                {
                    if (mylomza_checkBox.Checked)
                    {
                        mylomza();
                    }

                    if (fourlomza_checkBox.Checked)
                    {
                        if (tresc_textbox.TextLength > 160)
                        {
                            MessageBox.Show("Ogłoszenie powyżej 160 znaków nie zostanie dodane na stronę: 4lomza.pl", "Ogłoszenie za długie");
                            pictureBox20.Visible = true;
                        }
                        else
                        {
                            fourlomza();

                        }
                    }
                    if (kaliszak_checkBox.Checked)
                    {
                        kaliszak();
                    }
                    if(krakusik_checkBox.Checked)
                    {
                        krakusik();
                    }
                     if (gdyniak_checkBox.Checked)
                    {
                        gdyniak();
                    }
                     if (najpewniej_checkBox.Checked)
                    {
                        najpewniej();
                    }
                     if (poznaniak_checkBox.Checked)
                    {
                        poznaniak();
                    }
                     if (wroclawiak_checkBox.Checked)
                    {
                        wroclawiak();
                    }
                     if (katowiczak_checkBox.Checked)
                    {
                        katowiczak();
                    }
                     if (bydgoszczak_checkBox.Checked)
                    {
                        bydgoszczak();
                    }
                     if (szczeciniak_checkBox.Checked)
                    {
                        szczeciniak();
                    }
                     if (gdaniak_checkBox.Checked)
                    {
                        gdaniak();
                    }
                     if (opolak_checkBox.Checked)
                    {
                        opolak();
                    }
                     if (toruniak_checkBox.Checked)
                    {
                        toruniak();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nieznany bład, skontaktuj się z Bartek&Karol Company ;)", "Fatality Error "+ ex);
            }

        }

        private void mylomza()
        {
            try
            {
                webBrowser1.Navigate("http://www.mylomza.pl/ogloszenia/dodaj2.html");
                while(webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                {
                    Application.DoEvents();
                }

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
                waitTillLoad();


                    pictureBox2.Visible = true;

                
                webBrowser1.Stop();

            }
            catch
            {
                MessageBox.Show("Dodawanie do myLomza.pl nie powiodło się.", "Niepowodzenie");

                pictureBox19.Visible = true;
            }
        }

        private void fourlomza()
        {
            try
            {
                webBrowser1.Navigate("https://www.4lomza.pl/ogl2.php?mod=new");
                while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                {
                    Application.DoEvents();
                }


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
                while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                {
                    Application.DoEvents();
                }

                    pictureBox3.Visible = true;


               
                webBrowser1.Stop();

            }
            catch
            {
                MessageBox.Show("Dodawanie do 4lomza.pl nie powiodło się.", "Niepowodzenie");
                pictureBox20.Visible = true;
            }
        }

        private void kaliszak()
        {
            try
            {
                webBrowser1.Navigate("http://www.kaliszak.pl/dodaj-ogloszenie/formularz");

                waitTillLoad();

                HtmlElementCollection ele = webBrowser1.Document.All;
                foreach (HtmlElement el in ele)
                {
                    if (el.InnerText == "Dam pracę")
                    {
                        el.InvokeMember("onClick");
                    }

                }

                waitTillLoad();

                webBrowser1.Document.GetElementById("announcement_title").SetAttribute("value", name_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_description").SetAttribute("value", tresc_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_phone_number").SetAttribute("value", phone_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_email").SetAttribute("value", email_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_place").SetAttribute("value", city_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_quarter_estate").SetAttribute("value", "Winogrady");
                webBrowser1.Document.GetElementById("announcement_attribute_109_Praca-za-granica").InvokeMember("click");
                webBrowser1.Document.GetElementById("announcement_rules_accept").InvokeMember("click");

                HtmlElementCollection elc = this.webBrowser1.Document.GetElementsByTagName("input");
                foreach (HtmlElement el in elc)
                {
                    if (el.GetAttribute("type").Equals("submit"))
                    {
                        el.InvokeMember("click");
                    }
                }

                    pictureBox4.Visible = true;

            }
            catch
            {
                MessageBox.Show("Dodawanie do kaliszak.pl nie powiodło się.", "Niepowodzenie");
                pictureBox21.Visible = true;
            }
        }

        private void krakusik()
        {
            try
            {
                webBrowser1.Navigate("http://www.krakusik.pl/dodaj-ogloszenie/formularz");

                waitTillLoad();

                HtmlElementCollection ele = webBrowser1.Document.All;
                foreach (HtmlElement el in ele)
                {
                    if (el.InnerText == "Praca za granicą")
                    {
                        el.InvokeMember("onClick");
                    }

                }

                waitTillLoad();

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

                    pictureBox5.Visible = true;

                    
                

            }
            catch
            {
                MessageBox.Show("Dodawanie do krakusik.pl nie powiodło się.", "Niepowodzenie");
                pictureBox22.Visible = true;
            }
        }

        private void gdyniak()
        {
            try
            {
                webBrowser1.Navigate("http://www.gdyniak.pl/dodaj-ogloszenie/formularz");

                waitTillLoad();

                HtmlElementCollection ele = webBrowser1.Document.All;
                foreach (HtmlElement el in ele)
                {
                    if (el.InnerText == "Dam pracę")
                    {
                        el.InvokeMember("onClick");
                    }

                }

                waitTillLoad();

                webBrowser1.Document.GetElementById("announcement_title").SetAttribute("value", name_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_description").SetAttribute("value", tresc_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_phone_number").SetAttribute("value", phone_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_email").SetAttribute("value", email_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_place").SetAttribute("value", city_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_quarter_estate").SetAttribute("value", "Winogrady");
                webBrowser1.Document.GetElementById("announcement_attribute_109_Praca-za-granica").InvokeMember("click");
                webBrowser1.Document.GetElementById("announcement_rules_accept").InvokeMember("click");

                HtmlElementCollection elc = this.webBrowser1.Document.GetElementsByTagName("input");
                foreach (HtmlElement el in elc)
                {
                    if (el.GetAttribute("type").Equals("submit"))
                    {
                        el.InvokeMember("click");
                    }
                }


                    pictureBox6.Visible = true;
            }
            catch
            {
                MessageBox.Show("Dodawanie do gdyniak.pl nie powiodło się.", "Niepowodzenie");
                pictureBox23.Visible = true;
            }
        }

        private void najpewniej()
        {
            try
            {
                webBrowser1.Navigate("http://www.najpewniej.pl/dodaj.php?kat=764");

                waitTillLoad();

                HtmlElementCollection el = webBrowser1.Document.GetElementsByTagName("input");
                foreach (HtmlElement ele in el)
                {
                    if (ele.GetAttribute("name").Equals("tytul"))
                    {
                        ele.SetAttribute("value", workstation_textBox.Text);
                    }

                    if (ele.GetAttribute("name").Equals("miasto"))
                    {
                        ele.SetAttribute("value", city_textbox.Text);
                    }

                    if (ele.GetAttribute("name").Equals("telk"))
                    {
                        ele.SetAttribute("value", phone_textbox.Text);
                    }

                    if (ele.GetAttribute("name").Equals("email"))
                    {
                        ele.SetAttribute("value", email_textbox.Text);
                    }
                }

                HtmlElementCollection elm = webBrowser1.Document.GetElementsByTagName("select");
                foreach (HtmlElement elem in elm)
                {
                    if (elem.GetAttribute("name").Equals("wojewodztwo"))
                    {
                        elem.SetAttribute("value", "18");
                    }
                }

                HtmlElementCollection element = webBrowser1.Document.GetElementsByTagName("textarea");
                foreach (HtmlElement elems in element)
                {
                    if (elems.GetAttribute("name").Equals("tresc"))
                    {
                        elems.SetAttribute("value", tresc_textbox.Text);
                    }
                }

                HtmlElementCollection elmo = webBrowser1.Document.GetElementsByTagName("submit");
                foreach (HtmlElement elmon in elmo)
                {
                    if (elmon.GetAttribute("name").Equals("dodaj"))
                    {
                        elmon.InvokeMember("click");
                    }
                }
                pictureBox8.Visible = true;

            }
            catch
            {
                MessageBox.Show("Dodawanie do najpewniej.pl nie powiodło się.", "Niepowodzenie");
                pictureBox25.Visible = true;
            }
        }
        private void poznaniak()
        {
            try
            {
                webBrowser1.Navigate("http://www.poznaniak.pl/dodaj-ogloszenie/formularz");

                while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                {
                    Application.DoEvents();
                }

                HtmlElementCollection ele = webBrowser1.Document.All;
                foreach (HtmlElement el in ele)
                {
                    if (el.InnerText == "Praca za granicą")
                    {
                        el.InvokeMember("onClick");
                    }

                }

                waitTillLoad();

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

                pictureBox9.Visible = true;

                   // pictureBox26.Visible = true;
                

            }
            catch
            {
                MessageBox.Show("Dodawanie do poznaniak.pl nie powiodło się.", "Niepowodzenie");
                pictureBox26.Visible = true;
            }
        }

        private void wroclawiak()
        {
            try
            {
                webBrowser1.Navigate("http://www.wroclawiak.pl/dodaj-ogloszenie/formularz");
                while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                {
                    Application.DoEvents();
                }
                

                HtmlElementCollection ele = webBrowser1.Document.All;
                foreach (HtmlElement el in ele)
                {
                    if (el.InnerText == "Praca za granicą")
                    {
                        el.InvokeMember("onClick");
                    }

                }

                waitTillLoad();

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
                    pictureBox10.Visible = true;

                webBrowser1.Stop();

            }
            catch
            {
                MessageBox.Show("Dodawanie do wroclawiak.pl nie powiodło się.", "Niepowodzenie");
                pictureBox27.Visible = true;
            }
        }

        private void katowiczak()
        {
            try
            {
                webBrowser1.Navigate("http://www.katowiczak.pl/dodaj-ogloszenie/formularz");

                waitTillLoad();

                HtmlElementCollection ele = webBrowser1.Document.All;
                foreach (HtmlElement el in ele)
                {
                    if (el.InnerText == "Praca za granicą")
                    {
                        el.InvokeMember("onClick");
                    }

                }

                waitTillLoad();

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

                    pictureBox11.Visible = true;




                webBrowser1.Stop();

            }
            catch
            {
                MessageBox.Show("Dodawanie do katowiczak.pl nie powiodło się.", "Niepowodzenie");
                pictureBox28.Visible = true;
            }
        }

        private void bydgoszczak()
        {
            try
            {
                webBrowser1.Navigate("http://www.bydgoszczak.pl/dodaj-ogloszenie/formularz");

                waitTillLoad();

                HtmlElementCollection ele = webBrowser1.Document.All;
                foreach (HtmlElement el in ele)
                {
                    if (el.InnerText == "Praca za granicą")
                    {
                        el.InvokeMember("onClick");
                    }

                }

                waitTillLoad();

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

                    pictureBox12.Visible = true;


               
                webBrowser1.Stop();

            }
            catch
            {
                MessageBox.Show("Dodawanie do bydgoszczak.pl nie powiodło się.", "Niepowodzenie");
                pictureBox29.Visible = true;
            }
        }

        private void szczeciniak()
        {
            try
            {
                webBrowser1.Navigate("http://www.szczeciniak.pl/dodaj-ogloszenie/formularz");

                waitTillLoad();

                HtmlElementCollection ele = webBrowser1.Document.All;
                foreach (HtmlElement el in ele)
                {
                    if (el.InnerText == "Praca za granicą")
                    {
                        el.InvokeMember("onClick");
                    }

                }

                waitTillLoad();

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

                    pictureBox13.Visible = true;


            }
            catch
            {
                MessageBox.Show("Dodawanie do szczeciniak.pl nie powiodło się.", "Niepowodzenie");
                pictureBox30.Visible = true;
            }
        }
        private void gdaniak()
        {
            try
            {
                webBrowser1.Navigate("http://www.gdanszczak.pl/dodaj-ogloszenie/formularz");

                waitTillLoad();

                HtmlElementCollection ele = webBrowser1.Document.All;
                foreach (HtmlElement el in ele)
                {
                    if (el.InnerText == "Praca za granicą")
                    {
                        el.InvokeMember("onClick");
                    }
                }

                waitTillLoad();

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

                    pictureBox14.Visible = true;

            }
            catch
            {
                MessageBox.Show("Dodawanie do gdaniak.pl nie powiodło się.", "Niepowodzenie");
                pictureBox31.Visible = true;
            }
        }
        private void opolak()
        {
            try
            {
                webBrowser1.Navigate("http://www.opolak.pl/dodaj-ogloszenie/formularz");

                waitTillLoad();

                HtmlElementCollection ele = webBrowser1.Document.All;
                foreach (HtmlElement el in ele)
                {
                    if (el.InnerText == "Dam pracę")
                    {
                        el.InvokeMember("onClick");
                    }

                }

                waitTillLoad();

                webBrowser1.Document.GetElementById("announcement_title").SetAttribute("value", name_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_description").SetAttribute("value", tresc_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_phone_number").SetAttribute("value", phone_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_email").SetAttribute("value", email_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_place").SetAttribute("value", city_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_quarter_estate").SetAttribute("value", "Winogrady");
                webBrowser1.Document.GetElementById("announcement_attribute_109_Praca-za-granica").InvokeMember("click");
                webBrowser1.Document.GetElementById("announcement_rules_accept").InvokeMember("click");

                HtmlElementCollection elc = this.webBrowser1.Document.GetElementsByTagName("input");
                foreach (HtmlElement el in elc)
                {
                    if (el.GetAttribute("type").Equals("submit"))
                    {
                        el.InvokeMember("click");
                    }
                }
                    pictureBox15.Visible = true;


                

            }
            catch
            {
                MessageBox.Show("Dodawanie do opolak.pl nie powiodło się.", "Niepowodzenie");
                            pictureBox32.Visible = true;
            }
        }

        private void toruniak()
        {
            try
            {
                webBrowser1.Navigate("http://www.toruniak.pl/dodaj-ogloszenie/formularz");

                waitTillLoad();

                HtmlElementCollection ele = webBrowser1.Document.All;
                foreach (HtmlElement el in ele)
                {
                    if (el.InnerText == "Oferty pracy")
                    {
                        el.InvokeMember("onClick");
                    }

                }

                waitTillLoad();

                webBrowser1.Document.GetElementById("announcement_title").SetAttribute("value", name_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_description").SetAttribute("value", tresc_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_phone_number").SetAttribute("value", phone_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_email").SetAttribute("value", email_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_place").SetAttribute("value", city_textbox.Text);
                webBrowser1.Document.GetElementById("announcement_quarter_estate").SetAttribute("value", "Winogrady");
                webBrowser1.Document.GetElementById("announcement_attribute_109_Praca-za-granica").InvokeMember("click");
                webBrowser1.Document.GetElementById("announcement_rules_accept").InvokeMember("click");

                HtmlElementCollection elc = this.webBrowser1.Document.GetElementsByTagName("input");
                foreach (HtmlElement el in elc)
                {
                    if (el.GetAttribute("type").Equals("submit"))
                    {
                        el.InvokeMember("click");
                    }
                }

                    pictureBox16.Visible = true;


               

            }
            catch
            {
                MessageBox.Show("Dodawanie do toruniak.pl nie powiodło się.", "Niepowodzenie");
                pictureBox33.Visible = true;
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
                time_label.Text = "Pozostało znaków: " + remaind + "(Tylko 4lomza.pl)";
            }
            else
            {
                time_label.Text = "Pozostało znaków: 0";
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

        private int CheckForText(int count = 0)
        {
            foreach (Control c in this.Controls)
            {

                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        count++;
                    }
                }
            }

            if (tresc_textbox.Text == string.Empty)
            {
                count++;
            }

            return count;
        }

        public bool CheckBox()
        {
            bool check = false;
            foreach (var control in this.Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked)
                    {
                        check = true;
                    }
                }
            }

            if (check == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void zaznaczWszystkie_Click(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked)
                    {
                        ((CheckBox)control).Checked = false;
                    }
                    else
                    {
                        ((CheckBox)control).Checked = true;
                    }
                }
            }
        }

        private void fourlomza_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fourlomza_checkBox.Checked)
            {
                if (tresc_textbox.TextLength >= 161)
                {
                    MessageBox.Show("Na www.4lomza.pl maksymalnie 160 znaków !", "Błąd");
                    pictureBox20.Visible = true;


                }
               
            }
          
            
        }

        private void waitTillLoad()
        {
            WebBrowserReadyState loadStatus = default(WebBrowserReadyState);
            int waittime = 100000;
            int counter = 0;
            while (true)
            {
                loadStatus = webBrowser1.ReadyState;
                Application.DoEvents();

                if ((counter > waittime) || (loadStatus == WebBrowserReadyState.Uninitialized) || (loadStatus == WebBrowserReadyState.Loading) || (loadStatus == WebBrowserReadyState.Interactive))
                {
                    break; // TODO: might not be correct. Was : Exit While
                }
                counter += 1;
            }
            counter = 0;
            while (true)
            {
                loadStatus = webBrowser1.ReadyState;
                Application.DoEvents();

                if (loadStatus == WebBrowserReadyState.Complete)
                {
                    break; // TODO: might not be correct. Was : Exit While
                }

                counter += 1;
            }
            //Stworzone przez Bartek&Karol
            //Kontakt: bartal0meoo@gmail.com
        }

    }
}
