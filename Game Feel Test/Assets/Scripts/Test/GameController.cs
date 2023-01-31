using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Projectile projectile, projectile2, projectile3;
    public GameObject misileObj, misileObj2, misileObj3;
    public Transform misilesT, misilesT2, misilesT3;
    public int countScale=0;
    public Text textSize;
    public Material mat1, mat2;
    int matCont = 0;
    
    public int contCurrentRocket = 0;
    

    public GameObject hud1, hud2, hud3;
    public GameObject hudA;

    int contSpeed1, contSpeed2, contSpeed3;
    float velInit1, velInit2, velInit3;
    int contW1, contW2, contW3;
    float wInit, wInit2, wInit3;

    public Spawn sp;
    public ObjectPooling obj;

    private void Start()
    {
        misileObj.SetActive(false);
        misileObj2.SetActive(false);
        misileObj3.SetActive(false);
        velInit1 = projectile.speed;
        velInit2 = projectile2.speed;
        velInit3 = projectile3.speed;
        wInit = projectile.waitTime;
        wInit2 = projectile2.waitTime;
        wInit3 = projectile3.waitTime;
        sp.gameObject.GetComponent<Spawn>();
        obj.gameObject.GetComponent<ObjectPooling>();
        sp.gameObject.GetComponent<Spawn>().enabled = false;
        
    }
    public void ChangeRocket() 
    {
        contCurrentRocket++;
        if (contCurrentRocket == 1)
        {
            misileObj.SetActive(true);
            misileObj2.SetActive(false);
            misileObj3.SetActive(false);
        }
        else if (contCurrentRocket == 2)
        {
            misileObj2.SetActive(true);
            misileObj.SetActive(false);
            misileObj3.SetActive(false);
        }
        else if (contCurrentRocket == 3)
        {
            misileObj3.SetActive(true);
            misileObj.SetActive(false);
            misileObj2.SetActive(false);
        }
        else if (contCurrentRocket > 3) 
        {
            contCurrentRocket = 0;
            misileObj3.SetActive(false);
            misileObj.SetActive(false);
            misileObj2.SetActive(false);
        }
    
    }
    public void ChangeColor() 
    {
        matCont++;
        
        Renderer rend = misileObj.GetComponent<Renderer>();
        Renderer rend2 = misileObj2.GetComponent<Renderer>();
        Renderer rend3 = misileObj3.GetComponent<Renderer>();
        if (contCurrentRocket == 1)
        {

            if (matCont == 1)
            {
                rend.material = mat2;

            }
            else if (matCont == 2)
            {
                rend.material = mat1;

            }
            else if (matCont == 3) 
            {
                matCont = 0;
            }
        }
        //Start the color2;
        else if (contCurrentRocket == 2)
        {
            Debug.Log("color2");
            if (matCont == 1)
            {
                rend2.material = mat2;

            }
            else if (matCont == 2)
            {
                rend2.material = mat1;

            }
            else if (matCont == 3)
            {
                matCont = 0;
            }
        }
        //Start the color3
        else if (contCurrentRocket == 3) 
        {
            Debug.Log("color3");
            if (matCont == 1)
            {
                rend3.material = mat2;

            }
            else if (matCont == 2)
            {
                rend3.material = mat1;

            }
            else if (matCont == 3)
            {
                matCont = 0;
            }
        }
        
        



        Debug.Log(matCont);
    }

    public void ChangeHud() 
    {
        if (contCurrentRocket == 1)
        {
            hud1.SetActive(true);
            hudA.SetActive(false);
        }
        else if (contCurrentRocket == 2)
        {
            hud1.SetActive(false);
            hudA.SetActive(false);
            hud2.SetActive(true);

        }
        else if (contCurrentRocket == 3)
        {
            hud2.SetActive(false);
            hudA.SetActive(false);
            hud3.SetActive(true);
        }
        else if (contCurrentRocket == 0) 
        {
            hudA.SetActive(true);
        }
    }
    public void ChangeSpeedR1() 
    {
        contSpeed1++;
        if (contSpeed1 < 4)
        {
            projectile.speed++;
        }
        else if (contSpeed1 >= 4) 
        {
            projectile.speed = velInit1;
        }
    }
    public void ChangeSpeedR2()
    {
        contSpeed2++;
        if (contSpeed1 < 4)
        {
            projectile2.speed++;
        }
        else if (contSpeed1 >= 4)
        {
            projectile2.speed = velInit1;
        }
    }
    public void ChangeSpeedR3()
    {
        contSpeed3++;
        if (contSpeed3 < 4)
        {
            projectile3.speed++;
        }
        else if (contSpeed3 >= 4)
        {
            projectile3.speed = velInit1;
        }
    }
    public void ChangeW1() 
    {
        contW1++;
        if (contW1 < 4)
        {
            projectile.waitTime++;
        }
        else if (wInit >= 4) 
        {
            projectile.waitTime = wInit;
        }
    }
    public void ChangeW2()
    {
        contW2++;
        if (contW2 < 4)
        {
            projectile2.waitTime++;
        }
        else if (wInit2 >= 4)
        {
            projectile2.waitTime = wInit2;
        }
    }
    public void ChangeW3()
    {
        contW3++;
        if (contW3 < 4)
        {
            projectile3.waitTime++;
        }
        else if (wInit3 >= 4)
        {
            projectile3.waitTime = wInit3;
        }
    }
    public void ActivateT() 
    {
        sp.gameObject.SetActive(true);
        obj.gameObject.SetActive(true);
        sp.gameObject.GetComponent<Spawn>().enabled = true;
    }
    public void DA()
    {
        sp.gameObject.SetActive(false);
        obj.gameObject.SetActive(false);

    }
}
