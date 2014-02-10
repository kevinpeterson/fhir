package org.hl7.fhir.tools.implementations.java;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Iterator;
import java.util.LinkedHashSet;
import java.util.List;
import java.util.Map;
import java.util.Set;

public class JavaTypeHierarchy {

    private Map<String,Node> types = new HashMap<String, Node>();

    public JavaTypeHierarchy() {
        types.put( "Any", new Node( new Type( "Any", Collections.EMPTY_SET ) ) );
    }

    public void add( Set<String> compositeType, Map<String,String> aliases ) {

        List<String> sups = new ArrayList<String>( compositeType );
        Collections.sort( sups );
        compositeType = new LinkedHashSet<String>( sups );

        Type t;
        if ( compositeType.size() > 1 ) {
            t = new Type( getName( compositeType, aliases ), compositeType );
        } else {
            t = new Type( compositeType.iterator().next(), compositeType );
        }
        Node n = new Node( t );
        checkHierarchy( n );
        types.put( t.getName(), n );
    }

    private void checkHierarchy( Node n ) {
        for ( Node other : types.values() ) {
            int comp = n.compareTo( other );
            if ( comp > 0 ) {
                //n.getChildren().add( other );
                other.getParents().add( n );
            } else if ( comp < 0 ) {
                //other.getChildren().add( n );
                n.getParents().add( other );
            }
        }
    }

    protected static String getName( Collection<String> compositeType, Map<String, String> aliases ) {
        List<String> typeNames = new ArrayList<String>( compositeType );
        Collections.sort( typeNames );
        if ( aliases.containsKey( typeNames ) ) {
            return aliases.get( typeNames );
        }
        Iterator<String> iter = typeNames.iterator();
        String name = iter.next();
        while ( iter.hasNext() ) {
            name += "_or_" + iter.next();
        }
        if ( name.length() > 150 ) {
            if ( ! aliases.containsKey( name ) ) {
                aliases.put( name, "ResourceTypeUnion" + aliases.size() );
            }
            return aliases.get( name );
        }
        return name;
    }

    public Map<String, Node> getTypes() {
        return types;
    }

    public Type getType( String name ) {
        return types.get( name ).getType();
    }

    public void clean() {
        for ( String typeName : getTypes().keySet() ) {
            Node n = getTypes().get( typeName );
            Collection<Node> allParents = new HashSet<Node>( n.getParents() );
            for ( Node parent : allParents ) {
                boolean subsumed = isCovered( parent, allParents );
                if ( subsumed ) {
                    n.getParents().remove( parent );
                }
            }
        }
    }

    private boolean isCovered( Node parent, Collection<Node> allParents ) {
        boolean subsumed = false;
        for ( Node otherParent : allParents ) {
            if ( otherParent == parent ) { continue; }
            if ( otherParent.getAncestors().contains( parent.getType().getName() ) ) {
                return true;
            }
        }
        return subsumed;
    }

    public Set<String> getAncestors( String name ) {
        if ( ! this.types.containsKey( name ) ) {
            return Collections.emptySet();
        }
        Set<String> anx = this.types.get( name ).getParentNames();
        return anx.isEmpty() ? Collections.singleton( "Any" ) : anx;
    }

    public static class Type {
        private String name;
        private Set<String> types;

        private Type( String name, Set<String> types ) {
            this.name = name;
            this.types = types;
        }

        public String getName() {
            return name;
        }

        @Override
        public String toString() {
            return name;
        }


        @Override
        public boolean equals( Object o ) {
            if ( this == o ) return true;
            if ( o == null || getClass() != o.getClass() ) return false;

            Type type = (Type) o;

            if ( !name.equals( type.name ) ) return false;

            return true;
        }

        @Override
        public int hashCode() {
            return name.hashCode();
        }
    }

    private static class Node implements Comparable<Node> {
        private Type type;
        private Set<Node> parents = new HashSet<Node>(  );
        private Set<String> parentNames;
        //private Set<Node> children = new HashSet<Node>(  );

        private Node( Type type ) {
            this.type = type;
        }

        public Type getType() {
            return type;
        }

        public void setType( Type type ) {
            this.type = type;
        }

        public Set<Node> getParents() {
            return parents;
        }

        public void setParents( Set<Node> parents ) {
            this.parents = parents;
        }

        /*
        public Set<Node> getChildren() {
            return children;
        }

        public void setChildren( Set<Node> children ) {
            this.children = children;
        }
        */

        @Override
        public int compareTo( Node o ) {
            if ( this.getType().types.isEmpty() || o.getType().types.isEmpty() || this.getType().types.equals( o.getType().types ) ) {
                return 0;
            }
            if ( this.getType().types.containsAll( o.getType().types ) ) {
                return 1;
            }
            if ( o.getType().types.containsAll( this.getType().types ) ) {
                return -1;
            }
            return 0;
        }

        @Override
        public String toString() {
            return "N{" + type + '}';
        }

        @Override
        public boolean equals( Object o ) {
            if ( this == o ) return true;
            if ( o == null || getClass() != o.getClass() ) return false;

            Node node = (Node) o;

            if ( !type.equals( node.type ) ) return false;

            return true;
        }

        @Override
        public int hashCode() {
            return type.hashCode();
        }

        public Set<String> getAncestors() {
            Set<String> ancestors = new HashSet<String>(  );
            for ( Node n : parents ) {
                ancestors.add( n.getType().getName() );
                ancestors.addAll( n.getAncestors() );
            }
            return ancestors;
        }

        public Set<String> getParentNames() {
            Set<String> parentNames= new HashSet<String>();
            for ( Node n : this.getParents() ) {
                parentNames.add( n.getType().getName() );
            }
            return parentNames;
        }
    }


}
