using System;
using System.IO;
using System.Windows.Forms;

using FujiXerox.ApeosWare.PM.Ondemand.Log;
using FujiXerox.NPP.Infra;

namespace FujiXerox.ApeosWare.PM.Ondemand
{
    /// <summary>
    /// 設定情報定義クラス
    /// </summary>
    public class Configs
    {
		// Add Test Comments aaaa
		
        /// <summary>
        /// アプリケーションディレクトリ
        /// </summary>
        public static readonly string APP_DIR = System.Environment.CurrentDirectory;

        /// <summary>
        /// レジストリ基本キー
        /// </summary>
        public static readonly string REG_BASE_KEY = @"SOFTWARE\Fuji Xerox\ApeosWare Management Suite\AWPM On Demand Print Terminal";

        /// <summary>
        /// 用紙単価CSVファイルパス
        /// </summary>
        public static readonly string PAPER_PRICE_CSV_FILE_PATH = @"conf\USBTollGatePaperPrice.csv";

        /// <summary>
        /// 環境設定ファイルパス
        /// </summary>
        public static readonly string ONDEMAND_INI_FILE_PATH = @"conf\AwpmOndemandPCSetting.ini";

        /// <summary>
        /// npp設定ファイルパス
        /// </summary>
        public static readonly string NPP_INI_FILE_PATH = @"conf\AwpmOndemandPC.ini";

        /// <summary>
        /// Log4net設定ファイルパス
        /// </summary>
        public static readonly string LOG4NET_INI_FILE_PATH = @"conf\AwpmOndemandPC-log4net.xml";

        /// <summary>
        /// 画像イメージ格納フォルダー
        /// </summary>
        public static readonly string IMAGE_DIR_PATH = @"conf\img";

        /// <summary>
        /// Exodusライブラリ格納フォルダー
        /// </summary>
        public static readonly string EXODUS_LIB_DIR = Path.Combine(APP_DIR, @"lib\exodus");

        /// <summary>
        /// PDFライブラリ格納フォルダー
        /// </summary>
        public static readonly string PDF_LIB_DIR = Path.Combine(APP_DIR, @"lib\pdf");

        /// <summary>
        /// PDFライブラリ実行体パス
        /// </summary>
        public static readonly string PDF_EXE_PATH = Path.Combine(APP_DIR, @"lib\pdf\cbridge_dh.exe");

        /// <summary>
        /// プラグイン格納フォルダー
        /// </summary>
        public static readonly string PLUGIN_DLL_DIR = @"plugins";

        /// <summary>
        /// サーバー情報監視間隔(ミリ秒)
        /// </summary>
        public static int SERVER_INFO_WATCH_INTERVAL = 20000;

        /// <summary>
        /// サーバー情報取得後の監視間隔(ミリ秒)
        /// </summary>
        public static int SERVER_INFO_GET_AFTER_WATCH_INTERVAL = 60000;

        /// <summary>
        /// プリンター状態監視間隔(ミリ秒)
        /// </summary>
        public static int PRINTER_STATUS_WATCH_INTERVAL = 20000;

        /// <summary>
        /// プラグイン開始タイマー(ミリ秒)
        /// </summary>
        public static int PLUGIN_START_INTERVAL = 20000;
    }
}
