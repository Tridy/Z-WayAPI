namespace DeviceManager;

public class ControllerInfo
{
    public Data data { get; set; }
}

public class Data
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
    public Nodeid nodeId { get; set; }
    public Homeid homeId { get; set; }
    public Sucnodeid SUCNodeId { get; set; }
    public Isprimary isPrimary { get; set; }
    public Isinothersnetwork isInOthersNetwork { get; set; }
    public Isrealprimary isRealPrimary { get; set; }
    public Issuc isSUC { get; set; }
    public Sispresent SISPresent { get; set; }
    public Libtype libType { get; set; }
    public SDK SDK { get; set; }
    public Zwlibmajor ZWlibMajor { get; set; }
    public Zwlibminor ZWlibMinor { get; set; }
    public Zwlib ZWLib { get; set; }
    public Zwversion ZWVersion { get; set; }
    public Zwavechip ZWaveChip { get; set; }
    public Apiversion APIVersion { get; set; }
    public Apiversionmajor APIVersionMajor { get; set; }
    public Apiversionminor APIVersionMinor { get; set; }
    public Manufacturerid manufacturerId { get; set; }
    public Vendor vendor { get; set; }
    public Manufacturerproducttype manufacturerProductType { get; set; }
    public Manufacturerproductid manufacturerProductId { get; set; }
    public Capabilities capabilities { get; set; }
    public Controllerstate controllerState { get; set; }
    public Nonmanagmentjobs nonManagmentJobs { get; set; }
    public Lastincludeddevice lastIncludedDevice { get; set; }
    public Lastexcludeddevice lastExcludedDevice { get; set; }
    public Secureinclusion secureInclusion { get; set; }
    public Oldserialapiacktimeout10ms oldSerialAPIAckTimeout10ms { get; set; }
    public Oldserialapibytetimeout10ms oldSerialAPIByteTimeout10ms { get; set; }
    public Curserialapiacktimeout10ms curSerialAPIAckTimeout10ms { get; set; }
    public Curserialapibytetimeout10ms curSerialAPIByteTimeout10ms { get; set; }
    public Countjobs countJobs { get; set; }
    public Memorygetaddress memoryGetAddress { get; set; }
    public Memorygetdata memoryGetData { get; set; }
    public Memorymanufacturerid memoryManufacturerId { get; set; }
    public Memorytype memoryType { get; set; }
    public Memorycapacity memoryCapacity { get; set; }
    public Functionclasses functionClasses { get; set; }
    public Functionclassesnames functionClassesNames { get; set; }
    public Softwarerevisionversion softwareRevisionVersion { get; set; }
    public Softwarerevisionid softwareRevisionId { get; set; }
    public Softwarerevisiondate softwareRevisionDate { get; set; }
    public Uuid uuid { get; set; }
    public Hardware hardware { get; set; }
    public Bootloader bootloader { get; set; }
    public Firmware firmware { get; set; }
    public Frequency frequency { get; set; }
    public Devicerelaxdelay deviceRelaxDelay { get; set; }
    public Pausesending pauseSending { get; set; }
    public Promiscmode promiscMode { get; set; }
    public Statistics statistics { get; set; }
    public Homename homeName { get; set; }
    public Homenotes homeNotes { get; set; }
    public S2requirecsa S2RequireCSA { get; set; }
    public Smartstart smartStart { get; set; }
    public S2autoinclude S2AutoInclude { get; set; }
}

public class Nodeid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Homeid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Sucnodeid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Isprimary
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public bool value { get; set; }
}

public class Isinothersnetwork
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public bool value { get; set; }
}

public class Isrealprimary
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public bool value { get; set; }
}

public class Issuc
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public bool value { get; set; }
}

public class Sispresent
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public bool value { get; set; }
}

public class Libtype
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public string value { get; set; }
}

public class SDK
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public string value { get; set; }
}

public class Zwlibmajor
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Zwlibminor
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Zwlib
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Zwversion
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Zwavechip
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public string value { get; set; }
}

public class Apiversion
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public string value { get; set; }
}

public class Apiversionmajor
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Apiversionminor
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Manufacturerid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Vendor
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public string value { get; set; }
}

public class Manufacturerproducttype
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Manufacturerproductid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Capabilities
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int[] value { get; set; }
}

public class Controllerstate
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Nonmanagmentjobs
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Lastincludeddevice
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Lastexcludeddevice
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Secureinclusion
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Oldserialapiacktimeout10ms
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Oldserialapibytetimeout10ms
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Curserialapiacktimeout10ms
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Curserialapibytetimeout10ms
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Countjobs
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public bool value { get; set; }
}

public class Memorygetaddress
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Memorygetdata
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int[] value { get; set; }
}

public class Memorymanufacturerid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Memorytype
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Memorycapacity
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Functionclasses
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int[] value { get; set; }
}

public class Functionclassesnames
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public string[] value { get; set; }
}

public class Softwarerevisionversion
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public string value { get; set; }
}

public class Softwarerevisionid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public string value { get; set; }
}

public class Softwarerevisiondate
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public string value { get; set; }
}

public class Uuid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public string value { get; set; }
}

public class Hardware
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
    public Programmerid programmerId { get; set; }
    public Productionseq productionSeq { get; set; }
    public Uartspeed uartSpeed { get; set; }
}

public class Programmerid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Productionseq
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Uartspeed
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Bootloader
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
    public Version version { get; set; }
    public Crc crc { get; set; }
}

public class Version
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Crc
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Firmware
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
    public Version1 version { get; set; }
    public Build build { get; set; }
    public Crc1 crc { get; set; }
    public Caps caps { get; set; }
}

public class Version1
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Build
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Crc1
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Caps
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int[] value { get; set; }
    public Maxnodes maxNodes { get; set; }
    public Staticapi staticApi { get; set; }
    public Maxpower maxPower { get; set; }
    public Backup backup { get; set; }
    public Wup wup { get; set; }
    public Advancedima advancedIMA { get; set; }
    public Longrange longRange { get; set; }
    public Ultrauart ultraUART { get; set; }
    public Swapsubvendor swapSubvendor { get; set; }
    public Promisc promisc { get; set; }
    public Zniffer zniffer { get; set; }
    public Jammingdetection jammingDetection { get; set; }
}

public class Maxnodes
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Staticapi
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Maxpower
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Backup
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Wup
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Advancedima
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Longrange
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Ultrauart
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Swapsubvendor
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Promisc
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Zniffer
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Jammingdetection
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Frequency
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public string value { get; set; }
}

public class Devicerelaxdelay
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Pausesending
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Promiscmode
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public bool value { get; set; }
}

public class Statistics
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
    public Backgroundrssi backgroundRSSI { get; set; }
    public Rftxframes RFTxFrames { get; set; }
    public Rftxlbtbackoffs RFTxLBTBackOffs { get; set; }
    public Rfrxframes RFRxFrames { get; set; }
    public Rfrxlrcerrors RFRxLRCErrors { get; set; }
    public Rfrxcrc16errors RFRxCRC16Errors { get; set; }
    public Rfrxforeignhomeid RFRxForeignHomeID { get; set; }
    public Priorityroute priorityRoute { get; set; }
    public Jammingdetection1 jammingDetection { get; set; }
}

public class Backgroundrssi
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
    public Channel1 channel1 { get; set; }
    public Channel2 channel2 { get; set; }
    public Channel3 channel3 { get; set; }
}

public class Channel1
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Channel2
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Channel3
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Rftxframes
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Rftxlbtbackoffs
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Rfrxframes
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Rfrxlrcerrors
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Rfrxcrc16errors
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Rfrxforeignhomeid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Priorityroute
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
    public Dstnodeid dstNodeId { get; set; }
    public Routetype routeType { get; set; }
    public Speed speed { get; set; }
    public Hops hops { get; set; }
}

public class Dstnodeid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Routetype
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Speed
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Hops
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Jammingdetection1
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
    public Ch1threshold ch1Threshold { get; set; }
    public Ch2threshold ch2Threshold { get; set; }
    public Ch3threshold ch3Threshold { get; set; }
    public Detected detected { get; set; }
}

public class Ch1threshold
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Ch2threshold
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Ch3threshold
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Detected
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Homename
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Homenotes
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class S2requirecsa
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public bool value { get; set; }
}

public class Smartstart
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
    public Requestfrom requestFrom { get; set; }
    public Dskprovisioninglist dskProvisioningList { get; set; }
    public Includingdsk includingDSK { get; set; }
}

public class Requestfrom
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Dskprovisioninglist
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Includingdsk
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class S2autoinclude
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
    public Pin pin { get; set; }
    public Keys keys { get; set; }
}

public class Pin
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

public class Keys
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public string type { get; set; }
    public object value { get; set; }
}

