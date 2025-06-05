using System;
using System.Collections.Generic;
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

namespace ENabız
{
    public partial class RadiologyPage : Window
    {
        public RadiologyPage()
        {
            InitializeComponent();
            Loaded += RadiologyPage_Loaded;
        }

        private void RadiologyPage_Loaded(object sender, RoutedEventArgs e)
        {
            List<RadiologyData> data = new List<RadiologyData>
            {
                new RadiologyData
                {
                    Tarih = "28.06.2024",
                    OnIzleme = "C:\\Users\\TUANA\\OneDrive\\Masaüstü\\Projects\\ENabız\\ENabız\\ENabız\\mrornekleri\\VertebraGrafisi.jpg",
                    HastaneAdi = "TRABZON YAVUZ SELİM KEMİK HASTANESİ",
                    Aciklama = "Vertebra grafileri, dorsal veya lomber (İki yön )",
                    Rapor = "Yok"
                },
                new RadiologyData
                {
                    Tarih = "21.12.2023",
                    OnIzleme = "C:\\Users\\TUANA\\OneDrive\\Masaüstü\\Projects\\ENabız\\ENabız\\ENabız\\mrornekleri\\SağDizGrafisi.jpg",
                    HastaneAdi = "KARADENİZ TEKNİK ÜNİVERSİTESİ FARABİ HASTANESİ",
                    Aciklama = "Sağ diz grafisi (İki yön)",
                    Rapor = "Yok"
                },
                new RadiologyData
                {
                    Tarih = "12.06.2023",
                    OnIzleme = "C:\\Users\\TUANA\\OneDrive\\Masaüstü\\Projects\\ENabız\\ENabız\\ENabız\\mrornekleri\\SinüsParanazalGrafisi.jpg",
                    HastaneAdi = "ESKİŞEHİR ŞEHİR HASTANESİ",
                    Aciklama = "Sinüs paranasal grafisi (Waters ve Caldwell)",
                    Rapor = "Yok"
                },
                new RadiologyData
                {
                    Tarih = "24.05.2023",
                    OnIzleme = "C:\\Users\\TUANA\\OneDrive\\Masaüstü\\Projects\\ENabız\\ENabız\\ENabız\\mrornekleri\\ToraksGrafisi.jpg",
                    HastaneAdi = "BİLECİK BOZÜYÜK DEVLET HASTANESİ",
                    Aciklama = "Toraks grafisi (AP ve lateral)",
                    Rapor = "Yok"
                },
                new RadiologyData
                {
                    Tarih = "24.05.2023",
                    OnIzleme = "C:\\Users\\TUANA\\OneDrive\\Masaüstü\\Projects\\ENabız\\ENabız\\ENabız\\mrornekleri\\AyaktaDirektBatınGrafisi.jpg",
                    HastaneAdi = "BİLECİK BOZÜYÜK DEVLET HASTANESİ",
                    Aciklama = "Ayakta direkt batın grafisi",
                    Rapor = "Yok"
                },
                new RadiologyData
                {
                    Tarih = "24.05.2023",
                    OnIzleme = "C:\\Users\\TUANA\\OneDrive\\Masaüstü\\Projects\\ENabız\\ENabız\\ENabız\\mrornekleri\\AbdominalGrafi.jpg",
                    HastaneAdi = "BİLECİK BOZÜYÜK DEVLET HASTANESİ",
                    Aciklama = "Abdominal grafi (Supin pozisyon)",
                    Rapor = "Yok"
                },
                new RadiologyData
                {
                    Tarih = "18.10.2019",
                    OnIzleme = "C:\\Users\\TUANA\\OneDrive\\Masaüstü\\Projects\\ENabız\\ENabız\\ENabız\\mrornekleri\\ElBileğiGrafiği.jpg",
                    HastaneAdi = "ESKİŞEHİR ŞEHİR HASTANESİ",
                    Aciklama = "El bileği grafisi (PA ve lateral)",
                    Rapor = "Yok"
                },
                new RadiologyData
                {
                    Tarih = "02.01.2017",
                    OnIzleme = "C:\\Users\\TUANA\\OneDrive\\Masaüstü\\Projects\\ENabız\\ENabız\\ENabız\\mrornekleri\\SakrokoksigealGrafisi.jpg",
                    HastaneAdi = "TRABZON YAVUZ SELİM KEMİK HASTANESİ",
                    Aciklama = "Sakrokoksigeal grafi (Tek yön)",
                    Rapor = "Yok"
                },
                new RadiologyData
                {
                    Tarih = "26.11.2016",
                    OnIzleme = "C:\\Users\\TUANA\\OneDrive\\Masaüstü\\Projects\\ENabız\\ENabız\\ENabız\\mrornekleri\\LumbalGrafisi.jpg",
                    HastaneAdi = "KARADENİZ TEKNİK ÜNİVERSİTESİ FARABİ HASTANESİ",
                    Aciklama = "Vertebra grafileri, lomber bölge (İki yön)",
                    Rapor = "Yok"
                },
                new RadiologyData
                {
                    Tarih = "17.06.2016",
                    OnIzleme = "C:\\Users\\TUANA\\OneDrive\\Masaüstü\\Projects\\ENabız\\ENabız\\ENabız\\mrornekleri\\SolKalçaGrafisi.jpg",
                    HastaneAdi = "ESKİŞEHİR ŞEHİR HASTANESİ",
                    Aciklama = "Sol kalça grafisi (AP)",
                    Rapor = "Yok"
                },
            };

            RadiologyDataGrid.ItemsSource = data;
        }
    }
}
