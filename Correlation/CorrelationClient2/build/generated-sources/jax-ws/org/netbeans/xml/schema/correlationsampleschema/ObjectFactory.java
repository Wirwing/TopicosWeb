
package org.netbeans.xml.schema.correlationsampleschema;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the org.netbeans.xml.schema.correlationsampleschema package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _InitialisationRequest_QNAME = new QName("http://xml.netbeans.org/schema/correlationSampleSchema", "initialisationRequest");
    private final static QName _AddIntegerRequest_QNAME = new QName("http://xml.netbeans.org/schema/correlationSampleSchema", "addIntegerRequest");
    private final static QName _AddIntegerResponse_QNAME = new QName("http://xml.netbeans.org/schema/correlationSampleSchema", "addIntegerResponse");
    private final static QName _InitialisationResponse_QNAME = new QName("http://xml.netbeans.org/schema/correlationSampleSchema", "initialisationResponse");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: org.netbeans.xml.schema.correlationsampleschema
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link InitialisationResponseComplexType }
     * 
     */
    public InitialisationResponseComplexType createInitialisationResponseComplexType() {
        return new InitialisationResponseComplexType();
    }

    /**
     * Create an instance of {@link AddIntegerResponseComplexType }
     * 
     */
    public AddIntegerResponseComplexType createAddIntegerResponseComplexType() {
        return new AddIntegerResponseComplexType();
    }

    /**
     * Create an instance of {@link AddIntegerRequestComplexType }
     * 
     */
    public AddIntegerRequestComplexType createAddIntegerRequestComplexType() {
        return new AddIntegerRequestComplexType();
    }

    /**
     * Create an instance of {@link InitialisationRequestComplexType }
     * 
     */
    public InitialisationRequestComplexType createInitialisationRequestComplexType() {
        return new InitialisationRequestComplexType();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link InitialisationRequestComplexType }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://xml.netbeans.org/schema/correlationSampleSchema", name = "initialisationRequest")
    public JAXBElement<InitialisationRequestComplexType> createInitialisationRequest(InitialisationRequestComplexType value) {
        return new JAXBElement<InitialisationRequestComplexType>(_InitialisationRequest_QNAME, InitialisationRequestComplexType.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link AddIntegerRequestComplexType }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://xml.netbeans.org/schema/correlationSampleSchema", name = "addIntegerRequest")
    public JAXBElement<AddIntegerRequestComplexType> createAddIntegerRequest(AddIntegerRequestComplexType value) {
        return new JAXBElement<AddIntegerRequestComplexType>(_AddIntegerRequest_QNAME, AddIntegerRequestComplexType.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link AddIntegerResponseComplexType }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://xml.netbeans.org/schema/correlationSampleSchema", name = "addIntegerResponse")
    public JAXBElement<AddIntegerResponseComplexType> createAddIntegerResponse(AddIntegerResponseComplexType value) {
        return new JAXBElement<AddIntegerResponseComplexType>(_AddIntegerResponse_QNAME, AddIntegerResponseComplexType.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link InitialisationResponseComplexType }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://xml.netbeans.org/schema/correlationSampleSchema", name = "initialisationResponse")
    public JAXBElement<InitialisationResponseComplexType> createInitialisationResponse(InitialisationResponseComplexType value) {
        return new JAXBElement<InitialisationResponseComplexType>(_InitialisationResponse_QNAME, InitialisationResponseComplexType.class, null, value);
    }

}
