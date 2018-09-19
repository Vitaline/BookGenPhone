using System ;
class DemoTest {
    static void Main(){
        PhoneList<FriendNumber> pList=new PhoneList<FriendNumber>();
          for (int i =0;i<15;i++)
        pList.Add(new FriendNumber("Ivan","891277777777",false));
    }
}
