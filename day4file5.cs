using System;

	public class Product
	{
		public string action { get; set; }
		public int Quantity { get; set; }
		public int currentQuantity { get; set; }
 		public void GetProductDetails()
		{
			Console.WriteLine("Enter action :");
			action = Console.ReadLine();
		}
	}
	class Invoice:Product
	{
		public void PrintInvoice()
		{
			currentQuantity=100;
			Console.WriteLine("Quantity before Any Actions :"+currentQuantity);
			if(action == "Add")
			{
				Console.WriteLine("Enter Product Quantity to add :");
				Quantity = Convert.ToInt32(Console.ReadLine());
				currentQuantity=currentQuantity+Quantity;
				Console.WriteLine("Quantity-after adding  :" +currentQuantity);
			}
			else if(action == "Buy")
			{
				Console.WriteLine("Enter Product Quantity to buy  :");
				Quantity = Convert.ToInt32(Console.ReadLine());
				currentQuantity=currentQuantity-Quantity;
				Console.WriteLine("Quantity-left after buying  :" +currentQuantity);
			}
			
		}
	}
	public class User
	{
		public static void Main()
		{
			Invoice invoice = new Invoice();
			for(;;)
			{
			  Console.WriteLine("You Want to Exit : Y/N");
			    string choice = Console.ReadLine();
			    if(choice.ToLower()=="n")
			    {
			       invoice.GetProductDetails();
			       invoice.PrintInvoice();
			    }
			    else
			    {
			       break;
			    }
			}
		}
	}
	