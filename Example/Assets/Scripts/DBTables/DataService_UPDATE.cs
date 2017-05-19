using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class DataService
{
    private void UpdateDBUsers(DBUsers uDane)
    {
    }
    public void UpdateDBUserLevel(DBUserLevel DBUserLevel)
    {
        DataService.db._connection.Update(DBUserLevel);
    }
}

