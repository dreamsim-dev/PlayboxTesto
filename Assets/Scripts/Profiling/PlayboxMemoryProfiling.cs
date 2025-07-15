using CI.Utils.Extentions;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Profiling;

public class PlayboxMemoryProfiling : MonoBehaviour
{
    [SerializeField] UnityEvent<string> onMemoryProfilingFinished;
    
    public void ShowAllMemory()
    {
        long textureMemory = 0;
        foreach (var tex in Resources.FindObjectsOfTypeAll<Texture2D>())
        {
            textureMemory += Profiler.GetRuntimeMemorySizeLong(tex);
        }
        
        onMemoryProfilingFinished?.Invoke($"Total texture memory: {textureMemory / (1024 * 1024)} MB");
    }
    
    public void CleanMemory()
    {
        Resources.UnloadUnusedAssets();
        System.GC.Collect();
    }
}
