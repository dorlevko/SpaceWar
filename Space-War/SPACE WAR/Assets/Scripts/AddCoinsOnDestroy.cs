using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCoinsOnDestroy : MonoBehaviour
{
    public int amount;

    private void OnDestroy()
    {
        Player.AddCoins(amount);
    }
}
