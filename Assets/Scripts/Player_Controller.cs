using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour {

	[SerializeField]
	float moveSpeed = 8f;

	Vector3 forward, right;

	void Start () {
		forward = Camera.main.transform.forward;
		forward.y = 0;
		forward = Vector3.Normalize(forward);
		right = Quaternion.Euler(new Vector3(0,90,0)) * forward;
	}
	
	// Update is called once per frame
	void Update () {
		//check for attack
		if(Input.GetMouseButtonDown(0)){
			//Attack();
		}

		//move
		if(Input.anyKey){
			Move();
		}

		//look at the cursor
		LookAtMouse();
	}

	void Move(){
		Vector3 rightMovement = right * moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal_Key");
		Vector3 upMovement = forward * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical_Key");

		
		//move
		transform.position += rightMovement;
		transform.position += upMovement;


	}

	void LookAtMouse(){
		//mouse position in real world
		RaycastHit hit;
     	Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
 
     	if(Physics.Raycast(ray,out hit,100)){
			Vector3 target = new Vector3(hit.point.x, this.transform.position.y, hit.point.z);
        	transform.LookAt(target);
     	}
	}

	void Attack(){
		
	}
}
