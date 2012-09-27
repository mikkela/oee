using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Tools.Excel;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace ProduktionsstopOversigt
{
    public partial class Sheet1
    {
        //private const string connectionString =
        //    @"Data Source=MIKKEL-PC\SQLSERVER;Initial Catalog=oee;Integrated Security=True";

        private const string connectionString =
            @"Data Source=Alpha\SqlExpress;Initial Catalog=oee;Initial Catalog=oee;User Id=oee;Password=oee";

        private const string query =
            "SELECT ProductionStop.Name, ProductionStopRegistration.Duration " +
             "FROM  ProductionStopRegistration INNER JOIN " +
             "ProductionStop ON ProductionStopRegistration.ProductionStopId = ProductionStop.ID INNER JOIN " +
             "ProductionLeg ON ProductionStopRegistration.ProductionLegId = ProductionLeg.ID " +
             "WHERE (ProductionLeg.ProductionStart >= '{0}' AND ProductionLeg.ProductionEnd <= '{1}')";

        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
        }

        private void Sheet1_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            this.Startup += new System.EventHandler(this.Sheet1_Startup);
            this.Shutdown += new System.EventHandler(this.Sheet1_Shutdown);

        }

        #endregion

        private void generateButton_Click(object sender, EventArgs e)
        {
            var stops = RetreiveStops(periodStartDateTimePicker.Value, periodEndDateTimePicker.Value);

            var row = 4;

            foreach (var stop in stops)
            {
                this.Range["A" + row, "A" + row].Value2 = stop.Item1;
                this.Range["B" + row, "B" + row].Value2 = stop.Item2;
                this.Range["C" + row, "C" + row].Value2 = stop.Item3;

                row++;
            }


        }

        private IEnumerable<Tuple<string, int, int>> RetreiveStops(DateTime start, DateTime end)
        {
            var values = new Dictionary<string, Tuple<int, int>>();

            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var q = string.Format(query, start.ToString("yyyy-MM-dd"), end.ToString("yyyy-MM-dd"));
                using(var command = new SqlCommand(q, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            string name = reader[0].ToString();
                            int duration = new TimeSpan(long.Parse(reader[1].ToString())).Minutes;

                            if (!values.ContainsKey(name))
                            {
                                values.Add(name, new Tuple<int, int>(0, 0));
                            }

                            var currentValue = values[name];
                            var newValue = new Tuple<int, int>(currentValue.Item1 + 1, currentValue.Item2 + duration);

                            values[name] = newValue;                            

                        }
                    }
                }
            }

            return values.Select(p => new Tuple<string, int, int>(p.Key, p.Value.Item1, p.Value.Item2));
        }
    }
}
