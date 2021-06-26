using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Human : MonoBehaviour
{
    public float timer;
    public float pickUpDelay = 3f;
    public Image rescueBar;
    public static int rescueCount;
    public static int humanCount;

    public void Start()
    {
        humanCount++;
    }

    private void OnTriggerStay(Collider other)
    {
        timer += Time.fixedDeltaTime;
        rescueBar.fillAmount = timer / pickUpDelay;
        if (timer > pickUpDelay)
        {
            rescueCount++;
            GM.myGm.rescueText.text = rescueCount.ToString();
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        timer = 0;
        rescueBar.fillAmount = 0;
    }
}
