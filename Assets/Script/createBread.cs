using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBread : MonoBehaviour
{

    public GameObject obj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collision)
    {
        Instantiate(obj);
    }
}
