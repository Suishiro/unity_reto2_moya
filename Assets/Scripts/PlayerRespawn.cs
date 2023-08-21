using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{

    public GameObject[] hearts;

    private int life;

    private float checkPointPositionX, checkPointPositionY;

    public Animator animator;
    void Start()
    {
        life = hearts.Length;

        if (PlayerPrefs.GetFloat("checkPointPositionX")!=0)
        {
            transform.position=(new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY")));
        }
    }

    private void CheckLife()
    {

        if (life<1)
        {
            Destroy(hearts[0].gameObject);
            animator.Play("Hit");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);



        }

        else if (life < 2)
        {
            Destroy(hearts[1].gameObject);
            animator.Play("Hit");


        }

        else if (life < 3)
        {
            Destroy(hearts[2].gameObject);
            animator.Play("Hit");


        }
        else if (life < 4)
        {
            Destroy(hearts[3].gameObject);
            animator.Play("Hit");


        }
        else if (life < 5)
        {
            Destroy(hearts[4].gameObject);
            animator.Play("Hit");


        }
        else if (life < 6)
        {
            Destroy(hearts[5].gameObject);
            animator.Play("Hit");


        }
        else if (life < 7)
        {
            Destroy(hearts[6].gameObject);
            animator.Play("Hit");

        }
        else if (life < 8)
        {
            Destroy(hearts[7].gameObject);
            animator.Play("Hit");

        }
        else if (life < 9)
        {
            Destroy(hearts[8].gameObject);
            animator.Play("Hit");

        }
        else if (life < 10)
        {
            Destroy(hearts[9].gameObject);
            animator.Play("Hit");

        }
        else if (life < 11)
        {
            Destroy(hearts[10].gameObject);
            animator.Play("Hit");

        }
        else if (life < 12)
        {
            Destroy(hearts[11].gameObject);
            animator.Play("Hit");

        }
        else if (life < 13)
        {
            Destroy(hearts[12].gameObject);
            animator.Play("Hit");

        }
        else if (life < 14)
        {
            Destroy(hearts[13].gameObject);
            animator.Play("Hit");

        }
        else if (life < 15)
        {
            Destroy(hearts[14].gameObject);
            animator.Play("Hit");

        }
        else if (life < 16)
        {
            Destroy(hearts[15].gameObject);
            animator.Play("Hit");

        }
        else if (life < 17)
        {
            Destroy(hearts[16].gameObject);
            animator.Play("Hit");

        }
        else if (life < 18)
        {
            Destroy(hearts[17].gameObject);
            animator.Play("Hit");

        }
        else if (life < 19)
        {
            Destroy(hearts[18].gameObject);
            animator.Play("Hit");

        }
        else if (life < 20)
        {
            Destroy(hearts[19].gameObject);
            animator.Play("Hit");

        }
    }

    public void ReachedCheckPoint(float x,float y)
    {
        PlayerPrefs.SetFloat("checkPointPositionX",x);
        PlayerPrefs.SetFloat("checkPointPositionY", y);

    }

    public void PlayerDamaged()
    {
        life--;
        CheckLife();
    }


}
