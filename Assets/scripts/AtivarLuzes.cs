using UnityEngine;
using System.Collections;

public class AtivarLuzes : MonoBehaviour {
void OnTriggerEnter(Collider other) {
		Light lt = GameObject.Find("cozinhaLuz").GetComponent<Light>();
		lt.intensity = 8;
	}

}
