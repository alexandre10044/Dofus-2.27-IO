﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class FinalInt64
    {

        #region Variables

        public uint Low;
        public uint High;

        #endregion

        #region Builder

        public FinalInt64(uint param1 = 0, int param2 = 0)
        {
            Low = param1;
            High = (uint)param2;
        }

        #endregion

        #region Methods

        public static FinalInt64 FromNumber(Double param1)
        {
            return new FinalInt64((uint)param1, (int)Math.Floor((double)(param1 / 4.294967296E9)));
        }

        public Double ToNumber()
        {
            return High * 4.294967296E9 + Low;
        }

        #endregion

    }

