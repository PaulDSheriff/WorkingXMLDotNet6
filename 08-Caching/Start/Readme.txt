To run this project in Visual Studio Code, open the XMLSamples.code-workspace
  When prompted to add "Required Assets", Click the 'Yes' button
  Run the project
  Check the DEBUG CONSOLE window for the output
To run this project in Visual Studio 2022, open the XMLSamples.sln
  Run the project
  A console window shows the output

Added Packages
  System.Data.SqlClient
  System.Xml.ReaderWriter
  Microsoft.EntityFrameworkCore.SqlServer


CachingViewModel Samples
--------------------------------------------------
GetData() - Write code to see if an XML file exists. If not, read from a database and store to XML file. If it does, read data from the XML file.


DetectChangesViewModel Samples
--------------------------------------------------
CompareData() - Get total rows and max date of ModifiedDate field in both XML file and database to determine if the XML file needs to be refreshed.
