using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McArthurJA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Whenever the serach button is clicked a new Cereals class is created to run a set of Querys on.
        //The search resets the Listbox to show the new entries.
        //Checks each component of the search Query and will run the query if there is a item in the search.
        //Will then add each resulting Query item to the Listbox and display the items.
        private void searchButton_Click(object sender, EventArgs e)
        {
            Cereals cereals = new Cereals();
            resultsListBox.Items.Clear();

            cereals.cereals = BrandSearch(cereals, BrandTextBox.Text);
            if (MfrTextBox.Text != "")
                cereals.cereals = MfrSearch(cereals, MfrTextBox.Text[0]);
            if (TypeTextBox.Text != "")
                cereals.cereals = TypeSearch(cereals, TypeTextBox.Text[0]);
            if (CaloriesTextBox.Text != "")
                cereals.cereals = CaloriesSearch(cereals, Int32.Parse(CaloriesTextBox.Text));
            if (ProteinTextBox.Text != "")
                cereals.cereals = ProteinSearch(cereals, Int32.Parse(ProteinTextBox.Text));
            if (FatTextBox.Text != "")
                cereals.cereals = FatSearch(cereals, Int32.Parse(FatTextBox.Text));
            if (SodiumTextBox.Text != "")
                cereals.cereals = SodiumSearch(cereals, Int32.Parse(SodiumTextBox.Text));
            if (FiberTextBox.Text != "")
                cereals.cereals = FiberSearch(cereals, float.Parse(FiberTextBox.Text));
            if (CarboTextBox.Text != "")
                cereals.cereals = CarboSearch(cereals, float.Parse(CarboTextBox.Text));
            if (SugarsTextBox.Text != "")
                cereals.cereals = SugarsSearch(cereals, float.Parse(SugarsTextBox.Text));
            if (PotassTextBox.Text != "")
                cereals.cereals = PotassSearch(cereals, float.Parse(PotassTextBox.Text));
            if (VitaminsTextBox.Text != "")
                cereals.cereals = VitaminsSearch(cereals, float.Parse(VitaminsTextBox.Text));
            if (ShelfTextBox.Text != "")
                cereals.cereals = ShelfSearch(cereals, float.Parse(ShelfTextBox.Text));
            if (WeightTextBox.Text != "")
                cereals.cereals = WeightSearch(cereals, float.Parse(WeightTextBox.Text));
            if (CupsTextBox.Text != "")
                cereals.cereals = CupsSearch(cereals, float.Parse(CupsTextBox.Text));
            if (RatingTextBox.Text != "")
                cereals.cereals = RatingSearch(cereals, float.Parse(RatingTextBox.Text));

            foreach (Cereal result in cereals.cereals)
            {
                resultsListBox.Items.Add(result.Brand);
            }
        }

        //Runs a search LINQ on the brand of the Cereals
        //Returns the brands that contain the search query
        private List<Cereal> BrandSearch(Cereals cereals, string search)
        {
            var result =
                from cereal in cereals.cereals
                where cereal.Brand.Contains(search)
                select cereal;

            return result.ToList<Cereal>();
        }

        //Runs a LINQ finding the MFR character
        //Takes the user input and sets it to uppercase for the search because of the data storage method
        private List<Cereal> MfrSearch(Cereals cereals, char search)
        {
            var result =
                from cereal in cereals.cereals
                where cereal.Mfr == search.ToString().ToUpper()[0]
                select cereal;

            return result.ToList<Cereal>();
        }

        //Runs a LINQ command finding the Type of cereal
        //Once again uses uppercase because of the information storage method
        private List<Cereal> TypeSearch(Cereals cereals, char search)
        {
            var result =
                from cereal in cereals.cereals
                where cereal.Type == search.ToString().ToUpper()[0]
                select cereal;

            return result.ToList<Cereal>();
        }

        //Finds the search with calories less than or equal to the search amount
        private List<Cereal> CaloriesSearch(Cereals cereals, int search)
        {
            var result =
                from cereal in cereals.cereals
                where cereal.Calories <= search
                select cereal;

            return result.ToList<Cereal>();
        }

        //Returns the cereals with the user input Protein amount that is less than or equal
        private List<Cereal> ProteinSearch(Cereals cereals, int search)
        {
            var result =
                from cereal in cereals.cereals
                where cereal.Protein <= search
                select cereal;

            return result.ToList<Cereal>();
        }

        //Returns the LINQ of fat that are less than or equal to the user input
        private List<Cereal> FatSearch(Cereals cereals, int search)
        {
            var result =
                from cereal in cereals.cereals
                where cereal.Fat <= search
                select cereal;

            return result.ToList<Cereal>();
        }

        //Returns the LINQ on the user input amount of Sodium that is less than or equal to
        private List<Cereal> SodiumSearch(Cereals cereals, int search)
        {
            var result =
                from cereal in cereals.cereals
                where cereal.Sodium <= search
                select cereal;

            return result.ToList<Cereal>();
        }

        //Finds the amount of Fiber the user has input and returns those values and the ones that are less than
        private List<Cereal> FiberSearch(Cereals cereals, float search)
        {
            var result =
                from cereal in cereals.cereals
                where cereal.Fiber <= search
                select cereal;

            return result.ToList<Cereal>();
        }

        //Searchs for the user input amount of Carbo and returns the values less than or equal to
        private List<Cereal> CarboSearch(Cereals cereals, float search)
        {
            var result =
                from cereal in cereals.cereals
                where cereal.Carbo <= search
                select cereal;

            return result.ToList<Cereal>();
        }

        //Returns the LINQ query with user input Sugars that is less than or equal to
        private List<Cereal> SugarsSearch(Cereals cereals, float search)
        {
            var result =
                from cereal in cereals.cereals
                where cereal.Sugars <= search
                select cereal;

            return result.ToList<Cereal>();
        }

        //LINQ queries the Potass by user input and finds the cereals that are less than or equal to
        private List<Cereal> PotassSearch(Cereals cereals, float search)
        {
            var result =
                from cereal in cereals.cereals
                where cereal.Potass <= search
                select cereal;

            return result.ToList<Cereal>();
        }

        //Returns the LINQ query with user input Vitamins that is less than or equal to
        private List<Cereal> VitaminsSearch(Cereals cereals, float search)
        {
            var result =
                from cereal in cereals.cereals
                where cereal.Vitamins <= search
                select cereal;

            return result.ToList<Cereal>();
        }

        //LINQ queries the Shelf by user input and finds the cereals that are less than or equal to
        private List<Cereal> ShelfSearch(Cereals cereals, float search)
        {
            var result =
                from cereal in cereals.cereals
                where cereal.Shelf <= search
                select cereal;

            return result.ToList<Cereal>();
        }

        //Searchs for the user input amount of Weight and returns the values less than or equal to
        private List<Cereal> WeightSearch(Cereals cereals, float search)
        {
            var result =
                from cereal in cereals.cereals
                where cereal.Weight <= search
                select cereal;

            return result.ToList<Cereal>();
        }

        //Finds the amount of Cups the user has input and returns those values and the ones that are less than
        private List<Cereal> CupsSearch(Cereals cereals, float search)
        {
            var result =
                from cereal in cereals.cereals
                where cereal.Cups <= search
                select cereal;

            return result.ToList<Cereal>();
        }

        //Finds the search with Rating less than or equal to the search amount
        private List<Cereal> RatingSearch(Cereals cereals, float search)
        {
            var result =
                from cereal in cereals.cereals
                where cereal.Rating <= search
                select cereal;

            return result.ToList<Cereal>();
        }
    }
}
