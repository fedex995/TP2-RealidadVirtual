using UnityEngine;
using System.Collections;

public class ParticleSystemAutoDestroy : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
	    Invoke("Destroy", 1);
	}

    void Destroy()
    {
        Destroy(this.gameObject);
    }
}
