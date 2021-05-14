using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class Owner
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }

    public List<Post> Posts { get; set; }
    public List<Apartment> Apartments { get; set; }
}