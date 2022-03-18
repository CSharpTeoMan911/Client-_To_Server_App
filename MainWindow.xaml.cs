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

namespace Client__To_Server_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string ID { get; }
        private string PASSWORD { get; }

        private System.Timers.Timer AnimationAndFunctionalityTimer;

        private ProfilePage profilePage;
        private GradesPage gradesPage;
        private Materials_Page materialsPage;
        private Contacts contactsPage;

        private double InitialHeight;
        private double initialWidth;

        private byte NormalisedOrMaximised;
        public static bool WindowClosing;

        private byte ExpandOrContract;
        private bool MainMenuExpanded;
        
        public MainWindow(string Id, string Password)
        {
            WindowClosing = false;
            ID = Id;
            PASSWORD = Password;

            profilePage = new ProfilePage(Id, Password);
            gradesPage = new GradesPage(Id, Password);
            materialsPage = new Materials_Page(Id, Password);
            contactsPage = new Contacts(Id, Password);

           
           
            InitializeComponent();
        }


        private void MoveTheWindow(object sender, MouseButtonEventArgs e)
        {
            switch (WindowClosing)
            {
                case false:

                    switch (Application.Current == null)
                    {

                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {

                                case false:

                                    switch (Application.Current.MainWindow == null)
                                    {
                                        case false:
                                            this.DragMove();
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void MinimiseTheWindow(object sender, RoutedEventArgs e)
        {
            switch(WindowClosing)
            {
                case false:

                    switch(Application.Current == null)
                    {

                        case false:

                            switch(Application.Current.Dispatcher.HasShutdownStarted)
                            {

                                case false:

                                    switch(Application.Current.MainWindow == null)
                                    {
                                        case false:
                                            Application.Current.MainWindow.WindowState = WindowState.Minimized; 
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void NormaliseOrMaximiseTheWindow(object sender, RoutedEventArgs e)
        {
            switch (WindowClosing)
            {
                case false:

                    switch (Application.Current == null)
                    {

                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {

                                case false:

                                    switch (Application.Current.MainWindow == null)
                                    {
                                        case false:
                                            NormalisedOrMaximised++;

                                            switch(NormalisedOrMaximised)
                                            {
                                                case 1:
                                                    NormaliseOrMaximiseTheWindowButton.Content = "\xEF2F";
                                                    Application.Current.MainWindow.WindowState = WindowState.Maximized;
                                                    break;

                                                case 2:
                                                    NormaliseOrMaximiseTheWindowButton.Content = "\xEF2E";
                                                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                                                    NormalisedOrMaximised = 0;
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void CloseTheWindow(object sender, RoutedEventArgs e)
        {
            switch (WindowClosing)
            {
                case false:

                    switch (Application.Current == null)
                    {

                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {

                                case false:

                                    switch (Application.Current.MainWindow == null)
                                    {
                                        case false:
                                            this.Close();
                                            Application.Current.Shutdown();
                                            Environment.Exit(0);
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void Window_Is_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            WindowClosing = true;
        }

        private void ExpandTheMainMenu(object sender, RoutedEventArgs e)
        {
            switch (WindowClosing)
            {
                case false:

                    switch (Application.Current == null)
                    {

                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {

                                case false:

                                    switch (Application.Current.MainWindow == null)
                                    {
                                        case false:

                                            ExpandOrContract++;

                                            switch(ExpandOrContract)
                                            {
                                                case 1:
                                                    MainMenuExpanded = true;
                                                    break;

                                                case 2:
                                                    MainMenuExpanded = false;
                                                    ExpandOrContract = 0;
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitialHeight = HeightReference.ActualHeight;
            initialWidth = WidthReference.ActualWidth;

            AnimationAndFunctionalityTimer = new System.Timers.Timer();
            AnimationAndFunctionalityTimer.Elapsed += AnimationAndFunctionalityTimer_Elapsed;
            AnimationAndFunctionalityTimer.Interval = 10;
            AnimationAndFunctionalityTimer.Start();

            switch (Functionality_Mainframe.NavigationService.CanGoBack)
            {
                case true:
                    Functionality_Mainframe.NavigationService.RemoveBackEntry();
                    break;
            }
            Functionality_Mainframe.Navigate(profilePage);
        }

        private void AnimationAndFunctionalityTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            switch (WindowClosing)
            {
                case true:
                    try
                    {
                        AnimationAndFunctionalityTimer?.Stop();
                    }
                    catch { }
                    break;

                case false:

                    switch (Application.Current == null)
                    {
                        case true:
                            try
                            {
                                AnimationAndFunctionalityTimer?.Stop();
                            }
                            catch { }
                            break;

                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case true:
                                    try
                                    {
                                        AnimationAndFunctionalityTimer?.Stop();
                                    }
                                    catch { }
                                    break;

                                case false:

                                    Application.Current.Dispatcher.Invoke(() =>
                                    {
                                       

                                        switch (Application.Current.MainWindow == null)
                                        {
                                            case true:
                                                try
                                                {
                                                    AnimationAndFunctionalityTimer?.Stop();
                                                }
                                                catch { }
                                                break;

                                            case false:

                                               

                                                switch(MainMenuExpanded)
                                                {
                                                    case true:

                                                        switch(Menu_Stackpanel.ActualHeight <= InitialHeight * 4)
                                                        {
                                                            case true:
                                                                try
                                                                {
                                                                    Menu_Stackpanel.Height++;
                                                                    Menu_Stackpanel.Height++;
                                                                    Menu_Stackpanel.Height++;
                                                                    Menu_Stackpanel.Height++;
                                                                    Menu_Stackpanel.Height++;
                                                                    Menu_Stackpanel.Height++;
                                                                    Menu_Stackpanel.Height++;
                                                                    Menu_Stackpanel.Height++;
                                                                    Menu_Stackpanel.Height++;
                                                                    Menu_Stackpanel.Height++;
                                                                }
                                                                catch { }
                                                                break;
                                                        }

                                                        break;

                                                    case false:

                                                        switch(Menu_Stackpanel.Height > 0)
                                                        {
                                                            case true:
                                                                try
                                                                {
                                                                    Menu_Stackpanel.Height--;
                                                                    Menu_Stackpanel.Height--;
                                                                    Menu_Stackpanel.Height--;
                                                                    Menu_Stackpanel.Height--;
                                                                    Menu_Stackpanel.Height--;
                                                                    Menu_Stackpanel.Height--;
                                                                    Menu_Stackpanel.Height--;
                                                                    Menu_Stackpanel.Height--;
                                                                    Menu_Stackpanel.Height--;
                                                                    Menu_Stackpanel.Height--;
                                                                }
                                                                catch { }
                                                                
                                                                break;
                                                        }
                                                        break;
                                                }
                                                break;
                                        }
                                    });
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void Profile_Section(object sender, RoutedEventArgs e)
        {
            switch(MainWindow.WindowClosing)
            {
                case false:

                    switch(Application.Current == null)
                    {
                        case false:

                            switch(Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch(Application.Current.MainWindow == null)
                                    {
                                        case false:
                                            switch (Functionality_Mainframe.NavigationService.CanGoBack)
                                            {
                                                case true:
                                                    Functionality_Mainframe.NavigationService.RemoveBackEntry();
                                                    break;
                                            }
                                            Functionality_Mainframe.Navigate(profilePage);
                                            gradesPage.Dispose();
                                            contactsPage.Dispose();
                                            materialsPage.Dispose();
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void Grades_Section(object sender, RoutedEventArgs e)
        {
            switch (MainWindow.WindowClosing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch (Application.Current.MainWindow == null)
                                    {
                                        case false:
                                            switch (Functionality_Mainframe.NavigationService.CanGoBack)
                                            {
                                                case true:
                                                    Functionality_Mainframe.NavigationService.RemoveBackEntry();
                                                    break;
                                            }
                                            Functionality_Mainframe.Navigate(gradesPage);
                                            profilePage.Dispose();
                                            contactsPage.Dispose();
                                            materialsPage.Dispose();
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void Materials_Section(object sender, RoutedEventArgs e)
        {
            switch (MainWindow.WindowClosing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch (Application.Current.MainWindow == null)
                                    {
                                        case false:
                                            switch (Functionality_Mainframe.NavigationService.CanGoBack)
                                            {
                                                case true:
                                                    Functionality_Mainframe.NavigationService.RemoveBackEntry();
                                                    break;
                                            }
                                            Functionality_Mainframe.Navigate(materialsPage);
                                            profilePage.Dispose();
                                            gradesPage.Dispose();
                                            contactsPage.Dispose();
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void Contacts_Section(object sender, RoutedEventArgs e)
        {
            switch (MainWindow.WindowClosing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch (Application.Current.MainWindow == null)
                                    {
                                        case false:
                                            switch (Functionality_Mainframe.NavigationService.CanGoBack)
                                            {
                                                case true:
                                                    Functionality_Mainframe.NavigationService.RemoveBackEntry();
                                                    break;
                                            }
                                            Functionality_Mainframe.Navigate(contactsPage);
                                            profilePage.Dispose();
                                            gradesPage.Dispose();
                                            materialsPage.Dispose();
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void Log_Out_Section(object sender, RoutedEventArgs e)
        {
            switch (MainWindow.WindowClosing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch (Application.Current.MainWindow == null)
                                    {
                                        case false:

                                            var ParallelProcessing = new System.Threading.Thread(() =>
                                            {
                                                Server_Connection<string, string, string, string, string, string> server_Connection = new Server_Connection<string, string, string, string, string, string>();
                                                server_Connection.Log_Out(ID, PASSWORD);
                                            });
                                            ParallelProcessing.SetApartmentState(System.Threading.ApartmentState.STA);
                                            ParallelProcessing.Priority = System.Threading.ThreadPriority.AboveNormal;
                                            ParallelProcessing.IsBackground = true;
                                            ParallelProcessing.Start();

                                            Log_In_Window log_In_Window = new Log_In_Window();
                                            log_In_Window.Show();
                                            this.Close();
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
