﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class DataService
{
    private void UpdateDBUsers(DBUsers uDane)
    {
        Context.Update(uDane);
    }
    private void UpdateDBUsers(DBUserLevel uDane)
    {
        Context.Update(uDane);
    }
}

