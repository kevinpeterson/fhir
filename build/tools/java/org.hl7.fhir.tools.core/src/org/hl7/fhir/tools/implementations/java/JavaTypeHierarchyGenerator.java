package org.hl7.fhir.tools.implementations.java;

import org.hl7.fhir.definitions.model.Definitions;
import org.hl7.fhir.definitions.model.ElementDefn;
import org.hl7.fhir.definitions.model.ResourceDefn;
import org.hl7.fhir.definitions.model.TypeRef;

import java.util.Collections;
import java.util.HashSet;
import java.util.Iterator;
import java.util.Map;
import java.util.Set;

public class JavaTypeHierarchyGenerator {


    public static JavaTypeHierarchy createHierarchy( Definitions definitions, Map<String, String> aliases ) {

        JavaTypeHierarchy hier = new JavaTypeHierarchy();
        for ( ResourceDefn res : definitions.getResources().values() ) {
            hier.add( Collections.singleton( JavaGenerator.javaClassName( res.getName(), aliases ) ), aliases );
            for ( ElementDefn e: res.getRoot().getElements() ) {
                analyzeElement( e, hier, aliases );
            }
        }
        for ( ElementDefn e : definitions.getStructures().values() ) {
            analyzeElement( e, hier, aliases );
        }
        hier.clean();
        return hier;
    }

    private static void analyzeElement( ElementDefn e, JavaTypeHierarchy hier, Map<String, String> aliases ) {
        if ( ! e.getTypes().isEmpty() ) {
            for ( Iterator<TypeRef> types = e.getTypes().iterator(); types.hasNext(); ) {
                TypeRef ref = types.next();
                if ( "Resource".equals( ref.getName() ) && ref.hasParams() ) {
                    Set<String> superTypes = new HashSet<String>( );
                    for ( Iterator<String> params = ref.getParams().iterator(); params.hasNext(); ) {
                        superTypes.add( params.next() );
                    }

                    if ( superTypes.size() > 1 ) {
                        hier.add( superTypes, aliases );
                    }
                }
            }
        }
        for ( ElementDefn sub : e.getElements() ) {
            analyzeElement( sub, hier, aliases );
        }

    }


}
