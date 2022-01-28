namespace XMLSamples
{
  /// <summary>
  /// Class used in the Caching module to determine what has changed between the server and a local XML file
  /// </summary>
  public class ChangeInfo
  {
    public ChangeInfo()
    {
      MaxDate = DateTime.MinValue;
      TotalRows = -1;
    }

    public DateTime MaxDate { get; set; }
    public int TotalRows { get; set; }
  }
}
