namespace Lab04_Rider_ARM64.Categories.Portable; 

public class Portable: Category {
	public class iPhone: Category {
		public override string getCategoryName() {
			return "iPhone";
		}
		
		public static List<Item> items = new() {
			new Item(
				title: "iPhone 11 (64 GB)",
				price: 590,
				ID: "AAPL-IPHONE-11-64GB"
			),
			new Item(
				title: "iPhone 12 (128 GB)",
				price: 790,
				ID: "AAPL-IPHONE-12-128GB"
			),
			new Item(
				title: "iPhone 13 (128 GB)",
				price: 890,
				ID: "AAPL-IPHONE-13-128GB"
			),
		};
	}
	
	public class iPad: Category {
		public override string getCategoryName() {
			return "iPad";
		}
		
		public static List<Item> items = new() {
			new Item(
				title: "iPad Pro 12.9 (2018) 512GB",
				price: 790,
				ID: "AAPL-IPAD-PRO-2018-212GB"
			),
			new Item(
				title: "iPad 2 (Wi-Fi) 16GB",
				price: 49,
				ID: "AAPL-LEGACY-IPAD-2-16GB"
			),
			new Item(
				title: "iPad Air (2018) 128GB",
				price: 890,
				ID: "AAPL-IPAD-AIR-2018-128GB"
			),
		};
	}

	public override string getCategoryName() {
		return "Портативные устройства";
	}
}