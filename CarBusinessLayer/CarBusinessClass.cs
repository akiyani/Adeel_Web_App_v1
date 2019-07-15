using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDataLayer;
using CarModelLayer;
using System.Data;

namespace CarBusinessLayer
{
    public class CarBusinessClass
    {
        public static List<CarModelClass> GetIndivCarData()
        {
            CarModelClass CarInfo = new CarModelClass();
            var CarInfoList = new List<CarModelClass>();

            //Assignment 2
            //Get Car information from the CarDB and the connection string details from Web.Config file
            DataSet dsCarDataReport = new DataSet();
            dsCarDataReport = CarDataClass.GetCarDataUsingDbWithConfig();

     

            //transfer Dataset details to List Object
            if (dsCarDataReport.Tables.Count > 0)
            {
                CarInfoList = dsCarDataReport.Tables[0].AsEnumerable().Select(m => new CarModelClass
                {
                    //Left is Model, Right is CarDB columns
                    Model = Convert.ToString(m["Model"]),
                    Description = Convert.ToString(m["Description"]),
                    Horsepower = Convert.ToString(m["Horsepower"])

                }).ToList();

            }
            //Business Logic

            return CarInfoList;
        }

    }
}
