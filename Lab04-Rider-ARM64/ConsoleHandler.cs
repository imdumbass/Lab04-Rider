namespace Lab04_Rider_ARM64; 

public class ConsoleHandler {
	public OnlineStore onlineStore;

	public void catalogue() {
		Console.WriteLine("""
		1. Сервисы
		2. Портативные устройства
		3. Сервера 
		""");

		switch (ConsoleHelper.ReadInt(message: ">>")) {
			case 1:
				break;
			case 2:
				break;
			case 3:
				break;

		}
		
	}
	
	public ConsoleHandler(OnlineStore onlineStore) {
		this.onlineStore = onlineStore;
	}
}