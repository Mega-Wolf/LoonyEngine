namespace LoonyEngine {
    using System;
    using System.Collections.Generic;
    using System.Security;
    using UnityEngine;
    using UnityEngine.Assertions;

    public class SuperPooler {

        #region [Static]

        private static SuperPooler s_instance;

        public static SuperPooler Instance {
            get {
                if (s_instance == null) {
                    s_instance = new SuperPooler();
                }

                return s_instance;
            }
        }

        #endregion

        #region [FinalVariables]

        private Dictionary<Type, object> f_poolers = new Dictionary<Type, object>();

        #endregion

        #region [Constructors]

        private SuperPooler() {}

        #endregion

        #region [Getter]

        public Pooler<T> GetPooler<T>() where T : class, new() {
            if (f_poolers.TryGetValue(typeof(T), out object dummy)) {
                return (Pooler<T>)dummy;
            }

            Type genericPoolerType = typeof(Pooler<>);
            Type specificPoolerType = genericPoolerType.MakeGenericType(typeof(T));
            object pooler = Activator.CreateInstance(specificPoolerType);

            f_poolers[typeof(T)] = pooler;
            return (Pooler<T>)pooler;
        }

        #endregion

    }
}