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
    /// Interaction logic for Contacts.xaml
    /// </summary>
    public partial class Contacts : Page
    {
        private string ID;
        private string PASSWORD;

        private System.Timers.Timer Functionality_Timer;

        private double Initial_Title_TextBlock_Font_Size = 30;
        private double Initial_First_Academic_Institution_Phone_Number_TextBlock_Font_Size = 20;
        private double Initial_First_Academic_Institution_Email_TextBlock_Font_Size = 20;
        private double Initial_Second_Academic_Institution_Phone_Number_TextBlock_Font_Size = 20;
        private double Initial_Second_Academic_Institution_Email_TextBlock_Font_Size = 20;

        public Contacts(string Id, string Password)
        {
            ID = Id;
            PASSWORD = Password;

            InitializeComponent();
        }

        private void Contacts_Page_Loaded(object sender, RoutedEventArgs e)
        {
            Functionality_Timer = new System.Timers.Timer();
            Functionality_Timer.Elapsed += Functionality_Timer_Elapsed;
            Functionality_Timer.Interval = 1;
            Functionality_Timer.Start();

            Load_Contacts_Info();
        }

        private void Functionality_Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
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

                                                switch(Application.Current.MainWindow.WindowState)
                                                {
                                                    case WindowState.Normal:
                                                        Title_TextBlock.FontSize = Initial_Title_TextBlock_Font_Size;
                                                        First_Academic_Institution_Phone_Number_TextBlock.FontSize = Initial_First_Academic_Institution_Phone_Number_TextBlock_Font_Size;
                                                        First_Academic_Institution_Email_TextBlock.FontSize = Initial_First_Academic_Institution_Email_TextBlock_Font_Size;
                                                        Second_Academic_Institution_Phone_Number_TextBlock.FontSize = Initial_Second_Academic_Institution_Phone_Number_TextBlock_Font_Size;
                                                        Second_Academic_Institution_Email_TextBlock.FontSize = Initial_Second_Academic_Institution_Email_TextBlock_Font_Size;
                                                        break;

                                                    case WindowState.Maximized:
                                                        Title_TextBlock.FontSize = Initial_Title_TextBlock_Font_Size * 2;
                                                        First_Academic_Institution_Phone_Number_TextBlock.FontSize = Initial_First_Academic_Institution_Phone_Number_TextBlock_Font_Size * 2;
                                                        First_Academic_Institution_Email_TextBlock.FontSize = Initial_First_Academic_Institution_Email_TextBlock_Font_Size * 2;
                                                        Second_Academic_Institution_Phone_Number_TextBlock.FontSize = Initial_Second_Academic_Institution_Phone_Number_TextBlock_Font_Size * 2;
                                                        Second_Academic_Institution_Email_TextBlock.FontSize = Initial_Second_Academic_Institution_Email_TextBlock_Font_Size * 2;
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

        private void Load_Contacts_Info()
        {
            var ParallelProcessing = new System.Threading.Thread(async () =>
            {
                string PhoneNumber1 = "Phone number: ";
                string PhoneNumber2 = "Email address: ";

                string Email1 = "Phone number: ";
                string Email2 = "Email address: ";

                Server_Connection<string, string, string, string, string, string> server_connection = new Server_Connection<string, string, string, string, string, string>();
                var retrieved_data = await server_connection.Download_Contacts(ID, PASSWORD);
                var retrieved_picture_data = await server_connection.Download_Institutions_Contact_Pictures(ID, PASSWORD);

                int Count = 0;

                switch (retrieved_data.Length > 0)
                {
                    case true:
                        switch (retrieved_data[0] != '?')
                        {
                            case true:

                                for (int Index = 0; Index <= retrieved_data.Length - 1; Index++)
                                {
                                    if (retrieved_data[Index] != '|')
                                    {
                                        if (Count == 0)
                                        {
                                            PhoneNumber1 += retrieved_data[Index];
                                        }
                                        else if (Count == 1)
                                        {
                                            Email1 += retrieved_data[Index];
                                        }
                                        else if (Count == 2)
                                        {
                                            PhoneNumber2 += retrieved_data[Index];
                                        }
                                        else if (Count == 3)
                                        {
                                            Email2 += retrieved_data[Index];
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Count++;
                                    }
                                }
                                break;
                        }
                        break;
                }

                Application.Current.Dispatcher.Invoke(() =>
                {
                    First_Academic_Institution_Phone_Number_TextBlock.Text = PhoneNumber1;
                    Second_Academic_Institution_Phone_Number_TextBlock.Text = PhoneNumber2;

                    First_Academic_Institution_Email_TextBlock.Text = Email1;
                    Second_Academic_Institution_Email_TextBlock.Text = Email2;

                    try
                    {
                        BitmapImage image1 = new BitmapImage();
                        image1.BeginInit();
                        image1.StreamSource = new System.IO.MemoryStream(retrieved_picture_data.Item1);
                        image1.EndInit();

                        First_Academic_Institution_Image.Source = image1;
                    }
                    catch { }

                    try
                    {
                        BitmapImage image2 = new BitmapImage();
                        image2.BeginInit();
                        image2.StreamSource = new System.IO.MemoryStream(retrieved_picture_data.Item2);
                        image2.EndInit();

                        Second_Academic_Institution_Image.Source = image2;
                    }
                    catch { }

                    GC.Collect(2, GCCollectionMode.Forced);
                });
            });
            ParallelProcessing.SetApartmentState(System.Threading.ApartmentState.STA);
            ParallelProcessing.Priority = System.Threading.ThreadPriority.AboveNormal;
            ParallelProcessing.IsBackground = false;
            ParallelProcessing.Start();
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
                //try
                //{
                //    AnimationAndFunctionalityTimer?.Dispose();
                //}
                //catch { }

                GC.Collect(3, GCCollectionMode.Forced);
            }
        }

        ~Contacts()
        { GC.Collect(3, GCCollectionMode.Forced); }
    }
}
