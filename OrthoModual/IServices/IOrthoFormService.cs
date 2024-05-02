using OrthoModual.Models;

namespace OrthoModual.IServices
{
    public interface IOrthoFormService
    {
        IList<KeyValueModel> GetKeyValueList(string keyName);
        int AddOrthoFormDetails(OrthoFormModel orthoFormModel);
    }
}
