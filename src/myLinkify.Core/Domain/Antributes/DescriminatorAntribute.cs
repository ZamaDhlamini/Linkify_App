using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Domain.Antributes
{
    public class DescriminatorAntribute : Attribute
    {
        ///<summary>
        /// Name of the Discrimator column
        /// </summary>

        public string DiscriminatorColumn { get; set; }
        /// <summary>
        /// if true, indicates that entity uses discriminator
        /// </summary>

        public bool UseDiscrimator { get; set; }
        /// <summary>
        /// if true, indicates that the ORM should filter out rows with unkown dicrimator values
        /// </summary>

        public bool FilterUnkownDiscrimatiors { get; set; }

        public DescriminatorAntribute()
        {
            DiscriminatorColumn = "Frwk_Discriminator";
            UseDiscrimator = true;
            FilterUnkownDiscrimatiors = false;
        }
    }
}
