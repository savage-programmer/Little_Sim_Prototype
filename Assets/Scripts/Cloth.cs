using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ClothType
{
    Shirt,
    Feets,
    Pant
}

[CreateAssetMenu]
public class Cloth : ScriptableObject
{
    public string C_Name;
    public string Price;
    public ClothType Type;
    public int ClothIndex;

}
