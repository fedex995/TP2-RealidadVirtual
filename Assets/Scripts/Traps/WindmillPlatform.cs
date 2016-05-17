using UnityEngine;
using System.Collections;

public class WindmillPlatform : MonoBehaviour
{

    public Transform pivot;
    public float rotationSpeed;
	
	// Update is called once per frame
	void Update () {
	    transform.RotateAround(pivot.position, Vector3.right, rotationSpeed * Time.deltaTime);
        transform.eulerAngles = new Vector3(0, 0, 0);
	}

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Player")
        {
            c.transform.parent = transform;
        }
    }

    void OnCollisionExit(Collision c)
    {
        if (c.gameObject.tag == "Player")
        {
            c.transform.parent = null;
        }
    }
}
