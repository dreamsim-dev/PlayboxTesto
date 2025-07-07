using System;
using System.Collections;
using System.Collections.Generic;
using AppsFlyerSDK;
using CI.Utils.Extentions;
using InspectorButton;
using Playbox;
using UnityEngine;

public class Crosspromo : MonoBehaviour
{
    private void Start()
    {
        AppsFlyer.setIsDebug(true);
    }

    [Button]
    void Startt()
    {
        var dict = new Dictionary<string, string>();
        
        dict.Add("key1", "value1");
        dict.Add("key2", "value2");
        
        CrossPromo.RecordCrossPromoImpression("world.dreamsim.slumdogbillionaire","APS DATA LLC",dict);

        CrossPromo.GenerateUserInviteLink(dict);

        CrossPromo.OnConversionDataSucces += s =>
        {
            s.PlayboxInfo("CONVERSION DATA");

        };

        CrossPromo.OnAppOpenAttribution += app =>
        {
            
            app.PlayboxInfo("ATTREBUTION");
        };

        CrossPromo.OnOpenStoreLinkGenerated += app =>
        {
            
            app.PlayboxInfo("STORE LINK");

        };

        CrossPromo.OnInviteLinkGenerated += app =>
        {
            app.PlayboxInfo("INVITE LINK");
            
        };
    }
}
