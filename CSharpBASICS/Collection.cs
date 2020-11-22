using System.Collections.Genetic;
public class Collections
{
    public void LearnAboutList()
    {
        List<string> names = new List<string>{ "Shayam", "Rita" };
        names.Add("Pragya");
        names.Add("SPragya");
        names.Add("NPragya");
        names.Add("JPragya");

        names.Sort();
    }
    public void LearnAboutDictionary()
    {
        //Holds key-value pairs
        Dictionary<string, string> countryCapitals = new Dictionary<string, string>
        {
            ["Bhutan"] = "Thimpu",
            ["China"] =  "Beijin"

        }
        countryCapitals.Add("Nepal", "Lalitpur");
        countryCapitals.Add("America", "California";)
        countryCapitals.Add("England", "London";)
        countryCapitals.Add("Germany", "Youghy";)
    }
        
    }
}