using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomizeAnnotationArrow
{
    internal class ViewModel
    {
        public ObservableCollection<Model> ElectronicsSales { get; set; }
        public ObservableCollection<Model> FurnitureSales { get; set; }

        public ViewModel()
        {
            ElectronicsSales = new ObservableCollection<Model>
            {
                new Model { Month = "January", Sales = 15000 },
                new Model { Month = "February", Sales = 17000 },
                new Model { Month = "March", Sales = 16000 },
                new Model { Month = "April", Sales = 20000 },
                new Model { Month = "May", Sales = 23000 },
                new Model { Month = "June", Sales = 19000 }
            };

            FurnitureSales = new ObservableCollection<Model>
            {
                new Model { Month = "January", Sales = 12000 },
                new Model { Month = "February", Sales = 14000 },
                new Model { Month = "March", Sales = 13000 },
                new Model { Month = "April", Sales = 18000 },
                new Model { Month = "May", Sales = 22000 },
                new Model { Month = "June", Sales = 15000 }
            };
        }
    }
}
