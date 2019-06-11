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
using System.Windows.Resources;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int player = 1;
        static int playerImage = 1;
        static char[] field = new char[9];


        public MainWindow()
        {
            InitializeComponent();
            protector.Visibility = Visibility.Collapsed;
            info_image.Source = DrawText(ref playerImage);

            StreamResourceInfo sri = Application.GetResourceStream(new Uri("Resources/Arrow.cur", UriKind.Relative));
            Cursor customCursor = new Cursor(sri.Stream);
            this.Cursor = customCursor;

        }





        #region FIELD EVENTS

        private void a1_label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
 
            if (a1_image.Source == null)
            {
                if(player == 1) { field[0] = 'x'; }
                else { field[0] = 'o'; }

                a1_image.Source = DrawXO(ref player);
                info_image.Source = DrawText(ref playerImage);
                WinCheck();
            }
        }

        private void b1_label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (b1_image.Source == null)
            {
                if (player == 1) { field[1] = 'x'; }
                else { field[1] = 'o'; }

                b1_image.Source = DrawXO(ref player);
                info_image.Source = DrawText(ref playerImage);
                WinCheck();
            }
        }

        private void c1_label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (c1_image.Source == null)
            {
                if (player == 1) { field[2] = 'x'; }
                else { field[2] = 'o'; }

                c1_image.Source = DrawXO(ref player);
                info_image.Source = DrawText(ref playerImage);
                WinCheck();
            }
        }

        private void a2_label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (a2_image.Source == null)
            {
                if (player == 1) { field[3] = 'x'; }
                else { field[3] = 'o'; }

                a2_image.Source = DrawXO(ref player);
                info_image.Source = DrawText(ref playerImage);
                WinCheck();
            }
        }

        private void b2_label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (b2_image.Source == null)
            {
                if (player == 1) { field[4] = 'x'; }
                else { field[4] = 'o'; }

                b2_image.Source = DrawXO(ref player);
                info_image.Source = DrawText(ref playerImage);
                WinCheck();
            }
        }

        private void c2_label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (c2_image.Source == null)
            {
                if (player == 1) { field[5] = 'x'; }
                else { field[5] = 'o'; }

                c2_image.Source = DrawXO(ref player);
                info_image.Source = DrawText(ref playerImage);
                WinCheck();
            }
        }

        private void a3_label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (a3_image.Source == null)
            {
                if (player == 1) { field[6] = 'x'; }
                else { field[6] = 'o'; }

                a3_image.Source = DrawXO(ref player);
                info_image.Source = DrawText(ref playerImage);
                WinCheck();
            }
        }

        private void b3_label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (b3_image.Source == null)
            {
                if (player == 1) { field[7] = 'x'; }
                else { field[7] = 'o'; }

                b3_image.Source = DrawXO(ref player);
                info_image.Source = DrawText(ref playerImage);
                WinCheck();
            }
        }

        private void c3_label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (c3_image.Source == null)
            {
                if (player == 1) { field[8] = 'x'; }
                else { field[8] = 'o'; }

                c3_image.Source = DrawXO(ref player);
                info_image.Source = DrawText(ref playerImage);
                WinCheck();
            }
        }

        #endregion



        public void WinCheck()
        {
            bool flag = false;
            //X
            if ((field[0] == 'x' && field[1] == 'x' && field[2] == 'x') || (field[3] == 'x' && field[4] == 'x' && field[5] == 'x') || (field[6] == 'x' && field[7] == 'x' && field[8] == 'x'))
            {
                P1Win(); flag = true;
            }
            if ((field[0] == 'x' && field[3] == 'x' && field[6] == 'x') || (field[1] == 'x' && field[4] == 'x' && field[7] == 'x') || (field[2] == 'x' && field[5] == 'x' && field[8] == 'x'))
            {
                P1Win(); flag = true;
            }
            if ((field[0] == 'x' && field[4] == 'x' && field[8] == 'x') || (field[6] == 'x' && field[4] == 'x' && field[2] == 'x'))
            {
                P1Win(); flag = true;
            }

            // O
            if ((field[0] == 'o' && field[1] == 'o' && field[2] == 'o') || (field[3] == 'o' && field[4] == 'o' && field[5] == 'o') || (field[6] == 'o' && field[7] == 'o' && field[8] == 'o'))
            {
                P2Win(); flag = true;
            }
            if ((field[0] == 'o' && field[3] == 'o' && field[6] == 'o') || (field[1] == 'o' && field[4] == 'o' && field[7] == 'o') || (field[2] == 'o' && field[5] == 'o' && field[8] == 'o'))
            {
                P2Win(); flag = true;
            }
            if ((field[0] == 'o' && field[4] == 'o' && field[8] == 'o') || (field[6] == 'o' && field[4] == 'o' && field[2] == 'o'))
            {
                P2Win(); flag = true;
            }
            if (flag == false)
            {
                // No One
                if (field[0] != '\0' && field[1] != '\0' && field[2] != '\0' && field[3] != '\0' && field[4] != '\0' && field[5] != '\0' && field[6] != '\0' && field[7] != '\0' && field[8] != '\0')
                {
                    info_image.Visibility = Visibility.Collapsed;
                    info_image2.Visibility = Visibility.Visible;
                    ngImage.Visibility = Visibility.Visible;
                    info_image2.Source = new BitmapImage(new Uri("/Resources/NoOneWin.png", UriKind.Relative));
                    ngImage.Source = new BitmapImage(new Uri("/Resources/NewGame.png", UriKind.Relative));
                }
            }
        }

        public void P1Win()
        {
            protector.Visibility = Visibility.Visible;
            info_image.Visibility = Visibility.Collapsed;
            info_image2.Visibility = Visibility.Visible;
            ngImage.Visibility = Visibility.Visible;
            info_image2.Source = new BitmapImage(new Uri("/Resources/P1_Win.png", UriKind.Relative));
            ngImage.Source = new BitmapImage(new Uri("/Resources/NewGame.png", UriKind.Relative));
        }
        public void P2Win()
        {
            protector.Visibility = Visibility.Visible;
            info_image.Visibility = Visibility.Collapsed;
            info_image2.Visibility = Visibility.Visible;
            ngImage.Visibility = Visibility.Visible;
            info_image2.Source = new BitmapImage(new Uri("/Resources/P2_Win.png", UriKind.Relative));
            ngImage.Source = new BitmapImage(new Uri("/Resources/NewGame.png", UriKind.Relative));
        }

        public void StartGame()
        {
            for (int i = 0; i < field.Length; i++)
            {
                field[i] = '\0';
            }
            a1_image.Source = null;
            a2_image.Source = null;
            a3_image.Source = null;
            b1_image.Source = null;
            b2_image.Source = null;
            b3_image.Source = null;
            c1_image.Source = null;
            c2_image.Source = null;
            c3_image.Source = null;

            protector.Visibility = Visibility.Collapsed;
            info_image2.Visibility = Visibility.Collapsed;
            ngImage.Visibility = Visibility.Collapsed;
            info_image.Visibility = Visibility.Visible;
        }


        public static BitmapImage DrawText(ref int playerImage)
        {
            BitmapImage player1 = new BitmapImage(new Uri("/Resources/Player1.png", UriKind.Relative));
            BitmapImage player2 = new BitmapImage(new Uri("/Resources/Player2.png", UriKind.Relative));

            if (playerImage == 1)
            {
                playerImage = 2;
                return player1;
            }
            else
            {
                playerImage = 1;
                return player2;
            }

        }

        public static BitmapImage DrawXO(ref int player)
        {
            #region LoadPictures
            BitmapImage[] greenO = new BitmapImage[3];
            greenO[0] = new BitmapImage(new Uri("/Resources/Green_O_1.png", UriKind.Relative));
            greenO[1] = new BitmapImage(new Uri("/Resources/Green_O_2.png", UriKind.Relative));
            greenO[2] = new BitmapImage(new Uri("/Resources/Green_O_3.png", UriKind.Relative));
            BitmapImage[] blueX = new BitmapImage[3];
            blueX[0] = new BitmapImage(new Uri("/Resources/Blue_X_1.png", UriKind.Relative));
            blueX[1] = new BitmapImage(new Uri("/Resources/Blue_X_2.png", UriKind.Relative));
            blueX[2] = new BitmapImage(new Uri("/Resources/Blue_X_3.png", UriKind.Relative));
            BitmapImage blueLine = new BitmapImage(new Uri("/Resources/Blue_Line.png", UriKind.Relative));
            BitmapImage greenLine = new BitmapImage(new Uri("/Resources/Green_Line.png", UriKind.Relative));

            #endregion

            Random random = new Random();

            if (player == 1)
            {
                player = 2;
                return blueX[random.Next(0, 3)];
            }
            else
            {
                player = 1;
                return greenO[random.Next(0, 3)];
            }

        }

        #region MAX_MIN_DRAG
        private void DragMoveLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            KNWindow.DragMove();
        }
        private void CloseLabel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }
        private void MinimizeLabel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }



        #endregion

        private void ngImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            StartGame();
        }
    }
}
