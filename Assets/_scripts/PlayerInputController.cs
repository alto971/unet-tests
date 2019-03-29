using UnityEngine;
using System.Collections;

//http://docs.unity3d.com/ScriptReference/Input.GetAxis.html

public class PlayerInputController : MonoBehaviour {

	private Transform playerTransform;
	public float coeffMove = 3.0f;
	public float jumpCoeff = 5.0f;

	private float decalMove = 2.0f;

	private float speed = 11.0f;
	private float rotationSpeed = 250.0f;

	// Use this for initialization
	void Start () {
		playerTransform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.UpArrow)) {
			
			playerTransform.Translate(Vector3.forward * speed * Time.deltaTime,Space.Self);

		}

		
		
		playerTransform.Rotate(0,Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime,0);

		/**** monter et descendre  ****/
		/*if (Input.GetKey (KeyCode.UpArrow)) {
			playerTransform.position = new Vector3(playerTransform.position.x,playerTransform.position.y,playerTransform.position.z + decalMove);

		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			playerTransform.position = new Vector3(playerTransform.position.x,playerTransform.position.y,playerTransform.position.z - decalMove);

		}*/

		/*transform.Translate (0,Input.GetAxis("Jump") * Time.deltaTime * jumpCoeff,Input.GetAxis("Vertical") * coeffMove * Time.deltaTime);

		float fireValue = Input.GetAxis ("Fire1");
		if(fireValue !=0)
			Debug.Log ("on tire...ou on donne un coup de sabre !!");*/
			
			
			
//http://forum.unity3d.com/threads/network-transform-documentation-interpolation.332437/
//pourquoi l'inerpolation est pas bien avec transform

//https://www.youtube.com/watch?v=ZsZiHe8yN9A&list=PLwyZdDTyvucyAeJ_rbu_fbiUtGOVY55BG&index=24
//http://docs.unity3d.com/ScriptReference/Networking.NetworkAnimator.GetParameterAutoSend.html
//aniamtion
		/*	[SerializeField]//visible dans l'inspecteur mais non visible par les autres scripts
	private float speed = 7.0f;
	[SerializeField]
	private float rotationSpeed = 200.0f;
			if (isLocalPlayer) {


			myTransform.Translate (Vector3.forward * Input.GetAxis ("Vertical")* Time.deltaTime * speed,Space.Self);//par défaut self
			//myTransform.Translate (0,0,myTransform.forward * Input.GetAxis ("Vertical")* Time.deltaTime * speed);

			myTransform.Rotate(0,Input.GetAxis("Horizontal")* Time.deltaTime * rotationSpeed,0);


			if (Input.GetKey (KeyCode.Space)) {
				
				//animation.Play ("Attack");
			}
			else if (Input.GetKey (KeyCode.UpArrow)) {
				
				//animation.Play ("Run");
				anim.SetBool("isRunning", true);
			}
			else{

				//animation.Play ("idle");
				anim.SetBool("isRunning", false);
			}

		}*/


	}
}
