using UnityEngine;

public class WCGoal : MonoBehaviour
{
    public GameObject Player;
    public GameObject Opponent;
    public GameObject GoalWindow;
    public GameObject LostWindow;

    private Animator Animation;

    private void Start()
    {
/*        GoalWindow.SetActive(false);
        LostWindow.SetActive()*/
        Animation = Player.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Player)
        {
            Animation.SetBool("Running", false);
            Player.GetComponent<WCMovement>().enabled = false;
            Opponent.GetComponent<WCAI>().Speed = 0;
            GoalWindow.SetActive(true);

        }

        if (collision.gameObject == Opponent)
        {
            LostWindow.SetActive(true);
        }
    }
}
