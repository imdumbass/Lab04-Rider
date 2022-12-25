public static class ConsoleHelper {
	public static string ReadStringLine(string message, char separator = ' ') {
		Console.Write(message + separator);
		
		string consoleInput;
		do {
			consoleInput = Console.ReadLine();
		} while (String.IsNullOrEmpty(consoleInput));

		return consoleInput;
	}

	public static int ReadInt(string message = "", char separator = ' ') {
		while (true) {
			string stringLine = ReadStringLine(message: message, separator: separator);
			
			if (int.TryParse(stringLine, out int converted)) {
				return converted;
			}
		}
	}
}