/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package carrentalapp;

import javax.xml.ws.Holder;

/**
 *
 * @author Irving
 */
public class CarRentalAPP {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        javax.xml.ws.Holder<kutzcarrental.ws.GetCarsResponse> kutzCars = new Holder<>();
        javax.xml.ws.Holder<bechcarrental.ws.GetCarsResponse> bechCars = new Holder<>();
        
        getCarsWSDLOperation(kutzCars, bechCars);
        
        System.out.println(kutzCars.value.getReturn().get(0).getBrand());
        
    }

    private static void getCarsWSDLOperation(javax.xml.ws.Holder<kutzcarrental.ws.GetCarsResponse> kutzCars, javax.xml.ws.Holder<bechcarrental.ws.GetCarsResponse> bechCars) {
        org.netbeans.j2ee.wsdl.carrentalbpel.src.getcarswsdl.GetCarsWSDLService service = new org.netbeans.j2ee.wsdl.carrentalbpel.src.getcarswsdl.GetCarsWSDLService();
        org.netbeans.j2ee.wsdl.carrentalbpel.src.getcarswsdl.GetCarsWSDLPortType port = service.getGetCarsWSDLPort();
        port.getCarsWSDLOperation(kutzCars, bechCars);
    }
    
}
