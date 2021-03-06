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
     * 类 名 称:	ArticleComment
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Areas.Admin.Models
     * 文 件 名:	ArticleComment
     * 创建时间:	2013/3/13 14:02:03
     * 作    者:	常伟华 Changweihua
	 * 版    权:	ArticleComment说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	5d3a32a0-479d-40c4-b56f-baf8b6f4a938  
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
    public class ArticleComment
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        /// <summary>
        /// 相册名称
        /// </summary>
        [Display(Name = "您的昵称")]
        public string Name { get; set; }
        [Display(Name = "电子邮件")]
        public string Email { get; set; }
        [Display(Name = "个人网址")]
        public string Website { get; set; }
        [Display(Name = "评论内容")]
        public string Content { get; set; }
    }
}