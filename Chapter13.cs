using System;
using System.Collections.Generic;
using System.Text;
/*
 * Chapter 13 - Database Access Using ADO.NET
 * - Be introduced to technologies used for accessing databases. 
 * - Become familiar with the ADO.NET classes.
 * - Write program statements that use the DataReader class to retrieve database data. 
 * - Access and update databases using the DataSet and DataAdapter classes
 * - Be introduced to SQL query statements
 */

/*
 * For smaller projects, storing data in a txt file is appropriate, but as the raw amount
 * of data increases a database becomes a more appropriate option. 
 * 
 * In databases, rows are referred to as records and columns are referred to as fields of the table. pg 758
 */

/*
 * What is ADO.NET?
 * 
 * ADO.NET namepsaces are a number of classes that can be used to retrieve, manipulate, and update
 * data in a database. 
 * ADO.NET offers the capability of working with databases in a connected
 * or disconnected mode. 
 * ADO.NET was made with the disconnected functionality in mind. 
 * An entire database can be retireved to a temporary file or to a local machine. After the database
 * is retrieved, there is no longer a need to be connected to the database itself. 
 * The ability to retrieve a database to a temprorary file means that processing can occure entirely
 * at a local level. 
 * If the database has changed made it it, then the connection can be re-established and the changes can
 * be posted to the temporary file or local machine. 
 */

/*
 * What does ADO.NET support?  
 * 1. SQL Server                                                    System.Data.SqlClient
 * 2. Oracle                                                        System.Data.OracleClient
 * 3. OBject Linking and Embedding Database technology (OLE DB)     System.Data.OleDb
 * 4. Open Database Connectivity technology (ODBC)                  System.Data.Odbc
 * 
 * There are core objects in ADO.NET
 * connection   - Establishes connection.
 * command      - Executes a command against a data source.
 * dataReader   - Performs an access of the data. (accessor)
 * dataAdapter  - Performs an update of the data. (mutator)
 */

/*
 * System.Data.SqlClient
 * SqlConnection   - Establishes connection.
 * SqlCommand      - Executes a command against a data source.
 * SqlDataReader   - Performs an access of the data. (accessor)
 * SqlDataAdapter  - Performs an update of the data. (mutator)
 */

/*
 * System.Data.OleDb
 * OleDbConnection   - Establishes connection.
 * OleDbCommand      - Executes a command against a data source.
 * OleDbDataReader   - Performs an access of the data. (accessor)
 * OleDbDataAdapter  - Performs an update of the data. (mutator)
 */

namespace C_sharp_Programming
{
    class Chapter13
    {
    }
}
