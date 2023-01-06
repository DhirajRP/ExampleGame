
using UnityEngine;

public class concepts : MonoBehaviour
{
    void Start()
    {
        player p1 = new player();
        player p2 = new player();

        p2.takeDamage(18);
        Debug.Log("Health of P1" + p1.hitPOint);
        Debug.Log("Damage caused by P2" + p2.damage);
        Debug.Log("Health of P2" + p2.hitPOint);
        Debug.Log("Damage caused by P1" + p1.damage);
    }

   
}

class player
{
    // Attributes
   public int hitPOint = 100;
    public int damage = 10;
    // Methods
    public int dealDamage()
    {
       
        return damage;
    }
    public void takeDamage(int hit)
    {
        hitPOint = hitPOint - hit;
        
    }

}