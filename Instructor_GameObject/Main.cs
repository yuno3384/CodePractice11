//using System.Collections.Generic;
//using System.Drawing;
//using System.Numerics;
//using UnityEngine;

//public class Main : MonoBehaviour
//{
//    public Sprite sprite;
//    public List<Player> players = new List<Player>();

//    private void Start()
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            CreatePlayer();
//        }

//        int index = Random.Range(0, 10); // next(0, 10) 0~9
//        RemovePlayer(players[index]);
//    }

//    private void Update()
//    {
//        foreach (Player player in players)
//        {
//            GameObject go = player.gameObject;
//        }
//    }

//    void CreatePlayer()
//    {
//        GameObject go = new GameObject();
//        go.name = "Player";

//        SpriteRenderer sr = go.AddComponent<SpriteRenderer>();
//        //spriteRenderer sr = go.GetComponent<spriteRenderer>();
//        sr.sprite = sprite;
//        sr.color = Color.green;

//        Player player = go.AddComponent<Player>();
//        player.level = 2;

//        //player.enabled = false;

//        players.Add(player);
//    }

//    void RemovePlayer(Player player)
//    {
//        GameObject.Destroy(player);
//        players.Remove(player);
//    }
//}
    