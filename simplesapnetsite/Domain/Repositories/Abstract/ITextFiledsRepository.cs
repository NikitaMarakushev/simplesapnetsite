using simplesapnetsite.Domain.Entities;

namespace simplesapnetsite.Domain.Repositories.Abstract
{
    public interface ITextFiledsRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextFieldById(Guid id);

        TextField GetTextFieldByCodeWord(string name);

        void SaveTextField(TextField entity);

        void DeleteTextField(Guid id);
    }
}
