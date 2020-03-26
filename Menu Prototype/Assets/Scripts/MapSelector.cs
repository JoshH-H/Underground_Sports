using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSelector : MonoBehaviour
{
    //VisitPlaces
    public GameObject toScotland;
    public GameObject toFinland;
    public GameObject toIndonesia;
    public GameObject toAustralia;
    public GameObject toUSA;
    //AcceptPlaces
    public GameObject acceptScotland;
    public GameObject acceptFinland;
    public GameObject acceptIndonesia;
    public GameObject acceptAustralia;
    public GameObject acceptUSA;
    //ToGoBack
    public KeyCode back;
    
    //ToPlaces
    public void Scotland()
    {
        toScotland.SetActive(true);
        if (Input.GetKeyDown(back))
        {
            toScotland.SetActive(false);
        }
    }
    public void Finland()
    {
        toFinland.SetActive(true);
        if (Input.GetKeyDown(back))
        {
            toFinland.SetActive(false);
        }
    }
    public void Indonesia()
    {
        toIndonesia.SetActive(true);
        if (Input.GetKeyDown(back))
        {
            toIndonesia.SetActive(false);
        }
    }
    public void Australia()
    {
        toAustralia.SetActive(true);
        if (Input.GetKeyDown(back))
        {
            toAustralia.SetActive(false);
        }
    }
    public void USA()
    {
        toUSA.SetActive(true);
        if (Input.GetKeyDown(back))
        {
            toUSA.SetActive(false);
        }
    }
    //ToPlaces END
    
    //AcceptPlaces
    public void AccScotland()
    {
        acceptScotland.SetActive(true);
    }
    public void AccFinland()
    {
        acceptFinland.SetActive(true);
    }
    public void AccIndonesia()
    {
        acceptIndonesia.SetActive(true);
    }
    public void AccAustralia()
    {
        acceptAustralia.SetActive(true);
    }
    public void AccUSA()
    {
        acceptUSA.SetActive(true);
    }
    //AcceptPlaces END
}
