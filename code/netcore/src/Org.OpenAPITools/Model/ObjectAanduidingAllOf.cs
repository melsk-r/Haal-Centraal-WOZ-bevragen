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
    /// De aanduiding van het WOZ-object zoals wordt weergegeven op de WOZ-beschikking
    /// </summary>
    [DataContract(Name = "ObjectAanduiding_allOf")]
    public partial class ObjectAanduidingAllOf : IEquatable<ObjectAanduidingAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectAanduidingAllOf" /> class.
        /// </summary>
        /// <param name="locatieomschrijving">De aanvullende omschrijving van de ligging van een WOZ-object ten opzichte van de dichtstbijzijnde verblijfsobject, standplaats, ligplaats of openbare ruimte..</param>
        /// <param name="nummeraanduidingIdentificatie">Identificatie van de nummeraanduiding in de BAG waarmee het WOZ-object wordt aangeduid.</param>
        public ObjectAanduidingAllOf(string locatieomschrijving = default(string), string nummeraanduidingIdentificatie = default(string))
        {
            this.Locatieomschrijving = locatieomschrijving;
            this.NummeraanduidingIdentificatie = nummeraanduidingIdentificatie;
        }

        /// <summary>
        /// De aanvullende omschrijving van de ligging van een WOZ-object ten opzichte van de dichtstbijzijnde verblijfsobject, standplaats, ligplaats of openbare ruimte.
        /// </summary>
        /// <value>De aanvullende omschrijving van de ligging van een WOZ-object ten opzichte van de dichtstbijzijnde verblijfsobject, standplaats, ligplaats of openbare ruimte.</value>
        [DataMember(Name = "locatieomschrijving", EmitDefaultValue = false)]
        public string Locatieomschrijving { get; set; }

        /// <summary>
        /// Identificatie van de nummeraanduiding in de BAG waarmee het WOZ-object wordt aangeduid
        /// </summary>
        /// <value>Identificatie van de nummeraanduiding in de BAG waarmee het WOZ-object wordt aangeduid</value>
        [DataMember(Name = "nummeraanduidingIdentificatie", EmitDefaultValue = false)]
        public string NummeraanduidingIdentificatie { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectAanduidingAllOf {\n");
            sb.Append("  Locatieomschrijving: ").Append(Locatieomschrijving).Append("\n");
            sb.Append("  NummeraanduidingIdentificatie: ").Append(NummeraanduidingIdentificatie).Append("\n");
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
            return this.Equals(input as ObjectAanduidingAllOf);
        }

        /// <summary>
        /// Returns true if ObjectAanduidingAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectAanduidingAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectAanduidingAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Locatieomschrijving == input.Locatieomschrijving ||
                    (this.Locatieomschrijving != null &&
                    this.Locatieomschrijving.Equals(input.Locatieomschrijving))
                ) && 
                (
                    this.NummeraanduidingIdentificatie == input.NummeraanduidingIdentificatie ||
                    (this.NummeraanduidingIdentificatie != null &&
                    this.NummeraanduidingIdentificatie.Equals(input.NummeraanduidingIdentificatie))
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
                if (this.Locatieomschrijving != null)
                    hashCode = hashCode * 59 + this.Locatieomschrijving.GetHashCode();
                if (this.NummeraanduidingIdentificatie != null)
                    hashCode = hashCode * 59 + this.NummeraanduidingIdentificatie.GetHashCode();
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
