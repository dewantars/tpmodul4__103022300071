﻿using System;

namespace tpmodul4__103022300071
{
    public class KodePos
    {
        public enum Kelurahan
        {
            Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja
        }

        public static string GetKodePos(Kelurahan kelurahan)
        {
            string[] kodePosTable = {
                "40266", 
                "40287", 
                "40267", 
                "40256", 
                "40287", 
                "40286", 
                "40286", 
                "40286", 
                "40272", 
                "40274", 
                "40273"  
            };
            return kodePosTable[(int)kelurahan];
        }

    }
}
