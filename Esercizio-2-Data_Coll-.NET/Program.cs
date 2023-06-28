using System.Collections;


ArrayList arrayList = new ArrayList();
arrayList.Add("ciao");
arrayList.Add(0);
arrayList.Add(10.14);
arrayList.Add(true);
Print(arrayList);

 static void Print(IEnumerable list)
{
    foreach(var item in list )
        Console.WriteLine(item);
}