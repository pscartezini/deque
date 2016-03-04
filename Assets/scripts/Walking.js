	 #pragma strict
	   // drag the player here
	 var  speed:float = 5.0f; // move speed
	 var target:Transform;
	 public var walk: boolean = false;
	 function Start () {
	 
	 }
	 function Update () {
	 	if(walk){
	 		transform.position = Vector3.MoveTowards(transform.position, target.position,   speed*Time.deltaTime);	
	 	}
	  
	  
	 } 

