using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Button = UnityEngine.UI.Button;

public class EatingFlow : MonoBehaviour
{
    //Bars
    public Transform foodBar;
    public Transform drinkBar;
    public Transform burpBar;
    //Food
    private static float currentFood = 10;
    private static float maxFood = 200;
    public Button eatButton;
    //Drink
    private static float currentDrink = 10;
    private static float maxDrink = 150;
    public Button drinkButton;
    //Burp
    private static float currentBurp = 10;
    private static float maxBurp = 160;
    public Button burpButton;
    //ButtonActions
    public bool eating_W { get; set; }
    public bool drinking_S { get; set; }
    public bool burping_SP { get; set; }
    //TimeScale
    public float timeCheck = 0;
    public float timeCheckDr = 0;
    public float timeCheckBr = 9;
    //Misc
    public GameObject lose;
    private Animator Animation;
    public GameObject Player;
    void Start()
    {
        //BarStartingColour
        foodBar.GetComponent<Image>().color = new Color(0,1,0);
        drinkBar.GetComponent<Image>().color = new Color(0,1,0);
        burpBar.GetComponent<Image>().color = new Color(0,1,0);
        //ButtonsActivated
        eating_W = true;
        drinking_S = true;
        burping_SP = false;
        burpButton.interactable = false;
        Animation = Player.GetComponent<Animator>();
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
                    currentFood += 0.10f;
            }
        }
        if (timeCheck>.30)
        {

            timeCheck = 0;
            currentFood += 5;
            currentDrink += 5;
        }
        
        if (currentFood>81)
        {
            foodBar.GetComponent<Image>().color = new Color(1,1,0);
        }
        if (currentFood>151)
        {
            foodBar.GetComponent<Image>().color = new Color(1,0,0);
        }
        if (currentFood<80)
        {
            foodBar.GetComponent<Image>().color = new Color(0,1,0);
        }

        if (currentFood <=10)
        {
            timeCheck -= Time.deltaTime;
        }
        foodBar.GetComponent<RectTransform>().localScale = new Vector3(1, currentFood/maxFood, 1);
        
        if (currentFood > 199)
        {
            Animation.SetBool("Barf", true);
        }
        //FoodBarEND
        
        //DrinkBar
        if (Input.GetKey(KeyCode.S) && drinking_S)
        {
            timeCheckDr += Time.deltaTime;
            //drinkButton.SetActive(true);
        }
        else
        {
            if (currentDrink < maxDrink)
            {
                currentDrink += 0.05f;
            }
        }
        if (timeCheckDr>.35)
        {

            timeCheckDr = 0;
            currentDrink -= 10;
            currentFood -= 10;
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

        if (currentDrink > 149)
        {
            Animation.SetBool("Barf", true);
        }
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
        if (timeCheckBr>.15)
        {

            timeCheckBr = 0;
            currentBurp -= 15;
            currentDrink -= 3;
            currentFood -= 7;
        }
        
        if (currentBurp>51)
        {
            burpBar.GetComponent<Image>().color = new Color(1,1,0);
        }
        if (currentBurp>100)
        {
            burpBar.GetComponent<Image>().color = new Color(1,0,0);
            /*Debug.Log("fish");*/
        }
        if (currentBurp > 135)
        {
            burping_SP = true;
            burpButton.interactable = true;
        }
        if (currentBurp<50)
        {
            burpBar.GetComponent<Image>().color = new Color(0,1,0);
        }

        if (currentBurp <= 15)
        {
            timeCheckBr -= Time.deltaTime;
            burping_SP = false;
            burpButton.interactable = false;
        }
        burpBar.GetComponent<RectTransform>().localScale = new Vector3(1, currentBurp/maxBurp, 1);

        if (currentBurp > 159)
        {
            Animation.SetBool("Barf", true);
        }
        
    }
    //AnimEvents
    //FoodAnim
    public void disableEat()
    {
        eating_W = false;
        eatButton.interactable = false;
        StartCoroutine("restartFood");
    }

    IEnumerator restartFood()
    {
        yield return new WaitForSeconds(1);
        eating_W = true;
        eatButton.interactable = true;
    }
    //FoodAnimEND
    
    //DrinkAnim
    public void disableDrink()
    {
        drinking_S = false;
        drinkButton.interactable = false;
        StartCoroutine("restartDrink");
    }

    IEnumerator restartDrink()
    {
        yield return new WaitForSeconds(1);
        drinking_S = true;
        drinkButton.interactable = true;
    }
    //DrinkAnimEND
    
    //BurpAnim
    public void disableBurp()
    {
        burping_SP= false;
        burpButton.interactable = false;
    }
    //END
    public void barfLose()
    {
        lose.SetActive(true);
        Time.timeScale = 0;
    }
    
    //Misc
    IEnumerator beginDR()
    {
        yield return new WaitForSeconds(1);
        timeCheckDr += Time.timeScale;
        Debug.Log("poof");
    }

}
