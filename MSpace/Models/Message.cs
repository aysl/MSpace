﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MSpace.Models
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	Message
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Models
     * 文 件 名:	Message
     * 创建时间:	2013/3/15 9:22:06
     * 作    者:	常伟华 Changweihua
	 * 版    权:	Message说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	3c1dffdf-fee0-4c5f-b64c-ba5fd11f51c6  
	 *
	 * 登录用户:	Changweihua
	 * 所 属 域:	Lumia800

	 * 创建年份:	2013
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    #endregion

    /// <summary>
    /// 摘要
    /// </summary>
    public class Message
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        [Required]
        public string Content { get; set; }
        public string PublishDate { get; set; }
    }
}