using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSelector : MonoBehaviour
{
    public GameObject toScotland;
    public GameObject toFinland;
    public GameObject toIndonesia;
    public GameObject toAustralia;
    public GameObject toUSA;

    public GameObject acceptScotland;
    public GameObject acceptFinland;
    public GameObject acceptIndonesia;
    public GameObject acceptAustralia;
    public GameObject acceptUSA;
    
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
}
