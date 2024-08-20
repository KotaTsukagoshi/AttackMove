using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AttackMove
{
    public partial class Form1 : Form
    {
        private string selectedAttack;

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("剣");
            comboBox1.Items.Add("魔法");
            comboBox1.Items.Add("弓");

            selectedAttack = "剣";  // 初期選択
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "剣":
                    selectedAttack = "剣で攻撃した！";
                    break;
                case "魔法":
                    selectedAttack = "魔法を使った！";
                    break;
                case "弓":
                    selectedAttack = "弓で攻撃した！";
                    break;
            }

            MessageBox.Show(selectedAttack);
        }
    }
    //IAttackインターフェース
    public interface IAttack
    {
        string Attack();
    }
}
