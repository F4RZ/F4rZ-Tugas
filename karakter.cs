using UnityEngine;

public class karakter
{
private string name;
private int health;
private int damage;

public string Name
{
    get
    {
        return name;
    }
    set
    {
        name = value;
    }
}
public int Health
{
    get
    {
        return health;
    }
    set
    {
        health = value;
    }
}
public int Damage
{
    get
    {
        return damage;
    }
    set
    {
        damage = value;
    }
}
public void MoveLeft()
{
    Debug.Log ("Gerak Kiri");
}
public void MoveRight()
{
    Debug.Log ("Gerak Kanan");
}
public void Jump()
{
    Debug.Log ("Lompat");
}
public void Attack()
{
    Debug.Log ("Menyerang");
}
}
