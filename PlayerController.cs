using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        karakter player1;

        player1 = new karakter();
        player1.Name = "Farrell";
        player1.Health = 100;
        player1.Damage = 10;

        //Menampilkan hasil dari inisialisai attribut
        Debug.Log ("Name :"+player1.Name+", Health:"+player1.Health+",Damage:"+player1.Damage);

        //Memaggil Method dari salah satu method di class karakter.
        player1.Jump();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
