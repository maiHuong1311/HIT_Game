using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace Bai3
{
    internal class Program
    {
        struct Product
        {
            public string name;
            public double price;
            public int quantity;
            public string category;

            public Product(string name, double price, int quantity, string category)
            {
                this.name = name;
                this.price = price;
                this.quantity = quantity;
                this.category = category;
            }
            public void showInfo()
            {
                Console.WriteLine("Ten hang: " + name + ", gia: " + price + ", so luong ban: " + quantity + ", danh muc: " + category);
            }
        }
        static void Main(string[] args)
        {
            products.Add("P002", new Product("Tra sua", 40000, 15, "Do uong"));
            products.Add("P001", new Product("Banh mi", 15000, 20, "Do an"));
            products.Add("P003", new Product("Kem", 10000, 15, "Do an vat"));
            Console.WriteLine("-----QUAN LY BAN HANG-----");
            Console.WriteLine("1. Cap nhap hoac them san pham");
            Console.WriteLine("2. Tra thong tin san pham");
            Console.WriteLine("3. San pham ban chay nhat theo so luong");
            Console.WriteLine("4. San pham ban chay nhat theo danh muc");
            Console.WriteLine("5. Doanh thu theo danh muc");
            Console.WriteLine("6. Thoat");
            while(true)
            {
                Console.Write("Lua chon: ");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch(choose)
                {
                    case 1:
                        Console.Write("Nhap ma san pham: ");
                        string code = Console.ReadLine();
                        Console.Write("Nhap ten san pham: ");
                        string name = Console.ReadLine();
                        Console.Write("Nhap gia ban: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Nhap so luong ban: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nhap danh muc: ");
                        string category = Console.ReadLine();
                        AddOrUpdateProduct(code, name, price, quantity, category);
                        break;
                    case 2:
                        Console.Write("Nhap ma san pham muon tra thong tin: ");
                        string code1 = Console.ReadLine();
                        ShowInformationProduct(code1);
                        break;
                    case 3:
                        BestSellingProcduct();
                        break;
                    case 4:
                        BestSellingByCategory();
                        break;
                    case 5:
                        RevenueByCategory();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Lua chon loi");
                        break;
                }
            }
        }
        static Dictionary<string, Product> products = new Dictionary<string, Product>();
        public static void AddOrUpdateProduct(string code, string name, double price, int quantity, string category)
        {
            if(products.ContainsKey(code))
            {
                Product existed = products[code];
                existed.quantity += quantity;
                products[code] = existed;
                Console.WriteLine("Cap nhat thanh cong");
            }
            else
            {
                products[code] = new Product(name, price, quantity, category);
                Console.WriteLine("Them thanh cong");
            }

        }
        public static void ShowInformationProduct(string code)
        {
            if (products.ContainsKey(code))
            {
                Console.WriteLine("Thong tin san pham");
                products[code].showInfo();
            }
            else
                Console.WriteLine("Khong co san pham muon tim");
        }
        public static void BestSellingProcduct()
        {
            if(products.Count == 0)
                Console.WriteLine("Khong co san pham nao");
            else
            {
                int max = 0;
                string name = "null";
                foreach(KeyValuePair<string, Product> item in products)
                {
                    if(item.Value.quantity > max)
                    {
                        max = item.Value.quantity;
                        name = item.Value.name;
                    }
                }
                Console.WriteLine("San pham ban chay nhat la " + name + " voi so luong la " + max);
            }
        }
        public static void BestSellingByCategory()
        {
            Dictionary<string, Product> BestByCategory = new Dictionary<string, Product>();
            foreach(Product p in products.Values)
            {
                string category = p.category;
                if (!BestByCategory.ContainsKey(category)) {
                    BestByCategory[category] = p;
                }
                else
                {
                   if(p.quantity > BestByCategory[category].quantity)
                   {
                        BestByCategory[category] = p;
                   }
                }
            }
            foreach(Product p in BestByCategory.Values)
            {
                p.showInfo();
            }
        }
        public static void RevenueByCategory()
        {
            Dictionary<string, double> revenueByCategory = new Dictionary<string, double>();

            foreach (Product p in products.Values)
            {
                double revenue = p.price * p.quantity;
                if (revenueByCategory.ContainsKey(p.category))
                    revenueByCategory[p.category] += revenue;
                else
                    revenueByCategory[p.category] = revenue;
            }
            foreach(KeyValuePair<string, double> p in revenueByCategory)
            {
                Console.WriteLine("Doanh thu cua " + p.Key + " la " + p.Value);
            }
        }
    }
}
