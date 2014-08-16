using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using FluInvite.Infrastructure.Data;

namespace FluInvite.Infrastructure.Operations
{
    public class CsvExport
    {
        public CsvExport(String LocationToSave, DataTable DtPatients)
        {
            DtPatients.SaveCSV(LocationToSave);
        }
    }
}
