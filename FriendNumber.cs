using System;
class FriendNumber : PhoneNumber {
    public bool isWorkNumber {get;set;}
    public FriendNumber (string name, string nuber, bool isW) :base (name,number)
    {
        siWorkNumber = isW;
    }

}