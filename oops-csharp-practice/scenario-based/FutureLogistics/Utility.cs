using System;
using System.Text.RegularExpressions;
namespace FutureLogistics
{
    class Utility
    {
        public GoodsTransport ParseDetails(string input)
        {
            string pattern=@"[:]";
            string[] data=Regex.Split(input,pattern);
            if (data[3].Equals("BrickTransport", StringComparison.OrdinalIgnoreCase))
            {
                
                GoodsTransport good=new BrickTransport(data[0],data[1],int.Parse(data[2]),float.Parse(data[4]),int.Parse(data[5]),float.Parse(data[6]));
                return good;
            }
            else
            {
                GoodsTransport good=new TimberTransport(data[0],data[1],int.Parse(data[2]),float.Parse(data[4]),float.Parse(data[5]),data[6],float.Parse(data[7]));
                return good;
            }
        }

        public bool ValidateTransportId(string transportId)
        {
            string pattern=@"^RTS[0-9]{3}[A-Z]{1}$";
            if(Regex.IsMatch(transportId, pattern))
            {
                return true;
            }
            else
            {
                System.Console.WriteLine($"Transport id {transportId} is invalid \nPlease provide a valid record");
                return false;
            }
            
            
        }

        public string FindObjectType(GoodsTransport goodsTransport)
        {
            if(goodsTransport is TimberTransport)
            {
                return "TimberTransport";
            }
            else
            {
                return "BrickTransport";
            }
        }
    }
}