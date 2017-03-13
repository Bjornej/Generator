using System.Collections.Generic;

namespace Model
{
    public class TypeProperty : AbstractProperty
    {
        public string TypeName { get; set; }

        public ICollection<AbstractProperty> Properties { get; set; }
    }
}
