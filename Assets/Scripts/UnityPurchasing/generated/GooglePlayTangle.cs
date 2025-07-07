// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("tuq0l6ZyrCU/csSXmLE0lsXmVdhq0XuybBsrjiSB+WkPMYvrhzykqlhSO01sL/dTfM0Rs6BvFlgkojiOm7QqZouSJXBtfeTr+GnrSS922vg9LCfuuhSa4FBZ2gsK8jMMPlKQLTDSnDwSp+KonhMZmrHpT138u72HBjUEwajepP/EkPSpkf1fKQyNGfcC/kek33o3q88MSClw9NlwnZ4xukdTowl5IajrbXjsAaDt2ntowpXM/E7N7vzBysXmSoRKO8HNzc3JzM9OzcPM/E7Nxs5Ozc3Mew1bWWP4AYqBa6jqEyBx6svtCry91WmLxA7iLuTU35COvexZJ95jBuJXTLM250ClWmlLyHQ1WDsOPBmzIGOpjSAEEfHDiBuFsZ7zRc7PzczN");
        private static int[] order = new int[] { 9,10,5,6,6,11,7,8,13,9,10,13,12,13,14 };
        private static int key = 204;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
