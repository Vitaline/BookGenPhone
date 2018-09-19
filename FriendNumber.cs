using System;
class FriendNumber : PhoneNumber {
    public bool isWorkNumber {get;set;}
    public FriendNumber (string name, string number, bool isW) :base (name,number)
    {
        isWorkNumber = isW;
    }

}