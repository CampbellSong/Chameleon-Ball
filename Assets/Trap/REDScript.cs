﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REDScript : MonoBehaviour {
    public Color _color;
    public GameObject ball;
    public MeshRenderer meshRenderer;
    public Light light;
    public Camera camera;
    bool _bSwitch=false;
	// Use this for initialization
	void Start () {
       // meshRenderer.material.color = _color;
      //  light.color = _color;
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
                    _bSwitch = !_bSwitch;
                    _color = _bSwitch? Color.yellow:Color.red;                 
                    meshRenderer.material.color = _color;
                    light.color = _color;
     
                }
            }
        }
}
    
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.GetComponent<Renderer>().material.color != meshRenderer.material.color)
        {
            Destroy(collision.gameObject, .5f);
        }
    } 
   
    
}
