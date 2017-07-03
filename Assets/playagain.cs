using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;//增加命名空间

public class Playagain : MonoBehaviour
{
    public void ButtonClick()
    {
        //Application.LoadLevel("menu");  // sceneName就是你要加载的场景----这是老式的用法
        SceneManager.LoadScene(0);//1是场景的索引
        // Application.LoadLevel(sceneName);
    }
}