using System;
class PhoneList<T> where T: PhoneNumber{
    T[] phList;
    int end;
    public PhoneList(){
        phList=new T[10];
        end=0;
    }
    public bool Add (T ob) {
        if (end == phList.Length) return false;

            phList[end]= ob;
            end++;
            return true;
        
    }

    public T FindByName (string name){
    for (int i = 0; i<end; i++){
        if (phList[i].Name == name)

            return phList[i];

    }
            throw new NotFoundException ();    
    }
    public T FindByNumber (string number){
    for (int i = 0; i<end; i++){
        if (phList[i].Number == number)

            return phList[i];

    }
            throw new NotFoundException ();    
    }

    

}
