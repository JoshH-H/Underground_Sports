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
    //Instructions
    public GameObject Instructions;
    
    //ToPlaces
    public void Scotland()
    {
        toScotland.SetActive(true);
    }
    public void Finland()
    {
        toFinland.SetActive(true);
    }
    public void Indonesia()
    {
        toIndonesia.SetActive(true);
    }
    public void Australia()
    {
        toAustralia.SetActive(true);
    }
    public void USA()
    {
        toUSA.SetActive(true);
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
    
    //CloseAllTabs
    public void Back()
    {
        toScotland.SetActive(false);
        acceptScotland.SetActive(false);
        toFinland.SetActive(false);
        acceptFinland.SetActive(false);
        toIndonesia.SetActive(false);
        acceptIndonesia.SetActive(false);
        toAustralia.SetActive(false);
        acceptAustralia.SetActive(false);
        toUSA.SetActive(false);
        acceptUSA.SetActive(false);
    }

    //Instructions

    public void InstructionsCompl()
    {
        Instructions.SetActive(false);
    }
}
