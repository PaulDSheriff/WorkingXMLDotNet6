To run this project in Visual Studio Code, open the XMLSamples.code-workspace
  When prompted to add "Required Assets", Click the 'Yes' button
  Run the project
  Check the DEBUG CONSOLE window for the output
To run this project in Visual Studio 2022, open the XMLSamples.sln
  Run the project
  A console window shows the output


Things to Mention
------------------
No easy way to sort other than XSLT transforms
No easy way to join


ElementViewModel Samples
--------------------------------------------------
GetAllXDocument() - Write an XPath query to get all product elements using the XDocument class
GetAllXElement() - Write an XPath query to get all product elements using the XElement class
GetAllWithErrors() - Write an XPath query to load all products and show what happens when there is a null element
GetASingleNode() - Write an XPath query to get a single product from the XML document
GetACollectionOfNodes() - Write an XPath query to get a set of products where an element's value matches a criteria
GetLastNode() - Write an XPath query to get the last node in the document
GetFirstThreeNodes() - Write an XPath query to get the first three nodes in the document
AddToClass() - Write an XPath query to get some nodes and build a collection of Product objects


AttributeViewModel Samples
--------------------------------------------------
GetAll() - Write an XPath query to get all Products and display the attribute values
GetASingleNode() - Write an XPath query to get a single product and display the attribute values
GetACollectionOfNodes() - Write an XPath query to search for a specific attribute value


AggregateViewModel Samples
--------------------------------------------------
Count() - Write an XPath query to count all sales order details
Sum() - Write an XPath query to provide a sum of all values in the LineTotal element
Average() - Write an XPath query to provide the average value of all LineTotal elements
Minimum() - Write an XPath query to provide the minimum value of all LineTotal elements
Maximum() - Write an XPath query to provide the maximum value of all LineTotal elements
