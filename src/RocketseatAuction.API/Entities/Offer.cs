﻿namespace RocketseatAuction.API.Entities;

public class Offer
{
    public int Id { get; set; }
    public DateTime CreateOn { get; set; }
    public decimal Price { get; set; }
    public int ItemId { get; set; }
    public int UserId { get; set; }
}