using DesignPatterns.ChainOfResponsibility;

public class Program
{
    private static void Main(string[] args)
    {
        // create the chain links
        Approver jennifer = new HeadChef();
        Approver mitchell = new PurchasingManager();
        Approver olivia = new GeneralManager();

        //create the chain
        jennifer.SetSupervisor(mitchell);
        mitchell.SetSupervisor(olivia);

        //Generate and process purchase requests
        PurchaseOrder p =new PurchaseOrder(1,20,69,"Spices");
        jennifer.ProcessRequest(p);

        p = new PurchaseOrder(2, 300, 1389, "Fresh Veggies");
        jennifer.ProcessRequest(p);

        p = new PurchaseOrder(3, 500, 4823.99, "Beef");
        jennifer.ProcessRequest(p);


    }
}