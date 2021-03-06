﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Structure
{
    public class Proxy : Subject
    {
        private RealSubject _realSubject;

        public void PerformAction()
        {
            if (_realSubject == null)
                _realSubject = new RealSubject();

            _realSubject.PerformAction();
        }

    }
}
