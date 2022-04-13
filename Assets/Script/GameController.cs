using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int SpawnTime;
    public GameObject ball;
    float reload;
    int score;
    bool gameover;
    // Start is called before the first frame update
    void Start()
    {
        reload = 0;
    }

    // Update is called once per frame
    void Update()
    {
        reload -= Time.deltaTime;
        if(reload<=0)
        {
            SpawnBall();
            reload = SpawnTime;
        }
    }
    void SpawnBall()
    {
        Vector2 Spawnpos = new Vector2(Random.Range(-550, 550),450);
        if(ball)    Instantiate(ball, Spawnpos, Quaternion.identity);
    }
}
