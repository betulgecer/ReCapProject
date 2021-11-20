using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReCapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            //Biz 8*8 lik 64 butonlu bir demo tahtası yapmak istiyoruz.Aşağıdaki classı for döngüsüne alıp yazdırırsak 64 tane buton olur ama aynı yerde aynı işi yapar.
            //Aynı işlemden farklı nesneler oluşturup onları kontrol altında tutmak istiyorsak array yaparız.
            Button buttons = new Button();
            button.Width = 50;
            button.Height = 50;
            this.Controls.Add(button);  //butonu ekrana koy.
            */
            Button[,] buttons = new Button[8,8];
            // top ve left diye iki değişken tanımladık butonları yanyana aralıklı yazdırabilelim diye
            int top = 0;
            int left = 0;
            //getupperbounddaki sıfır 1.eleman demek yani satırlar için 
            //getupperbounddaki bir 2.eleman demek sütunlar 7 ye kadar sayıcaklar demek
            //satır için for içindeki for sütun için
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    //ilk buton bizim için yeni bir butondur.2. butonda bizim için yeni bir butondur her seferinde newlememiz gerek.
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top; 
                    left += 50; //başlangıç noktamızı 0 verdik.0 dan 50 karakter kadar boşluk olsun demek istiyoruz.
                    //ilk satırdaki 8 buton için top sıfır yukarıdan yüksekliği olmasın dedik ilk forda değer veremedik o yüzden
                    //demonun renkleri biri siyah biri beyaz olsun 1.buton siyahken altındaki ve yanındaki beyaz olsun
                    if((i+j ) %2 == 0 )
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }

                    
                    this.Controls.Add(buttons[i,j]);
                }
                left = 0; // döngü bitince lefti sıfırlamamız lazım 2.satıra geçtiğinde sola başlangıç noktaasına geçsin
                top += 50; //yukarıdan 50 karakter boşluk oluşsun

            }
       

        }
    }
}
