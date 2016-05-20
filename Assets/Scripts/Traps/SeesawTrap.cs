using UnityEngine;
using System.Collections;

public class SeesawTrap : MonoBehaviour {

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            c.gameObject.layer = LayerMask.NameToLayer("SeesawTrap");
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            c.gameObject.layer = LayerMask.NameToLayer("Player");
        }
    }
}
