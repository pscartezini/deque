using UnityEngine;
using System.Collections;

public class ChangeMaterial : MonoBehaviour {


	 public Material[] matArray;
 
 
 	public void MaterialChange(int m){
	
           	GetComponent<Renderer>().material = matArray[m];
     	
	}
	
	// Update is called once per frame
	
}

