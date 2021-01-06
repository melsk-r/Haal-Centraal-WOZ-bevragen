/*
 * Waardering onroerende zaken
 *
 * Deze API levert actuele gegevens over WOZ-objecten 
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Waarde op de meest recente beschikking met betrekking tot de peildatum
    /// </summary>
    [DataContract(Name = "Waarde")]
    public partial class Waarde : IEquatable<Waarde>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Waarde" /> class.
        /// </summary>
        /// <param name="vastgesteldeWaarde">Waarde van het WOZ-object op de peildatum in Euro.</param>
        /// <param name="indicatieBezwaarBeroep">Bij waarde true is er een lopende zaak voor bezwaar, beroep, hoger beroep of cassatie.</param>
        /// <param name="waardepeildatum">Datum waarvoor de vastgestelde waarde geldt.</param>
        public Waarde(int vastgesteldeWaarde = default(int), bool indicatieBezwaarBeroep = default(bool), DateTime waardepeildatum = default(DateTime))
        {
            this.VastgesteldeWaarde = vastgesteldeWaarde;
            this.IndicatieBezwaarBeroep = indicatieBezwaarBeroep;
            this.Waardepeildatum = waardepeildatum;
        }

        /// <summary>
        /// Waarde van het WOZ-object op de peildatum in Euro
        /// </summary>
        /// <value>Waarde van het WOZ-object op de peildatum in Euro</value>
        [DataMember(Name = "vastgesteldeWaarde", EmitDefaultValue = false)]
        public int VastgesteldeWaarde { get; set; }

        /// <summary>
        /// Bij waarde true is er een lopende zaak voor bezwaar, beroep, hoger beroep of cassatie
        /// </summary>
        /// <value>Bij waarde true is er een lopende zaak voor bezwaar, beroep, hoger beroep of cassatie</value>
        [DataMember(Name = "indicatieBezwaarBeroep", EmitDefaultValue = false)]
        public bool IndicatieBezwaarBeroep { get; set; }

        /// <summary>
        /// Datum waarvoor de vastgestelde waarde geldt
        /// </summary>
        /// <value>Datum waarvoor de vastgestelde waarde geldt</value>
        [DataMember(Name = "waardepeildatum", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Waardepeildatum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Waarde {\n");
            sb.Append("  VastgesteldeWaarde: ").Append(VastgesteldeWaarde).Append("\n");
            sb.Append("  IndicatieBezwaarBeroep: ").Append(IndicatieBezwaarBeroep).Append("\n");
            sb.Append("  Waardepeildatum: ").Append(Waardepeildatum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Waarde);
        }

        /// <summary>
        /// Returns true if Waarde instances are equal
        /// </summary>
        /// <param name="input">Instance of Waarde to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Waarde input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VastgesteldeWaarde == input.VastgesteldeWaarde ||
                    this.VastgesteldeWaarde.Equals(input.VastgesteldeWaarde)
                ) && 
                (
                    this.IndicatieBezwaarBeroep == input.IndicatieBezwaarBeroep ||
                    this.IndicatieBezwaarBeroep.Equals(input.IndicatieBezwaarBeroep)
                ) && 
                (
                    this.Waardepeildatum == input.Waardepeildatum ||
                    (this.Waardepeildatum != null &&
                    this.Waardepeildatum.Equals(input.Waardepeildatum))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.VastgesteldeWaarde.GetHashCode();
                hashCode = hashCode * 59 + this.IndicatieBezwaarBeroep.GetHashCode();
                if (this.Waardepeildatum != null)
                    hashCode = hashCode * 59 + this.Waardepeildatum.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
