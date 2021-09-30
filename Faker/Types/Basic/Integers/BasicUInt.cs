﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Types.Basic
{
    class BasicUInt: BasicInterface
    {
        private Type _type = typeof(uint);
        private Random _rnd = new Random();

        public Type TypeGetting
        {
            get
            {
                return _type;
            }
        }

        public T getObj<T>()
        {
            var buffer = new byte[4];
            _rnd.NextBytes(buffer);
            return (T)Convert.ChangeType(BitConverter.ToUInt32(buffer, 0), typeof(T));
        }
    }
}