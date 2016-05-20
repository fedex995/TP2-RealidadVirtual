using UnityEngine;
using System.Collections;

public class BrickBlock : MonoBehaviour {

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Player")
        {
            if (Random.Range(0f, 1f) > 0.6f)
                c.gameObject.SendMessage("CollectedCoin");
            Destroy(this.gameObject);
        }
    }
}
