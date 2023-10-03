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

namespace AB_logic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Operation_CB.Items.Clear();
            Operation_CB.Items.Add("∧, •, &");
            Operation_CB.Items.Add("∨, +, ǀǀ");
            Operation_CB.Items.Add("⇒, →, ⊃");
            Operation_CB.Items.Add("⇔, ≡, ↔");
            Operation_CB.Items.Add("⊕, ⊻");
            Operation_CB.Items.Add("↓");
            Operation_CB.Items.Add("|");
            //Operation_CB.Items.Add("⯯");
        }

        private void Show(string mess)
        {
            Output_L.Content = mess;
        }

        private void Show(string mess_a, string mess_b, string operation = "None")
        {
            switch (operation)
            {
                case "∧, •, &":
                    Show(mess_a + " И " + mess_b);
                    break;
                case "∨, +, ǀǀ":
                    Show(mess_a + " ИЛИ " + mess_b);
                    break;
                case "⇒, →, ⊃":
                    Show("НЕ " + mess_a + " И " + mess_b);
                    break;
                case "⇔, ≡, ↔":
                    Show(mess_a + " И " + mess_b + " ИЛИ НЕ " + mess_a + " И НЕ " + mess_b);
                    break;
                case "⊕, ⊻":
                    Show("ЛИБО " + mess_a + ", ЛИБО " + mess_b);
                    break;
                case "↓":
                    Show("НИ " + mess_a + ", НИ " + mess_b);
                    break;
                case "|":
                    Show(mess_a + " НЕСОВМЕСТНО С " + mess_b);
                    break;
                /*case "⯯":
                    Show(mess_a + " ХЗ " + mess_b);
                    break;*/
                default:
                    Show("Заполните все поля и выберите тип операции");
                    break;
            }
        }

        private void TB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Operation_CB.SelectedIndex == -1) { return; }
            Show(A_TB.Text, B_TB.Text, Operation_CB.SelectedItem.ToString());
        }

        private void Operation_CB_DropDownClosed(object sender, EventArgs e)
        {
            if (Operation_CB.SelectedIndex == -1) { return; }
            Show(A_TB.Text, B_TB.Text, Operation_CB.SelectedItem.ToString());
        }
    }
}
