using System;

namespace ClassLib
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string AddressName { get; set; }
        public string ClientName { get; set; }
        public int Code { get; set; }
        public string Status { get; set; }

        public Order(int id, DateTime orderDate, DateTime arrivalDate, string addressName, string clientName, int code, string status)
        {
            Id = id;
            OrderDate = orderDate;
            ArrivalDate = arrivalDate;
            AddressName = addressName;
            ClientName = clientName;
            Code = code;
            Status = status;
        }

    }
}
