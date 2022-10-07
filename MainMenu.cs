using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    ParticleSystem prtcls;
    Button btn;

    void Start()
    {
        Time.timeScale = 1;
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(PlayGame);

    }

    void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}
