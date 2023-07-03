using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;

namespace TikTakToe.ViewModels
{
    public class InicioViewModel : BaseViewModel
    {
        #region VARIABLES
        private string[] _celdas = new string[9];
        private Color[] _colorCeldas = new Color[9];
        public int[,] opciones = new int[8, 3] { { 1, 2, 3 }, { 1, 4, 7 }, { 1, 5, 9 }, { 4, 5, 6 }, { 2, 5, 8 }, { 7, 8, 9 }, { 3, 6, 9 }, { 3, 5, 7 } };
        List<int> list_player1 = new List<int>();
        List<int> list_player2 = new List<int>();
        private bool _TurnPlayer1;
        private bool _TurnPlayer2;
        private string _TextTurno;
        private string _NamePlayer1;
        private string _NamePlayer2;
        public int CountPlayer1 { get; set; }
        public int CountPlayer2 { get; set; }
        #endregion
        #region CONSTRUCTOR
        public InicioViewModel(INavigation navigation)
        {
            Navigation = navigation;
            IsBusy = true;
        }
        #endregion
        #region OBJETOS
        public string Celda1
        {
            get { return _celdas[0]; }
            set
            {
                SetValue(ref _celdas[0], value);
                OnPropertyChanged(nameof(Celda1));
            }
        }
        public string Celda2
        {
            get { return _celdas[1]; }
            set
            {
                SetValue(ref _celdas[1], value);
                OnPropertyChanged();
            }
        }
        public string Celda3
        {
            get { return _celdas[2]; }
            set
            {
                SetValue(ref _celdas[2], value);
                OnPropertyChanged();
            }
        }
        public string Celda4
        {
            get { return _celdas[3]; }
            set
            {
                SetValue(ref _celdas[3], value);
                OnPropertyChanged();
            }
        }
        public string Celda5
        {
            get { return _celdas[4]; }
            set
            {
                SetValue(ref _celdas[4], value);
                OnPropertyChanged();
            }
        }
        public string Celda6
        {
            get { return _celdas[5]; }
            set
            {
                SetValue(ref _celdas[5], value);
                OnPropertyChanged();
            }
        }
        public string Celda7
        {
            get { return _celdas[6]; }
            set
            {
                SetValue(ref _celdas[6], value);
                OnPropertyChanged();
            }
        }
        public string Celda8
        {
            get { return _celdas[7]; }
            set
            {
                SetValue(ref _celdas[7], value);
                OnPropertyChanged();
            }
        }
        public string Celda9
        {
            get { return _celdas[8]; }
            set
            {
                SetValue(ref _celdas[8], value);
                OnPropertyChanged();
            }
        }
        public bool TurnPlayer1
        {
            get { return _TurnPlayer1; }
            set
            {
                SetValue(ref _TurnPlayer1, value);
                if (_TurnPlayer1)
                {
                    TextTurno = "Es el turno del jugador " + NamePlayer1 + " (O)";
                    TurnPlayer2 = false;
                }
                else
                {
                    TextTurno = "Es el turno del jugador " + NamePlayer2 + " (X)";
                }
                OnPropertyChanged();
            }
        }
        public bool TurnPlayer2
        {
            get { return _TurnPlayer2; }
            set
            {
                SetValue(ref _TurnPlayer2, value);
                if (_TurnPlayer2)
                {
                    TextTurno = "Es el turno del jugador " + NamePlayer2 + " (X)";
                    TurnPlayer1 = false;
                }
                OnPropertyChanged();
            }
        }
        public Color ColorCelda1
        {
            get { return _colorCeldas[0]; }
            set
            {
                SetValue(ref _colorCeldas[0], value);
                OnPropertyChanged();
            }
        }
        public Color ColorCelda2
        {
            get { return _colorCeldas[1]; }
            set
            {
                SetValue(ref _colorCeldas[1], value);
                OnPropertyChanged();
            }
        }
        public Color ColorCelda3
        {
            get { return _colorCeldas[2]; }
            set
            {
                SetValue(ref _colorCeldas[2], value);
                OnPropertyChanged();
            }
        }
        public Color ColorCelda4
        {
            get { return _colorCeldas[3]; }
            set
            {
                SetValue(ref _colorCeldas[3], value);
                OnPropertyChanged();
            }
        }
        public Color ColorCelda5
        {
            get { return _colorCeldas[4]; }
            set
            {
                SetValue(ref _colorCeldas[4], value);
                OnPropertyChanged();
            }
        }
        public Color ColorCelda6
        {
            get { return _colorCeldas[5]; }
            set
            {
                SetValue(ref _colorCeldas[5], value);
                OnPropertyChanged();
            }
        }
        public Color ColorCelda7
        {
            get { return _colorCeldas[6]; }
            set
            {
                SetValue(ref _colorCeldas[6], value);
                OnPropertyChanged();
            }
        }
        public Color ColorCelda8
        {
            get { return _colorCeldas[7]; }
            set
            {
                SetValue(ref _colorCeldas[7], value);
                OnPropertyChanged();
            }
        }
        public Color ColorCelda9
        {
            get { return _colorCeldas[8]; }
            set
            {
                SetValue(ref _colorCeldas[8], value);
                OnPropertyChanged();
            }
        }
        public string TextTurno
        {
            get { return _TextTurno; }
            set
            {
                SetValue(ref _TextTurno, value);
                OnPropertyChanged(nameof(TextTurno));
            }
        }
        public string NamePlayer1
        {
            get { return _NamePlayer1; }
            set
            {
                SetValue(ref _NamePlayer1, value);
                OnPropertyChanged(nameof(NamePlayer1));
                OnPropertyChanged(nameof(TextTurno));
            }
        }
        public string NamePlayer2
        {
            get { return _NamePlayer2; }
            set
            {
                SetValue(ref _NamePlayer2, value);
                OnPropertyChanged(nameof(NamePlayer2));
                OnPropertyChanged(nameof(TextTurno));
            }
        }
        #endregion
        #region PROCESOS
        private void Play(string celda)
        {
            if (TurnPlayer1)
            {
                WriteSimbolPlayer1(celda);
                CountPlayer1++;
                TurnPlayer1 = false;
                Ganar(list_player1);
            }
            else
            {
                WriteSimbolPlayer2(celda);
                CountPlayer2++;
                TurnPlayer1 = true;
                Ganar(list_player2);
            }
        }
        private void WriteSimbolPlayer1(string celda)
        {
            switch (celda)
            {
                case "1":
                    Celda1 = "O";
                    ColorCelda1 = Color.FromHex("#FF0000");
                    list_player1.Add(1);
                    break;
                case "2":
                    Celda2 = "O";
                    ColorCelda2 = Color.FromHex("#FF0000");
                    list_player1.Add(2);
                    break;
                case "3":
                    Celda3 = "O";
                    ColorCelda3 = Color.FromHex("#FF0000");
                    list_player1.Add(3);
                    break;
                case "4":
                    Celda4 = "O";
                    ColorCelda4 = Color.FromHex("#FF0000");
                    list_player1.Add(4);
                    break;
                case "5":
                    Celda5 = "O";
                    ColorCelda5 = Color.FromHex("#FF0000");
                    list_player1.Add(5);
                    break;
                case "6":
                    Celda6 = "O";
                    ColorCelda6 = Color.FromHex("#FF0000");
                    list_player1.Add(6);
                    break;
                case "7":
                    Celda7 = "O";
                    ColorCelda7 = Color.FromHex("#FF0000");
                    list_player1.Add(7);
                    break;
                case "8":
                    Celda8 = "O";
                    ColorCelda8 = Color.FromHex("#FF0000");
                    list_player1.Add(8);
                    break;
                case "9":
                    Celda9 = "O";
                    ColorCelda9 = Color.FromHex("#FF0000");
                    list_player1.Add(9);
                    break;
            }
        }
        private void WriteSimbolPlayer2(string celda)
        {
            switch (celda)
            {
                case "1":
                    Celda1 = "X";
                    ColorCelda1 = Color.FromHex("#00CD00");
                    list_player2.Add(1);
                    break;
                case "2":
                    Celda2 = "X";
                    ColorCelda2 = Color.FromHex("#00CD00");
                    list_player2.Add(2);
                    break;
                case "3":
                    Celda3 = "X";
                    ColorCelda3 = Color.FromHex("#00CD00");
                    list_player2.Add(3);
                    break;
                case "4":
                    Celda4 = "X";
                    ColorCelda4 = Color.FromHex("#00CD00");
                    list_player2.Add(4);
                    break;
                case "5":
                    Celda5 = "X";
                    ColorCelda5 = Color.FromHex("#00CD00");
                    list_player2.Add(5);
                    break;
                case "6":
                    Celda6 = "X";
                    ColorCelda6 = Color.FromHex("#00CD00");
                    list_player2.Add(6);
                    break;
                case "7":
                    Celda7 = "X";
                    ColorCelda7 = Color.FromHex("#00CD00");
                    list_player2.Add(7);
                    break;
                case "8":
                    Celda8 = "X";
                    ColorCelda8 = Color.FromHex("#00CD00");
                    list_player2.Add(8);
                    break;
                case "9":
                    Celda9 = "X";
                    ColorCelda9 = Color.FromHex("#00CD00");
                    list_player2.Add(9);
                    break;
            }
        }
        private async void Ganar(List<int> lista1)
        {
            if (CountPlayer1 >= 3 || CountPlayer2 >= 3)
            {
                if (ListasIguales(lista1))
                {
                    await DisplayAlert("Felicitaciones", "Ganaste!!!", "Ok");
                    Limpiar();
                }
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
        private bool ListasIguales(List<int> lista1)
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
                int coincidencias = 0;
                foreach (int elementoLista in lista)
                {
                    foreach (int elementoLista1 in lista1)
                    {
                        if (elementoLista == elementoLista1)
                        {
                            coincidencias++;
                            break; // Salir del bucle interno si se encuentra una coincidencia
                        }
                    }
                }
                if (coincidencias == 3)
                {
                    iguales = true;
                    break;
                }
            }
            return iguales;
        }
        private void Limpiar()
        {
            Celda1 = "";
            Celda2 = "";
            Celda3 = "";
            Celda4 = "";
            Celda5 = "";
            Celda6 = "";
            Celda7 = "";
            Celda8 = "";
            Celda9 = "";
            ColorCelda1 = Color.FromHex("#FFFFFF");
            ColorCelda2 = Color.FromHex("#FFFFFF");
            ColorCelda3 = Color.FromHex("#FFFFFF");
            ColorCelda4= Color.FromHex("#FFFFFF");
            ColorCelda5 = Color.FromHex("#FFFFFF");
            ColorCelda6 = Color.FromHex("#FFFFFF");
            ColorCelda7 = Color.FromHex("#FFFFFF");
            ColorCelda8 = Color.FromHex("#FFFFFF");
            ColorCelda9 = Color.FromHex("#FFFFFF");
            list_player1.Clear();
            list_player2.Clear();
            CountPlayer1 = 0;
            CountPlayer2 = 0;
            TurnPlayer1 = Preferences.Get("Player1Default", false);
        }
        private void CerrarModal()
        {
            if (string.IsNullOrEmpty(NamePlayer1))
            {
                NamePlayer1 = "1";
            }
            if (string.IsNullOrEmpty(NamePlayer2))
            {
                NamePlayer2 = "2";
            }
            if (!TurnPlayer1 && !TurnPlayer2)
            {
                TurnPlayer1 = true;
                Preferences.Set("Player1Default", true);
            }
            else if (TurnPlayer1)
            {
                Preferences.Set("Player1Default", true);
            }
            else
            {
                Preferences.Set("Player1Default", false);
            }
            IsBusy = false;
        }
        #endregion
        #region COMANDOS
        public ICommand PlayCommand => new Command<string>(Play);
        public ICommand ReiniciarCommand => new Command(Limpiar);
        public ICommand CerrarCommand => new Command(CerrarModal);
        #endregion
    }
}