/// PokeAPI Proof-of-Concept
///
/// Gets a random Pokemon's name by a push of a button
/// Created by Viktor Berg, Brian Ly, Masaya Takahashi, and Andrew Shiroma 
/// Time due at October 24th
///
/// Github link: https://github.com/Awnder/API-Proof-of-Concept

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

        static async void GetPoke()
        {
            //used a magic number here because PokeAPI documentation does not show how many pokemon ids they have
            //I (Andrew) chose 400 as a safe number as the number of current pokmemon is around 900
            Pokemon poke = await pokeClient.GetResourceAsync<Pokemon>(rnd.Next(0, 400)); //gets pokemon by id
            pokeName = poke.Name;
        }

        private void pokeGetButton_Click(object sender, EventArgs e)
        {
            GetPoke();
            this.pokeNameTextBox.Text = pokeName;
        }
    }
}
