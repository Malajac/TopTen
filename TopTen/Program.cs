using System;
using System.Collections.Generic;
using System.Web;

public class Program
{
	public static void Main()
	{
        var in_test1 = new List<String> { "Danas", "je", "lijep", "dan", "Danas", "Dan" };
        var out_test1 = getWordCounts(in_test1);
        foreach (var k in out_test1.Keys)
        {
            Console.WriteLine(k + ":" + out_test1[k]);
        }
      

        Console.WriteLine("Hello World");
        Console.ReadLine();
	}

    //coment

	public List<String> getHtmlFromUrls(List<Uri> webSites)
	{
		const string noHTML = "NO_HTML";
		//TODO
		// Uzeti listu webSites & download HTML
		// if Web site is not available put "NO_HTML"
		return new List<String> { "HTML1", "HTML2" };
	}

	public List<String> removeHTMLs(List<string> htmls)
	{

		//TODO Sinisa
		//TEst case Senad
		// Uzeti listu htmls remove all tags
		// if "NO_HTML" return empty string
		return new List<String> { "Danas je lijep dan.", "text2" };
	}

	public List<List<string>> getWordListFromTexts(List<string> texts)
	{

		//TODO Senad
		//TestCase Denis
		// Uzeti text pretvoriti ga u listu rijeci
		// Kreirati metod koji ce Izbrisati rijeci krace od 3 slova
		// Kreirati metod koji ce izbaciti rijeci koje sadrze broj
		return new List<List<String>> { new List<String> { "Danas", "je", "lijep", "dan" } };
	}

	public static Dictionary<string, int> getWordCounts(List<string> rijeci)
	{
        /*
         * v1 code
        Dictionary<string, int> results = new Dictionary<string, int>();
        foreach (string s in rijeci)
        {
            if (results.ContainsKey(s))
            {
                results[s] += 1;
            }
            else
            {
                results[s] = 1;
            }            
        }
        */
        
        // should be case-insensitive now
        var results = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);
        foreach (string s in rijeci)
        {
            int currentCount = 0;
            //  TryGetValue is more performant than ContainsKey followed by item access
            results.TryGetValue(s, out currentCount);
            currentCount++;
            results[s] = currentCount;
        }

        //TODO Denis
        //TODO TestCases DZenita
        // return new Dictionary<String, int> { { "Danas", 2 }, { "dan", 1 } };
        return results;
	}

	Dictionary<String, int> makeTop10s(List<Dictionary<String, int>> top10Liste)
	{
		// TODO Dzenita, weighted average
		//TEsttCase Adin
		return new Dictionary<String, int>();
	}
}