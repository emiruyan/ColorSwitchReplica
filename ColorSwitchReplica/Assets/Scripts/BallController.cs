using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb; //Rigidbody 2d eriştik
    [SerializeField] private float jumpForce; //Float türünde bir jumpForce değişkeni oluşturduk
    [SerializeField] private string currentColor;

    //Renklerimize erişiyoruz;
    [SerializeField] private Color colorCyan;
    [SerializeField] private Color colorYellow;
    [SerializeField] private Color colorPink;
    [SerializeField] private Color colorPurple;

    [SerializeField] private SpriteRenderer spriteRenderer; //Unity içerisindeki Sprite Renderer'a eriştik. 


    private void Start()
    {
        RandomColor();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Mouse sol click tıklıyor ise;
        {
            rb.velocity = Vector2.up * jumpForce; //Vector2.up ve jumpForce'u çarp ve velocity'e ata
        }
    }

    private void OnTriggerEnter2D(Collider2D col)//Tetiklendiği anda;
    {
        if (col.tag != currentColor)
        {
            Debug.Log("You Death"); 
        }
    }

    void RandomColor()//Topumuza rastgele renk atayacağımız fonksiyon
    {
        int index = Random.Range(0, 4); //0 ve 4 arasında rastgele bir index oluşuturup index'e atadık
        
        switch (index) //index case'e eşit olursa ball'ın rengi değişecek
        {
            case 0: currentColor = "Cyan";
                spriteRenderer.color = colorCyan; //colorCyan'ı, Ball sr color'ına atıyoruz.
                break;
            case 1: currentColor = "Yellow";
                spriteRenderer.color = colorYellow;
                break;
            case 2: currentColor = "Pink";
                spriteRenderer.color = colorPink;
                break;
            case 3: currentColor = "Purple";
                spriteRenderer.color = colorPurple;
                break;
        }
    }
}
