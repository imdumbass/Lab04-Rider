public class Subscriptions: Services {
	private static string subcategoryName = "Подписки";

	public static List<Item> items = new List<Item> {
		new Item(
			title: "Apple Music (1 месяц)",
			price: 199,
			ID: "AAPL-MUSIC-1MTH"
		),
		
		new Item(
			title: "Apple One (1 месяц)",
			price: 599,
			ID: "AAPL-ONE-1MTH"
		),
		
		new Item(
			title: "iCloud 1TB (1 месяц)",
			price: 399,
			ID: "AAPL-ICLOUD-1MTH"
		),
		
		new Item(
			title: "Apple Arcade (1 месяц)",
			price: 99,
			ID: "AAPL-ARCADE-1MTH"
		)
	};
}