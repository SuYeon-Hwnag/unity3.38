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
        // Playerpriefs�� ����Ƽ ���� ���� ������
        int highscore = PlayerPrefs.GetInt("HighScore");
        highscoreCount.text = highscore.ToString();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // ���� ������ 1���� ���� �÷��� ��
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
