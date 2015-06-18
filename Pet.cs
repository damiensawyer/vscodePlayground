public class Pet

	public string Name {get;set;}
}

public Dog : Pet
{
	Dog()
	{
		var s = this.Name;
	}
}
