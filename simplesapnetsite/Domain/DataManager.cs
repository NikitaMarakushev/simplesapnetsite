using simplesapnetsite.Domain.Repositories.Abstract;

namespace simplesapnetsite.Domain
{
    public class DataManager
    {
        public ITextFiledsRepository TextFileds { get; set; }
       
        public IServiceItemRepository ServiceItem { get; set; }

        public DataManager(ITextFiledsRepository textFiledsRepository, IServiceItemRepository serviceItemRepositor)
        {
            TextFileds = textFiledsRepository;
            ServiceItem = serviceItemRepositor;
        }
    }
}
