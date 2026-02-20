namespace LINQ
{
    public class PeopleList
    {
        public static readonly List<People> peoples = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Mona",
                Age = 21,
                GenderId = Guid.Parse("18b4f75d-482a-44e7-a4a0-49f9580777e9")
            },
            new People()
            {
                Id = 2,
                Name = "Pona",
                Age = 31,
                GenderId = Guid.Parse("dc59ee8c-dac2-4e45-ac11-551136bbc9ba")
            },
            new People()
            {
                Id = 3,
                Name = "Ron",
                Age = 26,
                GenderId = Guid.Parse("a8563d88-db10-4c38-bf68-97917e2b4990")
            },
            new People()
            {
                Id = 4,
                Name = "Robin",
                Age = 20,
                GenderId = Guid.Parse("604ffb6a-8ff8-48eb-b448-71b48592592d")
            },
            new People()
            {
                Id = 5,
                Name = "Mari",
                Age = 28,
                GenderId = Guid.Parse("586b2074-e323-45ed-a354-56a6dd8857cc")
            },
            new People()
            {
                Id = 6,
                Name = "Mari",
                Age = 18,
                GenderId = Guid.Parse("15fc8042-8399-4c6e-8034-fe84d3b7827e")
            },
            
        };
    }  
}
