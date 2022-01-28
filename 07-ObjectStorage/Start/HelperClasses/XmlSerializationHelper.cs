using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace XMLSamples
{
  /// <summary>
  /// Extension methods to help serialize and deserialize XML
  /// </summary>
  public static class XmlSerializerHelper
  {
    #region Serialize<T> Method
    public static string Serialize<T>(this T value)
    {
      string ret = string.Empty;

      if (value != null)
      {
        // Create XML Serializer
        XmlSerializer serializer = new(typeof(T));
        // Create a MemoryStream to write into
        using (MemoryStream ms = new())
        {
          // Create a XmlWriterSettings object and add option to Indent
          XmlWriterSettings options = new()
          {
            Indent = true,
            Encoding = Encoding.Unicode
          };

          // Use an XmlWriter so you can format the XML
          using (XmlWriter xw = XmlWriter.Create(ms, options))
          {
            // Serialize the object into a set of bytes
            serializer.Serialize(xw, value);
            // Convert the Bytes into a string
            ret = Encoding.Unicode.GetString(ms.ToArray());
          }
        }
      }

      return ret;
    }
    #endregion

    #region Deserialize<T> Method
    public static T Deserialize<T>(this T value, string xml)
    {
      T ret = default;

      if (!string.IsNullOrEmpty(xml))
      {
        // Create XML Serializer
        XmlSerializer serializer = new(typeof(T));
        // Create a MemoryStream with the string read from the file
        using (MemoryStream ms = new(Encoding.Unicode.GetBytes(xml)))
        {
          // Deserialize the string into a product object
          ret = (T)serializer.Deserialize(ms);
        }        
      }

      return ret;
    }
    #endregion
  }
}