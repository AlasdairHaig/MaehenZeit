using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MähenZeit
{
    public partial class MähenZeit : Form
    {

        public class globaleVariablen
        {
            public static int hauslänge = 0;
            public static int hausBreit = 0;
            public static int hausBlockLänge = 0;
            public static int hausBlockBreit = 0;
            public static int rate = 0;
        }
        
        public MähenZeit()
        {
            InitializeComponent();
        }

        private void MähenZeit_Load(object sender, EventArgs e)
      {

      }

        private void hausLängeFeld_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void erreichenTaste_Click(object sender, EventArgs e)
        {
            globaleVariablen.hauslänge = Convert.ToInt32(hausLängeFeld.Text);
            globaleVariablen.hausBreit = Convert.ToInt32(hausBreitFeld.Text);
            globaleVariablen.hausBlockLänge = Convert.ToInt32(HausBlkLängeFeld.Text);
            globaleVariablen.hausBlockBreit = Convert.ToInt32(HausBlkBreitFeld.Text);
            globaleVariablen.rate = Convert.ToInt32(rate.Text);

            erreichen();
        }
    

      public void erreichen() {

          int minuteDauert = 0;
          int stundeDauert = 0;
          int hausOberfläche = globaleVariablen.hauslänge * globaleVariablen.hausBreit;
          int hausBlockOberfläche = globaleVariablen.hausBlockLänge * globaleVariablen.hausBlockBreit;

          int differenz = hausBlockOberfläche - hausOberfläche;
          // Oberfläche dividiert pro Geschwinigkeit
          int zeit = differenz / globaleVariablen.rate;
          if (zeit > 60)
          {
              stundeDauert = zeit / 60;
              minuteDauert = zeit % 60;
              Antwort.Text = "Das Mähen wird " + stundeDauert + " Stunde und " + minuteDauert + " Minute dauert";
          }
          else
          {
              Antwort.Text = "Das Mähen wird " + zeit + " Minute dauert";
          }
      }
    }
}
