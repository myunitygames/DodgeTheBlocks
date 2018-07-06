using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    public float gravityScaleAdjust = 20f;
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / gravityScaleAdjust;
    }

    // Update is called once per frame
    void Update () {
        //destroy the fallen blocks
		if(transform.position.y < -2f)
        {
            Destroy(gameObject);
        }
	}
}
