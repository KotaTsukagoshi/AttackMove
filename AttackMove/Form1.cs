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
        private Character character;

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("剣");
            comboBox1.Items.Add("魔法");
            comboBox1.Items.Add("弓");

            character = new Character("勇者", new SwordAttack());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //switch文null時用
            if (comboBox1.SelectedItem != null)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "剣":
                        character.AttackType = new SwordAttack();
                        break;
                    case "魔法":
                        character.AttackType = new MagicAttack();
                        break;
                    case "弓":
                        character.AttackType = new BowAttack();
                        break;
                }

                string result = character.PerformAttack();
                MessageBox.Show(result);
            }

            //nullなら抜ける
            else { return; }
        }
    }
    //IAttackインターフェース
    public interface IAttack
    {
        string Attack();
    }
}
