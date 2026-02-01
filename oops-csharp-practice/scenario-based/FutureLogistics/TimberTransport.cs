using System;
namespace FutureLogistics
{
    class TimberTransport:GoodsTransport
    {
        private float timberLength;
        private float timberRadius;
        private string timberType;
        private float timberPrice;
        public TimberTransport(string transportId,string transportDate,int transportRating,float timberLength,float timberRadius,string timberType,float timberPrice): base(transportId, transportDate, transportRating) 
        {
            this.timberLength=timberLength;
            this.timberRadius=timberRadius;
            this.timberType=timberType;
            this.timberPrice=timberPrice;
        }
        public float TimberLength
        {
            get{return timberLength;}
            set{timberLength=value;}
        }
        public float TimberRadius
        {
            get{return timberRadius;}
            set{timberRadius=value;}
        }
        public string TimberType
        {
            get{return timberType;}
            set{timberType=value;}
        }
        public float TimberPrice
        {
            get{return timberPrice;}
            set{timberPrice=value;}
        }
        public override string VehicleSelection()
        {
            float area=2*3.147f*TimberRadius*TimberLength;
            if (area < 250)
            {
                return "Truck";
            }
            else if(area>=250 && area <= 400)
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
            float price=0;
            float volume=3.147f*TimberRadius*TimberRadius*TimberLength;
            if (TimberType == "Premium")
            {
                price=volume*TimberPrice*0.25f;
            }
            else
            {
                price=volume*TimberPrice*0.15f;
            }

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

            float tax=price*0.3f;

            float discount=0;
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
            
            float totalCharge=(price+vehiclePrice+tax)-discount;
            return totalCharge;
        }

    }
}