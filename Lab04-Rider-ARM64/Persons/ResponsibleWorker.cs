namespace Lab04_Rider_ARM64; 

public class ResponsibleWorker: Person {
	public OnlineStore onlineStore { get; set; }
	
	public string serveTheCustomerAndGetReceipt() {
		if (onlineStore == null) {
			return "Ошибка. Ответственный рабочий не привязан к магазину!";
		}

		string temp = onlineStore.shoppingCartListHumanReadable;
		onlineStore.itemsInCart.Clear();

		return temp;
	}
	
	public ResponsibleWorker(
		string firstName,
		string lastName,
		string email
	) : base(firstName, lastName, email) {
		this.firstName = firstName;
		this.lastName = lastName;
		this.email = email;
	}
}