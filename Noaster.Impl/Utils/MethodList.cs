﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Noaster.Api;
using Noaster.Impl.Parts;

namespace Noaster.Impl.Utils
{
    public class MethodList : IList<IMethod>
    {
        private readonly IType _type;
        private readonly IList<IMethod> _coll;

        public MethodList(IType type)
        {
            _type = type;
            _coll = new List<IMethod>();
        }

        #region Collection stuff

        public void Add(IMethod item)
        {
            if (IsSpecial(item))
                return;
            _coll.Add(item);
        }

        public IEnumerator<IMethod> GetEnumerator() => _coll.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable) _coll).GetEnumerator();

        public void Clear() => _coll.Clear();

        public bool Contains(IMethod item) => _coll.Contains(item);

        public void CopyTo(IMethod[] array, int arrayIndex) => _coll.CopyTo(array, arrayIndex);

        public bool Remove(IMethod item) => _coll.Remove(item);

        public int Count => _coll.Count;

        public bool IsReadOnly => _coll.IsReadOnly;

        public int IndexOf(IMethod item) => _coll.IndexOf(item);

        public void Insert(int index, IMethod item) => _coll.Insert(index, item);

        public void RemoveAt(int index) => _coll.RemoveAt(index);

        public IMethod this[int index]
        {
            get { return _coll[index]; }
            set { _coll[index] = value; }
        }

        #endregion

        private bool IsSpecial(IMethod item)
        {
            var name = item.Name.Split('_').First();
            Special kind;
            return Enum.TryParse(name, true, out kind) && Understand(kind, item);
        }

        private bool Understand(Special kind, IMethod item)
        {
            var name = item.Name.Split(new[] {'_'}, 2).Last();
            switch (kind)
            {
                case Special.Get:
                case Special.Set:
                    return AddOrUpdateProperty(name, kind == Special.Get, item);
                case Special.Add:
                case Special.Remove:
                    return AddOrUpdateEvent(name, kind == Special.Add, item);
                default:
                    return false;
            }
        }

        private bool AddOrUpdateEvent(string name, bool isAdd, IMethod orig)
        {
            var holder = _type as IHasEvents;
            if (holder == null)
                return false;
            var evt = holder.Events.FirstOrDefault(e => e.Name == name);
            if (evt == null)
                holder.Events.Add(evt = new EventImpl(name));
            evt.Visibility = orig.Visibility;
            return true;
        }

        private bool AddOrUpdateProperty(string name, bool isGet, IMethod orig)
        {
            var holder = _type as IHasProperties;
            if (holder == null)
                return false;
            var prop = holder.Properties.FirstOrDefault(p => p.Name == name);
            if (prop == null)
                holder.Properties.Add(prop = new PropertyImpl(name));
            prop.Visibility = orig.Visibility;
            return true;
        }

        public enum Special
        {
            Get,
            Set,
            Add,
            Remove
        }
    }
}