using DPHW2Phone;


Phone phone = new Iphone11ProMax(new Iphone());
Console.WriteLine("Name : "+ phone.GetName());
Console.WriteLine("Price : "+ phone.GetPrice());
Console.WriteLine("Camare Count : "+ phone.GetCamreaCount());
Console.WriteLine("\n\n");
Phone phone1 = new Iphone11Pro(new Iphone());
Console.WriteLine("Name : "+ phone1.GetName());
Console.WriteLine("Price : "+ phone1.GetPrice());
Console.WriteLine("Camare Count : "+ phone1.GetCamreaCount());
Console.WriteLine("\n\n");
Phone phone2 = new Iphone11(new Iphone());
Console.WriteLine("Name : "+ phone2.GetName());
Console.WriteLine("Price : "+ phone2.GetPrice());
Console.WriteLine("Camare Count : "+ phone2.GetCamreaCount());





