package com.hub.rentcar;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.ejb.Stateless;
import javax.jws.WebParam;

/**
 *
 * @author Irving
 */
@WebService(serviceName = "HubService")
@Stateless()
public class HubService {

    private static List<CarRentLog> registry = new ArrayList<CarRentLog>();
    private static DateFormat df = new SimpleDateFormat("MM/dd/yyyy");
    private static final List<RentalProvider> rentalProviders = new ArrayList<RentalProvider>();
    
    static{
        rentalProviders.add(new RentalProvider("bech", "Bech Car Merida"));
        rentalProviders.add(new RentalProvider("kutz", "Kutz Car Montejo"));
    }
    
    @WebMethod(operationName = "getRegistry")
    public List<CarRentLog> getRegistry() {
        return registry;
    }
    
    @WebMethod(operationName = "addRegistry")
    public CarRentLog addRegistry(@WebParam(name = "id")String id, 
    @WebParam(name = "userId") String userId, 
    @WebParam(name = "providerUUID")String providerUUID) {
        
        CarRentLog log = new CarRentLog();
        log.setId(id);
        log.setProviderUUID(providerUUID);
        log.setUserId(userId);
        log.setStatus(CarRentLog.BOOKED_STATUS);
        log.setBookedDate(df.format(new Date()));
        
        registry.add(log);
        
        return log;
    }
    
    @WebMethod(operationName = "getRentalProviders")
    public List<RentalProvider> getRentalProviders(){
        return rentalProviders;
    }
    
}