#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.Profiling;

namespace LoonyEngine {

    public class ExtraWindow : EditorWindow {

        public static ExtraWindow Instance { get; private set; }

        [MenuItem("LoonyEngine/ExtraWindow")]
        private static void Init() {
            var window = GetWindow<ExtraWindow>();
            Instance = window;
            window.titleContent = new GUIContent("ExtraWindow");
            window.Show();
        }

        private void OnGUI() {
            StupidPhysicsManager spm = null;

            if (SuperPhysicsManager.Instance == null) {
                return;
            }

            Profiler.BeginSample("MyGUI");
            spm = (StupidPhysicsManager)SuperPhysicsManager.Instance.PhysicsManagers[0];
            spm.Render();
            Profiler.EndSample();
        }

        void OnInspectorUpdate() {
            Repaint();
        }

    }

}
#endif