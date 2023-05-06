namespace Module7.Delivery.Base
{
    abstract class DeliveryBase
    {
        public string Address;
        public string Phone;
        public string this[string param]
        {
            get
            {
                switch (param)
                {
                    case "Adress":
                        return Address;
                    case "Phone":
                        return Phone;
                    default: return null;
                }
            }
            set
            {
                switch (param)
                {
                    case "Adress":
                        Address = value;
                        break;
                    case "Phone":
                        Phone = value;
                        break;
                }
            }
        }

        public abstract void DeliveryTime();
    }
}
