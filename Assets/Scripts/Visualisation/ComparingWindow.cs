#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.Profiling;

namespace LoonyEngine {

    /// <summary>
    /// A window to print data about the PMs in the scene
    /// </summary>
    public class ComparingWindow : EditorWindow {

        private Vector2 m_scrollPosition;

        [MenuItem("LoonyEngine/ComparingWindow")]
        private static void Init() {
            var window = GetWindow<ComparingWindow>();
            window.position = new Rect(0, 0, 100, 100);
            window.titleContent = new GUIContent("ComparingWindow");
            window.Show();
        }

        private void OnGUI() {
            if (SuperPhysicsManager.Instance == null) {
                return;
            }

            Profiler.BeginSample("ComparingWindow");
            m_scrollPosition = EditorGUILayout.BeginScrollView(m_scrollPosition);

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.BeginVertical();
            EditorGUILayout.LabelField("Name:");
            EditorGUILayout.LabelField("Moved Elements:");
            EditorGUILayout.LabelField("Broad Checks:");
            EditorGUILayout.LabelField("Narrow Checks:");
            EditorGUILayout.LabelField("Triggers:");
            EditorGUILayout.LabelField("Collisions:");
            EditorGUILayout.LabelField("Movement Time (ms):");
            EditorGUILayout.LabelField("Collision Time (ms):");
            EditorGUILayout.EndVertical();

            foreach (AbstractPhysicsManager apm in SuperPhysicsManager.Instance.PhysicsManagers) {
                EditorGUILayout.BeginVertical();
                EditorGUILayout.LabelField(apm.Name);
                EditorGUILayout.LabelField(apm.MovedElements + "");
                EditorGUILayout.LabelField(apm.BroadChecks + "");
                EditorGUILayout.LabelField(apm.NarrowChecks + "");
                EditorGUILayout.LabelField(apm.Triggers + "");
                EditorGUILayout.LabelField(apm.Collisions + "");
                EditorGUILayout.LabelField(apm.MovementTime + "");
                EditorGUILayout.LabelField(apm.CollisionTime + "");
                EditorGUILayout.EndVertical();
            }
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.EndScrollView();
            Profiler.EndSample();
        }

        void OnInspectorUpdate() {
            Repaint();
        }

    }

}
#endif