using UnityEngine;

namespace EXMaid
{
    public class EXLog
    {
        static string AppendExMark(string msg) => $"[EXMaid] {msg}";

        public static void Log(string msg)
        {
            msg = AppendExMark(msg);
            Debug.Log(msg);
        }
        
        public static void Warning(string msg)
        {
            msg = AppendExMark(msg);
            Debug.LogWarning(msg);
        }
        
        public static void Error(string msg)
        {
            msg = AppendExMark(msg);
            Debug.LogError(msg);
        }
    }
}