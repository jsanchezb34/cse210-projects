public class Breathing : activity
{
    public Breathing() : base("breathing",
    "This activity will help you relax by walking you through \nbreathing in and out slowly.")
    {
    }
    public void Run()
    {
        Start();
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("inhaling");
            Showspinnner(5);
            Console.Write("Exhaling");
            Showspinnner(5);
            elapsed += 10;
        }
        End();
    }
}
