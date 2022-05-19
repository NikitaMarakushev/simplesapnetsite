using simplesapnetsite.Domain.Entities;

namespace simplesapnetsite.Domain.Repositories.Abstract
{
    public interface IServiceItemRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);

        void SaveServiceItem(ServiceItem entity);

        void DeleteServiceItem(Guid id);
    }
}
