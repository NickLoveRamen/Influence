using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat {
	//the value of the stat
	[SerializeField]
	private int baseValue;

	public int GetValue(){
		return this.baseValue;
	} 
}
