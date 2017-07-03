using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyself : MonoBehaviour {

    // Use this for initialization
    public float time;
    void Start()
    {
        StartCoroutine("DestroyParticle", time);
    }

    IEnumerator DestroyParticle(float waitTime)
    {

        yield return new WaitForSeconds(waitTime);
        Destroy(this.gameObject);
    }
}
