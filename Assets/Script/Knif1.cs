using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knif1 : MonoBehaviour
{
    public Camera camera;
    public GameObject Smallball1;
    public GameObject Smallball2;
    GameObject obj1;
    GameObject obj2;
    // Use this for initialization
    void Start()
    {
        obj1 = Smallball1;
        obj2 = Smallball2;
    }

    // Update is called once per frame
    void Update()
    {
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
        if (other.tag == GameObject.FindGameObjectWithTag("Ball").tag)
        {
            Instantiate(obj1);
            Instantiate(obj2);
            obj1.transform.position = GameObject.FindGameObjectWithTag("Ball").transform.position;
            obj2.transform.position = GameObject.FindGameObjectWithTag("Ball").transform.position;

            Destroy(GameObject.FindGameObjectWithTag("Ball"));


        }
    }
}
