package org.hl7.fhir.tools.implementations.java;

import org.hl7.fhir.definitions.Config;
import org.hl7.fhir.definitions.model.ElementDefn;
import org.hl7.fhir.definitions.model.ResourceDefn;

import java.io.IOException;
import java.io.OutputStream;
import java.io.UnsupportedEncodingException;
import java.util.Date;
import java.util.Iterator;
import java.util.Set;

public class JavaResourceReferenceGenerator extends JavaBaseGenerator {

    public JavaResourceReferenceGenerator( OutputStream out ) throws UnsupportedEncodingException {
        super( out );
    }

    public void generate( ElementDefn root, String packageName, String name, boolean primitive, Set<String> ancestors, Date genDate, String version ) throws IOException {
        write( "package " + packageName +".refs; \r\n" );
        write("\r\n/*\r\n"+ Config.FULL_LICENSE_CODE+"*/\r\n\r\n");
        write("// Generated on "+Config.DATE_FORMAT().format(genDate)+" for FHIR v"+version+"\r\n\r\n");

        write( "import org.hl7.fhir.instance.model.ResourceReference; \r\n" );
        write( "import org.hl7.fhir.instance.model.intf." + upFirst( name ) + "; \r\n" );
        write( "\r\n" );

        write( "public class "
               + upFirst(name) + "_Reference"
               + " extends ResourceReference<" + upFirst( name ) + ">"
               + " implements " + upFirst( name )
               + " {\r\n" );

        generateCopy( upFirst(name), root );

        generateResolver( name );

        write( "public " + upFirst( name ) + "_Reference asReference() { return this; } \r\n" );

        String resolveType = packageName + "." + ( primitive ? upFirst( name ) : "Resource" );
        write( "public " + resolveType + " asResource() { return (" +  resolveType + ") resolveReference(); } \r\n" );

        write( "public boolean isReference() { return true; } \r\n" );

        write("} \r\n");

    }

    private void generateResolver( String name ) throws IOException {
        write(  "   public " + name + " resolveReference() { throw new UnsupportedOperationException( \"TBD\" ); } " );
        write( "\r\n" );
    }

    public void generateCopy( String tn, ElementDefn root ) throws IOException {
        write("      public ResourceReference<"+tn+"> copy() {\r\n");
        write("        ResourceReference<"+tn+"> dst = new "+tn+"_Reference();\r\n");

        for (ElementDefn c : root.getElements()) {
            String params = "";
            String name = getElementName( c.getName(), true );
            write("        dst.set"+upFirst( name )+"(" + name+" == null ? null : "+name+".copy("+params+") ); \r\n");
        }
        write("        return dst;\r\n");
        write("      }\r\n\r\n");
    }

}
