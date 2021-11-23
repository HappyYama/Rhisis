﻿//
// This file contains every packet headers from the FF MsgHdr.h
//

namespace Rhisis.Protocol
{
    public enum PacketType : uint
    {
        WELCOME = 0x0000000,
        MYREG = 0x00000001,
        PROCSERVER_LIST = 0x00000002,
        LOAD_WORLD = 0x00000003,
        RECHARGE_IDSTACK = 0x00000004,
        PASSAGE = 0x00000005,
        DUPLICATE = 0x00000006,
        UNIFY = 0x00000007,
        ID = 0x00000008,
        ADDID = 0x00000009,
        POLL = 0x0000000A,
        QUERYTICKCOUNT = 0x0000000B,
        ERROR_TEXT = 0x0000000D,
        PLAYERCOUNT = 0x0000000F,
        QUERYSETGUILDNAME = 0x00000010,
        AUTHQUERY = 0x00000011,
        QUERYSETPLAYERNAME = 0x00000012,
        CONN = 0x00000013,
        PING = 0x00000014,
        GET_CLOCK = 0x00000015,
        CLOSE_EXISTING_CONNECTION = 0x00000016,
        ONE_HOUR_NOTIFY = 0x00000017,
        KEEP_ALIVE = 0x00000018,
        RUNEQ = 0x00000019,
        QUERYPOSTMAIL = 0x0000001A,
        QUERYREMOVEMAIL = 0x0000001B,
        QUERYGETMAILITEM = 0x0000001C,
        QUERYMAILBOX = 0x0000001D,
        ALLMAIL = 0x0000001E, // Not implemented in official files
        QUERYGETMAILGOLD = 0x0000001F,
        READMAIL = 0x00000024,
        DO_ESCAPE = 0x00000020,
        SETSNOOP = 0x00000021,
        SETSNOOPGUILD = 0x00000022,
        SNOOP = 0x00000023,
        CREATEMONSTER = 0x0000002A,
        QUERY_DESTROY_PLAYER = 0x00000030,
        NEW_ACCOUNT = 0x000000F0,
        DEL_ACCOUNT = 0x000000F1,
        CACHE_ADDR = 0x000000F2,
        PLAYER_LIST = 0x000000F3,
        CREATE_PLAYER = 0x000000F4,
        DEL_PLAYER = 0x000000F5,
        GETPLAYERLIST = 0x000000F6,
        SEL_PLAYER = 0x000000F7,
        SAVE_PLAYER = 0x000000F8,
        GT = 0x000000F9,
        ALLPLAYERID = 0x000000FA,
        BUSY = 0x000000FB,
        CERTIFY = 0x000000FC,
        SRVR_LIST = 0x000000FD,
        ERROR = 0x000000FE,
        PLAYERID = 0x000000FF,
        REMOVEPLAYERID = 0x00000FF2,
        PLAYER_COUNT = 0x00000FF3,
        ENABLE_SERVER = 0x00000FF4,
        FAIL = 0x00000FF5,
        NEWYEAR = 0x00000FF6,
        EXPBOXINFO = 0x00000F00,
        SEND_TO_CLIENT_NOTICE = 0x00000F01,
        SEND_TO_CLIENT_FILE_LIST = 0x00000F02,
        SEND_TO_SERVER_PATCH = 0x00000F03,
        SEND_TO_CLIENT_FILE = 0x00000F04,
        SEND_TO_CLIENT_PATCH = 0x00000F05,
        SEND_TO_CLIENT_PATCH_END = 0x00000F06,
        SEND_TO_CLIENT_PATCHCLIENTINFO = 0x00000F07,
        SEND_TO_SERVER_PATCHCLIENT_CORRECT = 0x00000F08,
        SEND_TO_SERVER_PATCHCLIENT_INCORRECT = 0x00000F09,
        SEND_TO_CLIENT_PATCHCLIENT = 0x00000F0A,
        SEND_TO_SERVER_REQUIRE_FILE = 0x00000F0B,
        SEND_TO_SERVER_REQUIRE_FILE_LIST = 0x00000F0C,
        SEND_TO_CLIENT_CDN = 0x00000F0D,
        SEND_TO_SERVER_EXP = 0x00000F31,
        SEND_TO_SERVER_CHANGEJOB = 0x00000F32,
        SEND_TO_SERVER_AP = 0x00000F33,
        CHANGEJOB = 0x00000F34,
        ITEM_TBL_UPDATE = 0x00000F35,
        JOIN = 0x0000FF00,
        LEAVE = 0x0000FF01,
        DESTROY_ALLPLAYERS = 0x0000FF02,
        REMOVE_ALLACCOUNTS = 0x0000FF03,
        CLOSE_ERROR = 0x0000FF04,
        PRE_JOIN = 0x0000FF05,
        GAMERATE = 0x0000FF06,
        SETMONSTERRESPAWN = 0x0000FF07,
        SETITEMEVENT = 0x0000FF08,
        LOADCONSTANT = 0x0000FF09,
        CHAT = 0x00FF0000,
        ACTMSG = 0x00FF0001,
        ADDOBJ = 0x00FF0002,
        REMOVEOBJ = 0x00FF0003,
        CONTROL = 0x00FF0004,
        BROADCAST = 0x000F0001,
        SAVEALLPLAYERS = 0x000F0002,
        DOUSESKILLPOINT = 0x000F0003,
        SKILLPOINTLOG = 0x000F0004,
        CREATEITEM = 0x00FF0005,
        MOVEITEM = 0x00FF0006,
        DROPITEM = 0x00FF0007,
        DROPGOLD = 0x00FF0008,
        REMOVEITEM = 0x00FF0009,
        SYNCITEM = 0x00FF000A,
        DOEQUIP = 0x00FF000B,
        DAMAGE = 0x00FF000C,
        SETEXPERIENCE = 0x00FF000D,
        REMOVEVENDORITEM = 0x00FF000E,
        REMOVEALLITEM = 0x00FF000F,
        MELEE_ATTACK = 0x00FF0010,
        MAGIC_ATTACK = 0x00FF0011,
        RANGE_ATTACK = 0x00FF0012,
        MOVERDEATH = 0x00FF0013,
        MELEE_ATTACK2 = 0x00FF0014,
        SHIP_ACTMSG = 0x00FF0015,
        MOTION = 0x00FF0016,
        SETFXP = 0x00FF0017,
        SETNAVIPOINT = 0x00FF0018,
        REMOVEINVENITEM = 0x00FF0019,
        USESKILL = 0x00FF0020,
        DOUSEITEM = 0x00FF0021,
        SFX_ID = 0x00FF0022,
        SETTARGET = 0x00FF0023,
        SFX_CLEAR = 0x00FF0024,
        TELESKILL = 0x00FF0025,
        REMOVEQUEST = 0x00FF0026,
        TRADECONFIRM = 0x00FF002F,
        TRADE = 0x00FF00A0,
        TRADEPUT = 0x00FF00A1,
        TRADEPULL = 0x00FF00A2,
        TRADEOK = 0x00FF00A3,
        TRADECANCEL = 0x00FF00A4,
        TRADEPUTGOLD = 0x00FF00A5,
        TRADECLEARGOLD = 0x00FF00A6,
        CONFIRMTRADE = 0x00FF00A7,
        CONFIRMTRADECANCEL = 0x00FF00A8,
        PVENDOR_OPEN = 0x00FF00A9,
        PVENDOR_CLOSE = 0x00FF00AA,
        REGISTER_PVENDOR_ITEM = 0x00FF00AB,
        QUERY_PVENDOR_ITEM = 0x00FF00AC,
        BUY_PVENDOR_ITEM = 0x00FF00AD,
        UNREGISTER_PVENDOR_ITEM = 0x00FF00AE,
        SET_HAIR = 0x00FF00AF,
        SCRIPTDLG = 0x00FF00B0,
        OPENSHOPWND = 0x00FF00B1,
        CLOSESHOPWND = 0x00FF00B2,
        BUYITEM = 0x00FF00B3,
        SELLITEM = 0x00FF00B4,
        REPAIRITEM = 0x00FF00B5,
        BUYCHIPITEM = 0x00FF00B6,
        REVIVAL = 0x00FF00C0,
        REVIVAL_TO_LODESTAR = 0x00FF00C1,
        REVIVAL_TO_LODELIGHT = 0x00FF00C2,
        SETLODELIGHT = 0x00FF00C3,
        INC_STAT_LEVEL = 0x00FF00C4,
        INC_JOB_LEVEL = 0x00FF00C5,
        ADDEXPERIENCE = 0x00FF00D0,
        SET_GROWTH_LEARNING_POINT = 0x00FF00D1,
        SFX_HIT = 0x00FF00D2,
        SETPOINTPARAM = 0x00FF00D3,
        WHISPER = 0x00FF00D4,
        ENDSKILLQUEUE = 0x00FF00D5,
        CAPTION = 0x00FF00D6,
        SAY = 0x00FF00E0,
        SHOUT = 0x00FF00E1,
        PLAYMUSIC = 0x00FF00E2,
        PLAYSOUND = 0x00FF00E3,
        SUMMONPLAYER = 0x00FF00E4,
        TELEPORTPLAYER = 0x00FF00E5,
        KILLPLAYER = 0x00FF00E6,
        GETPLAYERADDR = 0x00FF00E7,
        GETPLAYERCOUNT = 0x00FF00E8,
        GETCOREPLAYER = 0x00FF00E9,
        SYSTEM = 0x00FF00EA,
        MODIFYMODE = 0x00FF00EB,
        DEFINEDTEXT = 0x00FF00EC,
        GMSAY = 0x00FF00ED,
        CHANGEFACE = 0x00FF00EE,
        NW_WANTED_GOLD = 0x00FF00EF,
        NW_WANTED_LIST = 0x00FF00F0,
        WN_WANTED_LIST = 0x00FF00F1,
        NW_WANTED_INFO = 0x00FF00F2,
        WN_WANTED_INFO = 0x00FF00F3,
        WC_WANTED_GOLD = 0x00FF00F4,
        WC_WANTED_REWARD = 0x00FF00F5,
        CW_WANTED_LIST = 0x00FF00F6,
        CW_WANTED_REWARD = 0x00FF00F7,
        CT_WANTED = 0x00FF00F8,
        TC_LIST = 0x00FF00F9,
        REQ_LEAVE = 0x00FF00FA,
        WT_REQ_LEAVE = 0x00FF00FB,
        NW_WANTED_NAME = 0x00FF00FC,
        WN_WANTED_NAME = 0x00FF00FD,
        REPLACE = 0x00FF0F00,
        CORR_REQ = 0x00FF0FF0,
        SCRIPT_REMOVE_ALL_ITEM = 0x00FF0FF1,
        SCRIPT_EQUIP_ITEM = 0x00FF0FF2,
        SETQUEST = 0x00FF0FF3,
        SCRIPT_CREATE_ITEM = 0x00FF0FF4,
        SCRIPT_ADD_GOLD = 0x00FF0FF5,
        SCRIPT_REMOVE_QUEST = 0x00FF0FF6,
        SCRIPT_REPLACE = 0x00FF0FF7,
        SCRIPT_REPLACE_KEY = 0x00FF0FF8,
        SCRIPT_ADD_EXP = 0x00FF0FF9,
        SCRIPT_REMOVE_GOLD = 0x00FF0FFA,
        SCRIPT_TRANS_PXP = 0x00FF0FFB,
        SCRIPT_TRANS_PENYA = 0x00FF0FFC,
        CREATE_GUILDCLOAK = 0x00FF0FFD,
        LOCALPOSFROMIA = 0x00FF0FFF,
        CREATEANGEL = 0x00FFF000,
        SUMMONITEMUSE = 0x00FFF001,
        ANGELBUFF = 0x00FFF002,
        SNAPSHOT = 0xFFFFFF00,
        PLAYERMOVED = 0xFFFFFF01,
        PLAYERBEHAVIOR = 0xFFFFFF02,
        PLAYERMOVED2 = 0xFFFFFF03,
        PLAYERBEHAVIOR2 = 0xFFFFFF04,
        PLAYERCORR = 0xFFFFFF05,
        PLAYERCORR2 = 0xFFFFFF06,
        PLAYERSETDESTOBJ = 0xFFFFFF07,
        QUERYGETPOS = 0xFFFFFF08,
        GETPOS = 0xFFFFFF09,
        REMOVEAPPLETTASKBAR = 0xFFFFFF0A,
        ADDAPPLETTASKBAR = 0xFFFFFF0B,
        ADDITEMTASKBAR = 0xFFFFFF0C,
        REMOVEITEMTASKBAR = 0xFFFFFF0D,
        SKILLTASKBAR = 0xFFFFFF0E,
        MOVERDESTPOS = 0xFFFFFF0F,
        ERRORPARTY = 0xFFFFFF10,
        ADDPARTYMEMBER = 0xFFFFFF11,
        REMOVEPARTYMEMBER = 0xFFFFFF12,
        ADDPLAYERPARTY = 0xFFFFFF13,
        REMOVEPLAYERPARTY = 0xFFFFFF14,
        MEMBERLEVEL = 0xFFFFFF15,
        MEMBERJOB = 0xFFFFFF16,
        MEMBERREQUEST = 0xFFFFFF17,
        MEMBERREQUESTCANCLE = 0xFFFFFF18,
        CHANGETROUP = 0xFFFFFF19,
        CHANPARTYNAME = 0xFFFFFF1A,
        PARTYSKILLUSE = 0xFFFFFF1B,
        SETPARTYMODE = 0xFFFFFF1C,
        ADDPARTYEXP = 0xFFFFFF1E,
        REMOVEPARTYPOINT = 0xFFFFFF1F,
        PARTYCHANGEITEMMODE = 0xFFFFFF20,
        PARTYCHANGEEXPMODE = 0xFFFFFF21,
        SETPARTYEXP = 0xFFFFFF22,
        DUELREQUEST = 0xFFFFFF23,
        DUELYES = 0xFFFFFF24,
        DUELNO = 0xFFFFFF25,
        DUELPARTYREQUEST = 0xFFFFFF26,
        DUELPARTYYES = 0xFFFFFF27,
        DUELPARTYNO = 0xFFFFFF28,
        PLAYERANGLE = 0xFFFFFF29,
        SETPARTYDUEL = 0xFFFFFF2A,
        QUERYPLAYERLISTSTRING = 0xFFFFFF2B,
        MOVERFOCOUS = 0xFFFFFF2D,
        PARTYCHANGELEADER = 0xFFFFFF2F,
        GUILD = 0xFFFFFF30,
        CREATE_GUILD = 0xFFFFFF31,
        DESTROY_GUILD = 0xFFFFFF32,
        ADD_GUILD_MEMBER = 0xFFFFFF33,
        REMOVE_GUILD_MEMBER = 0xFFFFFF34,
        GUILD_INVITE = 0xFFFFFF35,
        IGNORE_GUILD_INVITE = 0xFFFFFF36,
        QUERYPLAYERSTRING = 0xFFFFFF37,
        GLOBAL_DATA = 0xFFFFFF38,
        GUILD_CHAT = 0xFFFFFF39,
        GUILD_MEMBER_LEVEL = 0xFFFFFF3A,
        GUILD_BANK_QUERY = 0xFFFFFF3B,
        GUILD_BANK = 0xFFFFFF3C,
        GUILD_BANK_UPDATE = 0xFFFFFF3D,
        GUILD_BANK_WND_CLOSE = 0xFFFFFF3E,
        GUILD_BANK_MOVEITEM = 0xFFFFFF3F,
        OPENBANKWND = 0xFFFFFF40,
        CLOSEBANKWND = 0xFFFFFF41,
        PUTITEMBACK = 0xFFFFFF42,
        PUTGOLDBACK = 0xFFFFFF43,
        GETITEMBACK = 0xFFFFFF44,
        GETGOLDBACK = 0xFFFFFF45,
        MOVEBANKITEM = 0xFFFFFF46,
        CHANGEBANKPASS = 0xFFFFFF47,
        CONFIRMBANK = 0xFFFFFF48,
        PUTBACKTOBANK = 0xFFFFFF49,
        ENVIRONMENTSNOW = 0xFFFFFF50,
        ENVIRONMENTRAIN = 0xFFFFFF51,
        FALLRAIN = 0xFFFFFF52,
        FALLSNOW = 0xFFFFFF53,
        STOPRAIN = 0xFFFFFF54,
        STOPSNOW = 0xFFFFFF55,
        ENVIRONMENTALL = 0xFFFFFF56,
        PARTYCHAT = 0xFFFFFF59,
        BLOCK = 0xFFFFFF5A,
        SAVE_SKILL = 0xFFFFFF5B,
        ADDFRIEND = 0xFFFFFF60,
        ADDFRIENDREQEST = 0xFFFFFF61,
        ADDFRIENDCANCEL = 0xFFFFFF62,
        GETFRIENDNAME = 0xFFFFFF63,
        GETFRIENDSTATE = 0xFFFFFF64,
        ADDFRIENDJOIN = 0xFFFFFF65,
        ADDFRIENDLOGOUT = 0xFFFFFF66,
        SETFRIENDSTATE = 0xFFFFFF67,
        FRIENDINTERCEPTSTATE = 0xFFFFFF68,
        FRIENDNOINTERCEPT = 0xFFFFFF69,
        REMOVEFRIEND = 0xFFFFFF6A,
        ADDFRIENDNAMEREQEST = 0xFFFFFF6B,
        ADDFRIENDNAMENOTFOUND = 0xFFFFFF6C,
        REMOVEFRIENDSTATE = 0xFFFFFF6D,
        ONEFRIEMDSTATE = 0xFFFFFF6E,
        PARTYNAME = 0xFFFFFF70,
        ADDPARTYNAME = 0xFFFFFF71,
        QUERYGETDESTOBJ = 0xFFFFFF72,
        GETDESTOBJ = 0xFFFFFF73,
        GUILD_CLASS = 0xFFFFFF74,
        GUILD_NICKNAME = 0xFFFFFF75,
        GUILD_MEMBERTIME = 0xFFFFFF76,
        GUILD_MEMBERLOGOUT = 0xFFFFFF77,
        RESURRECTION_OK = 0xFFFFFF78,
        RESURRECTION_CANCEL = 0xFFFFFF79,
        STATEMODE = 0xFFFFFF7A,
        MODE = 0xFFFFFF7B,
        CHEERING = 0xFFFFFF7C,
        EVE_RECOMMEND = 0xFFFFFF7D,
        SAVE_CONCURRENT_USER_NUMBER = 0x0F000F00,
        SAVE_CONCURRENT_FIELD_USER_NUMBER = 0x0F000F01,
        LOG_PLAY_CONNECT = 0x0F000F02,
        LOG_PLAY_DEATH = 0x0F000F03,
        LOG_LEVELUP = 0x0F000F04,
        LOG_SERVER_DEATH = 0x0F000F05,
        LOG_UNIQUEITEM = 0x0F000F06,
        LOG_ALLITEM = 0x0F000F07,
        LOG_QUEST = 0x0F000F08,
        LOG_GAMEMASTER_CHAT = 0x0F000F09,
        LOG_PK_PVP = 0x0F000F0A,
        LOG_SCHOOL = 0x0F000F0B,
        PREVENT_LOGIN = 0x0F000F0C,
        FREQUENCY_LOG = 0x0F000F0F,
        MONITOR_ID = 0xF0008000,
        CONSOLE_COMMAND = 0xF0008001,
        CONSOLE_OVERVIEW = 0xF0008002,
        CONSOLE_FILEHEADER = 0xF0008003,
        CONSOLE_FILEDATA = 0xF0008004,
        CONSOLE_UPLOADACK = 0xF0008005,
        CONSOLE_EXPAND = 0xF0008006,
        CONSOLE_SYNCACK = 0xF0008007,
        CONSOLE_EXPANDACK = 0xF0008008,
        CONSOLE_OVERVIEW2 = 0xF0008009,
        PROCESS_CREATED = 0xF0009000,
        PROCESS_TERMINATED = 0xF0009001,
        MY_PROCESS = 0xF0009002,
        CREATE_PROCESS = 0xF000A000,
        TERMINATE_PROCESS = 0xF000A001,
        TERMINATE_PROCESS_AND_QUIT = 0xF000A002,
        PROCESS_MODE = 0xF000A003,
        ADD_ACCOUNT = 0xF000B000,
        REMOVE_ACCOUNT = 0xF000B001,
        ROUTE = 0xF000B002,
        DESTROY_PLAYER = 0xF000B003,
        ERRORCODE = 0xF000B004,
        PROCESS_CREATED2 = 0xF000B005,
        PROCESS_TERMINATED2 = 0xF000B006,
        MY_PROCESS2 = 0xF0009007,
        RENEWEVNET = 0xF000B005,
        TAG = 0xF000B006,
        SENDTAG = 0xF000B007,
        INSERTTAG_RESULT = 0xF000B008,
        PARTYLEVEL = 0xF000B009,
        WC_GUILDLOGO = 0xF000B00A,
        WC_GUILDCONTRIBUTION = 0xF000B00B,
        WC_GUILDNOTICE = 0xF000B00C,
        CW_GUILDLOGO = 0xF000B00D,
        CW_GUILDCONTRIBUTION = 0xF000B00E,
        CW_GUILDNOTICE = 0xF000B00F,
        NW_GUILDLOGO = 0xF000B010,
        NW_GUILDCONTRIBUTION = 0xF000B011,
        NW_GUILDNOTICE = 0xF000B012,
        FOCUSOBJ = 0xF000B013,
        CALL_USPLOGGINGQUEST = 0xF000B014,
        CD_GUILD_LOGO = 0xF000B016,
        WD_GUILD_CONTRIBUTION = 0xF000B017,
        CD_GUILD_NOTICE = 0xF000B018,
        GUILD_BANK_WND = 0xF000B020,
        PUTITEMGUILDBANK = 0xF000B021,
        GETITEMGUILDBANK = 0xF000B022,
        GUILD_MSG_CONTROL = 0xF000B023,
        GUILD_AUTHORITY = 0xF000B026,
        GUILD_PENYA = 0xF000B027,
        GUILD_DB_REALPENYA = 0xF000B028,
        GUILD_GAMELOGIN = 0xF000B029,
        GUILD_GAMEJOIN = 0xF000B030,
        CHANGEGUILDJOBLEVEL = 0xF000B031,
        GUILD_SETNAME = 0xF000B032,
        GUILD_ERROR = 0xF000B035,
        DECL_GUILD_WAR = 0xF000B036,
        ACPT_GUILD_WAR = 0xF000B037,
        NC_ADDVOTE = 0xF000B038,
        NC_REMOVEVOTE = 0xF000B039,
        NC_CLOSEVOTE = 0xF000B03A,
        NC_CASTVOTE = 0xF000B03B,
        CD_ADDVOTE = 0xF000B03C,
        CD_REMOVEVOTE = 0xF000B03D,
        CD_CLOSEVOTE = 0xF000B03E,
        CD_CASTVOTE = 0xF000B03F,
        DC_ADDVOTERESULT = 0xF000B040,
        CW_ADDVOTERESULT = 0xF000B041,
        CW_MODIFYVOTE = 0xF000B042,
        UPDATE_GUILD_RANKING = 0xF000B043,
        UPDATE_GUILD_RANKING_END = 0xF000B044,
        UPDATE_GUILD_RANKING_DB = 0xF000B04D,
        REQUEST_GUILD_RANKING = 0xF000B04E,
        //WAR_DEAD = 0x00000000, // Incorrect value in conflict with WELCOME.
        WAR_END = 0xF000B046,
        SURRENDER = 0xF000B047,
        QUERY_TRUCE = 0xF000B048,
        ACPT_TRUCE = 0xF000B049,
        WAR_TIMEOUT = 0xF000B04A,
        WAR_MASTER_ABSENT = 0xF000B04B,
        SCHOOL_REPORT = 0xF000B04C,
        COMMERCIALELEM = 0xF000B04F,
        UPGRADEBASE = 0xF000B050,
        ENCHANT = 0xF000B024,
        PIERCING = 0xF000B025,
        PIERCING_SIZE = 0xF000D008,
        QUERYEQUIP = 0xF000D009,
        QUERYEQUIPSETTING = 0xF000D00A,
        PACHETTYPE_ITEMTRANSY = 0xF000D00C,
        RANDOMSCROLL = 0xF000D00D,
        REMVOE_ATTRIBUTE = 0xF000D00B,
        CHANGE_ATTRIBUTE = 0xF000D00E,
        UPDATEGUILDQUEST = 0xF000B051,
        BUYING_INFO = 0xF000B052,
        QUERYGUILDQUEST = 0xF000B053,
        ENTERCHTTING = 0xF000B054,
        CHATTING = 0xF000B055,
        INSERTGUILDQUEST = 0xF000B056,
        COMMONPLACE = 0xF000B057,
        OPENCHATTINGROOM = 0xF000B058,
        CLOSECHATTINGROOM = 0xF000B059,
        DELETEGUILDQUEST = 0xF000B05A,
        SERVER_ENABLE = 0xF000B05B,
        JOIN_BATTLESERVER = 0xF000D002,
        BASEGAMESETTING = 0xF000D003,
        MONSTERRESPAWNSETTING = 0xF000D004,
        MONSTERPROPGAMESETTING = 0xF000D005,
        GAMEMASTER_CHATTING = 0xF000D006,
        RELOAD_PROJECT = 0xF000D007,
        CREATESFXOBJ = 0xF000D00F,
        RETURNSCROLL = 0xF000D010,
        EVENT0913 = 0xF000D011,
        EVENT1206 = 0xF000D01A,
        EVENT = 0xF000D01B,
        ADD_GUILDCOMBAT = 0xF000D021,
        IN_GUILDCOMBAT = 0xF000D022,
        OUT_GUILDCOMBAT = 0xF000D023,
        JOIN_GUILDCOMBAT = 0xF000D024,
        RESULT_GUILDCOMBAT = 0xF000D025,
        GUILDCOMBAT_STATE = 0xF000D026,
        SELECTPLAYER_GUILDCOMBAT = 0xF000D027,
        REQUEST_STATUS = 0xF000D028,
        REMOVEPARTY_GUILDCOMBAT = 0xF000D029,
        ADDPARTY_GUILDCOMBAT = 0xF000D02A,
        SELECTMAP_GUILDCOMBAT = 0xF000D02B,
        START_GUILDCOMBAT = 0xF000D02C,
        GETPENYAGUILD_GUILDCOMBAT = 0xF000D02D,
        GETPENYAPLAYER_GUILDCOMBAT = 0xF000D02E,
        GETITEM_GUILDCOMBAT = 0xF000D02F,
        TELE_GUILDCOMBAT = 0xF000D030,
        PLAYERPOINT_GUILDCOMBAT = 0xF000D031,
        CONTINUE_GUILDCOMBAT = 0xF000D032,
        SUMMON_FRIEND = 0xF000E001,
        SUMMON_FRIEND_CONFIRM = 0xF000E002,
        SUMMON_PARTY = 0xF000E003,
        SUMMON_PARTY_CONFIRM = 0xF000E004,
        SUMMON_FRIEND_CANCEL = 0xF000E005,
        CHG_MASTER = 0xF000F000,
        GLOBALGIFTBOX = 0xF000F001,
        QUERYGLOBALGIFTBOX = 0xF000F002,
        RESTOREGLOBALGIFTBOX = 0xF000F003,
        QUERY_REMOVE_GUILD_BANK_TBL = 0xF000F004,
        EVENT_GENERIC = 0xF000F005,
        EVENT_FLAG = 0xF000F006,
        CALL_XXX_MULTI_SERVER = 0xF000F007,
        CTRL_COOLTIME_CANCEL = 0xF000F008,
        LOG_EXPBOX = 0xF000F009,
        TRAFIC_LOG = 0xF000F00A,
        KAWIBAWIBO_START = 0xF000F100,
        KAWIBAWIBO_GETITEM = 0xF000F101,
        REASSEMBLE_START = 0xF000F102,
        REASSEMBLE_OPENWND = 0xF000F103,
        ALPHABET_OPENWND = 0xF000F104,
        ALPHABET_START = 0xF000F105,
        FIVESYSTEM_OPENWND = 0xF000F106,
        FIVESYSTEM_DESTROYWND = 0xF000F107,
        FIVESYSTEM_BET = 0xF000F108,
        FIVESYSTEM_START = 0xF000F109,
        ULTIMATE_MAKEITEM = 0xF000F110,
        ULTIMATE_MAKEGEM = 0xF000F111,
        ULTIMATE_TRANSWEAPON = 0xF000F112,
        ULTIMATE_ENCHANTWEAPON = 0xF000F113,
        ULTIMATE_SETGEM = 0xF000F114,
        ULTIMATE_REMOVEGEM = 0xF000F115,
        EXCHANGE = 0xF000F116,
        EVENTLUA_STATE = 0xF000F117,
        EVENTLUA_CHANGED = 0xF000F118,
        EVENTLUA_NEEDSTATE = 0xF000F119,
        EVENTLUA_NOTICE = 0xF000F120,
        LEGENDSKILLUP_START = 0xF000F500,
        MODIFY_STATUS = 0xF000F501,
        PET_RELEASE = 0xF000F600,
        USE_PET_FEED = 0xF000F601,
        PET_TAMER_MISTAKE = 0xF000F602,
        PET_TAMER_MIRACLE = 0xF000F603,
        FEED_POCKET_INACTIVE = 0xF000F604,
        MAKE_PET_FEED = 0xF000F605,
        CALL_USP_PET_LOG = 0xF000F606,
        GC1TO1_TENDEROPENWND = 0xF000F700,
        GC1TO1_TENDERVIEW = 0xF000F701,
        GC1TO1_TENDER = 0xF000F702,
        GC1TO1_TENDERCANCEL = 0xF000F703,
        GC1TO1_OPEN = 0xF000F704,
        GC1TO1_MEMBERLINEUPOPENWND = 0xF000F705,
        GC1TO1_MEMBERLINEUP = 0xF000F706,
        GC1TO1_TELEPORTTONPC = 0xF000F707,
        GC1TO1_TELEPORTTOSTAGE = 0xF000F708,
        GC1TO1_TENDERFAILED = 0xF000F709,
        GC1TO1_STATETODB = 0xF000F710,
        GC1TO1_TENDERTODB = 0xF000F711,
        GC1TO1_TENDERTOSRVR = 0xF000F712,
        GC1TO1_LINEUPTODB = 0xF000F713,
        GC1TO1_WARPERSONTODB = 0xF000F714,
        GC1TO1_WARGUILDTODB = 0xF000F715,
        QUERY_START_COLLECTING = 0xF000F800,
        QUERY_STOP_COLLECTING = 0xF000F801,
        QUERY_PLAYER_DATA = 0xF000F802,
        ALL_PLAYER_DATA = 0xF000F803,
        ADD_PLAYER_DATA = 0xF000F804,
        DELETE_PLAYER_DATA = 0xF000F805,
        QUERY_PLAYER_DATA2 = 0xF000F807,
        UPDATE_PLAYER_DATA = 0xF000F808,
        PIERCINGREMOVE = 0xF000F809,
        GUILDLOG_VIEW = 0xF000F810,
        SEALCHAR_REQ = 0xF000F811,
        SEALCHARCONM_REQ = 0xF000F812,
        NPC_BUFF = 0xF000F813,
        SEALCHARGET_REQ = 0xF000F814,
        SEALCHARSET_REQ = 0xF000F815,
        ADD_MESSENGER = 0x70000000,
        DELETE_MESSENGER = 0x70000001,
        UPDATE_MESSENGER = 0x70000002,
        ERROR_STRING = 0x70000003,
        DO_USE_ITEM_TARGET = 0x70000004,
        REMOVE_ITEM_LEVEL_DOWN = 0x70000005,
        AVAIL_POCKET = 0x70000006,
        MOVE_ITEM_POCKET = 0x70000007,
        AWAKENING = 0x70000008,
        QUE_PETRESURRECTION = 0x70000009,
        BLESSEDNESS_CANCEL = 0x7000000A,
        LOGOUT = 0x7000000B,
        ARENA_ENTER = 0x70000010,
        ARENA_EXIT = 0x70000011,
        SECRETROOM_TENDER = 0x70000100,
        SECRETROOM_LINEUPMEMBER = 0x70000101,
        SECRETROOM_TENDEROPENWND = 0x70000102,
        SECRETROOM_LINEUPOPENWND = 0x70000103,
        SECRETROOM_ENTRANCE = 0x70000104,
        SECRETROOM_TELEPORTTONPC = 0x70000105,
        SECRETROOM_TENDERVIEW = 0x70000106,
        SECRETROOM_TENDERCANCELRETURN = 0x70000107,
        SECRETROOM_TENDER_INSERTTODB = 0x70000108,
        SECRETROOM_TENDER_UPDATETODB = 0x70000109,
        SECRETROOM_LINEUP_INSERTTODB = 0x70000110,
        SECRETROOM_INFO_CLEAR = 0x70000111,
        SECRETROOM_TENDERINFO_TO_WSERVER = 0x70000112,
        SECRETROOM_CLOSED = 0x70000113,
        SECRETROOM_TELEPORTTODUNGEON = 0x70000114,
        TAX_ALLINFO = 0x70001000,
        TAX_SET_SECRETROOM_WINNER = 0x70001001,
        TAX_SET_LORD = 0x70001002,
        TAX_SET_TAXRATE = 0x70001003,
        TAX_ADDSALESTAX = 0x70001004,
        TAX_ADDPURCHASEAX = 0x70001005,
        TAX_ADDTAX = 0x70001006,
        TAX_APPLY_TAXRATE_NOW = 0x70001007,
        HEAVENTOWER_TELEPORT = 0x70001008,
        RAINBOWRACE_PREVRANKING_OPENWND = 0x70002000,
        RAINBOWRACE_APPLICATION_OPENWND = 0x70002001,
        RAINBOWRACE_APPLICATION = 0x70002002,
        RAINBOWRACE_MINIGAME_PACKET = 0x70002003,
        RAINBOWRACE_REQ_FINISH = 0x70002004,
        RAINBOWRACE_LOADDBTOWORLD = 0x70002005,
        RAINBOWRACE_APPTODB = 0x70002006,
        RAINBOWRACE_FAILEDTODB = 0x70002007,
        RAINBOWRACE_RANKINGTODB = 0x70002008,
        HOUSING_LOADINFO = 0x70003000,
        HOUSING_FURNITURELIST = 0x70003001,
        HOUSING_SETUPFURNITURE = 0x70003002,
        HOUSING_DBFAILED = 0x70003003,
        HOUSING_VISITROOM = 0x70003004,
        HOUSING_SETVISITALLOW = 0x70003005,
        HOUSING_REQVISITABLELIST = 0x70003006,
        HOUSING_GOOUT = 0x70003007,
        HOUSING_GM_REMOVEALL = 0x70003008,
        HONOR_LIST_REQ = 0x70004000,
        HONOR_CHANGE_REQ = 0x70004001,
        LOG_GETHONORTIME = 0x70004002,
        QUESTHELPER_REQNPCPOS = 0x70005000,
        FUNNYCOIN_REQ_USE = 0x70006000,
        FUNNYCOIN_ACK_USE = 0x70006001,
        PCBANG_SETAPPLY = 0x70006010,
        TIMELIMIT_INFO = 0x70006020,
        TIMELIMIT_UPDATE = 0x70006021,
        TIMELIMIT_RESET = 0x70006022,
        SMELT_SAFETY = 0x70007000,
        ELECTION_ADD_DEPOSIT = 0x8FFF0000,
        ELECTION_SET_PLEDGE = 0x8FFF0001,
        ELECTION_INC_VOTE = 0x8FFF0002,
        ELECTION_BEGIN_CANDIDACY = 0x8FFF0003,
        ELECTION_BEGIN_VOTE = 0x8FFF0004,
        ELECTION_END_VOTE = 0x8FFF0005,
        ELECTION_PROCESS = 0x8FFF0006,
        LORD = 0x8FFF0007,
        L_EVENT_CREATE = 0x8FFF0008,
        LORD_SKILL_USE = 0x8FFF0009,
        L_EVENT_INITIALIZE = 0x8FFF000A,
        LORD_SKILL_TICK = 0x8FFF000B,
        L_EVENT_TICK = 0x8FFF000C,
        TRANSFORM_ITEM = 0x8FFF000D,
        TUTORIAL_STATE = 0x8FFF000E,
        PICKUP_PET_AWAKENING_CANCEL = 0x8FFF000F,
        OPTION_ENABLE_RENDER_MASK = 0x8FFF0010,
        DO_USE_ITEM_INPUT = 0x8FFFFF00,
        CLEAR_PET_NAME = 0x8FFFFF01,
        PROPOSE = 0x8FFFF000,
        REFUSE = 0x8FFFF001,
        COUPLE = 0x8FFFF002,
        DECOUPLE = 0x8FFFF003,
        ALL_COUPLES = 0x8FFFF004,
        CLEAR_PROPOSE = 0x8FFFF005,
        ADD_COUPLE_EXPERIENCE = 0x8FFFF006,
        INSTANCEDUNGEON_ALLINFO = 0x00001000,
        INSTANCEDUNGEON_CREATE = 0x00001001,
        INSTANCEDUNGEON_DESTROY = 0x00001002,
        INSTANCEDUNGEON_SETCOOLTIME = 0x00001003,
        INSTANCEDUNGEON_DELETECOOLTIME = 0x00001005,
        INSTANCEDUNGEON_LOG = 0x0F001100,
        MAP_KEY = 0xFFFFF000,
        QUIZ_CHANGED = 0xFF000000,
        QUIZ_STATE = 0xFF000001,
        QUIZ_NOTICE = 0xFF000002,
        QUIZ_ENTRANCE = 0xFF000003,
        QUIZ_TELEPORT = 0xFF000004,
        QUIZ_LOADQUIZ = 0xFF000005,
        QUIZ_PRIZEITEM = 0xFF000006,
        QUIZ_SELECT = 0xFF000007,
        QUIZ_OPEN = 0xFF000008,
        VISPET_REMOVEVIS = 0x88000000,
        VISPET_SWAPVIS = 0x88000001,
        GUILDHOUSE_LOAD = 0x88100000,
        GUILDHOUSE_BUY = 0x88100001,
        GUILDHOUSE_REMOVE = 0x88100002,
        GUILDHOUSE_PACKET = 0x88100003,
        GUILDHOUSE_ALLINFO = 0x88100004,
        GUILDHOSUE_RESTPOINT = 0x88100005,
        GUILDHOUSE_ENTER = 0x88100006,
        GUILDHOUSE_GOOUT = 0x88100007,
        GUILDFURNITURE_LOG = 0x88100008,
        TELEPORTER = 0x88100100,
        QUEST_CHECK = 0x88100110,
        CAMPUS_ALL = 0x88100120,
        CAMPUS_INVITE = 0x88100121,
        CAMPUS_ACCEPT = 0x88100122,
        CAMPUS_REFUSE = 0x88100123,
        CAMPUS_ADD_MEMBER = 0x88100124,
        CAMPUS_REMOVE_MEMBER = 0x88100125,
        CAMPUS_UPDATE_POINT = 0x88100126,
        LOGIN_PROTECT_NUMPAD = 0x88100200,
        LOGIN_PROTECT_CERT = 0x88100201,
        ERROR_LOG_TO_DB = 0x88100210,
        COLLECTION_CERTIFY = 0x88100220,
        ITEM_SELECT_AWAKENING_VALUE = 0x88100221,
        GUILDHOUSE_TENDER_MAINWND = 0x88100230,
        GUILDHOUSE_TENDER_INFOWND = 0x88100231,
        GUILDHOUSE_TENDER_INFO = 0x88100232,
        GUILDHOUSE_TENDER_JOIN = 0x88100233,
        GUILDHOUSE_TENDER_STATE = 0x88100234,
        GUILDHOUSE_TENDER_RESULT = 0x88100235,
        GUILDHOUSE_GRADE_UPDATE = 0x88100236,
        GUILDHOUSE_LEVEL_UPDATE = 0x88100237,
        GUILDHOUSE_EXPIRED = 0x88100238,
        QUERYMAILBOX_REQ = 0x88100240,
        QUERYMAILBOX_COUNT = 0x88100241,
    }
}
