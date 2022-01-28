using System.Globalization;
using System.Xml.Linq;

namespace XMLSamples
{
  /// <summary>
  /// Extension methods to help process XML files easily
  /// </summary>
  public static class XmlHelper
  {
    #region GetAs<T> Method
    public static T GetAs<T>(this XElement elem, string name, T defaultValue = default)
    {
      T ret = defaultValue;

      if (elem != null && elem.Element(name) != null && !string.IsNullOrEmpty(elem.Element(name).Value))
      {
        // Cast to Return Data Type
        // NOTE: ChangeType can not cast to a Nullable type
        ret = (T)Convert.ChangeType(elem.Element(name).Value, typeof(T), CultureInfo.InvariantCulture);
      }

      return ret;
    }
    #endregion

    #region GetAttrAs<T> Method
    public static T GetAttrAs<T>(this XElement elem, string name, T defaultValue = default)
    {
      T ret = defaultValue;

      if (elem != null && elem.Attribute(name) != null && !string.IsNullOrEmpty(elem.Attribute(name).Value))
      {
        // Cast to Return Data Type
        // NOTE: ChangeType can not cast to a Nullable type
        ret = (T)Convert.ChangeType(elem.Attribute(name).Value, typeof(T), CultureInfo.InvariantCulture);
      }

      return ret;
    }
    #endregion
  }
}
