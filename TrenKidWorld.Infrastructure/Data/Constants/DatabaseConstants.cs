using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenKidWorld.Infrastructure.Data.Constants
{
    public static class DatabaseConstants
    {
        public const int Guid_Max_Length = 100;
        public const int Product_Name_Max_Length = 50;
        public const int Category_Name_Max_Length = 50;
        public const int Description_Max_Length = 200;
        public const int ProfilePicture_Max_Length = 500;
        public const int Username_Max_Length = 50;
        public const int Oredr_Address_Max_Length = 300;
        public const int Products_Count_Max_Length = 10;
        public const double Price_Max_Pange = 100000.00;
        public const int Option_Name_Max_Length = 50;

        public const int Name_Min_Length = 3;
        public const double Price_Min_Range = 1.00;
        public const int Products_Count_Min_Length = 1;
    }
}
