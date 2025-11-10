using UnityEngine;

public class MainGameControlller : MonoBehaviour
{
    private  MainGameControlller Instance { get;  set; }

    public int RoomCounter;
    
    private void Awake() 
    {
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }

    private void ResetRoomCounter()
    {
        RoomCounter = 0;
    }
}
