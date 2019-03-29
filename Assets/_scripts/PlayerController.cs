using UnityEngine;
using UnityEngine.Networking;
using System.Collections;


public class PlayerController : NetworkBehaviour {

	private Transform myTransform;
	private Animator anim;

	private float speed = 11.0f;
	private float rotationSpeed = 250.0f;

	private NetworkAnimator animNet;

	// Use this for initialization
	void Start () {
		myTransform = GetComponent<Transform> ();
		anim = GetComponent<Animator> ();

		animNet = GetComponent<NetworkAnimator> ();
	}
	
	// Update is called once per frame
	void Update () {		

		if (isLocalPlayer) {
			if (Input.GetKey (KeyCode.UpArrow)) {
				
				myTransform.Translate(Vector3.forward * speed * Time.deltaTime,Space.Self);
				anim.SetBool("isRunning", true);
			}
			else{
				anim.SetBool("isRunning", false);
			}

			if (Input.GetKey (KeyCode.Space)) {
				
				//anim.SetTrigger("jump");
				animNet.SetTrigger("jump");
				//anim.SetBool("isJumping", true);
			}


			myTransform.Rotate(0,Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime,0);

			/*if (Input.GetKey (KeyCode.DownArrow)) {
				
				myTransform.Translate(-1 * Vector3.forward * speed * Time.deltaTime,Space.Self);
			}*/
		}
	
	}
}
