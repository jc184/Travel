using System;
using System.Collections.Generic;
using System.Text;
using Travel.Application.Dtos.Tour;

namespace Travel.Application.TourLists.GetTours
{
    public class ToursVm
    {
        public IList<TourListDto> Lists { get; set; }
    }
}
