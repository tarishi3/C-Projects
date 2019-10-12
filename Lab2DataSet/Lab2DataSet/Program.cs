using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2DataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet1.categoriesDataTable dtc = new DataSet1.categoriesDataTable();
            DataSet1.categoriesRow dr = dtc.NewcategoriesRow();
            DataSet1.categoriesRow dr1 = dtc.NewcategoriesRow();
            dr["Name"] = "IT";
            dr1["Name"] = "OOP";
            dtc.Rows.Add(dr);
            dtc.Rows.Add(dr1);

            foreach (DataRow item in dtc.Rows)
            {
                Console.WriteLine("categoryId: {0}, category Name: '{1}'", item["Id"], item["Name"]);
            }

            for (int i = 0; i < dtc.Rows.Count; i++)
            {
                Console.WriteLine("categoryId: {0}, category Name: '{1}'", dtc.Rows[i]["Id"], dtc.Rows[i]["Name"]);
            }

            Console.WriteLine();

            DataSet1.ProductsDataTable p1 = new DataSet1.ProductsDataTable();
            
            for (int i = 0; i < 10; i++)
            {
                DataSet1.ProductsRow pr = p1.NewProductsRow();
                pr["Id"] = i + 1;
                pr["Name"] = "Product " + (i + 1);
                p1.Rows.Add(pr);
            }

            foreach (DataRow item in p1.Rows)
            {
                Console.WriteLine("product Id: {0} , product Name: '{1}'", item["Id"], item["Name"]);
            }

            

            Console.ReadKey();
        }
    }
}
