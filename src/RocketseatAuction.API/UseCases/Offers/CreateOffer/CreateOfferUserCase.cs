using RocketseatAuction.API.Comunication.Requests;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Repositories;
using RocketseatAuction.API.Services;

namespace RocketseatAuction.API.UseCases.Offers.CreateOffer;

public class CreateOfferUserCase
{
    public readonly LoggedUser _loggedUser;

    public CreateOfferUserCase(LoggedUser loggedUser) => _loggedUser = loggedUser;

    public int Execute(int itemId, RequestCreateOfferJson request)
    {
        var repository = new RocketseatAuctionDbContext();

        var user = _loggedUser.User();

        var offer = new Offer
        {
            CreateOn = DateTime.Now,
            ItemId = itemId,
            Price = request.Price,
            UserId = user.Id,
        };

        repository.Offers.Add(offer);
        repository.SaveChanges();

        return offer.Id;
    }
}
