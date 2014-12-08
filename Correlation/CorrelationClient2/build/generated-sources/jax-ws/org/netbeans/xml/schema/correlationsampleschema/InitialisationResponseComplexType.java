
package org.netbeans.xml.schema.correlationsampleschema;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Clase Java para initialisationResponseComplexType complex type.
 * 
 * <p>El siguiente fragmento de esquema especifica el contenido que se espera que haya en esta clase.
 * 
 * <pre>
 * &lt;complexType name="initialisationResponseComplexType">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="instanceDescription" type="{http://www.w3.org/2001/XMLSchema}string"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "initialisationResponseComplexType", propOrder = {
    "instanceDescription"
})
public class InitialisationResponseComplexType {

    @XmlElement(required = true)
    protected String instanceDescription;

    /**
     * Obtiene el valor de la propiedad instanceDescription.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getInstanceDescription() {
        return instanceDescription;
    }

    /**
     * Define el valor de la propiedad instanceDescription.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setInstanceDescription(String value) {
        this.instanceDescription = value;
    }

}
