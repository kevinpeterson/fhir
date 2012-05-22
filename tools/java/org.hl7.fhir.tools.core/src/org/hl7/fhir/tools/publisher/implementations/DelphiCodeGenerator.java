package org.hl7.fhir.tools.publisher.implementations;

import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.io.UnsupportedEncodingException;
import java.util.ArrayList;
import java.util.List;

import org.hl7.fhir.definitions.Config;

public class DelphiCodeGenerator extends OutputStreamWriter {

	// fragments
  public String name;
  public List<String> uses = new ArrayList<String>();
  public List<String> comments = new ArrayList<String>();
  public List<String> precomments = new ArrayList<String>();
  public List<String> enumDefs = new ArrayList<String>();
	public List<String> enumConsts = new ArrayList<String>();
  public List<String> classFwds = new ArrayList<String>();
  public List<String> classDefs = new ArrayList<String>();
	public List<String> classImpls = new ArrayList<String>();
  public List<String> inits = new ArrayList<String>();
  public List<String> procs = new ArrayList<String>();
  public List<String> procsPub = new ArrayList<String>();
	
	public DelphiCodeGenerator(OutputStream out) throws UnsupportedEncodingException {
		super(out, "ASCII");
	}

	public void start() throws Exception {
	}

	public void finish() throws Exception {
	  if (precomments.size() > 0) {
	    for (int i = 0; i < precomments.size(); i++) {
	      if (precomments.get(i).charAt(0) == '!')
	        write("{"+precomments.get(i)+"}\r\n");
	      else
	        write("// "+precomments.get(i)+"\r\n");
	    }
	    write("\r\n");
	  }
    write("unit "+name+";\r\n");
    write("\r\n");
    write("{\r\n"+Config.FULL_LICENSE_CODE+"}\r\n\r\n");
    write("interface\r\n");
    write("\r\n");

    for (int i = 0; i < comments.size(); i++) {
      if (comments.get(i).charAt(0) == '!')
        write("{"+comments.get(i)+"}\r\n");
      else
        write("// "+comments.get(i)+"\r\n");
    }
    write("\r\n");
    
    write("uses\r\n");
    write("  ");
    for (int i = 0; i < uses.size(); i++) {
      if (i > 0)
        write(", ");
      write(uses.get(i));
    }
    write(";\r\n");
    write("\r\n");
    
    if (enumDefs.size() > 0) {
      write("Type\r\n");

      for (String s : enumDefs) {
        write(s+"\r\n");
      }

      write("Const\r\n");
      for (String s : enumConsts) {
        write(s+"\r\n");
      }
      write("\r\n");
    }

    if (classDefs.size() > 0) {
      write("Type\r\n");
      for (String s : classFwds) {
        write(s);
      }
      write("\r\n");
      for (String s : classDefs) {
        write(s+"\r\n");
      }
    }
    if (procsPub.size() > 0) {
      for (String s : procsPub) {
        write(s);
      }
      write("\r\n");
    }
    write("implementation\r\n");
    write("\r\n");
    for (String s : classImpls) {
      write(s+"\r\n");
    }

    for (String s : procs) {
      write(s+"\r\n");
    }

    if (inits.size() > 0) {
      write("initialization;\r\n");
      for (String s : inits) {
        write("  "+s+"\r\n");
      }
    }
    write("end.\r\n");
    write("\r\n");
		flush();
		close();
	}
	


}
