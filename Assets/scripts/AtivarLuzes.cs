using UnityEngine;
using System.Collections;

public class AtivarLuzes : MonoBehaviour {
void OnTriggerEnter(Collider other) {
		
		mudarTexturas(1);
		ligarLuzes(5f);
	}

	void mudarTexturas(int index){
		GameObject gm;
		gm=GameObject.Find("parede8");
        gm.GetComponent<ChangeMaterial>().MaterialChange(index);
        gm=GameObject.Find("parede2");
        gm.GetComponent<ChangeMaterial>().MaterialChange(index);
        gm=GameObject.Find("parede4");
        gm.GetComponent<ChangeMaterial>().MaterialChange(index);
        gm=GameObject.Find("parede5");
        gm.GetComponent<ChangeMaterial>().MaterialChange(index);
        gm=GameObject.Find("chao");
        gm.GetComponent<ChangeMaterial>().MaterialChange(index);
        gm=GameObject.Find("teto");
        gm.GetComponent<ChangeMaterial>().MaterialChange(index);
	}

	void ligarLuzes(float intensity){
		Light lt = GameObject.Find("cozinhaLuz").GetComponent<Light>();
		lt.intensity = intensity;
	}

}
