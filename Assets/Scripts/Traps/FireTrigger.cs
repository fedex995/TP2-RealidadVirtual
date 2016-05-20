using UnityEngine;
using System.Collections;

public class FireTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            c.gameObject.SendMessage("ReduceLives");
        }
    }
}
