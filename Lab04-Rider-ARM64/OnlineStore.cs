using System;
using Lab04_Rider_ARM64;

public class OnlineStore {
	public string name { get; }
	public string baseURL { get; }
	public Person currentUser { get; set; }
	public Admin adminPerson { get; set; }
	public List<Item> itemsInCart { get; set; } = new List<Item>();
	public List<string> longReceiptLog { get; set; } = new List<string>();
	public string welcomeMessage {
		get {
			return $"""
        	Добро пожаловать в интернет-магазин { name }.
        	Вы находитесь на странице: { baseURL + "auth/" }.
        	Для продолжения работы, необходимо зарегистрироваться.
        	""";
		}
	}

	/* Вывод списка из корзины в виде string для удобства чтения */
	public string shoppingCartListHumanReadable {
		get {
			if (itemsInCart.Count == 0) {
				Console.WriteLine("Товаров в корзине нет.");
			}

			string humanReadableString = "";
			UInt16 counter = 0;
			foreach (Item itemInCart in itemsInCart) {
				humanReadableString += $"""
						[Товар №{ ++counter }]
						Название: { itemInCart.title }
						Цена: { itemInCart.price }  
						ID: { itemInCart.ID }  
						""";
						humanReadableString += '\n';
			}

			return humanReadableString;
		}
	}
	
	public string completeTheOrder() {
		ResponsibleWorker responsibleWorker = adminPerson.sendResponsibleWorker();
		responsibleWorker.onlineStore = this;
		string receipt = responsibleWorker.serveTheCustomerAndGetReceipt();

		adminPerson.onlineStore = this;
		
		/* Администратор вносит информацию об оплате в магазин */
		adminPerson.addReceiptRecord(receiptFromResponsibleWorker: receipt);
		return longReceiptLog.LastOrDefault();
	}
	public OnlineStore(string name, string baseURL, Admin adminPerson) {
		this.name = name;
		this.baseURL = baseURL;
		this.adminPerson = adminPerson;
	}
}