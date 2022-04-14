using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dunglai : MonoBehaviour
{
    GameController Gc;
    private void Start()
    {
        Gc = FindObjectOfType<GameController>();
    }
    // keo vao
    [SerializeField]public Dropdown hungDepTrai;
    // cham vao la thong bao ( is trigger thi tinh la khong cham )
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Touch to line");
            Destroy(gameObject);
            Gc.Incre();
        }
    }
    // mac du da is trigger ( cho di xuyen qua ) nhung ma van tinh la va cham
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("DeathZone"))
        {
            Gc.GameOver = true;
            //hungDepTrai.gameObject.SetActive(true);
            Debug.Log("Touch to DeathZone");
        }
    }
}
