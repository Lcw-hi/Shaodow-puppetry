using UnityEngine;

public class ShoutAudio : MonoBehaviour
{
    // 检查这里有没有 public
    public void PlayTheVoice()
    {
        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
