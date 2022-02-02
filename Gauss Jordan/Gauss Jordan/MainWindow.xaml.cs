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

namespace Gauss_Jordan
{
    //Márquez Aranda Fernando Abdiel ITSN 201
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Double[,] Matriz = new Double[3, 4];


        private void Obtener_valores()
        {
            if (Combo3x3.IsSelected == true)
            {
                //Guardamos en las variables lo que hay en las caja de texto
                Matriz[0, 0] = Convert.ToDouble(this.Textbox1.Text);
                Matriz[0, 1] = Convert.ToDouble(this.Textbox2.Text);
                Matriz[0, 2] = Convert.ToDouble(this.Textbox3.Text);
                Matriz[0, 3] = Convert.ToDouble(this.Textbox4.Text);
                Matriz[1, 0] = Convert.ToDouble(this.Textbox5.Text);
                Matriz[1, 1] = Convert.ToDouble(this.Textbox6.Text);
                Matriz[1, 2] = Convert.ToDouble(this.Textbox7.Text);
                Matriz[1, 3] = Convert.ToDouble(this.Textbox8.Text);
                Matriz[2, 0] = Convert.ToDouble(this.Textbox9.Text);
                Matriz[2, 1] = Convert.ToDouble(this.Textbox10.Text);
                Matriz[2, 2] = Convert.ToDouble(this.Textbox11.Text);
                Matriz[2, 3] = Convert.ToDouble(this.Textbox12.Text);

            }
            else if (Combo2x2.IsSelected == true)
            {
                //Guardamos en las variables lo que hay en las caja de texto
                Matriz[0, 0] = Convert.ToDouble(this.Textbox1.Text);
                Matriz[0, 1] = Convert.ToDouble(this.Textbox2.Text);
                Matriz[0, 2] = Convert.ToDouble(this.Textbox3.Text);
                Matriz[1, 0] = Convert.ToDouble(this.Textbox5.Text);
                Matriz[1, 1] = Convert.ToDouble(this.Textbox6.Text);
                Matriz[1, 2] = Convert.ToDouble(this.Textbox7.Text);
            }
        }
        private void RevisarMatriz()
        {

        if(Combo3x3.IsSelected == true)
        { 
            while (Matriz[0,0] == 0 || Matriz[1,1] == 0 || Matriz[2,2] == 0)
            { 
            //Se compara entre la primera fila y la segunda para ver si es viable hacer la resta
            if (Matriz[0, 0] == 0 && Matriz[0, 1] != 0 && Matriz[1, 0] != 0)
            {
                    for (int m = 0; m <= 3; m++)
                    {
                        Matriz[0, m] = Matriz[0, m] - Matriz[1, m];
                    }
            }
            //Se compara entre la primera fila y la tercera para ver si es viable hacer la resta
            else if (Matriz[0, 0] == 0 && Matriz[2, 2] != 0 && Matriz[2, 0] != 0)
            {
                    for (int m = 0; m <= 3; m++)
                    {
                        Matriz[0, m] = Matriz[0, m] - Matriz[2, m];
                    }
                }
            //Se compara entre la segunda fila y la primera para ver si es viable hacer la resta
            else if (Matriz[1, 1] == 0 && Matriz[1, 0] != 0 && Matriz[0, 1] != 0)
            {
                    for (int m = 0; m <= 3; m++)
                    {
                        Matriz[1, m] = Matriz[1, m] - Matriz[0, m];
                    }
                }
            //Se compara entre la segunda fila y la primera para ver si es viable hacer la resta
            else if (Matriz[1, 1] == 0 && Matriz[1, 2] != 0 && Matriz[2, 1] != 0)
            {
                    for (int m = 0; m <= 3; m++)
                    {
                        Matriz[1, m] = Matriz[1, m] - Matriz[2, m];
                    }
                }
            //Se compara entre la tercera fila y la primera para ver si es viable hacer la resta
            else if (Matriz[2, 2] == 0 && Matriz[0, 2] != 0 && Matriz[2, 0] != 0)
            {
                    for (int m = 0; m <= 3; m++)
                    {
                        Matriz[2, m] = Matriz[2, m] - Matriz[0, m];
                    }
                }
            //Se compara entre la tercera fila y la segunda para ver si es viable hacer la resta
            else if (Matriz[2, 2] == 0 && Matriz[1, 2] != 0  && Matriz[2, 1] != 0)
            {

                    for(int m=0; m<=3; m++)
                    {
                        Matriz[2, m] = Matriz[2, m] - Matriz[1,m];
                    }
            }
            }
        }

        else if(Combo2x2.IsSelected == true)
            {
                while (Matriz[0, 0] == 0 || Matriz[1,1] == 0)
                {
                    //Se compara entre la primera fila y la segunda para ver si es viable hacer la resta
                    if (Matriz[0, 0] == 0 && Matriz[0, 1] != 0 && Matriz[1, 0] != 0)
                    {
                        for (int m = 0; m <= 3; m++)
                        {
                            Matriz[0, m] = Matriz[0, m] - Matriz[1, m];
                        }
                    }
                    //Se compara entre la segunda fila y la primera para ver si es viable hacer la resta
                    else if (Matriz[1, 1] == 0 && Matriz[1, 0] != 0 && Matriz[0, 1] != 0)
                    {
                        for (int m = 0; m <= 3; m++)
                        {
                            Matriz[1, m] = Matriz[1, m] - Matriz[0, m];
                        }
                    }
                }
            }
        }

        private void Btn_Calcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Combo3x3.IsSelected == true)
                {
                    //Los valores se definen en un arreglo bidimensional.
                    Obtener_valores();
                    /* Se hace una revisión para restar algunas filas con otras en caso de que la parte donde va uno sea 
                       igual a cero, si es posible hacerlo*/
                    RevisarMatriz();

                    //Las veces que se repitirá el proceso será igual a la cantidad de filas en la matriz 
                    for (int i = 0; i <= 2; i++)
                    {
                        //La variable i representará a la columna en la que se estara actuando 0 = fila 1; 1=fila 2 y 2= fila 3
                        /*Si el valor Matriz[0,0], Matriz[1,1] y Matriz[2,2] no es igual a 1 o 0, entonces se guardará 
                        el valor y se dividira entre la fila en curso*/
                        if (Matriz[i, i] == 0)
                        {
                            /*Si una de los renglones da cero en la parte donde va el uno entonces el sistema es incompatible.
                             Además de que es inutil dividir a las demas variables entre cero.*/
                            MessageBox.Show("El sistema es incompatible");
                        }
                        else if (Matriz[i, i] != 1)
                        {
                            Double Div = Matriz[i, i];
                            /*En esta parte se divide cada variable de la fila entre Div que representa ese espacio 
                              donde va a ir 1 en la matriz*/
                            for (int c = 0; c <= 3; c++)
                            {
                                /*Como i repesenta la fila actual y c la columna, entonces c solo llegará hasta el límite de 
                                  columnas (total de columnas en un sistema de 3x3 = 4). Cada valor de la misma fila sera 
                                  dividido entre la Matriz[i, i]*/
                                Matriz[i, c] = Matriz[i, c] / Div;
                            }
                        }

                        /*Esto es para que en la parte de la resta en lugar de tomar la fila en curso, tomará la fila siguiente 
                          para luego usar la única variable con la cual se multiplicara para la resta de filas. En caso de que se 
                          llegue a la tercera fila, el valor de la fila siguiente será 0*/
                        int Fila_next = i + 1;
                        if (Fila_next == 3) { Fila_next = 0; }

                        /*En esta parte se va por filas para resolver la matriz dependiendo de i (que cambiara a la siguiente 
                          valor al acabar el proceso)*/
                        for (int fila = 0; fila <= 1; fila++)
                        {
                            /*Se guarda en la variable múltiplo el valor que está en la fila siguiente pero de la misma columna*/
                            Double multiplo = Matriz[Fila_next, i];

                            for (int c = i; c <= 3; c++)
                            {

                                /*Se va con cada columna de la fila siguiente (en caso de que sea la tercera fila entonces la 
                                  fila siguiente vuelve a ser la primera) restando los mismos valores entre el producto 
                                  de la fila actual por el valor múltiplo del que se quiere obtener 0 */
                                Matriz[Fila_next, c] = Matriz[Fila_next, c] - (Matriz[i, c] * multiplo);
                            }

                            /*En caso de que la variable referente a la fila siguiente sea igual al número de filas 
                            existentes, entonces regresará a 0. En caso contrario se sumará 1*/
                            if (Fila_next == 2) { Fila_next = 0; }
                            else { Fila_next++; }
                        }
                    }

                    //Se guardan los datos de la ultima columna en las variables x, y, z.
                    Double x = Matriz[0, 3];
                    Double y = Matriz[1, 3];
                    Double z = Matriz[2, 3];

                    Textblock1.Text = Convert.ToString(x);
                    Textblock2.Text = Convert.ToString(y);
                    Textblock3.Text = Convert.ToString(z);
                }

                else if (Combo2x2.IsSelected == true)
                {
                    //Los valores se definen en un arreglo bidimensional.
                    Obtener_valores();
                    /* Se hace una revisión para cambiar algunas filas con otras en caso de que la parte donde va uno sea 
                       igual a cero, si es posible hacerlo*/
                    RevisarMatriz();

                    //Las veces que se repitirá el proceso será igual a la cantidad de filas en la matriz 
                    for (int i = 0; i <= 1; i++)
                    {
                        //i representará a la columna en la que se estara actuando 0 = fila 1 y 1=fila 2
                        /*Si el valor Matriz[0,0] y Matriz[1,1] no es igual a 1 o 0, entonces se guardara 
                        el valor y se dividira entre la fila en curso*/
                        if (Matriz[i, i] == 0)
                        {
                            /*Porque si una de los renglones da cero en la parte donde va el uno entonces el sistema 
                              es incompatible. Además de que es inutil dividir a las demas variables entre cero.*/
                            MessageBox.Show("El sistema es incompatible");
                        }
                        else if (Matriz[i, i] != 1)
                        {
                            Double Div = Matriz[i, i];
                            /*En esta parte se divide cada variable de la fila entre Div que representa ese espacio 
                              donde va a ir 1 en la matriz*/
                            for (int c = 0; c <= 2; c++)
                            {
                                /*Como i repesenta la fila actual y c la columna, entonces c solo llegará hasta el límite de 
                                  columnas (Total de columnas en un sistema de 2x2 = 3). Cada valor de la misma fila sera 
                                  dividido entre la Matriz[i, i]*/
                                Matriz[i, c] = Matriz[i, c] / Div;
                            }
                        }

                        /*Esto es para que en la parte de la resta en lugar de tomar la fila en curso, tomará la fila siguiente 
                          para luego usar la única variable con la cual se multiplicara para la resta de filas. En caso de que se 
                          llegue a la segunda fila, el valor de la fila siguiente será 0*/
                        int Fila_next = i + 1;
                        if (Fila_next == 2) { Fila_next = 0; }

                        /*En esta parte se va por filas para resolver la matriz de pendiendo de i, que representa la columna actual 
                          que cambiara cuando se acabe este proceso*/
                        for (int fila = 0; fila <= 0; fila++)
                        {
                            Double multiplo = Matriz[Fila_next, i];
                            /*Descarta en donde va el numero 1, Matriz[0,0] y Matriz[1,1] en la matriz procediendo 
                             * a hacer la resta.*/

                            for (int c = i; c <= 2; c++)
                            {

                                /*Se va con cada columna de la fila siguiente restando los mismos valores entre el producto de la 
                                  fila actual (en caso de que sea la segunda fila entonces la fila siguiente vuelve a ser la primera) 
                                  por el valor del que se quiere obtener 0 */
                                Matriz[Fila_next, c] = Matriz[Fila_next, c] - (Matriz[i, c] * multiplo);
                            }

                            /*En caso de que la variable referente a la fila siguiente sea igual al número de filas 
                              existentes, entonces regresará a 0. En caso contrario se sumará 1*/

                            if (Fila_next == 1) { Fila_next = 0; }
                            else { Fila_next++; }
                        }
                    }

                    //Se guardan los datos de la ultima columna en las variables x, y.
                    Double x = Matriz[0, 2];
                    Double y = Matriz[1, 2];

                    Textblock1.Text = Convert.ToString(x);
                    Textblock2.Text = Convert.ToString(y);
                }
            }
            catch
            {
                MessageBox.Show("Verifique que los datos introducidos sean correctos");
            }     
        }
        //Márquez Aranda Fernando Abdiel ITSN 201
        private void btn_Borrar_Click(object sender, RoutedEventArgs e)
        {
            Textbox1.Text = "";
            Textbox2.Text = "";
            Textbox3.Text = "";
            Textbox4.Text = "";
            Textbox5.Text = "";
            Textbox6.Text = "";
            Textbox7.Text = "";
            Textbox8.Text = "";
            Textbox9.Text = "";
            Textbox10.Text = "";
            Textbox11.Text = "";
            Textbox12.Text = "";
            Textblock1.Text = "";
            Textblock2.Text = "";
            Textblock3.Text = "";
        }

        private void Combobox_LayoutUpdated(object sender, EventArgs e)
        {
            if (Combo2x2.IsSelected == true)
            {
                Textblock_titulo.Text = "Gauss Jordan 2x2";
                lbl1.Content = "=";
                lbl2.Opacity = 0;
                lbl3.Content = "=";
                lbl4.Opacity = 0;
                lbl5.Opacity = 0;
                lbl6.Opacity = 0;
                lbl7.Opacity = 0;
                lblz.IsEnabled = false;
                Textblock3.IsEnabled = false;
                Textbox4.IsEnabled = false;
                Textbox8.IsEnabled = false;
                Textbox9.IsEnabled = false;
                Textbox10.IsEnabled = false;
                Textbox11.IsEnabled = false;
                Textbox12.IsEnabled = false;
                lblz.Opacity = 0;
                Textblock3.Opacity = 0;
                Textbox4.Opacity = 0;
                Textbox8.Opacity = 0;
                Textbox9.Opacity = 0;
                Textbox10.Opacity = 0;
                Textbox11.Opacity = 0;
                Textbox12.Opacity = 0;
            }
            else if (Combo3x3.IsSelected == true)
            {
                Textblock_titulo.Text = "Gauss Jordan 3x3";
                lblz.IsEnabled = true;
                lbl1.Content = "+";
                lbl2.Opacity = 255;
                lbl3.Content = "+";
                lbl4.Opacity = 255;
                lbl5.Opacity = 255;
                lbl6.Opacity = 255;
                lbl7.Opacity = 255;
                Textblock3.IsEnabled = true;
                Textbox4.IsEnabled = true;
                Textbox8.IsEnabled = true;
                Textbox9.IsEnabled = true;
                Textbox10.IsEnabled = true;
                Textbox11.IsEnabled = true;
                Textbox12.IsEnabled = true;
                lblz.Opacity = 229.5;
                Textblock3.Opacity = 229.5;
                Textbox4.Opacity = 229.5;
                Textbox8.Opacity = 229.5;
                Textbox9.Opacity = 229.5;
                Textbox10.Opacity = 229.5;
                Textbox11.Opacity = 229.5;
                Textbox12.Opacity = 229.5;
            }
        }

        private void Btn_info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show( "Programa simple sobre el método de Gauss Jordan.\n Creado por Márquez Aranda Fernado Abdiel (ITSN 201) \n Para más información espere hasta la siguiente actualización.","Método Gauss Jordan", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        //Márquez Aranda Fernando Abdiel ITSN 201
    }
}
