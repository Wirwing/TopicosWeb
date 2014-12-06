/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package KutzCarRental.Domain;

/**
 *
 * @author Ileana Ontiveros
 */
public class Car {
    
    int id;
    String type;
    String brand;
    String transmission;
    int numberPeople;
    int numberBaggage;
    double pricePerDay;
    boolean isAvailable;

    public Car(int id, String type, String brand, String transmission, int numberPeople, int numberBaggage, double pricePerDay, boolean isAvailable) {
        this.id = id;
        this.type = type;
        this.brand = brand;
        this.transmission = transmission;
        this.numberPeople = numberPeople;
        this.numberBaggage = numberBaggage;
        this.pricePerDay = pricePerDay;
        this.isAvailable = isAvailable;
    }
    
    public Car(){
    
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    public String getBrand() {
        return brand;
    }

    public void setBrand(String brand) {
        this.brand = brand;
    }

    public String getTransmission() {
        return transmission;
    }

    public void setTransmission(String transmission) {
        this.transmission = transmission;
    }

    public int getNumberPeople() {
        return numberPeople;
    }

    public void setNumberPeople(int numberPeople) {
        this.numberPeople = numberPeople;
    }

    public int getNumberBaggage() {
        return numberBaggage;
    }

    public void setNumberBaggage(int numberBaggage) {
        this.numberBaggage = numberBaggage;
    }

    public double getPricePerDay() {
        return pricePerDay;
    }

    public void setPricePerDay(double priceForDay) {
        this.pricePerDay = priceForDay;
    }

    public boolean isIsAvailable() {
        return isAvailable;
    }

    public void setIsAvailable(boolean isAvailable) {
        this.isAvailable = isAvailable;
    }
    
}
