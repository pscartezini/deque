using UnityEngine;
using System.Collections;
 
[RequireComponent(typeof(Collider))]
public class Teleport : MonoBehaviour {
 
  private CardboardHead head;
  private Vector3 reachdestination;
  private Vector3 startingPosition;
  private float delay = 0.0f; 
  private bool done = false;

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
                    hit.transform.gameObject.GetComponent<Gatilho>().change();
      }

      else if(hit.transform.gameObject.tag.Equals("Waypoint2")){
           //Debug.Log("Raycast hitted to: " + hit.collider);
                    hit.transform.gameObject.GetComponent<Gatilho2>().change();
      }

    }
  }

 

}