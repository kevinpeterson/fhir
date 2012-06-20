package org.hl7.fhir.definitions.parsers.converters;

/*
Copyright (c) 2011-2012, HL7, Inc
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

import java.util.ArrayList;
import java.util.List;
import org.hl7.fhir.definitions.ecore.fhir.FhirFactory;
import org.hl7.fhir.definitions.ecore.fhir.TypeRef;



/*
 * "Old" Syntax for type declarations in Fhir
 * 
 * typeSpec = '@' elementreference | '[param]' | 'xhtml' | 'xml:ID' |
 * 			'Interval(' orderedType ')' | 'Resource(' resourceParams ')' | 
 * 			type('|' type)* | '*'
 * 
 * resourceParams = resourceType ('|' resourceType)* | Any 
 * type = primitiveType | dataType | structure
 * 
 * NB: mapping of primitive types is dependent on dataAbsenceAllowed. Is
 * allowed, then the primitives must be mapped to a subclass of Type,
 * otherwise to the corresponding C# primitive (or XsdDateTime).
 */

public class TypeRefConverter 
{
	public final static String PRIMITIVE_PSEUDOTYPE_NAME = "Primitive";
	public final static String COMPOSITE_PSEUDOTYPE_NAME = "Composite";
	public final static String RESOURCEREF_PSEUDOTYPE_NAME = "ResourceRef";
	public final static String XHTML_PSEUDOTYPE_NAME = "xhtml";
	public final static String XMLID_PSEUDOTYPE_NAME = "xmlid";
	public final static String ANY_RESOURCE_GENERIC_ARG = "Any";
	
	public static List<TypeRef> buildTypeRefsFromFhirModel( 
						List<org.hl7.fhir.definitions.model.TypeRef> refs ) throws Exception
	{
		List<TypeRef> result = new ArrayList<TypeRef>();

		for( org.hl7.fhir.definitions.model.TypeRef ref : refs )
		{
				result.addAll( buildTypeRefsFromFhirModel(ref) );
		}
		
		return result;
	}
	
	
	// Some TypeRefs, like TypeX(A|B|C) and "*" are actually short-hands for
	// multiple TypeRefs: TypeX(A|B|C) will be expanded to TypeX(A) | TypeX(B) | TypeX(C)
	// and "*" to pseudo-types Primitive | Composite | Resource(Any). Therefore,
	// although this method takes one single model.TypeRef, it can return
	// multiple eCore.TypeRefs.
	public static List<TypeRef> buildTypeRefsFromFhirModel( org.hl7.fhir.definitions.model.TypeRef original )
			throws Exception
	{
		List<TypeRef> result = new ArrayList<TypeRef>();
		List<org.hl7.fhir.definitions.model.TypeRef> expandedTypeRefs = expandMultiTypeRef(original);
		
		for( org.hl7.fhir.definitions.model.TypeRef ref : expandedTypeRefs )
		{
			TypeRef convertedType = FhirFactory.eINSTANCE.createTypeRef();
			
			if( ref.isElementReference() )
				convertedType.setName( ref.getResolvedTypeName() );

			else if( ref.isUnboundGenericParam() )
			{
				convertedType.setName( "param" );
				convertedType.setIsUnboundGeneric(true);
			}
			
			else if( ref.isXhtml() )
				convertedType.setName( XHTML_PSEUDOTYPE_NAME );
			
			else if( ref.isXmlId() )
				convertedType.setName( XMLID_PSEUDOTYPE_NAME );
			
			else if( ref.isResourceReference() )
			{			
				convertedType.setName(RESOURCEREF_PSEUDOTYPE_NAME);

				if( ref.hasParams() && ref.getParams().size() == 1 )
				{
					if( ref.isAnyResource() )
						convertedType.setTakesAnyResource(true);
					else
						convertedType.getBoundParam().add(ref.getParams().get(0));					
				}
				else
					throw new Exception( "Resource references can only have a single generic parameter");
			}
			else
				convertedType.setName( ref.getName() );

			convertedType.setIsPseudoType( checkIsPseudoType(convertedType) );
			
			result.add(convertedType);
		}
		
		return result;
	}
	
	
	private static boolean checkIsPseudoType( TypeRef candidate )
	{
		return
			candidate.getName().equals(PRIMITIVE_PSEUDOTYPE_NAME) ||
			candidate.getName().equals(COMPOSITE_PSEUDOTYPE_NAME) ||
			candidate.getName().equals(RESOURCEREF_PSEUDOTYPE_NAME) ||
			candidate.getName().equals(XHTML_PSEUDOTYPE_NAME) ||
			candidate.getName().equals(XMLID_PSEUDOTYPE_NAME);
	}
	
	
	private static List<org.hl7.fhir.definitions.model.TypeRef> 
			expandMultiTypeRef( org.hl7.fhir.definitions.model.TypeRef ref )
	{
		List<org.hl7.fhir.definitions.model.TypeRef> expandedTypeRefs = 
				new ArrayList<org.hl7.fhir.definitions.model.TypeRef>();
		
		if( ref.isWildcardType() )
		{
			// "*" becomes pseudo-types Primitive | Composite | Resource(Any)
			org.hl7.fhir.definitions.model.TypeRef primitivePseudoType = 
					new org.hl7.fhir.definitions.model.TypeRef();
			primitivePseudoType.setName( PRIMITIVE_PSEUDOTYPE_NAME );
			expandedTypeRefs.add(primitivePseudoType);
			
			org.hl7.fhir.definitions.model.TypeRef compositePseudoType = 
					new org.hl7.fhir.definitions.model.TypeRef();
			compositePseudoType.setName( COMPOSITE_PSEUDOTYPE_NAME );
			expandedTypeRefs.add(compositePseudoType);
			
			// Note: we use the type "Resource" here and not "ResourceRef"
			// since it is called "Resource" in the Excel. This type is
			// then mapped to the pseudotype "ResourceRef" pseudotype
			// in the next stages of processing.
			org.hl7.fhir.definitions.model.TypeRef resourceRefPseudoType = 
					new org.hl7.fhir.definitions.model.TypeRef();
			resourceRefPseudoType.setName( "Resource" );
			resourceRefPseudoType.getParams().add( ANY_RESOURCE_GENERIC_ARG );
			expandedTypeRefs.add(resourceRefPseudoType);
		}
		else if( ref.isBoundGeneric() && ref.hasParams() &&
					ref.getParams().size() > 1)
		{
			// TypeX(A|B|C) becomes TypeX(A) | TypeX(B) | TypeX(C)
			for( String param : ref.getParams() )
			{
				org.hl7.fhir.definitions.model.TypeRef newRef = 
						new org.hl7.fhir.definitions.model.TypeRef();

				newRef.setName(ref.getName());
				newRef.getParams().add(param);
				
				expandedTypeRefs.add(newRef);
			}				
		}
		else
		{
			// Do nothing
			expandedTypeRefs.add(ref);
		}
		
		return expandedTypeRefs;
	}


	public static List<TypeRef> buildTypeRefsFromFhirTypeName( String fhirTypeName ) throws Exception
	{	
		org.hl7.fhir.definitions.model.TypeRef oldRef = new org.hl7.fhir.definitions.model.TypeRef();
		oldRef.setName(fhirTypeName);
		
		return buildTypeRefsFromFhirModel(oldRef);
	}
}