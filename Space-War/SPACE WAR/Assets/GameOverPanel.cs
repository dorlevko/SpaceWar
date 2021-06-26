using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverPanel : MonoBehaviour
{
    public TextMeshProUGUI enmeyKilledText;
    public TextMeshProUGUI humanRescueText;
    public TextMeshProUGUI stayUntouchedText;
    
    private void OnEnable()
    {
        enmeyKilledText.text = ((Health.enemyKilled / Health.enemyCount) * 100) + "% Enemy killed";
        humanRescueText.text = ((Human.rescueCount / Human.humanCount) * 100) + "% Human killed";
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
