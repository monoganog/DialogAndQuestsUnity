using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Dialouge
{
    [CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue", order = 0)]
    public class Dialogue : ScriptableObject
    {
        [SerializeField]
        DialougeNode[] nodes;

        private void Awake()
        {
            Debug.Log("im awake");
        }
    }
}