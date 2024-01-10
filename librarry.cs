class library
{
    public static void DisPlay(Book[] books)
    {
        foreach (var book in books)
        {
            Console.WriteLine("------");
            book.DisPlay();
            book.Add();
            Console.WriteLine("------");
        }
    }
}