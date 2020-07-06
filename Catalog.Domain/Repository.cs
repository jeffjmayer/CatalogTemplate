using System.Collections.Generic;
using System.Data;
using Catalog.Domain.Repository;

namespace Catalog.Domain
{

	// Art Context. hosts all repositories

	public static class ParticipantContext
	{
	    static Db db = new IaSdb();
		
		// entity specific repositories

        public static Participants Participants { get { return new Participants(); } }
        public static Carts Carts { get { return new Carts(); } }
        public static CartItems CartItems { get { return new CartItems(); } }
        public static Errors Errors { get { return new Errors(); } }
        public static Orders Orders { get { return new Orders(); } }
        public static OrderDetails OrderDetails { get { return new OrderDetails(); } }
        public static OrderNumbers OrderNumbers { get { return new OrderNumbers(); } }
        public static Products Products { get { return new Products(); } }
        public static Ratings Ratings { get { return new Ratings(); } }
        public static Users Users { get { return new Users(); } }

        // general purpose operations

        public static void Execute(string sql, params object[] parms) { db.Execute( sql, parms ); }
        public static IEnumerable<dynamic> Query(string sql, params object[] parms) { return db.Query( sql, parms ); }
        public static object Scalar(string sql, params object[] parms) { return db.Scalar( sql, parms ); }

        public static DataSet GetDataSet(string sql, params object[] parms) { return db.GetDataSet( sql, parms ); }
        public static DataTable GetDataTable(string sql, params object[] parms) { return db.GetDataTable( sql, parms ); }
        public static DataRow GetDataRow(string sql, params object[] parms) { return db.GetDataRow( sql, parms ); }
	}
}
