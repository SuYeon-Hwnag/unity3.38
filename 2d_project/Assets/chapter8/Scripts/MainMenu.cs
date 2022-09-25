using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class MainMenu : MonoBehaviour
{
    public TMP_Text highscoreCount;

    void Awake()
    {
        // Playerpriefs는 유니티 내부 저장 데이터
        int highscore = PlayerPrefs.GetInt("HighScore");
        highscoreCount.text = highscore.ToString();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // 다음 씬으로 1번이 게임 플레이 씬
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ChangeVolume(float value)
    {
        PlayerPrefs.SetFloat("Volume", value);
    }
}
