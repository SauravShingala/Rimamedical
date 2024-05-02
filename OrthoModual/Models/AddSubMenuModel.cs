using System.ComponentModel.DataAnnotations;

namespace OrthoModual.Models
{
    public class AddSubMenuModel
    {
        public string KeyName { get; set; }

        [Required(ErrorMessage = "Please Enter Value")]
        public string KeyValue { get; set; }

        public IList<GetSubMenuModel> getSubMenuModels { get; set; }
    }

    public class GetSubMenuModel
    {
        public string KeyName { get; set; }

        public string KeyValue { get; set; }
    }
}
