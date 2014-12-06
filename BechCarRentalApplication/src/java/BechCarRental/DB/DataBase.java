/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package BechCarRental.DB;

import BechCarRental.Domain.Car;
import BechCarRental.Domain.Reservation;
import java.util.ArrayList;

/**
 *
 * @author Ileana Ontiveros
 */
public class DataBase {
        
    private static DataBase db;
    private ArrayList<Car> carsTable;
    private ArrayList<Reservation> reservationsTable;
    
    private DataBase(){
        this.carsTable = new ArrayList<Car>();
        this.reservationsTable = new ArrayList<Reservation>();
        addCars();
    }
    
    public static DataBase getDB(){
        if(db == null){
            db = new DataBase();
        }
        return db;
    }
            
    private void addCars(){
        carsTable.add(new Car(1, "Automóvil", "Dodge i10", "Manual", 5, 1, 310, true));
        carsTable.add(new Car(2, "Automóvil", "Chevrolet Aveo", "Manual", 5, 3, 370, true));
        carsTable.add(new Car(3, "Automóvil", "Nissan Tiida", "Automática", 5, 3, 380, true));
        carsTable.add(new Car(4, "Automóvil", "Dodge Avenger", "Automática", 5, 2, 460, true));
        carsTable.add(new Car(5, "Camioneta", "Chrysler T-Country", "Automática", 7, 2, 1048, true));
        carsTable.add(new Car(6, "Camioneta", "Renaulr Duster", "Automática", 5, 2, 800, true));
        carsTable.add(new Car(7, "Camioneta", "Nissan Xtrail", "Automática", 5, 3, 807, true));
        carsTable.add(new Car(8, "Camioneta", "Wolkswagen Routan", "Automática", 7, 3, 999, true));
    }
    
    public Car getCarById(int idCar){
        Car car = carsTable.get(idCar-1);             
        return car;
    }
    
    public boolean addReservation(Reservation reservation, int idCar){
        boolean isBooked = false;
        int i = 0;
        while(i < carsTable.size()){
            Car car = carsTable.get(i);
            if (car.getId()==idCar){
                car.setIsAvailable(false);
                carsTable.set(i, car);
                reservationsTable.add(reservation);
                isBooked = true;
                i=carsTable.size();
            } else {
                isBooked = false;
            }
            i++;
        }
        return isBooked;
    }

    public ArrayList<Car> getCarsTable() {
        return carsTable;
    }

    public ArrayList<Reservation> getReservationsTable() {
        return reservationsTable;
    }
    
}
