using System.Text.Json.Serialization;

 namespace CoolApp.Models
{
    public class Product{
       public string Id { get; set; }
       /*Mapping*/
       [JsonPropertyName("title")]
       public string Title { get; set; }
       [JsonPropertyName("maker")]
       public string Maker { get; set; }
        [JsonPropertyName("category")]
       public string Category { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /*From Object to JSON*/

        /*override */
        public override string ToString()=> System.Text.Json.JsonSerializer.Serialize<Product>(this);
    }
}