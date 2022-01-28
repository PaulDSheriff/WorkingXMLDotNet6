using System.Xml.Schema;

namespace XMLSamples
{
  public class XmlValidationException : XmlSchemaValidationException
  {
    public XmlValidationException(string message, ValidationEventArgs e) : base(message)
    {
      EventArg = e;
    }

    public ValidationEventArgs EventArg { get; set; }
  }
}
