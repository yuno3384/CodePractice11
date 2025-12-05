//using System.Numerics;
//using UnityEngine;
//using UnityEngine.U2D;

//public class Player : MonoBehaviour
//{
//    // 인스펙터에서 노출되게끔 Sprite 타입의 이름은 sprite 변수를 만들어주시고, 유니티에서 텍스쳐를 연결해주세요.
//    //public Sprite sprite;
//    //[SerializeField] private Sprite sprite; // 이미지를 연결해 놓은 상황

//    public int level = 1;
//    public int hp = 100;
//    public int damage = 10;

//    private void Start()
//    {
//        // 게임오브젝트가 이미 있을것이다 가정하고 작업
//        GameObject go = gameObject; // 현재 내가 기생하고있는 게임오브젝트 가져오기
//        //SpriteRenderer sr = go.AddComponent<SpriteRenderer>();
//        //sr.sprite = sprite;
//        //sr.color = Color.blue;

//        // Transform tr = GetComponent<Transform>(); // 현재 게임오브젝트의 트랜스폼 가져오기
//        Transform tr = transform; // 현재 게임오브젝트의 트랜스폼 가져오기
//        tr.position = new Vector3(5, 0, 0); // 만들어진 좌표 안쓰고 내가 원하는 좌표 넣어줄때 사용

//    }
//}