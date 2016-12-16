using System;
using System.Collections.Generic;
using System.Net;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
	}

    //coment

	public List<String> getHtmlFromUrls(List<Url> webSites)
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
		return new List<String> { new List<String> { "Danas", "je", "lijep", "dan" } };
	}

	public Dictionary<String, int> getWordCounts(List<string> rijeci)
	{
		//TODO Denis
		//TODO TestCases DZenita
		return new Dictionary<String, int> { { "Danas", 2 }, { "dan", 1 } };
	}

	Dictionary<String, int> makeTop10s(List<Dictionary<String, int>> top10Liste)
	{
		// TODO Dzenita, weighted average
		//TEsttCase Adin
		return Dictionary<String, int>();
	}
}