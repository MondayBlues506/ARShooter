using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponManager : MonoBehaviour
{
    public Text test;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireWeapon()
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        test.text = "Pew!";
        yield return new WaitForSeconds(1.0f);
        test.text = "";
    }
}
