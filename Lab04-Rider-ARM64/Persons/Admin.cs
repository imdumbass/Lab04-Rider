namespace Lab04_Rider_ARM64; 

public class Admin: Person {
	public OnlineStore onlineStore { get; set; }
	
	public void addReceiptRecord(string receiptFromResponsibleWorker) {
		if (onlineStore == null) {
			Console.WriteLine("[Ошибка! Администратор не привязан к магазину.]");
			return;
		}
		
		string output = receiptFromResponsibleWorker;
		output += $"""
	
		[Клиента обслужил]
		Ответственный рабочий: { firstName } { lastName } ({ email })
	
		""";

		onlineStore.longReceiptLog.Add(output);
	}
	
	public ResponsibleWorker sendResponsibleWorker() {
		return new ResponsibleWorker(
			firstName: "Melanie",
			lastName: "Sielione",
			email: "siemela@aol.com"
		);
	}
	
	public Admin(string firstName, string lastName, string email) : base(firstName, lastName, email) {
		this.firstName = firstName;
		this.lastName = lastName;
		this.email = email;
		
	}
}