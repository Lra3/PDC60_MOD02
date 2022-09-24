using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using PDC60_MOD02.model;
using Xamarin.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace PDC60_MOD02.viewmodel
{
    class StudentInformationViewModel : INotifyPropertyChanged
    {
        public StudentInformation StudentInfo { get; set; }
        public Command CommandInformationUpdate { get; set; }

        public int sID { get; set; }

        public string Sname { get; set; }

        public int ylevel { get; set; }

        public string sctn { get; set; }

        public int crscode { get; set; }


        public string crs { get; set; }

        public StudentInformationViewModel()
        {
            CommandInformationUpdate = new Command(() =>
            {


                StudentInfo = new StudentInformation
                {

                    StudentID = sID,
                    StudentName = Sname,
                    YearLevel = ylevel,
                    Section = sctn,
                    CourseCode = crscode,
                    Course = crs,

                };

                OnProperyChanged(nameof(StudentInfo));


            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnProperyChanged(string propertyName)
        {


            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}