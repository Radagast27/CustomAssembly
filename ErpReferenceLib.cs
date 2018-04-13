namespace SSRSCustomAssembly
{
    public class ErpReferenceLib
    {
        public static string GetImageForCustomerAccount(int customerID)
        {
            //this example is static; in real-world implementation the customerID might fetch value from db or API
            bool isActiveAndValid = CheckCustomerIDIsValidAndActive(customerID);
            if (isActiveAndValid)
            {
                return "https://abccorp.imagesrv?customerID=" + customerID + ".svg";
            }
            else
            {
                return "https://abccorp.imagesrv?inactive.svg";
            }
        }

        public static bool CheckCustomerIDIsValidAndActive(int customerID)
        {
            return customerID >= 100 ? true : false;
        }
    }
}