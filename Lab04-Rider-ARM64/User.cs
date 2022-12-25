public class User {
	public string firstName { get; }
	public string lastName { get; }
	public string email { get; }

	public User(string firstName, string lastName, string email) {
		this.firstName = firstName;
		this.lastName = lastName;
		this.email = email;
	}
}