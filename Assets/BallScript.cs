using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	[SerializeField]
	private GameObject explosion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter2D(Collision2D col){
		GameObject e = Instantiate (explosion, this.transform.position, Quaternion.identity);
		Destroy (e, 2f);
		Destroy (this.gameObject);
	}
}
