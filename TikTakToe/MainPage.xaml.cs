using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TikTakToe
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Player1 = true;
            Player2 = false;
        }
        List<int> list_player1 = new List<int>();
        List<int> list_player2 = new List<int>();
        public int[,] opciones = new int[8, 3] { { 1, 2, 3 }, { 1, 4, 7 }, { 1, 5, 9 }, { 4, 5, 6 }, { 2, 5, 8 }, { 7, 8, 9 }, { 3,6,9}, { 3, 5, 7} };
        public bool Player1 { get; set; }
        public bool Player2 { get; set; }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            if (Player1)
            {
                btn1.Text = "X";
                list_player1.Add(1);
                Player1 = false;
                Player2 = true;
                Ganar(list_player1, opciones);
            }
            else
            {
                btn1.Text = "0";
                list_player2.Add(1);
                Player2 = false;
                Player1 = true;
                Ganar(list_player2, opciones);
            }
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            if (Player1)
            {
                btn2.Text = "X";
                list_player1.Add(2);
                Player1 = false;
                Player2 = true;
                Ganar(list_player1, opciones);
            }
            else
            {
                btn2.Text = "0";
                list_player2.Add(2);
                Player2 = false;
                Player1 = true;
                Ganar(list_player2, opciones);
            }
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            if (Player1)
            {
                btn3.Text = "X";
                list_player1.Add(3);
                Player1 = false;
                Player2 = true;
                Ganar(list_player1, opciones);
            }
            else
            {
                btn3.Text = "0";
                list_player2.Add(3);
                Player2 = false;
                Player1 = true;
                Ganar(list_player2, opciones);
            }
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            if (Player1)
            {
                btn4.Text = "X";
                list_player1.Add(4);
                Player1 = false;
                Player2 = true;
                Ganar(list_player1, opciones);
            }
            else
            {
                btn4.Text = "0";
                list_player2.Add(4);
                Player2 = false;
                Player1 = true;
                Ganar(list_player2, opciones);
            }
        }

        private void btn5_Clicked(object sender, EventArgs e)
        {
            if (Player1)
            {
                btn5.Text = "X";
                list_player1.Add(5);
                Player1 = false;
                Player2 = true;
                Ganar(list_player1, opciones);
            }
            else
            {
                btn5.Text = "0";
                list_player2.Add(5);
                Player2 = false;
                Player1 = true;
                Ganar(list_player2, opciones);
            }
        }

        private void btn6_Clicked(object sender, EventArgs e)
        {
            if (Player1)
            {
                btn6.Text = "X";
                list_player1.Add(6);
                Player1 = false;
                Player2 = true;
                Ganar(list_player1, opciones);
            }
            else
            {
                btn6.Text = "0";
                list_player2.Add(6);
                Player2 = false;
                Player1 = true;
                Ganar(list_player2, opciones);
            }
        }

        private void btn7_Clicked(object sender, EventArgs e)
        {
            if (Player1)
            {
                btn7.Text = "X";
                list_player1.Add(7);
                Player1 = false;
                Player2 = true;
                Ganar(list_player1, opciones);
            }
            else
            {
                btn7.Text = "0";
                list_player2.Add(7);
                Player2 = false;
                Player1 = true;
                Ganar(list_player2, opciones);
            }
        }

        private void btn8_Clicked(object sender, EventArgs e)
        {
            if (Player1)
            {
                btn8.Text = "X";
                list_player1.Add(8);
                Player1 = false;
                Player2 = true;
                Ganar(list_player1, opciones);
            }
            else
            {
                btn8.Text = "0";
                list_player2.Add(8);
                Player2 = false;
                Player1 = true;
                Ganar(list_player2, opciones);
            }
        }

        private void btn9_Clicked(object sender, EventArgs e)
        {
            if (Player1)
            {
                btn9.Text = "X";
                list_player1.Add(9);
                Player1 = false;
                Player2 = true;
                Ganar(list_player1, opciones);
            }
            else
            {
                btn9.Text = "0";
                list_player2.Add(9);
                Player2 = false;
                Player1 = true;
                Ganar(list_player2, opciones);
            }
        }
        private List<int> BuscarIndice(int indice)
        {
            List<int> list = new List<int>();
            for (int j = 0; j < 3; j++)
            {
                list.Add(opciones[indice, j]);
            }
            return list;
        }

        private bool ListasIguales(List<int> lista1, int[,] lista2)
        {
            bool iguales = false;
            if (lista1.Count < 3)
            {
                return false;
            }
            List<int> lista = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                lista = BuscarIndice(i);
                iguales = lista1.OrderBy(x => x).SequenceEqual(lista.OrderBy(x => x));
                if (iguales)
                {
                    break;
                }
            }
            return iguales;
        }
        private void Ganar(List<int> lista1, int[,] lista2)
        {
            if (ListasIguales(lista1,lista2))
            {
                DisplayAlert("Felicitaciones","Ganaste","Ok");
                Limpiar();
            }
        }
        private void Limpiar()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            list_player1.Clear();
            list_player2.Clear();
        }
    }
}
