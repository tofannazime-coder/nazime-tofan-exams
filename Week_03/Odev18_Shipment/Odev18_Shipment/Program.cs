
namespace Odev18_Shipment.Models;

class Program
{
    static void Main(string[] args)
    {
        List<Shipment> shipments = new List<Shipment>();
        Shipment shipment1 = new Shipment("TR657488", "Ömer Bilir", "Pınar Gül", DateTime.Now, 12.5);
        Shipment shipment2 = new Shipment("TR582058", "Can Öztürk", "Evin Şen", DateTime.Now, 8.2);
        Shipment shipment3 = new Shipment("TR929238", "Mehmet Kıran", "Rukiye Tofan", DateTime.Now, 13.3);


        shipments.Add(shipment1);
        shipments.Add(shipment2);
        shipments.Add(shipment3);


        Shipment? maxShipment = null;
        double maxWeight = 0;

        foreach (Shipment shipment in shipments)
        {
            if (shipment.WeightKg > maxWeight)
            {
                maxShipment = shipment;
                maxWeight = shipment.WeightKg;
            }

        }
       
       Console.WriteLine($"En ağır gönderi takip : {maxShipment.TrackingNumber} | Ağırlık : {maxShipment.WeightKg} kg | Gönderi : {maxShipment.SenderName}  | Alıcı : {maxShipment.ReceiverName} ");
    }

}