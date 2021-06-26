using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI coinsText;

    // Start is called before the first frame update
    void Start()
    {
        coinsText.text = Player.coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
