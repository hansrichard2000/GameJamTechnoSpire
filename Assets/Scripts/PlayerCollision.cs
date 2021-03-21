using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public GameObject prefabExplosion;
    int life = 3;
    public Text textlife;

    // Start is called before the first frame update
    void Start()
    {
        textlife.text = "" + life;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Virus1")
        {
            if(life == 0)
            {
                /*var explosion = Instantiate(prefabExplosion);
                explosion.transform.position = this.transform.position;*/
                Destroy(this.gameObject);
                SceneManager.LoadScene("GameOverScene");
            }
            else
            {
                life -= 1;
            }
        }
        if (collision.collider.tag == "Virus2")
        {
            if (life == 0)
            {
                /*var explosion = Instantiate(prefabExplosion);
                explosion.transform.position = this.transform.position;*/
                Destroy(this.gameObject);
                SceneManager.LoadScene("GameOverScene");
            }
            else
            {
                life -= 1;
            }
        }
        if (collision.collider.tag == "Virus3")
        {
            if (life == 0)
            {
                /*var explosion = Instantiate(prefabExplosion);
                explosion.transform.position = this.transform.position;*/
                Destroy(this.gameObject);
                SceneManager.LoadScene("GameOverScene");
            }
            else
            {
                life -= 1;
            }
        }
        if (collision.collider.tag == "Vbullet")
        {
            if (life == 0)
            {
                /*var explosion = Instantiate(prefabExplosion);
                explosion.transform.position = this.transform.position;*/
                Destroy(this.gameObject);
                SceneManager.LoadScene("GameOverScene");

            }
            else
            {
                life -= 1;
            }
        }
        textlife.text = "" + life;
    }
}
