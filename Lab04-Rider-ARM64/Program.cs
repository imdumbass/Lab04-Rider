using EasyConsole;
using Lab04_Rider_ARM64.Categories.Portable;

internal class Program {

	private static void Main(string[] args) {
		OnlineStore onlineStore = new OnlineStore(
			name: "Apple",
			baseURL: "https://apple.com/"
		);

		var subscriptions = new Menu();
		foreach (Item item in Subscriptions.items) {
			subscriptions.Add($"{item.title} ({item.price} у.е.) [{item.ID}]", () => {
				onlineStore.itemsInCart.Add(item);
			});
		}
		subscriptions.Add("Назад", () => { });
		
		var iPhone = new Menu();
		foreach (Item item in Portable.iPhone.items) {
			iPhone.Add($"{item.title} ({item.price} у.е.) [{item.ID}]", () => {
				onlineStore.itemsInCart.Add(item);
			});
		}
		iPhone.Add("Назад", () => { });

		var iPad = new Menu();
		foreach (Item item in Portable.iPad.items) {
			iPad.Add($"{item.title} ({item.price} у.е.) [{item.ID}]", () => {
				onlineStore.itemsInCart.Add(item);
			});
		}
		iPad.Add("Назад", () => { });
		
		var portable = new Menu()
			.Add($"iPhone", () => {
				Console.Clear();
				Console.WriteLine(new Portable.iPhone().getCategoryName());
				iPhone.Display();
			})
			.Add($"iPad", () => {
				Console.Clear();
				Console.WriteLine(new Portable.iPad().getCategoryName());
				iPad.Display();
			})
			.Add($"Назад", () => { });

		var catalogViewer = new Menu()
			.Add(
				"Сервисы", () => {
					Console.Clear();
					Console.WriteLine(new Subscriptions().getCategoryName());
					subscriptions.Display();
				}
			)
			.Add("Портативные устройства", () => {
				Console.Clear();
				Console.WriteLine(new Portable().getCategoryName());
				portable.Display();
			})
			.Add("Назад", () => { });
		
		var menu = new Menu()
			.Add("Перейти к просмотру каталога", () => {
				Console.Clear();
				catalogViewer.Display();
			})
			.Add("Просмотреть товары в корзине", () => {
				Console.Clear();
				
				if (onlineStore.itemsInCart.Count == 0) {
					Console.WriteLine("Товаров в корзине нет.");
				}
				
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
			})
			.Add("Выполнить заказ", () => Console.WriteLine("bar selected"))
			.Add("Завершить программу", () => Environment.Exit(0));
		
		Console.WriteLine(onlineStore.welcomeMessage);
		
		Console.WriteLine();

		onlineStore.currentUser = new User(
			firstName: ConsoleHelper.ReadStringLine(message: "Имя:"),
			lastName: ConsoleHelper.ReadStringLine(message: "Фамилия:"),
			email: ConsoleHelper.ReadStringLine(message: "Email:")
		);

		Console.Clear();
		
		while (true) {
			Console.Clear();
			Console.WriteLine($"{ onlineStore.currentUser.firstName } { onlineStore.currentUser.lastName }, добрый день.");
			menu.Display();	
		}
	}
}
