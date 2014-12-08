<%-- 
    Document   : index
    Created on : 6/10/2014, 03:01:50 PM
    Author     : Ileana Ontiveros
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <h1>Hello Correlation - Cliente 2!</h1>    <%-- start web service invocation --%><hr/>
    <%
    try {
	correlationsamplecomapp.CorrelationSampleComAppService1 service = 
                new correlationsamplecomapp.CorrelationSampleComAppService1();
	correlationsamplecomapp.PortType1 port = service.getCasaPort1();
	 // TODO initialize WS operation arguments here
	org.netbeans.xml.schema.correlationsampleschema.InitialisationRequestComplexType part1 = null;
        part1 = new org.netbeans.xml.schema.correlationsampleschema.InitialisationRequestComplexType();
	// TODO process result here
        part1.setName("Cliente 2");
	org.netbeans.xml.schema.correlationsampleschema.InitialisationResponseComplexType result = 
                port.initialisation(part1);
	out.println("Descripción de la instancia = "+result.getInstanceDescription());
    } catch (Exception ex) {
	// TODO handle custom exceptions here
        out.println("Error" + ex.toString());
    }
    %>    
    <%-- end web service invocation --%><hr/>

    </body>
</html>
