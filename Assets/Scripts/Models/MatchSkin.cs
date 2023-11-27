using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TA.Model
{
    [CreateAssetMenu(menuName = "Skin/Match", fileName = "SkinConfig")]
    public class MatchSkin : ScriptableObject
    {
        [SerializeField] Match[] matches = null;
        Dictionary<string, GameObject> m_lookupTable = null;

        public GameObject GetMatchByName(string name)
        {
            BuildLookUp();
            return m_lookupTable[name];
        }


        private void BuildLookUp()
        {
            if (m_lookupTable != null) return;
            m_lookupTable = new Dictionary<string, GameObject>();
            foreach (Match match in matches)
            {
                m_lookupTable[match.name] = match.prefab;
            }
        }
        [System.Serializable]
        class Match
        {
            public string name;
            public GameObject prefab;
        }
    }
}

