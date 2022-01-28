To run this project in Visual Studio Code, open the XMLSamples.code-workspace
  When prompted to add "Required Assets", Click the 'Yes' button
  Run the project
  Check the DEBUG CONSOLE window for the output
To run this project in Visual Studio 2022, open the XMLSamples.sln
  Run the project
  A console window shows the output


ElementViewModel Samples
--------------------------------------------------
GetAllXDocument() - When loading an XML document using XDocument, you use Descendants() to get all product nodes
GetAllXElement() - When loading an XML document using XElement, you use Elements() to get all product nodes

WhereClause() - Write a LINQ query to get a set of orders using a where clause from the XML file

OrderBy() - Write a LINQ query to get all products ordering by Color, ListPrice

AddToClass() - Write a LINQ query to get all elements and build a collection of Product objects

Join() - Write code load two XML files to join products and orders and create a new XML document with a different shape.

GetSalesWithDetails() - Write a LINQ query to only get those sales orders that have details
GetSalesLineTotalGreaterThan() - Write a LINQ query to only get those orders that have a LineTotal > $800


AttributeViewModel Samples
--------------------------------------------------
GetAll() - Write a LINQ query to get all Products and display the attribute values
GetAllUsingExtensionMethod() - Write a LINQ query to get all products and display the attribute values using the extension method GetAttrAs()
GetASingleNode() - Write a LINQ query to get a single product and display the attribute values
OrderBy() - Write a LINQ query to order the products by Color, then by ListPrice


AggregateViewModel Samples
--------------------------------------------------
Count() - Write a LINQ query to count all elements in an XML document
Sum() - Write a LINQ query to sum all LineTotal element values in an XML document
Average() - Write a LINQ query to find the average value of all LineTotal element values in an XML document
Minimum() - Write a LINQ query to find the minimum value of all LineTotal element values in an XML document
Maximum() - Write a LINQ query to find the maximum value of all LineTotal element values in an XML document
