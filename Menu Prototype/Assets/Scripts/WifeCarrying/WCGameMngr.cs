using System.Collections;
using UnityEngine;

public class WCGameMngr : MonoBehaviour
{
    public GameObject CountDownAnimation;
    public GameObject Instructions;
    public GameObject Player;
    public GameObject Opponoent;

    private void Awake()
    {
        Instructions.SetActive(true);
        CountDownAnimation.SetActive(false);
        Player.GetComponent<WCMovement>().enabled = false;
        Opponoent.GetComponent<WCAI>().enabled = false;
    }

    public void InstructionsComplete()
    {
        Instructions.SetActive(false);
        StartCoroutine(ActivateMovement());
        CountDownAnimation.SetActive(true);
    }

    private IEnumerator ActivateMovement()
    {
        yield return new WaitForSeconds(4);
        Player.GetComponent<WCMovement>().enabled = true;
        Opponoent.GetComponent<WCAI>().enabled = true;
    }
}