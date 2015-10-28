using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSWLibrary.Models;
using System.Data.Entity;

namespace CSWLibrary.DAL
{
    public class LibraryInitializer : DropCreateDatabaseIfModelChanges<LibraryContext>
    {
        public override void InitializeDatabase(LibraryContext context)
        {
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction
                , string.Format("ALTER DATABASE {0} SET SINGLE_USER WITH ROLLBACK IMMEDIATE", context.Database.Connection.Database));

            base.InitializeDatabase(context);
        }

        protected override void Seed(LibraryContext context)
        {
            var books = new List<Book>
            {
                new Book{Title="Cien años de soledad",Category="Fiction",Author="Gabriel Garcia Marquez"},
                new Book{Title="In search of lost time",Category="Drama",Author="Marcel Proust"},
                new Book{Title="Mourinho on Football : The Beautiful Game and Me",Category="Sports",Author="Jose Mourinho"},
                new Book{Title="Blood on Snow",Category="Crime",Author="Jo Nesbo"},
                new Book{Title="Essential Scrum : A Practical Guide to the Most Popular Agile Process",Category="Software",Author="Kenneth S. Rubin"},
                new Book{Title="The Adobe Photoshop Lightroom CC Book for Digital Photographers",Category="Photography",Author="Scott Kelby"},
                new Book{Title="Clean Code : A Handbook of Agile Software Craftsmanship",Category="Software",Author="Robert C. Martin"},
                new Book{Title="Adobe Photoshop CS6 Classroom in a Book",Category="Photography",Author="Adobe Creative Team"},
                new Book{Title="The Photoshop Workbook : Professional Retouching and Compositing Tips, Tricks, and Techniques",Category="Photography",Author="Glyn Dewis"},
                new Book{Title="Into Thin Air : A Personal Account of the Everest Disaster",Category="Sports",Author="Jon Krakauer"},
                new Book{Title="Memory Man",Category="Crime",Author="David Baldacci"},
                new Book{Title="Soppy",Category="Humour",Author="Philippa Rice"},
                new Book{Title="The Dogs of Riga : Kurt Wallander",Category="Crime",Author="Henning Mankell"},
                new Book{Title="Voyager",Category="Romance",Author="Diana Gabaldon"},
                new Book{Title="Anna Karenina",Category="Romance",Author="Leo Tolstoy"},
                new Book{Title="Leading",Category="Sports",Author="Alex Ferguson"},
                new Book{Title="It's Not Me, it's You",Category="Romance",Author="Mhairi McFarlane"},
                new Book{Title="Rick Stein: From Venice to Istanbul",Category="Food",Author="Rick Stein"},
                new Book{Title="William Shakespeare's the Phantom Menace",Category="Fiction",Author="Ian Doescher"},
                new Book{Title="Nopi: The Cookbook",Category="Food",Author="Ebury Press"},
                new Book{Title="The Bro Code",Category="Humour",Author="Barney Stinson"},
                new Book{Title="Social Eats : Food to Impress Your Mates",Category="Food",Author="Jimmy Garcia"},
                new Book{Title="The Very Hungover Caterpillar",Category="Humour",Author="Emlyn Rees"},
                new Book{Title="Memories",Category="Poetry",Author="Lang Leav"},
                new Book{Title="Dragonfly in Amber",Category="Romance",Author="Diana Gabaldon"}
            };
            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();
        }
    }
}