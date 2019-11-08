using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	private Rigidbody rb;
	public float speedU;
	public float speedF;
	void Start (){
		rb = GetComponent<Rigidbody>();
		if (speedU == 0) {
			rb.velocity = transform.forward * speedF;
		}
		if (speedF == 0) {
			rb.velocity = transform.up * speedU;
		}
	}
}