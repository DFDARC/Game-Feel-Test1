using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change : MonoBehaviour
{
    public Projectile projectile;
    public GameObject misileObj;
    public Transform misilesT;
    public int countScale;
    public Text textSize;
    public Material mat1, mat2;
    int matCont = 1;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(1, 1, 1);
        textSize.GetComponent<Text>();
        projectile.GetComponent<Projectile>();
        projectile = FindObjectOfType<Projectile>();
        
    }
    void Update()
    {
        textSize.text = misileObj.transform.localScale + "";
        if (Input.GetKeyDown(KeyCode.Z))
        {
            countScale++;
            AdjustScale();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            ChangeSped();
        }
        if (Input.GetKeyDown(KeyCode.V)) 
        {
            ChangeColor();
        }

    }

    public void AdjustScale()
    {
        if (countScale == 1)
        {

            // transform.localScale = new Vector3(2, 2, 2);
            misileObj.transform.localScale = new Vector3(2, 2, 2);
            Debug.Log(countScale);
        }
        else if (countScale == 2)
        {
            misileObj.transform.localScale = new Vector3(3, 3, 3);
        }
        else if (countScale == 5)
        {
            misileObj.transform.localScale = new Vector3(1, 1, 1);
        }
    }
    public void Click()
    {
        Debug.LogError("clique" + countScale);
        countScale++;
        if (countScale >= 5)
        {
            countScale = 0;
        }
        AdjustScale();
    }
    public void ChangeSped()
    {
        projectile.speed += projectile.speed + 2;
    }

    public void ChangeColor()
    {
        Renderer rend = misileObj.GetComponent<Renderer>();


        if (matCont == 1)
        {
            rend.material = mat2;
            matCont++;
        }
        else if (matCont == 2)
        {
            rend.material = mat1;
            matCont = 1;
        }



        Debug.Log(matCont);

    }
}
