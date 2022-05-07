using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUIHandler : MonoBehaviour
{
    public void ChangePlayerName(string newName)
    {
        Debug.Log("Changing player name to: " + newName);
        DataHolder.Instance.PlayerName = newName;
    }
}
