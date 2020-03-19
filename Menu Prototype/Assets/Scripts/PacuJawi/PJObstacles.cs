using System.Collections;
using UnityEngine;
public class PJObstacles : MonoBehaviour
{
    public GameObject Player;
    public GameObject Driver;

    private Animator Animation;
    private PJGlobalData gd;

    void Start()
    {
        gd = GameObject.Find("GameManager").GetComponent<PJGlobalData>();
        GetComponent<Animator>();
        Player.GetComponent<Animator>().SetBool("Hurting", false);
    }

    private IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            PJGlobalData.lives--;
            GameObject.Find("GameManager").GetComponent<PJGlobalData>().UpdateLives();
            Player.GetComponent<PacuJawiMovement>().Speed = 2;
            Player.GetComponent<Animator>().SetBool("Hurting", true);

            yield return new WaitForSeconds(5);

            Player.GetComponent<Animator>().SetBool("Hurting", false);
            Player.GetComponent<PacuJawiMovement>().Speed = 5;
        }

        if (PJGlobalData.lives == 0)
        {
            Player.GetComponent<PacuJawiMovement>().Speed = 0;
        }
    }
}