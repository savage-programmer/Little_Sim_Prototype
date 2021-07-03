using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothSelection : MonoBehaviour
{
    public Cloth ClothInfo
    {
        get { return m_ClothInfo; }
        set { m_ClothInfo = value; }
    }

    //ScripthAble Object Reference
    [SerializeField] private Cloth m_ClothInfo;

    //UI Element References
    [SerializeField] private Image m_Image;
    [SerializeField] private Text m_ClothName;
    [SerializeField] private Text m_Price;
    [SerializeField] private Button m_EquipButton;


    private void Awake()
    {
        m_EquipButton.onClick.AddListener(OnEquipButtonClick);
        //SetClothInfo();
    }

    public void SetClothInfo()
    {
        m_Image.gameObject.SetActive(false);
        m_ClothName.text = m_ClothInfo.C_Name;
        m_Price.text = m_ClothInfo.Price;


    }

    private void OnEquipButtonClick()
    {
        ClothManager.ClothEquip?.Invoke(m_ClothInfo);   
    }

    

}
