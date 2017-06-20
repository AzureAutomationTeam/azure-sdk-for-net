// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// The properties of the create advanced schedule monthly occurrence.
    /// </summary>
    public partial class AdvancedScheduleMonthlyOccurrence
    {
        /// <summary>
        /// Initializes a new instance of the AdvancedScheduleMonthlyOccurrence
        /// class.
        /// </summary>
        public AdvancedScheduleMonthlyOccurrence()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdvancedScheduleMonthlyOccurrence
        /// class.
        /// </summary>
        /// <param name="occurrence">Occurrence of the week within the month.
        /// Must be between 1 and 5</param>
        /// <param name="day">Day of the occurrence. Must be one of monday,
        /// tuesday, wednesday,thursday, friday, saturday, sunday. Possible
        /// values include: 'Monday', 'Tuesday', 'Wednesday', 'Thursday',
        /// 'Friday', 'Saturday', 'Sunday'</param>
        public AdvancedScheduleMonthlyOccurrence(int? occurrence = default(int?), string day = default(string))
        {
            this.Occurrence = occurrence;
            this.Day = day;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets occurrence of the week within the month. Must be
        /// between 1 and 5
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "occurrence")]
        public int? Occurrence { get; set; }

        /// <summary>
        /// Gets or sets day of the occurrence. Must be one of monday, tuesday,
        /// wednesday,thursday, friday, saturday, sunday. Possible values
        /// include: 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday',
        /// 'Saturday', 'Sunday'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "day")]
        public string Day { get; set; }

    }
}
