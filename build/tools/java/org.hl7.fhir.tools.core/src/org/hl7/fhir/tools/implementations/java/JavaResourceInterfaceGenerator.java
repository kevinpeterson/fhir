package org.hl7.fhir.tools.implementations.java;
/*
Copyright (c) 2011-2013, HL7, Inc
All rights reserved.

Redistribution and use in source and binary forms, with or without modification, 
are permitted provided that the following conditions are met:

 * Redistributions of source code must retain the above copyright notice, this 
   list of conditions and the following disclaimer.
 * Redistributions in binary form must reproduce the above copyright notice, 
   this list of conditions and the following disclaimer in the documentation 
   and/or other materials provided with the distribution.
 * Neither the name of HL7 nor the names of its contributors may be used to 
   endorse or promote products derived from this software without specific 
   prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
POSSIBILITY OF SUCH DAMAGE.

*/
import java.io.IOException;
import java.io.OutputStream;
import java.io.UnsupportedEncodingException;
import java.util.ArrayList;
import java.util.Date;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.Set;

import org.hl7.fhir.definitions.Config;
import org.hl7.fhir.definitions.model.BindingSpecification;
import org.hl7.fhir.definitions.model.DefinedCode;
import org.hl7.fhir.definitions.model.Definitions;
import org.hl7.fhir.definitions.model.ElementDefn;
import org.hl7.fhir.definitions.model.TypeRef;
import org.hl7.fhir.tools.implementations.java.JavaResourceGenerator.JavaGenClass;

public class JavaResourceInterfaceGenerator extends JavaResourceGenerator {


    public JavaResourceInterfaceGenerator(OutputStream out, Definitions definitions) throws UnsupportedEncodingException {
        super(out, definitions);
    }


    public void generate(ElementDefn root, String packageName, String name, Map<String, BindingSpecification> conceptDomains, JavaGenClass clss, DefinedCode cd, Map<String,String> aliases , Date genDate, String version) throws Exception {

        for (ElementDefn e : root.getElements()) {
            if ((!e.getName().equals("extension") && !e.getName().equals("text"))) {
                scanNestedTypes(root, root.getName(), e, conceptDomains);
            }
        }

        write( "package " + packageName +".intf; \r\n" );
        write("\r\n/*\r\n"+Config.FULL_LICENSE_CODE+"*/\r\n\r\n");
        write("// Generated on "+Config.DATE_FORMAT().format(genDate)+" for FHIR v"+version+"\r\n\r\n");

        write("import java.util.*;\r\n");
        if ( hasDecimal(root) ) {
            write("import java.math.*;\r\n");
        }

        List<String> importedTypes = new ArrayList<String>();

        for ( ElementDefn e : root.getElements() ) {
            generateImports( e, packageName, name, importedTypes );
        }


        write( "public interface " + upFirst(name) + "Resource extends " + upFirst(name) + " {\r\n" );
        write("\r\n");

        for ( ElementDefn e : root.getElements() ) {
            if ( !e.getName().equals("extension") && !e.getName().equals("text") ) {
                generateAccessors(root, e, "    ", upFirst(name), aliases);
            }
        }

        write("}\r\n");

        write("\r\n");
        flush();

    }

    private void generateImports( ElementDefn e, String packageName, String name, List<String> importedTypes ) throws IOException {
        String tn = typeNames.get(e);
        if ( importedTypes.contains( tn ) ) {
            return;
        }

        if ( enums.contains( e ) ) {
            write( "import " + packageName + "." + upFirst(name) + "." + fromEnumm( tn ) + "; \r\n" );
            if ( ! importedTypes.contains( "Enumeration" ) ) {
                write( "import " + packageName + ".Enumeration; \r\n" );
                importedTypes.add( "Enumeration" );
            }
        } else if (e.getTypes().size() == 1 && (definitions.getPrimitives().containsKey(e.typeCode()) || e.getTypes().get(0).isIdRef() || e.typeCode().equals("xml:lang"))) {
            if ( ! needsPrimitiveType( tn ) ) {
                // both needed for the full and simple getter
                write( "import " + packageName + "." + tn + "; \r\n" );
                write( "import " + packageName + "." + getSimpleType( tn ) + "; \r\n" );
            } else {
                write( "import " + packageName + "." + tn + "; \r\n" );
            }
        } else if ( tn != null ) {
            if ( strucs.contains( e ) ) {
                write( "import " + packageName + "." + upFirst(name) + "." + tn + "; \r\n" );
            } else {
                write( "import " + packageName + "." + tn + "; \r\n" );
            }
        }

        importedTypes.add( tn );

    }

    private String fromEnumm( String tn ) {
        return tn.substring( tn.indexOf( "<" ) + 1, tn.indexOf( ">" ) );
    }


    private void generateAccessors(ElementDefn root, ElementDefn e, String indent, String className, Map<String,String> aliases ) throws Exception {
        String tn = determineType( typeNames, e, aliases );
        String paramTn = tn; //addGenericParams( tn, e );

        if (e.unbounded()) {
            //jdoc(indent, "@return {@link #"+getElementName(e.getName(), true)+"} ("+e.getDefinition()+")");
            if (tn == null && e.usesCompositeType()) {
                write(indent+"public List<"+root.getName()+"> get"+getTitle(getElementName(e.getName(), false))+"(); \r\n");
            } else {
                write(indent+"public List<"+tn+"> get"+getTitle(getElementName(e.getName(), false))+"(); \r\n");
            }

            write("\r\n");

            if (e.getTypes().size() == 1 && (definitions.getPrimitives().containsKey(e.typeCode()) || e.getTypes().get(0).isIdRef() || e.typeCode().equals("xml:lang"))) {
                //jdoc(indent, "@param value {@link #"+getElementName(e.getName(), true)+"} ("+e.getDefinition()+")");
                write(indent+"public "+tn+" add"+getTitle(getElementName(e.getName(), false))+"Simple("+getSimpleType(tn)+" value); \r\n");
                write("\r\n");
            }
        } else {
            //jdoc(indent, "@return {@link #"+getElementName(e.getName(), true)+"} ("+e.getDefinition()+")");
            write(indent+"public "+paramTn+" get"+getTitle(getElementName(e.getName(), false))+"(); \r\n");

            write("\r\n");

            //jdoc(indent, "@param value {@link #"+getElementName(e.getName(), true)+"} ("+e.getDefinition()+")");
            write(indent+"public "+className+" set"+getTitle(getElementName(e.getName(), false))+"("+tn+" value); \r\n");
            write("\r\n");

            if (e.getTypes().size() == 1 && (definitions.getPrimitives().containsKey(e.typeCode()) || e.getTypes().get(0).isIdRef() || e.typeCode().equals("xml:lang"))) {
                //jdoc(indent, "@return "+e.getDefinition());
                write(indent+"public "+getSimpleType(tn)+" get"+getTitle(getElementName(e.getName(), false))+"Simple(); \r\n" );
                write("\r\n");

                //jdoc(indent, "@param value "+e.getDefinition());
                write(indent+"public "+className+" set"+getTitle(getElementName(e.getName(), false))+"Simple("+getSimpleType(tn)+" value); \r\n");
                write("\r\n");

            }
        }

    }

//    private String addGenericParams( String tn, ElementDefn e ) {
//        if ( "ResourceReference".equals( tn ) && ! e.getTypes().isEmpty() ) {
//            for ( Iterator<TypeRef> types = e.getTypes().iterator(); types.hasNext(); ) {
//                TypeRef ref = types.next();
//                if ( "Resource".equals( ref.getName() ) && ref.hasParams() ) {
//                    boolean first = true;
//
//                    for ( Iterator<String> params = ref.getParams().iterator(); params.hasNext(); ) {
//                        if ( first ) {
//                            first = false;
//                        } else {
//                            paramList += " & ";
//                        }
//                        paramList += params.next();
//                    }
//                    return "<" + paramList + "> " + tn + "<T>";
//                }
//            }
//        }
//        return tn;
//    }

    protected Boolean needsPrimitiveType (String n) {
        if (n.equals("String_"))
            return true;
        if (n.equals("Code"))
            return true;
        if (n.equals("Base64Binary"))
            return true;
        if (n.equals("Uri"))
            return true;
        if (n.equals("Oid"))
            return true;
        if (n.equals("Integer"))
            return true;
        if (n.equals("Boolean"))
            return true;
        if (n.equals("Decimal"))
            return true;
        if (n.equals("DateTime"))
            return false;
        if (n.equals("Date"))
            return false;
        if (n.equals("Id"))
            return true;
        if (n.equals("Instant"))
            return false;

        return true;
    }
}

