using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bernabe.mattia._4j.giocoDiCarte.models;

namespace bernabe.mattia._4j.giocoDiCarte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] carte = new string[13] { "due", "tre", "quattro", "cinque", "sei", "sette", "otto", "nove", "dieci", "jack", "donna", "re", "asso"};
            foreach(string i in carte)
            {
                list_value.Items.Add(i);
                list_value2.Items.Add(i);
            }

            string[] seme = new string[4] { "cuori", "quadri", "fiori", "picche"};
            foreach (string i in seme)
            {
                list_seme1.Items.Add(i);
                list_seme2.Items.Add(i);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_gioca_Click(object sender, EventArgs e)
        {
            string selezione;
            string seme;
            int valore = controlloValore(selezione = list_value.GetItemText(list_value.SelectedItem));
            seme = list_seme1.GetItemText(list_seme1.SelectedItem);
            Carta carta1 = new Carta(valore, seme);

            valore = controlloValore(selezione = list_value2.GetItemText(list_value2.SelectedItem));
            seme = list_seme2.GetItemText(list_seme2.SelectedItem);
            Carta carta2 = new Carta(valore, seme);
            Out1.Text = (carta1.visualizza());
            Out2.Text = (carta2.visualizza());

            bool ris = carta1.vince(carta2);
            if (ris)
                risultato.Text = ("La prima carta è maggiore della seconda");
            else
                risultato.Text = ("La seconda carta è maggiore della prima");
        }
        public int controlloValore(string value)
        {
            switch (value)
            {
                case "due":
                    return 2;
                case "tre":
                    return 3;
                case "quattro":
                    return 4;
                case "cinque":
                    return 5;
                case "sei":
                    return 6;
                case "sette":
                    return 7;
                case "otto":
                    return 8;
                case "nove":
                    return 9;
                case "dieci":
                    return 10;
                case "jack":
                    return 11;
                case "donna":
                    return 12;
                case "re":
                    return 13;
                case "asso":
                    return 14;
            }
            return 0;
        }
    }
}
