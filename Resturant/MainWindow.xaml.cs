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
using System.Collections.Generic;
using Resturant.DAL;
namespace Resturant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Button> SubCategory;
        List<Button> CategoryButtons;
        string Quantity;
        float Total;
        public MainWindow()
        {
            InitializeComponent();
            Quantity = "";
            Total = 0;
            SubCategory = new List<Button>();
            CategoryButtons = new List<Button>();
            var db = new res_for_sheratonEntities();
            var list = db.ResMainCategoryCodes.ToList();
            foreach (var item in list)
            {

                CategoryButtons.Add(new Button()
                {
                    Name = "Catbtn",
                    Content = item.MainCategoryNameA,
                    Width = 150,
                    Height = 100,
                    Margin = new Thickness(0,0 , 0, 0),
                    HorizontalAlignment = HorizontalAlignment.Right,
                    FontSize= 20,

                });
                CategoryButtons[CategoryButtons.Count - 1].Click += new RoutedEventHandler(CatbtnClick);
                CategoryMenu.Items.Add(CategoryButtons[CategoryButtons.Count - 1]);

            }
            var list1 = db.ResSubCategoryCodes.ToList();
            foreach (var item in list1)
            {
                SubCategory.Add(new Button()
                {
                    Name = "Btn",
                    Content = item.SubCategoryNameA,
                    Width = 98,
                    Height = 98,
                    Margin = new Thickness(5, 5, 0, 0),
                    HorizontalAlignment = HorizontalAlignment.Right,
                });
                SubMenu.Children.Add(SubCategory[SubCategory.Count - 1]);
                SubCategory[SubCategory.Count - 1].Click += new RoutedEventHandler(BtnClick);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void ButtonCheck_Click(object sender, RoutedEventArgs e)
        {
            ////arr.Add(new Button());
            ////arr[arr.Count - 1].Name = "Btn";
            ////arr[arr.Count - 1].Content = "فول";
            ////arr[arr.Count - 1].Width = 100;
            ////arr[arr.Count - 1].Height = 100;
            ////arr[arr.Count - 1].Margin = new Thickness(5, 5, 0, 0);
            ////SubMenu.Children.Add(arr[arr.Count - 1]);
            ////arr[arr.Count - 1].Click += new RoutedEventHandler(BtnClick);


            //CategoryButtons.Add(new Button());
            //CategoryButtons[CategoryButtons.Count - 1].Name = "Catbtn";
            //CategoryButtons[CategoryButtons.Count - 1].Content = "Catbtn";
            //CategoryButtons[CategoryButtons.Count - 1].Width = 250;
            //CategoryButtons[CategoryButtons.Count - 1].Height = 150;
            //CategoryButtons[CategoryButtons.Count - 1].Margin = new Thickness(5, 5, 0, 0);
            //CategoryButtons[CategoryButtons.Count - 1].Click += new RoutedEventHandler(CatbtnClick);
            //CategoryMenu.Items.Add(CategoryButtons[CategoryButtons.Count - 1]);

        }


        void CatbtnClick(object sender, RoutedEventArgs e)
        {
            SubCategory.Clear();
            Button t = sender as Button;
            SubMenu.Children.Clear();
            var db = new res_for_sheratonEntities();
            var id = db.ResMainCategoryCodes.Where(it => it.MainCategoryNameA == t.Content).Select(it => it.MainCategoryId).FirstOrDefault();
            var list = db.ResSubCategoryCodes.Where(i => i.MainCategoryId == id).ToList();
            foreach (var item in list)
            {
                SubCategory.Add(new Button());
                SubCategory[SubCategory.Count - 1].Name = "Btn";
                SubCategory[SubCategory.Count - 1].Content = item.SubCategoryNameA;
                SubCategory[SubCategory.Count - 1].Width = 100;
                SubCategory[SubCategory.Count - 1].Height = 100;
                SubCategory[SubCategory.Count - 1].Margin = new Thickness(5, 5, 0, 0);
                SubMenu.Children.Add(SubCategory[SubCategory.Count - 1]);
                SubCategory[SubCategory.Count - 1].Click += new RoutedEventHandler(BtnClick);
            }
        }

        void BtnClick(object sender, RoutedEventArgs e)
        {
            int minus = 0;
            if (SaladBox.IsChecked.Value) minus++;
            if (KetchupBox.IsChecked.Value) minus++;
            if (TehenaBox.IsChecked.Value) minus++;
            if (SandwichBox.IsChecked.Value) minus++;

            if (Quantity == "") Quantity = "1";
            Button tmp = sender as Button;
            BillViewCat.Items.Add(tmp.Content);
            BillViewNum.Items.Add(Quantity);
            int cost= int.Parse(Quantity)*2;
            BillViewCost.Items.Add(cost.ToString());
            Quantity = "";
            Total += cost;
            TotalPay.Content = Total.ToString();
        }

        private void QuantityBtn_Click(object sender, RoutedEventArgs e)
        {
            Button tmp = sender as Button;
            Quantity += tmp.Content;
        }

        private void QuantityBtn0_Click(object sender, RoutedEventArgs e)
        {

            Button tmp = sender as Button;
            Quantity += tmp.Content;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Button tmp = sender as Button;
            Quantity += tmp.Content;
        }

        private void QuantityBtn2_Click(object sender, RoutedEventArgs e)
        {

            Button tmp = sender as Button;
            Quantity += tmp.Content;
        }

        private void QuantityBtn3_Click(object sender, RoutedEventArgs e)
        {

            Button tmp = sender as Button;
            Quantity += tmp.Content;
        }

        private void QuantityBtn4_Click(object sender, RoutedEventArgs e)
        {

            Button tmp = sender as Button;
            Quantity += tmp.Content;
        }

        private void QuantityBtn5_Click(object sender, RoutedEventArgs e)
        {

            Button tmp = sender as Button;
            Quantity += tmp.Content;
        }

        private void QuantityBtn6_Click(object sender, RoutedEventArgs e)
        {

            Button tmp = sender as Button;
            Quantity += tmp.Content;
        }

        private void QuantityBtn7_Click(object sender, RoutedEventArgs e)
        {

            Button tmp = sender as Button;
            Quantity += tmp.Content;
        }

        private void QuantityBtn8_Click(object sender, RoutedEventArgs e)
        {

            Button tmp = sender as Button;
            Quantity += tmp.Content;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Quantity = "";
        }


    }
}
