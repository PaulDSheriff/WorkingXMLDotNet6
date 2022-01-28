using System.Xml.Schema;

namespace XMLSamples
{
  public class XmlValidationWarning : XmlSchemaValidationException
  {
    public XmlValidationWarning(string message, ValidationEventArgs e) : base(message)
    {
      EventArg = e;
    }

    public ValidationEventArgs EventArg { get; set; }
  }
}
