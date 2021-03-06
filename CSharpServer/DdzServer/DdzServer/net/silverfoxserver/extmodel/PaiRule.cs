/*
* SilverFoxServer: massive multiplayer game server for Flash, ...
* VERSION:3.0
* PUBLISH DATE:2015-9-2 
* GITHUB:github.com/wdmir/521266750_qq_com
* UPDATES AND DOCUMENTATION AT: http://www.silverfoxserver.net
* COPYRIGHT 2009-2015 SilverFoxServer.NET. All rights reserved.
* MAIL:521266750@qq.com
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DdzServer.net.silverfoxserver.extmodel
{
    public class PaiRule
    {
        public readonly String MING_PAI = "ming_pai";

        /// <summary>
        /// 一共最多叫分次数
        /// </summary>
        public readonly int JF_MAXCOUNT = 9;

        /// <summary>
        /// 最大的叫分值
        /// </summary>
        public readonly int JF_MAXVALUE = 3;

        /// <summary>
        /// 最小的叫分值，即不叫
        /// </summary>
        public readonly int JF_MINVALUE = 0;

        
    }
}
