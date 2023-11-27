using System.Collections;
using System.Collections.Generic;
using TA.Utility;
using UnityEngine;

public class NormalItem : Item
{
    public enum eNormalType
    {
        TYPE_ONE,
        TYPE_TWO,
        TYPE_THREE,
        TYPE_FOUR,
        TYPE_FIVE,
        TYPE_SIX,
        TYPE_SEVEN
    }

    public eNormalType itemType;

    public void SetType(eNormalType type)
    {
        itemType = type;
    }

    protected override string GetPrefabName()
    {
        string prefabname = string.Empty;
        //switch (itemType)
        //{
        //    case eNormalType.TYPE_ONE:
        //        prefabname = Constants.PREFAB_NORMAL_TYPE_ONE;
        //        break;
        //    case eNormalType.TYPE_TWO:
        //        prefabname = Constants.PREFAB_NORMAL_TYPE_TWO;
        //        break;
        //    case eNormalType.TYPE_THREE:
        //        prefabname = Constants.PREFAB_NORMAL_TYPE_THREE;
        //        break;
        //    case eNormalType.TYPE_FOUR:
        //        prefabname = Constants.PREFAB_NORMAL_TYPE_FOUR;
        //        break;
        //    case eNormalType.TYPE_FIVE:
        //        prefabname = Constants.PREFAB_NORMAL_TYPE_FIVE;
        //        break;
        //    case eNormalType.TYPE_SIX:
        //        prefabname = Constants.PREFAB_NORMAL_TYPE_SIX;
        //        break;
        //    case eNormalType.TYPE_SEVEN:
        //        prefabname = Constants.PREFAB_NORMAL_TYPE_SEVEN;
        //        break;
        //}

        //return prefabname;
        switch (itemType)
        {
            case eNormalType.TYPE_ONE:
                prefabname = "01";
                break;
            case eNormalType.TYPE_TWO:
                prefabname = "02";
                break;
            case eNormalType.TYPE_THREE:
                prefabname = "03";
                break;
            case eNormalType.TYPE_FOUR:
                prefabname = "04";
                break;
            case eNormalType.TYPE_FIVE:
                prefabname = "05";
                break;
            case eNormalType.TYPE_SIX:
                prefabname = "06";
                break;
            case eNormalType.TYPE_SEVEN:
                prefabname = "07";
                break;
        }

        return Constants.NORMAL_SKIN + prefabname;
    }

    public override void SetView()
    {
        string prefabname = GetPrefabName();

        if (!string.IsNullOrEmpty(prefabname))
        {
            //GameObject prefab = Resources.Load<GameObject>(prefabname);
            GameObject prefab = GameAssets.Instance.fishSkin.GetMatchByName(prefabname);
            if (prefab)
            {
                View = GameObject.Instantiate(prefab).transform;
                //View = Lean.Pool.LeanPool.Spawn(prefab).transform;
            }
        }
    }

    internal override bool IsSameType(Item other)
    {
        NormalItem it = other as NormalItem;

        return it != null && it.itemType == this.itemType;
    }
}
