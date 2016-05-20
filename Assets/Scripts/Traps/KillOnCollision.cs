using UnityEngine;
using System.Collections;

public class KillOnCollision : MonoBehaviour {

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Player")
        {
            c.gameObject.SendMessage("Kill");
        }
    }
}
