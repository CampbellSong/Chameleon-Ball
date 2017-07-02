using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallballspeed : MonoBehaviour
{

    public GameObject obj;

    public Vector3 speed;
	// Use this for initialization
	void Start ()
	{
	    obj.GetComponent<Rigidbody>().velocity = speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
