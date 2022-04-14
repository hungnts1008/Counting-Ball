using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int SpawnTime;
    public GameObject ball;
    float Reload;
    public int Score;
    public bool GameOver;
    public UI M_ui;
    // Start is called before the first frame update
    void Start()
    {
        Reload = 0;
        Score = 0;
        M_ui = FindObjectOfType<UI>();
        M_ui.SetScoreText("Score: " + Score);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver)
        {
            M_ui.ShowGameOver(true);    
            return;
        }
        Reload -= Time.deltaTime;
        if(Reload<=0)
        {
            SpawnBall();
            Reload = SpawnTime;
        }
    }
    void SpawnBall()
    {
        Vector2 Spawnpos = new Vector2(Random.Range(-550, 550),450);
        if(ball)    Instantiate(ball, Spawnpos, Quaternion.identity);
    }
    public void Incre()
    {
        Score++;
        M_ui.SetScoreText("Score: " + Score);
    }
    public void replay()
    {
        Score = 0;
        GameOver = false;
        M_ui.SetScoreText("Score: " + Score);
        M_ui.ShowGameOver(false);
    }
}
