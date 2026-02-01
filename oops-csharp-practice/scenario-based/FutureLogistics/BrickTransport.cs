using System;
namespace FutureLogistics
{
    class BrickTransport:GoodsTransport
    {
        private float brickSize;
        private int brickQuantity;
        private float brickPrice;
        public BrickTransport(string transportId,string transportDate,int transportRating,float brickSize,int brickQuantity,float brickPrice) : base(transportId, transportDate, transportRating)
        {
            this.brickSize=brickSize;
            this.brickQuantity=brickQuantity;
            this.brickPrice=brickPrice;
        }

        public float BrickSize
        {
            get
            {
                return brickSize;
            }
            set
            {
                brickPrice=value;
            }
        }
        public int BrickQuantity
        {
            get{return brickQuantity;}
            set{brickQuantity=value;}
        }
        public float BrickPrice
        {
            get{return brickPrice;}
            set{brickPrice=value;}
        }

        public override string VehicleSelection()
        {
            if (BrickQuantity < 300)
            {
                return "Truck";
            }
            else if(BrickQuantity>=300 && BrickQuantity <= 500)
            {
                return "Lorry";
            }
            else
            {
                return "MonsterLorry";
            }
        }
        
        public override float CalculateTotalCharge()
        {
            float price=BrickPrice*brickQuantity;
            float tax=price*0.3f;
            float discount=0;
            float vehiclePrice=0;
            if (VehicleSelection() == "Truck")
            {
                vehiclePrice=1000;
            }
            else if (VehicleSelection() == "Lorry")
            {
                vehiclePrice=1700;
            }
            else if(VehicleSelection() == "MonsterLorry")
            {
                vehiclePrice=3000;
            }
            
            if (TransportRating == 5)
            {
                discount=price*0.20f;
            }
            else if(TransportRating==3 || TransportRating == 4)
            {
                discount=price*0.10f;
            }
            else
            {
                discount=0;
            }
            float totalCharge=(price+tax+vehiclePrice)-discount;
            return totalCharge;
        }
    }
}