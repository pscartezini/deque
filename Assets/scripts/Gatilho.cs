using UnityEngine;
using System.Collections;

public class Gatilho : MonoBehaviour {
	public bool permission = true;
	public bool doIt = false;
	public int timer= 3;
	void OnTriggerEnter(Collider other) {
		
		doIt = false;
        //gameObject.SetActive(false);
	}

	void Update(){
		if(doIt){
			Debug.Log("Looking at");
			 GameObject player = GameObject.Find("CardboardMain");
			 player.transform.position = Vector3.MoveTowards(player.transform.position, transform.position, 3.0f*Time.deltaTime);
		}
		if(!doIt){
			Debug.Log("Looking away");
		}
	}

	public void change(bool status){
		if(permission){
			doIt=status;
			//permission= false;
		}

	}
}