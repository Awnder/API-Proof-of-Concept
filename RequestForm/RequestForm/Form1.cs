///PokeAPI Proof-of-Concept
///
///Created by Viktor Berg, Brian Ly, Masaya Takahashi, and Andrew Shiroma 
///Time due at October 24th
///
///Github link: https://github.com/Awnder/API-Proof-of-Concept

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PokeApiNet;

namespace RequestForm
{
    public partial class Form1 : Form
    {
        static PokeApiClient pokeClient = new PokeApiClient();
        static Random rnd = new Random();
        static string pokeName;

        public Form1()
        {
            InitializeComponent();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetPoke();
            this.pokeNameTextBox.Text = pokeName;
        }

        static async void GetPoke()
        {
            Pokemon poke = await pokeClient.GetResourceAsync<Pokemon>(rnd.Next(0, 400));
            pokeName = poke.Name;
        }
    }
}
