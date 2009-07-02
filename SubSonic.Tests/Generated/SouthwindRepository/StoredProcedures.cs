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
namespace SouthwindRepository{
    public partial class SPs{
        
        /// <summary>
        /// Creates an object wrapper for the CustOrderHist Procedure
        /// </summary>
        public static StoredProcedure CustOrderHist()
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("CustOrderHist", DataService.GetInstance("SouthwindRepository"), "");
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the CustOrdersDetail Procedure
        /// </summary>
        public static StoredProcedure CustOrdersDetail()
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("CustOrdersDetail", DataService.GetInstance("SouthwindRepository"), "");
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the CustOrdersOrders Procedure
        /// </summary>
        public static StoredProcedure CustOrdersOrders()
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("CustOrdersOrders", DataService.GetInstance("SouthwindRepository"), "");
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the Employee Sales By Country Procedure
        /// </summary>
        public static StoredProcedure EmployeeSalesByCountry()
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Employee Sales By Country", DataService.GetInstance("SouthwindRepository"), "");
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the Sales by Year Procedure
        /// </summary>
        public static StoredProcedure SalesByYear()
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Sales by Year", DataService.GetInstance("SouthwindRepository"), "");
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the Ten Most Expensive Products Procedure
        /// </summary>
        public static StoredProcedure TenMostExpensiveProducts()
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Ten Most Expensive Products", DataService.GetInstance("SouthwindRepository"), "");
        	
            return sp;
        }
        
    }
    
}
