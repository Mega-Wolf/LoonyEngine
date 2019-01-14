namespace LoonyEngine {
    using System.Collections.Generic;
    using UnityEngine;

    public class Pooler<T> where T : class, new() {

        #region [FinalVariables]

        private List<T> f_list = new List<T>();

        #endregion

        #region [PrivateVariables]

        private int m_usedItems;

        #endregion

        #region [Properties]

        public int Size { get { return m_usedItems; } }

        #endregion

        #region [Getter] 

        public T GetInstance() {

            if (m_usedItems == f_list.Count) {
                T t = new T();
                f_list.Add(t);
            }

            T ret = f_list[m_usedItems];

            ++m_usedItems;

            return ret;
        }

        #endregion

        #region [Setter]

        public void ReleaseInstance(T instance) {

            int index = -1;
            for (int i = 0; i < f_list.Count; ++i) {
                if (instance == f_list[i]) {
                    index = i;
                    break;
                }
            }

            --m_usedItems;

            f_list[index] = f_list[m_usedItems];
            f_list[m_usedItems] = instance;
        }

        #endregion

    }
}