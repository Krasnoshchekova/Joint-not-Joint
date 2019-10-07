using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMATH : MonoBehaviour {

		Rigidbody rb;
		public float A = 0.01F;
		public float k = 0.05F;
		float Omega;

		void Start()
		{
			rb = GetComponent<Rigidbody>();
			ls ();
		}

		void ls(){
			Omega = Mathf.Sqrt (k / rb.mass);
		}

		void Update()
		{
		rb.MovePosition( new Vector3( A*Mathf.Cos(Omega*Time.realtimeSinceStartup), -A*Mathf.Abs(Mathf.Sin(Omega*Time.realtimeSinceStartup))+4f,  0f) );
		}
}
