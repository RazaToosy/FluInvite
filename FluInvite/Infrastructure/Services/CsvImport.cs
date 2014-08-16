using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using FluInvite.Infrastructure.Data;

namespace FluInvite.Infrastructure.Operations
{
    public class CsvImport
    {
        public DataTable ProcessRepo(Repository Context)
        {
            return DataTable.New.ReadCsv(Context.SourceFile);
        }
    }
}
