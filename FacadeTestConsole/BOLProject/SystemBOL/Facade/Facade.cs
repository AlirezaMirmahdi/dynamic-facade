using BOLProject.BOL.BaseBol;
using System;
using System.Collections.Generic;

namespace BOLProject.BOL.SystemBOL.Facade
{
    public class Facade
    {
        private Dictionary<Type, IBaseBol> _bolsList = new Dictionary<Type, IBaseBol>();

        public Facade() { }

        public T GetBol<T>() where T : BaseBol.BaseBol
        {
            Type requestedType = typeof(T);
            IBaseBol resValue;
            var canGetValue = _bolsList.TryGetValue(requestedType, out resValue);
            if (canGetValue)
            {
                return resValue as T;
            }
            var requestedObj = Activator.CreateInstance(requestedType, this);
            _bolsList.Add(requestedType, requestedObj as BaseBol.BaseBol);
            return requestedObj as T;
        }
    }
}
