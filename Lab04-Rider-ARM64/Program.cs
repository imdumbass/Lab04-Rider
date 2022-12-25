using ConsoleTools;
using Lab04_Rider_ARM64;

internal class Program {

	private static void Main(string[] args) {
		OnlineStore onlineStore = new OnlineStore(
			name: "Apple",
			baseURL: "https://apple.com/"
		);
		ConsoleHandler consoleHandler = new ConsoleHandler(onlineStore);

		Console.WriteLine(onlineStore.welcomeMessage);
		
		Console.WriteLine();

		onlineStore.currentUser = new User(
			firstName: ConsoleHelper.ReadStringLine(message: "Имя:"),
			lastName: ConsoleHelper.ReadStringLine(message: "Фамилия:"),
			email: ConsoleHelper.ReadStringLine(message: "Email:")
		);

		Console.Clear();

		
		Environment.Exit(0);
		while (true) {
			Console.WriteLine(onlineStore.mainMenuString);
	
			switch (ConsoleHelper.ReadInt(message: ">>")) {
				case 1:
					Console.Clear();
					Console.WriteLine(onlineStore.categoriesString);
					
					Console.Clear();
					break;
				case 2: {
					UInt16 counter = 0;
					foreach (Item itemInCart in onlineStore.itemsInCart) {
						Console.WriteLine($"""
						[Товар №{ ++counter }]
						Название: { itemInCart.title }
						Цена: { itemInCart.price }  
						ID: { itemInCart.ID }
						""");
					}
					
					Console.ReadKey();
					break;
				}
				case 0:
					Environment.Exit(0);
					break;
				default:
					continue;
			}
			Console.Clear();
		}
		
	}
}