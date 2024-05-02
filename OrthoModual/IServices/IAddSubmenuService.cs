using OrthoModual.Models;
using System.Data;

namespace OrthoModual.IServices
{
    public interface IAddSubmenuService
    {
        IList<GetSubMenuModel> GetSubmenu(string keyName);
        bool AddSubMenu(AddSubMenuModel addSubMenuModel);
    }
}
