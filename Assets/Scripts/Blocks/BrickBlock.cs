using UnityEngine;
using System.Collections;

public class BrickBlock : MonoBehaviour {

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
