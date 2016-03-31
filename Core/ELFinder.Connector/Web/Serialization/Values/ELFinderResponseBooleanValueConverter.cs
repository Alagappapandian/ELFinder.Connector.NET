using System;
using Newtonsoft.Json;

namespace ELFinder.Connector.Web.Serialization.Values
{

    /// <summary>
    /// ELFinder response boolean value converter
    /// </summary>
    public class ELFinderResponseBooleanValueConverter : JsonConverter
    {

        #region Overrides

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter"/> to write to.</param><param name="value">The value.</param><param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {

            // Write boolean value as 0 or 1
            writer.WriteValue(((bool)value) ? 1 : 0);

        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader"/> to read from.</param><param name="objectType">Type of the object.</param><param name="existingValue">The existing value of object being read.</param><param name="serializer">The calling serializer.</param>
        /// <returns>
        /// The object value.
        /// </returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {

            return reader.Value.ToString() == "1";

        }

        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        /// <c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.
        /// </returns>
        public override bool CanConvert(Type objectType)
        {
            
            // Convert boolean types
            return objectType == typeof (bool);

        }

        #endregion
         
    }
}