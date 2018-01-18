using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCannon : MonoBehaviour {

	[SerializeField]
	private GameObject ball;
	[SerializeField]
	private float offset;
	[SerializeField]
	private float force;
	[SerializeField]
	private GameObject firePoint;
	[SerializeField]
	private float rotationSpeed;
	private float fireRate = 1f;
	private float coolDown = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && Time.time > coolDown) {
			GameObject b = Instantiate (ball, firePoint.transform.position, this.transform.rotation);
			Rigidbody2D phy = b.GetComponent<Rigidbody2D> ();
			phy.AddForce (b.transform.up * force);
			coolDown = Time.time + fireRate;
		}
		if(Input.GetAxis("Vertical") > 0){
			Quaternion rotation = this.transform.rotation;
			rotation *= Quaternion.Euler (0f, 0f, rotationSpeed);
			this.transform.rotation = rotation;

		}
		if(Input.GetAxis("Vertical") < 0){
			Quaternion rotation = this.transform.rotation;
			rotation *= Quaternion.Euler (0f, 0f, -rotationSpeed);
			this.transform.rotation = rotation;

		}
	}
}
