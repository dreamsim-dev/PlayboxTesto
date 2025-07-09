using System;
using System.Collections;
using GoogleMobileAds.Ump.Api;
using Playbox;
using Playbox.Consent;
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

    public void ShowTestConsentEEA()
    {
        ConsentData.DebugSettings.DebugGeography = DebugGeography.EEA;
        
        ConsentData.ShowConsent(this, () =>
        {
            Debug.Log("Show test consent");
            
        }, true);
    }
    
    public void ShowTestConsentUSS()
    {
        ConsentData.DebugSettings.DebugGeography = DebugGeography.RegulatedUSState;
        
        ConsentData.ShowConsent(this, () =>
        {
            Debug.Log("Show test consent");
            
        }, true);
    }
    
    public void ShowTestConsentOther()
    {
        ConsentData.DebugSettings.DebugGeography = DebugGeography.Other;
        
        ConsentData.ShowConsent(this, () =>
        {
            Debug.Log("Show test consent");
            
        }, true);
    }
}
