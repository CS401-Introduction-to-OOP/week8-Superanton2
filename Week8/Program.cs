// Етап 3. Тестування в Program.cs (~10 хв)
// 5. Виведiть у консоль загальну вартiсть доставки всiх елементiв у контейнерi, викликавши GetTotalCost().
using Week8;

Letter letter1 = new Letter("L1", 0.5);
Letter letter2 = new Letter("L2", 1.5);

Parcel parcel1 = new Parcel("P1", 12, "10x10x20");
Parcel parcel2 = new Parcel("P2", 15, "150x20x20");

letter1.PrintInfo();
parcel2.PrintInfo();

CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
myCargo.AddItem(letter1);
myCargo.AddItem(letter2);
myCargo.AddItem(parcel1);
myCargo.AddItem(parcel2);

Console.WriteLine();
Console.WriteLine("All cost: " + myCargo.GetTotalCost());