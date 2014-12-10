/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package BechCarRental.Domain;

import java.util.UUID;

/**
 *
 * @author Ileana Ontiveros
 */
public class Reservation {
    
    private static int countReservations = 1;
    
    String idReservation;
    String rentalDate;
    String returnDate;
    private Car car;
    double totalPrice;

    public Reservation() {
    }
    
    public Reservation(String rentalDate, String returnDate, Car car, double totalPrice) {
        this.idReservation = UUID.randomUUID().toString();
        this.rentalDate = rentalDate;
        this.returnDate = returnDate;
        this.car = car;
        this.totalPrice = totalPrice;
    }

    public static int getCountReservations() {
        return countReservations;
    }

    public static void setCountReservations(int countReservations) {
        Reservation.countReservations = countReservations;
    }

    public String getIdReservation() {
        return idReservation;
    }

    public void setIdReservation(String idReservation) {
        this.idReservation = idReservation;
    }

    public String getRentalDate() {
        return rentalDate;
    }

    public void setRentalDate(String rentalDate) {
        this.rentalDate = rentalDate;
    }

    public String getReturnDate() {
        return returnDate;
    }

    public void setReturnDate(String returnDate) {
        this.returnDate = returnDate;
    }

    public Car getCar() {
        return car;
    }

    public void setCar(Car car) {
        this.car = car;
    }

    public double getTotalPrice() {
        return totalPrice;
    }

    public void setTotalPrice(double totalPrice) {
        this.totalPrice = totalPrice;
    }
    
}
