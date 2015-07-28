using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DMailDelivery.Core.Persistence
{
    class PropertyConvention : IStoreModelConvention<EdmProperty>
    {
        public void Apply(EdmProperty property, DbModel model)
        {            
            property.Name = property.Name.Trim().ToLower();

            /*
            if (property.Name.Contains("_id"))
            {
                property.Name = "fk_" + property.Name.Replace("_id", "");
            }

            if (property.Name.Contains("id_"))
            {
                property.Name = "pk_" + property.Name.Replace("id_", "");
            }
            */
        }
    }
}