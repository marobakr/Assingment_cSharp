using Microsoft.EntityFrameworkCore;
using Session_01.Context;

namespace Session_01;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Entity Framework Core is an ORM that allows you to interact with a database using .NET objects.
         * ORM: Object Relational [Relational: is a Table] Mapping
         * - We Have 2 Types of ORM:
         *  - Code First (Generate Table Per Each Class)
         *  - Database First (Generate Class Per Each Table)
         * EF Core Supports LINQ
         *
         * EF Core Follows 3 Types To Generate Schema:
         * - TPC (Table Per Class): Each class in the inheritance hierarchy gets its own table. Tables include columns for all properties of the class, including inherited properties.
         * - TPH (Table Per Hierarchy): A single table is used to store data for all classes in the inheritance hierarchy. A discriminator column identifies which class a row belongs to.
         * - TPCC (Table Per Concrete Class): Each concrete class in the inheritance hierarchy gets its own table. Tables include columns only for the properties of that concrete class.
         */
        
        /*
         * Type Of ORM
         * - Entity Framework Core (EF Core): Automatically handles the mapping between .NET objects and database tables.
         * - Dapper (Micro ORM): The developer manually writes SQL queries, but Dapper helps with mapping the results to .NET objects.
         * - ADO.NET: The developer manually handles the mapping between .NET objects and database tables.
         */
        
        /*
 * SQL Server (Microsoft SQL Server):
   - Developed by Microsoft.
   - Supports T-SQL (Transact-SQL) as its query language.
   - Suitable for enterprise-level applications with high transaction volumes.
   - Offers advanced features like stored procedures, triggers, and full-text search.
   - Provides robust security features and integration with other Microsoft products.
 * MySQL
   - Open-source relational database management system.
   - Uses SQL (Structured Query Language) for database access.
   - Known for its speed, reliability, and ease of use.
   - Widely used in web applications and open-source projects.
   - Supports various storage engines like InnoDB and MyISAM.
 * SQLite:
   - Lightweight, file-based database.
   - Self-contained, serverless, and zero-configuration.
   - Suitable for embedded systems, mobile applications, and small to medium-sized applications.
   - Uses SQL for database access.
   - Not designed for high-concurrency environments.
 * NoSQL:
   - Non-relational database management systems.
   - Designed for distributed data stores with large-scale data storage needs.
   - Supports various data models: document, key-value, column-family, and graph.
   - Examples include MongoDB (document-based), Redis (key-value), Cassandra (column-family), and Neo4j (graph).
   - Provides flexibility in data schema and horizontal scalability.
 */
        
   
    }
    
   
    
    
}

