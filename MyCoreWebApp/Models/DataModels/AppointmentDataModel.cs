using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreWebApp.Models.DataModels
{
    public class AppointmentDataModel
    {
        public string appointmentNotes { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Appointment Scheduked Date")]
        public DateTime appointmentScheduledDate { get; set; }

        public string appointmentHistory { get; set; }

    }
}
