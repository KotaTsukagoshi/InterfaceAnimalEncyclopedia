using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceAnimalEncyclopedia
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> AnimalNames;
        public Form1()
        {
            InitializeComponent();
            this.AnimalNames = new Dictionary<string, string>();
            this.AnimalNames.Add("", "2");
            this.AnimalNames.Add("犬", "3");
            this.AnimalNames.Add("猫", "1");
            this.AnimalNames.Add("鳥", "2");
            foreach (KeyValuePair<string, string> data in this.AnimalNames)
            {
                comboBox1.Items.Add(data.Key);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IAnimal selectedAnimal = null;
          
            switch (comboBox1.SelectedItem.ToString())
            {
                case "犬":
                    selectedAnimal = new Dog();
                    break;
                case "猫":
                    selectedAnimal = new Cat();
                    break;
                case "鳥":
                    selectedAnimal = new Bird();
                    break;
                default:
                    MessageBox.Show("動物を選んでください。");
                    return;
            }

            label1.Text = selectedAnimal.MakeSound();
        }
    }
    
}
