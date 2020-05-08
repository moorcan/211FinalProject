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
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using Nancy.Json;

namespace CocktailSearch
{
    public partial class Form1 : Form
    {
        List<string> searchDrinks;
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
           
            //creates a drop down list of glasses
            List<string> alcoholList = getAlcoholList();
            dropdown_alcohol.Items.Clear();
            for (int i = 0; i < alcoholList.Count; i++)
            {
                dropdown_alcohol.Items.Add(alcoholList[i]);
            }

            //creates a drop down list of glasses
            List<string> glassType = getGlassList();
            dropdown_glass.Items.Clear();
            for (int i = 0; i < glassType.Count; i++)
            {
                dropdown_glass.Items.Add(glassType[i]);
            }
         
            //calls function which poopulates the 5 popular drinks on startup 
            populateFiveFavDrinks();

            //default drink on start up appears 
            IDictionary<string, string> drink = getDrink("Moscow Mule");
            populateDrink(drink);

            //search drinks in a function later
            searchDrinks = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private List<string> getAlcoholList()
        {   
            status.Text = "Retrieving Alcohol List";

            //makes HTTP request from web to grab list of ingrediants
            using (var client = new HttpClient(new HttpClientHandler { }))
            {   
                HttpResponseMessage response = client.GetAsync("https://www.thecocktaildb.com/api/json/v1/1/list.php?i=list").Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
               
                //instructions.Text = result;
                dynamic stuff = JsonConvert.DeserializeObject(result);

                //pull the first drink from the list of this type of drink
                dynamic drink = stuff["drinks"];  
                
                List<string> returnValue = new List<string>();
                foreach(var item in drink)
                {
                    string name = item["strIngredient1"];
                   returnValue.Add(name);                  
                }
                returnValue.Sort();
                return returnValue;
            }        
        }

        private List<string> getGlassList()
        {
            //makes HTTP request from web to grab list of glasses
            using (var client = new HttpClient(new HttpClientHandler { }))
            {
                HttpResponseMessage response = client.GetAsync("https://www.thecocktaildb.com/api/json/v1/1/list.php?g=list").Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
                status.Text = "Result: " + result;
                //instructions.Text = result;
                dynamic stuff = JsonConvert.DeserializeObject(result);

                dynamic drink = stuff["drinks"];  //pull the first drink from the list of this type of drink
                List<string> returnValue = new List<string>();
                foreach (var item in drink)
                {
                    string name = item["strGlass"];
                    returnValue.Add(name);
                }
                return returnValue;
            }
        }

        private List<string> getIngList()
        {
            List<string> returnValue = new List<string>();
            returnValue.Add("limes");
            returnValue.Add("orange juice");
            returnValue.Add("grenadine");
            return returnValue;
        }

        private List<string> getDrinksByIngredient(string ingredient)
        {   
            //status text at bottom of screen
            status.Text = "Retrieving by Ingredient";
           
            //makes HTTP request from web to filter drinks by ingredient
            using (var client = new HttpClient(new HttpClientHandler { }))
            {
                HttpResponseMessage response = client.GetAsync("https://www.thecocktaildb.com/api/json/v1/1/filter.php?i=" + ingredient).Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
                status.Text = "Result: " + result;
                //instructions.Text = result;
                dynamic stuff = JsonConvert.DeserializeObject(result);
                if(stuff == null)
                {
                    return null;
                }
                dynamic drink = stuff["drinks"];  //pull the first drink from the list of this type of drink
                List<string> returnValue = new List<string>();
                foreach (var item in drink)
                {
                    string name = item["strDrink"];
                    returnValue.Add(name);
                }
                return returnValue;
            }
        }
        //intersects the two lists (drinksbyIngredient and drinksbyGlass) and produces a list that matches drink name
        private List<string> getDrinkIntersection(List<string> drinksbyGlass, List<string> drinksbyIngredient)
        {
            List<string> returnVal = new List<string>();
            if(drinksbyIngredient == null && drinksbyGlass != null)
            {
                return drinksbyGlass;
            }
            else if(drinksbyGlass == null && drinksbyIngredient != null)
            {
                return drinksbyIngredient;
            }
            else
            {
                for(int j = 0; j < drinksbyGlass.Count ; j++)
                {
                    for(int k =0; k < drinksbyIngredient.Count; k++)
                    {
                        if (drinksbyGlass[j] == drinksbyIngredient[k])
                        {
                            returnVal.Add(drinksbyGlass[j]);
                        }
                    }
                }
            }
            return returnVal;
        }


        //call back function for when the user chooses an ingredient
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> drinksbyIngredient = getDrinksByIngredient(dropdown_alcohol.Text);
            List<string> drinksbyGlass = getDrinksByGlass(dropdown_glass.Text);
            List<string> drinks = getDrinkIntersection(drinksbyGlass, drinksbyIngredient);

            drinkList.Items.Clear();
            for (int i = 0; i < drinks.Count; i++)
            {
                drinkList.Items.Add(drinks[i]);
            }

        }

        private List<string> getDrinksByGlass(string glass)
        {
            status.Text = "Retrieving by Glass";
            //makes HTTP request from web to filter drinks by glass
            using (var client = new HttpClient(new HttpClientHandler { }))
            {
                HttpResponseMessage response = client.GetAsync("https://www.thecocktaildb.com/api/json/v1/1/filter.php?g=" + glass).Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
               
                //instructions.Text = result;
                dynamic stuff = JsonConvert.DeserializeObject(result);
                if(stuff == null)
                {
                    return null;
                }

                //unraveling json structure to get to the drink
                dynamic drink = stuff["drinks"]; //pull the first drink from the list of this type of drink
                List<string> returnValue = new List<string>();
                foreach (var item in drink)
                {
                    string name = item["strDrink"];
                    returnValue.Add(name);
                }
                return returnValue;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //call back function for when the user chooses a glass
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> drinksbyIngredient = getDrinksByIngredient(dropdown_alcohol.Text);
            List<string> drinksbyGlass = getDrinksByGlass(dropdown_glass.Text);
            List<string> drinks = getDrinkIntersection(drinksbyGlass, drinksbyIngredient);
            drinkList.Items.Clear();
            for (int i = 0; i < drinks.Count; i++)
            {
                drinkList.Items.Add(drinks[i]);
            }
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
            populateDrink(drink);

        }

        private void populateDrink(IDictionary<string, string> drink)
        {
            drinkName.Text = drink["name"];
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
            status.Text = "Getting Drink: " + drinkName;

            //makes HTTP request from web to grab information about drink
            using (var client = new HttpClient(new HttpClientHandler { }))
            {
                HttpResponseMessage response = client.GetAsync("https://www.thecocktaildb.com/api/json/v1/1/search.php?s=" + drinkName).Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
          
                //instructions.Text = result;
                dynamic stuff = JsonConvert.DeserializeObject(result);
                dynamic drink = stuff["drinks"][0];  //pull the first drink from the list of this type of drink
                int i = 0;

                //IDictionary<string, IDictionary<string, string>> dictOfDrinks = new Dictionary<string, IDictionary<string, string>>();
                IDictionary<string, string> drink1 = new Dictionary<string, string>();
                drink1["name"] = drink["strDrink"];//"Margarita";
                drink1["ingrediant1"] = drink["strIngredient1"]; //"Tequilla";
                drink1["ingrediant2"] = drink["strIngredient2"]; //"Triple sec";
                drink1["ingrediant3"] = drink["strIngredient3"]; //"Lime juice";
                drink1["ingrediant4"] = drink["strIngredient4"]; //"Salt";
                drink1["ingrediant5"] = drink["strIngredient5"]; // null;
                drink1["ingrediant6"] = drink["strIngredient6"]; // null;
                drink1["measure1"] = drink["strMeasure1"]; //"1 1/2 oz ";
                drink1["measure2"] = drink["strMeasure2"]; //"1/2 oz ";
                drink1["measure3"] = drink["strMeasure3"]; //"1 oz ";
                drink1["measure4"] = drink["strMeasure4"]; //null;
                drink1["measure5"] = drink["strMeasure5"]; //null;
                drink1["measure6"] = drink["strMeasure6"]; //null;
                drink1["photo"] = drink["strDrinkThumb"]; //"https://www.thecocktaildb.com/images/media/drink/wpxpvu1439905379.jpg";
                drink1["glass"] = drink["strGlass"];//"Cocktail Glass";
                drink1["instructions"] = drink["strInstructions"];//"Rub the rim of the glass with the lime slice to make the salt stick to it. Take care to moisten only the outer rim and sprinkle the salt on it." +
                                                                  // " The salt should present to the lips of the imbiber and never mix into the cocktail. Shake the other ingredients with ice, then carefully pour into the glass.";
                return drink1;
            }
        }

        private void measurment_Click(object sender, EventArgs e)
        {

        }

        private void populateFiveFavDrinks()
        {
            //Moscow Mule
            popularDrink1.Load("https://www.thecocktaildb.com/images/media/drink/3pylqc1504370988.jpg");

            //Mojito
            popularDrink2.Load("https://www.thecocktaildb.com/images/media/drink/rxtqps1478251029.jpg");

            //Manhatten
            popularDrink3.Load("https://www.thecocktaildb.com/images/media/drink/ec2jtz1504350429.jpg");

            //Wiskey Sour
            popularDrink4.Load("https://www.thecocktaildb.com/images/media/drink/zxd8v41576797287.jpg");

            //Long Island Tea
            popularDrink5.Load("https://www.thecocktaildb.com/images/media/drink/ywxwqs1439906072.jpg");


        }

        //Moscow Mule Drink 1
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            IDictionary<string, string> drink = getDrink("Moscow Mule");
            populateDrink(drink);
        }
        //Mojito Drink 2 when the popular drink Mojito is clicked you will see ingrediants
        private void popularDrink2_Click(object sender, EventArgs e)
        {
            IDictionary<string, string> drink = getDrink("Mojito");
            populateDrink(drink);
        }
        //Manhatten Drink3 when the popular drink Manhatten is clicked you will see ingrediants
        private void popularDrink3_Click(object sender, EventArgs e)
        {
            IDictionary<string, string> drink = getDrink("Manhattan");
            populateDrink(drink);
        }
        //Wishkey Sour Drink 4when the popular drink Wiskey Sour is clicked you will see ingrediants
        private void popularDrink4_Click(object sender, EventArgs e)
        {
            IDictionary<string, string> drink = getDrink("Whiskey Sour");
            populateDrink(drink);
        }

        //Long Island Tea Drink 5 when the popular drink Long Island Tea is clicked you will see ingrediants
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            IDictionary<string, string> drink = getDrink("Long Island Tea");
            populateDrink(drink);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        //search bar function 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
         //
            if(searchBar.Text.Length == 1)
            {
                drinkList.Items.Clear();
                string character = searchBar.Text;

                //status text at bottom of screen
                status.Text = "Searching By First Letter";

                //makes HTTP request from web to filter drinks by first letter
                using (var client = new HttpClient(new HttpClientHandler { }))
                {
                    HttpResponseMessage response = client.GetAsync("https://www.thecocktaildb.com/api/json/v1/1/search.php?f=" + character).Result;
                    response.EnsureSuccessStatusCode();
                    string result = response.Content.ReadAsStringAsync().Result;
                 
                    //parse json data
                    dynamic stuff = JsonConvert.DeserializeObject(result);
                    /*                  
                    if (stuff == null)
                    {
                        return null;
                    }
                    */

                    //pull the first drink from the list of this type of drink
                    dynamic drink = stuff["drinks"]; 
                   
                   
                    foreach (var item in drink)
                    {
                        string name = item["strDrink"];
                        searchDrinks.Add(name);
                    }
                    drinkList.Items.Clear();
                    for (int i = 0; i < searchDrinks.Count; i++)
                    {
                        drinkList.Items.Add(searchDrinks[i]);
                        searchDrinks.Sort();
                    }

                }
            }
            else if(searchBar.Text.Length > 1)
            {
                for(int i = 0; i < searchDrinks.Count; i++)
                {                   
                    string character = searchBar.Text.Substring(searchBar.Text.Length - 1 , 1);
                    string drinkName = searchDrinks[i];
                    string character2 = drinkName.Substring(searchBar.Text.Length - 1, 1);
                    if(! character.Equals(character2))
                    {
                        searchDrinks.RemoveAt(i);
                    }
                }
                drinkList.Items.Clear();
                for (int i = searchDrinks.Count -1; i >= 0; i--)
                {
                    
                    drinkList.Items.Add(searchDrinks[i]);
                }
            }

      
        }
    }




}
