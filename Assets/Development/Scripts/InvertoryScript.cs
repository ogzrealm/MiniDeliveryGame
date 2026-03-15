using UnityEngine;

public class InvertoryScript : MonoBehaviour
{
    [SerializeField] private int maxTrash = 5;
    [SerializeField] private int currentTrash;
    public void addInvertory()
    {
        if (currentTrash <= maxTrash)
        {
            currentTrash++;
            Debug.Log(currentTrash);
        }
    }
}
