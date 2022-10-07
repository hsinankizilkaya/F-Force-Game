using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class howToPlay : MonoBehaviour
{
    
    ParticleSystem prtcls;
    Button btnnn;

    void Start()
    {
        Time.timeScale = 1;
        Button btnnn = GetComponent<Button>();
        btnnn.onClick.AddListener(howToPlayy);

    }

    void howToPlayy()
    {
        SceneManager.LoadScene(2);
    }
}
