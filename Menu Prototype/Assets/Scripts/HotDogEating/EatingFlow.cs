using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EatingFlow : MonoBehaviour
{
    public Transform foodBar;

    private static float currentFood = 10;

   private static float maxFood = 200;

    //public KeyCode eat;
    public bool eating_W { get; set; }
    public float timeCheck = 0;
    void Start()
    {
        foodBar.GetComponent<Image>().color = new Color(0,1,0);
        eating_W = true;
    }

    void Update()
    {
        //FoodBar
        if (Input.GetKey(KeyCode.W) && eating_W)
        {
            timeCheck += Time.deltaTime;
        }
        else
        {
            if (currentFood < maxFood)
            {
                    currentFood += 0.15f;
            }
        }
        

        if (timeCheck>.50)
        {

            timeCheck = 0;
            currentFood -= 20;
        }
        
        if (currentFood>51)
        {
            foodBar.GetComponent<Image>().color = new Color(1,1,0);
        }
        if (currentFood>100)
        {
            foodBar.GetComponent<Image>().color = new Color(1,0,0);
        }
        if (currentFood<50)
        {
            foodBar.GetComponent<Image>().color = new Color(0,1,0);
        }

        if (currentFood <= 10)
        {
            timeCheck -= Time.deltaTime;
        }
        foodBar.GetComponent<RectTransform>().localScale = new Vector3(1, currentFood/maxFood, 1);
        //FoodBarEND
    }
    //Animevents
    public void disableEat()
    {
        eating_W = false;
        StartCoroutine("restartFood");
    }

    IEnumerator restartFood()
    {
        yield return new WaitForSeconds(1.5f);
        eating_W = true;
        Debug.Log("works");
    }
}
