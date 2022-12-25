public class Person {
	public string firstName { get; set; }
	public string lastName { get; set; }
	public string email { get; set; }

	public Person(string firstName, string lastName, string email) {
		this.firstName = firstName;
		this.lastName = lastName;
		this.email = email;
	}
}