using System;
namespace FutureLogistics
{
    class UserInterface
    {
        static void Main(string[] args)
        {
            Utility obj=new Utility();
            System.Console.WriteLine("Enter the Goods Transport details");
            string input=Console.ReadLine();
            var good=obj.ParseDetails(input);
            if (obj.ValidateTransportId(good.TransportId))
            {
                string objectType=obj.FindObjectType(good);
                if(objectType =="TimberTransport")
                {
                    TimberTransport timber = (TimberTransport)good;
                    System.Console.WriteLine($"Transport id : {timber.TransportId} \nDate of Transport : {timber.TransportDate} \nRating of the transport : {timber.TransportRating} \nType of the timber : {timber.TimberType} \nTimber price per kilo : {timber.TimberPrice} \nVehicle for transport : {timber.VehicleSelection()} \nTotal charge : {timber.CalculateTotalCharge()}");

                }
                else 
                {
                    BrickTransport brick= (BrickTransport)good;
                    System.Console.WriteLine($"Transport id : {brick.TransportId} \nDate of Transport : {brick.TransportDate} \nRating of the transport : {brick.TransportRating} \nQuantity of bricks : {brick.BrickQuantity} \nBrick price : {brick.BrickPrice} \nVehicle for transport : {brick.VehicleSelection()} \nTotal charge : {brick.CalculateTotalCharge()}");
                }
            }
            else
            {
                return;
            }
        }
    }
}