
package correlationsamplecomapp;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.jws.soap.SOAPBinding;
import javax.xml.bind.annotation.XmlSeeAlso;
import org.netbeans.xml.schema.correlationsampleschema.AddIntegerRequestComplexType;
import org.netbeans.xml.schema.correlationsampleschema.AddIntegerResponseComplexType;
import org.netbeans.xml.schema.correlationsampleschema.InitialisationRequestComplexType;
import org.netbeans.xml.schema.correlationsampleschema.InitialisationResponseComplexType;
import org.netbeans.xml.schema.correlationsampleschema.ObjectFactory;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.6-1b01 
 * Generated source version: 2.1
 * 
 */
@WebService(name = "portType1", targetNamespace = "http://j2ee.netbeans.org/wsdl/CorrelationSample/src/correlationSample")
@SOAPBinding(parameterStyle = SOAPBinding.ParameterStyle.BARE)
@XmlSeeAlso({
    ObjectFactory.class
})
public interface PortType1 {


    /**
     * 
     * @param part1
     * @return
     *     returns org.netbeans.xml.schema.correlationsampleschema.InitialisationResponseComplexType
     */
    @WebMethod
    @WebResult(name = "initialisationResponse", targetNamespace = "http://xml.netbeans.org/schema/correlationSampleSchema", partName = "part1")
    public InitialisationResponseComplexType initialisation(
        @WebParam(name = "initialisationRequest", targetNamespace = "http://xml.netbeans.org/schema/correlationSampleSchema", partName = "part1")
        InitialisationRequestComplexType part1);

    /**
     * 
     * @param part1
     * @return
     *     returns org.netbeans.xml.schema.correlationsampleschema.AddIntegerResponseComplexType
     */
    @WebMethod
    @WebResult(name = "addIntegerResponse", targetNamespace = "http://xml.netbeans.org/schema/correlationSampleSchema", partName = "part1")
    public AddIntegerResponseComplexType addInteger(
        @WebParam(name = "addIntegerRequest", targetNamespace = "http://xml.netbeans.org/schema/correlationSampleSchema", partName = "part1")
        AddIntegerRequestComplexType part1);

}
