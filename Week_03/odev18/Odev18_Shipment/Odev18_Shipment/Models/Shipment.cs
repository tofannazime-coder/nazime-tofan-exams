using System;
namespace Odev18_Shipment.Models;
public class Shipment
{
    public Shipment(string teackingNumber, string senderName, string receiveName, DateTime shipDate,double weightKg )
    {
        TrackingNumber = teackingNumber;
        SenderName = senderName;
        ReceiverName = receiveName;
        ShipDate = shipDate;
        WeightKg = weightKg;
    }

    public String TrackingNumber { get; set;}
    public String SenderName { get; set; }
    public String ReceiverName { get; set; }
    public DateTime ShipDate { get; set;}
    public double WeightKg { get; set;}
}