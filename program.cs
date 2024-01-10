using System;
class program
{
    static void Main()
    {
        Book[] libraryCataLog = new Book[]
        {
            new FictionBook("mmd", "amin", 13, "mokhtari"),
            new FictionBook("mmd", "amin", 12, "mokhtari"),
            new NonFictionBook("mmd", "amin", 1, "mokhtari"),
            new NonFictionBook("mmd", "amin", 23, "mokhtari")
        };
        library.DisPlay(libraryCataLog);
    }
}