﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerCustomAppearance {
    public class ReceptionDeskViewModel : INotifyPropertyChanged {
        readonly ReceptionDeskData data;

        public event PropertyChangedEventHandler PropertyChanged;
        public DateTime StartDate { get { return ReceptionDeskData.BaseDate; } }
        public IReadOnlyList<MedicalAppointment> MedicalAppointments { get => data.MedicalAppointments; }

        public ReceptionDeskViewModel() {
            data = new ReceptionDeskData();
        }

        protected void RaisePropertyChanged(string name) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
