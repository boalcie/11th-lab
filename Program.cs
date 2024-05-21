using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }
    public bool IsAvailable { get; set; }
    public List<string> Genres { get; set; }
}
public class Program
{
    static void Main(string[] args)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Book));
        StringWriter sw = new StringWriter();
        string xmlString = sw.ToString();
        StringReader stringReader = new StringReader(xmlString);
        Book desedeserializedBook = (Book)serializer.Deserialize(stringReader);


        /*
        var bookjson = File.ReadAllText("book.json");
        Book deserializedBook = JsonSerializer.Deserialize<Book>(bookjson);
        
        
        serializer.Serialize(sw,book);
        
        Console.WriteLine(xmlString);
        string jsonstring = JsonSerializer.Serialize(book);
        File.WriteAllText("book.json", jsonstring);

        Book book = new Book
        {
            Title = "Harry Potter and the Philosopher's Stone",
            Author = "J. K. Rowling",
            PublicationYear = 1997,
            IsAvailable = true,
            Genres = new List<string> { }
        };
        */
    }
}