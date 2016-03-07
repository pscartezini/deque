using UnityEngine;
using System.Collections;

public class Gatilho2 : MonoBehaviour {
	public bool permission = true;
	public bool doIt = false;
	void OnTriggerEnter(Collider other) {
		Debug.Log("Okay");
        doIt=false;
	}

	void Update(){
		if(doIt){
			 GameObject player = GameObject.Find("CardboardMain");
			 player.transform.position = Vector3.MoveTowards(player.transform.position, transform.position, 3.0f*Time.deltaTime);
		}
	}

	public void change(bool status){
		if(permission){
			doIt=status;
			//permission= false;
		}

	}
}