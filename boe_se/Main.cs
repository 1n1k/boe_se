using System;
using boe_se.Engine;

namespace boe_se
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            /*foreach (var item in Market.GetInstance.Items)
                if(item.DataId == 440)
                    Console.WriteLine(item.kurs);

            Console.ReadLine();*/
            System.Collections.Generic.List<GItem> items = Market.GetInstance.Items;
            Console.WriteLine("Die Daten wurden heruntergeladen.");
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            foreach (GItem item in items)
            {
                if (item.DataId >= 15000 && item.DataId <=20000)
                {
                    System.Diagnostics.Debug.WriteLine(item.kurs);
                }
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds + " ms gesamt");
            Console.WriteLine(GItem.ArrayBereitstellen + " ms f�r das Bereitstellen der Listen");
            Console.WriteLine(GItem.exponentiellerDurchschnitt + " ms f�r das Berechnen der exponentiellen Durchschnitte");
            Console.WriteLine(GItem.gleitenderDurchschnitt + " ms f�r das Berechnen der gleitenden Durchschnitte");
            Console.WriteLine(GItem.FormationEinrichten + " ms f�r das Bereitstellen der speziellen Listen f�r die Formationen");
            Console.WriteLine(GItem.Formationen + " ms f�r das Erkennen der Formationen");
		}
	}
}
