namespace XMLSamples {
  /// <summary>
  /// Provide hard-coded product data
  /// </summary>
  public static class ProductSalesRepository {
    public static ProductSales Get() {
      return new ProductSales
      {
        ProductID = 680,
        Name = "HL Road Frame - Black, 58",
        Color = "Black",
        StandardCost = 1059.31M,
        ListPrice = 1431.50M,
        Size = "58",
        Sales = new()
        {
          new SalesOrder
          {
            SalesOrderID = 71774,
            OrderQty = 1,
            ProductID = 680,
            UnitPrice = 1431.50M,
            LineTotal = 1431.50M
          },
          new SalesOrder
          {
            SalesOrderID = 71776,
            OrderQty = 10,
            ProductID = 680,
            UnitPrice = 8.99M,
            LineTotal = 80.99M
          },
          new SalesOrder
          {
            SalesOrderID = 71778,
            OrderQty = 3,
            ProductID = 680,
            UnitPrice = 1431.50M,
            LineTotal = 4294.5M
          }
        }
      };
    }
  }
}
