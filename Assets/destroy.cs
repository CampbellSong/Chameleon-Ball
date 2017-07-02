using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

	// Use this for initialization
    public GameObject init1;
    public GameObject init2;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "platform")
        {
            Destroy(this.gameObject);
            if (init1)
            {
                Instantiate(init1);
            }
            if (init2)
            {
                Instantiate(init2);
            }

            
        }
    }
}
