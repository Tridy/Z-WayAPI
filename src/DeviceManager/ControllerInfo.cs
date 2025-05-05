namespace DeviceManager;

public class ControllerInfo
{
    public required Data data { get; set; }
}

public class Data
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
    public required Nodeid nodeId { get; set; }
    public required Homeid homeId { get; set; }
    public required Sucnodeid SUCNodeId { get; set; }
    public required Isprimary isPrimary { get; set; }
    public required Isinothersnetwork isInOthersNetwork { get; set; }
    public required Isrealprimary isRealPrimary { get; set; }
    public required Issuc isSUC { get; set; }
    public required Sispresent SISPresent { get; set; }
    public required Libtype libType { get; set; }
    public required SDK SDK { get; set; }
    public required Zwlibmajor ZWlibMajor { get; set; }
    public required Zwlibminor ZWlibMinor { get; set; }
    public required Zwlib ZWLib { get; set; }
    public required Zwversion ZWVersion { get; set; }
    public required Zwavechip ZWaveChip { get; set; }
    public required Apiversion APIVersion { get; set; }
    public required Apiversionmajor APIVersionMajor { get; set; }
    public required Apiversionminor APIVersionMinor { get; set; }
    public required Manufacturerid manufacturerId { get; set; }
    public required Vendor vendor { get; set; }
    public required Manufacturerproducttype manufacturerProductType { get; set; }
    public required Manufacturerproductid manufacturerProductId { get; set; }
    public required Capabilities capabilities { get; set; }
    public required Controllerstate controllerState { get; set; }
    public required Nonmanagmentjobs nonManagmentJobs { get; set; }
    public required Lastincludeddevice lastIncludedDevice { get; set; }
    public required Lastexcludeddevice lastExcludedDevice { get; set; }
    public required Secureinclusion secureInclusion { get; set; }
    public required Oldserialapiacktimeout10ms oldSerialAPIAckTimeout10ms { get; set; }
    public required Oldserialapibytetimeout10ms oldSerialAPIByteTimeout10ms { get; set; }
    public required Curserialapiacktimeout10ms curSerialAPIAckTimeout10ms { get; set; }
    public required Curserialapibytetimeout10ms curSerialAPIByteTimeout10ms { get; set; }
    public required Countjobs countJobs { get; set; }
    public required Memorygetaddress memoryGetAddress { get; set; }
    public required Memorygetdata memoryGetData { get; set; }
    public required Memorymanufacturerid memoryManufacturerId { get; set; }
    public required Memorytype memoryType { get; set; }
    public required Memorycapacity memoryCapacity { get; set; }
    public required Functionclasses functionClasses { get; set; }
    public required Functionclassesnames functionClassesNames { get; set; }
    public required Softwarerevisionversion softwareRevisionVersion { get; set; }
    public required Softwarerevisionid softwareRevisionId { get; set; }
    public required Softwarerevisiondate softwareRevisionDate { get; set; }
    public required Uuid uuid { get; set; }
    public required Hardware hardware { get; set; }
    public required Bootloader bootloader { get; set; }
    public required Firmware firmware { get; set; }
    public required Frequency frequency { get; set; }
    public required Devicerelaxdelay deviceRelaxDelay { get; set; }
    public required Pausesending pauseSending { get; set; }
    public required Promiscmode promiscMode { get; set; }
    public required Statistics statistics { get; set; }
    public required Homename homeName { get; set; }
    public required Homenotes homeNotes { get; set; }
    public required S2requirecsa S2RequireCSA { get; set; }
    public required Smartstart smartStart { get; set; }
    public required S2autoinclude S2AutoInclude { get; set; }
}

public class Nodeid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Homeid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Sucnodeid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Isprimary
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public bool value { get; set; }
}

public class Isinothersnetwork
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public bool value { get; set; }
}

public class Isrealprimary
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public bool value { get; set; }
}

public class Issuc
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public bool value { get; set; }
}

public class Sispresent
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public bool value { get; set; }
}

public class Libtype
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required string value { get; set; }
}

public class SDK
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required string value { get; set; }
}

public class Zwlibmajor
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Zwlibminor
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Zwlib
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Zwversion
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Zwavechip
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required string value { get; set; }
}

public class Apiversion
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required string value { get; set; }
}

public class Apiversionmajor
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Apiversionminor
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Manufacturerid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Vendor
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required string value { get; set; }
}

public class Manufacturerproducttype
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Manufacturerproductid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Capabilities
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required int[] value { get; set; }
}

public class Controllerstate
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Nonmanagmentjobs
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Lastincludeddevice
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Lastexcludeddevice
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Secureinclusion
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Oldserialapiacktimeout10ms
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Oldserialapibytetimeout10ms
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Curserialapiacktimeout10ms
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Curserialapibytetimeout10ms
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Countjobs
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public bool value { get; set; }
}

public class Memorygetaddress
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Memorygetdata
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required int[] value { get; set; }
}

public class Memorymanufacturerid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Memorytype
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Memorycapacity
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Functionclasses
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required int[] value { get; set; }
}

public class Functionclassesnames
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required string[] value { get; set; }
}

public class Softwarerevisionversion
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required string value { get; set; }
}

public class Softwarerevisionid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required string value { get; set; }
}

public class Softwarerevisiondate
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required string value { get; set; }
}

public class Uuid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required string value { get; set; }
}

public class Hardware
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
    public required Programmerid programmerId { get; set; }
    public required Productionseq productionSeq { get; set; }
    public required Uartspeed uartSpeed { get; set; }
}

public class Programmerid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Productionseq
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Uartspeed
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Bootloader
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
    public required Version version { get; set; }
    public required Crc crc { get; set; }
}

public class Version
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Crc
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Firmware
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
    public required Version1 version { get; set; }
    public required Build build { get; set; }
    public required Crc1 crc { get; set; }
    public required Caps caps { get; set; }
}

public class Version1
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Build
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Crc1
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Caps
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required int[] value { get; set; }
    public required Maxnodes maxNodes { get; set; }
    public required Staticapi staticApi { get; set; }
    public required Maxpower maxPower { get; set; }
    public required Backup backup { get; set; }
    public required Wup wup { get; set; }
    public required Advancedima advancedIMA { get; set; }
    public required Longrange longRange { get; set; }
    public required Ultrauart ultraUART { get; set; }
    public required Swapsubvendor swapSubvendor { get; set; }
    public required Promisc promisc { get; set; }
    public required Zniffer zniffer { get; set; }
    public required Jammingdetection jammingDetection { get; set; }
}

public class Maxnodes
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Staticapi
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Maxpower
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Backup
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Wup
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Advancedima
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Longrange
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Ultrauart
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Swapsubvendor
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Promisc
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Zniffer
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Jammingdetection
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Frequency
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required string value { get; set; }
}

public class Devicerelaxdelay
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Pausesending
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Promiscmode
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public bool value { get; set; }
}

public class Statistics
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
    public required Backgroundrssi backgroundRSSI { get; set; }
    public required Rftxframes RFTxFrames { get; set; }
    public required Rftxlbtbackoffs RFTxLBTBackOffs { get; set; }
    public required Rfrxframes RFRxFrames { get; set; }
    public required Rfrxlrcerrors RFRxLRCErrors { get; set; }
    public required Rfrxcrc16errors RFRxCRC16Errors { get; set; }
    public required Rfrxforeignhomeid RFRxForeignHomeID { get; set; }
    public required Priorityroute priorityRoute { get; set; }
    public required Jammingdetection1 jammingDetection { get; set; }
}

public class Backgroundrssi
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
    public required Channel1 channel1 { get; set; }
    public required Channel2 channel2 { get; set; }
    public required Channel3 channel3 { get; set; }
}

public class Channel1
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Channel2
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Channel3
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Rftxframes
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Rftxlbtbackoffs
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Rfrxframes
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Rfrxlrcerrors
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Rfrxcrc16errors
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Rfrxforeignhomeid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Priorityroute
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
    public required Dstnodeid dstNodeId { get; set; }
    public required Routetype routeType { get; set; }
    public required Speed speed { get; set; }
    public required Hops hops { get; set; }
}

public class Dstnodeid
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Routetype
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Speed
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Hops
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Jammingdetection1
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
    public required Ch1threshold ch1Threshold { get; set; }
    public required Ch2threshold ch2Threshold { get; set; }
    public required Ch3threshold ch3Threshold { get; set; }
    public required Detected detected { get; set; }
}

public class Ch1threshold
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Ch2threshold
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Ch3threshold
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Detected
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public int value { get; set; }
}

public class Homename
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Homenotes
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class S2requirecsa
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public bool value { get; set; }
}

public class Smartstart
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
    public required Requestfrom requestFrom { get; set; }
    public required Dskprovisioninglist dskProvisioningList { get; set; }
    public required Includingdsk includingDSK { get; set; }
}

public class Requestfrom
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Dskprovisioninglist
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Includingdsk
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class S2autoinclude
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
    public required Pin pin { get; set; }
    public required Keys keys { get; set; }
}

public class Pin
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

public class Keys
{
    public int invalidateTime { get; set; }
    public int updateTime { get; set; }
    public required string type { get; set; }
    public required object value { get; set; }
}

