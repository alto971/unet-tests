using UnityEngine;
using System.Collections;

public class CameraFollowPlayer : MonoBehaviour {

	public GameObject lookAt;
	public GameObject TPWPoint;
	public bool isFPV;
	public GameObject player;

	private Transform myTransform;
	private Vector3 camDecalage;

	/*** décalage pour FPW ***/
	private float decalYFPW = 2f;
	private float decalZFPW = 0.005f;

	// Use this for initialization
	void Start () {
		myTransform = GetComponent<Transform> ();
		camDecalage = new Vector3(0,decalYFPW,-decalZFPW);

	}
	
	// Update is called once per frame
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
			myTransform.position = TPWPoint.transform.position;
		}
		transform.LookAt(lookAt.transform);

	}


}
