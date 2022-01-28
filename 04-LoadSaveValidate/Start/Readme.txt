To run this project in Visual Studio Code, open the XMLSamples.code-workspace
  When prompted to add "Required Assets", Click the 'Yes' button
  Run the project
  Check the DEBUG CONSOLE window for the output
To run this project in Visual Studio 2022, open the XMLSamples.sln
  Run the project
  A console window shows the output


LoadingViewModel Samples
--------------------------------------------------
LoadUsingXDocument() - Use the Load() method of the XDocument class
LoadUsingXElement() - Use the Load() method of the XElement class
GetFirstNodeUsingXDocument() - Use the FirstNode property after loading an XML file using XDocument.Load()
GetFirstNodeUsingXElement() - Use the FirstNode property after loading an XML file using XElement.Load()


SaveViewModel Samples
--------------------------------------------------
SaveUsingXDocument() - Write code to save an XML document to disk using XDocument.Save()
SaveUsingXmlWriter() - Create XML document and save to disk using the XmlWriter class
XmlWriterFormattingSave() - Create XML document and save to disk using the XmlWriter class. Use the XmlWriterSettings object to specify formatting for the XML
DataSetSave() - Put data into a DataSet object from a SQL database, then write the XML and XSD to disk using the WriteXml() and WriteXmlSchema() methods


ValidateViewModel Samples
--------------------------------------------------
ValidateXml() - Write code to validate XML using an XSD file
ValidateXmlWithError() - Write code to create an invalid node, then validate the XML using an XSD file
