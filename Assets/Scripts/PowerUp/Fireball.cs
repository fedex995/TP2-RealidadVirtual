using UnityEngine;
using System.Collections;

public class Fireball : MonoBehaviour
{

    [SerializeField] private float launchForce;
    [SerializeField] private ParticleSystem explosion;

	// Use this for initialization
	void Start ()
    {
        Invoke("Explode", 1.8f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Goomba")
        {
            c.gameObject.SendMessage("Kill");
            Explode();
        }
    }

    void Explode()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
    
}
