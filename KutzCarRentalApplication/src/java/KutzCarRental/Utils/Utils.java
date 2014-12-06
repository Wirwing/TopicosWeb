/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package KutzCarRental.Utils;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;

/**
 *
 * @author Ileana Ontiveros
 */
public class Utils {

    public Utils() {
    }
    
    public int calculateDays (String initialDate, String finalDate) throws ParseException{
        
        final long MILLSECS_PER_DAY = 24 * 60 * 60 * 1000;
        Date startDate = null;
        Date endDate = null;
        SimpleDateFormat dateFormat = new SimpleDateFormat("dd/MM/yyyy"); 
        
        Calendar date1;
        startDate = dateFormat.parse(initialDate);
        date1 = Calendar.getInstance();

        Calendar date2;
        endDate = dateFormat.parse(finalDate);
        date2 = Calendar.getInstance();
        
        date1.setTime(startDate); 
        date2.setTime(endDate);
        
        long totalDays;
        totalDays = ( endDate.getTime() - startDate.getTime() )/ MILLSECS_PER_DAY;
                
        return (int) totalDays;
    
    }
    
}
