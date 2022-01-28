using System.Text;

namespace XMLSamples
{
  /// <summary>
  /// To save private variables when serializing, add the [Serializable] attribute and use binary formatting
  /// </summary>
  [Serializable]
  public partial class ProductSerializable
  {
    private string APrivateValue = "A Private Variable";
    public void ChangePrivateString(string value)
    {
      APrivateValue = value;
    }
   
    // Can add this to private fields only to not allow serialization
    [NonSerialized]
    private string NonSerializedPrivate = "Testing";
       
    public int ProductID { get; set; }
    public string Name { get; set; }
    public string ProductNumber { get; set; }
    public string Color { get; set; }
    public decimal StandardCost { get; set; }
    public decimal ListPrice { get; set; }
    public string Size { get; set; }

    #region ToString Override 
    public override string ToString()
    {
      StringBuilder sb = new(1024);

      sb.AppendLine($"{Name}  ID: {ProductID}");
      sb.AppendLine($"   Color: {Color ?? "n/a"}   Size: {Size ?? "n/a"}");
      sb.AppendLine($"   Cost: {StandardCost:c}   Price: {ListPrice:c}");
      sb.AppendLine($"   Private Value: {APrivateValue}");
      sb.AppendLine($"   Non-Serialized Private Value: {NonSerializedPrivate}");

      return sb.ToString();
    }
    #endregion
  }
}
