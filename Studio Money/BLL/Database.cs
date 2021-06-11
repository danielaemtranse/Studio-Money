using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Reflection;
using FirebirdSql.Data.FirebirdClient;
using StudioMoney.BE;

namespace StudioMoney.BLL
{
    public class Database
    {
        private Object _oConnection;

        public Database()
        {
            FbConnection _oConnection = new FbConnection($"ServerType=1;Dialect=3;Port=3050;User=SYSDBA;Password=masterkey;Database={fnGetDatabase("Path")}");
            oConnection = _oConnection;
        }

        public virtual void Dispose()
        {

        }

        public Object oConnection
        {
            get
            {
                return _oConnection;
            }
            set
            {
                _oConnection = value;
            }
        }

        private static String fnGetDatabase(String sKey)
        {

            // Instantiate BE class
            ConfigurationBE objBE = new ConfigurationBE();

            // Instantiate Business class
            Configuration objBusiness = new Configuration();

            // Fill Business class properties
            objBusiness.ObjConfigurationBE = objBE;

            return objBusiness.fnGetDatabase(sKey);

        }

        public class Context : DbContext
        {
            public Context()
                : base(new FbConnection($"ServerType=1;Dialect=3;Port=3050;User=SYSDBA;Password=masterkey;Database={fnGetDatabase("Path")}"), true)
            { }

            public DbSet<Bank> Banks { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Properties()
                    .Configure(x => x.HasColumnName(x.ClrPropertyInfo.Name.ToUpper()));

                var bank = modelBuilder.Entity<Bank>();
                bank.ToTable("tbBank");
            }
        }

        public static DataTable CreateDataTable(IEnumerable source)
        {
            var table = new DataTable();
            int index = 0;
            var properties = new List<PropertyInfo>();
            foreach (var obj in source)
            {
                if (index == 0)
                {
                    foreach (var property in obj.GetType().GetProperties())
                    {
                        if (Nullable.GetUnderlyingType(property.PropertyType) != null)
                        {
                            continue;
                        }
                        properties.Add(property);
                        table.Columns.Add(new DataColumn(property.Name, property.PropertyType));
                    }
                }
                object[] values = new object[properties.Count];
                for (int i = 0; i < properties.Count; i++)
                {
                    values[i] = properties[i].GetValue(obj);
                }
                table.Rows.Add(values);
                index++;
            }
            return table;
        }
    }
}
