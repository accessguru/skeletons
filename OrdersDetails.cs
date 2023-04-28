namespace Skeleton
{
    public class OrdersDetails
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public double Freight { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShipCity { get; set; }
    }
}
