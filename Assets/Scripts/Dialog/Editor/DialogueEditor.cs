using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;

namespace RPG.Dialouge.Editor
{
    public class DialogueEditor : EditorWindow
    {

        Dialogue selectedDialogue = null;

        [MenuItem("Window/Dialogue Editor")]
        public static void ShowEditorWindow()
        {
            Debug.Log("show editor window");
            GetWindow(typeof(DialogueEditor), false, "Dialogue Editor");
        }

        [OnOpenAssetAttribute(1)]
        public static bool OnOpenAsset(int instanceID, int line)
        {
            if (EditorUtility.InstanceIDToObject(instanceID) is Dialogue)
            {
                ShowEditorWindow();
                return true;
            }
            return false;
        }
        private void OnGUI()
        {
            if(selectedDialogue == null)
            {
                EditorGUILayout.LabelField("No Dialogue Selected");
            }
            else
            {
                EditorGUILayout.LabelField(selectedDialogue.name);
            }
        }
        void OnSelectionChange()
        {
            //Dialogue newDialogue = Selection.activeObject as Dialogue;
            if (Selection.activeObject is Dialogue)
            {
                selectedDialogue = Selection.activeObject as Dialogue;
                Repaint();
            }
        }
    }
}
