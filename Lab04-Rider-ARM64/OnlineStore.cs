using System;

public class OnlineStore {
	public string name { get; }
	public string baseURL { get; }
	public User currentUser { get; set; }
	public List<Item> itemsInCart { get; set; } = new List<Item>();

	public string welcomeMessage {
		get {
			return $"""
        	Добро пожаловать в интернет-магазин { name }.
        	Вы находитесь на странице: { baseURL + "auth/" }.
        	Для продолжения работы, необходимо зарегистрироваться.
        	""";
		}
	}

	public OnlineStore(string name, string baseURL) {
		this.name = name;
		this.baseURL = baseURL;
	}
}