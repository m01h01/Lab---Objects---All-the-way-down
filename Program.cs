namespace Lab___Objects___All_the_way_down
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an instance of company's name, so we can call back to check for inventory
            WalletCompany McKoy = new WalletCompany();

            //public WalletCreated(double originalCost, double price, Brands brands, Material material, Style style, Pattern pattern, CompartmentType compartmentType)

            //Create those needed objects for a Wallet
            double originalPrice = 50;
            double sellingPrice = 120;
            CompartmentType compartmentType = new CompartmentType(CompartmentType.Compartment.IDcard);    
            Pattern pattern = new Pattern (Pattern.Patterns.Camouflage);
            Brands brand = new Brands(Brands.Brand.Tumi);
            Style style = new Style(Style.Styles.Classic);
            Material material = new Material(Material.Materials.Suede);


            //Aggregation- pass in those objects to create an instance of Wallet
            WalletCreated wal1 = new WalletCreated(originalPrice, sellingPrice, brand, material, style, pattern, compartmentType);
            Console.WriteLine(wal1 +"\n");

            WalletCreated wal2 = new WalletCreated(70, 130, new Brands(Brands.Brand.Levis), new Material(Material.Materials.Leather),
                new Style(Style.Styles.Modern), new Pattern(Pattern.Patterns.Chevron),
                new CompartmentType(CompartmentType.Compartment.CheckBook));
            Console.WriteLine(wal2 + "\n");

            //Adding those watches to company inventory
            McKoy.AddInventory(wal1);
            McKoy.AddInventory(wal2);

            //Accessing the first wallet from the list
            WalletCreated firstWallet = McKoy.Created[0];

            //Get to access any kind of objects that exist in the firstWallet
            Brands firstBrand = firstWallet.Brands;
            Console.WriteLine($"The first wallet that has created: Brand:"+firstBrand + "\n");

            //Accessing the list to know how many wallets have been created
            Console.WriteLine(McKoy);

        }
    }
}