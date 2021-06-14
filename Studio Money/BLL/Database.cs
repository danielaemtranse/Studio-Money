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
    public class Database: DbContext
    {
        public Database() : base(new FbConnection($"ServerType=1;Dialect=3;Port=3050;User=SYSDBA;Password=masterkey;Database={fnGetDatabase("Path")}"), true) { }

        public DbSet<Bank> Banks { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetAssembly(GetType())); //Current Assembly
            base.OnModelCreating(modelBuilder);
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
