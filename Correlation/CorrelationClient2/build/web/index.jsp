<%-- 
    Document   : index
    Created on : 6/10/2014, 07:42:06 PM
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
        <h1>Hello Correlation!</h1>
            <%-- start web service invocation --%><hr/>
    <%
    try {
	correlationsamplecomapp.CorrelationSampleComAppService1 service = 
                new correlationsamplecomapp.CorrelationSampleComAppService1();
	correlationsamplecomapp.PortType1 port = service.getCasaPort1();
	 // TODO initialize WS operation arguments here
	org.netbeans.xml.schema.correlationsampleschema.InitialisationRequestComplexType part1 = null;
	// TODO process result here
        part1 = new org.netbeans.xml.schema.correlationsampleschema.InitialisationRequestComplexType();
        part1.setName("Clase de Tópicos WS");
	org.netbeans.xml.schema.correlationsampleschema.InitialisationResponseComplexType result = 
                port.initialisation(part1);
	out.println("Saludo = "+result.getInstanceDescription());
        
    } catch (Exception ex) {
	// TODO handle custom exceptions here
        out.println(ex.toString());
    }
    %>
    <%-- end web service invocation --%><hr/>
    

    </body>
</html>
