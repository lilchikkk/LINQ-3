namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere!");
            //tuleb teha class nimega PeopleList
            //seal on kuus rida andmed
            //kindlasti peab olema kaks Mari nimega isikut
            //aga erinevate vanusega
            Console.WriteLine("1.ThenByLINQ");
            Console.WriteLine("2.ThenbydescendingLINQ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ThenByLINQ();
                    break;
                case 2:
                    ThenbydescendingLINQ();
                    break ;
                case 3:
                    SelectLINQ();
                    break;
                default:
                    Console.WriteLine("vale valik");
                    break;
            }
        }

        //kutsuda meetod switchi esile
        public static void ThenByLINQ()
        {
            //thenby sorteerib numbrilise järjestuses
            var thenByResult = PeopleList.peoples
                .OrderBy(x => x.Name)
                .ThenBy(x => x.Age);

            Console.WriteLine("ThenBy järgi sorteerimine");
            foreach (var person in thenByResult)
            {
                Console.WriteLine(person.Name + " " + person.Age);
            }
        }

        //samusugune nagu eelmine, aga kasutage
        //thenbydescending
        public static void ThenbydescendingLINQ()
        {
            var thenByResult = PeopleList.peoples
               .OrderBy(x => x.Name)
               .ThenByDescending(x => x.Age);

            Console.WriteLine("ThenBy järgi sorteerimine");
            foreach (var person in thenByResult)
            {
                Console.WriteLine(person.Name + " " + person.Age);
            }
        }

        public static void SelectLINQ()
        {
            //select lihtsalt tagastab andmed nii nagu need
            //on andmebaasis, sama hea, mis SQL select
            var result = PeopleList.peoples
                    .Select(x => new
                    {
                        Name = x.Name,
                        Age = x.Age,
                    });

            Console.WriteLine("SelectLINQ järgi sorteerimine");
            foreach (var person in result)
            {
                Console.WriteLine(person.Name + " " + person.Age);
            }
        }
    }  
}
