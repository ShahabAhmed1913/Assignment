// See https://aka.ms/new-console-template for more information
using Assignment;

Car car1 = new Car(1, "City", "ABC-1234", "Honda", 2, "Car");
car1.PayTax((int)car1.BasePrice);

Car car2 = new Car(2, "Altis", "DEF-5678", "Toyota", 2, "Car");
car2.PayTax((int)car2.BasePrice);

Car car3 = new Car(3, "Model X", "GHI-9012", "Tesla", 2, "Car");
car3.PayTax((int)car3.BasePrice);

Car car4 = new Car(4, "Wagon R", "JKL-3456", "Suzuki", 2, "Car");
car4.PayTaxPassWithoutPaying();

Car car5 = new Car(5, "Camaro", "MNO-7890", "Chevrolet", 2, "Car");
car5.PayTaxPassWithoutPaying();

Car car6 = new Car(6, "Accord", "ABC-1234", "Honda", 2, "Car");
car6.PayTax((int)car6.BasePrice);


Bike bike1 = new Bike(6, "GS 150", "PQR-1122", "Honda", 1, "Bike");
bike1.PayTax((int)bike1.BasePrice);

Bike bike2 = new Bike(7, "MT-15", "STU-3344", "Yamaha", 1, "Bike");
bike2.PayTax((int)bike2.BasePrice);

Bike bike3 = new Bike(8, "RC 390", "VWX-5566", "KTM", 1, "Bike");
bike3.PayTaxPassWithoutPaying();


HeavyCar hc1 = new HeavyCar(9, "FH16", "HV-1122", "Volvo", 4, "HeavyCar");
hc1.PayTax((int)hc1.BasePrice);

HeavyCar hc2 = new HeavyCar(10, "Actros 2645", "HV-3344", "Mercedes-Benz", 4, "HeavyCar");
hc2.PayTaxPassWithoutPaying();

HeavyCar hc3 = new HeavyCar(11, "LPT 3118", "HV-5566", "Tata", 4, "HeavyCar");
hc3.PayTax((int)hc3.BasePrice);

HeavyCar hc4 = new HeavyCar(12, "LP 4518", "HV-4566", "Tata", 4, "HeavyCar");
hc3.PayTax((int)hc3.BasePrice);


Console.WriteLine("Total Tax Collection: RS " + ToolVehicle.TotalTaxCollected);
Console.WriteLine("Total Tax Pay Vehicles: " + ToolVehicle.TotalTaxPayingVehicles);
Console.WriteLine("Total NO Tax Pay Vehicles: " + ToolVehicle.TotalNonTaxPayingVehicles);
Console.WriteLine("Total Vehicle Entry: " + ToolVehicle.TotalVehicles);
