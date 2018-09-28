



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace uFrAdvance
{
    using DL_STATUS = System.UInt32;

    public enum UFR_STATUS
    {
        UFR_OK = 0x00,

        UFR_COMMUNICATION_ERROR = 0x01,
        UFR_CHKSUM_ERROR = 0x02,
        UFR_READING_ERROR = 0x03,
        UFR_WRITING_ERROR = 0x04,
        UFR_BUFFER_OVERFLOW = 0x05,
        UFR_MAX_ADDRESS_EXCEEDED = 0x06,
        UFR_MAX_KEY_INDEX_EXCEEDED = 0x07,
        UFR_NO_CARD = 0x08,
        UFR_COMMAND_NOT_SUPPORTED = 0x09,
        UFR_FORBIDEN_DIRECT_WRITE_IN_SECTOR_TRAILER = 0x0A,
        UFR_ADDRESSED_BLOCK_IS_NOT_SECTOR_TRAILER = 0x0B,
        UFR_WRONG_ADDRESS_MODE = 0x0C,
        UFR_WRONG_ACCESS_BITS_VALUES = 0x0D,
        UFR_AUTH_ERROR = 0x0E,
        UFR_PARAMETERS_ERROR = 0x0F,
        UFR_MAX_SIZE_EXCEEDED = 0x10,
        UFR_UNSUPPORTED_CARD_TYPE,

        UFR_WRITE_VERIFICATION_ERROR = 0x70,
        UFR_BUFFER_SIZE_EXCEEDED = 0x71,
        UFR_VALUE_BLOCK_INVALID = 0x72,
        UFR_VALUE_BLOCK_ADDR_INVALID = 0x73,
        UFR_VALUE_BLOCK_MANIPULATION_ERROR = 0x74,
        UFR_WRONG_UI_MODE = 0x75,
        UFR_KEYS_LOCKED = 0x76,
        UFR_KEYS_UNLOCKED = 0x77,
        UFR_WRONG_PASSWORD = 0x78,
        UFR_CAN_NOT_LOCK_DEVICE = 0x79,
        UFR_CAN_NOT_UNLOCK_DEVICE = 0x7A,
        UFR_DEVICE_EEPROM_BUSY = 0x7B,
        UFR_RTC_SET_ERROR = 0x7C,
        UFR_TAG_UNKNOWN = 0x7D,

        UFR_COMMUNICATION_BREAK = 0x50,
        UFR_NO_MEMORY_ERROR = 0x51,
        UFR_CAN_NOT_OPEN_READER = 0x52,
        UFR_READER_NOT_SUPPORTED = 0x53,
        UFR_READER_OPENING_ERROR = 0x54,
        UFR_READER_PORT_NOT_OPENED = 0x55,
        UFR_CANT_CLOSE_READER_PORT = 0x56,

        UFR_TIMEOUT_ERR = 0x90,

        UFR_FT_STATUS_ERROR_1 = 0xA0,
        UFR_FT_STATUS_ERROR_2 = 0xA1,
        UFR_FT_STATUS_ERROR_3 = 0xA2,
        UFR_FT_STATUS_ERROR_4 = 0xA3,
        UFR_FT_STATUS_ERROR_5 = 0xA4,
        UFR_FT_STATUS_ERROR_6 = 0xA5,
        UFR_FT_STATUS_ERROR_7 = 0xA6,
        UFR_FT_STATUS_ERROR_8 = 0xA7,
        UFR_FT_STATUS_ERROR_9 = 0xA8,

        //NDEF error codes
        UFR_WRONG_NDEF_CARD_FORMAT = 0x80,
        UFR_NDEF_MESSAGE_NOT_FOUND = 0x81,
        UFR_NDEF_UNSUPPORTED_CARD_TYPE = 0x82,
        UFR_NDEF_CARD_FORMAT_ERROR = 0x83,
        UFR_MAD_NOT_ENABLED = 0x84,
        UFR_MAD_VERSION_NOT_SUPPORTED = 0x85,

        // multiple units - return from the functions with ReaderList_ prefix in name
        UFR_DEVICE_WRONG_HANDLE = 0x100,
        UFR_DEVICE_INDEX_OUT_OF_BOUND,
        UFR_DEVICE_ALREADY_OPENED,
        UFR_DEVICE_ALREADY_CLOSED,
        UFR_DEVICE_IS_NOT_CONNECTED,

        // Originality Check Error Codes:
        UFR_NOT_NXP_GENUINE = 0x200,
        UFR_OPEN_SSL_DYNAMIC_LIB_FAILED,
        UFR_OPEN_SSL_DYNAMIC_LIB_NOT_FOUND,

        UFR_NOT_IMPLEMENTED = 0x1000,
        UFR_COMMAND_FAILED,

        MAX_UFR_STATUS = 10000000,
        UNKNOWN_ERROR = 2147483647 // 0x7FFFFFFF
    };

    public enum ERRORCODES
    {

        DL_OK                                   = 0x00,
        COMMUNICATION_ERROR                     = 0x01,
        CHKSUM_ERROR                            = 0x02,
        READING_ERROR                           = 0x03,
        WRITING_ERROR                           = 0x04,
        BUFFER_OVERFLOW                         = 0x05,
        MAX_ADDRESS_EXCEEDED                    = 0x06,
        MAX_KEY_INDEX_EXCEEDED                  = 0x07,
        NO_CARD                                 = 0x08,
        COMMAND_NOT_SUPPORTED                   = 0x09,
        FORBIDEN_DIRECT_WRITE_IN_SECTOR_TRAILER = 0x0A,
        ADDRESSED_BLOCK_IS_NOT_SECTOR_TRAILER   = 0x0B,
        WRONG_ADDRESS_MODE                      = 0x0C,
        WRONG_ACCESS_BITS_VALUES                = 0x0D,
        AUTH_ERROR                              = 0x0E,
        PARAMETERS_ERROR                        = 0x0F,
        MAX_SIZE_EXCEEDED                       = 0x10,
        UNSUPPORTED_CARD_TYPE                   = 0x11,

        COMMUNICATION_BREAK                     = 0x50,
        NO_MEMORY_ERROR                         = 0x51,
        CAN_NOT_OPEN_READER                     = 0x52,
        READER_NOT_SUPPORTED                    = 0x53,
        READER_OPENING_ERROR                    = 0x54,
        READER_PORT_NOT_OPENED                  = 0x55,
        CANT_CLOSE_READER_PORT                  = 0x56,

        WRITE_VERIFICATION_ERROR                = 0x70,
        BUFFER_SIZE_EXCEEDED                    = 0x71,
        VALUE_BLOCK_INVALID                     = 0x72,
        VALUE_BLOCK_ADDR_INVALID                = 0x73,
        VALUE_BLOCK_MANIPULATION_ERROR          = 0x74,
        WRONG_UI_MODE                           = 0x75,
        KEYS_LOCKED                             = 0x76,
        KEYS_UNLOCKED                           = 0x77,
        WRONG_PASSWORD                          = 0x78,
        CAN_NOT_LOCK_DEVICE                     = 0x79,
        CAN_NOT_UNLOCK_DEVICE                   = 0x7A,
        DEVICE_EEPROM_BUSY                      = 0x7B,
        RTC_SET_ERROR                           = 0x7C,
        ANTICOLLISION_DISABLED                  = 0x7D,
        NO_CARDS_ENUMERRATED                    = 0x7E,
        CARD_ALREADY_SELECTED                   = 0x7F,

        FT_STATUS_ERROR_1                       = 0xA0,
        FT_STATUS_ERROR_2                       = 0xA1,
        FT_STATUS_ERROR_3                       = 0xA2,
        FT_STATUS_ERROR_4                       = 0xA3,
        FT_STATUS_ERROR_5                       = 0xA4,
        FT_STATUS_ERROR_6                       = 0xA5,
        FT_STATUS_ERROR_7                       = 0xA6,
        FT_STATUS_ERROR_8                       = 0xA7,
        FT_STATUS_ERROR_9                       = 0xA8

    }
    
       
    unsafe class  uFCoder
    {

#if WIN64
        const string DLL_PATH = "..\\..\\ufr-lib\\windows\\x86_64\\";
        const string NAME_DLL = "uFCoder-x86_64.dll";

#else
        const string DLL_PATH = "..\\..\\ufr-lib\\windows\\x86\\";
        const string NAME_DLL = "uFCoder-x86.dll";
#endif
        const string DLL_NAME = DLL_PATH + NAME_DLL;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto,EntryPoint="ReaderOpen" )]
        public static extern DL_STATUS ReaderOpen();

        [DllImport( DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto,EntryPoint="ReaderClose")]
        public static extern DL_STATUS ReaderClose ();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ReaderReset")]
        public static extern DL_STATUS ReaderReset();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ReaderSoftRestart")]
        public static extern DL_STATUS ReaderSoftRestart();

        [DllImport( DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto,EntryPoint="GetReaderType" )]
        public static  extern DL_STATUS GetReaderType (ulong* get_reader_type);

         [DllImport( DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto,EntryPoint="ReaderKeyWrite" )]
       public static extern DL_STATUS ReaderKeyWrite(byte* aucKey, byte ucKeyIndex);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "GetReaderSerialNumber")]
        public  static extern DL_STATUS GetReaderSerialNumber (ulong* serial_number);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "GetCardId")]
        public static extern DL_STATUS GetCardId(byte* card_type, ulong* card_serial);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "GetCardIdEx")]
        public static extern DL_STATUS GetCardIdEx(byte* bCardType,
                                                   byte[] bCardUid,
                                                   byte* bUidSize);


        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "GetDlogicCardType")]
        public static extern DL_STATUS GetDlogicCardType(byte* bCardType);



        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ReaderUISignal")]
        public static extern DL_STATUS ReaderUISignal(int light_mode, int sound_mode);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ReadUserData")]
        public static extern DL_STATUS ReadUserData(byte* aucData);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "WriteUserData")]
        public static extern DL_STATUS  WriteUserData(byte* aucData);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "GetReaderHardwareVersion")]
        public static extern DL_STATUS GetReaderHardwareVersion(byte* bVerMajor,
                                                                byte* bVerMinor);
         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "GetReaderFirmwareVersion")]        
        public static extern DL_STATUS GetReaderFirmwareVersion(byte* bVerMajor,
                                                                byte* bVerMinor);



        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "LinearRead")]
        public static extern DL_STATUS LinearRead(byte[] aucData,
                                                  ushort linear_address,
                                                  ushort data_len,
                                                  ushort* bytes_written,
                                                  byte auth_mode,
                                                  byte key_index);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "LinearRead_AKM1")]
        public static extern DL_STATUS LinearRead_AKM1(byte* aucData,
                                                   ushort linear_address,
                                                   ushort data_len,
                                                   ushort* bytes_written,
                                                   byte key_mode);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "LinearRead_AKM2")]
        public static extern DL_STATUS LinearRead_AKM2(byte* aucData,
                                                   ushort linear_address,
                                                   ushort data_len,
                                                   ushort* bytes_written,
                                                   byte key_mode);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "LinearRead_PK")]
        public static extern DL_STATUS LinearRead_PK(byte[] aucData,
                                                   ushort linear_address,
                                                   ushort data_len,
                                                   ushort* bytes_written,
                                                   byte key_mode,
                                                   byte[] pk_key);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "LinearWrite")]
        public static extern DL_STATUS LinearWrite (byte[] aucData,
                                                    ushort linear_address,
                                                    ushort data_len,
                                                    ushort* bytes_written,
                                                    byte auth_mode, 
                                                    byte key_index);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "LinearWrite_AKM1")]
        public static extern DL_STATUS LinearWrite_AKM1(byte* aucData,
                                                    ushort linear_address,
                                                    ushort data_len,
                                                    ushort* bytes_written,
                                                    byte auth_mode);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "LinearWrite_AKM2")]
        public static extern DL_STATUS LinearWrite_AKM2(byte* aucData,
                                                    ushort linear_address,
                                                    ushort data_len,
                                                    ushort* bytes_written,
                                                    byte auth_mode);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "LinearWrite_PK")]
        public static extern DL_STATUS LinearWrite_PK(byte[] aucData,
                                                   ushort linear_address,
                                                   ushort data_len,
                                                   ushort* bytes_written,
                                                   byte key_mode,
                                                   byte[] pk_key);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "BlockRead")]
        public static extern DL_STATUS  BlockRead(byte[] data,
                                                  UInt16 block_address,
                                                  byte auth_mode,
                                                  byte key_index);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "BlockRead_AKM1")]
        public static extern DL_STATUS BlockRead_AKM1(byte* data,
                                                      UInt16 block_address,
                                                      byte auth_mode);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "BlockRead_AKM2")]
        public static extern DL_STATUS BlockRead_AKM2(byte* data,
                                                      UInt16 block_address,
                                                      byte auth_mode);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "BlockRead_PK")]
        public static extern DL_STATUS BlockRead_PK(byte[] data,
                                                    UInt16 block_address,
                                                    byte auth_mode,
                                                    byte[] pk_key);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "BlockWrite")]
        public static extern DL_STATUS BlockWrite(byte[] data,
                                                  UInt16 block_address,
                                                  byte auth_mode,
                                                  byte key_index);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "BlockWrite_AKM1")]
        public static extern DL_STATUS BlockWrite_AKM1(byte* data,
                                                       UInt16 block_address,
                                                       byte auth_mode);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "BlockWrite_AKM2")]
        public static extern DL_STATUS BlockWrite_AKM2(byte* data,
                                                       UInt16 block_address,
                                                       byte auth_mode);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "BlockWrite_PK")]
        public static extern DL_STATUS BlockWrite_PK(byte[] data,
                                                     UInt16 block_address,
                                                     byte auth_mode,
                                                     byte[] pk_key);



         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "BlockInSectorRead")]
          public static extern DL_STATUS BlockInSectorRead(byte* data,
                                                           byte sector_address,
                                                           byte block_in_sector_address,
                                                           byte auth_mode,byte key_index);


         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "BlockInSectorRead_AKM1")]
         public static extern DL_STATUS BlockInSectorRead_AKM1(byte* data,
                                                               byte sector_address,
                                                               byte block_in_sector_address,
                                                               byte auth_mode);


         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "BlockInSectorRead_AKM2")]
         public static extern DL_STATUS BlockInSectorRead_AKM2(byte* data,
                                                               byte sector_address,
                                                               byte block_in_sector_address,
                                                               byte auth_mode);

         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "BlockInSectorRead_PK")]
         public static extern DL_STATUS BlockInSectorRead_PK(byte* data,
                                                             byte sector_address,
                                                             byte block_in_sector_address,
                                                             byte auth_mode,
                                                             byte* pk_key);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "BlockInSectorWrite")]
        public static extern DL_STATUS BlockInSectorWrite(byte* data,
                                                          byte sector_address,
                                                          byte block_in_sector_address,
                                                          byte auth_mode,
                                                          byte key_index);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "BlockInSectorWrite_AKM1")]
        public static extern DL_STATUS BlockInSectorWrite_AKM1(byte* data,
                                                               byte sector_address,
                                                               byte block_in_sector_address,
                                                               byte auth_mode);


        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "BlockInSectorWrite_AKM2")]
        public static extern DL_STATUS BlockInSectorWrite_AKM2(byte* data,
                                                               byte sector_address,
                                                               byte block_in_sector_address,
                                                               byte auth_mode);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "BlockInSectorWrite_PK")]
        public static extern DL_STATUS BlockInSectorWrite_PK(byte* data,
                                                             byte sector_address,
                                                             byte block_in_sector_address,
                                                             byte auth_mode,
                                                             byte* pk_key);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockRead")]
        public static extern DL_STATUS   ValueBlockRead(int* value,
                                                        byte* value_addr,
                                                        UInt16 block_address,
                                                        byte auth_mode,
                                                        byte key_index);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockRead_AKM1")]
        public static extern DL_STATUS ValueBlockRead_AKM1(int* value,
                                                           byte* value_addr,
                                                           UInt16 block_address,
                                                           byte auth_mode);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockRead_AKM2")]
        public static extern DL_STATUS ValueBlockRead_AKM2(int* value,
                                                           byte* value_addr,
                                                           UInt16 block_address,
                                                           byte auth_mode);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockRead_PK")]
        public static extern DL_STATUS ValueBlockRead_PK(int* value,
                                                         byte* value_addr,
                                                         UInt16 block_address,
                                                         byte auth_mode,
                                                         byte* pk_key);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockWrite")]
        public static extern DL_STATUS ValueBlockWrite( int value,
                                                        byte value_addr,
                                                        UInt16 block_address,
                                                        byte auth_mode,
                                                        byte key_index);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockWrite_AKM1")]
        public static extern DL_STATUS ValueBlockWrite_AKM1(int value,
                                                        byte value_addr,
                                                        UInt16 block_address,
                                                        byte auth_mode);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockWrite_AKM2")]
        public static extern DL_STATUS ValueBlockWrite_AKM2(int value,
                                                        byte value_addr,
                                                        UInt16 block_address,
                                                        byte auth_mode);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockWrite_PK")]
        public static extern DL_STATUS ValueBlockWrite_PK(int value,
                                                        byte value_addr,
                                                        UInt16 block_address,
                                                        byte auth_mode,
                                                        byte* pk_key);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockIncrement")]
        public static extern DL_STATUS  ValueBlockIncrement(int increment_value,
                                                            UInt16 block_address,
                                                            byte auth_mode,
                                                            byte key_index);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockIncrement_AKM1")]
        public static extern DL_STATUS ValueBlockIncrement_AKM1(int increment_value,
                                                                UInt16 block_address,
                                                                byte auth_mode);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockIncrement_AKM2")]
        public static extern DL_STATUS ValueBlockIncrement_AKM2(int increment_value,
                                                                UInt16 block_address,
                                                                byte auth_mode);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockIncrement_PK")]
        public static extern DL_STATUS ValueBlockIncrement_PK(int increment_value,
                                                                UInt16 block_address,
                                                                byte auth_mode,
                                                                byte* pk_key);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockDecrement")]
        public static extern DL_STATUS ValueBlockDecrement(int increment_value,
                                                           UInt16 block_address,
                                                           byte auth_mode,
                                                             byte key_index);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockDecrement_AKM1")]
        public static extern DL_STATUS ValueBlockDecrement_AKM1(int increment_value,
                                                                UInt16 block_address,
                                                                byte auth_mode);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockDecrement_AKM2")]
        public static extern DL_STATUS ValueBlockDecrement_AKM2(int increment_value,
                                                                UInt16 block_address,
                                                                byte auth_mode);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockDecrement_PK")]
        public static extern DL_STATUS ValueBlockDecrement_PK(int increment_value,
                                                              UInt16 block_address,
                                                              byte auth_mode,
                                                              byte* pk_key);
        
         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockInSectorRead")]
         public static extern   DL_STATUS  ValueBlockInSectorRead(Int32 *value,
                                                                  byte* value_addr,
                                                                  byte sector_address,
                                                                  byte block_in_sector_address,
                                                                  byte auth_mode,
                                                                  byte key_index);

         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockInSectorRead_AKM1")]
         public static extern DL_STATUS ValueBlockInSectorRead_AKM1(Int32* value,
                                                                  byte* value_addr,
                                                                  byte sector_address,
                                                                  byte block_in_sector_address,
                                                                  byte auth_mode);


         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockInSectorRead_AKM2")]
         public static extern DL_STATUS ValueBlockInSectorRead_AKM2(Int32* value,
                                                                  byte* value_addr,
                                                                  byte sector_address,
                                                                  byte block_in_sector_address,
                                                                  byte auth_mode);

         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockInSectorRead_PK")]
         public static extern DL_STATUS ValueBlockInSectorRead_PK(Int32* value,
                                                                  byte* value_addr,
                                                                  byte sector_address,
                                                                  byte block_in_sector_address,
                                                                  byte auth_mode,
                                                                  byte* pk_key);

         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockInSectorWrite")]
         public static extern DL_STATUS ValueBlockInSectorWrite(Int32 value,
                                                                byte value_addr,            
                                                                byte sector_address,
                                                                byte block_in_sector_address,
                                                                byte auth_mode,byte key_index);

         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockInSectorWrite_AKM1")]
         public static extern DL_STATUS ValueBlockInSectorWrite_AKM1(Int32 value,
                                                                byte value_addr,
                                                                byte sector_address,
                                                                byte block_in_sector_address,
                                                                byte auth_mode);

         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockInSectorWrite_AKM2")]
         public static extern DL_STATUS ValueBlockInSectorWrite_AKM2(Int32 value,
                                                                byte value_addr,
                                                                byte sector_address,
                                                                byte block_in_sector_address,
                                                                byte auth_mode);

         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockInSectorWrite_PK")]
         public static extern DL_STATUS ValueBlockInSectorWrite_PK(Int32 value,
                                                                byte value_addr,
                                                                byte sector_address,
                                                                byte block_in_sector_address,
                                                                byte auth_mode,
                                                                byte* pk_key); 

          [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockInSectorIncrement")]
          public static extern DL_STATUS  ValueBlockInSectorIncrement(Int32 increment_value,
                                                                      byte sector_address,          
                                                                      byte block_in_sector_address,           
                                                                      byte auth_mode,
                                                                      byte key_index);

          [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockInSectorIncrement_AKM1")]
          public static extern DL_STATUS ValueBlockInSectorIncrement_AKM1(Int32 increment_value,
                                                                      byte sector_address,
                                                                      byte block_in_sector_address,
                                                                      byte auth_mode);

          [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockInSectorIncrement_AKM2")]
          public static extern DL_STATUS ValueBlockInSectorIncrement_AKM2(Int32 increment_value,
                                                                      byte sector_address,
                                                                      byte block_in_sector_address,
                                                                      byte auth_mode);


          [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockInSectorIncrement_PK")]
          public static extern DL_STATUS ValueBlockInSectorIncrement_PK(Int32 increment_value,
                                                                      byte sector_address,
                                                                      byte block_in_sector_address,
                                                                      byte auth_mode,
                                                                      byte* pk_key);

         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockInSectorDecrement")]
          public static extern DL_STATUS  ValueBlockInSectorDecrement(Int32 decrement_value,
                                                                      byte sector_address,
                                                                      byte block_in_sector_address,
                                                                      byte auth_mode,
                                                                      byte key_index);

         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockInSectorDecrement_AKM1")]
         public static extern DL_STATUS ValueBlockInSectorDecrement_AKM1(Int32 decrement_value,
                                                                     byte sector_address,
                                                                     byte block_in_sector_address,
                                                                     byte auth_mode);


         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockInSectorDecrement_AKM2")]
         public static extern DL_STATUS ValueBlockInSectorDecrement_AKM2(Int32 decrement_value,
                                                                     byte sector_address,
                                                                     byte block_in_sector_address,
                                                                     byte auth_mode);


         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ValueBlockInSectorDecrement_PK")]
         public static extern DL_STATUS ValueBlockInSectorDecrement_PK(Int32 decrement_value,
                                                                     byte sector_address,
                                                                     byte block_in_sector_address,
                                                                     byte auth_mode,
                                                                     byte* pk_key);

         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "SectorTrailerWrite")]
         public static extern DL_STATUS SectorTrailerWrite(byte addressing_mode,
                                         byte address,
                                         byte* new_key_A,
                                         byte block0_access_bits,
                                         byte block1_access_bits,
                                         byte block2_access_bits,
                                         byte sector_trailer_access_bits,
                                         byte sector_trailer_byte9,
                                         byte* new_key_B,
                                         byte auth_mode,
                                         byte key_index);

         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "SectorTrailerWrite_AKM1")]
         public static extern DL_STATUS SectorTrailerWrite_AKM1(byte addressing_mode,
                                         byte address,
                                         byte* new_key_A,
                                         byte block0_access_bits,
                                         byte block1_access_bits,
                                         byte block2_access_bits,
                                         byte sector_trailer_access_bits,
                                         byte sector_trailer_byte9,
                                         byte* new_key_B,
                                         byte auth_mode);

         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "SectorTrailerWrite_AKM2")]
         public static extern DL_STATUS SectorTrailerWrite_AKM2(byte addressing_mode,
                                         byte address,
                                         byte* new_key_A,
                                         byte block0_access_bits,
                                         byte block1_access_bits,
                                         byte block2_access_bits,
                                         byte sector_trailer_access_bits,
                                         byte sector_trailer_byte9,
                                         byte* new_key_B,
                                         byte auth_mode);

         [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "SectorTrailerWrite_PK")]
         public static extern DL_STATUS SectorTrailerWrite_PK(byte addressing_mode,
                                         byte address,
                                         byte* new_key_A,
                                         byte block0_access_bits,
                                         byte block1_access_bits,
                                         byte block2_access_bits,
                                         byte sector_trailer_access_bits,
                                         byte sector_trailer_byte9,
                                         byte* new_key_B,
                                         byte auth_mode,
                                         byte* pk_key);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "LinearFormatCard")]
       public static extern DL_STATUS  LinearFormatCard(byte* new_key_A,
                                                        byte blocks_access_bits,
                                                        byte sector_trailers_access_bits,
                                                        byte sector_trailers_byte9,
                                                        byte* new_key_B,
                                                        byte* sectors_formatted,
                                                        byte auth_mode,
                                                        byte key_index);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "LinearFormatCard_AKM1")]
        public static extern DL_STATUS LinearFormatCard_AKM1(byte* new_key_A,
                                                         byte blocks_access_bits,
                                                         byte sector_trailers_access_bits,
                                                         byte sector_trailers_byte9,
                                                         byte* new_key_B,
                                                         byte* sectors_formatted,
                                                         byte auth_mode);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "LinearFormatCard_AKM2")]
        public static extern DL_STATUS LinearFormatCard_AKM2(byte* new_key_A,
                                                         byte blocks_access_bits,
                                                         byte sector_trailers_access_bits,
                                                         byte sector_trailers_byte9,
                                                         byte* new_key_B,
                                                         byte* sectors_formatted,
                                                         byte auth_mode);
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "LinearFormatCard_PK")]
        public static extern DL_STATUS LinearFormatCard_PK(byte* new_key_A,
                                                         byte blocks_access_bits,
                                                         byte sector_trailers_access_bits,
                                                         byte sector_trailers_byte9,
                                                         byte* new_key_B,
                                                         byte* sectors_formatted,
                                                         byte auth_mode,                                        
                                                         byte* pk_key);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "GetReaderSerialDescription")]
        public static extern DL_STATUS GetReaderSerialDescription(byte[] SerialDescription);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "GetBuildNumber")]
        public static extern DL_STATUS GetBuildNumber(byte* build);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "EnableAntiCollision")]
        public static extern DL_STATUS EnableAntiCollision();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "DisableAntiCollision")]
        public static extern DL_STATUS DisableAntiCollision();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "EnumCards")]
        public static extern DL_STATUS EnumCards(byte* lpucCardsNumber,
                                                 byte* lpucUidListSize);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ListCards")]
        public static extern DL_STATUS ListCards(byte[] aucUidList,
                                                 byte ucUidListSize);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "SelectCard")]
        public static extern DL_STATUS SelectCard(byte[] aucUid,
                                                  byte  ucUidSize,
                                                  byte* lpucSelectedCardType);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "GetAntiCollisionStatus")]
        public static extern DL_STATUS GetAntiCollisionStatus(char* lpIsAntiCollEnabled,
                                                              char* lpcIsAnyCardSelected);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "DeslectCard")]
        public static extern DL_STATUS DeselectCard();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall, EntryPoint = "UFR_Status2String")]
        private static extern IntPtr UFR_Status2String(DL_STATUS status);
        public static string status2str(DL_STATUS status)
        {
            IntPtr str_ret = UFR_Status2String(status);
            return Marshal.PtrToStringAnsi(str_ret);
        }
    }
}
