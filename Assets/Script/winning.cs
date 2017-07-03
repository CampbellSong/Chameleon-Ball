using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winning : MonoBehaviour {

    public GameObject Winning;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider collision)
    {
        Winning.SetActive(true);
        Destroy(collision.gameObject);
    }
}
