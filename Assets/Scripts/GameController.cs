using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject obstacle;
    public float spawnTime;
    float m_spawnTime;
    bool m_isGameover;
    int m_score;
    UiManager m_ui;
    // Start is called before the first frame update
    void Start()
    {
        m_spawnTime = 0;
        m_ui = FindObjectOfType<UiManager>();
        m_ui.SetScoreText("Score: " + m_score);
    }

    // Update is called once per frame
    void Update()
    {
        if (m_isGameover)
        {
            m_spawnTime = 0;
            m_ui.ShowGameoverPanel(true);
            return;
        }

        m_spawnTime -= Time.deltaTime;
        if(m_spawnTime <= 0)
        {
            spawnObstacle();
            m_spawnTime = spawnTime;
        }
    }

    public void spawnObstacle()
    {
        float randYpos = Random.Range(-2.58f, -1.5f);
        Vector2 spawnPos = new Vector2(11, randYpos);
        if (obstacle != null)
        {
            Instantiate(obstacle, spawnPos, Quaternion.identity);
        }
    }
    public void Replay()
    {
        SceneManager.LoadScene("GamePlay");
        m_score = 0;
        m_isGameover = false;
        m_ui.SetScoreText("Score: " + m_score);
        m_ui.ShowGameoverPanel(false);
    }
    public void SetScore(int value)
    {
        m_score = value;
    }
    public int getScore()
    {
        return m_score;
    }
    public void ScoreIncrement()
    {
        
        m_score++;
        m_ui.SetScoreText("Score: " + m_score);
    }
    public bool IsGameOver()
    {
        return m_isGameover;
    }
    public void SetGameoverState(bool state)
    {
        m_isGameover = state;
    }
}
