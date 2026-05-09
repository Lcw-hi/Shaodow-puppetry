using UnityEngine;

public class MonkeyVoice : MonoBehaviour 
{
    // 只要动画运行到书签处，就会调用这个“手指”函数
    public void CallBajie() {
        AudioSource audio = GetComponent<AudioSource>();
        if (audio != null) {
            audio.Play(); 
            Debug.Log("大圣开嗓啦！播放的是：" + audio.clip.name);
        }
    }
}
