using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GM : MonoBehaviour
{
    public static GM myGm;
    public TextMeshProUGUI rescueText;

    private void Awake()
    {
        myGm = this;
    }
}
