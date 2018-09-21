using System;
class Supplier : PhoneNumber {
    	public string Number {get; set;}


	public string Name {get; set;}
    public Supplier (string name, string number)
    {
Name = name;
		Number = number;
    }

}