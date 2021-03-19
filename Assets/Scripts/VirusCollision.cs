using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusCollision : MonoBehaviour
{
    public GameObject prefabExplosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            var explosion = Instantiate(prefabExplosion);
            explosion.transform.position = this.transform.position;
            Destroy(this.gameObject);
            Destroy(collision.collider.gameObject);
        }
        if (collision.collider.tag == "Bullet")
        {
            var explosion = Instantiate(prefabExplosion);
            explosion.transform.position = this.transform.position;
            Destroy(this.gameObject);
            Destroy(collision.collider.gameObject);
        }
        
    }
}
