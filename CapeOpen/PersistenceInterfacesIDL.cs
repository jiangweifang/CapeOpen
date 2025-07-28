﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace CapeOpen
{
    /// <summary>
    /// 持久化
    /// </summary>
    [ComImport]
    [ComVisible(false)]
    [Guid("0000010c-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPersist
    {
        /// <summary>
        /// 获取一个类的唯一标识符。
        /// </summary>
        /// <param name="pClassID"></param>
        void GetClassID(out Guid pClassID);
    };

    /// <summary>
    /// This interface cannot be import through PIA for some reason
    /// </summary>
    [Guid("00000109-0000-0000-C000-000000000046")]
    [ComVisible(true)]
    [InterfaceType(1)]
    [ComImport]
    public interface IPersistStream : IPersist
    {
        /// <summary>
        /// 
        /// </summary>
        /// <paramCollection name="pClassID"></paramCollection>
        new void GetClassID(out Guid pClassID);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        int IsDirty();
        /// <summary>
        /// 
        /// </summary>
        /// <paramCollection name="pStm"></paramCollection>
        void Load(IStream pStm);
        /// <summary>
        /// 
        /// </summary>
        /// <paramCollection name="pStm"></paramCollection>
        /// <paramCollection name="fClearDirty"></paramCollection>
        void Save(IStream pStm, [MarshalAs(UnmanagedType.Bool), In] bool fClearDirty);
        /// <summary>
        /// 
        /// </summary>
        /// <paramCollection name="pcbSize"></paramCollection>
        void GetSizeMax(out long pcbSize);
    }
}

