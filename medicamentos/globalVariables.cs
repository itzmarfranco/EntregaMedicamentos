using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicamentos
{
    class globalVariables
    {
        public static user currentUser = new user();
        //connection string
        public static string connectionString = @"Data Source = DESKTOP-BCOUPQF\SQLEXPRESS; Initial Catalog = medicines; Integrated Security = True";

        //sql server procedures
        //login
        public static string sp_validUser = "validUser";
        public static string spvar_username = "username";
        public static string spvar_password = "password";
        //loadMedicines
        public static string sp_loadMedicines = "loadMedicines";
        //saveMedicine
        public static string sp_saveMedicine = "saveMedicine";
        public static string spvar_medName = "medName";
        public static string spvar_expDate = "expDate";
        public static string spvar_lot = "lot";
        public static string spvar_quantity = "quantity";
        //searchMedicine
        public static string sp_searchMedicine = "searchMedicine";
        //deliverMedicine
        public static string sp_deliverMedicine = "deliverMedicine";
        public static string spvar_medId = "medicine";
        public static string spvar_userId = "user";
        public static string spvar_delivered = "delivered";
        //loadMedicinesNonDelivered
        public static string sp_loadMedicinesNonDelivered = "loadMedicinesNonDelivered";
        public static string spvar_startDate = "startDate";
        public static string spvar_endDate = "endDate";

        public static string sp_loadMedicinesDaily = "loadMedicinesDaily";
        public static string sp_loadMedicinesDelivered = "loadMedicinesDelivered";
    }
}
