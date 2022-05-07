using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHolder : MonoBehaviour
{
  public static DataHolder instance;
  public static DataHolder Instance { get { return instance; } }

  #region DATA
  [SerializeField]
  private string playerName = "Player";
  #endregion DATA

  #region ACCESSORS
  public string PlayerName { get { return playerName; } set { playerName = value; } }
  #endregion ACCESSORS
  void Awake()
  {
    if (instance != null)
    {
      Destroy(gameObject);
      return;
    }
    instance = this;
  }
}
