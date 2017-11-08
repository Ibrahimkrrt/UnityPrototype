using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeM : MonoBehaviour {

    private float MovmentSpeed=2.0f;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            MovmentSpeed = 4.0f;
        }
        else
        {
            MovmentSpeed = 2.0f;
        }
        transform.Translate(MovmentSpeed*Input.GetAxis("Horizontal") * Time.deltaTime, 0f, MovmentSpeed*Input.GetAxis("Vertical") * Time.deltaTime);

	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coins"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
