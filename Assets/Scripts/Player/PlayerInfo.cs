using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public int level;
    public int location;
    public string playerName;
    public static int counter_Z  = 0;
    public static int counter_X  = 0;
    public static int counter_C  = 0;
    public static GameObject player;
    public void Save(){
        string json = JsonUtility.ToJson(this);
        PlayerPrefs.SetString("PlayerInfo", json);
        Debug.Log("Saved as " + json);
    }

    public void Load(){
        string json = PlayerPrefs.GetString("PlayerInfo");
        JsonUtility.FromJsonOverwrite(json, this);
        Debug.Log("Loaded as " + json);
    }
    void OnEnable(){
        player = gameObject;
        Load();
    }

    void OnDisable(){
        Save();
    }

}
