using UnityEngine;
using System.Collections;

public class triggerMonstro : MonoBehaviour {
bool goMonster =false;
bool dissolve = false;
float valor =0f;
	// Use this for initialization
	void Start () {
			goMonster=false;	
			dissolve=false;
	}
	

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag.Equals("Player")){
			goMonster=true;
		}
		else if(other.gameObject.tag.Equals("Monster")){
			dissolve=true;
		}
		
	}

	// Update is called once per frame
	void Update () {
		if(goMonster){
			//Debug.Log("Player chamou o mosntro");
			GameObject player = GameObject.Find("ghoulprefab");
			player.transform.position = Vector3.MoveTowards(player.transform.position, transform.position, 28.0f*Time.deltaTime);
		}
		if(dissolve){
			GameObject player = GameObject.Find("ghoulprefab");
			//Shader test = player.transform.GetChild(1).GetComponent<Shader>();
			valor+= Time.deltaTime;
			player.transform.GetChild(1).GetComponent<Renderer>().material.SetFloat("_Cutoff", valor+0.1f);
			//test.shader = Shader.Find("FireDissolve");
			//test.DissolveStatus=1;
			//Debug.Log(test.GetFloat("DissolveStatus"));
			//Debug.Log("okay");
		}
	}
}
