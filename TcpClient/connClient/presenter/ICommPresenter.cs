﻿using System.Collections.Generic;
using bitkyFlashresUniversal.connClient.model.bean;

namespace bitkyFlashresUniversal.connClient.presenter
{
    public interface ICommPresenter
    {
        /// <summary>
        ///     客户端已获取Socket的回调函数
        /// </summary>
        void GetSocketSuccess();

        /// <summary>
        ///     设置数据帧
        /// </summary>
        /// <returns>处理后的数据帧</returns>
        void SetFrameData(FrameData frameData);

        /// <summary>
        ///     连接失效
        /// </summary>
        void ConnFailed(string evenType);

        /// <summary>
        /// 根据预设的IP及端口号初始化TCP客户端
        /// </summary>
        void InitTcpClient(string ip, int port);

        /// <summary>
        /// 开始启动持续采集模式
        /// </summary>
        void DeviceGatherStart(OperateType type);

        /// <summary>
        /// 开启工作流程
        /// </summary>
        void StartWork();
        void InsertDataIntoDb(List<Electrode> electrodes);
        void InsertDataIntoDbComplete();

        /// <summary>
        ///     从前端关闭连接
        /// </summary>
        void FrontConnClosed();

        /// <summary>
        ///     通信信息的显示
        /// </summary>
        /// <param name="message">输入所需显示的信息</param>
        void CommunicateMessageShow(string message);
        /// <summary>
        ///     发送帧信息的显示
        /// </summary>
        /// <param name="message">输入所需显示的信息</param>
        void SendDataShow(string message);

        /// <summary>
        ///     接收帧信息的显示
        /// </summary>
        /// <param name="message">输入所需显示的信息</param>
        void ReceiveDataShow(string message);
        /// <summary>
        /// 数据库数据轮廓信息显示
        /// </summary>
        /// <param name="message"></param>
        void DataOutlineShow(string message);

        /// <summary>
        /// 检查数据表的正确性，并显示轮廓信息
        /// </summary>
        /// <returns></returns>
        bool CheckTable();
        /// <summary>
        ///     清空已采集的数据
        /// </summary>
        void GatherDataClear();
    }
}