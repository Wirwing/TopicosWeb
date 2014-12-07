/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.hub.rentcar.models;

/**
 *
 * @author Irving
 */
public class CarRentLog {
    
    public static String BOOKED_STATUS = "booked";
    public static String CANCELED_STATUS = "canceled";
    
    private String id;
    private String userId;
    private String providerUUID;
    private String bookedDate;
    private String status;
    
    /**
     * @return the id
     */
    public String getId() {
        return id;
    }

    /**
     * @param id the id to set
     */
    public void setId(String id) {
        this.id = id;
    }

    /**
     * @return the userId
     */
    public String getUserId() {
        return userId;
    }

    /**
     * @param userId the userId to set
     */
    public void setUserId(String userId) {
        this.userId = userId;
    }

    /**
     * @return the providerUUID
     */
    public String getProviderUUID() {
        return providerUUID;
    }

    /**
     * @param providerUUID the providerUUID to set
     */
    public void setProviderUUID(String providerUUID) {
        this.providerUUID = providerUUID;
    }

    /**
     * @return the bookedDate
     */
    public String getBookedDate() {
        return bookedDate;
    }

    /**
     * @param bookedDate the bookedDate to set
     */
    public void setBookedDate(String bookedDate) {
        this.bookedDate = bookedDate;
    }

    /**
     * @return the status
     */
    public String getStatus() {
        return status;
    }

    /**
     * @param status the status to set
     */
    public void setStatus(String status) {
        this.status = status;
    }
    
}
