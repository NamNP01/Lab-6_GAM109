using System;
using System.Collections.Generic;
using System.Linq;

public class ShopLab6
{
    public int id;
    public string name;
    public string des;

    public ShopLab6(int id, string name, string des)
    {
        this.id = id;
        this.name = name;
        this.des = des;
    }
}

public class PhoneLab6
{
    public int id;
    public int shop_id;
    public string name;
    public int price;
    public string des;

    public PhoneLab6(int id, int shop_id, string name, int price, string des)
    {
        this.id = id;
        this.shop_id = shop_id;
        this.name = name;
        this.price = price;
        this.des = des;
    }
}

public class Program
{
    public static void Main()
    {
        List<ShopLab6> listShop = new List<ShopLab6>();
        listShop.Add(new ShopLab6(1, "HCM", "Quận 12"));
        listShop.Add(new ShopLab6(2, "Hà Nội", "Quận Nam từ liêm"));
        listShop.Add(new ShopLab6(3, "Đà Nẵng", "Quận Hải châu"));

        List<PhoneLab6> listPhone = new List<PhoneLab6>();
        listPhone.Add(new PhoneLab6(1, 1, "IP 15", 100, "độc lạ bình dương"));
        listPhone.Add(new PhoneLab6(2, 2, "IP 16", 1000, "độc lạ bình dương"));
        listPhone.Add(new PhoneLab6(3, 3, "IP 17", 10000, "độc lạ bình dương"));
        listPhone.Add(new PhoneLab6(4, 1, "IP 18", 100000, "độc lạ bình dương"));

        var query = from phone in listPhone
                    join shop in listShop on phone.shop_id equals shop.id
                    select new { ShopName = shop.name, PhoneName = phone.name };
        Console.WriteLine("Cau a");

        foreach (var item in query)
        {
            Console.WriteLine($"ShopName: {item.ShopName}, PhoneName: {item.PhoneName}");
        }
        Console.WriteLine("Cau b");
        var result = listShop.GroupJoin(
            listPhone,
            shop => shop.id,
            phone => phone.shop_id,
            (shop, phones) => new
            {
                ShopName = shop.name,
                Phones = phones
            }
        );
        foreach (var item in result)
        {
            Console.WriteLine($"ShopName: {item.ShopName}");
            Console.WriteLine(new string('-', 20));
            foreach (var phone in item.Phones)
            {
                Console.WriteLine($"phoneName: {phone.name}");
                Console.WriteLine($"phonePrice: {phone.price}");
                Console.WriteLine(new string('-', 20));
            }
        }
    }
}
