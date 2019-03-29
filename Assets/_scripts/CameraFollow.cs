using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject player;
	public GameObject lookAt;
	public GameObject TPWoint;
	public bool isFPV;

	private Transform myTransform;
	private float decalY;
	private float decalZ;
	private Vector3 camDecalage;

	/*** décalage pour FPW ***/
	private float decalYFPW = 2f;
	private float decalZFPW = 0.005f;

	/*** décalage pour TPW ***/
	private float decalYTPW = 2f;
	private float decalZTPW = 1f;


	void Start () {
		myTransform = GetComponent<Transform> ();
		//myTransform.position = player.transform.position;

		//Vector3 playerPos = player.transform.position;

		if (isFPV) {	
			//camPos = new Vector3 (playerPos.x, playerPos.y + decalY, playerPos.z - decalZ);		
			//myTransform.position = camPos;
			decalY = decalYFPW;
			decalZ = decalZFPW;
			camDecalage = new Vector3(0,decalY,-decalZ);

		}
		else {
			//camPos = new Vector3 (playerPos.x, playerPos.y + decalY, playerPos.z - decalZ);		
			//myTransform.position = camPos;
			decalY = decalYTPW;
			decalZ = decalZTPW;
			//camDecalage = new Vector3(0,decalY,-decalZ); // pas terrible avec le lookAt remplacé par TPW Point
		}
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			
			isFPV = !isFPV; 
			
		}
	
	}

	void LateUpdate(){
		if (isFPV) {
			myTransform.position = player.transform.position + camDecalage;
		}
		else{
			myTransform.position = TPWoint.transform.position;
		}
		transform.LookAt(lookAt.transform);

	}
}
