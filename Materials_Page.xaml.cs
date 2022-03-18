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
    /// Interaction logic for Materials_Page.xaml
    /// </summary>
    public partial class Materials_Page : Page
    {
        private string ID;
        private string PASSWORD;


        private System.Threading.Thread ParallelProcessing;

        private System.Timers.Timer AnimationAndFunctionalityTimer;

        private bool Materials_Displayer_Expanded;

        private double Title_TextBlock_Initial_Font_Size = 35;

        private double Initial_Fundamentals_of_Programming_Subsection_Button_Width = 400;
        private double Initial_Fundamentals_of_Programming_Subsection_Button_Height = 200;

        private double Initial_Computer_Systems_Subsection_Button_Width = 400;
        private double Initial_Computer_Systems_Subsection_Button_Height = 200;

        private double Initial_Foundation_Project_Subsection_Button_Width = 400;
        private double Initial_Foundation_Project_Subsection_Button_Height = 200;

        private double Initial_Logical_Analisys_And_Problem_Solving_Subsection_Button_Width = 400;
        private double Initial_Logical_Analisys_And_Problem_Solving_Subsection_Button_Height = 200;

        private double Initial_Databases_Subsection_Button_Width = 400;
        private double Initial_Databases_Subsection_Button_Height = 200;

        private double Initial_Fundamentals_of_Software_Engineering_Subsection_Button_Width = 400;
        private double Initial_Fundamentals_of_Software_Engineering_Subsection_Button_Height = 200;

        private double Initial_Go_Back_Button_Font_Size = 20;
        private Thickness Initial_Go_Back_Button_Thickness = new Thickness(0, 0, 10, 0);

        private double Initial_Subject_TextBlock_FontSize = 30;

        private Thickness Initial_Week_StackPanel_Thickness = new Thickness(0, 50, 0, 0);

        private double Initial_Week_Back_Button_Font_Size = 20;

        private double Initial_Week_Displayer_TextBlock_Font_Size = 25;

        private double Initial_Week_Forward_Button_Font_Size = 20;

        private double Initial_Week_File_Button_FontSize = 20;

        private Thickness Initial_Week_File_Button_Thickness = new Thickness(0, 0, 0, 20);

        private Thickness Initial_Materials_Displayer_Go_Back_Stackpanel_Thickness = new Thickness(0, 50, 0, 0);

        private Thickness Initial_File_Dispalyer_Stackpanel_Thickness = new Thickness(0, 50, 0, 0);

        private string Subject;
        private int Week = 1;

        public Materials_Page(string Id, string Password)
        {
            this.KeepAlive = false;

            ID = Id;
            PASSWORD = Password;

            InitializeComponent();
        }

        private void Load_Fundamentals_of_Programming_Subsection_Materials(object sender, RoutedEventArgs e)
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

                                    Application.Current.Dispatcher.Invoke(() =>
                                    {
                                        switch (Application.Current.MainWindow == null)
                                        {
                                            case false:

                                                Subject_TextBlock.Text = "Subject: Fundamentals of Programming";
                                                Subject = "3";

                                                switch (Week < 10)
                                                {
                                                    case true:
                                                        Week_Displayer.Text = "Week" + Week.ToString();
                                                        Load_Material_Names(Subject, "0" + Week.ToString());
                                                        break;

                                                    case false:
                                                        Week_Displayer.Text = "Week" + Week.ToString();
                                                        Load_Material_Names(Subject, Week.ToString());
                                                        break;
                                                }

                                                Materials_Displayer_Expanded = true;
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

        private void Load_Computer_Systems_Subsection_Materials(object sender, RoutedEventArgs e)
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

                                    Application.Current.Dispatcher.Invoke(() =>
                                    {
                                        switch (Application.Current.MainWindow == null)
                                        {
                                            case false:

                                                Subject_TextBlock.Text = "Subject: Computer Systems";
                                                Subject = "0";

                                                switch (Week < 10)
                                                {
                                                    case true:
                                                        Week_Displayer.Text = "Week" + Week.ToString();
                                                        Load_Material_Names(Subject, "0" + Week.ToString());
                                                        break;

                                                    case false:
                                                        Week_Displayer.Text = "Week" + Week.ToString();
                                                        Load_Material_Names(Subject, Week.ToString());
                                                        break;
                                                }

                                                Materials_Displayer_Expanded = true;
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

        private void Load_Foundation_Project_Subsection_Materials(object sender, RoutedEventArgs e)
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

                                    Application.Current.Dispatcher.Invoke(() =>
                                    {
                                        switch (Application.Current.MainWindow == null)
                                        {
                                            case false:

                                                Subject_TextBlock.Text = "Subject: Foundation Project";
                                                Subject = "2";

                                                switch (Week < 10)
                                                {
                                                    case true:
                                                        Week_Displayer.Text = "Week" + Week.ToString();
                                                        Load_Material_Names(Subject, "0" + Week.ToString());
                                                        break;

                                                    case false:
                                                        Week_Displayer.Text = "Week" + Week.ToString();
                                                        Load_Material_Names(Subject, Week.ToString());
                                                        break;
                                                }

                                                Materials_Displayer_Expanded = true;
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

        private void Load_Logical_Analisys_And_Problem_Solving_Subsection_Materials(object sender, RoutedEventArgs e)
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

                                    Application.Current.Dispatcher.Invoke(() =>
                                    {
                                        switch (Application.Current.MainWindow == null)
                                        {
                                            case false:

                                                Subject_TextBlock.Text = "Subject: Logical Analysis and Problem Solving";
                                                Subject = "5";

                                                switch (Week < 10)
                                                {
                                                    case true:
                                                        Week_Displayer.Text = "Week" + Week.ToString();
                                                        Load_Material_Names(Subject, "0" + Week.ToString());
                                                        break;

                                                    case false:
                                                        Week_Displayer.Text = "Week" + Week.ToString();
                                                        Load_Material_Names(Subject, Week.ToString());
                                                        break;
                                                }

                                                Materials_Displayer_Expanded = true;
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

        private void Load_Databases_Subsection_Materials(object sender, RoutedEventArgs e)
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

                                    Application.Current.Dispatcher.Invoke(() =>
                                    {
                                        switch (Application.Current.MainWindow == null)
                                        {
                                            case false:

                                                Subject_TextBlock.Text = "Subject: Databases";
                                                Subject = "1";

                                                switch (Week < 10)
                                                {
                                                    case true:
                                                        Week_Displayer.Text = "Week" + Week.ToString();
                                                        Load_Material_Names(Subject, "0" + Week.ToString());
                                                        break;

                                                    case false:
                                                        Week_Displayer.Text = "Week" + Week.ToString();
                                                        Load_Material_Names(Subject, Week.ToString());
                                                        break;
                                                }

                                                Materials_Displayer_Expanded = true;
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

        private void Load_Fundamentals_of_Software_Engineering_Subsection_Materials(object sender, RoutedEventArgs e)
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

                                    Application.Current.Dispatcher.Invoke(() =>
                                    {
                                        switch (Application.Current.MainWindow == null)
                                        {
                                            case false:

                                                Subject_TextBlock.Text = "Subject: Fundamentals of Software Engineering";
                                                Subject = "4";

                                                switch (Week < 10)
                                                {
                                                    case true:
                                                        Week_Displayer.Text = "Week" + Week.ToString();
                                                        Load_Material_Names(Subject, "0" + Week.ToString());
                                                        break;

                                                    case false:
                                                        Week_Displayer.Text = "Week" + Week.ToString();
                                                        Load_Material_Names(Subject, Week.ToString());
                                                        break;
                                                }

                                                Materials_Displayer_Expanded = true;
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

        private void Go_Back_To_The_Main_Menu(object sender, RoutedEventArgs e)
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

                                    Application.Current.Dispatcher.Invoke(() =>
                                    {
                                        switch (Application.Current.MainWindow == null)
                                        {
                                            case false:
                                                Materials_Displayer_Expanded = false;
                                                Week = 1;
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

        private void Load_Material_Names(string Subject, string Week)
        {
            Week_File1.Content = String.Empty;
            Week_File2.Content = String.Empty;
            Week_File3.Content = String.Empty;
            Week_File4.Content = String.Empty;
            Week_File5.Content = String.Empty;
            Week_File6.Content = String.Empty;
            Week_File7.Content = String.Empty;
            Week_File8.Content = String.Empty;
            Week_File9.Content = String.Empty;
            Week_File10.Content = String.Empty;

            ParallelProcessing = new System.Threading.Thread(async () =>
            {
                string[] FileNames = new string[10];

                Server_Connection<string, string, string, string, string, string> server_Connection = new Server_Connection<string, string, string, string, string, string>();
                var retrieved_data = await server_Connection.Download_Subject_Materials(Subject, Week, ID, PASSWORD);

                switch((retrieved_data != String.Empty) || (retrieved_data != null))
                {
                    case true:
                        int Count = 0;

                        for (int Index = 0; Index <= retrieved_data.Length - 1; Index++)
                        {
                            if (retrieved_data[Index] != '|')
                            {
                                FileNames[Count] += retrieved_data[Index].ToString();
                            }
                            else
                            {
                                Count++;
                            }
                        }

                        Application.Current.Dispatcher.Invoke(() =>
                        {
                            Week_File1.Content = FileNames[0];
                            Week_File2.Content = FileNames[1];
                            Week_File3.Content = FileNames[2];
                            Week_File4.Content = FileNames[3];
                            Week_File5.Content = FileNames[4];
                            Week_File6.Content = FileNames[5];
                            Week_File7.Content = FileNames[6];
                            Week_File8.Content = FileNames[7];
                            Week_File9.Content = FileNames[8];
                            Week_File10.Content = FileNames[9];
                        });
                        break;
                }
            });
            ParallelProcessing.SetApartmentState(System.Threading.ApartmentState.STA);
            ParallelProcessing.Priority = System.Threading.ThreadPriority.AboveNormal;
            ParallelProcessing.IsBackground = true;
            ParallelProcessing.Start();
        }

        private void Materials_Page_Loaded(object sender, RoutedEventArgs e)
        {
            AnimationAndFunctionalityTimer = new System.Timers.Timer();
            AnimationAndFunctionalityTimer.Elapsed += AnimationAndFunctionalityTimer_Elapsed;
            AnimationAndFunctionalityTimer.Interval = 1;
            AnimationAndFunctionalityTimer.Start();

            Subject = String.Empty;
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

                                                switch (Materials_Displayer_Expanded)
                                                {
                                                    case false:
                                                        Title_TextBlock.Visibility = Visibility.Visible;
                                                        Materials_Displayer.Height = 0;
                                                        Materials_Page_Control_Stackpanel.Height = (Fundamentals_of_Programming_Subsection_Button.ActualHeight * 8) + (50 * 8);
                                                        break;

                                                    case true:
                                                        Title_TextBlock.Visibility = Visibility.Hidden;
                                                        Materials_Page_Control_Stackpanel.Height = 0;
                                                        Materials_Displayer.Height = Subject_TextBlock.ActualHeight * 30;
                                                        break;
                                                }

                                                switch (Application.Current.MainWindow.WindowState)
                                                {
                                                    case WindowState.Normal:
                                                        Title_TextBlock.FontSize = Title_TextBlock_Initial_Font_Size;

                                                        Fundamentals_of_Programming_Subsection_Button.Width = Initial_Fundamentals_of_Programming_Subsection_Button_Width;
                                                        Fundamentals_of_Programming_Subsection_Button.Height = Initial_Fundamentals_of_Programming_Subsection_Button_Height;

                                                        Computer_Systems_Subsection_Button.Width = Initial_Computer_Systems_Subsection_Button_Width;
                                                        Computer_Systems_Subsection_Button.Height = Initial_Computer_Systems_Subsection_Button_Height;

                                                        Logical_Analisys_And_Problem_Solving_Subsection_Button.Width = Initial_Logical_Analisys_And_Problem_Solving_Subsection_Button_Width;
                                                        Logical_Analisys_And_Problem_Solving_Subsection_Button.Height = Initial_Logical_Analisys_And_Problem_Solving_Subsection_Button_Height;

                                                        Foundation_Project_Subsection_Button.Width = Initial_Foundation_Project_Subsection_Button_Width;
                                                        Foundation_Project_Subsection_Button.Height = Initial_Foundation_Project_Subsection_Button_Height;

                                                        Databases_Subsection_Button.Width = Initial_Databases_Subsection_Button_Width;
                                                        Databases_Subsection_Button.Height = Initial_Databases_Subsection_Button_Height;

                                                        Fundamentals_of_Software_Engineering_Subsection_Button.Width = Initial_Fundamentals_of_Software_Engineering_Subsection_Button_Width;
                                                        Fundamentals_of_Software_Engineering_Subsection_Button.Height = Initial_Fundamentals_of_Software_Engineering_Subsection_Button_Height;



                                                        Go_Back_Button.Margin = Initial_Go_Back_Button_Thickness;
                                                        Go_Back_Button.FontSize = Initial_Go_Back_Button_Font_Size;

                                                        Subject_TextBlock.FontSize = Initial_Subject_TextBlock_FontSize;

                                                        Week_Stackpanel.Margin = Initial_Week_StackPanel_Thickness;

                                                        Week_Back.FontSize = Initial_Week_Back_Button_Font_Size;
                                                        Week_Displayer.FontSize = Initial_Week_Displayer_TextBlock_Font_Size;
                                                        Week_Forward.FontSize = Initial_Week_Forward_Button_Font_Size;

                                                        Week_File1.FontSize = Initial_Week_File_Button_FontSize;
                                                        Week_File2.FontSize = Initial_Week_File_Button_FontSize;
                                                        Week_File3.FontSize = Initial_Week_File_Button_FontSize;
                                                        Week_File4.FontSize = Initial_Week_File_Button_FontSize;
                                                        Week_File5.FontSize = Initial_Week_File_Button_FontSize;
                                                        Week_File6.FontSize = Initial_Week_File_Button_FontSize;
                                                        Week_File7.FontSize = Initial_Week_File_Button_FontSize;
                                                        Week_File8.FontSize = Initial_Week_File_Button_FontSize;
                                                        Week_File9.FontSize = Initial_Week_File_Button_FontSize;
                                                        Week_File10.FontSize = Initial_Week_File_Button_FontSize;

                                                        Week_File1.Margin = Initial_Week_File_Button_Thickness;
                                                        Week_File2.Margin = Initial_Week_File_Button_Thickness;
                                                        Week_File3.Margin = Initial_Week_File_Button_Thickness;
                                                        Week_File4.Margin = Initial_Week_File_Button_Thickness;
                                                        Week_File5.Margin = Initial_Week_File_Button_Thickness;
                                                        Week_File6.Margin = Initial_Week_File_Button_Thickness;
                                                        Week_File7.Margin = Initial_Week_File_Button_Thickness;
                                                        Week_File8.Margin = Initial_Week_File_Button_Thickness;
                                                        Week_File9.Margin = Initial_Week_File_Button_Thickness;
                                                        Week_File10.Margin = Initial_Week_File_Button_Thickness;

                                                        Materials_Displayer_Go_Back_Stackpanel.Margin = Initial_Materials_Displayer_Go_Back_Stackpanel_Thickness;

                                                        File_Dispalyer_Stackpanel.Margin = Initial_File_Dispalyer_Stackpanel_Thickness;

                                                        break;

                                                    case WindowState.Maximized:
                                                        Title_TextBlock.FontSize = Title_TextBlock_Initial_Font_Size * 2;

                                                        Fundamentals_of_Programming_Subsection_Button.Width = Initial_Fundamentals_of_Programming_Subsection_Button_Width * 2;
                                                        Fundamentals_of_Programming_Subsection_Button.Height = Initial_Fundamentals_of_Programming_Subsection_Button_Height * 2;

                                                        Computer_Systems_Subsection_Button.Width = Initial_Computer_Systems_Subsection_Button_Width * 2;
                                                        Computer_Systems_Subsection_Button.Height = Initial_Computer_Systems_Subsection_Button_Height * 2;

                                                        Logical_Analisys_And_Problem_Solving_Subsection_Button.Width = Initial_Logical_Analisys_And_Problem_Solving_Subsection_Button_Width * 2;
                                                        Logical_Analisys_And_Problem_Solving_Subsection_Button.Height = Initial_Logical_Analisys_And_Problem_Solving_Subsection_Button_Height * 2;

                                                        Foundation_Project_Subsection_Button.Width = Initial_Foundation_Project_Subsection_Button_Width * 2;
                                                        Foundation_Project_Subsection_Button.Height = Initial_Foundation_Project_Subsection_Button_Height * 2;

                                                        Databases_Subsection_Button.Width = Initial_Databases_Subsection_Button_Width * 2;
                                                        Databases_Subsection_Button.Height = Initial_Databases_Subsection_Button_Height * 2;

                                                        Fundamentals_of_Software_Engineering_Subsection_Button.Width = Initial_Fundamentals_of_Software_Engineering_Subsection_Button_Width * 2;
                                                        Fundamentals_of_Software_Engineering_Subsection_Button.Height = Initial_Fundamentals_of_Software_Engineering_Subsection_Button_Height * 2;



                                                        Go_Back_Button.Margin = new Thickness(0,0,20,0);
                                                        Go_Back_Button.FontSize = Initial_Go_Back_Button_Font_Size * 2;

                                                        Subject_TextBlock.FontSize = Initial_Subject_TextBlock_FontSize * 2;

                                                        Week_Stackpanel.Margin = new Thickness(0, 100, 0, 0);

                                                        Week_Back.FontSize = Initial_Week_Back_Button_Font_Size * 2;
                                                        Week_Displayer.FontSize = Initial_Week_Displayer_TextBlock_Font_Size * 2;
                                                        Week_Forward.FontSize = Initial_Week_Forward_Button_Font_Size * 2;


                                                        Week_File1.FontSize = Initial_Week_File_Button_FontSize * 2;
                                                        Week_File2.FontSize = Initial_Week_File_Button_FontSize * 2;
                                                        Week_File3.FontSize = Initial_Week_File_Button_FontSize * 2;
                                                        Week_File4.FontSize = Initial_Week_File_Button_FontSize * 2;
                                                        Week_File5.FontSize = Initial_Week_File_Button_FontSize * 2;
                                                        Week_File6.FontSize = Initial_Week_File_Button_FontSize * 2;
                                                        Week_File7.FontSize = Initial_Week_File_Button_FontSize * 2;
                                                        Week_File8.FontSize = Initial_Week_File_Button_FontSize * 2;
                                                        Week_File9.FontSize = Initial_Week_File_Button_FontSize * 2;
                                                        Week_File10.FontSize = Initial_Week_File_Button_FontSize * 2;

                                                        Week_File1.Margin = new Thickness(0, 0, 0, 40);
                                                        Week_File2.Margin = new Thickness(0, 0, 0, 40);
                                                        Week_File3.Margin = new Thickness(0, 0, 0, 40);
                                                        Week_File4.Margin = new Thickness(0, 0, 0, 40);
                                                        Week_File5.Margin = new Thickness(0, 0, 0, 40);
                                                        Week_File6.Margin = new Thickness(0, 0, 0, 40);
                                                        Week_File7.Margin = new Thickness(0, 0, 0, 40);
                                                        Week_File8.Margin = new Thickness(0, 0, 0, 40);
                                                        Week_File9.Margin = new Thickness(0, 0, 0, 40);
                                                        Week_File10.Margin = new Thickness(0, 0, 0, 40);

                                                        Materials_Displayer_Go_Back_Stackpanel.Margin = new Thickness(0, 100, 0, 0);

                                                        File_Dispalyer_Stackpanel.Margin = new Thickness(0, 100, 0, 0);

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
                    Week = 1;
                    
                    AnimationAndFunctionalityTimer?.Stop();
                    AnimationAndFunctionalityTimer?.Dispose();
                }
                catch { }

                GC.Collect(3, GCCollectionMode.Forced);
            }
        }

        ~Materials_Page()
        { GC.Collect(3, GCCollectionMode.Forced); }

        private void Week_Back_Clicked(object sender, RoutedEventArgs e)
        {

            switch (Week > 1)
            {
                case true:
                    Week--;

                    switch (Week < 10)
                    {
                        case true:
                            Week_Displayer.Text = "Week" + Week.ToString();
                            Load_Material_Names(Subject, "0" + Week.ToString());
                            break;

                        case false:
                            Week_Displayer.Text = "Week" + Week.ToString();
                            Load_Material_Names(Subject, Week.ToString());
                            break;
                    }

                    break;
            }
        }

        private void Week_Forward_Clicked(object sender, RoutedEventArgs e)
        {

            switch (Week < 30)
            {
                case true:
                    Week++;

                    switch (Week < 10)
                    {
                        case true:
                            Week_Displayer.Text = "Week" + Week.ToString();
                            Load_Material_Names(Subject, "0" + Week.ToString());
                            break;

                        case false:
                            Week_Displayer.Text = "Week" + Week.ToString();
                            Load_Material_Names(Subject, Week.ToString());
                            break;
                    }

                    break;
            }
           
        }

        private void Download_Material(object sender, RoutedEventArgs e)
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

                                    Application.Current.Dispatcher.Invoke(() =>
                                    {
                                        switch (Application.Current.MainWindow == null)
                                        {
                                            case false:

                                                var Button = (Button)sender;
                                                var FileName = Button.Content.ToString();

                                                var parallelProcessing = new System.Threading.Thread(async () =>
                                                {
                                                    string Processed_Week = String.Empty;

                                                    switch (Week < 10)
                                                    {
                                                        case true:
                                                            Processed_Week = "0" + Week.ToString();
                                                            break;

                                                        case false:
                                                            Processed_Week = Week.ToString();
                                                            break;
                                                    }


                                                   



                                                    

                                                    using (var SaveFile = new System.Windows.Forms.SaveFileDialog())
                                                    {
                                                        SaveFile.FileName = FileName;

                                                        switch (SaveFile.ShowDialog())
                                                        {
                                                            case System.Windows.Forms.DialogResult.OK:

                                                            
                                                                using (var File = System.IO.File.Open(SaveFile.FileName, System.IO.FileMode.Create))
                                                                {
                                                                    using (var Write_Binary_Data_To_File = new System.IO.BinaryWriter(File))
                                                                    {
                                                                        Server_Connection<string, string, string, string, string, string> server_Connection = new Server_Connection<string, string, string, string, string, string>();
                                                                        var retrieved_data = await server_Connection.Download_Material_File(Subject, Processed_Week, FileName, ID, PASSWORD);

                                                                        Write_Binary_Data_To_File.Write(retrieved_data);
                                                                        Write_Binary_Data_To_File.Flush();
                                                                        Write_Binary_Data_To_File.Close();
                                                                    }
                                                                    
                                                                }
                                                                break;
                                                        }
                                                    }
                                                });
                                                parallelProcessing.SetApartmentState(System.Threading.ApartmentState.STA);
                                                parallelProcessing.Priority = System.Threading.ThreadPriority.Highest;
                                                parallelProcessing.IsBackground = false;
                                                parallelProcessing.Start();

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
    }
}
