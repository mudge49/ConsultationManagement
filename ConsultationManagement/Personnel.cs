﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    public class Personnel : Person
    {
        private static int personnelIDctr = 0;
        public int PersonnelID { get; set; }
        public List<Client> Clients { get; set; }
        public Classification Classification { get; set; }
        public PersonnelStatus Status { get; set; }
        public Account Account { get; set; }
        public WorkSchedule WorkSchedule { get; set; }
        
        public Personnel(string Name, string ContactNumber) : base(Name,ContactNumber) 
        {
            this.PersonnelID = System.Threading.Interlocked.Increment(ref personnelIDctr);
            this.Clients = new List<Client>();
        }

        public void setAppointmentRequest(Client client)
        {
                        
        }

        public void setPersonnelStatus(PersonnelStatus status) 
        {
            this.Status = status;
        }

        public void addWorkSchedule(WorkSchedule sched)
        {

        }

        public void removeWorkSchedule(WorkSchedule sched)
        {

        }
    }
}
