using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Domain.Antributes
{
    public class EntityAttribute : Attribute
    {
        ///<summary>
        /// Specifies friendly name of the entity that should be shown to user when required
        /// </summary>

        public string FriendlyName { get; set; }
        /// <summary>
        /// This is a short version of the Type name of the entity class that is unique within
        /// all the entities in the current soloution
        /// The alias must be 30 charcaters long or less. This is also typically match
        /// the Discrimator value defined for the entitiy on NHibernate mapping if the entity
        /// is a subclass of another entity
        /// </summary>
        public string TypeshortAlias { get; set; }
    }
}
