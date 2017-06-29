using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eggcolorchange : MonoBehaviour {
    //public GameObject ball;
    public Color _color;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("111");
        if (collision.gameObject.GetComponent<Renderer>().material.color != this._color) {
            collision.gameObject.GetComponent<Renderer>().material.color = this._color;
        }
    }
}
