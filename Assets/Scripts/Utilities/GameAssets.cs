using System.Collections;
using System.Collections.Generic;
using TA.Model;
using UnityEngine;

namespace TA.Utility
{
    public class GameAssets : MonoBehaviour
    {
        private static GameAssets m_instance;
        
        public static GameAssets Instance
        {
            get
            {
                if (m_instance == null)
                    m_instance = Instantiate(Resources.Load<GameAssets>("GameAssets"));
                return m_instance;
            }
        }

        public MatchSkin matchSkin;
        public MatchSkin fishSkin;
        public GameObject backgroundCellPrefab;
        public GameObject bonusHorizontal;
        public GameObject bonusVertical;
        public GameObject bonusBomb;
    }
}

