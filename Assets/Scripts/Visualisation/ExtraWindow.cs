#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.Profiling;

namespace LoonyEngine {

    /// <summary>
    /// A window to print data about the PMs in the scene
    /// </summary>
    public class ExtraWindow : EditorWindow {

        private Vector2 m_scrollPosition;

        [MenuItem("LoonyEngine/ExtraWindow")]
        private static void Init() {
            var window = GetWindow<ExtraWindow>();
            window.position = new Rect(0,0, 100,100);
            window.titleContent = new GUIContent("ExtraWindow");
            window.Show();
        }

        private void OnGUI() {
            if (SuperPhysicsManager.Instance == null) {
                return;
            }

            Profiler.BeginSample("MyGUI");
            m_scrollPosition = EditorGUILayout.BeginScrollView(m_scrollPosition);
            foreach (AbstractPhysicsManager apm in SuperPhysicsManager.Instance.PhysicsManagers){
                apm.Render();
                EditorGUILayout.LabelField("");
                EditorGUILayout.LabelField("##############################");
                EditorGUILayout.LabelField("");
            }
            EditorGUILayout.EndScrollView();
            Profiler.EndSample();
        }

        void OnInspectorUpdate() {
            Repaint();
        }

    }

}
#endif