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

	public string mainMenuString {
		get {
			return $"""
			Выберите опцию:
			1. Перейти к просмотру каталога
			2. Просмотреть товары в корзине
			3. Выполнить заказ
			0. Завершить программу 
			""";
		}
	}

	public string categoriesString {
		get {
			return $"""
			1. Сервисы
			2. Портативные устройства
			3. Сервера  	
			""";
		}
	}

	public void OnlineStoreHandler() {
		void services() {
			void Subscriptions() {
			}
			
			Console.WriteLine("""
			1. Подписки
			""");
			
			switch (ConsoleHelper.ReadInt(message: ">>")) {
				case 1:
					break;
			}
		}

		void portable() {
			
		}

		void servers() {
			
		}
		
		switch (ConsoleHelper.ReadInt(message: ">>")) {
			case 1:
				services();
				break;
			case 2:
				portable();
				break;
			case 3:
				servers();
				break;

		}
	}
	
	public OnlineStore(string name, string baseURL) {
		this.name = name;
		this.baseURL = baseURL;
	}
}