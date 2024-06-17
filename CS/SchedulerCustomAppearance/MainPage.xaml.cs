using DevExpress.Maui.Scheduler;

namespace SchedulerCustomAppearance {
    public partial class MainPage : ContentPage {

        public MainPage() {
            InitializeComponent();
        }

    }

    class WorkWeekViewCellCustomizer : IDayViewCellCustomizer {
        public void Customize(DayViewCellViewModel cell) {
            if (cell.Interval.Start.Hour < DateTime.Now.Hour
                && cell.Interval.Start.Date == DateTime.Today) {
                cell.BackgroundColor = Color.FromArgb("#fbf7e0");
            }
        }
    }
}