using System.Runtime.Serialization;
using System.Text;

namespace XMLSamples
{
  /// <summary>
  /// Using the [Data*] attributes
  /// </summary>
  [DataContract(Name = "Product", Namespace = "http://www.pdsa.com")]
  public partial class ProductWithDataContract
  {
    [DataMember]
    private string APrivateValue = "A Private Variable";

    public void ChangePrivateString(string value)
    {
      APrivateValue = value;
    }

    // Won't be serialized
    private string NonSerializedPrivate = "Testing";

    [DataMember]
    public int ProductID { get; set; }

    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public string ProductNumber { get; set; }
    [DataMember]
    public string Color { get; set; }
    [DataMember]
    public decimal StandardCost { get; set; }
    [DataMember]
    public decimal ListPrice { get; set; }
    [DataMember]
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
