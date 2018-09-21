using System ;
class DemoTest {
    static void Main(){
        PhoneList<FriendNumber> pList=new PhoneList<FriendNumber>();
         
        pList.Add(new FriendNumber("Ivan","891277777777",false));
        pList.Add(new FriendNumber("Paul","891275675677",true));
        pList.Add(new FriendNumber("Tom","891745645777",false));

try {

FriendNumber frnd = pList.FindByName("Ivan");

Console.WriteLine(frnd.Name+" "+frnd.Number);

if (frnd.isWorkNumber)
Console.WriteLine(" (рабочий)");
else Console.WriteLine();
}

catch (NotFoundException){ Console.WriteLine("Not found"); }

Console.WriteLine();


 PhoneList<Supplier> pList2=new PhoneList<Supplier>();
          
        pList2.Add(new Supplier("Ivan","891277777777"));
        pList2.Add(new Supplier("Paul","891275675677"));
        pList2.Add(new Supplier("Tom","891745645777"));

try {

Supplier frnd2 = pList2.FindByNumber("891275675677");

Console.WriteLine(frnd2.Name+" "+frnd2.Number);


}

catch (NotFoundException){ Console.WriteLine("Not found"); }


    }
}
