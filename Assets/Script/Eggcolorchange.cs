using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eggcolorchange : MonoBehaviour {
    //public GameObject ball;
<<<<<<< HEAD:Assets/Script/Eggcolorchange.cs
    //public MeshRenderer ballRendere;
=======
>>>>>>> 80466d80d1484c0ccd644df3494face84dd2c358:Assets/Dyeing/Eggcolorchange.cs
    public Color _color;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collision)
    {
<<<<<<< HEAD:Assets/Script/Eggcolorchange.cs
        //Debug.Log("111");
        if (other.GetComponent<Renderer>().material.color != this._color) {
            other.GetComponent<Renderer>().material.color = this._color;
=======
        Debug.Log("111");
        if (collision.gameObject.GetComponent<Renderer>().material.color != this._color) {
            collision.gameObject.GetComponent<Renderer>().material.color = this._color;
>>>>>>> 80466d80d1484c0ccd644df3494face84dd2c358:Assets/Dyeing/Eggcolorchange.cs
        }
    }
}
