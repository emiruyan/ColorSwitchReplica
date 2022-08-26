using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
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
    [SerializeField] private int star;
    [SerializeField] private Text startText;
    


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
        if (col.tag == "Star")
        {
            star++;
            startText.text = star.ToString();
            Destroy(col.gameObject);
            return;
        }
        
        if (col.tag == "ColorChanger" ) //Ball'ın çarptığı objenin tagı ColorChanger'a eşit ise;
        {
            RandomColor(); ////Topumuza rastgele renk atayacağımız fonksiyon
            Destroy(col.gameObject);//Çarpıştığmız objeyi yok et
            return;   
        }
        if (col.tag != currentColor) //Ball'ın çarptığı obje eşit değilse cuurentColor'a;
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Oynadığımız sahneyi tekrar oynatıyoruz
        }
    }

    void RandomColor()//Topumuza rastgele renk atayacağımız fonksiyon
    {
        int index = Random.Range(0, 4); //0 ve 4 arasında rastgele bir rakam oluşuturup index'e atadık
        
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
