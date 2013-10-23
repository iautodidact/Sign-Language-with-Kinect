﻿// author：      fyhuang
// created time：2013/10/17 17:23:52
// organizatioin:CURE lab, CUHK
// copyright：   2013-2015
// CLR：         4.0.30319.18052
// project link：https://github.com/huangfuyang/Sign-Language-with-Kinect

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Research.DynamicDataDisplay.Common;


namespace CURELab.SignLanguage.Debugger.Model
{
    /// <summary>
    /// add summary here
    /// </summary>

    public class SegmentedWordCollection : RingArray<SegmentedWordModel>
    {
        private const int TOTAL_POINTS = 300;

        public SegmentedWordCollection()
            : base(TOTAL_POINTS) // here i set how much values to show 
        {
        }
    }

    public class SegmentedWordModel
    {
        

        public string Word { get; set; }

        public int StartTime { get; set; }
        public int EndTime { get; set; }

        public SegmentedWordModel(string word, int from, int to)
        {
            this.Word = word;
            this.StartTime = from;
            this.EndTime = to; 
        }
    }
}