using System;
class FriendNumber : PhoneNumber {
	public string Number {get; set;}


	public string Name {get; set;}
    public bool isWorkNumber {get;set;}
    public FriendNumber (string name, string number, bool isW)
    {

		Name = name;
		Number = number;

        isWorkNumber = isW;
    }

}