package org.hl7.fhir.tools.implementations.java;

import org.hl7.fhir.definitions.model.Definitions;
import org.hl7.fhir.definitions.model.ElementDefn;
import org.hl7.fhir.definitions.model.ResourceDefn;
import org.hl7.fhir.definitions.model.TypeRef;

import java.util.Collections;
import java.util.HashSet;
import java.util.Iterator;
import java.util.Set;

public class JavaTypeHierarchyGenerator {

    public static JavaTypeHierarchy createHierarchy( Definitions definitions ) {

        JavaTypeHierarchy hier = new JavaTypeHierarchy();
        for ( ResourceDefn res : definitions.getResources().values() ) {
            hier.add( Collections.singleton( javaClassName( res.getName() ) ) );
            for ( ElementDefn e: res.getRoot().getElements() ) {
                if ( ! e.getTypes().isEmpty() ) {
                    for ( Iterator<TypeRef> types = e.getTypes().iterator(); types.hasNext(); ) {
                        TypeRef ref = types.next();
                        if ( "Resource".equals( ref.getName() ) && ref.hasParams() ) {
                            boolean first = true;
                            Set<String> superTypes = new HashSet<String>( );
                            for ( Iterator<String> params = ref.getParams().iterator(); params.hasNext(); ) {
                                if ( first ) {
                                    first = false;
                                }
                                superTypes.add( params.next() );
                            }

                            if ( superTypes.size() > 1 ) {
                                hier.add( superTypes );
                            }
                        }
                    }
                }
            }
        }
        hier.clean();
        return hier;
    }

    protected static String javaClassName(String name) {
        if (name.equals("List"))
            return "List_";
        else
            return name;
    }

}
