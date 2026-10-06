using LibraryApp;

Book book = new Book();

// This is info for the book class

book.Title = "C# for Beginners";
book.Author = "Bill Gates";
book.ISBN = 1234567890;
book.DisplayInfo();

// adding another book
Book book1 = new Book();

book1.Title = "Methods and Classes";
book1.Author = "Microsoft";
book1.ISBN = 987654321;
book1.DisplayInfo();