using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Gatilho2 : MonoBehaviour {
	public bool permission = true;
	public bool doIt = false;
	public float timer=0;
	 public Canvas CanvasObject;
	public Image barraDeProgresso;



	void OnTriggerEnter(Collider other) {
		
		doIt = false;
        //gameObject.SetActive(false);
	}

	void Update(){
		if(doIt){
			timer+= Time.deltaTime;
			if(timer>0){
				   CanvasObject.enabled = true;
			}
			Debug.Log("Looking at"+timer);
			barraDeProgresso.fillAmount = (timer*1)/3;
			if(timer>=3){
				CanvasObject.enabled = false;
				permission=false;
				GameObject player = GameObject.Find("CardboardMain");
			 	player.transform.position = Vector3.MoveTowards(player.transform.position, transform.position, 3.0f*Time.deltaTime);
			}
			 
		}
		if(!doIt){
			Debug.Log("Looking away");
			timer= 0;
				CanvasObject.enabled = false;
		}
	}

	public void change(bool status){
		if(permission){
			doIt=status;
			
			//permission= false;
		}

	}
}
