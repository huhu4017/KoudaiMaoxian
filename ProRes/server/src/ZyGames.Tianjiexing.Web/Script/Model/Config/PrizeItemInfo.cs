﻿/****************************************************************************
Copyright (c) 2013-2015 scutgame.com

http://www.scutgame.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
****************************************************************************/
using System;
using ProtoBuf;
using ZyGames.Framework.Event;

namespace ZyGames.Tianjiexing.Model.Config
{
    /// <summary>
    /// 奖励物品配置信息
    /// </summary>
    [Serializable, ProtoContract]
    public class PrizeItemInfo : EntityChangeEvent
    {
        public PrizeItemInfo()
            : base(false)
        {

        }
        /// <summary>
        /// 类型 0：物品 1：灵件 2:附魔符
        /// </summary>
        [ProtoMember(1)]
        public int Type { get; set; }

        /// <summary>
        /// 物品ID
        /// </summary>
        [ProtoMember(2)]
        public int ItemID
        {
            get;
            set;
        }

        /// <summary>
        /// 数量
        /// </summary>
        [ProtoMember(3)]
        public int Num
        {
            get;
            set;
        }
    }
}