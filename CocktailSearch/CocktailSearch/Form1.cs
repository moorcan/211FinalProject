using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocktailSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //https://prod.liveshare.vsengsaas.visualstudio.com/join?F5FFF30CDAD5201A93CFAB19BAA1D4354A07
            //https://www.thecocktaildb.com/api/json/v1/1/filter.php?i=Gin
            //https://www.thecocktaildb.com/api/json/v1/1/filter.php?i=Vodka

            List<string> alcoholList = getAlcoholList();
            dropdown_alcohol.Items.Clear();
            for (int i = 0; i < alcoholList.Count; i++)
            {
                dropdown_alcohol.Items.Add(alcoholList[i]);
            }

            List<string> glassType = getGlassList();
            dropdown_glass.Items.Clear();
            for (int i = 0; i < glassType.Count; i++)
            {
                dropdown_glass.Items.Add(glassType[i]);
            }

            List<string> ingrediants = getIngList();
            dropdown_ingredients.Items.Clear();
            for (int i = 0; i < ingrediants.Count; i++)
            {
                dropdown_ingredients.Items.Add(ingrediants[i]);
            }




            /*List the categories, glasses, ingredients or alcoholic filters
            https://www.thecocktaildb.com/api/json/v1/1/list.php?c=list
            https://www.thecocktaildb.com/api/json/v1/1/list.php?g=list
            https://www.thecocktaildb.com/api/json/v1/1/list.php?i=list
            https://www.thecocktaildb.com/api/json/v1/1/list.php?a=list
            */
            //POPULAR DRINKS
            //  https://www.thecocktaildb.com/api/json/v1/1/filter.php?c=Cocktail
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private List<string> getAlcoholList()
        {
            List<string> returnValue = new List<string>();
            returnValue.Add("Vodka");
            returnValue.Add("Scotch");
            returnValue.Add("Wiskey");
            return returnValue;
        }

        private List<string> getGlassList()
        {
            List<string> returnValue = new List<string>();
            returnValue.Add("Highball");
            returnValue.Add("Shot Glass");
            returnValue.Add("Pint Glass");
            return returnValue;
        }

        private List<string> getIngList()
        {
            List<string> returnValue = new List<string>();
            returnValue.Add("limes");
            returnValue.Add("orange juice");
            returnValue.Add("grenadine");
            return returnValue;
        }

        private List<string> getDrinks(string alcohol, string glass, string ingrediant)
        {
            List<string> returnValue = new List<string>();
            returnValue.Add("mojito");
            returnValue.Add("moscow mule");
            returnValue.Add("tequila sunrise");
            return returnValue;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> drinks = getDrinks(dropdown_alcohol.Text, dropdown_glass.Text, dropdown_ingredients.Text);
            drinkList.Items.Clear();
            for (int i = 0; i < drinks.Count; i++)
            {
                drinkList.Items.Add(drinks[i]);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void resultPicture_Click(object sender, EventArgs e)
        {
            drinkName.Text = "Moscow Mule";
        }

        private void drinkList_SelectedIndexChanged(object sender, EventArgs e)
        {
       
            IDictionary<string, string> drink = getDrink(drinkList.Text);
            drinkName.Text = drinkList.Text;
            resultPicture.Load(drink["photo"]);
            instructions.Text = drink["instructions"];
            ingrediant1.Text = drink["ingrediant1"];
            ingrediant2.Text = drink["ingrediant2"];
            ingrediant3.Text = drink["ingrediant3"];
            ingrediant4.Text = drink["ingrediant4"];
            ingrediant5.Text = drink["ingrediant5"];
            ingrediant6.Text = drink["ingrediant6"];
            measure1.Text = drink["measure1"];
            measure2.Text = drink["measure2"];
            measure3.Text = drink["measure3"];
            measure4.Text = drink["measure4"];
            measure5.Text = drink["measure5"];
            measure6.Text = drink["measure6"];
        }

        private IDictionary<string, string> getDrink(string drinkName)
        {
            //IDictionary<string, IDictionary<string, string>> dictOfDrinks = new Dictionary<string, IDictionary<string, string>>();
            IDictionary<string, string> drink1 = new Dictionary<string, string>();
            drink1["ingrediant1"] = "Tequilla";
            drink1["ingrediant2"] = "Triple sec";
            drink1["ingrediant3"] = "Lime juice";
            drink1["ingrediant4"] = "Salt";
            drink1["ingrediant5"] = null;
            drink1["ingrediant6"] = null;
            drink1["measure1"] = "1 1/2 oz ";
            drink1["measure2"] = "1/2 oz ";
            drink1["measure3"] = "1 oz ";
            drink1["measure4"] = null;
            drink1["measure5"] = null;
            drink1["measure6"] = null;
            drink1["photo"] = "https://www.thecocktaildb.com/images/media/drink/wpxpvu1439905379.jpg";
            drink1["glass"] = "Cocktail Glass";
            drink1["instructions"] = "Rub the rim of the glass with the lime slice to make the salt stick to it. Take care to moisten only the outer rim and sprinkle the salt on it." +
                                     " The salt should present to the lips of the imbiber and never mix into the cocktail. Shake the other ingredients with ice, then carefully pour into the glass.";

           // IDictionary<string, string> drink2 = new Dictionary<string, string>();
           // drink2["ingrediant"] = "orange juice";
           // drink2["instructions"] = "do not stir";
           // dictOfDrinks["Margarita"] = drink1;
           // dictOfDrinks["tequila sunrise"] = drink2;
            return drink1;




        }

        private void measurment_Click(object sender, EventArgs e)
        {

        }
    }

   /* private IDictionary<string, IDictionary<string, string>> populateDrink(string drinkName)
        {
            IDictionary<string, IDictionary<string, string>> dictOfDrinks = new Dictionary<string, IDictionary<string, string>>();
            IDictionary<string, string> drink1 = new Dictionary<string, string>();
            drink1["ingrediant1"] = "Tequilla";
            drink1["ingrediant2"] = "Triple sec";
            drink1["ingrediant3"] = "Lime juice";
            drink1["ingrediant4"] = "Salt";
            drink1["measure1"] = "1 1/2 oz ";
            drink1["measure2"] = "1/2 oz ";
            drink1["measure3"] = "1 oz ";
            drink1["measure4"] = null;
            drink1["photo"] = "https://www.thecocktaildb.com/images/media/drink/wpxpvu1439905379.jpg";
            drink1["glass"] = "Cocktail Glass";
            drink1["instructions"] = "Rub the rim of the glass with the lime slice to make the salt stick to it. Take care to moisten only the outer rim and sprinkle the salt on it." +
                                     " The salt should present to the lips of the imbiber and never mix into the cocktail. Shake the other ingredients with ice, then carefully pour into the glass.";

            drink1["instructions"] = "Shake the glass";
            IDictionary<string, string> drink2 = new Dictionary<string, string>();
            drink2["ingrediant"] = "orange juice";
            drink2["instructions"] = "do not stir";
            dictOfDrinks["Margarita"] = drink1;
            dictOfDrinks["tequila sunrise"] = drink2;
            return dictOfDrinks;
            
     


        }
        */
    
}
