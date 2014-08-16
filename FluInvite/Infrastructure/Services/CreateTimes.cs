using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccess;
using FluInvite.Core.Models;
using FluInvite.Infrastructure.Data;

namespace FluInvite.Infrastructure.Operations
{
    public class CreateTimes
    {

        public Repository ProcessRepo(Repository Context)
        {
            
            List<DateTime> sessionTIme = new List<DateTime>();

            foreach (ModelSession session in Context.Sessions)
            {
                DateTime timeIndex = new DateTime(session.From.Year, session.From.Month, session.From.Day, session.From.Hour, session.From.Minute, 0);
                for (int n = 0; n < session.NoOfSlots; n++)
                {
                    for (int i = 0; i < Context.MaxPatientsPerSlot; i++)
                    {
                        sessionTIme.Add(timeIndex);
                    }
                    timeIndex = timeIndex.AddMinutes(Context.SlotLengthInMinutes);
                }
            }

            if (Context.DtPatients.Rows.Count() > sessionTIme.Count)
                MessageBox.Show("You need to create more session Times", "Not Enough Slots");
            else
            {
                int sessionIndex = 0;
                foreach (var patient in Context.DtPatients.Rows)
                {
                    patient["Slot"] = string.Format("{0} at {1}{2}", sessionTIme[sessionIndex].ToString("D"),sessionTIme[sessionIndex].ToString("t"),sessionTIme[sessionIndex].ToString("tt"));
                    sessionIndex++;
                }
            }

            return Context;
        }
    }
}
