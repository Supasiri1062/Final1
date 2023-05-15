class program {
    static void Main(string[] args) {
        int[] num = new int[10]; 
        Console.Write("Input town numbers: ");
        int TownNumber = int.Parse(Console.ReadLine());
        int CovidOverall = 0;

        Console.Write("Input Town Name: ");
        string TownName = (Console.ReadLine());

        Console.Write("Input Neighbor Town: ");
        int NeighborTown = int.Parse(Console.ReadLine());

        Console.WriteLine();
        int NeighborTown2 = int.Parse(Console.ReadLine());

        if((NeighborTown2 ==  NeighborTown) && (NeighborTown2 > TownNumber))
        {
            Console.WriteLine("Invalid ID");
        }

        Console.WriteLine("{0},{1},{2}" , TownNumber , TownName , CovidOverall);

        Console.Write("Input upcoming COVID: ");
        string upcoming = (Console.ReadLine());

        if((upcoming == "Outbreak") || (upcoming == "Vaccinate") || (upcoming == "Lockdown")) {
            Console.WriteLine("Location: ");
            int Location = int.Parse(Console.ReadLine());
        }
        else if(upcoming == "Spread"){
            CovidOverall++;
        }

        


    }
}
