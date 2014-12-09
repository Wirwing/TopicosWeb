<%-- 
    Document   : segundoCliente
    Created on : 7/10/2014, 06:44:41 AM
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
        // TODO process result here
        part1.setName("Cliente 2");
        part1.setValueToAdd(5);
	org.netbeans.xml.schema.correlationsampleschema.AddIntegerResponseComplexType result = 
                port.addInteger(part1);
	out.println("Suma del cliente 2 = "+result.getCurrentTotal());
    } catch (Exception ex) {
	// TODO handle custom exceptions here
    }
    %>
    <%-- end web service invocation --%><hr/>

    </body>
</html>
