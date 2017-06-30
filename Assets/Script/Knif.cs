using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knif : MonoBehaviour {
    public Camera camera;
    public GameObject Smallball;
    GameObject obj;
	// Use this for initialization
	void Start () {
        obj = Smallball;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.transform.Equals(this.transform))
                {
                    this.GetComponent<Rigidbody>().useGravity = true;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == GameObject.FindGameObjectWithTag("Ball").tag) {
            Instantiate(obj);
            Instantiate(obj);
            obj.transform.position = GameObject.FindGameObjectWithTag("Ball").transform.position;
            Destroy(GameObject.FindGameObjectWithTag("Ball"));
           
            
        }
    } 
}
