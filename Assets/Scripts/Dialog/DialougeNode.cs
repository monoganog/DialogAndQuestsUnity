using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Dialouge
{

    [System.Serializable]
    public class DialougeNode
    {
        public string UID;
        public string text;
        public string[] children;
    }
}
