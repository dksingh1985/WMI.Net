using System;
using System.Collections.Generic;
using System.Text;

namespace WMI.Net.Model
{
    internal class Win32_Process
    {
        string CreationClassName;
        string Caption;
        string CommandLine;
        DateTime CreationDate;
        string CSCreationClassName;
        string CSName;
        string Description;
        string ExecutablePath;
        ushort ExecutionState;
        string Handle;
        uint HandleCount;
        DateTime InstallDate;
        ulong KernelModeTime;
        uint MaximumWorkingSetSize;
        uint MinimumWorkingSetSize;
        string Name;
        string OSCreationClassName;
        string OSName;
        ulong OtherOperationCount;
        ulong OtherTransferCount;
        uint PageFaults;
        uint PageFileUsage;
        uint ParentProcessId;
        uint PeakPageFileUsage;
        ulong PeakVirtualSize;
        uint PeakWorkingSetSize;
        uint Priority;
        ulong PrivatePageCount;
        uint ProcessId;
        uint QuotaNonPagedPoolUsage;
        uint QuotaPagedPoolUsage;
        uint QuotaPeakNonPagedPoolUsage;
        uint QuotaPeakPagedPoolUsage;
        ulong ReadOperationCount;
        ulong ReadTransferCount;
        uint SessionId;
        string Status;
        DateTime TerminationDate;
        uint ThreadCount;
        ulong UserModeTime;
        ulong VirtualSize;
        string WindowsVersion;
        ulong WorkingSetSize;
        ulong WriteOperationCount;
        ulong WriteTransferCount;
    }
}
