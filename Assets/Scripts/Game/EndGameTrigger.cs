using UnityEngine;
using System.Collections;

public class EndGameTrigger : MonoBehaviour {


    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            GameManager.instance.WonGame();
        }
    }

}
