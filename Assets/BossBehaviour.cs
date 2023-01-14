using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossBehaviour : Character
{

    public int life = 5;
    
    public override void DealDamage(float val)
    {
        life -= 1;
        Debug.Log(life);
        if (life == 0)
        {
            GameLogic.instance.EndBoss();
            ConsoleText.getInstance().ShowMessage("Boss defeat");
            
            base.DealDamage(val);
        }
        else
        {
            GameObject thisExplosionObject = GameObject.Instantiate(explosionFX);
            thisExplosionObject.transform.position = transform.position;
            
        }
        
    }
    

   
}
