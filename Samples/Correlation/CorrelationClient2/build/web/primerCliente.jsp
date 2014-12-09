<%-- 
    Document   : primerCliente
    Created on : 6/10/2014, 08:40:34 PM
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
        <h1>Hello Add Integer!</h1>    <%-- start web service invocation --%><hr/>
    <%
    try {
	correlationsamplecomapp.CorrelationSampleComAppService1 service = 
                new correlationsamplecomapp.CorrelationSampleComAppService1();
	correlationsamplecomapp.PortType1 port = service.getCasaPort1();
	 // TODO initialize WS operation arguments here
	org.netbeans.xml.schema.correlationsampleschema.AddIntegerRequestComplexType part1 = null;
	part1 = new org.netbeans.xml.schema.correlationsampleschema.AddIntegerRequestComplexType();
        part1.setName("Clase de Tópicos WS");
        part1.setValueToAdd(3);
        // TODO process result here
	org.netbeans.xml.schema.correlationsampleschema.AddIntegerResponseComplexType result = 
                port.addInteger(part1);
        out.println("Suma = "+result.getCurrentTotal());
    } catch (Exception ex) {
	// TODO handle custom exceptions here
        out.println(ex.toString());
    }
    %>
    <%-- end web service invocation --%><hr/>

    </body>
</html>

