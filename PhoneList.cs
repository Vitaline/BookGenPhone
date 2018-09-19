using System;
class PhoneList<T> where T: PhoneNumber{
    T[] phList;
    int end;
    public PhoneList(){
        phList=new T[10];
        end=0;
    }
    public void Add (T ob) {
        if (end != phList.Length){

            phList[end]= ob;
            end++;
        }
        else Console.WriteLine("PhoneList is full");
    }
}
