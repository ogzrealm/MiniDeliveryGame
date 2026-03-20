using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    private int _maxTrash = 5;
    [SerializeField] private int currentTrash;
    public void addInventory()
    {
        if (currentTrash <= _maxTrash)
        {
            currentTrash++;
            Debug.Log(currentTrash);
        }
    }
}
