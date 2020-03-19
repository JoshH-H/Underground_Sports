using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuTransition : MonoBehaviour
{
    //public GameObject Logo;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine("Switch");
    }

    IEnumerator Switch()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("LDScreen");
    }
}
