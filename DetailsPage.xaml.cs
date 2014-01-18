using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using DataBoundApp1.Resources;
using Microsoft.Phone.Tasks;

namespace DataBoundApp1
{
    public partial class DetailsPage : PhoneApplicationPage
    {
        // Constructor
        public DetailsPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            BuildLocalizedApplicationBar();
        }

        // When page is navigated to set data context to selected item in list
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (DataContext == null)
            {
                string selectedIndex = "";
                if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
                {
                    int index = int.Parse(selectedIndex);
                    DataContext = App.ViewModel.Items[index];
                }
            }
        }

        private void BuildLocalizedApplicationBar()
        {
            // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();

            // Create a new button and set the text value to the localized string from AppResources.
            ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/feature.calendar.png", UriKind.Relative));
            appBarButton.Text = "Bilet satın al";
            ApplicationBar.Buttons.Add(appBarButton);

            // Create a new menu item with the localized string from AppResources.

            ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem("Bilet satın al");
            ApplicationBarMenuItem appBarMenuItem1 = new ApplicationBarMenuItem("Yardım");

            ApplicationBar.MenuItems.Add(appBarMenuItem);
            ApplicationBar.MenuItems.Add(appBarMenuItem1);

            appBarButton.Click += appBarButton_Click;
            appBarMenuItem.Click += appBarMenuItem_Click;
            appBarMenuItem1.Click += appBarMenuItem1_Click;
        }

        private void appBarMenuItem1_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));

        }

        private void appBarMenuItem_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));

        }

        private void appBarButton_Click(object sender, EventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask();
    
            webBrowserTask.Uri = new Uri("https://etcdd.tcdd.gov.tr/tcddrezwebapproot/nettcddservlet?cmd=defaultuser");
    
            webBrowserTask.Show(); 
        }
    }
}