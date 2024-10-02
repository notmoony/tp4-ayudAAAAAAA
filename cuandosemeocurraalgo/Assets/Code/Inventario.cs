using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    public void Agregar(Item item)
    {
        items.Add(item);
    }
}
