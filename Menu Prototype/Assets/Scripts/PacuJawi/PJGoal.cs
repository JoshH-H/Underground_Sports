using UnityEngine;

public class PJGoal : MonoBehaviour
{
    public GameObject Player;
    public GameObject Driver;
    public GameObject Camera;
    public GameObject FinalTime;


    private Animator Animation;
    private RaceTimer Timer;

    private void Start()
    {
        Timer = GameObject.Find("Timer").GetComponent<RaceTimer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Player)
        {
            Animation = Driver.GetComponent<Animator>();
            Animation.SetBool("Goal", true);
            Driver.transform.parent = null;
            Camera.transform.parent = null;

            Player.GetComponent<PacuJawiMovement>().Speed = 0;
            Player.GetComponent<PacuJawiMovement>().SpeedIncrease = 0;
            Player.GetComponent<PacuJawiMovement>().activateMovement = false;
            FinalTime.SetActive(true);
            Timer.enabled = false;
            Timer.timerText.ToString();
        }
    }
}
