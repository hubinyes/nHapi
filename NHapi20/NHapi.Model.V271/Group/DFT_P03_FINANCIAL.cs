using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V271.Segment;
using NHapi.Model.V271.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V271.Group
{
///<summary>
///Represents the DFT_P03_FINANCIAL Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: FT1 (Financial Transaction) </li>
///<li>1: NTE (Notes and Comments) optional </li>
///<li>2: DFT_P03_FINANCIAL_PROCEDURE (a Group object) optional repeating</li>
///<li>3: DFT_P03_FINANCIAL_COMMON_ORDER (a Group object) optional repeating</li>
///</ol>
///</summary>
[Serializable]
public class DFT_P03_FINANCIAL : AbstractGroup {

	///<summary> 
	/// Creates a new DFT_P03_FINANCIAL Group.
	///</summary>
	public DFT_P03_FINANCIAL(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(FT1), true, false);
	      this.add(typeof(NTE), false, false);
	      this.add(typeof(DFT_P03_FINANCIAL_PROCEDURE), false, true);
	      this.add(typeof(DFT_P03_FINANCIAL_COMMON_ORDER), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating DFT_P03_FINANCIAL - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns FT1 (Financial Transaction) - creates it if necessary
	///</summary>
	public FT1 FT1 { 
get{
	   FT1 ret = null;
	   try {
	      ret = (FT1)this.GetStructure("FT1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns NTE (Notes and Comments) - creates it if necessary
	///</summary>
	public NTE NTE { 
get{
	   NTE ret = null;
	   try {
	      ret = (NTE)this.GetStructure("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of DFT_P03_FINANCIAL_PROCEDURE (a Group object) - creates it if necessary
	///</summary>
	public DFT_P03_FINANCIAL_PROCEDURE GetFINANCIAL_PROCEDURE() {
	   DFT_P03_FINANCIAL_PROCEDURE ret = null;
	   try {
	      ret = (DFT_P03_FINANCIAL_PROCEDURE)this.GetStructure("FINANCIAL_PROCEDURE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of DFT_P03_FINANCIAL_PROCEDURE
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public DFT_P03_FINANCIAL_PROCEDURE GetFINANCIAL_PROCEDURE(int rep) { 
	   return (DFT_P03_FINANCIAL_PROCEDURE)this.GetStructure("FINANCIAL_PROCEDURE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DFT_P03_FINANCIAL_PROCEDURE 
	 */ 
	public int FINANCIAL_PROCEDURERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("FINANCIAL_PROCEDURE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the DFT_P03_FINANCIAL_PROCEDURE results 
	 */ 
	public IEnumerable<DFT_P03_FINANCIAL_PROCEDURE> FINANCIAL_PROCEDUREs 
	{ 
		get
		{
			for (int rep = 0; rep < FINANCIAL_PROCEDURERepetitionsUsed; rep++)
			{
				yield return (DFT_P03_FINANCIAL_PROCEDURE)this.GetStructure("FINANCIAL_PROCEDURE", rep);
			}
		}
	}

	///<summary>
	///Adds a new DFT_P03_FINANCIAL_PROCEDURE
	///</summary>
	public DFT_P03_FINANCIAL_PROCEDURE AddFINANCIAL_PROCEDURE()
	{
		return this.AddStructure("FINANCIAL_PROCEDURE") as DFT_P03_FINANCIAL_PROCEDURE;
	}

	///<summary>
	///Removes the given DFT_P03_FINANCIAL_PROCEDURE
	///</summary>
	public void RemoveFINANCIAL_PROCEDURE(DFT_P03_FINANCIAL_PROCEDURE toRemove)
	{
		this.RemoveStructure("FINANCIAL_PROCEDURE", toRemove);
	}

	///<summary>
	///Removes the DFT_P03_FINANCIAL_PROCEDURE at the given index
	///</summary>
	public void RemoveFINANCIAL_PROCEDUREAt(int index)
	{
		this.RemoveRepetition("FINANCIAL_PROCEDURE", index);
	}

	///<summary>
	/// Returns  first repetition of DFT_P03_FINANCIAL_COMMON_ORDER (a Group object) - creates it if necessary
	///</summary>
	public DFT_P03_FINANCIAL_COMMON_ORDER GetFINANCIAL_COMMON_ORDER() {
	   DFT_P03_FINANCIAL_COMMON_ORDER ret = null;
	   try {
	      ret = (DFT_P03_FINANCIAL_COMMON_ORDER)this.GetStructure("FINANCIAL_COMMON_ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of DFT_P03_FINANCIAL_COMMON_ORDER
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public DFT_P03_FINANCIAL_COMMON_ORDER GetFINANCIAL_COMMON_ORDER(int rep) { 
	   return (DFT_P03_FINANCIAL_COMMON_ORDER)this.GetStructure("FINANCIAL_COMMON_ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DFT_P03_FINANCIAL_COMMON_ORDER 
	 */ 
	public int FINANCIAL_COMMON_ORDERRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("FINANCIAL_COMMON_ORDER").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the DFT_P03_FINANCIAL_COMMON_ORDER results 
	 */ 
	public IEnumerable<DFT_P03_FINANCIAL_COMMON_ORDER> FINANCIAL_COMMON_ORDERs 
	{ 
		get
		{
			for (int rep = 0; rep < FINANCIAL_COMMON_ORDERRepetitionsUsed; rep++)
			{
				yield return (DFT_P03_FINANCIAL_COMMON_ORDER)this.GetStructure("FINANCIAL_COMMON_ORDER", rep);
			}
		}
	}

	///<summary>
	///Adds a new DFT_P03_FINANCIAL_COMMON_ORDER
	///</summary>
	public DFT_P03_FINANCIAL_COMMON_ORDER AddFINANCIAL_COMMON_ORDER()
	{
		return this.AddStructure("FINANCIAL_COMMON_ORDER") as DFT_P03_FINANCIAL_COMMON_ORDER;
	}

	///<summary>
	///Removes the given DFT_P03_FINANCIAL_COMMON_ORDER
	///</summary>
	public void RemoveFINANCIAL_COMMON_ORDER(DFT_P03_FINANCIAL_COMMON_ORDER toRemove)
	{
		this.RemoveStructure("FINANCIAL_COMMON_ORDER", toRemove);
	}

	///<summary>
	///Removes the DFT_P03_FINANCIAL_COMMON_ORDER at the given index
	///</summary>
	public void RemoveFINANCIAL_COMMON_ORDERAt(int index)
	{
		this.RemoveRepetition("FINANCIAL_COMMON_ORDER", index);
	}

}
}
