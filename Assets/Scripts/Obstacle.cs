using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float moveSpeed;
    Player m_pla;
    GameController m_gc;
    // Start is called before the first frame update
    void Start()
    {
        m_gc = FindObjectOfType<GameController>();
        m_pla = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_gc.IsGameOver())
        {
            return;
        }
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("SceneLimit"))
        {
            m_gc.ScoreIncrement();

            Destroy(gameObject);          
        }
        if (col.CompareTag("Player"))
        {
            m_gc.SetGameoverState(true);
            Destroy(gameObject);
        }
    }
    
}
