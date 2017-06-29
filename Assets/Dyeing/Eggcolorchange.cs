using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eggcolorchange : MonoBehaviour {
    //public GameObject ball;
    public MeshRenderer ballRendere;
    public Color _color;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("111");
        if (ballRendere.material.color != this._color) {
            ballRendere.material.color = this._color;
        }
    }
}
