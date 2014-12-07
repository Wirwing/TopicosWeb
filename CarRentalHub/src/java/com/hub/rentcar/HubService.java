package com.hub.rentcar;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.ejb.Stateless;

/**
 *
 * @author Irving
 */
@WebService(serviceName = "HubService")
@Stateless()
public class HubService {

    private static List<CarRentLog> registry = new ArrayList<CarRentLog>();
    private static DateFormat df = new SimpleDateFormat("MM/dd/yyyy");
    
    @WebMethod(operationName = "getRegistry")
    public List<CarRentLog> getRegistry() {
        return registry;
    }
    
    @WebMethod(operationName = "addRegistry")
    public CarRentLog addRegistry(String id, String userId, String providerUUID) {
        
        CarRentLog log = new CarRentLog();
        log.setId(id);
        log.setProviderUUID(providerUUID);
        log.setUserId(userId);
        log.setStatus(CarRentLog.BOOKED_STATUS);
        log.setBookedDate(df.format(new Date()));
        
        return log;
    }
    
}