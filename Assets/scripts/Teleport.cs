using UnityEngine;
using System.Collections;
 
[RequireComponent(typeof(Collider))]
public class Teleport : MonoBehaviour {
 
  private CardboardHead head;
  private Vector3 reachdestination;
  private Vector3 startingPosition;
  private float delay = 0.0f; 
  private bool done = false;
  private int number =0;
  void Start() {
    head = Camera.main.GetComponent<StereoController>().Head;
    startingPosition = transform.localPosition;
  }
  
  void Update() {
  
    //bool isLookedAt = GetComponent<Collider>().Raycast(head.Gaze, out hit, Mathf.Infinity);
    //GetComponent<Renderer>().material.color = isLookedAt ? Color.green : Color.red;
    SetTargetEnemy();
    
  }

  private void SetTargetEnemy() {
    RaycastHit hit;        
    // Shoot raycast
    if (Physics.Raycast(transform.position, transform.forward, out hit, 50)) {
     
      //Debug.DrawLine(transform.position, hit.transform.position, Color.red);
      //targetEnemy = hit.collider.gameObject;
      if(hit.transform.gameObject.tag.Equals("Waypoint1")){
           //Debug.Log("Raycast hitted to: " + hit.collider);
                    number=1;
                    done=true;
                    hit.transform.gameObject.GetComponent<Gatilho>().change(true);

      }

      else if(hit.transform.gameObject.tag.Equals("Waypoint2")){
           //Debug.Log("Raycast hitted to: " + hit.collider);
                    number=2;
                    done=true;
                    hit.transform.gameObject.GetComponent<Gatilho2>().change(true);
      }

      else{
        if(done){
          done= false;
           GameObject gm;
          switch (number){
            case 1:
               gm =GameObject.Find("Waypoint1");
                gm.GetComponent<Gatilho>().change(false);
            break;
            case 2:
                gm =GameObject.Find("Waypoint2");
                gm.GetComponent<Gatilho2>().change(false);
            break;

            
          }
        }
      }
  }
}
}
 

