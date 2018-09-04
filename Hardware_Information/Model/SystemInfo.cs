using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_Information
{
    /// <summary>
    /// 操作系统信息
    /// </summary>
    class SystemInfo
    {
        /// <summary>  
        /// CPU序列号  
        /// </summary>  
        public string CpuID { set; get; } = "";
        /// <summary>  
        /// 网卡/Mac地址  
        /// </summary>  
        public string MacAddress { set; get; } = "";
        /// <summary>  
        /// 硬盘ID  
        /// </summary>  
        public List<DiskInfo> DiskInfoList { set; get; } = null;
        /// <summary>  
        /// IP地址  
        /// </summary>  
        public string IpAddress { set; get; } = "";
        /// <summary>  
        /// 系统登录用户名  
        /// </summary>  
        public SysName SysName { set; get; } = null;
        /// <summary>  
        /// 系统名称  
        /// </summary>  
        public string ComputerName { set; get; } = "";

        /// <summary>
        /// 系统型号
        /// </summary>
        public SysModel SystemModel { set; get; } = null;

        //private SysModel _systemType;
        ///// <summary>  
        ///// 系统型号  
        ///// </summary>  
        //public SysModel SystemType
        //{
        //    set { _systemType = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SystemType")); }
        //    get { return _systemType; }
        //}

        /// <summary>
        /// 物理内存（单位b） 
        /// </summary>
        public List<MemoryInfo> MemoryList { set; get; }

        //private List<MemoryInfo> _MemoryList;
        ///// <summary>  
        ///// 物理内存（单位b）  
        ///// </summary>  
        //public List<MemoryInfo> MemoryList
        //{
        //    set { _MemoryList = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MemoryList")); }
        //    get { return _MemoryList; }
        //}

        /// <summary>
        /// 显卡芯片
        /// </summary>
        public string VideoProcessor { set; get; } = "";
        //private string _VideoProcessor;
        ///// 显卡芯片
        ///// </summary>
        //public string VideoProcessor
        //{
        //    set { _VideoProcessor = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("VideoProcessor")); }
        //    get { return _VideoProcessor; }
        //}


        //public event PropertyChangedEventHandler PropertyChanged;
    }

    class SysName
    {
        public string Caption { set; get; } = "";

        public string OS { set; get; } = "";
    }

    class SysModel
    {
        public string Mau { set; get; } = "";

        public string SModel { set; get; } = "";
    }
}
