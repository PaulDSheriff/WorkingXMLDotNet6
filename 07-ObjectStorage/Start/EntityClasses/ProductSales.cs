using System.Text;
using System.Xml.Serialization;

namespace XMLSamples
{
  /// <summary>
  /// Class to hold a Product object and list of SalesOrder objects
  /// </summary>
  public partial class ProductSales
  {
    public int ProductID { get; set; }
    public string Name { get; set; }
    public string ProductNumber { get; set; }
    public string Color { get; set; }
    public decimal StandardCost { get; set; }
    public decimal ListPrice { get; set; }
    public string Size { get; set; }
    public DateTime ModifiedDate { get; set; }

    [XmlArray("SalesForProduct")]
    public List<SalesOrder> Sales { get; set; }

    #region ToString Override
    public override string ToString()
    {
      StringBuilder sb = new(1024);

      sb.AppendLine($"{Name}  ID: {ProductID}");
      sb.AppendLine($"   Color: {Color ?? "n/a"}   Size: {Size ?? "n/a"}");
      sb.AppendLine($"   Cost: {StandardCost:c}   Price: {ListPrice:c}");
      sb.AppendLine($"   Modified Date: {ModifiedDate:d}");

      foreach (SalesOrder item in Sales)
      {
        sb.AppendLine("   " + item.ToString());
      }

      return sb.ToString();
    }
    #endregion
  }
}
