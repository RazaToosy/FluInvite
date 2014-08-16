using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DataAccess;
using FluInvite.Core.Models;
using FluInvite.Infrastructure.Operations;

namespace FluInvite.Infrastructure.Data
{
    public class Repository
    {
        public Repository(int ListSIze, int SlotLengthInMinutes, int MaxPatientsPerSlot, string SourceFile)
        {
            this.ListSIze = ListSIze;
            this.SlotLengthInMinutes = SlotLengthInMinutes;
            this.MaxPatientsPerSlot = MaxPatientsPerSlot;
            this.SourceFile = SourceFile;
            this.DtPatients = new CsvImport().ProcessRepo(this);
            Sessions = new List<ModelSession>();
        }

        public List<ModelSession> Sessions { get; set; }
        public int ListSIze { get; set; }
        public int SlotLengthInMinutes { get; set; }
        public int MaxPatientsPerSlot { get; set; }
        public string SourceFile { get; set; }
        public DataTable DtPatients { get; set; }

        public void  CreateSession(String rawSessionData)
        {
            string[] times = rawSessionData.Split(',');

            for (int i = 0; i < times.Length/2; i++)
            {
                ModelSession session = new ModelSession();
                session.From = DateTime.Parse(times[i*2]);
                session.To = DateTime.Parse(times[(i*2)+ 1]);
                TimeSpan span = session.To - session.From;
                session.NoOfSlots = (int)span.TotalMinutes/SlotLengthInMinutes;
                Sessions.Add(session);
            }
        }

    }
}
