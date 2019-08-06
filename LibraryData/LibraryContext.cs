using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LibraryData
{
    public class LibraryContext : DbContext //use cntrl+. to use core , DbContext is kind of the main database
    {
        public LibraryContext (DbContextOptions options ) : base(options) { } //Constructor
        public DbSet<Patron> Patrons { get; set; } //kind of representing a table in database 
        //tables are going to mapped to patron object adn then properties of that patron object will map the columns in that patrons table
    }
}
