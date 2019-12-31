using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionDistanceToTargetNode))]
    public class AIDecisionDistanceToTargetNodeEditor: AIDecisionNodeEditor
    {
        private SerializedProperty _comparisonMode;
        private SerializedProperty _distance;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            if (CollapseNodeOn) return;

            _comparisonMode = serializedObject.FindProperty("comparisonMode");
            _distance = serializedObject.FindProperty("distance");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_comparisonMode);
            NodeEditorGUILayout.PropertyField(_distance);
            serializedObject.ApplyModifiedProperties();
        }

    }
}