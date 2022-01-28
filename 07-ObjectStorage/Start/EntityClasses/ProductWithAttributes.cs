using System.Text;
using System.Xml.Serialization;

namespace XMLSamples
{
  /// <summary>
  /// Using the [Xml*] attributes
  /// </summary>
  [XmlRootAttribute("Product", Namespace = "http://www.pdsa.com", IsNullable = false)]
  public partial class ProductWithAttributes
  {
    [XmlAttribute("ProductId")]
    public int ProductID { get; set; }

    [XmlElement("ProductName")]
    public string Name { get; set; }
    public string ProductNumber { get; set; }
    public string Color { get; set; }
    public decimal StandardCost { get; set; }
    public decimal ListPrice { get; set; }

    /// <summary>
    /// If Size is null, the XML element will still appear
    /// </summary>
    [XmlElement(IsNullable = true)]
    public string Size { get; set; }

    /// <summary>
    /// This property will not be written out
    /// </summary>
    [XmlIgnore]
    public string ProductDescription;

    #region ToString Override 
    public override string ToString()
    {
      StringBuilder sb = new(1024);

      sb.AppendLine($"{Name}  ID: {ProductID}");
      sb.AppendLine($"   Color: {Color ?? "n/a"}   Size: {Size ?? "n/a"}");
      sb.AppendLine($"   Cost: {StandardCost:c}   Price: {ListPrice:c}");
     
      return sb.ToString();
    }
    #endregion
  }
}
