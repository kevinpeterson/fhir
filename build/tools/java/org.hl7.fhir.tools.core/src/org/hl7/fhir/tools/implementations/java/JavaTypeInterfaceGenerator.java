package org.hl7.fhir.tools.implementations.java;

import org.hl7.fhir.definitions.Config;
import org.hl7.fhir.definitions.model.ElementDefn;

import java.io.IOException;
import java.io.OutputStream;
import java.io.UnsupportedEncodingException;
import java.util.ArrayList;
import java.util.Date;
import java.util.Iterator;
import java.util.List;
import java.util.Set;

public class JavaTypeInterfaceGenerator extends JavaBaseGenerator {

    public JavaTypeInterfaceGenerator( OutputStream out ) throws UnsupportedEncodingException {
        super( out );
    }


    public void generate( String packageName, String name, boolean isPrimitive, Set<String> ancestors, Date genDate, String version ) throws IOException {
        write( "package " + packageName +".intf; \r\n" );
        write("\r\n/*\r\n"+ Config.FULL_LICENSE_CODE+"*/\r\n\r\n");
        write("// Generated on "+Config.DATE_FORMAT().format(genDate)+" for FHIR v"+version+"\r\n\r\n");

        write( "import " + packageName + ".ResourceReference; \r\n" );

        write( "public interface "
               + upFirst(name)
               + ( "Any".equals( name ) ? "" : formatSupers( ancestors ) )
               + " {\r\n" );

        //write( "public " + upFirst( name ) + " copy(); \r\n" );

        write( "\r\n" );
        write( "    public " + packageName + ".ResourceReference<? extends " + upFirst( name ) + "> asReference(); \r\n" );
        write( "\r\n" );
        write( "\r\n" );
        write( "    public " + packageName + "." + ( isPrimitive ? upFirst( name ) : "Resource" ) + " asResource(); \r\n" );
        write( "\r\n" );
        write( "\r\n" );
        write( "    public boolean isReference(); \r\n" );
        write( "\r\n" );

        write("} \r\n");

    }

    private String formatSupers( Set<String> ancestors ) {
        if ( ancestors.isEmpty() ) {
            return "";
        }
        String ext = " extends ";
        boolean first = true;
        for ( Iterator<String> iter = ancestors.iterator(); iter.hasNext(); ) {
            if ( first ) {
                first = false;
            } else {
                ext += ", ";
            }
            ext += iter.next();
        }
        return ext;
    }

}
