using UnityEngine;
using System.Collections;

public class Gatilho : MonoBehaviour {
	public bool permission = true;
	public bool doIt = false;
	void OnTriggerEnter(Collider other) {
		Debug.Log("Okay 2");
		doIt = false;
        //gameObject.SetActive(false);
	}

	void Update(){
		if(doIt){
			 GameObject player = GameObject.Find("CardboardMain");
			 player.transform.position = Vector3.MoveTowards(player.transform.position, transform.position, 3.0f*Time.deltaTime);
		}
	}

	public void change(){
		if(permission){
			doIt=true;
			permission= false;
		}

	}
}