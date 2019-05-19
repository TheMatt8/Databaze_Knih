using System;
using System.Collections.Generic;
using System.Text;

namespace Databaze_Knih.Model
{
    public interface IDatabaze
    {
        SQLite.SQLiteConnection dkNapojeni();
    }
}
