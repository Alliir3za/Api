﻿using Avn.Domain.Dtos.Subscriptions;

namespace Avn.Services.Implementations;

public class SubscriptionsService : ISubscriptionsService
{
    private readonly IAppUnitOfWork _uow;
    public SubscriptionsService(IAppUnitOfWork unitOfWork) => _uow = unitOfWork;


    /// <summary>
    /// Get current subscription model for a user
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    public async Task<IActionResponse<Subscription>> GetCurrentModelAsync(Guid userId, CancellationToken cancellationToken = default)
    {
        var subscription = await _uow.SubscriptionRepo.Queryable()
              .Include(X => X.Pricing)
              .Include(X => X.Pricing.NetworkInPricings)
              .ThenInclude(X => X.Network)
              .FirstOrDefaultAsync(X => X.To >= DateTime.Now, cancellationToken);

        if (subscription is null)
            return new ActionResponse<Subscription>(ActionResponseStatusCode.NotFound, BusinessMessage.NotFound);

        return new ActionResponse<Subscription>(subscription);
    }

    /// <summary>
    /// Add User Subscription
    /// this is an internal API
    /// </summary>
    /// <param name="item"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<IActionResponse<int>> AddAsync(CreateSubscriptionDto item, CancellationToken cancellationToken = default)
    {
        Subscription model = new()
        {
            UserId = item.UserId,
            PricingId = item.PricingId,
            TransactionId = item.TransactionId,
            From = item.From,
            To = item.To
        };

        await _uow.SubscriptionRepo.AddAsync(model, cancellationToken);
        var result = await _uow.SaveChangesAsync(cancellationToken);
        if (!result.ToSaveChangeResult())
            return new ActionResponse<int>(ActionResponseStatusCode.ServerError, BusinessMessage.ServerError);

        return new ActionResponse<int>(model.Id);
    }

}