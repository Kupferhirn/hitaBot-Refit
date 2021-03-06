using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class LeaveTeam
    {
        /// <summary>
        ///     Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", EmitDefaultValue = false)]
        public bool? Success { get; set; }

        /// <summary>
        ///     Gets or Sets SuccessMsg
        /// </summary>
        [DataMember(Name = "success_msg", EmitDefaultValue = false)]
        public string SuccessMsg { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeaveTeam {\n");

            sb.Append("  Success: ").Append(Success).Append("\n");

            sb.Append("  SuccessMsg: ").Append(SuccessMsg).Append("\n");

            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}