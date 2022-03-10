﻿using System;

namespace interface_arayüz
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger filelogger = new FileLogger();
            filelogger.writeLog();
            SmsLogger smslogger = new SmsLogger();
            smslogger.writeLog();
            DatabaseLogger databaselogger = new DatabaseLogger();
            databaselogger.writeLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.writeLog();
        }
    }
}
