using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace WpfDonuts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public delegate void orderDelagate(Order order);
        //public delegate double calculateTotalDelegate(Order order);
        //public delegate double calculateIncomeDelegate(List<Order> lo);

        List<Order> ordersList = new List<Order>();

        //// Calculate total anonymous method
        //calculateTotalDelegate c = delegate (Order or)
        //{
        //    return ((or.Coffee * 19.95) + (or.Donuts * 29.95));
        //};

        //// Calculate total anonymous method
        //calculateIncomeDelegate ci = delegate (List<Order> lOrders)
        //{
        //    double sum = 0;
        //    foreach (Order od in lOrders)
        //    {
        //        sum += ((od.Coffee * 19.95) + (od.Donuts * 29.95));

        //    }
        //    return sum;
        //};

        public MainWindow()
        {
            InitializeComponent();
            lvOrders.ItemsSource = ordersList;

        }

        public void Odercollection(Order order)
        {
            if (order.coffeeReady == true && order.donutsReady == true)
            {
                MessageBox.Show(order.Name + " is ready for collection");
            }
        }

        public void saveToDB(Order order)
        {
            MessageBox.Show("Save to DB");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txbName.Text;
            string phone = txbPhone.Text;
            int donuts = Convert.ToInt32(txbDonuts.Text);
            int coffee = Convert.ToInt32(txbCoffee.Text);

            Order order = new Order(name, phone, donuts, coffee);
            ordersList.Add(order);




            //List<System.Windows.Controls.ValidationResult> validationResults = new List<System.Windows.Controls.ValidationResult>();
            //ValidationContext criteria = new ValidationContext(order);
            //bool validCheck = Validator.TryValidateObject(order, criteria, (ICollection<System.ComponentModel.DataAnnotations.ValidationResult>)validationResults, true);
            //if (!validCheck)
            //{
            //    foreach (System.Windows.Controls.ValidationResult result in validationResults)
            //    {
            //        MessageBox.Show(result.ErrorContent.ToString());
            //    }
            //}
            //else
            //{
                //orderDelagate placedOder = new orderDelagate(Odercollection);
                //placedOder += saveToDB;

                //ProcessOrder.Barista(order, placedOder);
                //ProcessOrder.Donuteer(order, placedOder);

                //// Invoking the calculateTotalDelegate 
                //MessageBox.Show(c(order).ToString());

                //// Invoking the calculateIncomeDelegate
                //List<Order> lo = new List<Order>();
                //MessageBox.Show(ci(lo).ToString());
            //}


        }
    }
}
