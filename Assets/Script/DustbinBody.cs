using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustbinBody : MonoBehaviour {
    public Color color;
    public GameObject ball;
	// Use this for initialization
	void Start () {
       

    }

    // Update is called once per frame
    void Update () {
		
	}
    
void OnTriggerEnter(Collider other)
    {
        if (other.tag == GameObject.FindGameObjectWithTag("smallball1").tag) {
            
            GameObject.FindGameObjectWithTag("smallball1").GetComponent<Renderer>().material.color = color;
            ball.GetComponent<Rigidbody>().velocity = new Vector3(2, 0, 0);
            Debug.Log("111");
            //GameObject.FindGameObjectWithTag("smallball").transform.position = GameObject.FindGameObjectWithTag("cube").transform.position;
        }
    } 
}
