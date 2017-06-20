// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// The schedule property associated with the entity.
    /// </summary>
    public partial class ScheduleAssociationProperty
    {
        /// <summary>
        /// Initializes a new instance of the ScheduleAssociationProperty
        /// class.
        /// </summary>
        public ScheduleAssociationProperty()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScheduleAssociationProperty
        /// class.
        /// </summary>
        /// <param name="name">Gets or sets the name of the schedule.</param>
        public ScheduleAssociationProperty(string name = default(string))
        {
            this.Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
