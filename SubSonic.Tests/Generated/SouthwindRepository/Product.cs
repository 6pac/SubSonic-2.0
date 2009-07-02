using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace SouthwindRepository
{
	/// <summary>
	/// Strongly-typed collection for the Product class.
	/// </summary>
    [Serializable]
	public partial class ProductCollection : RepositoryList<Product, ProductCollection>
	{	   
		public ProductCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ProductCollection</returns>
		public ProductCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Product o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the products table.
	/// </summary>
	[Serializable]
	public partial class Product : RepositoryRecord<Product>, IRecordBase
	{
		#region .ctors and Default Settings
		
		public Product()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Product(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("products", TableType.Table, DataService.GetInstance("SouthwindRepository"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"";
				//columns
				
				TableSchema.TableColumn colvarProductID = new TableSchema.TableColumn(schema);
				colvarProductID.ColumnName = "ProductID";
				colvarProductID.DataType = DbType.Int32;
				colvarProductID.MaxLength = 10;
				colvarProductID.AutoIncrement = true;
				colvarProductID.IsNullable = false;
				colvarProductID.IsPrimaryKey = true;
				colvarProductID.IsForeignKey = false;
				colvarProductID.IsReadOnly = false;
				colvarProductID.DefaultSetting = @"";
				colvarProductID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProductID);
				
				TableSchema.TableColumn colvarProductName = new TableSchema.TableColumn(schema);
				colvarProductName.ColumnName = "ProductName";
				colvarProductName.DataType = DbType.String;
				colvarProductName.MaxLength = 40;
				colvarProductName.AutoIncrement = false;
				colvarProductName.IsNullable = false;
				colvarProductName.IsPrimaryKey = false;
				colvarProductName.IsForeignKey = true;
				colvarProductName.IsReadOnly = false;
				colvarProductName.DefaultSetting = @"";
				
					colvarProductName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProductName);
				
				TableSchema.TableColumn colvarSupplierID = new TableSchema.TableColumn(schema);
				colvarSupplierID.ColumnName = "SupplierID";
				colvarSupplierID.DataType = DbType.Int32;
				colvarSupplierID.MaxLength = 10;
				colvarSupplierID.AutoIncrement = false;
				colvarSupplierID.IsNullable = true;
				colvarSupplierID.IsPrimaryKey = false;
				colvarSupplierID.IsForeignKey = true;
				colvarSupplierID.IsReadOnly = false;
				colvarSupplierID.DefaultSetting = @"";
				
					colvarSupplierID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSupplierID);
				
				TableSchema.TableColumn colvarCategoryID = new TableSchema.TableColumn(schema);
				colvarCategoryID.ColumnName = "CategoryID";
				colvarCategoryID.DataType = DbType.Int32;
				colvarCategoryID.MaxLength = 10;
				colvarCategoryID.AutoIncrement = false;
				colvarCategoryID.IsNullable = true;
				colvarCategoryID.IsPrimaryKey = false;
				colvarCategoryID.IsForeignKey = true;
				colvarCategoryID.IsReadOnly = false;
				colvarCategoryID.DefaultSetting = @"";
				
					colvarCategoryID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCategoryID);
				
				TableSchema.TableColumn colvarQuantityPerUnit = new TableSchema.TableColumn(schema);
				colvarQuantityPerUnit.ColumnName = "QuantityPerUnit";
				colvarQuantityPerUnit.DataType = DbType.String;
				colvarQuantityPerUnit.MaxLength = 20;
				colvarQuantityPerUnit.AutoIncrement = false;
				colvarQuantityPerUnit.IsNullable = true;
				colvarQuantityPerUnit.IsPrimaryKey = false;
				colvarQuantityPerUnit.IsForeignKey = false;
				colvarQuantityPerUnit.IsReadOnly = false;
				colvarQuantityPerUnit.DefaultSetting = @"";
				colvarQuantityPerUnit.ForeignKeyTableName = "";
				schema.Columns.Add(colvarQuantityPerUnit);
				
				TableSchema.TableColumn colvarUnitPrice = new TableSchema.TableColumn(schema);
				colvarUnitPrice.ColumnName = "UnitPrice";
				colvarUnitPrice.DataType = DbType.Decimal;
				colvarUnitPrice.MaxLength = 0;
				colvarUnitPrice.AutoIncrement = false;
				colvarUnitPrice.IsNullable = true;
				colvarUnitPrice.IsPrimaryKey = false;
				colvarUnitPrice.IsForeignKey = false;
				colvarUnitPrice.IsReadOnly = false;
				colvarUnitPrice.DefaultSetting = @"";
				colvarUnitPrice.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUnitPrice);
				
				TableSchema.TableColumn colvarUnitsInStock = new TableSchema.TableColumn(schema);
				colvarUnitsInStock.ColumnName = "UnitsInStock";
				colvarUnitsInStock.DataType = DbType.Int16;
				colvarUnitsInStock.MaxLength = 5;
				colvarUnitsInStock.AutoIncrement = false;
				colvarUnitsInStock.IsNullable = true;
				colvarUnitsInStock.IsPrimaryKey = false;
				colvarUnitsInStock.IsForeignKey = false;
				colvarUnitsInStock.IsReadOnly = false;
				colvarUnitsInStock.DefaultSetting = @"";
				colvarUnitsInStock.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUnitsInStock);
				
				TableSchema.TableColumn colvarUnitsOnOrder = new TableSchema.TableColumn(schema);
				colvarUnitsOnOrder.ColumnName = "UnitsOnOrder";
				colvarUnitsOnOrder.DataType = DbType.Int16;
				colvarUnitsOnOrder.MaxLength = 5;
				colvarUnitsOnOrder.AutoIncrement = false;
				colvarUnitsOnOrder.IsNullable = true;
				colvarUnitsOnOrder.IsPrimaryKey = false;
				colvarUnitsOnOrder.IsForeignKey = false;
				colvarUnitsOnOrder.IsReadOnly = false;
				colvarUnitsOnOrder.DefaultSetting = @"";
				colvarUnitsOnOrder.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUnitsOnOrder);
				
				TableSchema.TableColumn colvarReorderLevel = new TableSchema.TableColumn(schema);
				colvarReorderLevel.ColumnName = "ReorderLevel";
				colvarReorderLevel.DataType = DbType.Int16;
				colvarReorderLevel.MaxLength = 5;
				colvarReorderLevel.AutoIncrement = false;
				colvarReorderLevel.IsNullable = true;
				colvarReorderLevel.IsPrimaryKey = false;
				colvarReorderLevel.IsForeignKey = false;
				colvarReorderLevel.IsReadOnly = false;
				colvarReorderLevel.DefaultSetting = @"";
				colvarReorderLevel.ForeignKeyTableName = "";
				schema.Columns.Add(colvarReorderLevel);
				
				TableSchema.TableColumn colvarDiscontinued = new TableSchema.TableColumn(schema);
				colvarDiscontinued.ColumnName = "Discontinued";
				colvarDiscontinued.DataType = DbType.Boolean;
				colvarDiscontinued.MaxLength = 4;
				colvarDiscontinued.AutoIncrement = false;
				colvarDiscontinued.IsNullable = false;
				colvarDiscontinued.IsPrimaryKey = false;
				colvarDiscontinued.IsForeignKey = false;
				colvarDiscontinued.IsReadOnly = false;
				colvarDiscontinued.DefaultSetting = @"";
				colvarDiscontinued.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDiscontinued);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SouthwindRepository"].AddSchema("products",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ProductID")]
		[Bindable(true)]
		public int ProductID 
		{
			get { return GetColumnValue<int>(Columns.ProductID); }
			set { SetColumnValue(Columns.ProductID, value); }
		}
		  
		[XmlAttribute("ProductName")]
		[Bindable(true)]
		public string ProductName 
		{
			get { return GetColumnValue<string>(Columns.ProductName); }
			set { SetColumnValue(Columns.ProductName, value); }
		}
		  
		[XmlAttribute("SupplierID")]
		[Bindable(true)]
		public int? SupplierID 
		{
			get { return GetColumnValue<int?>(Columns.SupplierID); }
			set { SetColumnValue(Columns.SupplierID, value); }
		}
		  
		[XmlAttribute("CategoryID")]
		[Bindable(true)]
		public int? CategoryID 
		{
			get { return GetColumnValue<int?>(Columns.CategoryID); }
			set { SetColumnValue(Columns.CategoryID, value); }
		}
		  
		[XmlAttribute("QuantityPerUnit")]
		[Bindable(true)]
		public string QuantityPerUnit 
		{
			get { return GetColumnValue<string>(Columns.QuantityPerUnit); }
			set { SetColumnValue(Columns.QuantityPerUnit, value); }
		}
		  
		[XmlAttribute("UnitPrice")]
		[Bindable(true)]
		public decimal? UnitPrice 
		{
			get { return GetColumnValue<decimal?>(Columns.UnitPrice); }
			set { SetColumnValue(Columns.UnitPrice, value); }
		}
		  
		[XmlAttribute("UnitsInStock")]
		[Bindable(true)]
		public short? UnitsInStock 
		{
			get { return GetColumnValue<short?>(Columns.UnitsInStock); }
			set { SetColumnValue(Columns.UnitsInStock, value); }
		}
		  
		[XmlAttribute("UnitsOnOrder")]
		[Bindable(true)]
		public short? UnitsOnOrder 
		{
			get { return GetColumnValue<short?>(Columns.UnitsOnOrder); }
			set { SetColumnValue(Columns.UnitsOnOrder, value); }
		}
		  
		[XmlAttribute("ReorderLevel")]
		[Bindable(true)]
		public short? ReorderLevel 
		{
			get { return GetColumnValue<short?>(Columns.ReorderLevel); }
			set { SetColumnValue(Columns.ReorderLevel, value); }
		}
		  
		[XmlAttribute("Discontinued")]
		[Bindable(true)]
		public bool Discontinued 
		{
			get { return GetColumnValue<bool>(Columns.Discontinued); }
			set { SetColumnValue(Columns.Discontinued, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ProductIDColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ProductNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn SupplierIDColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn CategoryIDColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn QuantityPerUnitColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn UnitPriceColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn UnitsInStockColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn UnitsOnOrderColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ReorderLevelColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn DiscontinuedColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ProductID = @"ProductID";
			 public static string ProductName = @"ProductName";
			 public static string SupplierID = @"SupplierID";
			 public static string CategoryID = @"CategoryID";
			 public static string QuantityPerUnit = @"QuantityPerUnit";
			 public static string UnitPrice = @"UnitPrice";
			 public static string UnitsInStock = @"UnitsInStock";
			 public static string UnitsOnOrder = @"UnitsOnOrder";
			 public static string ReorderLevel = @"ReorderLevel";
			 public static string Discontinued = @"Discontinued";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
