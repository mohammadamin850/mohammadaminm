 class FictionBook :Book
    {
        public string Guner{get; set;}

        public FictionBook(string title, string auther, int page , string guner) : base (title,auther, page)
        {
                Guner = guner;
        }
        public override void Add()
        {
            Console.WriteLine( $"Guner : {Guner}" );
        }
    }
