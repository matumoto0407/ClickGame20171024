﻿using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour {

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }

	void Start () {
        //Shoot(new Vector3(0, 200, 2000));
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
