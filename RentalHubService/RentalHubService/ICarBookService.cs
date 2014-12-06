using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RentalHubService
{
    [ServiceContract]
    public interface ICarBookService
    {

        [OperationContract]
        List<CarBooking> AddLoggedCarBookings(CarBooking booking);

        [OperationContract]
        List<CarBooking> GetLoggedBookings();

    }

    [DataContract]
    public class CarBooking
    {

        private string rentId;
        private string provider;

        [DataMember]
        public string Provider
        {
            get { return provider; }
            set { provider = value; }
        }

        [DataMember]
        public string RentId
        {
            get { return rentId; }
            set { rentId = value; }
        }
    }
}
