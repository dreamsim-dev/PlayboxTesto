using System;
using System.Collections;
using System.Collections.Generic;
using CI.Utils.Extentions;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class AppCrusher : MonoBehaviour
{
   public void DevireToNull()
   {
       int i = 10;
       
       i = i / 0;
      
   }

   public void GetTheNullString()
   {
       string a = null;
       a.PlayboxInfo("ERROR_TESTING_CRUSH");
   }
   
   public void GetException()
   {
       throw new Exception("ERROR_TESTING_CRUSH");
   }
}
