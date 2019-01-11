using System;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace LoonyEngine {

    public abstract class ObjectOrderInformation {
        public abstract void UpdateIDs();

        public abstract void Render(Rect rect);
    }

    public class ObjectOrderInformation<T> : ObjectOrderInformation {

        enum Changing {
            Same,
            Different,
            Added,
            Removed
        }

        #region [FinalVariables]

        private string f_name;

        // this whole approach only works with lists and arrays
        private ICollection<T> f_collection;

        private List<int> f_idLast = new List<int>();
        private List<int> f_idThis = new List<int>();

        private Func<T, int> f_getID;

        private List<Changing> f_comparedToLast = new List<Changing>();

        #endregion

        #region [Constructors]

        public ObjectOrderInformation(string name, ICollection<T> collection, Func<T, int> getID) {
            this.f_name = name;
            this.f_collection = collection;

            f_getID = getID;
        }

        #endregion

        #region [Override]

        public override void UpdateIDs() {
            List<int> dummy = f_idLast;
            f_idLast = f_idThis;
            f_idThis = dummy;
            f_comparedToLast.Clear();
            f_idThis.Clear();
            int i = 0;
            foreach (T t in f_collection) {
                int id = f_getID(t);
                f_idThis.Add(id);

                if (f_idLast.Count <= i) {
                    f_comparedToLast.Add(Changing.Added);
                    continue;
                }

                if (f_idLast[i] == id) {
                    f_comparedToLast.Add(Changing.Same);
                } else {
                    f_comparedToLast.Add(Changing.Different);
                }

                ++i;
            }

            for (; i < f_idLast.Count; ++i) {
                f_comparedToLast.Add(Changing.Removed);
            }

        }

#if UNITY_EDITOR

        public override void Render(Rect rect) {
            EditorGUILayout.LabelField(f_name);

            for (int j = 0; j < f_comparedToLast.Count; ++j) {

                Color color = Color.black;

                switch (f_comparedToLast[j]) {
                    case Changing.Added:
                        color = (Color.yellow + Color.red) / 2;
                        break;
                    case Changing.Removed:
                        color = Color.magenta;
                        break;
                    case Changing.Same:
                        color = Color.green;
                        break;
                    case Changing.Different:
                        color = Color.red;
                        break;
                }
                EditorGUI.DrawRect(new Rect(j, rect.y + 18, 1, 25), color);
            }
        }

#endif

        #endregion

    }

}