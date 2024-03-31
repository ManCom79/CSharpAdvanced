namespace Models
{
    public class Boat : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"I'm a boat and I do not have any wheels :-(");
        }
    }
}
