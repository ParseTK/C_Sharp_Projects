using System;
using static System.Console;
using System.Globalization;

/*
Create an application named TestClassifiedAd that 
instantiates and displays at least two ClassifiedAd objects. 
A ClassifiedAd has fields for a Category 
(For example, Used Cars and Help Wanted), 
a number of Words, and a price. 
Include properties that contain get and set accessors 
for the category and number of words, 
but only a get accessor for the price. 
The price is calculated at nine cents per word.

Note: Your output should be formatted as: 
The classified ad with 100 words in category Used Cars costs $9.00
The classified ad with 60 words in category Help Wanted costs $5.40
*/

class TestClassifiedAd
{
	static void Main()
	{
		var ad_1 = new ClassifiedAd("Used Cars", 100);
		var ad_2 = new ClassifiedAd("Help Wanted", 60);

		Console.WriteLine(ad_1.OutputAd());
		Console.WriteLine(ad_2.OutputAd());

		//var ui = new OutputAd();

		//ui.DisplayAd(ad_1);
		//ui.DisplayAd(ad_2);
	}
}

class ClassifiedAd
{
	private string Category;
	private int NumWords;

	public string Category
	{
		get => Category;
		set => Category = value;
	}

	public int NumWords
	{
		get => NumWords;
		set => NumWords = value;
	}

	public float Price => NumWords * 0.09f; // readonly <- get

	public ClassifiedAd(string category, int numWords) =>
		(Category, NumWords) = (category, numWords);

	public string OutputAd() =>
        $"The classified ad with {NumWords} words in category {Category} costs {Price.ToString("C", CultureInfo.GetCultureInfo("en-US"))}";
}
/*
class OutputAd
{
	public void DisplayAd(ClassifiedAd ad) =>
		Console.WriteLine($"The classified ad with {ad.NumWords} words in category {ad.Category} costs {ad.GetPrice.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");	
}
*/
