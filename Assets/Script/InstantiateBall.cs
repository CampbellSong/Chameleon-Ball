using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBall : MonoBehaviour {
    public GameObject ball;
    public Camera camera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                if (hit.collider.transform.Equals(this.transform)) {
                    GameObject newball = Instantiate(ball);
                }
            }
        }
	}
}
