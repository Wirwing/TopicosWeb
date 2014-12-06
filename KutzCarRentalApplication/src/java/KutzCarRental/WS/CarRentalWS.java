/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package KutzCarRental.WS;

import KutzCarRental.DB.DataBase;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.ejb.Stateless;
import KutzCarRental.Domain.Car;
import KutzCarRental.Domain.Reservation;
import KutzCarRental.Utils.Utils;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.Map;

/**
 *
 * @author Ileana Ontiveros
 */
@WebService(serviceName = "CarRentalWS")
@Stateless()
public class CarRentalWS {
    
    /**
     * Obtener una lista de autos para rentar
     */
    @WebMethod(operationName = "getCars")
    public ArrayList<Car> getCars() {
        ArrayList<Car> cars = DataBase.getDB().getCarsTable();
        return cars;
    }
    
    /**
     * Obtener la lista de reservaciones
     */
    @WebMethod(operationName = "getReservations")
    public ArrayList<Reservation> getReservations() {
        ArrayList<Reservation> reservations = DataBase.getDB().getReservationsTable();
        return reservations;
    }

    /**
     * Reservar un auto
     */
    @WebMethod(operationName = "createReservation")
    public boolean createReservation(@WebParam(name = "rentalDate") String rentalDate,
        @WebParam(name = "returnDate") String returnDate, 
        @WebParam(name = "idCar") int idCar) throws ParseException {
        
        boolean isBooked = false;
        try {
            Car car = DataBase.getDB().getCarById(idCar);
            double pricePerDay = car.getPricePerDay();
            int totalDays = new Utils().calculateDays(rentalDate, returnDate);
            double priceTotal = totalDays*pricePerDay;
            Reservation reservation = new Reservation(rentalDate, returnDate, idCar, priceTotal);
            isBooked = DataBase.getDB().addReservation(reservation, idCar);
            return true;
        } catch (Exception e){
            return false;
        } 
        
    }
      
}
