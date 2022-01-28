using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace XMLSamples {
  /// <summary>
  /// Demos for saving an XML document to disk
  /// </summary>
  public class SaveViewModel {
    public SaveViewModel() {
      // TODO: Modify your file location
      XmlFileName = @"D:\Samples\Product.xml";
    }

    private readonly string XmlFileName;

    #region SaveUsingXDocument Method
    /// <summary>
    /// Write code to save an XML document to disk using XDocument.Save()
    /// </summary>
    public string SaveUsingXDocument() {
      // Get a Product XML string
      string xml = XmlStringHelper.CreateProductXmlString();
      // Create XML Document using Parse()
      XDocument doc = XDocument.Parse(xml);

      // TODO: Write your code here

      // Display value
      string value = $"Check the file '{XmlFileName}' for the XML document";
      Console.WriteLine(value);

      return value;
    }
    #endregion

    #region SaveUsingXmlWriter Method
    /// <summary>
    /// Create XML document and save to disk using the XmlWriter class
    /// </summary>
    public string SaveUsingXmlWriter() {
      // Create the XML Writer
      using (XmlWriter writer = XmlWriter.Create(XmlFileName)) {
        //TODO:  Write your code here

        // Close the Writer
        writer.Close();
      }

      // Display value
      string value = $"Check the file '{XmlFileName}' for the XML document";
      Console.WriteLine(value);

      return value;
    }
    #endregion

    #region XmlWriterFormattingSave Method
    /// <summary>
    /// Create XML document and save to disk using the XmlWriter class
    /// Use the XmlWriterSettings object to specify formatting for the XML
    /// </summary>
    public string XmlWriterFormattingSave() {
      // TODO: Write your code here
      XmlWriterSettings settings = null;

      // Create the XML Writer
      using (XmlWriter writer = XmlWriter.Create(XmlFileName, settings)) {
        // Write a Start Element (Root)
        writer.WriteStartElement("Products");

        // Write a Start Element (Parent)
        writer.WriteStartElement("Product");
        // Write an Attribute
        writer.WriteAttributeString("ProductID", "999");

        // Write a Start Element (Child)
        writer.WriteStartElement("Name");
        // Write the value
        writer.WriteString("Bicycle Helmet");
        // Write the End Element
        writer.WriteEndElement();

        // Write a Start Element (Child)
        writer.WriteStartElement("ProductNumber");
        // Write the value
        writer.WriteString("HELM-01");
        // Write the End Element
        writer.WriteEndElement();

        // Write a Start Element (Child)
        writer.WriteStartElement("Color");
        // Write the value
        writer.WriteString("White");
        // Write the End Element
        writer.WriteEndElement();

        // Write a Start Element (Child)
        writer.WriteStartElement("StandardCost");
        // Write the value
        writer.WriteString("24.49");
        // Write the End Element
        writer.WriteEndElement();

        // Write a Start Element (Child)
        writer.WriteStartElement("ListPrice");
        // Write the value
        writer.WriteString("89.99");
        // Write the End Element
        writer.WriteEndElement();

        // Write a Start Element (Child)
        writer.WriteStartElement("Size");
        // Write the value
        writer.WriteString("Medium");
        // Write the End Element
        writer.WriteEndElement();

        // Write the End Element (Parent)
        writer.WriteEndElement();
        // Write the End Element (Root)
        writer.WriteEndElement();
        // Close the Writer
        writer.Close();
      }

      // Display value
      string value = $"Check the file '{XmlFileName}' for the XML document";
      Console.WriteLine(value);

      return value;
    }
    #endregion

    #region DataSetSave Method
    /// <summary>
    /// Put data into a DataSet object from a SQL database, then write the XML and XSD to disk using the WriteXml() and WriteXmlSchema() methods
    /// </summary>
    public string DataSetSave() {
      // TODO: MODIFY YOUR FILE LOCATION
      string XsdFileName = @"D:\Samples\Product.xsd";
      // TODO: MODIFY YOUR DATABASE LOCATION
      string path = @"D:\Samples\Database\XMLSamples.mdf";  // Normally in config file
      string sql = "SELECT * FROM Product";
      string cs = @$"Server=(localdb)\mssqllocaldb;AttachDbFileName={path};Integrated Security=true";

      using (SqlDataAdapter da = new(sql, cs)) {
        // Set the DataSetName = Root Node
        using (DataSet ds = new("Products")) {
          // Set TableName = Parent Nodes
          da.Fill(ds, "Product");
          // TODO: Use a StreamWriter to write XML data
          

          // TODO: Use a StreamWriter to write XSD data
          
        }
      }

      string value = $"Check the file '{XmlFileName}' for the XML document";
      value += $"{Environment.NewLine}Check the file '{XsdFileName}' for the XSD document";

      // Display value
      Console.WriteLine(value);

      return value;
    }
    #endregion
  }
}
