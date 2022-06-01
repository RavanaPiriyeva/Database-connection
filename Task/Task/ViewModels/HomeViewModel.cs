using System.Collections.Generic;
using Task.Models;

namespace Task.ViewModels
{
    public class HomeViewModel
    {
       
            public List<Slider> Sliders { get; set; }
            public List<Service> Services { get; set; }
        public List<Feature> Features { get; set; }

    }
}
