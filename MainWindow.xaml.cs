using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SeminarOOP
{

    public partial class MainWindow : Window
    {

        enum E_BMW
        {
            i8 = 85000,
            M2 = 50000,
            X6 = 105000,
            M4 = 45000,
            M5 = 100000,
            M3 = 44000
        }

        enum E_Audi
        {
            R8 = 100000,
            RS5 = 40000,
            A4 = 25000,
            A8 = 75000,
            A5 = 30000
        }

        enum E_Mercedes
        {
            AClass = 42000,
            BClass = 35000,
            CClass = 52000,
            EClass = 70000,
            GLS = 140000,

        }

        enum E_VW
        {
            Arteon = 50000,
            Caddy = 22000,
            Golf4 = 1000,
            Golf8 = 25000,
            Passat = 35000

        }

        enum E_Rimac
        {
            COne = 1000000,
            CTwo = 1640000
        }

        enum E_SportMtrc
        {
            BMW = 15000,
            Kawasaki = 10500,
            Ducati = 10000,
            Yamaha = 5000,
            Honda = 13000,
            Suzuki = 5200
        }

        enum E_RoadMtrc
        {
            BMW = 10000,
            Kawasaki = 5200,
            Ducati = 8000,
            Yamaha = 3000,
            Honda = 4000,
            Suzuki = 5000
        }

        enum E_Scooter
        {
            Piaggio = 1800,
            Yamaha = 2000,
            Aprilia = 2100,
            Peugeot = 2200,
            Gilera = 2400
        }

        class Vehicle
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Price { get; set; }
        }

        public List<OneLine> BMW_ = new List<OneLine>();
        public List<OneLine> SM_ = new List<OneLine>();
        public List<OneLine> RM_ = new List<OneLine>();
        public List<OneLine> Scooter_ = new List<OneLine>();
        public List<OneLine> Audi_ = new List<OneLine>();
        public List<OneLine> Rimac_ = new List<OneLine>();
        public List<OneLine> VW_ = new List<OneLine>();
        public List<OneLine> Mercedes_ = new List<OneLine>();
        public List<OneLine> Final = new List<OneLine>();
        public List<Data> Money = new List<Data>();

        void ReadF(string fileName, List<OneLine> listName)
        {
            string[] readText = File.ReadAllLines(fileName);
            foreach (string l in readText)
            {
                listName.Add(new OneLine { Line = l });
            }
        }

        void Log(string model, string brand, int price)
        {
            File.AppendAllText("Log.txt", "\n" + model + "\t\t" + brand + "\t\t" + price);
        }

        void Add(string line, List<OneLine> listName)
        {
            listName.Add(new OneLine { Line = line });
        }


        string[] S_BMW = new string[6];
        int[] S2_BMW = new int[6];

        void Add_BMW(string l, int k, int va)
        {
            S_BMW[k] = l;
            S2_BMW[k] = va;
        }

        string[] S_AUDI = new string[6];
        int[] S2_AUDI = new int[6];

        void Add_AUDI(string l, int k, int va)
        {
            S_AUDI[k] = l;
            S2_AUDI[k] = va;
        }

        string[] S_MERCEDES = new string[6];
        int[] S2_MERCEDES = new int[6];

        void Add_MERCEDES(string l, int k, int va)
        {
            S_MERCEDES[k] = l;
            S2_MERCEDES[k] = va;
        }

        string[] S_RIMAC = new string[6];
        int[] S2_RIMAC = new int[6];

        void Add_RIMAC(string l, int k, int va)
        {
            S_RIMAC[k] = l;
            S2_RIMAC[k] = va;
        }

        string[] S_VW = new string[6];
        int[] S2_VW = new int[6];

        void Add_VW(string l, int k, int va)
        {
            S_VW[k] = l;
            S2_VW[k] = va;
        }

        string[] S_SM = new string[6];
        int[] S2_SM = new int[6];

        void Add_SM(string l, int k, int va)
        {
            S_SM[k] = l;
            S2_SM[k] = va;
        }

        string[] S_RM = new string[6];
        int[] S2_RM = new int[6];

        void Add_RM(string l, int k, int va)
        {
            S_RM[k] = l;
            S2_RM[k] = va;
        }

        string[] S_SCOOTER = new string[6];
        int[] S2_SCOOTER = new int[6];

        void Add_SCOOTER(string l, int k, int va)
        {
            S_SCOOTER[k] = l;
            S2_SCOOTER[k] = va;
        }


        public MainWindow()
        {


            InitializeComponent();


            Money.Add(new Data { Range = "1,000€-3,000€" });
            Money.Add(new Data { Range = "3,000€-6,000€" });
            Money.Add(new Data { Range = "6,000€-12,000€" });
            Money.Add(new Data { Range = "12,000€-20,000€" });
            Money.Add(new Data { Range = "20,000€-50,000€" });
            Money.Add(new Data { Range = "50,000€-100,000€" });
            Money.Add(new Data { Range = "100000€+" });


            myComboBox.ItemsSource = Money;
            Source();
            File.Create("Log.txt");

        }


        private void sumbitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello { firstNameText.Text}, Welcome to my WPF app, please choose price and proceed to see which vehicle suits you!");
            CPRB.Visibility = Visibility.Visible;
            myComboBox.Visibility = Visibility.Visible;
            File.WriteAllText("Log.txt", "MODEL\t\t" + "BRAND\t\t" + "PRICE[€]" + "\n");
        }

        private void CHX1_Checked(object sender, RoutedEventArgs e)
        {
            CHX2.IsChecked = true;
            CHX4.IsChecked = true;

        }

        private void CHX1_Unchecked(object sender, RoutedEventArgs e)
        {
            CHX2.IsChecked = false;
            CHX4.IsChecked = false;

        }

        public class OneLine
        {
            public string Line { get; set; }

        }

        public class Data
        {
            public string Range { get; set; }

        }

        private void CHX2_Checked(object sender, RoutedEventArgs e)
        {
            CHX2_0.Visibility = Visibility.Visible;
            CHX2_1.Visibility = Visibility.Visible;
            CHX2_2.Visibility = Visibility.Visible;
            CHX2_3.Visibility = Visibility.Visible;
            CHX2_4.Visibility = Visibility.Visible;

        }

        private void CHX2_Unchecked(object sender, RoutedEventArgs e)
        {
            CHX2_0.Visibility = Visibility.Hidden;
            CHX2_1.Visibility = Visibility.Hidden;
            CHX2_2.Visibility = Visibility.Hidden;
            CHX2_3.Visibility = Visibility.Hidden;
            CHX2_4.Visibility = Visibility.Hidden;
            BMW_TB.Visibility = Visibility.Hidden;
            AUDI_TB.Visibility = Visibility.Hidden;
            RIMAC_TB.Visibility = Visibility.Hidden;
            VW_TB.Visibility = Visibility.Hidden;
            MERCEDES_TB.Visibility = Visibility.Hidden;
            myComboboxBMW.Visibility = Visibility.Hidden;
            myComboboxAUDI.Visibility = Visibility.Hidden;
            myComboboxRIMAC.Visibility = Visibility.Hidden;
            myComboboxVW.Visibility = Visibility.Hidden;
            myComboboxMERCEDES.Visibility = Visibility.Hidden;
            CHX2_0.IsChecked = false;
            CHX2_1.IsChecked = false;
            CHX2_2.IsChecked = false;
            CHX2_3.IsChecked = false;
            CHX2_4.IsChecked = false;

        }

        private void CHX4_Checked(object sender, RoutedEventArgs e)
        {
            CHX4_0.Visibility = Visibility.Visible;
            CHX4_1.Visibility = Visibility.Visible;
            CHX4_2.Visibility = Visibility.Visible;

        }

        void Less()
        {
            myComboboxBMW.ItemsSource = null;
            myComboboxBMW.Items.Clear();
            BMW_.Clear();
            myComboboxAUDI.ItemsSource = null;
            myComboboxAUDI.Items.Clear();
            Audi_.Clear();
            myComboboxMERCEDES.ItemsSource = null;
            myComboboxMERCEDES.Items.Clear();
            Mercedes_.Clear();
            myComboboxRIMAC.ItemsSource = null;
            myComboboxRIMAC.Items.Clear();
            Rimac_.Clear();
            myComboboxVW.ItemsSource = null;
            myComboboxVW.Items.Clear();
            VW_.Clear();
            myComboboxSM.ItemsSource = null;
            myComboboxSM.Items.Clear();
            SM_.Clear();
            myComboboxRM.ItemsSource = null;
            myComboboxRM.Items.Clear();
            RM_.Clear();
            myComboboxSCOOTER.ItemsSource = null;
            myComboboxSCOOTER.Items.Clear();
            Scooter_.Clear();


        }

        void Source()
        {
            myComboboxBMW.ItemsSource = BMW_;
            myComboboxAUDI.ItemsSource = Audi_;
            myComboboxMERCEDES.ItemsSource = Mercedes_;
            myComboboxVW.ItemsSource = VW_;
            myComboboxSM.ItemsSource = SM_;
            myComboboxRM.ItemsSource = RM_;
            myComboboxSCOOTER.ItemsSource = Scooter_;
            myComboboxRIMAC.ItemsSource = Rimac_;
        }

        private void CHX4_Unchecked(object sender, RoutedEventArgs e)
        {
            CHX4_0.Visibility = Visibility.Hidden;
            CHX4_1.Visibility = Visibility.Hidden;
            CHX4_2.Visibility = Visibility.Hidden;
            SM_TB.Visibility = Visibility.Hidden;
            RM_TB.Visibility = Visibility.Hidden;
            SCOOTER_TB.Visibility = Visibility.Hidden;
            myComboboxSM.Visibility = Visibility.Hidden;
            myComboboxRM.Visibility = Visibility.Hidden;
            myComboboxSCOOTER.Visibility = Visibility.Hidden;
            CHX4_0.IsChecked = false;
            CHX4_1.IsChecked = false;
            CHX4_2.IsChecked = false;

        }

        private void myComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i_bmw = 0;
            int i_audi = 0;
            int i_mercedes = 0;
            int i_rimac = 0;
            int i_vw = 0;
            int i_sm = 0;
            int i_rm = 0;
            int i_scooter = 0;
            CHX1.Visibility = Visibility.Visible;
            CHX2.Visibility = Visibility.Visible;
            CHX4.Visibility = Visibility.Visible;
            CHX2.IsChecked = true;
            CHX4.IsChecked = true;
            B_B.Visibility = Visibility.Hidden;
            switch (myComboBox.SelectedIndex)
            {
                case 0:
                    Less();

                    foreach (E_BMW val in Enum.GetValues(typeof(E_BMW)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 1000 && value <= 3000)
                        {
                            string read = Enum.GetName(typeof(E_BMW), value);
                            Add(read, BMW_);
                            Add_BMW(read, i_bmw, value);
                            i_bmw++;
                        }
                    }
                    myComboboxBMW.ItemsSource = BMW_;
                    foreach (E_Audi val in Enum.GetValues(typeof(E_Audi)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 1000 && value <= 3000)
                        {
                            string read = Enum.GetName(typeof(E_Audi), value);
                            Add(read, Audi_);
                            Add_AUDI(read, i_audi, value);
                            i_audi++;
                        }
                    }

                    foreach (E_Mercedes val in Enum.GetValues(typeof(E_Mercedes)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 1000 && value <= 3000)
                        {
                            string read = Enum.GetName(typeof(E_Mercedes), value);
                            Add(read, Mercedes_);
                            Add_MERCEDES(read, i_mercedes, value);
                            i_mercedes++;
                        }
                    }

                    foreach (E_VW val in Enum.GetValues(typeof(E_VW)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 1000 && value <= 3000)
                        {
                            string read = Enum.GetName(typeof(E_VW), value);
                            Add(read, VW_);
                            Add_VW(read, i_vw, value);
                            i_vw++;
                        }
                    }

                    foreach (E_Rimac val in Enum.GetValues(typeof(E_Rimac)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 1000 && value <= 3000)
                        {
                            string read = Enum.GetName(typeof(E_Rimac), value);
                            Add(read, Rimac_);
                            Add_RIMAC(read, i_rimac, value);
                            i_rimac++;
                        }
                    }
                    foreach (E_SportMtrc val in Enum.GetValues(typeof(E_SportMtrc)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 1000 && value <= 3000)
                        {
                            string read = Enum.GetName(typeof(E_SportMtrc), value);
                            Add(read, SM_);
                            Add_SM(read, i_sm, value);
                            i_sm++;
                        }
                    }
                    foreach (E_RoadMtrc val in Enum.GetValues(typeof(E_RoadMtrc)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 1000 && value <= 3000)
                        {
                            string read = Enum.GetName(typeof(E_RoadMtrc), value);
                            Add(read, RM_);
                            Add_RM(read, i_rm, value);
                            i_rm++;
                        }
                    }
                    foreach (E_Scooter val in Enum.GetValues(typeof(E_Scooter)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 1000 && value <= 3000)
                        {
                            string read = Enum.GetName(typeof(E_Scooter), value);
                            Add(read, Scooter_);
                            Add_SCOOTER(read, i_scooter, value);
                            i_scooter++;
                        }
                    }
                    Source();
                    break;
                case 1:
                    Less();

                    foreach (E_BMW val in Enum.GetValues(typeof(E_BMW)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 3000 && value <= 6000)
                        {
                            string read = Enum.GetName(typeof(E_BMW), value);

                            Add(read, BMW_);
                            Add_BMW(read, i_bmw, value);
                            i_bmw++;
                        }
                    }
                    myComboboxBMW.ItemsSource = BMW_;

                    foreach (E_Audi val in Enum.GetValues(typeof(E_Audi)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 3000 && value <= 6000)
                        {
                            string read = Enum.GetName(typeof(E_Audi), value);

                            Add(read, Audi_);
                            Add_AUDI(read, i_audi, value);
                            i_audi++;
                        }
                    }

                    foreach (E_Mercedes val in Enum.GetValues(typeof(E_Mercedes)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 3000 && value <= 6000)
                        {
                            string read = Enum.GetName(typeof(E_Mercedes), value);

                            Add(read, Mercedes_);
                            Add_MERCEDES(read, i_mercedes, value);
                            i_mercedes++;
                        }
                    }

                    foreach (E_VW val in Enum.GetValues(typeof(E_VW)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 3000 && value <= 6000)
                        {
                            string read = Enum.GetName(typeof(E_VW), value);

                            Add(read, VW_);
                            Add_VW(read, i_vw, value);
                            i_vw++;
                        }
                    }

                    foreach (E_Rimac val in Enum.GetValues(typeof(E_Rimac)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 3000 && value <= 6000)
                        {
                            string read = Enum.GetName(typeof(E_Rimac), value);

                            Add(read, Rimac_);
                            Add_RIMAC(read, i_rimac, value);
                            i_rimac++;
                        }
                    }
                    foreach (E_SportMtrc val in Enum.GetValues(typeof(E_SportMtrc)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 3000 && value <= 6000)
                        {
                            string read = Enum.GetName(typeof(E_SportMtrc), value);

                            Add(read, SM_);
                            Add_SM(read, i_sm, value);
                            i_sm++;
                        }
                    }
                    foreach (E_RoadMtrc val in Enum.GetValues(typeof(E_RoadMtrc)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 3000 && value <= 6000)
                        {
                            string read = Enum.GetName(typeof(E_RoadMtrc), value);

                            Add(read, RM_);
                            Add_RM(read, i_rm, value);
                            i_rm++;
                        }
                    }
                    foreach (E_Scooter val in Enum.GetValues(typeof(E_Scooter)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 3000 && value <= 6000)
                        {
                            string read = Enum.GetName(typeof(E_Scooter), value);

                            Add(read, Scooter_);
                            Add_SCOOTER(read, i_scooter, value);
                            i_scooter++;
                        }
                    }
                    Source();
                    break;
                case 2:
                    Less();

                    foreach (E_BMW val in Enum.GetValues(typeof(E_BMW)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 6000 && value <= 12000)
                        {
                            string read = Enum.GetName(typeof(E_BMW), value);

                            Add(read, BMW_);
                            Add_BMW(read, i_bmw, value);
                            i_bmw++;
                        }
                    }
                    myComboboxBMW.ItemsSource = BMW_;
                    foreach (E_Audi val in Enum.GetValues(typeof(E_Audi)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 6000 && value <= 12000)
                        {
                            string read = Enum.GetName(typeof(E_Audi), value);

                            Add(read, Audi_);
                            Add_AUDI(read, i_audi, value);
                            i_audi++;
                        }
                    }

                    foreach (E_Mercedes val in Enum.GetValues(typeof(E_Mercedes)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 6000 && value <= 12000)
                        {
                            string read = Enum.GetName(typeof(E_Mercedes), value);

                            Add(read, Mercedes_);
                            Add_MERCEDES(read, i_mercedes, value);
                            i_mercedes++;
                        }
                    }

                    foreach (E_VW val in Enum.GetValues(typeof(E_VW)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 6000 && value <= 12000)
                        {
                            string read = Enum.GetName(typeof(E_VW), value);

                            Add(read, VW_);
                            Add_VW(read, i_vw, value);
                            i_vw++;
                        }
                    }

                    foreach (E_Rimac val in Enum.GetValues(typeof(E_Rimac)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 6000 && value <= 12000)
                        {
                            string read = Enum.GetName(typeof(E_Rimac), value);

                            Add(read, Rimac_);
                            Add_RIMAC(read, i_rimac, value);
                            i_rimac++;
                        }
                    }
                    foreach (E_SportMtrc val in Enum.GetValues(typeof(E_SportMtrc)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 6000 && value <= 12000)
                        {
                            string read = Enum.GetName(typeof(E_SportMtrc), value);

                            Add(read, SM_);
                            Add_SM(read, i_sm, value);
                            i_sm++;
                        }
                    }
                    foreach (E_RoadMtrc val in Enum.GetValues(typeof(E_RoadMtrc)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 6000 && value <= 12000)
                        {
                            string read = Enum.GetName(typeof(E_RoadMtrc), value);

                            Add(read, RM_);
                            Add_RM(read, i_rm, value);
                            i_rm++;
                        }
                    }
                    foreach (E_Scooter val in Enum.GetValues(typeof(E_Scooter)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 6000 && value <= 12000)
                        {
                            string read = Enum.GetName(typeof(E_Scooter), value);

                            Add(read, Scooter_);
                            Add_SCOOTER(read, i_scooter, value);
                            i_scooter++;
                        }
                    }
                    Source();
                    break;
                case 3:
                    Less();

                    foreach (E_BMW val in Enum.GetValues(typeof(E_BMW)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 12000 && value <= 20000)
                        {
                            string read = Enum.GetName(typeof(E_BMW), value);

                            Add(read, BMW_);
                            Add_BMW(read, i_bmw, value);
                            i_bmw++;
                        }
                    }
                    myComboboxBMW.ItemsSource = BMW_;
                    foreach (E_Audi val in Enum.GetValues(typeof(E_Audi)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 12000 && value <= 20000)
                        {
                            string read = Enum.GetName(typeof(E_Audi), value);

                            Add(read, Audi_);
                            Add_AUDI(read, i_audi, value);
                            i_audi++;
                        }
                    }

                    foreach (E_Mercedes val in Enum.GetValues(typeof(E_Mercedes)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 12000 && value <= 20000)
                        {
                            string read = Enum.GetName(typeof(E_Mercedes), value);

                            Add(read, Mercedes_);
                            Add_MERCEDES(read, i_mercedes, value);
                            i_mercedes++;
                        }
                    }

                    foreach (E_VW val in Enum.GetValues(typeof(E_VW)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 12000 && value <= 20000)
                        {
                            string read = Enum.GetName(typeof(E_VW), value);

                            Add(read, VW_);
                            Add_VW(read, i_vw, value);
                            i_vw++;
                        }
                    }

                    foreach (E_Rimac val in Enum.GetValues(typeof(E_Rimac)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 12000 && value <= 20000)
                        {
                            string read = Enum.GetName(typeof(E_Rimac), value);

                            Add(read, Rimac_);
                            Add_RIMAC(read, i_rimac, value);
                            i_rimac++;
                        }
                    }
                    foreach (E_SportMtrc val in Enum.GetValues(typeof(E_SportMtrc)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 12000 && value <= 20000)
                        {
                            string read = Enum.GetName(typeof(E_SportMtrc), value);

                            Add(read, SM_);
                            Add_SM(read, i_sm, value);
                            i_sm++;
                        }
                    }
                    foreach (E_RoadMtrc val in Enum.GetValues(typeof(E_RoadMtrc)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 12000 && value <= 20000)
                        {
                            string read = Enum.GetName(typeof(E_RoadMtrc), value);

                            Add(read, RM_);
                            Add_RM(read, i_rm, value);
                            i_rm++;
                        }
                    }
                    foreach (E_Scooter val in Enum.GetValues(typeof(E_Scooter)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 12000 && value <= 20000)
                        {
                            string read = Enum.GetName(typeof(E_Scooter), value);

                            Add(read, Scooter_);
                            Add_SCOOTER(read, i_scooter, value);
                            i_scooter++;
                        }
                    }
                    Source();
                    break;
                case 4:
                    Less();

                    foreach (E_BMW val in Enum.GetValues(typeof(E_BMW)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 20000 && value <= 50000)
                        {
                            string read = Enum.GetName(typeof(E_BMW), value);

                            Add(read, BMW_);
                            Add_BMW(read, i_bmw, value);
                            i_bmw++;
                        }
                    }
                    myComboboxBMW.ItemsSource = BMW_;
                    foreach (E_Audi val in Enum.GetValues(typeof(E_Audi)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 20000 && value <= 50000)
                        {
                            string read = Enum.GetName(typeof(E_Audi), value);

                            Add(read, Audi_);
                            Add_AUDI(read, i_audi, value);
                            i_audi++;
                        }
                    }

                    foreach (E_Mercedes val in Enum.GetValues(typeof(E_Mercedes)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 20000 && value <= 50000)
                        {
                            string read = Enum.GetName(typeof(E_Mercedes), value);

                            Add(read, Mercedes_);
                            Add_MERCEDES(read, i_mercedes, value);
                            i_mercedes++;
                        }
                    }

                    foreach (E_VW val in Enum.GetValues(typeof(E_VW)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 20000 && value <= 50000)
                        {
                            string read = Enum.GetName(typeof(E_VW), value);

                            Add(read, VW_);
                            Add_VW(read, i_vw, value);
                            i_vw++;
                        }
                    }

                    foreach (E_Rimac val in Enum.GetValues(typeof(E_Rimac)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 20000 && value <= 50000)
                        {
                            string read = Enum.GetName(typeof(E_Rimac), value);

                            Add(read, Rimac_);
                            Add_RIMAC(read, i_rimac, value);
                            i_rimac++;
                        }
                    }
                    foreach (E_SportMtrc val in Enum.GetValues(typeof(E_SportMtrc)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 20000 && value <= 50000)
                        {
                            string read = Enum.GetName(typeof(E_SportMtrc), value);

                            Add(read, SM_);
                            Add_SM(read, i_sm, value);
                            i_sm++;
                        }
                    }
                    foreach (E_RoadMtrc val in Enum.GetValues(typeof(E_RoadMtrc)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 20000 && value <= 50000)
                        {
                            string read = Enum.GetName(typeof(E_RoadMtrc), value);

                            Add(read, RM_);
                            Add_RM(read, i_rm, value);
                            i_rm++;
                        }
                    }
                    foreach (E_Scooter val in Enum.GetValues(typeof(E_Scooter)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 20000 && value <= 50000)
                        {
                            string read = Enum.GetName(typeof(E_Scooter), value);

                            Add(read, Scooter_);
                            Add_SCOOTER(read, i_scooter, value);
                            i_scooter++;
                        }
                    }
                    Source();
                    break;
                case 5:
                    Less();

                    foreach (E_BMW val in Enum.GetValues(typeof(E_BMW)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 50000 && value <= 100000)
                        {
                            string read = Enum.GetName(typeof(E_BMW), value);

                            Add(read, BMW_);
                            Add_BMW(read, i_bmw, value);
                            i_bmw++;
                        }
                    }

                    myComboboxBMW.ItemsSource = BMW_;
                    foreach (E_Audi val in Enum.GetValues(typeof(E_Audi)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 50000 && value <= 100000)
                        {
                            string read = Enum.GetName(typeof(E_Audi), value);

                            Add(read, Audi_);
                            Add_AUDI(read, i_audi, value);
                            i_audi++;
                        }
                    }

                    foreach (E_Mercedes val in Enum.GetValues(typeof(E_Mercedes)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 50000 && value <= 100000)
                        {
                            string read = Enum.GetName(typeof(E_Mercedes), value);

                            Add(read, Mercedes_);
                            Add_MERCEDES(read, i_mercedes, value);
                            i_mercedes++;
                        }
                    }

                    foreach (E_VW val in Enum.GetValues(typeof(E_VW)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 50000 && value <= 100000)
                        {
                            string read = Enum.GetName(typeof(E_VW), value);

                            Add(read, VW_);
                            Add_VW(read, i_vw, value);
                            i_vw++;
                        }
                    }

                    foreach (E_Rimac val in Enum.GetValues(typeof(E_Rimac)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 50000 && value <= 100000)
                        {
                            string read = Enum.GetName(typeof(E_Rimac), value);

                            Add(read, Rimac_);
                            Add_RIMAC(read, i_rimac, value);
                            i_rimac++;
                        }
                    }

                    foreach (E_SportMtrc val in Enum.GetValues(typeof(E_SportMtrc)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 50000 && value <= 100000)
                        {
                            string read = Enum.GetName(typeof(E_SportMtrc), value);

                            Add(read, SM_);
                            Add_SM(read, i_sm, value);
                            i_sm++;
                        }
                    }

                    foreach (E_RoadMtrc val in Enum.GetValues(typeof(E_RoadMtrc)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 50000 && value <= 100000)
                        {
                            string read = Enum.GetName(typeof(E_RoadMtrc), value);

                            Add(read, RM_);
                            Add_RM(read, i_rm, value);
                            i_rm++;
                        }
                    }

                    foreach (E_Scooter val in Enum.GetValues(typeof(E_Scooter)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 50000 && value <= 100000)
                        {
                            string read = Enum.GetName(typeof(E_Scooter), value);

                            Add(read, Scooter_);
                            Add_SCOOTER(read, i_scooter, value);
                            i_scooter++;
                        }
                    }
                    Source();
                    break;
                case 6:
                    Less();

                    foreach (E_BMW val in Enum.GetValues(typeof(E_BMW)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 100000)
                        {
                            string read = Enum.GetName(typeof(E_BMW), value);


                            Add(read, BMW_);
                            Add_BMW(read, i_bmw, value);
                            i_bmw++;

                        }


                    }

                    foreach (E_Audi val in Enum.GetValues(typeof(E_Audi)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 100000)
                        {
                            string read = Enum.GetName(typeof(E_Audi), value);


                            Add(read, Audi_);
                            Add_AUDI(read, i_audi, value);
                            i_audi++;
                        }
                    }

                    foreach (E_Mercedes val in Enum.GetValues(typeof(E_Mercedes)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 100000)
                        {
                            string read = Enum.GetName(typeof(E_Mercedes), value);

                            Add(read, Mercedes_);
                            Add_MERCEDES(read, i_mercedes, value);
                            i_mercedes++;
                        }
                    }

                    foreach (E_VW val in Enum.GetValues(typeof(E_VW)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 100000)
                        {
                            string read = Enum.GetName(typeof(E_VW), value);

                            Add(read, VW_);
                            Add_VW(read, i_vw, value);
                            i_vw++;
                        }
                    }

                    foreach (E_Rimac val in Enum.GetValues(typeof(E_Rimac)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 100000)
                        {
                            string read = Enum.GetName(typeof(E_Rimac), value);

                            Add(read, Rimac_);
                            Add_RIMAC(read, i_rimac, value);
                            i_rimac++;
                        }
                    }

                    foreach (E_SportMtrc val in Enum.GetValues(typeof(E_SportMtrc)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 100000)
                        {
                            string read = Enum.GetName(typeof(E_SportMtrc), value);

                            Add(read, SM_);
                            Add_SM(read, i_sm, value);
                            i_sm++;
                        }
                    }

                    foreach (E_RoadMtrc val in Enum.GetValues(typeof(E_RoadMtrc)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 100000)
                        {
                            string read = Enum.GetName(typeof(E_RoadMtrc), value);

                            Add(read, RM_);
                            Add_RM(read, i_rm, value);
                            i_rm++;
                        }
                    }

                    foreach (E_Scooter val in Enum.GetValues(typeof(E_Scooter)))
                    {
                        int value = Convert.ToInt32(val);
                        if (value >= 100000)
                        {
                            string read = Enum.GetName(typeof(E_Scooter), value);

                            Add(read, Scooter_);
                            Add_SCOOTER(read, i_scooter, value);
                            i_scooter++;
                        }
                    }
                    Source();
                    break;
            }

        }

        private void CHX2_0_Checked(object sender, RoutedEventArgs e)
        {
            myComboboxBMW.Visibility = Visibility.Visible;
            CHX2_0.Visibility = Visibility.Hidden;
            BMW_TB.Visibility = Visibility.Visible;

        }

        private void CHX2_1_Checked(object sender, RoutedEventArgs e)
        {
            myComboboxAUDI.Visibility = Visibility.Visible;
            CHX2_1.Visibility = Visibility.Hidden;
            AUDI_TB.Visibility = Visibility.Visible;
        }

        private void CHX2_2_Checked(object sender, RoutedEventArgs e)
        {
            myComboboxMERCEDES.Visibility = Visibility.Visible;
            CHX2_2.Visibility = Visibility.Hidden;
            MERCEDES_TB.Visibility = Visibility.Visible;
        }

        private void CHX2_3_Checked(object sender, RoutedEventArgs e)
        {
            myComboboxVW.Visibility = Visibility.Visible;
            CHX2_3.Visibility = Visibility.Hidden;
            VW_TB.Visibility = Visibility.Visible;
        }

        private void CHX2_4_Checked(object sender, RoutedEventArgs e)
        {
            myComboboxRIMAC.Visibility = Visibility.Visible;
            CHX2_4.Visibility = Visibility.Hidden;
            RIMAC_TB.Visibility = Visibility.Visible;
        }

        private void CHX4_0_Checked(object sender, RoutedEventArgs e)
        {
            myComboboxSM.Visibility = Visibility.Visible;
            CHX4_0.Visibility = Visibility.Hidden;
            SM_TB.Visibility = Visibility.Visible;
        }

        private void CHX4_1_Checked(object sender, RoutedEventArgs e)
        {
            myComboboxRM.Visibility = Visibility.Visible;
            CHX4_1.Visibility = Visibility.Hidden;
            RM_TB.Visibility = Visibility.Visible;
        }

        private void CHX4_2_Checked(object sender, RoutedEventArgs e)
        {
            myComboboxSCOOTER.Visibility = Visibility.Visible;
            CHX4_2.Visibility = Visibility.Hidden;
            SCOOTER_TB.Visibility = Visibility.Visible;
        }

        private void myComboboxBMW_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            myListView.Visibility = Visibility.Visible;
            TB_B.Visibility = Visibility.Visible;
            B.Visibility = Visibility.Visible;
            switch (myComboboxBMW.SelectedIndex)
            {
                case 0:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "BMW", Model = S_BMW[0], Price = S2_BMW[0] });
                    Log("BMW", S_BMW[0], S2_BMW[0]);
                    break;
                case 1:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "BMW", Model = S_BMW[1], Price = S2_BMW[1] });
                    Log("BMW", S_BMW[1], S2_BMW[1]);
                    break;
                case 2:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "BMW", Model = S_BMW[2], Price = S2_BMW[2] });
                    Log("BMW", S_BMW[2], S2_BMW[2]);
                    break;
                case 3:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "BMW", Model = S_BMW[3], Price = S2_BMW[3] });
                    Log("BMW", S_BMW[3], S2_BMW[3]);
                    break;
                case 4:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "BMW", Model = S_BMW[4], Price = S2_BMW[4] });
                    Log("BMW", S_BMW[4], S2_BMW[4]);
                    break;
                case 5:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "BMW", Model = S_BMW[5], Price = S2_BMW[5] });
                    Log("BMW", S_BMW[5], S2_BMW[5]);
                    break;
            }

        }

        private void myComboboxAUDI_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            myListView.Visibility = Visibility.Visible;
            TB_B.Visibility = Visibility.Visible;
            B.Visibility = Visibility.Visible;
            switch (myComboboxAUDI.SelectedIndex)
            {
                case 0:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Audi", Model = S_AUDI[0], Price = S2_AUDI[0] });
                    Log("Audi", S_AUDI[0], S2_AUDI[0]);
                    break;
                case 1:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Audi", Model = S_AUDI[1], Price = S2_AUDI[1] });
                    Log("Audi", S_AUDI[1], S2_AUDI[1]);
                    break;
                case 2:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Audi", Model = S_AUDI[2], Price = S2_AUDI[2] });
                    Log("Audi", S_AUDI[2], S2_AUDI[2]);
                    break;
                case 3:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Audi", Model = S_AUDI[3], Price = S2_AUDI[3] });
                    Log("Audi", S_AUDI[3], S2_AUDI[3]);
                    break;
                case 4:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Audi", Model = S_AUDI[4], Price = S2_AUDI[4] });
                    Log("Audi", S_AUDI[4], S2_AUDI[4]);
                    break;
                case 5:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Audi", Model = S_AUDI[5], Price = S2_AUDI[5] });
                    Log("Audi", S_AUDI[5], S2_AUDI[5]);
                    break;
            }


        }

        private void myComboboxMERCEDES_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            myListView.Visibility = Visibility.Visible;
            TB_B.Visibility = Visibility.Visible;
            B.Visibility = Visibility.Visible;
            switch (myComboboxMERCEDES.SelectedIndex)
            {
                case 0:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Mercedes", Model = S_MERCEDES[0], Price = S2_MERCEDES[0] });
                    Log("Mercedes", S_MERCEDES[0], S2_MERCEDES[0]);
                    break;
                case 1:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Mercedes", Model = S_MERCEDES[1], Price = S2_MERCEDES[1] });
                    Log("Mercedes", S_MERCEDES[1], S2_MERCEDES[1]);
                    break;
                case 2:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Mercedes", Model = S_MERCEDES[2], Price = S2_MERCEDES[2] });
                    Log("Mercedes", S_MERCEDES[2], S2_MERCEDES[2]);
                    break;
                case 3:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Mercedes", Model = S_MERCEDES[3], Price = S2_MERCEDES[3] });
                    Log("Mercedes", S_MERCEDES[3], S2_MERCEDES[3]);
                    break;
                case 4:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Mercedes", Model = S_MERCEDES[4], Price = S2_MERCEDES[4] });
                    Log("Mercedes", S_MERCEDES[4], S2_MERCEDES[4]);
                    break;
                case 5:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Mercedes", Model = S_MERCEDES[5], Price = S2_MERCEDES[5] });
                    Log("Mercedes", S_MERCEDES[5], S2_MERCEDES[5]);
                    break;
            }

        }

        private void myComboboxRIMAC_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            myListView.Visibility = Visibility.Visible;
            TB_B.Visibility = Visibility.Visible;
            B.Visibility = Visibility.Visible;
            switch (myComboboxRIMAC.SelectedIndex)
            {
                case 0:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Rimac", Model = S_RIMAC[0], Price = S2_RIMAC[0] });
                    Log("Rimac", S_RIMAC[0], S2_RIMAC[0]);
                    break;
                case 1:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Rimac", Model = S_RIMAC[1], Price = S2_RIMAC[1] });
                    Log("Rimac", S_RIMAC[1], S2_RIMAC[1]);
                    break;
                case 2:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Rimac", Model = S_RIMAC[2], Price = S2_RIMAC[2] });
                    Log("Rimac", S_RIMAC[2], S2_RIMAC[2]);
                    break;
                case 3:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Rimac", Model = S_RIMAC[3], Price = S2_RIMAC[3] });
                    Log("Rimac", S_RIMAC[3], S2_RIMAC[3]);
                    break;
                case 4:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Rimac", Model = S_RIMAC[4], Price = S2_RIMAC[4] });
                    Log("Rimac", S_RIMAC[4], S2_RIMAC[4]);
                    break;
                case 5:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Rimac", Model = S_RIMAC[5], Price = S2_RIMAC[5] });
                    Log("Rimac", S_RIMAC[5], S2_RIMAC[5]);
                    break;
            }

        }

        private void myComboboxVW_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            myListView.Visibility = Visibility.Visible;
            TB_B.Visibility = Visibility.Visible;
            B.Visibility = Visibility.Visible;
            switch (myComboboxVW.SelectedIndex)
            {
                case 0:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "VW", Model = S_VW[0], Price = S2_VW[0] });
                    Log("VW", S_VW[0], S2_VW[0]);
                    break;
                case 1:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "VW", Model = S_VW[1], Price = S2_VW[1] });
                    Log("VW", S_VW[1], S2_VW[1]);
                    break;
                case 2:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "VW", Model = S_VW[2], Price = S2_VW[2] });
                    Log("VW", S_VW[2], S2_VW[2]);
                    break;
                case 3:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "VW", Model = S_VW[3], Price = S2_VW[3] });
                    Log("VW", S_VW[3], S2_VW[3]);
                    break;
                case 4:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "VW", Model = S_VW[4], Price = S2_VW[4] });
                    Log("VW", S_VW[4], S2_VW[4]);
                    break;
                case 5:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "VW", Model = S_VW[5], Price = S2_VW[5] });
                    Log("VW", S_VW[5], S2_VW[5]);
                    break;
            }

        }

        private void myComboboxSM_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            myListView.Visibility = Visibility.Visible;
            TB_B.Visibility = Visibility.Visible;
            B.Visibility = Visibility.Visible;
            switch (myComboboxSM.SelectedIndex)
            {
                case 0:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "SM", Model = S_SM[0], Price = S2_SM[0] });
                    Log("SM", S_SM[0], S2_SM[0]);
                    break;
                case 1:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "SM", Model = S_SM[1], Price = S2_SM[1] });
                    Log("SM", S_SM[1], S2_SM[1]);
                    break;
                case 2:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "SM", Model = S_SM[2], Price = S2_SM[2] });
                    Log("SM", S_SM[2], S2_SM[2]);
                    break;
                case 3:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "SM", Model = S_SM[3], Price = S2_SM[3] });
                    Log("SM", S_SM[3], S2_SM[3]);
                    break;
                case 4:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "SM", Model = S_SM[4], Price = S2_SM[4] });
                    Log("SM", S_SM[4], S2_SM[4]);
                    break;
                case 5:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "SM", Model = S_SM[5], Price = S2_SM[5] });
                    Log("SM", S_SM[5], S2_SM[5]);
                    break;
            }

        }

        private void myComboboxRM_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            myListView.Visibility = Visibility.Visible;
            TB_B.Visibility = Visibility.Visible;
            B.Visibility = Visibility.Visible;
            switch (myComboboxRM.SelectedIndex)
            {
                case 0:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "RM", Model = S_RM[0], Price = S2_RM[0] });
                    Log("RM", S_RM[0], S2_RM[0]);
                    break;
                case 1:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "RM", Model = S_RM[1], Price = S2_RM[1] });
                    Log("RM", S_RM[1], S2_RM[1]);
                    break;
                case 2:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "RM", Model = S_RM[2], Price = S2_RM[2] });
                    Log("RM", S_RM[2], S2_RM[2]);
                    break;
                case 3:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "RM", Model = S_RM[3], Price = S2_RM[3] });
                    Log("RM", S_RM[3], S2_RM[3]);
                    break;
                case 4:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "RM", Model = S_RM[4], Price = S2_RM[4] });
                    Log("RM", S_RM[4], S2_RM[4]);
                    break;
                case 5:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "RM", Model = S_RM[5], Price = S2_RM[5] });
                    Log("RM", S_RM[5], S2_RM[5]);
                    break;
            }

        }

        private void myComboboxSCOOTER_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            myListView.Visibility = Visibility.Visible;
            TB_B.Visibility = Visibility.Visible;
            B.Visibility = Visibility.Visible;
            switch (myComboboxSCOOTER.SelectedIndex)
            {
                case 0:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Scooter", Model = S_SCOOTER[0], Price = S2_SCOOTER[0] });
                    Log("Scooter", S_SCOOTER[0], S2_SCOOTER[0]);
                    break;
                case 1:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Scooter", Model = S_SCOOTER[1], Price = S2_SCOOTER[1] });
                    Log("Scooter", S_SCOOTER[1], S2_SCOOTER[1]);
                    break;
                case 2:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Scooter", Model = S_SCOOTER[2], Price = S2_SCOOTER[2] });
                    Log("Scooter", S_SCOOTER[2], S2_SCOOTER[2]);
                    break;
                case 3:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Scooter", Model = S_SCOOTER[3], Price = S2_SCOOTER[3] });
                    Log("Scooter", S_SCOOTER[3], S2_SCOOTER[3]);
                    break;
                case 4:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Scooter", Model = S_SCOOTER[4], Price = S2_SCOOTER[4] });
                    Log("Scooter", S_SCOOTER[4], S2_SCOOTER[4]);
                    break;
                case 5:
                    myListView.Items.Clear();
                    myListView.Items.Add(new Vehicle() { Brand = "Scooter", Model = S_SCOOTER[5], Price = S2_SCOOTER[5] });
                    Log("Scooter", S_SCOOTER[5], S2_SCOOTER[5]);
                    break;
            }

        }

        private void In(object sender, EventArgs e)
        {
            ReadF("Texts/Audi.txt", Audi_);
            ReadF("Texts/BMW.txt", BMW_);
            ReadF("Texts/Mercedes.txt", Mercedes_);
            ReadF("Texts/Rimac.txt", Rimac_);
            ReadF("Texts/Vw.txt", VW_);
            ReadF("Texts/SportMtrc.txt", SM_);
            ReadF("Texts/RoadMtrc.txt", RM_);
            ReadF("Texts/Scooter.txt", Scooter_);

        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            myListView.Items.Clear();
            Less();
            B_B.Visibility = Visibility.Visible;
            CHX2.IsChecked = false;
            CHX4.IsChecked = false;
            File.WriteAllText("Log.txt", "MODEL\t\t" + "BRAND\t\t" + "PRICE[€]" + "\n");
        }
    }
}
