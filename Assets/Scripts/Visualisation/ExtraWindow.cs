#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.Profiling;

namespace LoonyEngine {

    public class ExtraWindow : EditorWindow {

        [MenuItem("LoonyEngine/ExtraWindow")]
        private static void Init() {
            var window = GetWindow<ExtraWindow>();
            window.position = new Rect(0,0, 100,100);
            window.titleContent = new GUIContent("ExtraWindow");
            window.Show();
        }

        private void OnGUI() {
            AbstractPhysicsManager spm;

            if (SuperPhysicsManager.Instance == null) {
                return;
            }

            Profiler.BeginSample("MyGUI");
            spm = SuperPhysicsManager.Instance.PhysicsManagers[0];
            spm.Render();
            Profiler.EndSample();
        }

        void OnInspectorUpdate() {
            Repaint();
        }

    }

}
#endif