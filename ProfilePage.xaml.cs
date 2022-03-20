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
    /// Interaction logic for ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        string ID { get; }
        string PASSWORD { get; }

        private System.Timers.Timer AnimationAndFunctionalityTimer;
        private double InitialUsernameFontSize = 22;
        private double InitialTitleTextBoxFontSize = 45;

        public ProfilePage(string Id, string Password)
        {
            ID = Id;
            PASSWORD = Password;

            this.KeepAlive = false;
            InitializeComponent();
        }

        private void ProfilePageLoaded(object sender, RoutedEventArgs e)
        {
            AnimationAndFunctionalityTimer = new System.Timers.Timer();
            AnimationAndFunctionalityTimer.Elapsed += AnimationAndFunctionalityTimer_Elapsed;
            AnimationAndFunctionalityTimer.Interval = 1;
            AnimationAndFunctionalityTimer.Start();


            Server_Connection<string, string, string, string, string, string> server_connection = new Server_Connection<string, string, string, string, string, string>();


            var ParallelProcessing = new System.Threading.Thread(async() =>
            {
                var retrieved_data = await server_connection.Download_Profile_Picture(ID, PASSWORD);

                Application.Current.Dispatcher.Invoke(() =>
                {
                    try
                    {
                        BitmapImage image = new BitmapImage();
                        image.BeginInit();
                        image.StreamSource = new System.IO.MemoryStream(retrieved_data);
                        image.EndInit();
                        
                        Profile_Picture.ImageSource = image;
                    }
                    catch
                    {
                       try
                       {
                          BitmapImage image = new BitmapImage(new Uri("default-picture.jpg", UriKind.RelativeOrAbsolute));

                          Profile_Picture.ImageSource = image;
                       }
                       catch
                       { }
                    }

                    UsernameTextBox.Text = "ID: " + ID;
                });
            });
            ParallelProcessing.SetApartmentState(System.Threading.ApartmentState.STA);
            ParallelProcessing.Priority = System.Threading.ThreadPriority.AboveNormal;
            ParallelProcessing.IsBackground = true;
            ParallelProcessing.Start();
            
        }

        private void AnimationAndFunctionalityTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
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

                                    Application.Current.Dispatcher.Invoke(() =>
                                    {
                                        switch(Application.Current.MainWindow == null)
                                        {
                                            case false:

                                                ProfilePictureImage.Height = HeightReference.ActualHeight * 3;
                                                ProfilePictureImage.Width = HeightReference.ActualHeight * 3;

                                                switch (Application.Current.MainWindow.WindowState)
                                                {
                                                    case WindowState.Normal:
                                                        Title_TextBlock.FontSize = InitialTitleTextBoxFontSize;
                                                        UsernameTextBox.FontSize = InitialUsernameFontSize;
                                                        break;

                                                    case WindowState.Maximized:
                                                        Title_TextBlock.FontSize = InitialTitleTextBoxFontSize * 2;
                                                        UsernameTextBox.FontSize = InitialUsernameFontSize * 2;
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

        private void Profile_Page_Size_Changed(object sender, SizeChangedEventArgs e)
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

                                           
                                            break;
                                    }

                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                try
                {
                    AnimationAndFunctionalityTimer?.Dispose();
                }
                catch { }

                GC.Collect(3, GCCollectionMode.Forced);
            }
        }

        ~ProfilePage()
        { GC.Collect(3, GCCollectionMode.Forced); }
    }
}
