using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class Post
{
    public int Id { get; set; }
    public int Cost { get; set; }

    public Owner Owner { get; set; }
    public int OwnerId { get; set; }
    public Apartment Apartment { get; set; }
    public int ApartmentId { get; set; }
}