using UnityEngine;

public class PJGoal : MonoBehaviour
{
    public GameObject Player;
    public GameObject Driver;
    public GameObject Camera;
    public GameObject FinalTime;

    public GameObject Gold;
    public GameObject Bronze;
    public GameObject Silver;
    public GameObject TimeImage;

    private Animator Animation;
    private RaceTimer Timer;
    private PJGlobalData gd;

    private void Start()
    {
        Timer = GameObject.Find("Timer").GetComponent<RaceTimer>();
        gd = GameObject.Find("GameManager").GetComponent<PJGlobalData>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Player)
        {
            GoalReached();
        }
    }

    void GoalReached()
    {
        Animation = Driver.GetComponent<Animator>();
        Animation.SetBool("Goal", true);

        Driver.transform.parent = null;
        Camera.transform.parent = null;

        Player.GetComponent<PacuJawiMovement>().Speed = 0;
        Player.GetComponent<PacuJawiMovement>().SpeedIncrease = 0;
        Player.GetComponent<PacuJawiMovement>().activateMovement = false;

        Timer.enabled = false;
        Timer.timerText.ToString();

        TimeImage.transform.position = new Vector2(1300,700);

        if (gd.lives == 3)
        {
            Gold.SetActive(true);
        }

        if (gd.lives == 2)
        {
            Silver.SetActive(true);
        }

        if (gd.lives == 1)
        {
            Bronze.SetActive(true);
        }
    }
}
