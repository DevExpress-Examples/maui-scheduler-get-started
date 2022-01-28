using DevExpress.Maui.Scheduler;
using System.ComponentModel;

namespace SchedulerExample
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new ReceptionDeskViewModel();
            InitializeComponent();
        }


        private void WorkWeekView_Tap(object sender, SchedulerGestureEventArgs e) {
            if (e.AppointmentInfo == null) {
                ShowNewAppointmentEditPage(e.IntervalInfo);
                return;
            }
            AppointmentItem appointment = e.AppointmentInfo.Appointment;
            ShowAppointmentEditPage(appointment);
        }

        private void ShowAppointmentEditPage(AppointmentItem appointment) {
            AppointmentEditPage appEditPage = new AppointmentEditPage(appointment, this.storage);
            Navigation.PushAsync(appEditPage);
        }

        private void ShowNewAppointmentEditPage(IntervalInfo info) {
            AppointmentEditPage appEditPage = new AppointmentEditPage(info.Start, info.End, 
                                                                     info.AllDay, this.storage);
            Navigation.PushAsync(appEditPage);
        }


        public class ReceptionDeskViewModel : INotifyPropertyChanged
        {
            readonly ReceptionDeskData data;

            public event PropertyChangedEventHandler PropertyChanged;
            public DateTime StartDate { get { return ReceptionDeskData.BaseDate; } }
            public IReadOnlyList<MedicalAppointment> MedicalAppointments
            { get => data.MedicalAppointments; }

            public ReceptionDeskViewModel()
            {
                data = new ReceptionDeskData();
            }

            protected void RaisePropertyChanged(string name)
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
