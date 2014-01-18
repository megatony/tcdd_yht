using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using DataBoundApp1.Resources;

namespace DataBoundApp1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        /// <summary>
        /// Sample property that returns a localized string
        /// </summary>
        public string LocalizedSampleProperty
        {
            get
            {
                return AppResources.SampleProperty;
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            // Sample data; replace with real data
            //this.Items.Add(new ItemViewModel() { ID = "0", LineOne = "Bilet Satın Al", LineTwo = "Bilet satın al", LineThree = "" });
            this.Items.Add(new ItemViewModel() { ID = "0", LineOne = "Eskişehir-Ankara", LineTwo = "YHT Sefer Saatleri", LineThree = "Eskişehir K:06.45-Ankara V:08.15 (Polatlı V:07.34 Sincan V:07.53)\n\nEskişehir K:07.45-Ankara V:09.15 (Polatlı V:08.34 Sincan V:08.53)\n\nEskişehir K:09.00-Ankara V:10.30 (Polatlı V:09.49 Sincan duruş yok)\n\nEskişehir K:11.15-Ankara V:12.45 (Polatlı V:12.05 Sincan V:12.24)\n\nEskişehir K:12.45-Ankara V:14.15 (Polatlı duruş yok Sincan V:13.54)\n\nEskişehir K:15.00-Ankara V:16.30 (Polatlı V:15.50 Sincan V:16.09)\n\nEskişehir K:16.35-Ankara V:18.05 (Polatlı V:17.24 Sincan V:17.44)\n\nEskişehir K:18.15-Ankara V:19.45 (Polatlı duruş yok Sincan V:19.24)\n\nEskişehir K:19.00-Ankara V:20.30 (Polatlı V:19.50 Sincan V:20.09)\n\nEskişehir K.21.00-Ankara V:22.30 (Polatlı duruş yok Sincan V:22.09)" });
            this.Items.Add(new ItemViewModel() { ID = "1", LineOne = "Ankara-Eskişehir", LineTwo = "YHT Sefer Saatleri", LineThree = "Ankara K:06.45-Eskişehir V:08.15 (Sincan K:07.06 Polatlı K:07.24)\n\nAnkara K:08.10-Eskişehir V:09.40 (Sincan K:08.31 Polatlı K:08.49)\n\nAnkara K:09.10-Eskişehir V:10.40 (Sincan-Polatlı duruşu yok)\n\nAnkara K:11.00-Eskişehir V:12.30 (Sincan K:11.21 Polatlı K:11.39)\n\nAnkara K:12.45-Eskişehir V:14.15 (Sincan K:13.06 Polatlı duruş yok)\n\nAnkara K:15.00-Eskişehir V:16.30 (Sincan K:15.21 Polatlı K:15.39)\n\nAnkara K:16.30-Eskişehir V:18.00 (Sincan K:16.51 Polatlı duruş yok)\n\nAnkara K:18.00-Eskişehir V:19.30 (Sincan K:18.21 Polatlı duruş yok)\n\nAnkara K:19.00-Eskişehir V:20.30 (Sincan K:19.21 Polatlı K:19.39)\n\nAnkara K:21.00-Eskişehir V:22.30 (Sincan K:21.21 Polatlı duruş yok)" });
            this.Items.Add(new ItemViewModel() { ID = "2", LineOne = "Eskişehir-Konya", LineTwo = "YHT Sefer Saatleri", LineThree = "Eskişehir K:08.00 - Konya V:10.00\n\nEskişehir K:16.00 - Konya V:18.00" });
            this.Items.Add(new ItemViewModel() { ID = "3", LineOne = "Konya-Eskişehir", LineTwo = "YHT Sefer Saatleri", LineThree = "Konya K:09.35 - Eskişehir V:11.35\n\nKonya K:18.55 - Eskişehir V:20.55" });
            this.Items.Add(new ItemViewModel() { ID = "4", LineOne = "Ankara-Konya", LineTwo = "YHT Sefer Saatleri", LineThree = "Ankara K:07.00-Konya V:08.52 (Sincan K:07.21 Polatlı duruş yok)\n\nAnkara K:09.35-Konya V:11.30 (Sincan K:09.56 Polatlı K:10.17)\n\nAnkara K:11.20-Konya V:13.10 (Sincan-Polatlı duruş yok.)\n\nAnkara K:13.00-Konya V:14.52 (Sincan K:13.21 Polatlı duruş yok.)\n\nAnkara K:15.30-Konya V:17.22 (Sincan K:15:51 Polatlı duruş yok.)\n\nAnkara K:17.00-Konya V:18.50 (Sincan-Polatlı duruş yok.)\n\nAnkara K:18.30-Konya V:20.25 (Sincan K:18.51 Polatlı K:19.12)\n\nAnkara K:20.45-Konya V:22.40 (Sincan K:21.06 Polatlı K:21.27)\n\nANKARA-KONYA-KARAMAN YHT+DMU SETİ SAATLERİ:\n\nAnkara'dan 07.00'da kalkan yhtye bağlantı= Konya K:09.15 Karaman V:10.23\n\nAnkara'dan 09.35'de kalkan yhtye bağlantı= Konya K:12.05 Karaman V:13.14\n\nAnkara'dan 15.30'da kalkan yhtye bağlantı= Konya K:17.30 Karaman V:18.37"});
            this.Items.Add(new ItemViewModel() { ID = "5", LineOne = "Konya-Ankara", LineTwo = "YHT Sefer Saatleri", LineThree = "Konya K:07.00-Ankara V:08.50 (Polatlı duruşu yok Sincan V:08.29)\n\nKonya K:08.30-Ankara V:10.21 (Polatlı V:09.40 Sincan V:10.00)\n\nKonya K:10.30-Ankara V:12.15 (Polatlı-Sincan duruş yok)\n\nKonya K:12.15-Ankara V:14.02 (Polatlı duruşu yok Sincan V:13.41)\n\nKonya K:14.30-Ankara V:16.21 (Polatlı V:15.40 Sincan V:16.00)\n\nKonya K:16.00-Ankara V:17.45 (Polatlı-Sincan duruşu yok)\n\nKonya K:18.15-Ankara V:20.06 (Polatlı V:19.25 Sincan V:19.45)\n\nKonya K:20.30-Ankara V:22.21 (Polatlı V:21.40 Sincan V:22.00)\n\nKARAMAN-KONYA-ANKARA YHT+DMU SETİ SAATLERİ:\n\nKaraman K:10.45 Konya V:11.50 /Konya'dan 12.15 kalkan yhtye bağlantı\n\nKaraman K:14.25 Konya V:15.31 /Konya'dan 16.00 kalkan yhtye bağlantı\n\nKaraman K:19.00 Konya V:20.06 /Konya'dan 20.30 kalkan yhtye bağlantı" });
            //this.Items.Add(new ItemViewModel() { ID = "7", LineOne = "runtime eight", LineTwo = "Nascetur pharetra placerat pulvinar", LineThree = "Pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum" });
            //this.Items.Add(new ItemViewModel() { ID = "8", LineOne = "runtime nine", LineTwo = "Maecenas praesent accumsan bibendum", LineThree = "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu" });
            //this.Items.Add(new ItemViewModel() { ID = "9", LineOne = "runtime ten", LineTwo = "Dictumst eleifend facilisi faucibus", LineThree = "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus" });
            //this.Items.Add(new ItemViewModel() { ID = "10", LineOne = "runtime eleven", LineTwo = "Habitant inceptos interdum lobortis", LineThree = "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent" });
            //this.Items.Add(new ItemViewModel() { ID = "11", LineOne = "runtime twelve", LineTwo = "Nascetur pharetra placerat pulvinar", LineThree = "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos" });
            //this.Items.Add(new ItemViewModel() { ID = "12", LineOne = "runtime thirteen", LineTwo = "Maecenas praesent accumsan bibendum", LineThree = "Maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur" });
            //this.Items.Add(new ItemViewModel() { ID = "13", LineOne = "runtime fourteen", LineTwo = "Dictumst eleifend facilisi faucibus", LineThree = "Pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent" });
            //this.Items.Add(new ItemViewModel() { ID = "14", LineOne = "runtime fifteen", LineTwo = "Habitant inceptos interdum lobortis", LineThree = "Accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat" });
            //this.Items.Add(new ItemViewModel() { ID = "15", LineOne = "runtime sixteen", LineTwo = "Nascetur pharetra placerat pulvinar", LineThree = "Pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum" });

            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}