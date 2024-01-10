class NonFictionBook : Book
{
    public string Topic { get; set; }

    public NonFictionBook(string title, string auther, int page, string topic) : base (title, auther , page)
    {
        Topic = topic;
    }
    public override void Add()
    {
        Console.WriteLine($"Topic : {Topic}");
    }
}
