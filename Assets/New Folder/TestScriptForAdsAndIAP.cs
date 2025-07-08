using System;
using System.Collections;
using Playbox;
using UnityEngine;
using UnityEngine.Events;

public class TestScriptForAdsAndIAP : MonoBehaviour
{
    [SerializeField]
    string productID = string.Empty;
    
    [SerializeField]
    UnityEvent<Color> onColorChange;

    public void BTN_TestIAP()
    {
        IAP.BuyProduct(productID);
    }
    
    public void BTN_TestAds()
    {
        if (Advertisement.isReady())
        {
            Advertisement.Show();
        }
    }

    private void OnEnable()
    {
        MainInitialization.PostInitialization += StartCoroutinmeUPD;
    }

    private void OnDisable()
    {
        MainInitialization.PostInitialization -= StartCoroutinmeUPD;
    }

    void StartCoroutinmeUPD()
    {
        StartCoroutine(updColor());
    }

    IEnumerator updColor()
    {
        while (true)
        {
            onColorChange.Invoke(Advertisement.isReady() ? Color.green : Color.white);
            
            yield return new WaitForSeconds(0.25f);
        }
    }
}
