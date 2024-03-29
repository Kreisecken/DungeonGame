using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewItem", menuName ="DungeonGame/Item")]
public class ItemProperties : ScriptableObject
{
    public int id;
    public string itemName;
    public Sprite icon;
    public int maxCount = -1; // -1 for no limit
    
    virtual public void InventoryClick(Item item)
    {
        Debug.Log(itemName + " (" + item.count.ToString() + ") was clicked");
    }
}
