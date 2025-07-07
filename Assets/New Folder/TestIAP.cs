using Playbox;
using UnityEngine;

public class TestIAP : MonoBehaviour
{
    [SerializeField]
    string productID = string.Empty;
    
    public void BTN_TestIAP()
    {
        IAP.BuyProduct(productID);
    }
    
    public void BTN_TestAds()
    {
        Advertisement.Show();
    }
}
