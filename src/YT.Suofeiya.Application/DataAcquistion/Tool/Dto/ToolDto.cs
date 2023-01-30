﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Tool.Dto
{
    public class ToolDto : EntityDto
    {

        //采集点
        public int AcquisitionPointNo { get; set; }

        //刀具编号
        public int ToolNo { get; set; }

        //刀具名称
        public string ToolName { get; set; }

        // 刀具 电机等
        public int WornPartType { get; set; }

        //刀具上一次使用时间
        public DateTime? BeginTime { get; set; }

        //刀具最后一次使用时间
        public DateTime? EndTime { get; set; }

        // 更新时间
        public DateTime? UpdateTime { get; set; }

        // 上一次触发时间
        public DateTime? TrigLastTime { get; set; }

        //刀具使用次数
        public int UsedCount { get; set; }

        //总共使用时间
        public double TotalUsedTime { get; set; }

        //刀具预设次数
        public int PresettingCount { get; set; }

        //刀具当前状态
        public int ToolStatus { get; set; }

        //刀具当前状态
        public bool IsUsed { get; set; }

        //如果使用次数大于预设次数报警
        public bool IsAlarm { get; set; }

        // 上一次更换时间
        public DateTime? ChangeTime { get; set; }

        /// <summary>
        /// 刀具X轴移动距离
        /// </summary>
        public int? DistanceX { get; set; }

        /// <summary>
        /// 刀具Y轴移动距离
        /// </summary>
        public int? DistanceY { get; set; }

        /// <summary>
        /// 刀具Z轴移动距离
        /// </summary>
        public int? DistanceZ { get; set; }

        public int? DistanceX_Addr { get; set; }

        public int? DistanceY_Addr { get; set; }

        public int? DistanceZ_Addr { get; set; }
    }
}
