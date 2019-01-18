#if UNITY_EDITOR
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Profiling;

namespace LoonyEngine {

    /// <summary>
    /// A window to print data about the PMs in the scene
    /// </summary>
    public class ComparingWindow : EditorWindow {

        const int SIZE = 22;

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

            List<string> labels = new List<string>();
            Dictionary<string, List<object>> values = new Dictionary<string, List<object>>();
            GUIStyle gsLabel = new GUIStyle();
            gsLabel.fontSize = SIZE;
            foreach (AbstractPhysicsManager apm in SuperPhysicsManager.Instance.PhysicsManagers) {
                foreach (string label in apm.PrintData.Keys) {

                    if (!labels.Contains(label)) {
                        labels.Add(label);
                        EditorGUILayout.LabelField(label + ":", gsLabel, GUILayout.Height(SIZE + 3));
                        values[label] = new List<object>();
                    }

                    values[label].Add(apm.PrintData[label]);
                }
            }

            // EditorGUILayout.LabelField("Name:");
            // EditorGUILayout.LabelField("Moved Elements:");
            // EditorGUILayout.LabelField("Broad Checks:");
            // EditorGUILayout.LabelField("Narrow Checks:");
            // EditorGUILayout.LabelField("Triggers:");
            // EditorGUILayout.LabelField("Collisions:");
            // EditorGUILayout.LabelField("Movement Time (ms):");
            // EditorGUILayout.LabelField("Collision Time (ms):");
            EditorGUILayout.EndVertical();

            foreach (AbstractPhysicsManager apm in SuperPhysicsManager.Instance.PhysicsManagers) {
                EditorGUILayout.BeginVertical();
                //     EditorGUILayout.LabelField(apm.Name);
                //     EditorGUILayout.LabelField(apm.MovedElements + "");
                //     EditorGUILayout.LabelField(apm.BroadChecks + "");
                //     EditorGUILayout.LabelField(apm.NarrowChecks + "");
                //     EditorGUILayout.LabelField(apm.Triggers + "");
                //     EditorGUILayout.LabelField(apm.Collisions + "");
                //     EditorGUILayout.LabelField(apm.MovementTime + "");
                //     EditorGUILayout.LabelField(apm.CollisionTime + "");

                foreach (string label in labels) {
                    object data = null;
                    if (apm.PrintData.TryGetValue(label, out data)) {
                        GUIStyle gs = new GUIStyle();
                        gs.fontSize = SIZE;
                        GUIStyleState gss = new GUIStyleState();

                        object lowest = null;
                        object highest = null;
                        foreach (object value in values[label]) {

                            if (lowest == null) {
                                lowest = value;
                                highest = value;
                            } else {
                                switch (value) {
                                    case float v: {
                                            if (v < (float)lowest) {
                                                lowest = value;
                                            } else if (v > (float)highest) {
                                                highest = value;
                                            }

                                        }
                                        break;
                                    case int v: {
                                            if (v < (int)lowest) {
                                                lowest = value;
                                            } else if (v > (int)highest) {
                                                highest = value;
                                            }

                                        }
                                        break;
                                    case double v: {
                                            if (v < (double)lowest) {
                                                lowest = value;
                                            } else if (v > (double)highest) {
                                                highest = value;
                                            }

                                        }

                                        break;
                                }
                            }
                        }

                        if (lowest != null && !lowest.Equals(highest)) {
                            if (data.Equals(lowest)) {
                                gss.textColor = new Color(0, 0.5f, 0, 1);
                            } else if (data.Equals(highest)) {
                                gss.textColor = Color.red;
                            }
                        }

                        gs.normal = gss;
                        EditorGUILayout.LabelField(data.ToString(), gs, GUILayout.Height(SIZE + 3));
                    } else {
                        EditorGUILayout.LabelField("-------", gsLabel, GUILayout.Height(SIZE + 3));
                    }
                }

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