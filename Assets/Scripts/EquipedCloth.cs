using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class EquipedCloth : MonoBehaviour
{
    [SerializeField] private Material[] m_Shirts;
    [SerializeField] private Material[] m_Feets;
    [SerializeField] private Material[] m_Pants;

    [SerializeField] private MeshRenderer m_FeetMeshRenderer;
    [SerializeField] private SkinnedMeshRenderer m_ShirtMeshRenderer;
    [SerializeField] private SkinnedMeshRenderer m_PantMeshRenderer;


    private void Awake()
    {
        ClothManager.ClothEquip += OnNewClothEquiped;
    }

    private void OnNewClothEquiped(Cloth cloth)
    {
        if (cloth.Type == ClothType.Shirt)
            m_ShirtMeshRenderer.materials[m_ShirtMeshRenderer.materials.Length - 1] = m_Shirts[cloth.ClothIndex];
        else if (cloth.Type == ClothType.Feets)
            m_FeetMeshRenderer.materials[m_FeetMeshRenderer.materials.Length - 1] = m_Feets[cloth.ClothIndex];
        else
            m_PantMeshRenderer.materials[m_PantMeshRenderer.materials.Length - 1] = m_Pants[cloth.ClothIndex];

    }


}
