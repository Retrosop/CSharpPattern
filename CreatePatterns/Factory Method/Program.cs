class User
{
	public int Id { get; set; }
	string Name { get; set; }
}

class Manager: User
{
	public string Company { get; set; }	
}