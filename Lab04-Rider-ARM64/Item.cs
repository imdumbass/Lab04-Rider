public class Item {
	public string title { get; }
	public UInt32 price { get; }
	public string ID { get; }

	public Item(string title, UInt32 price, string ID) {
		this.title = title;
		this.price = price;
		this.ID = ID;
	}
}
