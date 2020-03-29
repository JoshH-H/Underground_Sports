using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EatingFlow : MonoBehaviour
{
    //Bars
    public Transform foodBar;
    public Transform drinkBar;

    public Transform burpBar;
    //Food
    private static float currentFood = 10;
    private static float maxFood = 200;
    //Drink
    private static float currentDrink = 10;
    private static float maxDrink = 150;
    //Burp
    private static float currentBurp = 10;
    private static float maxBurp = 150;
    //ButtonActions
    public bool eating_W { get; set; }
    public bool drinking_S { get; set; }
    public bool burping_SP { get; set; }
    //TimeScale
    public float timeCheck = 0;
    public float timeCheckDr = 0;
    public float timeCheckBr = 0;
    void Start()
    {
        //BarStartingColour
        foodBar.GetComponent<Image>().color = new Color(0,1,0);
        drinkBar.GetComponent<Image>().color = new Color(0,1,0);
        burpBar.GetComponent<Image>().color = new Color(0,1,0);
        //ButtonsActivated
        eating_W = true;
        drinking_S = true;
        burping_SP = true;
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
                    currentFood += 0.20f;
            }
        }
        if (timeCheck>.35)
        {

            timeCheck = 0;
            currentFood -= 10;
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
        
        //DrinkBar
        if (Input.GetKey(KeyCode.S) && drinking_S)
        {
            timeCheckDr += Time.deltaTime;
            timeCheck += Time.deltaTime;
        }
        else
        {
            if (currentDrink < maxDrink)
            {
                currentDrink += 0.30f;
            }
        }
        if (timeCheckDr>.25)
        {

            timeCheckDr = 0;
            currentDrink -= 10;
        }
        
        if (currentDrink>51)
        {
            drinkBar.GetComponent<Image>().color = new Color(1,1,0);
        }
        if (currentDrink>100)
        {
            drinkBar.GetComponent<Image>().color = new Color(1,0,0);
        }
        if (currentDrink<50)
        {
            drinkBar.GetComponent<Image>().color = new Color(0,1,0);
        }

        if (currentDrink <= 10)
        {
            timeCheckDr -= Time.deltaTime;
        }
        drinkBar.GetComponent<RectTransform>().localScale = new Vector3(1, currentDrink/maxDrink, 1);
        //DrinkBarEND
        
        //BurpBar
        if (Input.GetKey(KeyCode.Space) && burping_SP)
        {
            timeCheckBr += Time.deltaTime;
        }
        else
        {
            if (currentBurp < maxBurp)
            {
                currentBurp += 0.10f;
            }
        }
        if (timeCheckBr>.80)
        {

            timeCheckBr = 0;
            currentBurp -= 10;
        }
        
        if (currentBurp>51)
        {
            burpBar.GetComponent<Image>().color = new Color(1,1,0);
        }
        if (currentBurp>100)
        {
            burpBar.GetComponent<Image>().color = new Color(1,0,0);
        }
        if (currentBurp<50)
        {
            burpBar.GetComponent<Image>().color = new Color(0,1,0);
        }

        if (currentBurp <= 10)
        {
            timeCheckBr -= Time.deltaTime;
        }
        burpBar.GetComponent<RectTransform>().localScale = new Vector3(1, currentBurp/maxBurp, 1);
    }
    //AnimEvents
    //FoodAnim
    public void disableEat()
    {
        eating_W = false;
        StartCoroutine("restartFood");
    }

    IEnumerator restartFood()
    {
        yield return new WaitForSeconds(1.5f);
        eating_W = true;
    }
    //FoodAnimEND
    
    //DrinkAnim
    public void disableDrink()
    {
        drinking_S = false;
        StartCoroutine("restartDrink");
    }

    IEnumerator restartDrink()
    {
        yield return new WaitForSeconds(2.5f);
        drinking_S = true;
        Debug.Log("works");
    }
}
